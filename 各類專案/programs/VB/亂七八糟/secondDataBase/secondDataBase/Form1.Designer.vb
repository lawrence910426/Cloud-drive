<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ProgsDataSet = New secondDataBase.ProgsDataSet()
        Me.程式BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.程式TableAdapter = New secondDataBase.ProgsDataSetTableAdapters.程式TableAdapter()
        Me.識別碼DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.名DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.位置DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.語言DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.類別DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.連接到DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.運用到DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.優先完成順序DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.程式BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.識別碼DataGridViewTextBoxColumn, Me.名DataGridViewTextBoxColumn, Me.位置DataGridViewTextBoxColumn, Me.語言DataGridViewTextBoxColumn, Me.類別DataGridViewTextBoxColumn, Me.連接到DataGridViewTextBoxColumn, Me.運用到DataGridViewTextBoxColumn, Me.優先完成順序DataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.程式BindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(105, 32)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(1051, 589)
        Me.DataGridView2.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(-1, 102)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ProgsDataSet
        '
        Me.ProgsDataSet.DataSetName = "ProgsDataSet"
        Me.ProgsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '程式BindingSource
        '
        Me.程式BindingSource.DataMember = "程式"
        Me.程式BindingSource.DataSource = Me.ProgsDataSet
        '
        '程式TableAdapter
        '
        Me.程式TableAdapter.ClearBeforeFill = True
        '
        '識別碼DataGridViewTextBoxColumn
        '
        Me.識別碼DataGridViewTextBoxColumn.DataPropertyName = "識別碼"
        Me.識別碼DataGridViewTextBoxColumn.HeaderText = "識別碼"
        Me.識別碼DataGridViewTextBoxColumn.Name = "識別碼DataGridViewTextBoxColumn"
        '
        '名DataGridViewTextBoxColumn
        '
        Me.名DataGridViewTextBoxColumn.DataPropertyName = "名"
        Me.名DataGridViewTextBoxColumn.HeaderText = "名"
        Me.名DataGridViewTextBoxColumn.Name = "名DataGridViewTextBoxColumn"
        '
        '位置DataGridViewTextBoxColumn
        '
        Me.位置DataGridViewTextBoxColumn.DataPropertyName = "位置"
        Me.位置DataGridViewTextBoxColumn.HeaderText = "位置"
        Me.位置DataGridViewTextBoxColumn.Name = "位置DataGridViewTextBoxColumn"
        '
        '語言DataGridViewTextBoxColumn
        '
        Me.語言DataGridViewTextBoxColumn.DataPropertyName = "語言"
        Me.語言DataGridViewTextBoxColumn.HeaderText = "語言"
        Me.語言DataGridViewTextBoxColumn.Name = "語言DataGridViewTextBoxColumn"
        '
        '類別DataGridViewTextBoxColumn
        '
        Me.類別DataGridViewTextBoxColumn.DataPropertyName = "類別"
        Me.類別DataGridViewTextBoxColumn.HeaderText = "類別"
        Me.類別DataGridViewTextBoxColumn.Name = "類別DataGridViewTextBoxColumn"
        '
        '連接到DataGridViewTextBoxColumn
        '
        Me.連接到DataGridViewTextBoxColumn.DataPropertyName = "連接到"
        Me.連接到DataGridViewTextBoxColumn.HeaderText = "連接到"
        Me.連接到DataGridViewTextBoxColumn.Name = "連接到DataGridViewTextBoxColumn"
        '
        '運用到DataGridViewTextBoxColumn
        '
        Me.運用到DataGridViewTextBoxColumn.DataPropertyName = "運用到"
        Me.運用到DataGridViewTextBoxColumn.HeaderText = "運用到"
        Me.運用到DataGridViewTextBoxColumn.Name = "運用到DataGridViewTextBoxColumn"
        '
        '優先完成順序DataGridViewTextBoxColumn
        '
        Me.優先完成順序DataGridViewTextBoxColumn.DataPropertyName = "優先完成順序"
        Me.優先完成順序DataGridViewTextBoxColumn.HeaderText = "優先完成順序"
        Me.優先完成順序DataGridViewTextBoxColumn.Name = "優先完成順序DataGridViewTextBoxColumn"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1356, 741)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView2)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.程式BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ProgsDataSet As secondDataBase.ProgsDataSet
    Friend WithEvents 程式BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 程式TableAdapter As secondDataBase.ProgsDataSetTableAdapters.程式TableAdapter
    Friend WithEvents 識別碼DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 名DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 位置DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 語言DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 類別DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 連接到DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 運用到DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 優先完成順序DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
