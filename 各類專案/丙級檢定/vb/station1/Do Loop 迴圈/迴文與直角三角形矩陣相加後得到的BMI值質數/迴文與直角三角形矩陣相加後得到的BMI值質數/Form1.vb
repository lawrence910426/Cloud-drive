Public Class Form1
    Dim vn = vbNewLine
    '**********************
    '*11900-940301 Program*
    '**********************
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim m0, m1, m2, m3, m4
        FileOpen(1, "c:/11900/940301.sm", OpenMode.Input)
        Input(1, m0)
        FileClose(1)

        m1 = m0
        Do
            m2 = m1 \ 10
            m3 = m1 Mod 10
            m4 = m4 & m3
            If m2 = 0 Then
                Exit Do
            Else
                m1 = m2
            End If
        Loop While True

        If m0 = m4 Then
            TextBox1.Text = "第一題結果:" & m0 & " is a palindrome."
        Else
            TextBox1.Text = "第一題結果:" & m0 & " is not a palindrome."
        End If
    End Sub
    '**********************
    '*11900-940302 Program*
    '**********************
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim m0, m1
        FileOpen(1, "c:/11900/940302.sm", OpenMode.Input)
        Input(1, m0)
        FileClose(1)
        Dim i = 1

        Do
            Dim j = 1
            Do
                m1 = m1 & j
                j += 1
            Loop While j <= i
            m1 = m1 & vn
            i += 1
        Loop While i <= m0

        TextBox2.Text = "第二題結果:" & vn & m1

    End Sub
    '**********************
    '*11900-940303 Program*
    '**********************
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim m0, m1
        FileOpen(1, "c:/11900/940303.sm", OpenMode.Input)
        Input(1, m0)
        FileClose(1)
        Dim i = 1
        Do
            If m0 Mod i = 0 Then m1 += 1
            i += 1
        Loop While i <= m0

        If m1 = 2 Then
            TextBox3.Text = "第三題結果:" & m0 & " is a prime number."
        Else
            TextBox3.Text = "第三題結果:" & m0 & " is not a prime number."
        End If
    End Sub
    '**********************
    '*11900-940304 Program*
    '**********************
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim h(3), w(3), bmi(3)
        Dim sbmi As Integer

        FileOpen(1, "c:/11900/940304.sm", OpenMode.Input)
        Dim i = 1
        Do
            Input(1, h(i)) : Input(1, w(i))
            bmi(i) = w(i) / (h(i) / 100) ^ 2
            i += 1
        Loop While i <= 3
        FileClose(1)
        sbmi = bmi(1)
        i = 1
        Do
            If sbmi > bmi(i) Then sbmi = bmi(i)
            i += 1
        Loop While i <= 3

        If sbmi <= 25 And sbmi >= 20 Then
            TextBox4.Text = "第四題結果:最小BMI值=" & sbmi & "，正常"
        Else
            TextBox4.Text = "第四題結果:最小BMI值=" & sbmi & "，不正常"
        End If
    End Sub
    '**********************
    '*11900-940305 Program*
    '**********************
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim a(2, 2), b(2, 2), c(2, 2)
        FileOpen(1, "c:/11900/940305.sm", OpenMode.Input)
        Dim i = 1

        Do
            Dim j = 1
            Do
                Input(1, a(i, j))
                j += 1
            Loop While j <= 2
            i += 1
        Loop While i <= 2

        i = 1
        Do
            Dim j = 1
            Do
                Input(1, b(i, j))
                j += 1
            Loop While j <= 2
            i += 1
        Loop While i <= 2
        FileClose(1)
        i = 1
        Do
            Dim j = 1
            Do
                c(i, j) = a(i, j) + b(i, j)
                j += 1
            Loop While j <= 2
            i += 1
        Loop While i <= 2

        TextBox5.Text = "第五題結果:" & vn & "[" & c(1, 1) & "        " & c(1, 2) & "]" & vn & "[" & c(2, 1) & "    " & c(2, 2) & "]"
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Shell("D:\title_d.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Call pd.Print()
    End Sub

    Private Sub pd_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles pd.PrintPage
        Dim m0, m1, m2, m3, m4 As String
        FileOpen(1, "D:\title.txt", OpenMode.Input)
        Input(1, m1) : Input(1, m2) : Input(1, m3) : Input(1, m4)
        FileClose(1)

        m0 = "姓名:[" & m1 & "]    准考證號碼:[" & m3 & "]" & vn
        m0 = m0 & "座號:[" & m2 & "]    考試日期:[" & m4 & "]" & vn & vn

        m0 = m0 & TextBox1.Text & vn & vn
        m0 = m0 & TextBox2.Text & vn & vn
        m0 = m0 & TextBox3.Text & vn & vn
        m0 = m0 & TextBox4.Text & vn & vn
        m0 = m0 & TextBox5.Text & vn & vn

        e.Graphics.DrawString(m0, TextBox1.Font, Brushes.Black, 150, 100)
    End Sub
End Class
