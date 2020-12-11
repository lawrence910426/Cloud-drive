<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.吳邦寧DataSet = New WindowsApplication1.吳邦寧DataSet()
        Me.TestBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestTableAdapter = New WindowsApplication1.吳邦寧DataSetTableAdapters.testTableAdapter()
        Me.姓名DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScoreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.學生編號DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.吳邦寧DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.姓名DataGridViewTextBoxColumn, Me.ScoreDataGridViewTextBoxColumn, Me.學生編號DataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TestBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(293, 93)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(418, 150)
        Me.DataGridView1.TabIndex = 0
        '
        '吳邦寧DataSet
        '
        Me.吳邦寧DataSet.DataSetName = "吳邦寧DataSet"
        Me.吳邦寧DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TestBindingSource
        '
        Me.TestBindingSource.DataMember = "test"
        Me.TestBindingSource.DataSource = Me.吳邦寧DataSet
        '
        'TestTableAdapter
        '
        Me.TestTableAdapter.ClearBeforeFill = True
        '
        '姓名DataGridViewTextBoxColumn
        '
        Me.姓名DataGridViewTextBoxColumn.DataPropertyName = "姓名"
        Me.姓名DataGridViewTextBoxColumn.HeaderText = "姓名"
        Me.姓名DataGridViewTextBoxColumn.Name = "姓名DataGridViewTextBoxColumn"
        '
        'ScoreDataGridViewTextBoxColumn
        '
        Me.ScoreDataGridViewTextBoxColumn.DataPropertyName = "Score"
        Me.ScoreDataGridViewTextBoxColumn.HeaderText = "Score"
        Me.ScoreDataGridViewTextBoxColumn.Name = "ScoreDataGridViewTextBoxColumn"
        '
        '學生編號DataGridViewTextBoxColumn
        '
        Me.學生編號DataGridViewTextBoxColumn.DataPropertyName = "學生編號"
        Me.學生編號DataGridViewTextBoxColumn.HeaderText = "學生編號"
        Me.學生編號DataGridViewTextBoxColumn.Name = "學生編號DataGridViewTextBoxColumn"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 261)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.吳邦寧DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents 吳邦寧DataSet As WindowsApplication1.吳邦寧DataSet
    Friend WithEvents TestBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TestTableAdapter As WindowsApplication1.吳邦寧DataSetTableAdapters.testTableAdapter
    Friend WithEvents 姓名DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ScoreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 學生編號DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
