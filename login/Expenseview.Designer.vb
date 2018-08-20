<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Expenseview
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EACONSULTDataSet9 = New EACONSULT.EACONSULTDataSet9()
        Me.ExpenseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExpenseTableAdapter = New EACONSULT.EACONSULTDataSet9TableAdapters.ExpenseTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurposeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EACONSULTDataSet9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpenseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.PurposeDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn, Me.IDescriptionDataGridViewTextBoxColumn, Me.IDateDataGridViewTextBoxColumn, Me.TOTALDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ExpenseBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(648, 429)
        Me.DataGridView1.TabIndex = 0
        '
        'EACONSULTDataSet9
        '
        Me.EACONSULTDataSet9.DataSetName = "EACONSULTDataSet9"
        Me.EACONSULTDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ExpenseBindingSource
        '
        Me.ExpenseBindingSource.DataMember = "Expense"
        Me.ExpenseBindingSource.DataSource = Me.EACONSULTDataSet9
        '
        'ExpenseTableAdapter
        '
        Me.ExpenseTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'PurposeDataGridViewTextBoxColumn
        '
        Me.PurposeDataGridViewTextBoxColumn.DataPropertyName = "Purpose"
        Me.PurposeDataGridViewTextBoxColumn.HeaderText = "Purpose"
        Me.PurposeDataGridViewTextBoxColumn.Name = "PurposeDataGridViewTextBoxColumn"
        '
        'AmountDataGridViewTextBoxColumn
        '
        Me.AmountDataGridViewTextBoxColumn.DataPropertyName = "Amount"
        Me.AmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
        '
        'IDescriptionDataGridViewTextBoxColumn
        '
        Me.IDescriptionDataGridViewTextBoxColumn.DataPropertyName = "IDescription"
        Me.IDescriptionDataGridViewTextBoxColumn.HeaderText = "IDescription"
        Me.IDescriptionDataGridViewTextBoxColumn.Name = "IDescriptionDataGridViewTextBoxColumn"
        '
        'IDateDataGridViewTextBoxColumn
        '
        Me.IDateDataGridViewTextBoxColumn.DataPropertyName = "IDate"
        Me.IDateDataGridViewTextBoxColumn.HeaderText = "IDate"
        Me.IDateDataGridViewTextBoxColumn.Name = "IDateDataGridViewTextBoxColumn"
        '
        'TOTALDataGridViewTextBoxColumn
        '
        Me.TOTALDataGridViewTextBoxColumn.DataPropertyName = "TOTAL"
        Me.TOTALDataGridViewTextBoxColumn.HeaderText = "TOTAL"
        Me.TOTALDataGridViewTextBoxColumn.Name = "TOTALDataGridViewTextBoxColumn"
        '
        'Expenseview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 429)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Expenseview"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Expenseview"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EACONSULTDataSet9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpenseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents EACONSULTDataSet9 As EACONSULT.EACONSULTDataSet9
    Friend WithEvents ExpenseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ExpenseTableAdapter As EACONSULT.EACONSULTDataSet9TableAdapters.ExpenseTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PurposeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTALDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
