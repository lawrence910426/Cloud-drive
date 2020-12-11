


Imports System.Threading.ReaderWriterLock
Public Class Form1
    Dim lastOk As Int32
    Dim Findthread As Threading.Thread
    Dim Webthread As Threading.Thread
    Dim sendText As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '   Dim AAA(1) As String
        '   Dim d() As String = AAA
        '  My.Computer.FileSystem.GetFiles("D:\").CopyTo(d, 0)
        '    My.Computer.FileSystem.GetDirectories("D:\").CopyTo(d, d.LongLength)
        '  Dim c(1000) As String
        ' My.Computer.FileSystem.GetFiles("C:\").CopyTo(c, 0)
        '  Dim f(1000) As String
        '  Try
        '    My.Computer.FileSystem.GetFiles("F:\").CopyTo(f, 0)
        '    Catch
        '  End Try
        '  For Each i As String In d
        'MsgBox(i)
        '  Next

        ' thread = New Thread(AddressOf WebBrowser1_DocumentCompleted)
        'WebBrowser1.Navigate("https://member.xuite.net/HiReg/checkcookieservlet?version=1.0&curl=http://xuite.net/members/authorize.php&siteid=50032&sessionid=&channelurl=YmFzZTY0QnlBZG1pbi1odHRwOi8veHVpdGUubmV0L21lbWJlcnMvbWluaUxvZ2luLnBocD9maW5hbD1odHRwJTNBJTJGJTJGeHVpdGUubmV0JTJGJmluZGV4PTE=&others=&checksum=8893ec0e6bc3933167baaa2e11d1021c&formtype=&service_type=uid&finish_channelurl=http%3A%2F%2Fxuite.net%2F%3Fnewbie%3D1")
    End Sub
    Dim nowUrl As String
    Private Sub WebBrowser1_DocumentCompleted() Handles WebBrowser1.DocumentCompleted
        Randomize()
        ' RichTextBox1.Text = WebBrowser1.Document.Url.ToString)
        If WebBrowser1.Url.ToString = "https://member.xuite.net/HiReg/checkcookieservlet?version=1.0&curl=http://xuite.net/members/authorize.php&siteid=50032&sessionid=&channelurl=YmFzZTY0QnlBZG1pbi1odHRwOi8veHVpdGUubmV0L21lbWJlcnMvbWluaUxvZ2luLnBocD9maW5hbD1odHRwJTNBJTJGJTJGeHVpdGUubmV0JTJGJmluZGV4PTE=&others=&checksum=8893ec0e6bc3933167baaa2e11d1021c&formtype=&service_type=uid&finish_channelurl=http://xuite.net/?newbie=1" Then
            WebBrowser1.Document.GetElementById("uid").SetAttribute("value", "er8888")
            WebBrowser1.Document.GetElementById("pw").SetAttribute("value", "er8888")
            WebBrowser1.Document.GetElementById("form1").InvokeMember("submit")
            'the loginbutton have id but i can't get it
            'just like pw ,not visible ,inbinvinsity
            'WebBrowser1.Document.GetElementById("ms_id1") '.SetAttribute("value", " 'ps' ")
            '  WebBrowser1.Document.
            'WebBrowser1.Document.GetElementById("login").SetAttribute("height", "90")

            'shell("D:\aaa.htm")
            'don't"" xuite yet
            ' load("http://blog.xuite.net/_my2/join_step1.phtml", 7)
            Timer1.Enabled = True

        ElseIf WebBrowser1.Url.ToString = "http://blog.xuite.net/_my2/join_step1.phtml" Then
            WebBrowser1.Document.GetElementById("blogUrl").SetAttribute("value", "1234567890" + Int(Rnd(5555256) * 90)) '1234567890
            WebBrowser1.Document.GetElementById("title").SetAttribute("value", "樂利國小") '
            WebBrowser1.Document.GetElementById("description").SetAttribute("value", "關於樂利") '
            '
            WebBrowser1.Document.GetElementById("btn_submit").InvokeMember("onclick")
            Timer2.Enabled = True



        End If
        If WebBrowser1.Url.ToString = "http://blog.xuite.net/_my2/article_post.phtml?bid=" & Str(lastOk) & "#" Then
            WebBrowser1.Document.GetElementById("title").SetAttribute("value", "白色斗篷下的黑暗") '樂利國小的老師們
            WebBrowser1.Document.GetElementById("tinymce").SetAttribute("value", sendText) 'enter = 13

            WebBrowser1.Document.GetElementById("btn_publish").InvokeMember("onclick")
            End
        End If





    End Sub

    Dim time As Short


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        time += 1
        If time = 10 Then
            WebBrowser1.Navigate("http://blog.xuite.net/_my2/join_step1.phtml")
            Timer1.Enabled = False
            time = 0
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        time += 1
        If time = 5 Then
            '   WebBrowser1.Document.GetElementById("icon_blognew").InvokeMember("onClick")


            ' WebBrowser1.Document.GetElementById("icon_del").GetAttribute("onclick")
            time = 0
            Timer3.Enabled = True
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        time += 1
        If time = 5 Then
            '   WebBrowser1.Document.GetElementById("icon_blognew").InvokeMember("onClick")


            '4000000
            search()
            'http://blog.xuite.net/_my2/article_post.phtml?bid=3777496
            'WebBrowser1.Document.GetElementById("icon_blognew").InvokeMember("onclick")
            Timer3.Enabled = False

            time = 0
        End If
    End Sub

    'Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick

    '    Timer4.Enabled = False
    '    time += 1
    '    If time = 5 Then
    '        WebBrowser1.Document.GetElementById("title").SetAttribute("value", "blablabla") '樂利國小的老師們
    '        WebBrowser1.Document.GetElementById("tinymce").SetAttribute("value", "blablabla") 'enter = 13

    '        WebBrowser1.Document.GetElementById("btn_publish").InvokeMember("onclick")




    '        Timer4.Enabled = False
    '        time = 0
    '    End If
    'End Sub

    Private Sub search()

        For i = 3775000 To 4000000 Step 1 '225000
            Try
                WebBrowser1.Document.GetElementById(Str(i)).SetAttribute("class", "sss")
            Catch
                lastOk = i
            End Try
        Next
        nowUrl = "http://blog.xuite.net/_my2/article_post.phtml?bid=" & Str(lastOk) & "#"
        WebBrowser1.Navigate("http://blog.xuite.net/_my2/article_post.phtml?bid=" & Str(lastOk) & "#")
        ' WebBrowser1.Document.GetElementById("title").SetAttribute("value", "blablabla") '樂利國小的老師們
        'WebBrowser1.Document.GetElementById("tinymce").SetAttribute("value", "blablabla") 'enter = 13
        Webthread = New Threading.Thread(AddressOf WebBrowser1_DocumentCompleted)
        Webthread.IsBackground = True
        Webthread.Start()
        Findthread.Abort()
        'WebBrowser1.Document.GetElementById("btn_publish").InvokeMember("onclick")
        '
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a As Object = Nothing
        Dim b As Windows.Forms.WebBrowserDocumentCompletedEventArgs = Nothing

        Findthread = New Threading.Thread(AddressOf search)

        Findthread.IsBackground = True
        '  WebBrowser1.Navigate("https://member.xuite.net/HiReg/checkcookieservlet?version=1.0&curl=http://xuite.net/members/authorize.php&siteid=50032&sessionid=&channelurl=YmFzZTY0QnlBZG1pbi1odHRwOi8veHVpdGUubmV0L21lbWJlcnMvbWluaUxvZ2luLnBocD9maW5hbD1odHRwJTNBJTJGJTJGeHVpdGUubmV0JTJGJmluZGV4PTE=&others=&checksum=8893ec0e6bc3933167baaa2e11d1021c&formtype=&service_type=uid&finish_channelurl=http%3A%2F%2Fxuite.net%2F%3Fnewbie%3D1")
        Findthread.Start()
        Form2.Visible = True


        Dim z As String = Nothing

        Dim x As Integer = Nothing
        x = z





    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Visible = False
    End Sub

    Private Sub WebBrowser2_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser2.DocumentCompleted
        'sendText = Chr(WebBrowser2.Document.GetElementById("banner").GetAttribute("class"))






    End Sub
End Class
'https://member.xuite.net/HiReg/checkcookieservlet?version=1.0&curl=http://xuite.net/members/authorize.php&siteid=50032&sessionid=&channelurl=YmFzZTY0QnlBZG1pbi1odHRwOi8veHVpdGUubmV0L21lbWJlcnMvbWluaUxvZ2luLnBocD9maW5hbD1odHRwcyUzQSUyRiUyRm1lbWJlci54dWl0ZS5uZXQlMkZIaVJlZyUyRmNoZWNrY29va2llc2VydmxldCUzRnZlcnNpb24lM0QxLjAlMjZjdXJsJTNEaHR0cCUzQSUyRiUyRmJsb2cueHVpdGUubmV0JTJGX21lbWJlcnMlMkZBdXRob3JpemUucGhwJTI2c2l0ZWlkJTNENTAwMTUlMjZzZXNzaW9uaWQlM0QlMjZjaGFubmVsdXJsJTNEaHR0cCUzQSUyRiUyRmJsb2cueHVpdGUubmV0JTJGJTI2b3RoZXJzJTNEJTI2Y2hlY2tzdW0lM0Q2MGQ5N2E0ODRmZGYwY2Y2YmRhODY5NTIyNjdhZGQ5NyZpbmRleD0x&others=&checksum=22e027ff80611beca119a819715e0966&formtype=&service_type=uid&finish_channelurl=http%3A%2F%2Fxuite.net%2F%3Fnewbie%3D1