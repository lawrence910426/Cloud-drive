Public Class Form1
    Dim a(6), b, c As Single
    Dim f, g, x, y As Integer
    Private Sub Form1_Load1()
        Randomize()
        For ij = 1 To 1
            For i = 1 To 6
                For j = 1 To 1
                    a(i) = Rnd()
                    a(i) = 50 * a(i)
                    a(i) = Int(a(i))
                    If a(i) >= 50 Or a(i) = 0 Then
                        j = j - 1
                    End If
                Next j

                b = i
                c = 1
                For j1 = c To i
                    If b = 1 Then
                    Else
                        b = b - 1
                    End If
                    If a(b) = a(i) Then
                        For k = 1 To 1
                            'a(i) = Rnd()
                            'a(i) = 49 * a(i)
                            'a(i) = Int(a(i))
                            a(i) = Int(50 * Rnd())
                            If a(i) >= 50 Or a(i) = 0 Then
                                k = k - 1
                            End If
                        Next k
                        j1 = j1 - 1
                    End If
                    If b <= 2 Then
                        c = i + 1
                    End If
                Next j1

            Next i

            f = Rnd()
            g = Rnd()
            If f = g Then
                ij = ij - 1
                MsgBox("博不到ㄅㄨㄝ")
            Else
                MsgBox("博到ㄅㄨㄝ")
            End If
        Next ij
        Label1.Text = Str(a(1))
        Label2.Text = Str(a(2))
        Label3.Text = Str(a(3))
        Label4.Text = Str(a(4))
        Label5.Text = Str(a(5))
        Label6.Text = Str(a(6))
        y = 0
        x = 0

    End Sub
    Private Sub Button1_Click() Handles Button1.Click
        Form1_Load()
    End Sub
    Private Sub Form1_Load() Handles MyBase.Load
        x = 0
        y = 0
        Button1.Text = "重算"
        Form1_Load1()
    End Sub
End Class
