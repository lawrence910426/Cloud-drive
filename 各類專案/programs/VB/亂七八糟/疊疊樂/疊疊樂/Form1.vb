Public Class Form1
    Public usr1 As SByte

    Private Sub ReLoad(ByVal winLoose As SByte)

    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        usr1 = 3
        PaperSisorStone_Main(usr1, usr1, usr1)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        usr1 = 1
        PaperSisorStone_Main(usr1, usr1, usr1)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        usr1 = 2
        PaperSisorStone_Main(usr1, usr1, usr1)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button1.Text = "剪刀"
        Button2.Text = "石頭"
        Button3.Text = "布"
        Form4.Visible = True
    End Sub
    Public Sub PaperSisorStone_Main(ByVal a As Single, ByVal b As Single, ByVal c As Single)
        If a = 0 Then
            a = b
            b = c
        End If
        If b = 0 Then
            a = b
            c = a
        End If

        Dim x As SByte

        If a = b Then

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

                                x = 1
                            End If
                        End If

                        If a = 3 Or b = 2 Then

                            If x = 2 Then
                            Else

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

                                x = 1
                            End If
                        End If

                        If a = 1 Or b = 3 Then
                            If x = 1 Then
                            Else
                                If x = 2 Then
                                Else

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

                                x = 1

                            End If
                        End If
                    End If
                    If b = 1 Or a = 2 Then
                        If x = 2 Then
                        Else

                            x = 2
                        End If
                    End If
                End If
            Next
        End If
        ReLoad(x)
    End Sub
End Class
