Public Class Form2
    Dim a, b, c, d, g, f, h, l, A3, A2, x, y, N2, N1, z, Z1, A1, A4, Y2, L1, B1, b2, m1, m2 As Double
    Dim R1(100, 100), R2(100, 100), L0(100, 100) As Integer

    'Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
    'End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        a = 1

        'If b = 1 Then
        ' b = "剪刀"
        'If b = 2 Then
        'b = "布"
        'If b = 3 Then 
        'b = "石頭"
        '  End If
        ' End If
        'End If


        count_unit()

        'If a = b - 1 Then
        'MsgBox("你輸啦")
        'x() ' = 2
        'Else
        'If a = b + 1 Then
        'MsgBox("你贏了")
        'x = 1
        'End If
        'End If
        '       End If
        '              End If

        '  For j = 1 To 1
        'If h = 27 Then
        'g = Rnd()
        '  g = g * 4
        '   g = g + 50
        '    g = Int(g)
        '  End If
        '  If l = 27 Then
        'c = Rnd()
        '  c = c * 4
        ' c = c + 50
        '  c = Int(c)
        ' End If
        ' If l = 54 Or h = 54 Or l = 50 Or h = 50 Then
        'j = j - 1
        '   End If
        '  Next

        '    If c = 51 Then
        '       MsgBox("陳淇文 我讓你出名了!")
        '     x = 4
        ''   End If

        '  If c = 52 Then
        '      MsgBox("金城武 我讓你出名了")
        '  End If

        '    If c = 53 Then
        '      MsgBox("吳邦寧 我讓我出名了")
        '  End If

        '      If g = 51 Then
        '    If x = 4 Then
        ' '         Else
        'MsgBox("殺氣哥 我讓你出名了")
        '        End If
        '   End If

        '  If g = 52 Then
        '      MsgBox("承諺哥 我讓你出名了")
        '  End If

        '   If g = 53 Then
        '     MsgBox("楊嘉進 我讓你出名了")
        ' End If

        ' If x = 2 Then
        '    If c >= 49 Then
        ''     Else
        'MsgBox("是" + Str(c) + "害的")
        '  End If
        ' End If

        ' If x = 1 Then
        '
        '  If c >= 49 Then
        '  Else
        'MsgBox("是" + Str(g) + "幫助的")
        ' End If
        '  End If
        '
        'If x = 3 Then
        'MsgBox("驚險過關")
        'End If



        'If (a = 1 And b = 3) Or a > b Then
        'MsgBox("你輸啦")
        ' Else
        '  If (a = 3 And b = 1) Or a < b Then
        'MsgBox("你贏了")
        '  Else
        '  MsgBox("你輸啦")
        ' End If
        ' End If





        'MsgBox(b)
        ' If a = b Then
        'MsgBox("平手")
        'If a = 3 And b = 1 Then
        'MsgBox("輸了")
        'If a = 1 And b = 3 Then
        'MsgBox("贏了")
        'If a > b Then
        'MsgBox("贏了")
        'Else
        'MsgBox("輸了")
        ' End If
        'End If
        'end If
        'End If
    End Sub
    Private Sub count_unit()
        If b = a Then
            For i = 1 To 1
                b = Rnd()
                b = b * 4
                b = Int(b)

                If b = 4 Or b = 0 Then
                    i = i - 1
                End If
            Next
        End If


        If b = 1 Then
            MsgBox("電腦出剪刀")
        End If
        If b = 2 Then
            MsgBox("電腦出石頭")
        End If
        If b = 3 Then
            MsgBox("電腦出布")
        End If

        If a = b Then
            MsgBox("平手")
            x = 3
        Else
            For i = 1 To 1
                If a = 1 Or b = 1 Then

                    If a = 1 And b = 1 Then
                        i = i - 1
                    Else
                        If a = 2 Or b = 3 Then

                            If x = 1 Then
                            Else
                                MsgBox("你贏了")
                                x = 1
                            End If
                        End If

                        If a = 3 Or b = 2 Then

                            If x = 2 Then
                            Else
                                MsgBox("你輸啦")
                                x = 2
                            End If
                        End If
                    End If
                End If
            Next
            For j = 1 To 1
                If a = 2 Or b = 2 Then
                    If a = 2 And b = 2 Then
                        j = j - 1
                    Else
                        If a = 3 Or b = 1 Then
                            If x = 1 Then
                            Else
                                MsgBox("你贏了")
                                x = 1
                            End If
                        End If

                        If a = 1 Or b = 3 Then
                            If x = 1 Then
                            Else
                                If x = 2 Then
                                Else
                                    MsgBox("你輸啦")
                                    x = 2
                                End If
                            End If
                        End If
                    End If
                End If
            Next
            For k = 1 To 1
                If a = 3 Or b = 3 Then
                    If a = 3 And b = 3 Then
                        k = k - 1
                    Else
                        If a = 1 Or b = 2 Then

                            If x = 1 Then
                            Else
                                MsgBox("你贏了")
                                x = 1

                            End If
                        End If
                    End If
                    If b = 1 Or a = 2 Then
                        If x = 2 Then
                        Else
                            MsgBox("你輸啦")
                            x = 2
                        End If
                    End If
                End If
            Next
        End If
        Z1 = 1
        Form1_Load1()
    End Sub

    Private Sub Form1_Load1()
        If L1 = 1 Then
        Else
            z = z + 1

            If x = 1 Then
                A1 = A1 + 1
            End If
            If x = 2 Then
                A4 = A4 + 1
            End If


            Randomize()
            For i = 1 To 1
                b = Rnd()
                b = b * 4
                b = Int(b)

                If b = 4 Or b = 0 Then
                    i = i - 1
                End If
            Next

            Button1.Text = "剪刀"
            Button2.Text = "石頭"
            Button3.Text = "布"
            Label1.Text = "勝" + Str(A1)
            Label2.Text = "敗" + Str(A4)
            Label3.Text = "局數" + Str(z)
            CheckBox1.Text = "是否選擇勝負抵消"
            x = 0
            L1 = 1
            Y2 = y / 2
            Y2 = Int(Y2)
            Y2 = Y2 * 2
            If Y2 = y Then
                CheckBox1_CheckedChanged()
            End If
            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = True
        End If
        L1 = 0

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        a = 2
        count_unit()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        a = 3
        count_unit()
    End Sub

    Private Sub Form1_Load() Handles MyBase.Load

        z = 0
        x = 0
        y = 1
        A3 = 0
        A2 = 0
        A1 = 0
        A4 = 0
        B1 = 0
        b2 = 1
        For i = 1 To 100
            For j = 1 To 100
                R1(i, j) = 0
                R2(i, j) = 0
                L0(i, j) = 0
            Next
        Next
        For i = 1 To 1
            b = Rnd()
            b = b * 4
            b = Int(b)

            If b = 4 Or b = 0 Then
                i = i - 1
            End If
        Next
        Button1.Text = "剪刀"
        Button2.Text = "石頭"
        Button3.Text = "布"
        Button4.Text = "離開遊戲"
        Label1.Text = "勝" + Str(A1)
        Label2.Text = "敗" + Str(A4)
        Label3.Text = "局數" + Str(z)
        CheckBox1.Text = "是否選擇勝負抵消"
        CheckBox1.CheckState = 0
        CheckBox2.Text = "選擇求救模式" + Str(b2)
        CheckBox2.CheckState = 0
        MsgBox("遊戲開始")
        Button5.Text = "求救     " + "次數" + Str(B1)

    End Sub

    Private Sub Button4_Click() Handles Button4.Click
        Dim A11 As String
        A11 = InputBox("y       or         n")
        If A11 = "y" Or A11 = "Y" Then

            End
            Stop
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged() Handles CheckBox1.Click
        If L1 = 0 Then
            y = y + 1
        End If
        Y2 = y / 2
        Y2 = Int(Y2)
        Y2 = Y2 * 2
        If Y2 = y Then
            If A4 = A1 Then
                A4 = 0
                A1 = 0
            Else
                If A4 > A1 Then
                    A4 = A4 - A1
                    A1 = 0
                End If
                If A4 < A1 Then
                    A1 = A1 - A4
                    A4 = 0
                End If
            End If
        End If
        Label1.Text = "勝" + Str(A1)
        Label2.Text = "敗" + Str(A4)
        L1 = 1
        Form1_Load1()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If m2 = 0 Then
            If B1 >= 5 Then
                MsgBox("已經不能再求救啦!")
                Button5.Enabled = False
                CheckBox2.Enabled = False
            Else
                B1 = B1 + 1
                If b2 = 2 Then
                    MsgBox("你贏了")
                    x = 1
                    L1 = 0
                Else
                    If b2 = 1 Then
                        L1 = 1
                        If b = 1 Then
                            Button1.Enabled = False
                            Button2.Enabled = True
                            Button3.Enabled = False
                        End If
                        If b = 2 Then
                            Button1.Enabled = False
                            Button2.Enabled = False
                            Button3.Enabled = True
                        End If
                        If b = 3 Then
                            Button1.Enabled = True
                            Button2.Enabled = False
                            Button3.Enabled = False
                        End If
                    End If
                End If
            End If
            Button5.Text = "求救     " + "次數" + Str(B1)
            m2 = 0
            Form1_Load1()
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged() Handles CheckBox2.Click
        m1 = 0
        If b2 = 1 Then
            b2 = 2
            m1 = 1
        End If
        If b2 = 2 And m1 = 0 Then
            b2 = 1
        End If
        CheckBox2.Text = "選擇求救模式" + Str(b2)
    End Sub


    '預測出的 第一次(完)可呼叫
    Private Sub think()
        Dim c, d, f, g, h, m, N1, N2, N3, o, p, q As Single
        o = 0
        p = 1
        N1 = 0
        N2 = 0
        N3 = 0
        If z > 0 Then
            c = z / 100
            d = Int(c)
            c = c - d
            c = c * 100

            R1(d, c) = a
            R2(d, c) = b



            q = a
            For ij = 1 To 1

                h = 0
                m = 0
                For i = 1 To d
                    For j = 1 To 100
                        g = i
                        f = j


                        If R1(i, j) = q Then
                            g = g + p
                            If g = 101 Then
                                g = 1
                                f = f + 1
                                If f = 101 Then
                                    '                           lawrence()
                                End If
                            End If
                            h = h + 1
                            If h = 101 Then
                                h = 1
                                m = m + 1
                            End If
                            R1(f, g) = L0(m, h)
                        End If


                    Next j
                Next i

                For i = 1 To m
                    For j = 1 To h
                        If L0(i, j) = 1 Then
                            N1 = N1 + 1
                        End If
                        If L0(i, j) = 2 Then
                            N2 = N2 + 1
                        End If
                        If L0(i, j) = 3 Then
                            N3 = N3 + 1
                        End If
                    Next
                Next

                If N1 = N2 And N2 = N3 Then
                    o = 4
                Else
                    If N1 = N2 Then
                        o = 1
                    End If
                    If N2 = N3 Then
                        o = 2
                    End If
                    If N3 = N2 Then
                        o = 3
                    End If
                End If

                If o = 0 Then
                Else
                    p = p + 1
                    ij = ij - 1
                End If


            Next ij

            If N1 > (N2 And N3) Then
                b = 1
            End If
            If N2 > (N1 And N3) Then
                b = 2
            End If
            If N3 > (N1 And N3) Then
                b = 3
            End If

        End If
    End Sub



End Class
