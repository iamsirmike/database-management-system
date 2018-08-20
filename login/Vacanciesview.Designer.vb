<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vacanciesview
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
        Me.COMPANYNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LOCATIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TELEPHONEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEPLOYEDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATEDEPLOYEDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VacanciesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EACONSULTDataSet15 = New EACONSULT.EACONSULTDataSet15()
        Me.VacanciesTableAdapter = New EACONSULT.EACONSULTDataSet15TableAdapters.VacanciesTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VacanciesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EACONSULTDataSet15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.COMPANYNAMEDataGridViewTextBoxColumn, Me.LOCATIONDataGridViewTextBoxColumn, Me.TELEPHONEDataGridViewTextBoxColumn, Me.VDATEDataGridViewTextBoxColumn, Me.DEPLOYEDDataGridViewTextBoxColumn, Me.DATEDEPLOYEDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.VacanciesBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(644, 509)
        Me.DataGridView1.TabIndex = 0
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
        'TELEPHONEDataGridViewTextBoxColumn
        '
        Me.TELEPHONEDataGridViewTextBoxColumn.DataPropertyName = "TELEPHONE"
        Me.TELEPHONEDataGridViewTextBoxColumn.HeaderText = "TELEPHONE"
        Me.TELEPHONEDataGridViewTextBoxColumn.Name = "TELEPHONEDataGridViewTextBoxColumn"
        '
        'VDATEDataGridViewTextBoxColumn
        '
        Me.VDATEDataGridViewTextBoxColumn.DataPropertyName = "V_DATE"
        Me.VDATEDataGridViewTextBoxColumn.HeaderText = "V_DATE"
        Me.VDATEDataGridViewTextBoxColumn.Name = "VDATEDataGridViewTextBoxColumn"
        '
        'DEPLOYEDDataGridViewTextBoxColumn
        '
        Me.DEPLOYEDDataGridViewTextBoxColumn.DataPropertyName = "DEPLOYED"
        Me.DEPLOYEDDataGridViewTextBoxColumn.HeaderText = "DEPLOYED"
        Me.DEPLOYEDDataGridViewTextBoxColumn.Name = "DEPLOYEDDataGridViewTextBoxColumn"
        '
        'DATEDEPLOYEDDataGridViewTextBoxColumn
        '
        Me.DATEDEPLOYEDDataGridViewTextBoxColumn.DataPropertyName = "DATEDEPLOYED"
        Me.DATEDEPLOYEDDataGridViewTextBoxColumn.HeaderText = "DATEDEPLOYED"
        Me.DATEDEPLOYEDDataGridViewTextBoxColumn.Name = "DATEDEPLOYEDDataGridViewTextBoxColumn"
        '
        'VacanciesBindingSource
        '
        Me.VacanciesBindingSource.DataMember = "Vacancies"
        Me.VacanciesBindingSource.DataSource = Me.EACONSULTDataSet15
        '
        'EACONSULTDataSet15
        '
        Me.EACONSULTDataSet15.DataSetName = "EACONSULTDataSet15"
        Me.EACONSULTDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VacanciesTableAdapter
        '
        Me.VacanciesTableAdapter.ClearBeforeFill = True
        '
        'Vacanciesview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 509)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Vacanciesview"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vacanciesview"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VacanciesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EACONSULTDataSet15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents EACONSULTDataSet15 As EACONSULT.EACONSULTDataSet15
    Friend WithEvents VacanciesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VacanciesTableAdapter As EACONSULT.EACONSULTDataSet15TableAdapters.VacanciesTableAdapter
    Friend WithEvents COMPANYNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LOCATIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TELEPHONEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VDATEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DEPLOYEDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DATEDEPLOYEDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
