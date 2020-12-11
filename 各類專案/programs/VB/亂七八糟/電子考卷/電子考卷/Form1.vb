Public Class Form1
    Dim a, a1, a2, a3, a4, g, g2, b2(100, 8) As String
    Dim b, c, d, f, f2, PT, b1(100, 8), x(100), h, b1_times As Single

    Private Sub Form1_Load() Handles MyBase.Load
        Form2.Visible = True

        b1_times = 0
        b = 1
        Label1.Text = "第" + Str(b) + "題"
        Label2.Text = a
        Button6.Text = "前一題"
        If c = 0 Then
            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = True
            Button4.Enabled = True
            TextBox1.Enabled = False
            Button1.Text = a1
            Button2.Text = a2
            Button3.Text = a3
            Button4.Text = a4
        End If
        If c = 1 Then
            Button1.Enabled = True
            Button2.Enabled = True
            Button4.Enabled = True
            Button3.Enabled = True
            TextBox1.Enabled = True
        End If
        Button5.Text = "下一題"

        'a =題目 c=選擇/填充 f2=選擇答案 g2=填充答案 pt=point b=題數 a(1-4)=答案選項 






        after_quiz()
    End Sub
    Private Sub before_quiz()
        Button5.Enabled = False
        Label1.Text = "第" + Str(b) + "題"
        Label2.Text = a
        If c = 0 Then
            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = True
            Button4.Enabled = True
            TextBox1.Enabled = False
            Button1.Text = a1
            Button2.Text = a2
            Button3.Text = a3
            Button4.Text = a4
        End If
        If c = 1 Then
            Button1.Enabled = False
            Button2.Enabled = False
            Button4.Enabled = False
            Button3.Enabled = False
            TextBox1.Enabled = True
        End If
        Button5.Text = "下一題"

        If b = 11 Then
            b = 10
            Label1.Text = "第" + Str(b) + "題"
            MsgBox("對了" + Str(PT) + "題")
            Me.Close()
        End If

    End Sub
    Private Sub after_quiz()

        'a =題目 c=選擇/填充 f2=選擇答案 g2=填充答案 pt=point b=題數 a(1-4)=答案選項 
        Randomize()

        h = Int(b1_times * Rnd())

        h = 1

        a = b2(h, 1)
        c = b1(h, 2)
        f2 = b1(h, 3)
        g2 = b2(h, 4)
        a1 = b2(h, 5)
        a2 = b2(h, 6)
        a3 = b2(h, 7)
        a4 = b2(h, 8)

        x(b) = h




        before_quiz()
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        b = b + 1
        If c = 0 Then
            If f2 = f Then
                PT = PT + 1
            End If
        Else
            If g = g2 Then
                PT = PT + 1
            End If
        End If

        'a =題目 c=選擇/填充 f2=選擇答案 g2=填充答案 pt=point b=題數 a(1-4)=答案選項 

        If Form4.Label7.Text = "0" Then
            b1_times = b1_times + 1
            b2(b1_times, 1) = Form4.Label1.Text
            b1(b1_times, 2) = Form4.CheckBox1.CheckState
            b1(b1_times, 3) = Form4.Label8.Text
            b2(b1_times, 4) = Form4.Label2.Text
            b2(b1_times, 5) = Form4.Label3.Text
            b2(b1_times, 6) = Form4.Label4.Text
            b2(b1_times, 7) = Form4.Label5.Text
            b2(b1_times, 8) = Form4.Label6.Text







        End If
        Form4.Label7.Text = "1"

        after_quiz()
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        g = TextBox1.Text
        Button5.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        f = 1
        Button5.Enabled = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        f = 2
        Button5.Enabled = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        f = 3
        Button5.Enabled = True
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        f = 4
        Button5.Enabled = True
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If b = 0 Then
        Else
            b = b - 1

            h = x(b)
            a = b2(h, 1)
            c = b1(h, 2)
            f2 = b1(h, 3)
            g2 = b2(h, 4)
            a1 = b2(h, 5)
            a2 = b2(h, 6)
            a3 = b2(h, 7)
            a4 = b2(h, 8)
        End If
        before_quiz()
    End Sub
End Class
