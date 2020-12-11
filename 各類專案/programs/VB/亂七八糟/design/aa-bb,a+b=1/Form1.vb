Public Class Form1
    Dim a, b, count_times1, count_times2 As Double
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a1, b1, ab1, ab2, [ab], ab12, ab22, ab1a(169), ab1a2, ab2a(169), ab2a2 As Double
        MsgBox("check start")
        For i = 1 To 100
            a = a + 1
            For j = 1 To a
                b = b + 1
                a1 = a * a
                b1 = b * b
                ab1 = a + b
                If a1 > b1 Then
                    ab2 = a1 - b1
                    If a1 < b1 Then
                        ab2 = b1 - a1
                    End If
                End If
                For k1 = 1 To ab1
                    ab12 = Int(ab1 / k1)
                    ab12 = ab12 * k1
                    If ab12 = ab1 Then
                        ab1a2 = ab1a2 + 1
                        ab1a(ab1a2) = k1
                    End If
                Next
                For k2 = 1 To ab1
                    ab22 = Int(ab2 / k2)
                    ab22 = ab22 * k2
                    If ab22 = ab2 Then
                        ab2a2 = ab2a2 + 1
                        ab2a(ab2a2) = k2
                    End If
                Next

                For ij1 = 1 To ab1a2
                    For ij2 = 1 To ab2a2
                        If ab1a(ij1) = ab2a(ij2) Then
                            [ab] = ab1a(ij1)
                        End If
                    Next
                Next

                If [ab] = 1 Then
                    MsgBox("算出之外的的了")
                    MsgBox(Str(ab1) + "and" + Str(ab2))
                End If
                TextBox1.Text = Str(ab1)
                TextBox2.Text = Str(ab2)
            Next j
            i = i - 1
        Next i
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        a = 1
        b = 1
        count_times1 = 1
        count_times2 = 1
    End Sub
End Class
