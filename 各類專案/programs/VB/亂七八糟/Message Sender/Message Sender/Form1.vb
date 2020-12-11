
Imports System.Net.Sockets '.TcpClient
'Imports System.Net.Sockets
Imports System.Net
Imports System.Threading

Imports System.Text


'port 10 11 
Public Class Form1
    Dim tcpl As TcpListener
    Dim tcpc As TcpClient
    Dim tcpc2 As TcpClient
    Dim listenT As New Thread(AddressOf listen)
    Dim myIp As String
    Dim s As NetworkStream
    Dim s2 As NetworkStream
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        myIp = Getip()
        Label3.Text = Getip()

        Control.CheckForIllegalCrossThreadCalls = False
















        'Dim ip() As IPAddress = Dns.GetHostEntry(Dns.GetHostName).AddressList
        'aa.Start()
        'aa.IsBackground = True
        'For Each it As IPAddress In ip

        '    If it.AddressFamily = Sockets.AddressFamily.InterNetwork Then
        '        max = it.ToString()
        '    End If
        'Next
        'Dim pts As Microsoft.VisualBasic.Devices.Ports
        'pts = My.Computer.Ports
        'MsgBox(Str(pts.SerialPortNames(1)))
        'Dim v As Socket = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
        'Dim sendmsg() As Byte = Encoding.Default.GetBytes("hhghhjjj")

        'Dim a(1000) As Byte
        'Dim habi As IPEndPoint
        'habi = New IPEndPoint(IPAddress.Parse(max), 10)
        'v.Connect(habi)
        '' Dim b As New IPEndPoint(IPAddress.Parse(max), Val(My.Computer.Ports.ToString)) 'IPAddress.Parse(max), Val(My.Computer.Ports.ToString)
        '' Dim a As New Net.Sockets.TcpClient(max, Val(My.Computer.Ports.ToString))
        '' a.Connect()
        'v.Send(sendmsg, 0, sendmsg.Length, SocketFlags.None)

    End Sub
    Sub closingForm() Handles MyBase.FormClosing
        Application.ExitThread()
        listenT.Abort()
        tcpl.Stop()

    End Sub
    Sub listen()
        tcpl.Start()
        Dim s As Socket = Nothing
        'Dim ips As IPEndPoint
        's.

        s = tcpl.AcceptSocket
        ' Dim n As NetworkStream = s.GetStream
        Do Until False
            Dim buffer(1024) As Byte
            s.Receive(buffer)
            Beep()
            Label2.Text = (Encoding.Default.GetString(buffer))
            's.Disconnect(True)
            ' s.Close()
            ' s.Disconnect(False)
            'tcpl.Start()
        Loop
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



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim b() As Byte = Encoding.Default.GetBytes(TextBox1.Text)
        s.Write(b, 0, b.Length)


   
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click





        tcpc = New TcpClient()

        tcpc.Connect(TextBox2.Text, Val(TextBox3.Text.ToString())) 'target is myself


        s = tcpc.GetStream()
     



        Button2.Enabled = False

    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim ipa As IPAddress
        ipa = IPAddress.Parse(myIp)
        Dim ipe As New IPEndPoint(ipa, Val(TextBox4.Text))
        tcpl = New TcpListener(ipe)
        tcpl.Start()



        listenT.Start()
        Button3.Enabled = False
    End Sub
End Class
