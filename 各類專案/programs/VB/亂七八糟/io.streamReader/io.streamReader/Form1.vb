Public Class Form1
    Dim d As SByte
    Dim b As String

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Beep()
        Dim c As New IO.StreamReader("D:\111.txt")
        b = c.ReadToEnd
        d = d + 1
        c.Close()
        Dim a As New IO.StreamWriter("D:\111.txt")




        a.Write(d & b)

        a.Flush()
        a.Close()


    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        MsgBox(b)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
