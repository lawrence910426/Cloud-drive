Imports System.Net
Imports System.Net.Sockets












Public Class Form1
    Dim send As TcpClient
    Dim listener As TcpListener
    Dim listen As Socket
    Dim listenT As Threading.Thread
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load




    End Sub
    Function getip()
        Dim ip() As IPAddress = Dns.GetHostEntry(Dns.GetHostName).AddressList
        For Each it As IPAddress In ip
            If it.AddressFamily = AddressFamily.InterNetwork Then















                Return it.ToString
            End If
        Next
        Return ""
    End Function
    Sub listening()
        Dim s As Socket = listener.AcceptSocket()
        'improtant sendfile
        Dim t As TcpClient

        t = listener.AcceptTcpClient()
        ' s.RemoteEndPoint .AddressFamily 










    End Sub








    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        listener = New TcpListener(getip(), 36000)
        listener.Start()

        listenT = New Threading.Thread(AddressOf listening)
    End Sub
End Class
