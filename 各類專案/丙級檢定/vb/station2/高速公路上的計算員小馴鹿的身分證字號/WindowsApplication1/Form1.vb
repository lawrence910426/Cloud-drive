Public Class Form1


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim rno, ec, d(100, 4)
        FileOpen(1, "d:\11900\940306.t01", OpenMode.Input)
        rno = 0
        Do While Not EOF(1)
            rno += 1
            For i = 1 To 3
                Input(1, d(rno, i))
            Next
        Loop

        For i = 1 To rno
            ec = ""
            If ec = "" Then
                If Not d(i, 1) Like "[A-Z]#########" Then ec = "FORMAT ERROR"
            End If
            If ec = "" Then
                Dim sex = Mid(d(i, 1), 2, 1) & d(i, 3)
                If sex <> "1M" And sex <> "2F" Then
                    ec = "SEX CODE ERROR"
                End If
            End If
            If ec = "" Then
                Dim s = "ABCDEFGHJKLMNPQRSTUVXYWZIO"
                Dim m1 = InStr(s, Mid(d(i, 1), 1, 1)) + 9

                Dim x1 = m1 \ 10
                Dim x2 = m1 Mod 10
                Dim y = x1 + 9 * x2
                For j = 2 To 9
                    y = y + Mid(d(i, 1), j, 1) * (10 - j)
                Next
                y = y + Mid(d(i, 1), 10, 1)
                If y Mod 10 <> 0 Then ec = "SUM CHECK ERROR"
            End If
            d(i, 4) = ec
        Next

        Dim dt As New DataTable
        dt.Columns.Add("ID_NO")
        dt.Columns.Add("NAME")
        dt.Columns.Add("SEX")
        dt.Columns.Add("ERROR")

        For i = 1 To rno
            Dim dr As DataRow = dt.NewRow
            dr(0) = d(i, 1)
            dr(1) = d(i, 2)
            dr(2) = d(i, 3)
            dr(3) = d(i, 4)
            dt.Rows.Add(dr)
        Next
        dgv.DataSource = dt
        dgv.Sort(dgv.Columns(0), 0)
        dgv.Columns(2).Width = 100
        dgv.Columns(3).Width = 150


    End Sub
End Class