<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vacancies
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
        Me.Label13 = New System.Windows.Forms.Label()
        Me.VacanciesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EACONSULTDataSet13 = New EACONSULT.EACONSULTDataSet13()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EACONSULTDataSet3 = New EACONSULT.EACONSULTDataSet3()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpdatedeployed = New System.Windows.Forms.DateTimePicker()
        Me.dtpvacancydate = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txtlocation = New System.Windows.Forms.TextBox()
        Me.txttelephone = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcompanyname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StaffTableAdapter = New EACONSULT.EACONSULTDataSet3TableAdapters.StaffTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnUpdate_record = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnNewRecord = New System.Windows.Forms.Button()
        Me.ACTIONS = New System.Windows.Forms.GroupBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.bnsearch2 = New System.Windows.Forms.Button()
        Me.bnsearch1 = New System.Windows.Forms.Button()
        Me.txtsearchname = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtsearchID = New System.Windows.Forms.TextBox()
        Me.REGISTRATION = New System.Windows.Forms.Label()
        Me.EACONSULTDataSet12 = New EACONSULT.EACONSULTDataSet12()
        Me.VacanciesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VacanciesTableAdapter = New EACONSULT.EACONSULTDataSet12TableAdapters.VacanciesTableAdapter()
        Me.VacanciesTableAdapter1 = New EACONSULT.EACONSULTDataSet13TableAdapters.VacanciesTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.COMPANYNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LOCATIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TELEPHONEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEPLOYEDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATEDEPLOYEDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VacanciesBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EACONSULTDataSet14 = New EACONSULT.EACONSULTDataSet14()
        Me.VacanciesTableAdapter2 = New EACONSULT.EACONSULTDataSet14TableAdapters.VacanciesTableAdapter()
        CType(Me.VacanciesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EACONSULTDataSet13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EACONSULTDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.ACTIONS.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.EACONSULTDataSet12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VacanciesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VacanciesBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EACONSULTDataSet14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(40, 113)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 13)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Vacancy Date"
        '
        'VacanciesBindingSource1
        '
        Me.VacanciesBindingSource1.DataMember = "Vacancies"
        Me.VacanciesBindingSource1.DataSource = Me.EACONSULTDataSet13
        '
        'EACONSULTDataSet13
        '
        Me.EACONSULTDataSet13.DataSetName = "EACONSULTDataSet13"
        Me.EACONSULTDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "Staff"
        Me.StaffBindingSource.DataSource = Me.EACONSULTDataSet3
        '
        'EACONSULTDataSet3
        '
        Me.EACONSULTDataSet3.DataSetName = "EACONSULTDataSet3"
        Me.EACONSULTDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.dtpdatedeployed)
        Me.GroupBox1.Controls.Add(Me.dtpvacancydate)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtlocation)
        Me.GroupBox1.Controls.Add(Me.txttelephone)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtcompanyname)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 131)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1156, 248)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal details"
        '
        'dtpdatedeployed
        '
        Me.dtpdatedeployed.Location = New System.Drawing.Point(447, 113)
        Me.dtpdatedeployed.Name = "dtpdatedeployed"
        Me.dtpdatedeployed.Size = New System.Drawing.Size(200, 20)
        Me.dtpdatedeployed.TabIndex = 28
        '
        'dtpvacancydate
        '
        Me.dtpvacancydate.Location = New System.Drawing.Point(124, 113)
        Me.dtpvacancydate.Name = "dtpvacancydate"
        Me.dtpvacancydate.Size = New System.Drawing.Size(200, 20)
        Me.dtpvacancydate.TabIndex = 27
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Yes", "No"})
        Me.ComboBox1.Location = New System.Drawing.Point(724, 65)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(171, 21)
        Me.ComboBox1.TabIndex = 26
        '
        'txtlocation
        '
        Me.txtlocation.Location = New System.Drawing.Point(124, 71)
        Me.txtlocation.Name = "txtlocation"
        Me.txtlocation.Size = New System.Drawing.Size(194, 20)
        Me.txtlocation.TabIndex = 11
        '
        'txttelephone
        '
        Me.txttelephone.Location = New System.Drawing.Point(447, 67)
        Me.txttelephone.Name = "txttelephone"
        Me.txttelephone.Size = New System.Drawing.Size(194, 20)
        Me.txttelephone.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(335, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Date Deployed"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Location"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(336, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Telephone"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Company Name"
        '
        'txtcompanyname
        '
        Me.txtcompanyname.Location = New System.Drawing.Point(124, 34)
        Me.txtcompanyname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtcompanyname.Name = "txtcompanyname"
        Me.txtcompanyname.Size = New System.Drawing.Size(288, 20)
        Me.txtcompanyname.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(650, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Deployed?"
        '
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(447, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 33)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "&Clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnUpdate_record
        '
        Me.btnUpdate_record.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate_record.Location = New System.Drawing.Point(346, 19)
        Me.btnUpdate_record.Name = "btnUpdate_record"
        Me.btnUpdate_record.Size = New System.Drawing.Size(95, 33)
        Me.btnUpdate_record.TabIndex = 8
        Me.btnUpdate_record.Text = "&Update"
        Me.btnUpdate_record.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(245, 19)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(95, 33)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnNewRecord
        '
        Me.btnNewRecord.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewRecord.Location = New System.Drawing.Point(43, 19)
        Me.btnNewRecord.Name = "btnNewRecord"
        Me.btnNewRecord.Size = New System.Drawing.Size(95, 33)
        Me.btnNewRecord.TabIndex = 1
        Me.btnNewRecord.Text = "&New"
        Me.btnNewRecord.UseVisualStyleBackColor = True
        '
        'ACTIONS
        '
        Me.ACTIONS.Controls.Add(Me.Button1)
        Me.ACTIONS.Controls.Add(Me.btnUpdate_record)
        Me.ACTIONS.Controls.Add(Me.btnDelete)
        Me.ACTIONS.Controls.Add(Me.btnSave)
        Me.ACTIONS.Controls.Add(Me.btnNewRecord)
        Me.ACTIONS.Location = New System.Drawing.Point(15, 386)
        Me.ACTIONS.Name = "ACTIONS"
        Me.ACTIONS.Size = New System.Drawing.Size(558, 77)
        Me.ACTIONS.TabIndex = 16
        Me.ACTIONS.TabStop = False
        Me.ACTIONS.Text = "Actions"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(144, 19)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(95, 33)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'bnsearch2
        '
        Me.bnsearch2.Location = New System.Drawing.Point(793, 26)
        Me.bnsearch2.Name = "bnsearch2"
        Me.bnsearch2.Size = New System.Drawing.Size(75, 23)
        Me.bnsearch2.TabIndex = 5
        Me.bnsearch2.Text = "SEARCH"
        Me.bnsearch2.UseVisualStyleBackColor = True
        '
        'bnsearch1
        '
        Me.bnsearch1.Enabled = False
        Me.bnsearch1.Location = New System.Drawing.Point(319, 26)
        Me.bnsearch1.Name = "bnsearch1"
        Me.bnsearch1.Size = New System.Drawing.Size(75, 23)
        Me.bnsearch1.TabIndex = 4
        Me.bnsearch1.Text = "SEARCH"
        Me.bnsearch1.UseVisualStyleBackColor = True
        '
        'txtsearchname
        '
        Me.txtsearchname.Location = New System.Drawing.Point(566, 28)
        Me.txtsearchname.Name = "txtsearchname"
        Me.txtsearchname.Size = New System.Drawing.Size(191, 20)
        Me.txtsearchname.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(467, 31)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "By First Name:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.bnsearch2)
        Me.GroupBox2.Controls.Add(Me.bnsearch1)
        Me.GroupBox2.Controls.Add(Me.txtsearchname)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtsearchID)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 60)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1063, 64)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search"
        '
        'txtsearchID
        '
        Me.txtsearchID.Enabled = False
        Me.txtsearchID.Location = New System.Drawing.Point(104, 28)
        Me.txtsearchID.Name = "txtsearchID"
        Me.txtsearchID.Size = New System.Drawing.Size(191, 20)
        Me.txtsearchID.TabIndex = 1
        '
        'REGISTRATION
        '
        Me.REGISTRATION.AutoSize = True
        Me.REGISTRATION.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGISTRATION.Location = New System.Drawing.Point(1, 26)
        Me.REGISTRATION.Name = "REGISTRATION"
        Me.REGISTRATION.Size = New System.Drawing.Size(181, 31)
        Me.REGISTRATION.TabIndex = 14
        Me.REGISTRATION.Text = "VACANCIES"
        '
        'EACONSULTDataSet12
        '
        Me.EACONSULTDataSet12.DataSetName = "EACONSULTDataSet12"
        Me.EACONSULTDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VacanciesBindingSource
        '
        Me.VacanciesBindingSource.DataMember = "Vacancies"
        Me.VacanciesBindingSource.DataSource = Me.EACONSULTDataSet12
        '
        'VacanciesTableAdapter
        '
        Me.VacanciesTableAdapter.ClearBeforeFill = True
        '
        'VacanciesTableAdapter1
        '
        Me.VacanciesTableAdapter1.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.COMPANYNAMEDataGridViewTextBoxColumn, Me.LOCATIONDataGridViewTextBoxColumn, Me.TELEPHONEDataGridViewTextBoxColumn, Me.VDATEDataGridViewTextBoxColumn, Me.DEPLOYEDDataGridViewTextBoxColumn, Me.DATEDEPLOYEDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.VacanciesBindingSource2
        Me.DataGridView1.Location = New System.Drawing.Point(236, 469)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(647, 110)
        Me.DataGridView1.TabIndex = 17
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
        'VacanciesBindingSource2
        '
        Me.VacanciesBindingSource2.DataMember = "Vacancies"
        Me.VacanciesBindingSource2.DataSource = Me.EACONSULTDataSet14
        '
        'EACONSULTDataSet14
        '
        Me.EACONSULTDataSet14.DataSetName = "EACONSULTDataSet14"
        Me.EACONSULTDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VacanciesTableAdapter2
        '
        Me.VacanciesTableAdapter2.ClearBeforeFill = True
        '
        'Vacancies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1149, 607)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ACTIONS)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.REGISTRATION)
        Me.Name = "Vacancies"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vacancies"
        CType(Me.VacanciesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EACONSULTDataSet13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EACONSULTDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ACTIONS.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.EACONSULTDataSet12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VacanciesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VacanciesBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EACONSULTDataSet14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents StaffBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EACONSULTDataSet3 As EACONSULT.EACONSULTDataSet3
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtlocation As System.Windows.Forms.TextBox
    Friend WithEvents txttelephone As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtcompanyname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents StaffTableAdapter As EACONSULT.EACONSULTDataSet3TableAdapters.StaffTableAdapter
    Public WithEvents Button1 As System.Windows.Forms.Button
    Public WithEvents btnUpdate_record As System.Windows.Forms.Button
    Public WithEvents btnDelete As System.Windows.Forms.Button
    Private WithEvents btnNewRecord As System.Windows.Forms.Button
    Friend WithEvents ACTIONS As System.Windows.Forms.GroupBox
    Public WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents bnsearch2 As System.Windows.Forms.Button
    Friend WithEvents bnsearch1 As System.Windows.Forms.Button
    Friend WithEvents txtsearchname As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtsearchID As System.Windows.Forms.TextBox
    Friend WithEvents REGISTRATION As System.Windows.Forms.Label
    Friend WithEvents dtpdatedeployed As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpvacancydate As System.Windows.Forms.DateTimePicker
    Friend WithEvents EACONSULTDataSet12 As EACONSULT.EACONSULTDataSet12
    Friend WithEvents VacanciesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VacanciesTableAdapter As EACONSULT.EACONSULTDataSet12TableAdapters.VacanciesTableAdapter
    Friend WithEvents EACONSULTDataSet13 As EACONSULT.EACONSULTDataSet13
    Friend WithEvents VacanciesBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents VacanciesTableAdapter1 As EACONSULT.EACONSULTDataSet13TableAdapters.VacanciesTableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents EACONSULTDataSet14 As EACONSULT.EACONSULTDataSet14
    Friend WithEvents VacanciesBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents VacanciesTableAdapter2 As EACONSULT.EACONSULTDataSet14TableAdapters.VacanciesTableAdapter
    Friend WithEvents COMPANYNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LOCATIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TELEPHONEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VDATEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DEPLOYEDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DATEDEPLOYEDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
