Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: 這行程式碼會將資料載入 '吳邦寧DataSet.test' 資料表。您可以視需要進行移動或移除。
        Me.TestTableAdapter.Fill(Me.吳邦寧DataSet.test)

    End Sub
End Class