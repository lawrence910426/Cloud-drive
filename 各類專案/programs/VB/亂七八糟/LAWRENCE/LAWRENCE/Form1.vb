Public Class Form1
    Dim a, b, c, d, g, f, h, l, x As Single
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button1.Text = "開始遊戲"
    End Sub
    'Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
    'End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Randomize()
        x = 0
        g = InputBox("輸入失敗時怪誰")
        c = InputBox("輸入成功時是誰幫助的")



        If c > 27 Or c <= 0 Then
            c = 27
        End If


        If g > 27 Or g < 0 Then
            g = 27
        End If




        For j = 1 To 1
            a = InputBox("1是剪刀 2是石頭 3是布")
            If a = 1 Or a = 2 Or a = 3 Then
            Else
                j = j - 1
            End If
        Next
        For i = 1 To 1
            b = Rnd()
            b = b * 4
            b = Int(b)


            If b = 4 Or b = 0 Then
                i = i - 1
            End If
        Next

        b = 2

        'If b = 1 Then
        ' b = "剪刀"
        'If b = 2 Then
        'b = "布"
        'If b = 3 Then 
        'b = "石頭"
        '  End If
        ' End If
        'End If
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

        For j = 1 To 1
            If h = 27 Then
                g = Rnd()
                g = g * 4
                g = g + 50
                g = Int(g)
            End If
            If l = 27 Then
                c = Rnd()
                c = c * 4
                c = c + 50
                c = Int(c)
            End If
            If l = 54 Or h = 54 Or l = 50 Or h = 50 Then
                j = j - 1
            End If
        Next

        If c = 51 Then
            MsgBox("陳淇文 我讓你出名了!")
            x = 4
        End If

        If c = 52 Then
            MsgBox("金城武 我讓你出名了")
        End If

        If c = 53 Then
            MsgBox("吳邦寧 我讓我出名了")
        End If

        If g = 51 Then
            If x = 4 Then
            Else
                MsgBox("殺氣哥 我讓你出名了")
            End If
        End If

        If g = 52 Then
            MsgBox("承諺哥 我讓你出名了")
        End If

        If g = 53 Then
            MsgBox("楊嘉進 我讓你出名了")
        End If

        If x = 2 Then
            If c >= 49 Then
            Else
                MsgBox("是" + Str(c) + "害的")
            End If
        End If

        If x = 1 Then

            If c >= 49 Then
            Else
                MsgBox("是" + Str(g) + "幫助的")
            End If
        End If


        If x = 3 Then
            MsgBox("驚險過關")
        End If



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
End Class
