Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim A(10), B(10), C(10) As Integer
        Dim D(10) As String

        For i = 1 To 10
            D(i) = InputBox("輸入姓名")
            B(i) = InputBox("輸入自然分數")
            C(i) = InputBox("輸入數學分數")
            A(i) = B(i) + C(i)
        Next

        For i = 1 To 10
            TextBox1.Text = D(i)
            TextBox2.Text = B(i)
            TextBox3.Text = C(i)
            TextBox4.Text = A(i)

            MsgBox("hahaha")
        Next
    End Sub
End Class
