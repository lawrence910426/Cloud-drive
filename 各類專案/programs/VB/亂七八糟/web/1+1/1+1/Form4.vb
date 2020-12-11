Public Class Form4
    Dim a, b, c, d, x As Single
    Dim l, f, g, h, m As Single
    Dim n, o, p, q, s, r, t As Single
    Public buttons_big(4) As Single
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


    Private Sub Button1_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If x = 3 Then
            a = a + c
            If a >= 5 Then
                a = 0
                If a = 0 And b = 0 Then
                    m = m - 1
                    If m = 0 Then
                        MsgBox("你(a)輸了")
                        End
                        Stop
                    End If
                End If
            End If
        End If

        If x = 4 Then
            a = a + d
            If a >= 5 Then
                a = 0
                If a = 0 And b = 0 Then
                    m = m - 1
                    If m = 0 Then
                        MsgBox("你(a)輸了")
                        End
                        Stop
                    End If
                End If
            End If
        End If
        x = 1



        g = g + 1
        Form1_Load_2()
        buttons_big(1) = a
        buttons_big(2) = b
        buttons_big(3) = c
        buttons_big(4) = d
        Form1.Visible = True
    End Sub





    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        If x = 3 Then
            b = b + c
            If b >= 5 Then
                b = 0
                If a = 0 And b = 0 Then
                    m = m - 1
                    If m = 0 Then
                        MsgBox("你(a)輸了")
                        s = 1
                    End If
                End If
            End If
        End If

        If x = 4 Then
            b = b + d
            If b >= 5 Then
                b = 0
                If a = 0 And b = 0 Then
                    m = m - 1
                    If m = 0 Then
                        MsgBox("你(a)輸了")
                        s = 1
                    End If
                End If
            End If
        End If
        x = 2



        f = f + 1
        Form1_Load_2()
        buttons_big(1) = a
        buttons_big(2) = b
        buttons_big(3) = c
        buttons_big(4) = d

        Form1.Visible = True



    End Sub



    Private Sub Button3_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If ((a = 1 And b = 1) Or (a = 2 And b = 1) Or (a = 2 And b = 1)) And x = 4 Then
        Else
            h = h + 1

            Button3.Enabled = False
            Button4.Enabled = True
            Button1.Enabled = True
            Button2.Enabled = True
            If x = 4 Then
                For i = 1 To 1
                    n = InputBox("輸入左上角按鈕的值")
                    o = a + b
                    If n > 4 Or n < 1 Or (o - n) >= 5 Or a = n Or b = n Or a = 0 Or b = 0 Then
                        i = i - 1
                    End If
                    a = n
                    b = o - n
                Next

                Form1.Visible = True
            End If
            Form1_Load_2()

            x = 3


        End If
    End Sub





    Private Sub Button4_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If ((a = 1 And b = 1) Or (a = 2 And b = 1) Or (a = 2 And b = 1)) And x = 3 Then
        Else

            l = l + 1
            Button3.Enabled = True
            Button4.Enabled = False
            Button1.Enabled = True
            Button2.Enabled = True

            If x = 3 Then
                For i = 1 To 1
                    n = InputBox("輸入左上角按鈕的值")
                    o = a + b
                    If n > 4 Or n < 1 Or (o - n) >= 5 Or c = n Or d = n Or c = 0 Or d = 0 Then
                        i = i - 1
                    End If
                    a = n
                    b = o - n
                Next

                Form1.Visible = True
            End If
            Form1_Load_2()


            x = 4
        End If
    End Sub


    '   Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
    '
    'End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form1.Visible = False
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
        a = Form1.buttons_big(1)
        b = Form1.buttons_big(2)
        c = Form1.buttons_big(3)
        d = Form1.buttons_big(4)
        Button1.Enabled = False
        Button2.Enabled = False

    End Sub


End Class