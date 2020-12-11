Public Class Form1
    Dim a, b, c, d, x As Single
    Dim l, f, g, h, m As Single
    Dim n, o, p, q, s, r, t As Single
    Public buttons_big(4) As Single
    Dim first_load As Single


    Private Sub Form1_Load_2()
        Button1.Text = (Str(a))
        Button2.Text = (Str(b))
        Button3.Text = (Str(c))
        Button4.Text = (Str(d))
        Label1.Text = ("使用次數" + Str(l))
        Label2.Text = ("使用次數" + Str(f))
        Label3.Text = ("使用次數" + Str(g))
        Label4.Text = ("使用次數" + Str(h))
        If l > 101 Or f > 101 Or g > 101 Or h > 101 Then
            MsgBox("平手")
            End
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ((a = 1 And b = 1) Or (a = 2 And b = 1) Or (a = 2 And b = 1)) And x = 1 Then
        Else
            If x = 2 Then
                For i = 1 To 1
                    n = InputBox("輸入左上角按鈕的值")
                    o = a + b
                    If n > 4 Or n < 1 Or (o - n) >= 5 Or a = n Or b = n Or a = 0 Or b = 0 Then
                        i = i - 1
                    End If
                    a = n
                    b = o - n
                Next
                Form4.Visible = True
            End If

            g = g + 1
            Form1_Load_2()


            Button3.Enabled = True
            Button4.Enabled = True
            Button1.Enabled = False
            Button2.Enabled = True
            x = 1
        End If
    End Sub
    Private Sub Button2_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If ((a = 1 And b = 1) Or (a = 2 And b = 1) Or (a = 2 And b = 1)) And x = 1 Then
        Else
            If x = 1 Then
                For i = 1 To 1
                    n = InputBox("輸入左上角按鈕的值")
                    o = c + d
                    If n > 4 Or n < 1 Or (o - n) >= 5 Or a = n Or b = n Or a = 0 Or b = 0 Then
                        i = i - 1
                    End If
                    a = n
                    b = o - n
                Next
                Form4.Visible = True
            End If


            f = f + 1
            Form1_Load_2()


            Button3.Enabled = True
            Button4.Enabled = True
            Button1.Enabled = True
            Button2.Enabled = False
            x = 2

        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If x = 1 Then
            c = c + a
            If c >= 5 Then
                c = 0
                If c = 0 And d = 0 Then
                    r = r - 1
                    If r = 0 Then
                        MsgBox("你(b)輸了")
                        Stop
                        End
                    End If
                End If
            End If
        End If

        If x = 2 Then
            c = c + b
            If c >= 5 Then
                c = 0
                If c = 0 And d = 0 Then
                    r = r - 1
                    If r = 0 Then
                        MsgBox("你(a)輸了")
                        Stop
                        End
                    End If
                End If
            End If
        End If
        x = 3


        h = h + 1
        Form1_Load_2()
        buttons_big(1) = a
        buttons_big(2) = b
        buttons_big(3) = c
        buttons_big(4) = d
        Form4.Visible = True
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        If x = 1 Then
            d = d + a
            If d >= 5 Then
                d = 0
                If d = 0 And c = 0 Then
                    r = r - 1
                    If r = 0 Then
                        MsgBox("你(b)輸了")
                        End
                        Stop
                    End If
                End If
            End If
        End If

        If x = 2 Then
            d = d + b
            If d >= 5 Then
                d = 0
                If c = 0 And d = 0 Then
                    r = r - 1
                    If r = 0 Then
                        MsgBox("你(a)輸了")
                        End
                        Stop
                    End If
                End If
            End If
        End If
        x = 4



        l = l + 1
        Form1_Load_2()
        buttons_big(1) = a
        buttons_big(2) = b
        buttons_big(3) = c
        buttons_big(4) = d
        Form4.Visible = True

    End Sub

    '   Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
    '
    'End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form4.Visible = False


        m = 1
        r = 1

        a = 1
        b = 1
        c = 1
        d = 1



        Button1.Text = (Str(a))
        Button2.Text = (Str(b))
        Button3.Text = (Str(c))
        Button4.Text = (Str(d))
        Label1.Text = ("使用次數" + Str(l))
        Label2.Text = ("使用次數" + Str(f))
        Label3.Text = ("使用次數" + Str(g))
        Label4.Text = ("使用次數" + Str(h))
        Button3.Enabled = False
        Button4.Enabled = False
        Button1.Enabled = True
        Button2.Enabled = True

        a = Form4.buttons_big(1)
        b = Form4.buttons_big(2)
        c = Form4.buttons_big(3)
        d = Form4.buttons_big(4)
    End Sub



End Class
