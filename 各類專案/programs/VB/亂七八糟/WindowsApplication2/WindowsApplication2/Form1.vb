Public Class Form1
    Dim recorder As UShort
    Dim add(100) As Boolean
    Dim minus(100) As Boolean
    Dim times(100) As Boolean
    Dim devided(100) As Boolean
    Dim leftone(100) As Boolean
    Dim rightone(100) As Boolean
    Dim Data(100) As Single
    Dim first As Boolean
    Dim boxControl As Boolean
    Private Sub All_keyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Button1.KeyPress, Button2.KeyPress, Button3.KeyPress, Button4.KeyPress, Button5.KeyPress, Button6.KeyPress, Button7.KeyPress, Button8.KeyPress
        If e.KeyChar = "+" Then
            Button2_Click()
        Else
            If e.KeyChar = "-" Then
                Button3_Click()
            Else
                If e.KeyChar = "*" Then
                    Button4_Click()
                Else
                    If e.KeyChar = "/" Then
                        Button5_Click()
                    Else
                        TextBox1.Text += e.KeyChar
                    End If
                End If
            End If
        End If

    End Sub
    Private Sub box_keyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = "+" Then

            Button2_Click()
            TextBox1.Text = ""
        Else
            If e.KeyChar = "-" Then

                Button3_Click()
                TextBox1.Text = ""
            Else
                If e.KeyChar = "*" Then

                    Button4_Click()
                    TextBox1.Text = ""
                Else
                    If e.KeyChar = "/" Then

                        Button5_Click()

                        TextBox1.Text = ""

                    End If
                End If
            End If

        End If

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox3.Text = Nothing
        recorder = 0
        For i = 1 To 100
            Data(i) = 0
            devided(i) = 0
            times(i) = True
            add(i) = True
            minus(i) = True
            leftone(i) = 1
            rightone(i) = 1
        Next
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click  ' do
        recorder += 1
        Data(recorder) += Val(TextBox1.Text)
        TextBox3.Text += TextBox1.Text
        TextBox1.Text = Nothing
        count()
    End Sub
    Private Sub Button2_Click() Handles Button2.Click '2345 +-*/
        TextBox3.Text += TextBox1.Text
        recorder += 1
        TextBox3.Text += "+"
        add(recorder) = True
        Data(recorder) += Val(TextBox1.Text)
        TextBox1.Text = Nothing
    End Sub

    Private Sub Button3_Click() Handles Button3.Click
        TextBox3.Text += TextBox1.Text
        recorder += 1
        TextBox3.Text += "-"
        minus(recorder) = True
        Data(recorder) += Val(TextBox1.Text)
        TextBox1.Text = Nothing
    End Sub

    Private Sub Button4_Click() Handles Button4.Click
        TextBox3.Text += TextBox1.Text
        recorder += 1
        TextBox3.Text += "*"
        times(recorder) = True
        Data(recorder) += Val(TextBox1.Text)
        TextBox1.Text = Nothing
    End Sub

    Private Sub Button5_Click() Handles Button5.Click
        TextBox3.Text += TextBox1.Text
        recorder += 1
        TextBox3.Text += "/"
        devided(recorder) = True
        Data(recorder) = Val(TextBox1.Text)
        TextBox1.Text = Nothing
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click '(
        TextBox3.Text += TextBox1.Text
        recorder += 1
        TextBox3.Text += "("
        leftone(recorder) = True
        Data(recorder) += Val(TextBox1.Text)
        TextBox1.Text = Nothing
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click  ')
        TextBox3.Text += TextBox1.Text
        recorder += 1
        TextBox3.Text += ")"
        rightone(recorder) = True
        Data(recorder) += Val(TextBox1.Text)
        TextBox1.Text = Nothing
    End Sub

    Sub count()    'next job 分數  ???*??? / ???/???  ok less test
        '分數 約及擴分
        '四則運算 doing
        'time date

        Dim a As Integer = recorder
        Dim a2 As Decimal = Data(1)
        Dim unableFullDev As Boolean = False
        For i = 1 To a
            If add(i) = True Then
                a2 = a2 + Data(i + 1)
            End If
            If minus(i) = True Then
                a2 = a2 - Data(i + 1)
            End If
            If times(i) = True Then
                a2 = a2 * Data(i + 1)
            End If






             



            If devided(i) = True Then
                If a2 = Int(a2 / Data(i + 1)) * Data(i + 1) Then '整除
                    a2 = a2 / Data(i + 1)
                Else
                    If unableFullDev Then

                        MsgBox("unable to all devided")
                        Exit Sub
                    Else
                        Dim j As Integer = 1

                        Do Until add(j) = True

                            If minus(j) = True Then
                                Exit Do
                            End If
                            If Data(j) = 0 Then
                                Exit Do
                            End If
                            j += 1
                            'do code
                            'Data type ? +?-?*?/?
                        Loop
                        j -= 1
                        Dim Data2(100) As Decimal
                        'Dim dev2(100) As Boolean
                        '   Dim times2(100) As Boolean
                        Dim devidedFind As Short
                        Dim timesFind As Short
                        For K As Long = i To j Step 1 'Began Dev (i) or times (i) end dev(j) or times(j)

                            Dim TD(100) As Boolean
                            Dim arrayBig As Single
                            'arraybig =1   2   3
                            arrayBig = K        '          ? * ? / ?
                            If devided(K) = True Then
                                devidedFind += 1
                                '  Data2(K - devidedFind + 1) = Data(i + K) 'wrong
                                Data2(j - devidedFind + 1) = Data(K)
                                times(K) = devided(K)
                                devided(K) = 0
                            Else
                                timesFind += 1
                                Data2(K) = Data(K)
                                times(K) = devided(K)
                                devided(K) = 0
                            End If
                            'wrong data change but times and dev doesn't change



                        Next K
                        'flush
                        For i2 = i To j
                            Data(i2) = Data2(i2)


                        Next

                        unableFullDev = True
                        i = i - (i - j)
                    End If
                End If

            End If
        Next i


        MsgBox(Str(a2))
    End Sub


 
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If Button9.Text = "a/b" Then
            Button9.Text = "a.bcdefg"
        Else
            Button9.Text = "a/b"
        End If
    End Sub


End Class
