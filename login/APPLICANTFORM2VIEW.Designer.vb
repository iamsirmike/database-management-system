<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class APPLICANTFORM2VIEW
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
        Me.EACONSULTDataSet17 = New EACONSULT.EACONSULTDataSet17()
        Me.Applicant2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Applicant2TableAdapter = New EACONSULT.EACONSULTDataSet17TableAdapters.Applicant2TableAdapter()
        Me.TOJOB1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOJOB2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOJOB13DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LPWORKEDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MANAGERNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YEARSWORKEDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLITERATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ACCESSTUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APPLICANTIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EACONSULTDataSet17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Applicant2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TOJOB1DataGridViewTextBoxColumn, Me.TOJOB2DataGridViewTextBoxColumn, Me.TOJOB13DataGridViewTextBoxColumn, Me.LPWORKEDDataGridViewTextBoxColumn, Me.MANAGERNODataGridViewTextBoxColumn, Me.YEARSWORKEDDataGridViewTextBoxColumn, Me.CLITERATEDataGridViewTextBoxColumn, Me.ACCESSTUSDataGridViewTextBoxColumn, Me.APPLICANTIDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Applicant2BindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(946, 467)
        Me.DataGridView1.TabIndex = 0
        '
        'EACONSULTDataSet17
        '
        Me.EACONSULTDataSet17.DataSetName = "EACONSULTDataSet17"
        Me.EACONSULTDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Applicant2BindingSource
        '
        Me.Applicant2BindingSource.DataMember = "Applicant2"
        Me.Applicant2BindingSource.DataSource = Me.EACONSULTDataSet17
        '
        'Applicant2TableAdapter
        '
        Me.Applicant2TableAdapter.ClearBeforeFill = True
        '
        'TOJOB1DataGridViewTextBoxColumn
        '
        Me.TOJOB1DataGridViewTextBoxColumn.DataPropertyName = "T_O_JOB1"
        Me.TOJOB1DataGridViewTextBoxColumn.HeaderText = "T_O_JOB1"
        Me.TOJOB1DataGridViewTextBoxColumn.Name = "TOJOB1DataGridViewTextBoxColumn"
        '
        'TOJOB2DataGridViewTextBoxColumn
        '
        Me.TOJOB2DataGridViewTextBoxColumn.DataPropertyName = "T_O_JOB2"
        Me.TOJOB2DataGridViewTextBoxColumn.HeaderText = "T_O_JOB2"
        Me.TOJOB2DataGridViewTextBoxColumn.Name = "TOJOB2DataGridViewTextBoxColumn"
        '
        'TOJOB13DataGridViewTextBoxColumn
        '
        Me.TOJOB13DataGridViewTextBoxColumn.DataPropertyName = "T_O_JOB13"
        Me.TOJOB13DataGridViewTextBoxColumn.HeaderText = "T_O_JOB13"
        Me.TOJOB13DataGridViewTextBoxColumn.Name = "TOJOB13DataGridViewTextBoxColumn"
        '
        'LPWORKEDDataGridViewTextBoxColumn
        '
        Me.LPWORKEDDataGridViewTextBoxColumn.DataPropertyName = "L_P_WORKED"
        Me.LPWORKEDDataGridViewTextBoxColumn.HeaderText = "L_P_WORKED"
        Me.LPWORKEDDataGridViewTextBoxColumn.Name = "LPWORKEDDataGridViewTextBoxColumn"
        '
        'MANAGERNODataGridViewTextBoxColumn
        '
        Me.MANAGERNODataGridViewTextBoxColumn.DataPropertyName = "MANAGER_NO"
        Me.MANAGERNODataGridViewTextBoxColumn.HeaderText = "MANAGER_NO"
        Me.MANAGERNODataGridViewTextBoxColumn.Name = "MANAGERNODataGridViewTextBoxColumn"
        '
        'YEARSWORKEDDataGridViewTextBoxColumn
        '
        Me.YEARSWORKEDDataGridViewTextBoxColumn.DataPropertyName = "YEARS_WORKED"
        Me.YEARSWORKEDDataGridViewTextBoxColumn.HeaderText = "YEARS_WORKED"
        Me.YEARSWORKEDDataGridViewTextBoxColumn.Name = "YEARSWORKEDDataGridViewTextBoxColumn"
        '
        'CLITERATEDataGridViewTextBoxColumn
        '
        Me.CLITERATEDataGridViewTextBoxColumn.DataPropertyName = "C_LITERATE"
        Me.CLITERATEDataGridViewTextBoxColumn.HeaderText = "C_LITERATE"
        Me.CLITERATEDataGridViewTextBoxColumn.Name = "CLITERATEDataGridViewTextBoxColumn"
        '
        'ACCESSTUSDataGridViewTextBoxColumn
        '
        Me.ACCESSTUSDataGridViewTextBoxColumn.DataPropertyName = "ACCESS_T_US"
        Me.ACCESSTUSDataGridViewTextBoxColumn.HeaderText = "ACCESS_T_US"
        Me.ACCESSTUSDataGridViewTextBoxColumn.Name = "ACCESSTUSDataGridViewTextBoxColumn"
        '
        'APPLICANTIDDataGridViewTextBoxColumn
        '
        Me.APPLICANTIDDataGridViewTextBoxColumn.DataPropertyName = "APPLICANTID"
        Me.APPLICANTIDDataGridViewTextBoxColumn.HeaderText = "APPLICANTID"
        Me.APPLICANTIDDataGridViewTextBoxColumn.Name = "APPLICANTIDDataGridViewTextBoxColumn"
        '
        'APPLICANTFORM2VIEW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(946, 467)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "APPLICANTFORM2VIEW"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "APPLICANTFORM2VIEW"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EACONSULTDataSet17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Applicant2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents EACONSULTDataSet17 As EACONSULT.EACONSULTDataSet17
    Friend WithEvents Applicant2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Applicant2TableAdapter As EACONSULT.EACONSULTDataSet17TableAdapters.Applicant2TableAdapter
    Friend WithEvents TOJOB1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOJOB2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOJOB13DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LPWORKEDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MANAGERNODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YEARSWORKEDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLITERATEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ACCESSTUSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents APPLICANTIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
