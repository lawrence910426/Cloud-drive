Public Class Form2

 
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Text IsNot "O" Then
            Button1.Text = "O"
            comdo()
        Else
            MsgBox("你不能下這")
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Button2.Text IsNot "O" Then
            Button2.Text = "O"
            comdo()
        Else
            MsgBox("你不能下這")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Button3.Text IsNot "O" Then
            Button3.Text = "O"
            comdo()
        Else
            MsgBox("你不能下這")
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Button4.Text IsNot "O" Then
            Button4.Text = "O"
            comdo()
        Else
            MsgBox("你不能下這")
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If Button5.Text IsNot "O" Then
            Button5.Text = "O"
            comdo()
        Else
            MsgBox("你不能下這")
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If Button6.Text IsNot "O" Then
            Button6.Text = "O"
            comdo()
        Else
            MsgBox("你不能下這")
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If Button7.Text IsNot "O" Then
            Button7.Text = "O"
            comdo()
        Else
            MsgBox("你不能下這")
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If Button8.Text IsNot "O" Then
            Button8.Text = "O"
            comdo()
        Else
            MsgBox("你不能下這")
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If Button9.Text IsNot "O" Then
            Button9.Text = "O"
            comdo()
        Else
            MsgBox("你不能下這")
        End If
    End Sub

    Sub comdo()
        If Button1.Text = "O" And Button2.Text = "O" Then  'left to right up to down diagon l.u r.u
            Button3.Text = "X"
        ElseIf Button1.Text = "O" And Button3.Text = "O" Then
            Button2.Text = "X"
        ElseIf Button2.Text = "O" And Button3.Text = "O" Then
            Button1.Text = "X"
        ElseIf Button4.Text = "O" And Button5.Text = "O" Then
            Button6.Text = "X"
        ElseIf Button4.Text = "O" And Button6.Text = "O" Then
            Button5.Text = "X"
        ElseIf Button5.Text = "O" And Button6.Text = "O" Then
            Button4.Text = "X"
        ElseIf Button7.Text = "O" And Button8.Text = "O" Then
            Button9.Text = "X"
        ElseIf Button7.Text = "O" And Button9.Text = "O" Then
            Button8.Text = "X"
        ElseIf Button8.Text = "O" And Button9.Text = "O" Then
            Button7.Text = "X"



        ElseIf Button1.Text = "O" And Button4.Text = "O" Then
            Button7.Text = "X"
        ElseIf Button1.Text = "O" And Button7.Text = "O" Then
            Button4.Text = "X"
        ElseIf Button7.Text = "O" And Button4.Text = "O" Then
            Button1.Text = "X"
        ElseIf Button2.Text = "O" And Button5.Text = "O" Then
            Button8.Text = "X"
        ElseIf Button2.Text = "O" And Button8.Text = "O" Then
            Button5.Text = "X"
        ElseIf Button8.Text = "O" And Button5.Text = "O" Then
            Button2.Text = "X"
        ElseIf Button3.Text = "O" And Button6.Text = "O" Then
            Button9.Text = "X"
        ElseIf Button3.Text = "O" And Button9.Text = "O" Then
            Button6.Text = "X"
        ElseIf Button9.Text = "O" And Button6.Text = "O" Then
            Button3.Text = "X"

        ElseIf Button1.Text = "O" And Button5.Text = "O" Then
            Button9.Text = "X"
        ElseIf Button1.Text = "O" And Button9.Text = "O" Then
            Button5.Text = "X"
        ElseIf Button9.Text = "O" And Button5.Text = "O" Then
            Button1.Text = "X"
        ElseIf Button7.Text = "O" And Button5.Text = "O" Then
            Button3.Text = "X"
        ElseIf Button5.Text = "O" And Button3.Text = "O" Then
            Button7.Text = "X"
        ElseIf Button7.Text = "O" And Button3.Text = "O" Then
            Button5.Text = "X"
        Else
            If Button1.Text = "O" Or Button1.Text = "X" Then


                If Button2.Text = "O" Or Button2.Text = "X" Then
                    If Button3.Text = "O" Or Button3.Text = "X" Then
                        If Button4.Text = "O" Or Button4.Text = "X" Then
                            If Button5.Text = "O" Or Button5.Text = "X" Then
                                If Button6.Text = "O" Or Button6.Text = "X" Then
                                    If Button7.Text = "O" Or Button7.Text = "X" Then
                                        If Button8.Text = "O" Or Button8.Text = "X" Then

                                        Else
                                            Button9.Text = "X"
                                        End If
                                    Else
                                        Button7.Text = "X"
                                    End If
                                Else
                                    Button6.Text = "X"
                                End If
                            Else
                                Button5.Text = "X"
                            End If
                        Else
                            Button4.Text = "X"
                        End If
                    Else
                        Button3.Text = "X"
                    End If
                Else
                    Button2.Text = "X"
                End If
            Else
                Button1.Text = "X"
            End If


        End If


    End Sub



    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If (Button1.Text <> "" And Button2.Text <> "" And Button3.Text <> "" And Button4.Text <> "" And Button5.Text <> "" And Button6.Text <> "" And Button7.Text <> "" And Button8.Text <> "" And Button9.Text <> "") Then
            Me.Visible = False


        End If


    End Sub
End Class