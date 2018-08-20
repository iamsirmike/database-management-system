<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Deployedview
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
        Me.EACONSULTDataSet7 = New EACONSULT.EACONSULTDataSet7()
        Me.DeployBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DeployTableAdapter = New EACONSULT.EACONSULTDataSet7TableAdapters.DeployTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIRSTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LASTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATEDEPLOYEDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COMPANYNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LOCATIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TYPEOFJOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SALARYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PHOTODataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EACONSULTDataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeployBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FIRSTNAMEDataGridViewTextBoxColumn, Me.LASTNAMEDataGridViewTextBoxColumn, Me.DATEDEPLOYEDDataGridViewTextBoxColumn, Me.COMPANYNAMEDataGridViewTextBoxColumn, Me.LOCATIONDataGridViewTextBoxColumn, Me.TYPEOFJOBDataGridViewTextBoxColumn, Me.SALARYDataGridViewTextBoxColumn, Me.PHOTODataGridViewImageColumn})
        Me.DataGridView1.DataSource = Me.DeployBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(950, 483)
        Me.DataGridView1.TabIndex = 0
        '
        'EACONSULTDataSet7
        '
        Me.EACONSULTDataSet7.DataSetName = "EACONSULTDataSet7"
        Me.EACONSULTDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DeployBindingSource
        '
        Me.DeployBindingSource.DataMember = "Deploy"
        Me.DeployBindingSource.DataSource = Me.EACONSULTDataSet7
        '
        'DeployTableAdapter
        '
        Me.DeployTableAdapter.ClearBeforeFill = True
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
        'DATEDEPLOYEDDataGridViewTextBoxColumn
        '
        Me.DATEDEPLOYEDDataGridViewTextBoxColumn.DataPropertyName = "DATEDEPLOYED"
        Me.DATEDEPLOYEDDataGridViewTextBoxColumn.HeaderText = "DATEDEPLOYED"
        Me.DATEDEPLOYEDDataGridViewTextBoxColumn.Name = "DATEDEPLOYEDDataGridViewTextBoxColumn"
        '
        'COMPANYNAMEDataGridViewTextBoxColumn
        '
        Me.COMPANYNAMEDataGridViewTextBoxColumn.DataPropertyName = "COMPANYNAME"
        Me.COMPANYNAMEDataGridViewTextBoxColumn.HeaderText = "COMPANYNAME"
        Me.COMPANYNAMEDataGridViewTextBoxColumn.Name = "COMPANYNAMEDataGridViewTextBoxColumn"
        '
        'LOCATIONDataGridViewTextBoxColumn
        '
        Me.LOCATIONDataGridViewTextBoxColumn.DataPropertyName = "LOCATION"
        Me.LOCATIONDataGridViewTextBoxColumn.HeaderText = "LOCATION"
        Me.LOCATIONDataGridViewTextBoxColumn.Name = "LOCATIONDataGridViewTextBoxColumn"
        '
        'TYPEOFJOBDataGridViewTextBoxColumn
        '
        Me.TYPEOFJOBDataGridViewTextBoxColumn.DataPropertyName = "TYPEOFJOB"
        Me.TYPEOFJOBDataGridViewTextBoxColumn.HeaderText = "TYPEOFJOB"
        Me.TYPEOFJOBDataGridViewTextBoxColumn.Name = "TYPEOFJOBDataGridViewTextBoxColumn"
        '
        'SALARYDataGridViewTextBoxColumn
        '
        Me.SALARYDataGridViewTextBoxColumn.DataPropertyName = "SALARY"
        Me.SALARYDataGridViewTextBoxColumn.HeaderText = "SALARY"
        Me.SALARYDataGridViewTextBoxColumn.Name = "SALARYDataGridViewTextBoxColumn"
        '
        'PHOTODataGridViewImageColumn
        '
        Me.PHOTODataGridViewImageColumn.DataPropertyName = "PHOTO"
        Me.PHOTODataGridViewImageColumn.HeaderText = "PHOTO"
        Me.PHOTODataGridViewImageColumn.Name = "PHOTODataGridViewImageColumn"
        '
        'Deployedview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 483)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Deployedview"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Deployedview"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EACONSULTDataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeployBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents EACONSULTDataSet7 As EACONSULT.EACONSULTDataSet7
    Friend WithEvents DeployBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DeployTableAdapter As EACONSULT.EACONSULTDataSet7TableAdapters.DeployTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FIRSTNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LASTNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DATEDEPLOYEDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COMPANYNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LOCATIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TYPEOFJOBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SALARYDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PHOTODataGridViewImageColumn As System.Windows.Forms.DataGridViewImageColumn
End Class
