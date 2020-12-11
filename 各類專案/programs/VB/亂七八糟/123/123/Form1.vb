Public Class Form1





    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For i = 1 To 10
            Shell("cmd.exe /c start " & "http://blog.xuite.net/_theme/message/message_index.php?bid=3166039&aid=71643806")
        Next
        Form2.Visible = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a As Boolean = True
        Do Until Button1.Text = ""
            Do Until Button1.Enabled = False
                Do Until a = False
                    Shell("cmd.exe /c start " & "http://blog.xuite.net/_theme/message/message_index.php?bid=3166039&aid=71643806")
                    a = False
                Loop
                a = True
                Button1.Enabled = False
            Loop
            Button1.Text = "開始"
            Button1.Enabled = False
            a = True
        Loop
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Form2.Timer1.Enabled = False Then
            Form2.Timer1.Enabled = True
        End If
    End Sub
End Class
