Imports System.IO
Imports System.Threading


Imports System.Net.Sockets

Public Class About
    Inherits System.Web.UI.Page
    Dim tcpc As New TcpClient()
    Dim tcpl As New TcpListener(System.Net.IPAddress.Parse("192.168.0.4"), 1234)
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim s As New System.Media.SoundPlayer("http://billor.chsh.chc.edu.tw/sound/Femaleha.wav")
        s.PlayLooping()
    End Sub
    Sub listen()
        tcpl.Start()
        Dim s As Socket = tcpl.AcceptSocket()
        Do Until False
            Dim b(10000000) As Byte
            s.Receive(b)
            MsgBox(System.Text.Encoding.Default.GetString(b))
        Loop







    End Sub
    Sub change()

    End Sub
    Protected Sub s(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
  
        ' Dim s As New System.Media.SoundPlayer("http://billor.chsh.chc.edu.tw/sound/Femaleha.wav")

        's.PlayLooping()


    End Sub
 

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Dim msg As New System.Net.Mail.MailMessage()

    End Sub
End Class