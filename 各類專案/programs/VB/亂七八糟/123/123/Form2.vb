Public Class Form2



    Private Sub Form2_Load() Handles Timer1.Tick
        If Form1.Visible = False Or Form1.Timer1.Enabled = False Then
            Form1.Visible = True
        End If
    End Sub
End Class