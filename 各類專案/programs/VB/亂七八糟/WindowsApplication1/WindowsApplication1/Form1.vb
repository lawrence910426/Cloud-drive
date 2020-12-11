








Public Class Form1
    Dim Array(100) As System.Array
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: 這行程式碼會將資料載入 'Database1DataSet.行程金額對照表' 資料表。您可以視需要進行移動或移除。
        行程金額對照表TableAdapter.Fill(Me.Database1DataSet.行程金額對照表)
        Main()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            行程金額對照表TableAdapter.Update(Database1DataSet.行程金額對照表)
        Catch ex As Exception
            MsgBox("儲存失敗")
        End Try
    End Sub
    Sub Main()
        Dim a(10) As Integer
        ' 行程金額對照表BindingSource.CopyTo(Array, 1)





    End Sub





    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        行程金額對照表TableAdapter.Fill(Database1DataSet.行程金額對照表)

    End Sub
End Class
