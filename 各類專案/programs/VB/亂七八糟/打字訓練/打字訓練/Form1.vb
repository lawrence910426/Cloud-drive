Public Class Form1
    Dim 打字多久 As Decimal

    Private Sub Button1_(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Button1.KeyPress
        RichTextBox2.Text += e.KeyChar
    End Sub

    Private Sub RichTextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox2.TextChanged
        If RichTextBox2.Text = RichTextBox1.Text Then
            Timer1.Enabled = False
            Button1.Text = "Finish         " + "約花了" & Str(打字多久 * 1.25) + "sec來打"
            Label2.Text = "click to continue"
            Button1.Enabled = True
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        打字多久 += 1
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Text = ""
        Dim text As String = ""
        RichTextBox1.Text = text

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim rr As New IO.StreamReader("C:\程式\打字訓練.txt")
        Dim max As String
        Dim max2 As String
        Dim txt(100) As String
        max = rr.ReadToEnd
        max2 = Str(打字多久) + " "
        rr.Close()
        Dim wr As New IO.StreamWriter("C:\程式\打字訓練.txt")
        wr.Write(max2, max)
        wr.Flush()
        wr.Close()
        Dim sr As New IO.StreamReader("C:\程式\打字訓練.txt")
        txt = Split(sr.ReadToEnd, " ")
        sr.Close()




    End Sub


End Class
