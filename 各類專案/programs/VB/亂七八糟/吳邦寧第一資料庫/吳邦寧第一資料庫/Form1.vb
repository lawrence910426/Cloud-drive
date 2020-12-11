Public Class Form1
    Dim MAX(4) As String
    Dim MAX2(4, 100) As String
    Public file(4, 100) As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim reader As New IO.StreamReader("F:\吳邦寧第一資料庫txt")
        MsgBox(2^16)
        MAX = Split(reader.ReadToEnd, ",")
        For i = 1 To 400 Step 4
            MAX2(1, Int(i / 4)) = MAX(i)
            MAX2(2, Int((i - 1) / 4)) = MAX(i - 1)
            MAX2(3, Int((i - 2) / 4)) = MAX(i - 2)
            MAX2(4, Int((i - 3) / 4)) = MAX(i - 3)
        Next
        For i = 1 To 100
            For j = 1 To 4
                file(j, i) = MAX2(j, i)
            Next
        Next
        change(1)
    End Sub
    Private Sub change(ByVal file As Short)
        MAX2(file + 0, 1) = TextBox1.Text
        MAX2(file + 0, 2) = TextBox2.Text
        MAX2(file + 0, 3) = TextBox3.Text
        MAX2(file + 0, 4) = TextBox4.Text
        MAX2(file + 0, 5) = TextBox5.Text
        MAX2(file + 1, 1) = Label6.Text
        MAX2(file + 1, 2) = Label7.Text
        MAX2(file + 1, 3) = Label8.Text
        MAX2(file + 1, 4) = Label9.Text
        MAX2(file + 1, 5) = TextBox6.Text
        MAX2(file + 2, 1) = TextBox7.Text
        MAX2(file + 2, 2) = TextBox8.Text
        MAX2(file + 2, 3) = TextBox9.Text
        MAX2(file + 2, 4) = TextBox10.Text
        MAX2(file + 2, 5) = TextBox11.Text
        MAX2(file + 3, 1) = TextBox12.Text
        MAX2(file + 3, 2) = TextBox13.Text
        MAX2(file + 3, 3) = TextBox14.Text
        MAX2(file + 3, 4) = TextBox15.Text
        MAX2(file + 3, 5) = TextBox15.Text
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub


End Class
