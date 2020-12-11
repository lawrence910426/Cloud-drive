Public Class Form4
    Public all_letters As String
    Dim AllLetters, oneLetter(10000) As String
    Dim all_letter As String
    Dim letter(10000), ltr As Single

    Private Sub form1_load() Handles MyBase.Load
        Randomize()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AllLetters = "file" + all_letters  'last 7 index 41+27+10=78 2*78=156
        oneLetter = Split(all_letters, " ")
        Dim a As Decimal
        a = Rnd()

        For i = 0 To 10000
            Select Case oneLetter(0)
                Case "a"
                    ltr = 1
                Case "b"
                    ltr = 2
                Case "c"
                    ltr = 3
                Case "d"
                    ltr = 4
                Case "e"
                    ltr = 5
                Case "f"
                    ltr = 6
                Case "g"
                    ltr = 8
                Case "h"
                    ltr = 9
                Case "i"
                    ltr = 10
                Case "j"
                    ltr = 11
                Case "k"
                    ltr = 12
                Case "l"
                    ltr = 13
                Case "m"
                    ltr = 14
                Case "n"
                    ltr = 15
                Case "o"
                    ltr = 16
                Case "p"
                    ltr = 17
                Case "q"
                    ltr = 18
                Case "r"
                    ltr = 19
                Case "s"
                    ltr = 20
                Case "t"
                    ltr = 21
                Case "u"
                    ltr = 22
                Case "v"
                    ltr = 23
                Case "w"
                    ltr = 24
                Case "x"
                    ltr = 25
                Case "y"
                    ltr = 26
                Case "z"
                    ltr = 27

                Case Form2.Button1.Text ' up english down chinese
                    ltr = 28
                Case Form2.Button2.Text
                    ltr = 29
                Case Form2.Button3.Text
                    ltr = 30
                Case Form2.Button4.Text
                    ltr = 31
                Case Form2.Button5.Text
                    ltr = 32
                Case Form2.Button6.Text
                    ltr = 33
                Case Form2.Button7.Text
                    ltr = 34
                Case Form2.Button8.Text
                    ltr = 35
                Case Form2.Button9.Text
                    ltr = 36
                Case Form2.Button10.Text
                    ltr = 37
                Case Form2.Button11.Text
                    ltr = 38
                Case Form2.Button11.Text
                    ltr = 39
                Case Form2.Button12.Text
                    ltr = 40
                Case Form2.Button13.Text
                    ltr = 41
                Case Form2.Button14.Text
                    ltr = 42
                Case Form2.Button15.Text
                    ltr = 43
                Case Form2.Button16.Text
                    ltr = 44
                Case Form2.Button17.Text
                    ltr = 45
                Case Form2.Button18.Text
                    ltr = 46
                Case Form2.Button19.Text
                    ltr = 47
                Case Form2.Button20.Text
                    ltr = 48
                Case Form2.Button21.Text
                    ltr = 49
                Case Form2.Button22.Text
                    ltr = 50
                Case Form2.Button23.Text
                    ltr = 51

                Case Form2.Button24.Text

                    ltr = 52
                Case Form2.Button25.Text

                    ltr = 53
                Case Form2.Button26.Text
                    ltr = 54

                Case Form2.Button27.Text
                    ltr = 55

                Case Form2.Button28.Text
                    ltr = 56

                Case Form2.Button29.Text

                    ltr = 57
                Case Form2.Button30.Text
                    ltr = 58
                Case Form2.Button31.Text
                    ltr = 59
                Case Form2.Button32.Text
                    ltr = 60
                Case Form2.Button33.Text
                    ltr = 61
                Case Form2.Button34.Text
                    ltr = 62
                Case Form2.Button35.Text
                    ltr = 63
                Case Form2.Button36.Text
                    ltr = 64
                Case Form2.Button37.Text
                    ltr = 65
                Case Form2.Button38.Text
                    ltr = 66
                Case Form2.Button39.Text
                    ltr = 67
                Case Form2.Button40.Text
                    ltr = 68
                Case Form2.Button41.Text
                    ltr = 69
                Case Form2.Button42.Text
                    ltr = 70
                Case Form2.Button41.Text
                    'NUMBERS

                Case Form3.Button1.Text
                    ltr = 71
                Case Form3.Button2.Text
                    ltr = 72
                Case Form3.Button3.Text
                    ltr = 73
                Case Form3.Button4.Text
                    ltr = 74
                Case Form3.Button5.Text
                    ltr = 75
                Case Form3.Button6.Text
                    ltr = 76
                Case Form3.Button7.Text
                    ltr = 77
                Case Form3.Button8.Text
                    ltr = 78
                Case Form3.Button9.Text
                    ltr = 79
                Case Form3.Button10.Text
                    ltr = 80
            End Select

            If Int(Rnd()) = 0 Then
                letter(i) = 1 + ltr
            Else
                letter(i) = 160 - ltr
            End If
            letter(i) = letter(i) * a
            all_letter = all_letter + Str(letter(i)) + " "
        Next










        Form5.RichTextBox1.Text = all_letter
        Form5.TextBox1.Text = Str(a)
        Form5.Visible = True











    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

    End Sub
End Class