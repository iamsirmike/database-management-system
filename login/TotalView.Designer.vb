<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TotalView
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
        Me.EACONSULTDataSet10 = New EACONSULT.EACONSULTDataSet10()
        Me.TotalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TotalTableAdapter = New EACONSULT.EACONSULTDataSet10TableAdapters.TotalTableAdapter()
        Me.TDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INCOMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EXPENSEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EACONSULTDataSet11 = New EACONSULT.EACONSULTDataSet11()
        Me.TotalBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TotalTableAdapter1 = New EACONSULT.EACONSULTDataSet11TableAdapters.TotalTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EACONSULTDataSet10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EACONSULTDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TDATEDataGridViewTextBoxColumn, Me.INCOMEDataGridViewTextBoxColumn, Me.EXPENSEDataGridViewTextBoxColumn, Me.TOTALDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TotalBindingSource1
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(446, 338)
        Me.DataGridView1.TabIndex = 0
        '
        'EACONSULTDataSet10
        '
        Me.EACONSULTDataSet10.DataSetName = "EACONSULTDataSet10"
        Me.EACONSULTDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TotalBindingSource
        '
        Me.TotalBindingSource.DataMember = "Total"
        Me.TotalBindingSource.DataSource = Me.EACONSULTDataSet10
        '
        'TotalTableAdapter
        '
        Me.TotalTableAdapter.ClearBeforeFill = True
        '
        'TDATEDataGridViewTextBoxColumn
        '
        Me.TDATEDataGridViewTextBoxColumn.DataPropertyName = "TDATE"
        Me.TDATEDataGridViewTextBoxColumn.HeaderText = "TDATE"
        Me.TDATEDataGridViewTextBoxColumn.Name = "TDATEDataGridViewTextBoxColumn"
        '
        'INCOMEDataGridViewTextBoxColumn
        '
        Me.INCOMEDataGridViewTextBoxColumn.DataPropertyName = "INCOME"
        Me.INCOMEDataGridViewTextBoxColumn.HeaderText = "INCOME"
        Me.INCOMEDataGridViewTextBoxColumn.Name = "INCOMEDataGridViewTextBoxColumn"
        '
        'EXPENSEDataGridViewTextBoxColumn
        '
        Me.EXPENSEDataGridViewTextBoxColumn.DataPropertyName = "EXPENSE"
        Me.EXPENSEDataGridViewTextBoxColumn.HeaderText = "EXPENSE"
        Me.EXPENSEDataGridViewTextBoxColumn.Name = "EXPENSEDataGridViewTextBoxColumn"
        '
        'TOTALDataGridViewTextBoxColumn
        '
        Me.TOTALDataGridViewTextBoxColumn.DataPropertyName = "TOTAL"
        Me.TOTALDataGridViewTextBoxColumn.HeaderText = "TOTAL"
        Me.TOTALDataGridViewTextBoxColumn.Name = "TOTALDataGridViewTextBoxColumn"
        '
        'EACONSULTDataSet11
        '
        Me.EACONSULTDataSet11.DataSetName = "EACONSULTDataSet11"
        Me.EACONSULTDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TotalBindingSource1
        '
        Me.TotalBindingSource1.DataMember = "Total"
        Me.TotalBindingSource1.DataSource = Me.EACONSULTDataSet11
        '
        'TotalTableAdapter1
        '
        Me.TotalTableAdapter1.ClearBeforeFill = True
        '
        'TotalView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 338)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "TotalView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TotalView"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EACONSULTDataSet10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EACONSULTDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents EACONSULTDataSet10 As EACONSULT.EACONSULTDataSet10
    Friend WithEvents TotalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TotalTableAdapter As EACONSULT.EACONSULTDataSet10TableAdapters.TotalTableAdapter
    Friend WithEvents TDATEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents INCOMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EXPENSEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTALDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EACONSULTDataSet11 As EACONSULT.EACONSULTDataSet11
    Friend WithEvents TotalBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TotalTableAdapter1 As EACONSULT.EACONSULTDataSet11TableAdapters.TotalTableAdapter
End Class
