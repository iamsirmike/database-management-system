<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Deploy
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtsalary = New System.Windows.Forms.TextBox()
        Me.txtcompanyname = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Browse = New System.Windows.Forms.Button()
        Me.txtResidence = New System.Windows.Forms.TextBox()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EACONSULTDataSet3 = New EACONSULT.EACONSULTDataSet3()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Picture = New System.Windows.Forms.PictureBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtlastname = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtstaffid = New System.Windows.Forms.TextBox()
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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtsearchID = New System.Windows.Forms.TextBox()
        Me.REGISTRATION = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txttypeofjob = New System.Windows.Forms.TextBox()
        Me.dtpdatedeployed = New System.Windows.Forms.DateTimePicker()
        Me.EACONSULTDataSet5 = New EACONSULT.EACONSULTDataSet5()
        Me.DeployBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DeployTableAdapter = New EACONSULT.EACONSULTDataSet5TableAdapters.DeployTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIRSTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LASTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATEDEPLOYEDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COMPANYNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LOCATIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TYPEOFJOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SALARYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PHOTODataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EACONSULTDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ACTIONS.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.EACONSULTDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeployBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(224, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "GH¢"
        '
        'txtsalary
        '
        Me.txtsalary.Location = New System.Drawing.Point(124, 149)
        Me.txtsalary.Name = "txtsalary"
        Me.txtsalary.Size = New System.Drawing.Size(94, 20)
        Me.txtsalary.TabIndex = 27
        '
        'txtcompanyname
        '
        Me.txtcompanyname.Location = New System.Drawing.Point(124, 110)
        Me.txtcompanyname.Name = "txtcompanyname"
        Me.txtcompanyname.Size = New System.Drawing.Size(194, 20)
        Me.txtcompanyname.TabIndex = 25
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(40, 113)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 13)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Company Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(40, 152)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Salary"
        '
        'Browse
        '
        Me.Browse.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Browse.ForeColor = System.Drawing.Color.Black
        Me.Browse.Location = New System.Drawing.Point(946, 196)
        Me.Browse.Name = "Browse"
        Me.Browse.Size = New System.Drawing.Size(197, 23)
        Me.Browse.TabIndex = 17
        Me.Browse.Text = "Browse..."
        Me.Browse.UseVisualStyleBackColor = True
        '
        'txtResidence
        '
        Me.txtResidence.Location = New System.Drawing.Point(447, 106)
        Me.txtResidence.Name = "txtResidence"
        Me.txtResidence.Size = New System.Drawing.Size(194, 20)
        Me.txtResidence.TabIndex = 15
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
        Me.GroupBox1.Controls.Add(Me.txttypeofjob)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtsalary)
        Me.GroupBox1.Controls.Add(Me.txtcompanyname)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Browse)
        Me.GroupBox1.Controls.Add(Me.Picture)
        Me.GroupBox1.Controls.Add(Me.txtResidence)
        Me.GroupBox1.Controls.Add(Me.txtFirstName)
        Me.GroupBox1.Controls.Add(Me.txtlastname)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtstaffid)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(35, 118)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1156, 248)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal details"
        '
        'Picture
        '
        Me.Picture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Picture.Location = New System.Drawing.Point(946, 24)
        Me.Picture.Name = "Picture"
        Me.Picture.Size = New System.Drawing.Size(197, 163)
        Me.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picture.TabIndex = 16
        Me.Picture.TabStop = False
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(124, 71)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(194, 20)
        Me.txtFirstName.TabIndex = 11
        '
        'txtlastname
        '
        Me.txtlastname.Location = New System.Drawing.Point(447, 67)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(194, 20)
        Me.txtlastname.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(335, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Location"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(336, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Last Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Applicant ID"
        '
        'txtstaffid
        '
        Me.txtstaffid.Location = New System.Drawing.Point(124, 34)
        Me.txtstaffid.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtstaffid.Name = "txtstaffid"
        Me.txtstaffid.Size = New System.Drawing.Size(109, 20)
        Me.txtstaffid.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(650, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Date Deployed"
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
        Me.ACTIONS.Location = New System.Drawing.Point(35, 373)
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
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(43, 31)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "By ID:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.bnsearch2)
        Me.GroupBox2.Controls.Add(Me.bnsearch1)
        Me.GroupBox2.Controls.Add(Me.txtsearchname)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtsearchID)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Location = New System.Drawing.Point(35, 47)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1156, 64)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search"
        '
        'txtsearchID
        '
        Me.txtsearchID.Location = New System.Drawing.Point(104, 28)
        Me.txtsearchID.Name = "txtsearchID"
        Me.txtsearchID.Size = New System.Drawing.Size(191, 20)
        Me.txtsearchID.TabIndex = 1
        '
        'REGISTRATION
        '
        Me.REGISTRATION.AutoSize = True
        Me.REGISTRATION.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGISTRATION.Location = New System.Drawing.Point(21, 13)
        Me.REGISTRATION.Name = "REGISTRATION"
        Me.REGISTRATION.Size = New System.Drawing.Size(130, 31)
        Me.REGISTRATION.TabIndex = 14
        Me.REGISTRATION.Text = "DEPLOY"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(650, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Type of Job"
        '
        'txttypeofjob
        '
        Me.txttypeofjob.Location = New System.Drawing.Point(734, 110)
        Me.txttypeofjob.Name = "txttypeofjob"
        Me.txttypeofjob.Size = New System.Drawing.Size(194, 20)
        Me.txttypeofjob.TabIndex = 30
        '
        'dtpdatedeployed
        '
        Me.dtpdatedeployed.Location = New System.Drawing.Point(734, 74)
        Me.dtpdatedeployed.Name = "dtpdatedeployed"
        Me.dtpdatedeployed.Size = New System.Drawing.Size(194, 20)
        Me.dtpdatedeployed.TabIndex = 31
        '
        'EACONSULTDataSet5
        '
        Me.EACONSULTDataSet5.DataSetName = "EACONSULTDataSet5"
        Me.EACONSULTDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DeployBindingSource
        '
        Me.DeployBindingSource.DataMember = "Deploy"
        Me.DeployBindingSource.DataSource = Me.EACONSULTDataSet5
        '
        'DeployTableAdapter
        '
        Me.DeployTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FIRSTNAMEDataGridViewTextBoxColumn, Me.LASTNAMEDataGridViewTextBoxColumn, Me.DATEDEPLOYEDDataGridViewTextBoxColumn, Me.COMPANYNAMEDataGridViewTextBoxColumn, Me.LOCATIONDataGridViewTextBoxColumn, Me.TYPEOFJOBDataGridViewTextBoxColumn, Me.SALARYDataGridViewTextBoxColumn, Me.PHOTODataGridViewImageColumn})
        Me.DataGridView1.DataSource = Me.DeployBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(198, 474)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(950, 92)
        Me.DataGridView1.TabIndex = 17
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
        'Deploy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1227, 576)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ACTIONS)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.REGISTRATION)
        Me.Name = "Deploy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Deploy"
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EACONSULTDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ACTIONS.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.EACONSULTDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeployBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtsalary As System.Windows.Forms.TextBox
    Friend WithEvents txtcompanyname As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Private WithEvents Browse As System.Windows.Forms.Button
    Friend WithEvents txtResidence As System.Windows.Forms.TextBox
    Friend WithEvents StaffBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EACONSULTDataSet3 As EACONSULT.EACONSULTDataSet3
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpdatedeployed As System.Windows.Forms.DateTimePicker
    Friend WithEvents txttypeofjob As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Picture As System.Windows.Forms.PictureBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtlastname As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtstaffid As System.Windows.Forms.TextBox
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
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtsearchID As System.Windows.Forms.TextBox
    Friend WithEvents REGISTRATION As System.Windows.Forms.Label
    Friend WithEvents EACONSULTDataSet5 As EACONSULT.EACONSULTDataSet5
    Friend WithEvents DeployBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DeployTableAdapter As EACONSULT.EACONSULTDataSet5TableAdapters.DeployTableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
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
