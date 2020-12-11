Public Class Form1
    Dim rocket(3, 3), rock(3, 3), Where_I_am As Single
    Dim before_count_time As Single
    Dim witch_shoot, shoot_time As Single
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        before_count_time = before_count_time + 1
        If before_count_time = 1 Then
            Label17.Text = "3"
        End If
        If before_count_time = 2 Then
            Label17.Text = "2"
        End If
        If before_count_time = 3 Then
            Label17.Text = "1"
        End If
        If before_count_time = 4 Then
            Label17.Text = ""
            Timer2.Enabled = True
        End If
    End Sub


    Private Sub Timer2_Tick() Handles Timer2.Tick

        witch_shoot = Int(4 * Rnd())
        If witch_shoot = 1 Then
            rocket(1, 1) = 1
        Else
            If witch_shoot = 2 Then
                rocket(2, 1) = 1
            Else
                If witch_shoot = 3 Then
                    rocket(3, 1) = 1
                End If
            End If
        End If

        witch_shoot = Int(4 * Rnd())
        If witch_shoot = 1 Then
            rock(1, 1) = 1
        Else
            If witch_shoot = 2 Then
                rock(2, 1) = 1
            Else
                If witch_shoot = 3 Then
                    rock(3, 1) = 1
                End If
            End If
        End If
        Timer3.Enabled = True
        Timer1.Enabled = False
        Timer2.Enabled = False
    End Sub
    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        shoot_time = shoot_time + 1
        Timer2.Enabled = False
        For i = 1 To 3
            If rocket(i, 1) = 1 Then
                rocket(i, 2) = rocket(i, 2) + 1
                If rocket(i, 2) > 3 Then
                    rocket(i, 2) = 3
                End If
                If rocket(i, 2) = 3 Then
                    rocket(i, 3) = rocket(i, 3) + 1
                End If
            End If
        Next

        If rocket(1, 3) = 1 Then
            Label5.Text = "<<<<<0000"
        Else
            If rocket(1, 2) = 1 Or rocket(1, 2) = 2 Or rocket(1, 2) = 3 Then
                Label5.Text = "Warning"
            Else
                Label5.Text = ""
            End If
        End If
        If rocket(1, 3) = 2 Then
            Label4.Text = "<<<<<0000"
        Else
            Label4.Text = ""
        End If
        If rocket(1, 3) = 3 Then
            Label3.Text = "<<<<<0000"
        Else
            Label3.Text = ""
        End If
        If rocket(1, 3) = 4 Then
            Label2.Text = "<<<<<0000"
        Else
            Label2.Text = ""
        End If
        If rocket(1, 3) = 5 Then
            Label1.Text = "<<<<<0000"
        Else
            Label1.Text = ""
        End If



        If rocket(2, 3) = 1 Then
            Label10.Text = "<<<<<0000"
        Else
            Label10.Text = ""
        End If
        If rocket(2, 3) = 2 Then
            Label9.Text = "<<<<<0000"
        Else
            Label9.Text = ""
        End If
        If rocket(2, 3) = 3 Then
            Label8.Text = "<<<<<0000"
        Else
            Label8.Text = ""
        End If
        If rocket(2, 3) = 4 Then
            Label7.Text = "<<<<<0000"
        Else
            Label7.Text = ""
        End If
        If rocket(2, 3) = 5 Then
            Label6.Text = "<<<<<0000"
        Else
            Label6.Text = ""
        End If
        If rocket(3, 3) = 1 Then
            Label15.Text = "<<<<<0000"
        Else
            Label15.Text = ""
        End If
        If rocket(3, 3) = 2 Then
            Label14.Text = "<<<<<0000"
        Else
            Label14.Text = ""
        End If
        If rocket(3, 3) = 3 Then
            Label13.Text = "<<<<<0000"
        Else
            Label13.Text = ""
        End If
        If rocket(3, 3) = 4 Then
            Label12.Text = "<<<<<0000"
        Else
            Label12.Text = ""
        End If
        If rocket(3, 3) = 5 Then
            Label11.Text = "<<<<<0000"
        Else
            Label11.Text = ""
        End If
        If shoot_time >= 3 Then
            shoot_time = 0
            Timer3.Enabled = False
            Timer2.Enabled = True
        End If
    End Sub

End Class
