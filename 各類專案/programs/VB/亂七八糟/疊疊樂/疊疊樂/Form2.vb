Public Class Form2
    Public usr1 As SByte
    Private Sub ReLoad(ByVal winLoose As SByte)

    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        usr1 = 3
        Form1.PaperSisorStone_Main(usr1, usr1, usr1)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        usr1 = 1
        Form1.PaperSisorStone_Main(usr1, usr1, usr1)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        usr1 = 2
        Form1.PaperSisorStone_Main(usr1, usr1, usr1)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button1.Text = "剪刀"
        Button2.Text = "石頭"
        Button3.Text = "布"
    End Sub
End Class