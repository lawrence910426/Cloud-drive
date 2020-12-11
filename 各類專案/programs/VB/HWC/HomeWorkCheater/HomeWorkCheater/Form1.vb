

Imports System.Text

Imports System.Threading
Imports System.Net
Imports System.Net.Sockets












Public Class Form1
    'Public gotChkMsgYet As Boolean = False




    Dim howmuch_smalls As Byte
    Dim search(10) As String
    Dim Add(10, 0) As String
    Dim AddHowMuch As Byte

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'WebBrowser1.Navigate("https://member.xuite.net/HiReg/checkcookieservlet?version=1.0&curl=http://xuite.net/members/authorize.php&siteid=50032&sessionid=&channelurl=YmFzZTY0QnlBZG1pbi1odHRwOi8veHVpdGUubmV0L21lbWJlcnMvbWluaUxvZ2luLnBocD9maW5hbD1odHRwJTNBJTJGJTJGeHVpdGUubmV0JTJGJmluZGV4PTE=&others=&checksum=8893ec0e6bc3933167baaa2e11d1021c&formtype=&service_type=uid&finish_channelurl=http%3A%2F%2Fxuite.net%2F%3Fnewbie%3D1")
        Module1.list = New Thread(AddressOf listenServer)
        Module1.start()
        LinkLabel10.Text = "新增6小題"
        LinkLabel9.Text = "新增5小題"
        LinkLabel8.Text = "新增4小題"
        LinkLabel7.Text = "新增3小題"
        LinkLabel6.Text = "新增小小題"
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'using visible=1 or 0
        If howmuch_smalls = 5 Then
            Button2.Enabled = False
        Else
            howmuch_smalls += 1
            Select Case howmuch_smalls
                Case 1
                    Label6.Text = "小小題"
                    '
                    ComboBox6.Visible = True
                    LinkLabel6.Visible = True
                    Label6.Visible = True
                    Button2.Text = LinkLabel7.Text
                Case 2
                    LinkLabel7.Visible = True
                    Label7.Visible = True
                    Label7.Text = "3小題"
                    '
                    ComboBox7.Visible = True
                    Button2.Text = LinkLabel8.Text
                Case 3
                    LinkLabel8.Visible = True
                    Label8.Visible = True
                    Label8.Text = "4小題"
                    ' 
                    ComboBox8.Visible = True
                    Button2.Text = LinkLabel9.Text
                Case 4
                    LinkLabel9.Visible = True
                    Label9.Visible = True
                    Label9.Text = "5小題"
                    '   
                    ComboBox9.Visible = True
                    Button2.Text = LinkLabel10.Text
                Case 5
                    Label10.Text = "6小題"
                    '  
                    LinkLabel10.Visible = True
                    Label10.Visible = True
                    ComboBox10.Visible = True
            End Select
        End If
    End Sub
#Region "objs"



















    'searches
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        search(1) = ComboBox1.Text

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

        search(2) = ComboBox2.Text

    End Sub




    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        search(3) = ComboBox3.Text
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        search(4) = ComboBox4.Text
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox5.SelectedIndexChanged
        search(5) = ComboBox5.Text
    End Sub



    Private Sub ComboBox6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox6.SelectedIndexChanged
        search(6) = ComboBox6.Text
    End Sub

    Private Sub ComboBox7_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox7.SelectedIndexChanged
        search(7) = ComboBox7.Text
    End Sub

    Private Sub ComboBox8_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox8.SelectedIndexChanged
        search(8) = ComboBox8.Text
    End Sub

    Private Sub ComboBox9_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox9.SelectedIndexChanged
        search(9) = ComboBox9.Text
    End Sub

    Private Sub ComboBox10_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox10.SelectedIndexChanged
        search(10) = ComboBox10.Text
    End Sub
#End Region
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'send to module
        Module1.Search(search(1), search(2), search(2), search(3), search(4), search(5), search(6), search(7), search(8), search(10))
    End Sub
#Region "add"
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If LinkLabel1.Text <> "確定" Then
            LinkLabel1.Text = "確定"
            ComboBox1.Visible = False
            TextBox1.Visible = True
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
        Else
            ComboBox1.Items.Add(TextBox1.Text)
            TextBox1.Visible = False
            ComboBox1.Visible = True
            LinkLabel1.Text = "增加科目"
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        If LinkLabel2.Text <> "確定" Then
            LinkLabel2.Text = "確定"
            ComboBox1.Visible = False
            TextBox1.Visible = True
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
        Else
            ComboBox1.Items.Add(TextBox1.Text)
            TextBox1.Visible = False
            ComboBox1.Visible = True
            LinkLabel2.Text = "增加科目"
        End If
    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        If LinkLabel3.Text <> "確定" Then
            LinkLabel3.Text = "確定"
            ComboBox1.Visible = False
            TextBox1.Visible = True
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
        Else
            ComboBox1.Items.Add(TextBox1.Text)
            TextBox1.Visible = False
            ComboBox1.Visible = True
            LinkLabel3.Text = "增加科目"
        End If
    End Sub

    Private Sub LinkLabel4_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        If LinkLabel4.Text <> "確定" Then
            LinkLabel4.Text = "確定"
            ComboBox1.Visible = False
            TextBox1.Visible = True
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
        Else
            ComboBox1.Items.Add(TextBox1.Text)
            TextBox1.Visible = False
            ComboBox1.Visible = True
            LinkLabel4.Text = "增加科目"
        End If
    End Sub

    Private Sub LinkLabel5_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        If LinkLabel5.Text <> "確定" Then
            LinkLabel5.Text = "確定"
            ComboBox1.Visible = False
            TextBox1.Visible = True
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
        Else
            ComboBox1.Items.Add(TextBox1.Text)
            TextBox1.Visible = False
            ComboBox1.Visible = True
            LinkLabel5.Text = "增加科目"
        End If
    End Sub

    Private Sub LinkLabel6_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        If LinkLabel6.Text <> "確定" Then
            LinkLabel6.Text = "確定"
            ComboBox8.Visible = False
            TextBox1.Visible = True
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
        Else
            ComboBox1.Items.Add(TextBox1.Text)
            TextBox1.Visible = False
            ComboBox1.Visible = True
            LinkLabel6.Text = "增加科目"
        End If
    End Sub

    Private Sub LinkLabel7_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel7.LinkClicked
        If LinkLabel7.Text <> "確定" Then
            LinkLabel7.Text = "確定"
            ComboBox1.Visible = False
            TextBox1.Visible = True
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
        Else
            ComboBox1.Items.Add(TextBox1.Text)
            TextBox8.Visible = False
            ComboBox8.Visible = True
            LinkLabel7.Text = "增加科目"
        End If
    End Sub

    Private Sub LinkLabel8_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel8.LinkClicked
        If LinkLabel8.Text <> "確定" Then
            LinkLabel8.Text = "確定"
            ComboBox1.Visible = False
            TextBox1.Visible = True
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
        Else
            ComboBox1.Items.Add(TextBox1.Text)
            TextBox8.Visible = False
            ComboBox8.Visible = True
            LinkLabel8.Text = "增加科目"
        End If
    End Sub

    Private Sub LinkLabel9_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel9.LinkClicked
        If LinkLabel9.Text <> "確定" Then
            LinkLabel9.Text = "確定"
            ComboBox1.Visible = False
            TextBox1.Visible = True
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
        Else
            ComboBox1.Items.Add(TextBox1.Text)
            TextBox1.Visible = False
            ComboBox1.Visible = True
            LinkLabel9.Text = "增加科目"
        End If
    End Sub









    Private Sub LinkLabel10_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel10.LinkClicked
        If LinkLabel10.Text <> "確定" Then
            LinkLabel10.Text = "確定"
            ComboBox10.Visible = False
            TextBox10.Visible = True
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
        Else
            ComboBox1.Items.Add(TextBox1.Text)
            TextBox10.Visible = False
            ComboBox10.Visible = True
            LinkLabel10.Text = "增加科目"
        End If
    End Sub
#End Region
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click



    End Sub
    'Private Sub checkTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkTime.Tick

    '    If gotChkMsgYet = False Then
    '        Module1.reSend()
    '    Else
    '        gotChkMsgYet = False
    '        checkTime.Enabled = False
    '    End If


    'End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Module1.online()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

    End Sub
End Class

Module Module1
    Public list As Thread
    Dim listener As New TcpListener(New IPEndPoint(IPAddress.Parse(Getip()), 36000))
    Sub start()
        list = New Thread(AddressOf listenServer)
        list.TrySetApartmentState(ApartmentState.STA)
        list.Priority = ThreadPriority.Highest
        list.Start()
    End Sub


    Function Getip()
        Dim ips As String = Nothing
        Dim ip() As IPAddress = Dns.GetHostEntry(Dns.GetHostName).AddressList
        For Each it In ip
            If it.AddressFamily = AddressFamily.InterNetwork Then
                Return it.ToString()
            End If
        Next
        Return ips
    End Function


    Sub Search(ByVal search1 As String, Optional ByVal search2 As String = Nothing, Optional ByVal search3 As String = Nothing, Optional ByVal search4 As String = Nothing, Optional ByVal search5 As String = Nothing, Optional ByVal search6 As String = Nothing, Optional ByVal search7 As String = Nothing, Optional ByVal search8 As String = Nothing, Optional ByVal search9 As String = Nothing, Optional ByVal search10 As String = Nothing)
        'OR search. Just for 題號




    End Sub
#Region "past"

    'Dim reSendMsg As String


    'Sub reSend()

    '    Dim udpc As New UdpClient("10.123.123.12", 1234)
    '    Dim sendByt() As Byte = Encoding.Default.GetBytes(reSendMsg)
    '    udpc.Send(sendByt, sendByt.Length)
    '    Beep()


    'End Sub


    ''先說一句話 傳來的回音是個enter
    'Sub sendmsg(ByVal msg As String)
    '    reSendMsg = msg
    '    Dim udpc As New UdpClient("10.123.123.12", 1234)
    '    Dim sendByt() As Byte = Encoding.Default.GetBytes(msg)
    '    udpc.Send(sendByt, sendByt.Length)
    'End Sub

    'Sub sendCheck()
    '    'check code chr(13)
    '    Dim udpc As New UdpClient("server ip", 225)
    '    Dim byt() As Byte = Encoding.Default.GetBytes(Chr(13))
    '    udpc.Send(byt, byt.Length)

    'End Sub


    'Dim CheckThread As New Thread(AddressOf lis)

    'Sub lis()
    '    Dim udpc As New UdpClient("dfedsfsdfsdf.vsvfs.d.fsdf", 14165255)

    '    Dim ep As IPEndPoint = New IPEndPoint(IPAddress.Parse("ip"), 111425353)
    '    Dim msgb() As Byte = udpc.Receive(ep)
    '    Dim msg As String = Encoding.Default.GetString(msgb)

    '    If msg.Chars(1) = Chr(13) Then
    '        Form1.gotChkMsgYet = True
    '    Else
    '        sendCheck()
    '        'give it to lots of things
    '    End If








    'End Sub
#End Region
    Sub giveAnswer()

    End Sub

    Sub deleteAnswer()

    End Sub

    Sub newExr()

    End Sub

    Sub listenServer()

        Do Until False
            Dim msg As String = read()

        Loop
    End Sub
    Function read()
        Dim s As Socket = listener.AcceptSocket()
        Dim msgb() As Byte = Nothing
        s.Receive(msgb)
        Dim msg As String = Encoding.Default.GetString(msgb)
        Return msg
    End Function
    Sub online()
        Dim sender As TcpClient = New TcpClient("serverIP", 36000) '36000 is server's port
        Dim stream As NetworkStream = sender.GetStream()
        Dim msg() As Byte = Encoding.Default.GetBytes(Getip() + "getonline")
        stream.Write(msg, 0, msg.Length)
        listener.Start()






    End Sub
End Module
