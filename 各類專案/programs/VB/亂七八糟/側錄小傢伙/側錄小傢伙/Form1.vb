Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        SendKeys.Send(Keys.PrintScreen)
        Dim g As Graphics

        'SendKeys.Send(Keys.Control + Keys.V)
        PictureBox1.Image = My.Computer.Screen. 'My.Computer.Clipboard.GetImage()
        'PictureBox1.ImageLocation = "dfad"
    End Sub
End Class
