Public Class Form2
    Dim a, b, c, d, f, g As String
    Dim h, answer_choose, l, l2, l3, l4, l5, l6, l7 As Integer
    Private Sub Form2_Load() Handles MyBase.Load

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = (0) Then
            CheckBox1.Text = "選擇"
            h = 0
        Else
            CheckBox1.Text = "填充"
            h = 1
        End If
    End Sub


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        l = 1
        f = TextBox1.Text
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        l2 = 1
        g = TextBox2.Text
    End Sub

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged
        l3 = 1
        a = RichTextBox1.Text
    End Sub

    Private Sub RichTextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox2.TextChanged
        l4 = 1
        b = RichTextBox2.Text
    End Sub

    Private Sub RichTextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox3.TextChanged
        l5 = 1
        c = RichTextBox3.Text
    End Sub

    Private Sub RichTextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox4.TextChanged
        l6 = 1
        d = RichTextBox4.Text
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If h = 0 Then
            If l3 = 0 Or l4 = 0 Or l5 = 0 Or l6 = 0 Then
                l = 0
            End If
        Else
            If l7 = 0 Then
                l = 0
            End If
        End If
        If l = 0 Or l2 = 0 Then
        Else

            Form4.Label1.Text = f
            Form4.Label2.Text = g
            Form4.Label3.Text = a
            Form4.Label4.Text = b
            Form4.Label5.Text = c
            Form4.Label6.Text = d
            Form4.CheckBox1.CheckState = h
            Form4.Label7.Text = "2"
            Form4.Label8.Text = answer_choose
            l = 0
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        l7 = 1
        If CheckBox2.CheckState = 1 Then
            CheckBox3.Enabled = False
            CheckBox4.Enabled = False
            CheckBox5.Enabled = False
            answer_choose = 1
        Else
            CheckBox3.Enabled = True
            CheckBox4.Enabled = True
            CheckBox5.Enabled = True
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        l7 = 1
        If CheckBox3.CheckState = 1 Then
            CheckBox2.Enabled = False
            CheckBox4.Enabled = False
            CheckBox5.Enabled = False
            answer_choose = 2
        Else
            CheckBox2.Enabled = True
            CheckBox4.Enabled = True
            CheckBox5.Enabled = True
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        l7 = 1
        If CheckBox4.CheckState = 1 Then
            CheckBox3.Enabled = False
            CheckBox2.Enabled = False
            CheckBox5.Enabled = False
            answer_choose = 3
        Else
            CheckBox3.Enabled = True
            CheckBox2.Enabled = True
            CheckBox5.Enabled = True
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        l7 = 1
        If CheckBox5.CheckState = 1 Then
            CheckBox3.Enabled = False
            CheckBox4.Enabled = False
            CheckBox2.Enabled = False
            answer_choose = 4
        Else
            CheckBox3.Enabled = True
            CheckBox4.Enabled = True
            CheckBox2.Enabled = True
        End If
    End Sub
End Class