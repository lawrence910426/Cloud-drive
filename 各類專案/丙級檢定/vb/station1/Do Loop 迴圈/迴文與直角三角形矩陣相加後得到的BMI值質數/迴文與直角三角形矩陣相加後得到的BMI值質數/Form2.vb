Public Class Form2
    Dim vn = vbNewLine
    '**********************
    '*11900-940301 Program*
    '**********************
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim m0, m1, m2, m3, i
        i = 1
        FileOpen(1, "c:\11900\940301.sm", OpenMode.Input)
        Input(1, m0)
        FileClose(1)

        m1 = m0
        Do While i < 10
            m2 = m1 Mod 10
            m1 = m1 \ 10
            m3 = m3 & m2
            If m1 = 0 Then Exit Do
            i += 1
        Loop

        If m0 = m3 Then
            t1.Text = "第一題結果:" & m0 & " is a palindrome."
        Else
            t1.Text = "第一題結果:" & m0 & " is not a palindrome."
        End If
    End Sub
    '**********************
    '*11900-940304 Program*
    '**********************
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim h(3), w(3), bmi(3)
        Dim sbmi As Integer
        Dim i = 1
        FileOpen(1, "c:\11900\940304.sm", OpenMode.Input)
        Do While i < 4
            Input(1, h(i)) : Input(1, w(i))
            bmi(i) = w(i) / (h(i) / 100) ^ 2
            i += 1
        Loop
        FileClose(1)
        i = 1
        sbmi = bmi(1)
        Do While i < 4
            If bmi(i) < sbmi Then sbmi = bmi(i)
            i += 1
        Loop

        If sbmi <= 25 And sbmi >= 20 Then
            t2.Text = "第四題結果:最小BMI值=" & sbmi & "，正常"
        Else
            t2.Text = "第四題結果:最小BMI值=" & sbmi & "，不正常"

        End If
    End Sub
    '**********************
    '*11900-940305 Program*
    '**********************
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim a(2, 2), b(2, 2), c(2, 2)
        FileOpen(1, "c:\11900\940305.sm", OpenMode.Input)
        Dim i = 1
        Do While i < 3
            Dim j = 1
            Do While j < 3
                Input(1, a(i, j))
                j += 1
            Loop
            i += 1
        Loop
        i = 1
        Do While i < 3
            Dim j = 1
            Do While j < 3
                Input(1, b(i, j))
                j += 1
            Loop
            i += 1
        Loop
        FileClose(1)
        i = 1
        Do While i < 3
            Dim j = 1
            Do While j < 3
                c(i, j) = a(i, j) + b(i, j)
                j += 1
            Loop
            i += 1
        Loop

        t3.Text = "第五題結果:" & vn & "[" & c(1, 1) & "        " & c(1, 2) & "]" & vn & "[" & c(2, 1) & "    " & c(2, 2) & "]"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Shell("d:\title_d.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Call pd.Print()
    End Sub

    Private Sub pd_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles pd.PrintPage
        Dim m0, m1, m2, m3, m4
        FileOpen(1, "d:\title.txt", OpenMode.Input)
        Input(1, m1) : Input(1, m2) : Input(1, m3) : Input(1, m4)
        FileClose(1)

        m0 = "姓名:[" & m1 & "]    准考證號碼:[" & m3 & "]" & vn
        m0 = m0 & "座號:[" & m2 & "]    考試日期:[" & m4 & "]" & vn & vn

        m0 = m0 & t1.Text & vn & vn
        m0 = m0 & t2.Text & vn & vn
        m0 = m0 & t3.Text & vn & vn

        e.Graphics.DrawString(m0, t1.Font, Brushes.Black, 100, 100)
    End Sub
End Class