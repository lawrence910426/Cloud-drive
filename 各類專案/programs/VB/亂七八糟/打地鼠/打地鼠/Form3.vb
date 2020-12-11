Public Class Form3
    Dim before_count As Single
    Dim mouse_up_down(6), win_times, loose_times As Integer
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
        before_count = 3
        Form1.Visible = False
        Form2.Visible = False
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        before_count = before_count - 1
        If before_count = 0 Then
            Label1.Text = "開始"
        Else
            If before_count > 0 Then
                Label1.Text = Str(before_count)
            Else
                Label1.Text = ""
                Timer2.Enabled = True
                Timer1.Enabled = False
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        For i = 1 To 6
            mouse_up_down(i) = Int(3 * Rnd())
        Next i
        If mouse_up_down(1) = 1 Then
            Button1.Text = " 地鼠出沒~"
        Else
            Button1.Text = " "
        End If
        If mouse_up_down(2) = 1 Then
            Button2.Text = " 地鼠出沒~"
        Else
            Button2.Text = " "
        End If
        If mouse_up_down(3) = 1 Then
            Button3.Text = " 地鼠出沒~"
        Else
            Button3.Text = " "
        End If
        If mouse_up_down(4) = 1 Then
            Button4.Text = " 地鼠出沒~"
        Else
            Button4.Text = " "
        End If
        If mouse_up_down(5) = 1 Then
            Button5.Text = " 地鼠出沒~"
        Else
            Button5.Text = " "
        End If
        If mouse_up_down(6) = 1 Then
            Button6.Text = " 地鼠出沒~"
        Else
            Button6.Text = " "
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Text = " 地鼠出沒~" Then
            win_times = win_times + 1
        Else
            loose_times = loose_times + 1
        End If
        Label2.Text = win_times
        Label3.Text = loose_times

        Button1.Text = " "




    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Button2.Text = " 地鼠出沒~" Then
            win_times = win_times + 1
        Else
            loose_times = loose_times + 1
        End If
        Label2.Text = win_times
        Label3.Text = loose_times
        Button2.Text = " "
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Button3.Text = " 地鼠出沒~" Then
            win_times = win_times + 1
        Else
            loose_times = loose_times + 1
        End If
        Label2.Text = win_times
        Label3.Text = loose_times
        Button3.Text = " "
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Button4.Text = " 地鼠出沒~" Then
            win_times = win_times + 1
        Else
            loose_times = loose_times + 1
        End If
        Label2.Text = win_times
        Label3.Text = loose_times
        Button4.Text = " "
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If Button5.Text = " 地鼠出沒~" Then
            win_times = win_times + 1
        Else
            loose_times = loose_times + 1
        End If
        Label2.Text = win_times
        Label3.Text = loose_times
        Button5.Text = " "
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If Button6.Text = " 地鼠出沒~" Then
            win_times = win_times + 1
        Else
            loose_times = loose_times + 1
        End If
        Label2.Text = win_times
        Label3.Text = loose_times
        Button6.Text = " "
    End Sub
End Class