<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Guarantorsview
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
        Me.EACONSULTDataSet6 = New EACONSULT.EACONSULTDataSet6()
        Me.GuarantorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GuarantorsTableAdapter = New EACONSULT.EACONSULTDataSet6TableAdapters.GuarantorsTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIRSTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SURNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RELIGIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RADDRESSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TELEPHONEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMAILDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OCCUPATIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OADDRESSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OFFICETELDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDTYPEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDNUMBERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REGDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PHOTODataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EACONSULTDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GuarantorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FIRSTNAMEDataGridViewTextBoxColumn, Me.SURNAMEDataGridViewTextBoxColumn, Me.DOBDataGridViewTextBoxColumn, Me.RELIGIONDataGridViewTextBoxColumn, Me.RADDRESSDataGridViewTextBoxColumn, Me.TELEPHONEDataGridViewTextBoxColumn, Me.EMAILDataGridViewTextBoxColumn, Me.OCCUPATIONDataGridViewTextBoxColumn, Me.OADDRESSDataGridViewTextBoxColumn, Me.OFFICETELDataGridViewTextBoxColumn, Me.IDTYPEDataGridViewTextBoxColumn, Me.IDNUMBERDataGridViewTextBoxColumn, Me.REGDATEDataGridViewTextBoxColumn, Me.PHOTODataGridViewImageColumn})
        Me.DataGridView1.DataSource = Me.GuarantorsBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1066, 494)
        Me.DataGridView1.TabIndex = 0
        '
        'EACONSULTDataSet6
        '
        Me.EACONSULTDataSet6.DataSetName = "EACONSULTDataSet6"
        Me.EACONSULTDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GuarantorsBindingSource
        '
        Me.GuarantorsBindingSource.DataMember = "Guarantors"
        Me.GuarantorsBindingSource.DataSource = Me.EACONSULTDataSet6
        '
        'GuarantorsTableAdapter
        '
        Me.GuarantorsTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'FIRSTNAMEDataGridViewTextBoxColumn
        '
        Me.FIRSTNAMEDataGridViewTextBoxColumn.DataPropertyName = "FIRSTNAME"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.HeaderText = "FIRSTNAME"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.Name = "FIRSTNAMEDataGridViewTextBoxColumn"
        '
        'SURNAMEDataGridViewTextBoxColumn
        '
        Me.SURNAMEDataGridViewTextBoxColumn.DataPropertyName = "SURNAME"
        Me.SURNAMEDataGridViewTextBoxColumn.HeaderText = "SURNAME"
        Me.SURNAMEDataGridViewTextBoxColumn.Name = "SURNAMEDataGridViewTextBoxColumn"
        '
        'DOBDataGridViewTextBoxColumn
        '
        Me.DOBDataGridViewTextBoxColumn.DataPropertyName = "DOB"
        Me.DOBDataGridViewTextBoxColumn.HeaderText = "DOB"
        Me.DOBDataGridViewTextBoxColumn.Name = "DOBDataGridViewTextBoxColumn"
        '
        'RELIGIONDataGridViewTextBoxColumn
        '
        Me.RELIGIONDataGridViewTextBoxColumn.DataPropertyName = "RELIGION"
        Me.RELIGIONDataGridViewTextBoxColumn.HeaderText = "RELIGION"
        Me.RELIGIONDataGridViewTextBoxColumn.Name = "RELIGIONDataGridViewTextBoxColumn"
        '
        'RADDRESSDataGridViewTextBoxColumn
        '
        Me.RADDRESSDataGridViewTextBoxColumn.DataPropertyName = "R_ADDRESS"
        Me.RADDRESSDataGridViewTextBoxColumn.HeaderText = "R_ADDRESS"
        Me.RADDRESSDataGridViewTextBoxColumn.Name = "RADDRESSDataGridViewTextBoxColumn"
        '
        'TELEPHONEDataGridViewTextBoxColumn
        '
        Me.TELEPHONEDataGridViewTextBoxColumn.DataPropertyName = "TELEPHONE"
        Me.TELEPHONEDataGridViewTextBoxColumn.HeaderText = "TELEPHONE"
        Me.TELEPHONEDataGridViewTextBoxColumn.Name = "TELEPHONEDataGridViewTextBoxColumn"
        '
        'EMAILDataGridViewTextBoxColumn
        '
        Me.EMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL"
        Me.EMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL"
        Me.EMAILDataGridViewTextBoxColumn.Name = "EMAILDataGridViewTextBoxColumn"
        '
        'OCCUPATIONDataGridViewTextBoxColumn
        '
        Me.OCCUPATIONDataGridViewTextBoxColumn.DataPropertyName = "OCCUPATION"
        Me.OCCUPATIONDataGridViewTextBoxColumn.HeaderText = "OCCUPATION"
        Me.OCCUPATIONDataGridViewTextBoxColumn.Name = "OCCUPATIONDataGridViewTextBoxColumn"
        '
        'OADDRESSDataGridViewTextBoxColumn
        '
        Me.OADDRESSDataGridViewTextBoxColumn.DataPropertyName = "O_ADDRESS"
        Me.OADDRESSDataGridViewTextBoxColumn.HeaderText = "O_ADDRESS"
        Me.OADDRESSDataGridViewTextBoxColumn.Name = "OADDRESSDataGridViewTextBoxColumn"
        '
        'OFFICETELDataGridViewTextBoxColumn
        '
        Me.OFFICETELDataGridViewTextBoxColumn.DataPropertyName = "OFFICE_TEL"
        Me.OFFICETELDataGridViewTextBoxColumn.HeaderText = "OFFICE_TEL"
        Me.OFFICETELDataGridViewTextBoxColumn.Name = "OFFICETELDataGridViewTextBoxColumn"
        '
        'IDTYPEDataGridViewTextBoxColumn
        '
        Me.IDTYPEDataGridViewTextBoxColumn.DataPropertyName = "ID_TYPE"
        Me.IDTYPEDataGridViewTextBoxColumn.HeaderText = "ID_TYPE"
        Me.IDTYPEDataGridViewTextBoxColumn.Name = "IDTYPEDataGridViewTextBoxColumn"
        '
        'IDNUMBERDataGridViewTextBoxColumn
        '
        Me.IDNUMBERDataGridViewTextBoxColumn.DataPropertyName = "ID_NUMBER"
        Me.IDNUMBERDataGridViewTextBoxColumn.HeaderText = "ID_NUMBER"
        Me.IDNUMBERDataGridViewTextBoxColumn.Name = "IDNUMBERDataGridViewTextBoxColumn"
        '
        'REGDATEDataGridViewTextBoxColumn
        '
        Me.REGDATEDataGridViewTextBoxColumn.DataPropertyName = "REG_DATE"
        Me.REGDATEDataGridViewTextBoxColumn.HeaderText = "REG_DATE"
        Me.REGDATEDataGridViewTextBoxColumn.Name = "REGDATEDataGridViewTextBoxColumn"
        '
        'PHOTODataGridViewImageColumn
        '
        Me.PHOTODataGridViewImageColumn.DataPropertyName = "PHOTO"
        Me.PHOTODataGridViewImageColumn.HeaderText = "PHOTO"
        Me.PHOTODataGridViewImageColumn.Name = "PHOTODataGridViewImageColumn"
        '
        'Guarantorsview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1066, 494)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Guarantorsview"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guarantorsview"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EACONSULTDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GuarantorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents EACONSULTDataSet6 As EACONSULT.EACONSULTDataSet6
    Friend WithEvents GuarantorsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GuarantorsTableAdapter As EACONSULT.EACONSULTDataSet6TableAdapters.GuarantorsTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FIRSTNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SURNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DOBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RELIGIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RADDRESSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TELEPHONEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMAILDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OCCUPATIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OADDRESSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OFFICETELDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDTYPEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDNUMBERDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REGDATEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PHOTODataGridViewImageColumn As System.Windows.Forms.DataGridViewImageColumn
End Class
