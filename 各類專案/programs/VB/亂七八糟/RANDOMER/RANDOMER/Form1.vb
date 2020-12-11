Public Class Form1
    Dim OneTwo As Boolean
    Dim number1 As Integer
    Dim number2 As Integer
    Private Sub InputIn(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress, Button1.KeyPress
        If OneTwo Then
            Try
                number1 = Val(e.KeyChar)
            Catch ex As Exception
                MsgBox("Error")
            End Try
            OneTwo = False
        Else
            If OneTwo = False Then
                Try
                    number2 = Val(e.KeyChar)
                Catch ex As Exception
                    MsgBox("Error")
                End Try
                OneTwo = True
            End If
        End If
        If (number2 * 10 + number1) > 26 Then
            number1 = 0
            number2 = 0
            OneTwo = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Randomize()
        Dim max As Single
        max = Str(Int(27 * Rnd()))
        Do Until max <> 0
            max = Str(Int(27 * Rnd()))
        Loop
        If number2 = 0 And number1 = 0 Then
            Label1.Text = "請  " + Str(max) + "  來表演"
        Else
            Label1.Text = "請  " + Str(number2 * 10 + number1) + "  來表演"
        End If
        Beep()
    End Sub
End Class
