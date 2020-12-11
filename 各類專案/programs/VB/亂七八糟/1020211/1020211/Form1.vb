Public Class Form1
    Dim a(100, 6), b, c(6), d As Single
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        a(b, 1) = TextBox1.Text
    End Sub
    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        a(b, 2) = TextBox2.Text
    End Sub
    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        a(b, 3) = TextBox3.Text
    End Sub
    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        a(b, 4) = TextBox4.Text
    End Sub
    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        a(b, 5) = TextBox5.Text
    End Sub
    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        a(b, 6) = TextBox6.Text
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        b = 1
        Button1.Text = "第" + Str(b) + "組號碼"
        Button2.Text = "上一組號碼"
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        b = b + 1

        If b = 101 Then
            For i = 1 To 6
                c(i) = InputBox("輸入你的號碼")
            Next i
            For i = 1 To 100
                d = 0
                For j = 1 To 6
                    For k = 1 To 6
                        If a(i, j) = c(k) Then
                            d = d + 1
                        End If
                        If d = 0 Then
                        Else
                            MsgBox("第" + Str(i) + "組 中" + Str(d) + "個")
                        End If
                    Next
                Next
            Next
        Else
            Button1.Text = "第" + Str(b) + "組號碼"
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If b = 1 Then
        Else
            b = b - 1
        End If
    End Sub
End Class
