
Public Class Form2
    Public users(1000, 2) As String
    Public user(1000), how_much_users As Double
    Dim yes_no_ps As Integer
    Dim yes_no_id As Integer
    Private Sub Form2_Load() Handles MyBase.Load





        Label1.Text = "帳號"

        Button1.Text = ("登入")
        MaskedTextBox1.Text = ""
        TextBox1.Text = "哈比嚕@哈比.親東.親東槍"
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        For i = 1 To 1000
            If users(i, 1) = TextBox1.Text Then
                yes_no_id = 1
            End If
        Next
    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs)

        For i = 1 To 1000
            If users(i, 2) = MaskedTextBox1.Text Then
                yes_no_ps = 1
            End If
        Next
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If yes_no_id = 1 And yes_no_ps = 1 Then
            Form3.Visible = True
        Else
            MsgBox("failed")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Button1.Text = ("完成") Then
            For i = 1 To 1000
                If users(i, 1) = TextBox1.Text Or users(i, 2) = MaskedTextBox1.Text Then
                    Label3.Text = "與其他帳號重複"
                Else
                    how_much_users = how_much_users + 1
                    users(how_much_users, 1) = TextBox1.Text
                    users(how_much_users, 2) = MaskedTextBox1.Text
                End If
            Next
            Form2_Load()
        Else
            Label2.Text = "你想要的密碼"
            Button1.Text = ("完成")
            MaskedTextBox1.Text = ""
            TextBox1.Text = "你想要的帳號"
        End If
    End Sub


End Class