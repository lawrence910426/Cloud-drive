Public Class Form2
    Dim rno
    Dim d(100, 5)
    Dim total
    Dim c(7, 2)
    Dim te(7)

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "d:\11900\940307.sm", OpenMode.Input)
        rno = 0
        Do While Not EOF(1)
            rno += 1
            For i = 1 To 5
                Input(1, d(rno, i))
            Next
            For j = 2 To 5
                total += d(rno, j)
            Next
        Loop
        c(1, 1) = c11 : c(1, 2) = c12
        c(2, 1) = c21 : c(2, 2) = c22
        c(3, 1) = c31 : c(3, 2) = c32
        c(4, 1) = c41 : c(4, 2) = c42
        c(5, 1) = c51 : c(5, 2) = c52
        c(6, 1) = c61 : c(6, 2) = c62
        c(7, 1) = c71 : c(7, 2) = c72
        te(1) = t1 : te(2) = t2
        te(3) = t3 : te(4) = t4
        te(5) = t5 : te(6) = t6
        te(7) = t7

        gb.Hide()

    End Sub

    Private Sub btcar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btcar.Click
        Dim t(4), l(4)
        gb.Show()
        gb.Text = "依車輛種類"
        For i = 5 To 7
            c(i, 1).hide()
            c(i, 2).hide()
            te(i).hide()
        Next
        t(1) = "大型車"
        t(2) = "中型車"
        t(3) = "小型車"
        t(4) = "公務車"
        For i = 1 To rno
            l(1) += d(i, 2)
            l(2) += d(i, 3)
            l(3) += d(i, 4)
            l(4) += d(i, 5)
        Next
        For i = 1 To 4
            For j = 1 To 4
                If l(i) < l(j) Then
                    Dim m1 = l(i) : l(i) = l(j) : l(j) = m1
                    Dim m2 = t(i) : t(i) = t(j) : t(j) = m2
                End If
            Next
        Next
        For i = 1 To 4
            c(i, 2).text = Format(l(i), "###,###,###")
            c(i, 1).text = t(i)
            te(i).width = 300 * l(i) / total
            c(i, 2).left = te(i).Right + 10
        Next
    End Sub

    Private Sub bw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bw.Click
        Dim t(7), l(7)
        gb.Show()
        gb.Text = "依星期別"
        For i = 5 To 7
            c(i, 1).show()
            c(i, 2).show()
            te(i).show()
        Next
        t(1) = "星期一"
        t(2) = "星期二"
        t(3) = "星期三"
        t(4) = "星期四"
        t(5) = "星期五"
        t(6) = "星期六"
        t(7) = "星期日"

        For i = 1 To rno
            For j = 2 To 5
                Select Case d(i, 1)
                    Case "MONDAY"
                        l(1) += d(i, j)
                    Case "TUESDAY"
                        l(2) += d(i, j)
                    Case "WEDNESDAY"
                        l(3) += d(i, j)
                    Case "THURSDAY"
                        l(4) += d(i, j)
                    Case "FRIDAY"
                        l(5) += d(i, j)
                    Case "SATURDAY"
                        l(6) += d(i, j)
                    Case "SUNDAY"
                        l(7) += d(i, j)
                End Select
            Next
        Next

        For i = 1 To 7
            c(i, 2).text = Format(l(i), "###,###,###")
            c(i, 1).text = t(i)
            te(i).width = 300 * l(i) / total
            c(i, 2).left = te(i).Right + 10
        Next



        
    End Sub
End Class
