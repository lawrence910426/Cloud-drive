Public Class Form1
    Dim linePos(13, 2) As Int16

#If CONFIG = "Debug" Then
#Region "lll()"



#End Region

#End If

    Sub lll()

    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load




        Dim picbox1 As New PictureBox



        picbox1.ImageLocation = "ddd"
        Me.Controls.Add(picbox1)
        Dim location As Drawing.Point
        location.X = 1380 / 2
        location.Y = 780 / 4 / 3 + 25
        picbox1.Location = location
        Dim siz As Drawing.Size
        siz.Height = 10
        siz.Width = 10
        picbox1.Size = siz
        'img1.FromFile("D:\pic\pic1.jpg")
        '  Button1.Image = img1
    End Sub

    Sub form1_click(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown
        Dim location As Drawing.Point
        location = e.Location
        If location.Y < linePos(1, 2) Then
            If location.X > 0 And location.X < linePos(1, 1) Then












            End If

        End If







        '  Me.Controls.Add((btn2))
    End Sub





End Class
Namespace a
    Class a
        Sub a()
            ' If AddressOf a = "" Then

















            ' End If









        End Sub









    End Class



End Namespace