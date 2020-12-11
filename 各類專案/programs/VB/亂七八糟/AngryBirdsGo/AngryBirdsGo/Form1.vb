Imports System.Threading









Public Class Form1
    Dim imageThread As New Thread(AddressOf imageControlUnit)





    Private Sub imageControlUnit()
        Dim max(1024) As Byte
        Dim container As PowerPacks.ShapeContainer
        Dim i As Integer = 0
        Dim Pos(788) As Byte
        For Each z In max

            Pos(i) = z
            i += 1

            If i = 788 Then
                Exit For
            End If
        Next
        ' make max to arrayA





        For i2 As Double = 0 To 788
            Dim line As New Microsoft.VisualBasic.PowerPacks.LineShape(Pos(i2), i2, Pos(i2 + 1), i2 + 1)
            container = New PowerPacks.ShapeContainer()
            container.Shapes.Add(line)
retry:
            Try
                Me.Controls.Add(container)
            Catch ex As Exception
                ProgressBar1.PerformStep()
                Beep()
                GoTo retry

            End Try




        Next
        For X = 1 To 100

        Next



    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        imageControlUnit()
        Stop
        End
    End Sub
    Shadows Sub closing() Handles MyBase.FormClosing
        imageThread.Abort()
    End Sub



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        imageThread.IsBackground = True
        CheckForIllegalCrossThreadCalls = False
        Beep()

        Dim b(10, 10) As Array
        MsgBox(b.ToString)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        imageThread.Start()
    End Sub
End Class
