<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.行程金額DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.行程名稱DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.編號DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.行程金額對照表BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New WindowsApplication1.Database1DataSet()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.行程金額對照表TableAdapter = New WindowsApplication1.Database1DataSetTableAdapters.行程金額對照表TableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.行程金額對照表BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.行程金額DataGridViewTextBoxColumn, Me.行程名稱DataGridViewTextBoxColumn, Me.編號DataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.行程金額對照表BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(343, 150)
        Me.DataGridView1.TabIndex = 0
        '
        '行程金額DataGridViewTextBoxColumn
        '
        Me.行程金額DataGridViewTextBoxColumn.DataPropertyName = "行程金額"
        Me.行程金額DataGridViewTextBoxColumn.HeaderText = "行程金額"
        Me.行程金額DataGridViewTextBoxColumn.Name = "行程金額DataGridViewTextBoxColumn"
        '
        '行程名稱DataGridViewTextBoxColumn
        '
        Me.行程名稱DataGridViewTextBoxColumn.DataPropertyName = "行程名稱"
        Me.行程名稱DataGridViewTextBoxColumn.HeaderText = "行程名稱"
        Me.行程名稱DataGridViewTextBoxColumn.Name = "行程名稱DataGridViewTextBoxColumn"
        '
        '編號DataGridViewTextBoxColumn
        '
        Me.編號DataGridViewTextBoxColumn.DataPropertyName = "編號"
        Me.編號DataGridViewTextBoxColumn.HeaderText = "編號"
        Me.編號DataGridViewTextBoxColumn.Name = "編號DataGridViewTextBoxColumn"
        '
        '行程金額對照表BindingSource
        '
        Me.行程金額對照表BindingSource.DataMember = "行程金額對照表"
        Me.行程金額對照表BindingSource.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(453, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 73)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Flush the poo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        '行程金額對照表TableAdapter
        '
        Me.行程金額對照表TableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(451, 108)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(132, 26)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "DownLoadNewRecord"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 261)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.行程金額對照表BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Database1DataSet As WindowsApplication1.Database1DataSet
    Friend WithEvents 行程金額對照表BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 行程金額對照表TableAdapter As WindowsApplication1.Database1DataSetTableAdapters.行程金額對照表TableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents 行程金額DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 行程名稱DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 編號DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
