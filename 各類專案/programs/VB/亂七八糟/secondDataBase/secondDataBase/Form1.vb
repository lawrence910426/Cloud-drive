Imports System.Threading











Public Class Form1


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: 這行程式碼會將資料載入 'ProgsDataSet.程式' 資料表。您可以視需要進行移動或移除。
        Me.程式TableAdapter.Fill(Me.ProgsDataSet.程式)


    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged


        ' SearchBindingSource1 

        '   SearchTableAdapter2.Update(Database1DataSet2.Search)
        'MsgBox(Str(Database1DataSet1.Search.Item(0).Item(0)))
        ' a.Item(2).Item(2) = "5"
        ' SearchTableAdapter1.Fill(Database1DataSet1.Search)
        ' Me.SearchTableAdapter1.Fill(Me.Database1DataSet1.Search)




    End Sub


    Sub stops() Handles MyBase.FormClosing


    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Validate()
        程式BindingSource.EndEdit()
        Me.程式TableAdapter.Update(Me.ProgsDataSet.程式)
        程式TableAdapter.Update(ProgsDataSet.程式)
        程式BindingSource.ResumeBinding()
    End Sub
End Class
