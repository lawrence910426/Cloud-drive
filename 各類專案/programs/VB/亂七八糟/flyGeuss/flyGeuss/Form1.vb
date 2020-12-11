Public Class Form1
    Dim pos As Drawing.Point
    Dim Time As Integer
    Dim speedLeft As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OvalShape1.Visible = False
        Dim pt As Drawing.Point
        pt.X = 0
        pt.Y = 497
        loadPosi(pt)
    End Sub
    Sub loadPosi(ByVal point As Drawing.Point)



        LineShape1.X2 = point.X
        LineShape2.Y2 = point.Y
        LineShape3.X2 = point.X
        LineShape3.Y2 = point.Y


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim loadPos As Drawing.Point
        Try
            loadPos.X = Val(TextBox2.Text)

            loadPos.Y = Val(TextBox1.Text)
        Catch ex As Exception
            MsgBox("please enter it properly")
        End Try
        Dim T As Integer
        Dim SH As Integer
        Dim SL As Integer
        Dim t2 As Double
        t2 = loadPos.Y / 10
        If Not (Int(t2) = t2) Then
            If Int(t2) < t2 Then
                If t2 - Int(t2) >= 4 Then
                    t2 = Int(t2)
                Else
                    t2 = Int(t2) + 1

                End If
            End If
        End If
        T = t2

        SL = T * loadPos.X * 2
        For i = 1 To T
            SH = SH + 10 * i



        Next
        T = T / 2
        loadPos.X = SL * 10
        loadPos.Y = 497 - SH * 10
        loadPosi(loadPos)

        speedLeft = SL
        Label1.Text = Str(SH)
        Label2.Text = Str(SL)
        Timer1.Enabled = True
        Time = T
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        '  TextBox4.Text = "-" + TextBox4.Text
        Dim angle As Integer
        Dim speed As Integer
        Try
            angle = Val(TextBox4.Text)
            speed = Val(TextBox3.Text)
        Catch ex As Exception
            MsgBox("input properly")
        End Try
        Dim Xspeed As Integer
        Dim Yspeed As Integer







        Dim loadPos As Drawing.Point
        Yspeed = Math.Sin(angle) * speed   'connect
        Xspeed = Math.Cos(angle) * speed

        loadPos.X = Xspeed
        loadPos.Y = Yspeed







        Dim T As Integer
        Dim SH As Integer
        Dim SL As Integer
        Dim t2 As Double
        t2 = loadPos.Y / 10
        If Not (Int(t2) = t2) Then
            If Int(t2) < t2 Then
                If t2 - Int(t2) >= 4 Then
                    t2 = Int(t2)
                Else
                    t2 = Int(t2) + 1

                End If
            End If
        End If
        T = t2
        SL = T * loadPos.X * 2
        For i = 1 To T
            SH = SH + 10 * i



        Next
        T = T / 2
        loadPos.X = SL * 10
        loadPos.Y = 497 - SH * 10
        loadPosi(loadPos)

        Label1.Text = Str(SH)
        Label2.Text = Str(SL)
        Timer1.Enabled = True

        Dim Loadovl As Drawing.Point
        Loadovl.X = 0
        Loadovl.Y = 437
        OvalShape1.Location = Loadovl
        Time = T
        speedLeft = SL
    End Sub
    Dim Secs As Int16
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Secs = Secs + 1
        Dim ovlLoc As System.Drawing.Point
        OvalShape1.Visible = True
        'ovlLoc.X = Val(Label2.Text)
        'ovlLoc.Y = Val(Label1.Text)
        'y fly
        'X lr
        ovlLoc.Y += (Time - Secs) * 100

        ovlLoc.X += speedLeft * 10






        ' OvalShape1.Location
        OvalShape1.Location = ovlLoc







    End Sub







End Class
