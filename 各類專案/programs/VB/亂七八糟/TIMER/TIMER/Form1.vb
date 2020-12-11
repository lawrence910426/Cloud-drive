Public Class Form1
    Dim a, b, c, d, f, g, h As Double
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        a = a + 1
        If a = 1000 Then
            a = 0
            b = b + 1
        End If
        If b = 60 Then
            b = 0
            c = c + 1
        End If
        If c = 60 Then
            c = 0
            d = d + 1
        End If
        If d = 24 Then
            d = 0
            f = f + 1
        End If
        If f = 365 Then
            g = g + 1
        End If
        If g = 100 Then
            g = 0
            h = h + 1
        End If
        TextBox1.Text = Str(a) + "1/10秒" + Str(b) + "秒" + Str(c) + "分鐘" + Str(c) + "小時" + Str(d) + "小時" + Str(f) + "天" + Str(g) + "年" + Str(h) + "世紀"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Enabled = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer1.Enabled = False
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button1.Text = "START"
        Button2.Text = "STOP"
    End Sub
End Class
