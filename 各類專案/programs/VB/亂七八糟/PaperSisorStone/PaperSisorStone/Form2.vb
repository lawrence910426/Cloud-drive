Public Class Form2
    Dim DelPlsSin As SByte

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DelPlsSin = 1
        Button1.Text = "Finish"
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Text = "Sign In" Then
            DelPlsSin = 3
        End If

        Select Case DelPlsSin
            Case 1
                Try
                    My.Computer.FileSystem.CreateDirectory("D:\PaperSisorStoneGame\Game\DATA\")
                    Dim please As System.IO.FileStream
                    please = System.IO.File.Create("D:\PaperSisorStoneGame\Game\DATA\" & TextBox1.Text & "please.txt")
                    please.Close()
                    Dim playtimes As System.IO.FileStream
                    playtimes = System.IO.File.Create("D:\PaperSisorStoneGame\Game\DATA\" & TextBox1.Text & "playtimes.txt")
                    playtimes.Close()
                    Dim loose As System.IO.FileStream
                    loose = System.IO.File.Create("D:\PaperSisorStoneGame\Game\DATA\" & TextBox1.Text & "loose.txt")
                    loose.Close()
                    Dim win As System.IO.FileStream
                    win = System.IO.File.Create("D:\PaperSisorStoneGame\Game\DATA\" & TextBox1.Text & "win.txt")
                    win.Close()
                    Beep()
                Catch ex As Exception
                    MsgBox("Error")
                End Try
            Case 2
                Try
                    My.Computer.FileSystem.DeleteFile("D:\PaperSisorStoneGame\Game\DATA\" & TextBox1.Text & "win.txt")
                    My.Computer.FileSystem.DeleteFile("D:\PaperSisorStoneGame\Game\DATA\" & TextBox1.Text & "playtimes.txt")
                    My.Computer.FileSystem.DeleteFile("D:\PaperSisorStoneGame\Game\DATA\" & TextBox1.Text & "loose.txt")
                    My.Computer.FileSystem.DeleteFile("D:\PaperSisorStoneGame\Game\DATA\" & TextBox1.Text & "please.txt")
                    Button1.Text = "Sign In"
                Catch ex As Exception
                    MsgBox("Error")
                Finally
                    Beep()
                End Try
            Case 3
                Try
                    Dim srOpenPlease As New IO.StreamReader("D:\PaperSisorStoneGame\Game\DATA\" & TextBox1.Text & "please.txt")
                    Form1.B1 = Val(srOpenPlease.ReadToEnd())
                    srOpenPlease.Close()
                    Dim srOpenWin As New IO.StreamReader("D:\PaperSisorStoneGame\Game\DATA\" & TextBox1.Text & "win.txt")
                    Form1.A1 = Val(srOpenWin.ReadToEnd())
                    srOpenPlease.Close()
                    Dim srOpenLoose As New IO.StreamReader("D:\PaperSisorStoneGame\Game\DATA\" & TextBox1.Text & "loose.txt")
                    Form1.A4 = Val(srOpenLoose.ReadToEnd())
                    srOpenPlease.Close()
                    Dim srOpenPlaytimes As New IO.StreamReader("D:\PaperSisorStoneGame\Game\DATA\" & TextBox1.Text & "playtimes.txt")
                    Form1.z = Val(srOpenPlaytimes.ReadToEnd())
                    srOpenPlease.Close()
                    Timer1.Enabled = False
                    Form1.Visible = True
                Catch
                    MsgBox("Error")
                Finally
                    Beep()
                End Try
        End Select
        Button1.Text = "Sign In"
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        DelPlsSin = 2
        Button1.Text = "Delete"
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form1.Visible = False
        Try
            Dim test As New IO.StreamReader("D:\PaperSisorStoneGame\System\DownLoaded.txt")
        Catch ex As Exception
Questioner:
            If MsgBox("您尚未安裝程式，按下確認來安裝", vbAbort + vbOKCancel) Then
                Try
                    Shell("D:\GameDownLaoder.exe")
                Catch ex2 As Exception
                    MsgBox("請把下載器放在D槽")
                    GoTo Questioner
                End Try
            Else
                GoTo Questioner
            End If
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Form1.Visible = False
        Me.Visible = True
    End Sub
End Class