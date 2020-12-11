Public Class Form1
    Dim how_long_time, how_much_click, click_witch_key As Single 'data a=a+1 need 1/1000000(0.00001) sec   if... need 0.01499984(0.015) sec 
    Dim data(30, 2, 10, 3) As Single
    Dim LeftRight As Boolean
    Dim what_do As SByte
    Dim delayTime As Single



    Private Sub KeyPres(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress

        If (e.KeyChar = "a" Or e.KeyChar = "4") And click_witch_key = 1 Then
            Timer2.Enabled = False
            Beep()
            save()
        Else
            If (e.KeyChar = "d" Or e.KeyChar = "6") And click_witch_key = 5 Then
                Timer2.Enabled = False
                Beep()
                save()
            Else
                If (e.KeyChar = "w" Or e.KeyChar = "s" Or e.KeyChar = "2" Or e.KeyChar = "8") And (click_witch_key = 2 Or click_witch_key = 4) Then
                    Timer2.Enabled = False
                    Beep()
                    save()
                Else
                    If (e.KeyChar = "q" Or e.KeyChar = "5") And click_witch_key = 3 Then
                        Timer2.Enabled = False
                        Beep()
                        save()
                    End If
                End If
            End If
        End If


    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim dtmTest As Date
        Form2.Visible = True

        'dtmTest = TimeValue(Now)
        ' intHour = Hour(Now) ' intHour = 21 (for 9 PM)
        ' intMinute = Minute(Now) ' intMinute = 15
        '  intSecond = Second(Now) ' intSecond = 20
        '    MsgBox(dtmTest)
        Randomize()
        delayTime = Int(76 * Rnd())
        Do Until delayTime <> 0
            delayTime = Int(76 * Rnd())
        Loop
        Beep()
    End Sub
    Dim before_count As Short = 3
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        before_count = before_count - 1
        Label3.Text = Str(before_count)
        'MsgBox(Str(before_count))
        If before_count = 0 Then
            Label3.Text = ""
            Timer1.Enabled = False
            delay(delayTime)
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        how_long_time += 1
        If Int(how_long_time / 1501) * 1501 = how_long_time Then
            how_long_time -= 1
        End If
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If click_witch_key = 1 Then

            Beep()
            save()
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If click_witch_key = 3 Then

            Beep()
            save()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If click_witch_key = 5 Then

            Beep()
            save()
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If click_witch_key = 4 Or click_witch_key = 2 Then

            Beep()
            save()
        End If
    End Sub

    Private Sub random_unit()
        Randomize()
        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        click_witch_key = Int(6 * Rnd())
        Do Until click_witch_key <> 0
            click_witch_key = Int(6 * Rnd())
        Loop



        Timer3.Enabled = False
        If click_witch_key = 1 Then
            Button1.Text = "<<<<<=="
        End If
        If click_witch_key = 2 Then
            Button1.Text = "==>>>>>"
        End If
        If click_witch_key = 3 Then
            Button2.Text = "press"
        End If
        If click_witch_key = 4 Then
            Button3.Text = "<<<<<=="
        End If
        If click_witch_key = 5 Then
            Button3.Text = "==>>>>>"
        End If

    End Sub

    Private Sub save()
        Dim left_right As SByte
        If how_much_click >= 10 = False Then
            If LeftRight = 1 Then
                left_right = 1
            Else
                left_right = 2
            End If

            data(Form2.how_much_users, left_right, how_much_click, what_do) = how_long_time
            delayTime = Int(76 * Rnd())
            Do Until delayTime <> 0
                delayTime = Int(76 * Rnd())
            Loop
            delay(delayTime)
        Else
            MsgBox("測試完畢")
        End If
    End Sub

    Private Sub delay(ByVal delayTime As SByte)
        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
                    Label3.Text = ""
        For i = 1 To 1000000 * delayTime
            For ij = 1 To 10 * delayTime

            Next
        Next
        random_unit()
    End Sub
End Class