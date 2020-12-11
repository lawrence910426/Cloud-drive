
Public Class Form2
    Public how_much_users As SByte = 1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        how_much_users += 1
        If how_much_users >= 30 Then
            MsgBox("測試完成", 1, "finish")
            End
            Stop
        End If
        Form1.Visible = True
    End Sub
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = (" 測試者人數        " + Str(how_much_users))
        Me.Text = "人數  " + Str(how_much_users)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form3.Visible = True
    End Sub
End Class

