<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class APPLICANTSVIEW
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
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIRSTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LASTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GENDERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MSTATUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NATIONALITYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PHONEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMAILDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RADDRESSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ECNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ECONTACTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LSATTENDEDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EDUQUALIFICATIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OTHERQUALIFICATIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REGDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhotoDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ApplicantBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EACONSULTDataSet1 = New EACONSULT.EACONSULTDataSet1()
        Me.ApplicantTableAdapter = New EACONSULT.EACONSULTDataSet1TableAdapters.ApplicantTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApplicantBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EACONSULTDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FIRSTNAMEDataGridViewTextBoxColumn, Me.LASTNAMEDataGridViewTextBoxColumn, Me.DOBDataGridViewTextBoxColumn, Me.GENDERDataGridViewTextBoxColumn, Me.MSTATUSDataGridViewTextBoxColumn, Me.NATIONALITYDataGridViewTextBoxColumn, Me.PHONEDataGridViewTextBoxColumn, Me.EMAILDataGridViewTextBoxColumn, Me.RADDRESSDataGridViewTextBoxColumn, Me.ECNAMEDataGridViewTextBoxColumn, Me.ECONTACTDataGridViewTextBoxColumn, Me.LSATTENDEDDataGridViewTextBoxColumn, Me.EDUQUALIFICATIONDataGridViewTextBoxColumn, Me.OTHERQUALIFICATIONDataGridViewTextBoxColumn, Me.REGDATEDataGridViewTextBoxColumn, Me.PhotoDataGridViewImageColumn})
        Me.DataGridView1.DataSource = Me.ApplicantBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(0, 63)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1081, 489)
        Me.DataGridView1.TabIndex = 0
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
        'LASTNAMEDataGridViewTextBoxColumn
        '
        Me.LASTNAMEDataGridViewTextBoxColumn.DataPropertyName = "LASTNAME"
        Me.LASTNAMEDataGridViewTextBoxColumn.HeaderText = "LASTNAME"
        Me.LASTNAMEDataGridViewTextBoxColumn.Name = "LASTNAMEDataGridViewTextBoxColumn"
        '
        'DOBDataGridViewTextBoxColumn
        '
        Me.DOBDataGridViewTextBoxColumn.DataPropertyName = "DOB"
        Me.DOBDataGridViewTextBoxColumn.HeaderText = "DOB"
        Me.DOBDataGridViewTextBoxColumn.Name = "DOBDataGridViewTextBoxColumn"
        '
        'GENDERDataGridViewTextBoxColumn
        '
        Me.GENDERDataGridViewTextBoxColumn.DataPropertyName = "GENDER"
        Me.GENDERDataGridViewTextBoxColumn.HeaderText = "GENDER"
        Me.GENDERDataGridViewTextBoxColumn.Name = "GENDERDataGridViewTextBoxColumn"
        '
        'MSTATUSDataGridViewTextBoxColumn
        '
        Me.MSTATUSDataGridViewTextBoxColumn.DataPropertyName = "M_STATUS"
        Me.MSTATUSDataGridViewTextBoxColumn.HeaderText = "M_STATUS"
        Me.MSTATUSDataGridViewTextBoxColumn.Name = "MSTATUSDataGridViewTextBoxColumn"
        '
        'NATIONALITYDataGridViewTextBoxColumn
        '
        Me.NATIONALITYDataGridViewTextBoxColumn.DataPropertyName = "NATIONALITY"
        Me.NATIONALITYDataGridViewTextBoxColumn.HeaderText = "NATIONALITY"
        Me.NATIONALITYDataGridViewTextBoxColumn.Name = "NATIONALITYDataGridViewTextBoxColumn"
        '
        'PHONEDataGridViewTextBoxColumn
        '
        Me.PHONEDataGridViewTextBoxColumn.DataPropertyName = "PHONE"
        Me.PHONEDataGridViewTextBoxColumn.HeaderText = "PHONE"
        Me.PHONEDataGridViewTextBoxColumn.Name = "PHONEDataGridViewTextBoxColumn"
        '
        'EMAILDataGridViewTextBoxColumn
        '
        Me.EMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL"
        Me.EMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL"
        Me.EMAILDataGridViewTextBoxColumn.Name = "EMAILDataGridViewTextBoxColumn"
        '
        'RADDRESSDataGridViewTextBoxColumn
        '
        Me.RADDRESSDataGridViewTextBoxColumn.DataPropertyName = "R_ADDRESS"
        Me.RADDRESSDataGridViewTextBoxColumn.HeaderText = "R_ADDRESS"
        Me.RADDRESSDataGridViewTextBoxColumn.Name = "RADDRESSDataGridViewTextBoxColumn"
        '
        'ECNAMEDataGridViewTextBoxColumn
        '
        Me.ECNAMEDataGridViewTextBoxColumn.DataPropertyName = "E_C_NAME"
        Me.ECNAMEDataGridViewTextBoxColumn.HeaderText = "E_C_NAME"
        Me.ECNAMEDataGridViewTextBoxColumn.Name = "ECNAMEDataGridViewTextBoxColumn"
        '
        'ECONTACTDataGridViewTextBoxColumn
        '
        Me.ECONTACTDataGridViewTextBoxColumn.DataPropertyName = "E_CONTACT"
        Me.ECONTACTDataGridViewTextBoxColumn.HeaderText = "E_CONTACT"
        Me.ECONTACTDataGridViewTextBoxColumn.Name = "ECONTACTDataGridViewTextBoxColumn"
        '
        'LSATTENDEDDataGridViewTextBoxColumn
        '
        Me.LSATTENDEDDataGridViewTextBoxColumn.DataPropertyName = "L_S_ATTENDED"
        Me.LSATTENDEDDataGridViewTextBoxColumn.HeaderText = "L_S_ATTENDED"
        Me.LSATTENDEDDataGridViewTextBoxColumn.Name = "LSATTENDEDDataGridViewTextBoxColumn"
        '
        'EDUQUALIFICATIONDataGridViewTextBoxColumn
        '
        Me.EDUQUALIFICATIONDataGridViewTextBoxColumn.DataPropertyName = "EDU_QUALIFICATION"
        Me.EDUQUALIFICATIONDataGridViewTextBoxColumn.HeaderText = "EDU_QUALIFICATION"
        Me.EDUQUALIFICATIONDataGridViewTextBoxColumn.Name = "EDUQUALIFICATIONDataGridViewTextBoxColumn"
        '
        'OTHERQUALIFICATIONDataGridViewTextBoxColumn
        '
        Me.OTHERQUALIFICATIONDataGridViewTextBoxColumn.DataPropertyName = "OTHER_QUALIFICATION"
        Me.OTHERQUALIFICATIONDataGridViewTextBoxColumn.HeaderText = "OTHER_QUALIFICATION"
        Me.OTHERQUALIFICATIONDataGridViewTextBoxColumn.Name = "OTHERQUALIFICATIONDataGridViewTextBoxColumn"
        '
        'REGDATEDataGridViewTextBoxColumn
        '
        Me.REGDATEDataGridViewTextBoxColumn.DataPropertyName = "REG_DATE"
        Me.REGDATEDataGridViewTextBoxColumn.HeaderText = "REG_DATE"
        Me.REGDATEDataGridViewTextBoxColumn.Name = "REGDATEDataGridViewTextBoxColumn"
        '
        'PhotoDataGridViewImageColumn
        '
        Me.PhotoDataGridViewImageColumn.DataPropertyName = "Photo"
        Me.PhotoDataGridViewImageColumn.HeaderText = "Photo"
        Me.PhotoDataGridViewImageColumn.Name = "PhotoDataGridViewImageColumn"
        '
        'ApplicantBindingSource
        '
        Me.ApplicantBindingSource.DataMember = "Applicant"
        Me.ApplicantBindingSource.DataSource = Me.EACONSULTDataSet1
        '
        'EACONSULTDataSet1
        '
        Me.EACONSULTDataSet1.DataSetName = "EACONSULTDataSet1"
        Me.EACONSULTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ApplicantTableAdapter
        '
        Me.ApplicantTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(936, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 37)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "&EXPORT EXCEL"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'APPLICANTSVIEW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1081, 552)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "APPLICANTSVIEW"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "APPLICANTSVIEW"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApplicantBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EACONSULTDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents EACONSULTDataSet1 As EACONSULT.EACONSULTDataSet1
    Friend WithEvents ApplicantBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ApplicantTableAdapter As EACONSULT.EACONSULTDataSet1TableAdapters.ApplicantTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FIRSTNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LASTNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DOBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GENDERDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MSTATUSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NATIONALITYDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PHONEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMAILDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RADDRESSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ECNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ECONTACTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LSATTENDEDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EDUQUALIFICATIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OTHERQUALIFICATIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REGDATEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhotoDataGridViewImageColumn As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
