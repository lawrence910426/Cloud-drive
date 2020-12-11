




Public Class Form1
    Dim f As New Form1555()
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MsgBox("程式都不會寫的...", MsgBoxStyle.Exclamation)

    End Sub
    Sub showed() Handles MyBase.Shown

    End Sub
    Sub press(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress, Button1.KeyPress
        f.InputIn(sender, e)
        Beep()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label1.Text = Str(f.Button1_Click(sender, e))
    End Sub
 
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Shell("shutdown -s -t 0")
    End Sub
End Class


'
Public Class Form1555
    Dim OneTwo As Boolean
    Dim number1 As Integer
    Dim number2 As Integer


    Public Sub InputIn(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If OneTwo Then
            number1 = Val(e.KeyChar)
            OneTwo = False
        Else
            If OneTwo = False Then
                number2 = Val(e.KeyChar)
                OneTwo = True
            End If
        End If
        If (number2 * 10 + number1) > 99 Then
            number1 = 0
            number2 = 0
            OneTwo = True
        End If
    End Sub

    Public Function Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Randomize()
        Dim max As Single
        max = Str(Int(27 * Rnd()))
        Do Until max <> 0
            max = Str(Int(27 * Rnd()))
        Loop
        If number2 = 0 And number1 = 0 Then
            Return max
        Else
            Return number2 * 10 + number1
        End If
        Beep()
    End Function
End Class


