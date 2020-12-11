Public Class Form1
    Dim a, b, c, d As Double
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button1.Text = "開始"
        Button2.Enabled = False
        Button3.Enabled = False
        Button2.Text = "開始"
        Button3.Text = "開始"
        Label1.Text = "其中之一能結束，其餘將進入病毒"
        a = 0

        MsgBox(Str(a))
        For i = 1 To 1
            For j = 1 To 1
                a = a + 1
            Next
        Next

        MsgBox("邦寧式半病毒")

        For i = 1 To 100000
            For j = 1 To 1000000
                j = j - 1
                b = j / 10000000
                c = Int(b)
                If c = b Then
                    Button2.Enabled = True
                    Button3.Enabled = True
                    i = 111111
                    j = 1111111
                End If
            Next
            i = i - 1
        Next


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Randomize()
        d = Rnd()
        d = 4 * d
        d = Int(d)
        If d = 4 Then
            d = 1
        End If
        If d = 1 Then
            End
        Else

            For i = 1 To 1000000
                For j = 1 To 100000000
                    a = a + 1
                Next
            Next
            MsgBox("邦寧式全病毒")
            For i = 1 To 100000
                For j = 1 To 1000000
                    j = j - 1
                Next
                i = i - 1
            Next
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Randomize()
        d = Rnd()
        d = 4 * d
        d = Int(d)
        If d = 4 Then
            d = 2
        End If
        If d = 1 Then
            End
        Else

            For i = 1 To 1000000
                For j = 1 To 100000000
                    a = a + 1
                Next
            Next
            MsgBox("邦寧式全病毒")
            For i = 1 To 100000
                For j = 1 To 1000000
                    j = j - 1
                Next
                i = i - 1
            Next
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Randomize()
        d = Rnd()
        d = 4 * d
        d = Int(d)
        MsgBox(Str(d))
        If d = 4 Then
            d = 3
        End If
        If d = 3 Then
            End
        Else

            For i = 1 To 1000000
                For j = 1 To 100000000
                    a = a + 1
                Next
            Next
            MsgBox("邦寧式全病毒")
            For i = 1 To 100000
                For j = 1 To 1000000
                    j = j - 1
                Next
                i = i - 1
            Next
        End If
    End Sub
End Class
