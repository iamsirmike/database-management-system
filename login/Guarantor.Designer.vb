<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Guarantor
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
        Me.txtsearchID = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.REGISTRATION = New System.Windows.Forms.Label()
        Me.txtreligion = New System.Windows.Forms.TextBox()
        Me.txtcontact = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Browse = New System.Windows.Forms.Button()
        Me.txtResidence = New System.Windows.Forms.TextBox()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtapplicantid = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Picture = New System.Windows.Forms.PictureBox()
        Me.txtoccupation = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtoccupationaddress = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtofficetelephone = New System.Windows.Forms.TextBox()
        Me.txtidtype = New System.Windows.Forms.TextBox()
        Me.txtidnumber = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dtpdateofregistration = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EACONSULTDataSet2 = New EACONSULT.EACONSULTDataSet2()
        Me.GuarantorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GuarantorsTableAdapter = New EACONSULT.EACONSULTDataSet2TableAdapters.GuarantorsTableAdapter()
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
        Me.ACTIONS.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EACONSULTDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GuarantorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.ACTIONS.Location = New System.Drawing.Point(38, 426)
        Me.ACTIONS.Name = "ACTIONS"
        Me.ACTIONS.Size = New System.Drawing.Size(558, 77)
        Me.ACTIONS.TabIndex = 11
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
        'txtsearchID
        '
        Me.txtsearchID.Location = New System.Drawing.Point(104, 28)
        Me.txtsearchID.Name = "txtsearchID"
        Me.txtsearchID.Size = New System.Drawing.Size(191, 20)
        Me.txtsearchID.TabIndex = 1
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
        Me.GroupBox2.Location = New System.Drawing.Point(38, 53)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1156, 64)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search"
        '
        'REGISTRATION
        '
        Me.REGISTRATION.AutoSize = True
        Me.REGISTRATION.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGISTRATION.Location = New System.Drawing.Point(22, 9)
        Me.REGISTRATION.Name = "REGISTRATION"
        Me.REGISTRATION.Size = New System.Drawing.Size(449, 31)
        Me.REGISTRATION.TabIndex = 9
        Me.REGISTRATION.Text = "GUARANTOR'S REGISTRATION"
        '
        'txtreligion
        '
        Me.txtreligion.Location = New System.Drawing.Point(124, 117)
        Me.txtreligion.Name = "txtreligion"
        Me.txtreligion.Size = New System.Drawing.Size(194, 20)
        Me.txtreligion.TabIndex = 27
        '
        'txtcontact
        '
        Me.txtcontact.Location = New System.Drawing.Point(736, 110)
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.Size = New System.Drawing.Size(159, 20)
        Me.txtcontact.TabIndex = 25
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(650, 117)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 13)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Contact"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(43, 247)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Date Of Registration"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(40, 117)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Religion"
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
        Me.txtResidence.Location = New System.Drawing.Point(447, 117)
        Me.txtResidence.Name = "txtResidence"
        Me.txtResidence.Size = New System.Drawing.Size(194, 20)
        Me.txtResidence.TabIndex = 15
        '
        'dtpDOB
        '
        Me.dtpDOB.CustomFormat = "dd/MMM/yyyy"
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDOB.Location = New System.Drawing.Point(736, 70)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(123, 20)
        Me.dtpDOB.TabIndex = 14
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(124, 70)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(194, 20)
        Me.txtFirstName.TabIndex = 11
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(124, 160)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(194, 20)
        Me.txtemail.TabIndex = 10
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(447, 70)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(194, 20)
        Me.txtSurname.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(357, 117)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Residence"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(650, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Date Of Birth"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "E-mail"
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
        'txtapplicantid
        '
        Me.txtapplicantid.Location = New System.Drawing.Point(124, 34)
        Me.txtapplicantid.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtapplicantid.Name = "txtapplicantid"
        Me.txtapplicantid.Size = New System.Drawing.Size(109, 20)
        Me.txtapplicantid.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.dtpdateofregistration)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtidnumber)
        Me.GroupBox1.Controls.Add(Me.txtidtype)
        Me.GroupBox1.Controls.Add(Me.txtofficetelephone)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtoccupationaddress)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtoccupation)
        Me.GroupBox1.Controls.Add(Me.txtreligion)
        Me.GroupBox1.Controls.Add(Me.txtcontact)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Browse)
        Me.GroupBox1.Controls.Add(Me.Picture)
        Me.GroupBox1.Controls.Add(Me.txtResidence)
        Me.GroupBox1.Controls.Add(Me.dtpDOB)
        Me.GroupBox1.Controls.Add(Me.txtFirstName)
        Me.GroupBox1.Controls.Add(Me.txtemail)
        Me.GroupBox1.Controls.Add(Me.txtSurname)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtapplicantid)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(38, 124)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1156, 295)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(357, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Surname"
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
        'txtoccupation
        '
        Me.txtoccupation.Location = New System.Drawing.Point(447, 164)
        Me.txtoccupation.Name = "txtoccupation"
        Me.txtoccupation.Size = New System.Drawing.Size(194, 20)
        Me.txtoccupation.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(357, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Occupation"
        '
        'txtoccupationaddress
        '
        Me.txtoccupationaddress.Location = New System.Drawing.Point(771, 167)
        Me.txtoccupationaddress.Name = "txtoccupationaddress"
        Me.txtoccupationaddress.Size = New System.Drawing.Size(159, 20)
        Me.txtoccupationaddress.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(650, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Occupation Address"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(40, 201)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 13)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Office Tel"
        '
        'txtofficetelephone
        '
        Me.txtofficetelephone.Location = New System.Drawing.Point(124, 201)
        Me.txtofficetelephone.Name = "txtofficetelephone"
        Me.txtofficetelephone.Size = New System.Drawing.Size(194, 20)
        Me.txtofficetelephone.TabIndex = 33
        '
        'txtidtype
        '
        Me.txtidtype.Location = New System.Drawing.Point(447, 201)
        Me.txtidtype.Name = "txtidtype"
        Me.txtidtype.Size = New System.Drawing.Size(194, 20)
        Me.txtidtype.TabIndex = 34
        '
        'txtidnumber
        '
        Me.txtidnumber.Location = New System.Drawing.Point(736, 201)
        Me.txtidnumber.Name = "txtidnumber"
        Me.txtidnumber.Size = New System.Drawing.Size(159, 20)
        Me.txtidnumber.TabIndex = 35
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(357, 208)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 13)
        Me.Label15.TabIndex = 36
        Me.Label15.Text = "ID type"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(650, 208)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 13)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "ID number"
        '
        'dtpdateofregistration
        '
        Me.dtpdateofregistration.Enabled = False
        Me.dtpdateofregistration.Location = New System.Drawing.Point(161, 247)
        Me.dtpdateofregistration.Name = "dtpdateofregistration"
        Me.dtpdateofregistration.Size = New System.Drawing.Size(280, 20)
        Me.dtpdateofregistration.TabIndex = 12
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FIRSTNAMEDataGridViewTextBoxColumn, Me.SURNAMEDataGridViewTextBoxColumn, Me.DOBDataGridViewTextBoxColumn, Me.RELIGIONDataGridViewTextBoxColumn, Me.RADDRESSDataGridViewTextBoxColumn, Me.TELEPHONEDataGridViewTextBoxColumn, Me.EMAILDataGridViewTextBoxColumn, Me.OCCUPATIONDataGridViewTextBoxColumn, Me.OADDRESSDataGridViewTextBoxColumn, Me.OFFICETELDataGridViewTextBoxColumn, Me.IDTYPEDataGridViewTextBoxColumn, Me.IDNUMBERDataGridViewTextBoxColumn, Me.REGDATEDataGridViewTextBoxColumn, Me.PHOTODataGridViewImageColumn})
        Me.DataGridView1.DataSource = Me.GuarantorsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(38, 509)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1156, 108)
        Me.DataGridView1.TabIndex = 12
        '
        'EACONSULTDataSet2
        '
        Me.EACONSULTDataSet2.DataSetName = "EACONSULTDataSet2"
        Me.EACONSULTDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GuarantorsBindingSource
        '
        Me.GuarantorsBindingSource.DataMember = "Guarantors"
        Me.GuarantorsBindingSource.DataSource = Me.EACONSULTDataSet2
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
        'Guarantor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1218, 642)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ACTIONS)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.REGISTRATION)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Guarantor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guarantor"
        Me.ACTIONS.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EACONSULTDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GuarantorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents txtsearchID As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents REGISTRATION As System.Windows.Forms.Label
    Friend WithEvents txtreligion As System.Windows.Forms.TextBox
    Friend WithEvents txtcontact As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Private WithEvents Browse As System.Windows.Forms.Button
    Public WithEvents Picture As System.Windows.Forms.PictureBox
    Friend WithEvents txtResidence As System.Windows.Forms.TextBox
    Friend WithEvents dtpDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtapplicantid As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtoccupationaddress As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtoccupation As System.Windows.Forms.TextBox
    Friend WithEvents dtpdateofregistration As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtidnumber As System.Windows.Forms.TextBox
    Friend WithEvents txtidtype As System.Windows.Forms.TextBox
    Friend WithEvents txtofficetelephone As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents EACONSULTDataSet2 As EACONSULT.EACONSULTDataSet2
    Friend WithEvents GuarantorsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GuarantorsTableAdapter As EACONSULT.EACONSULTDataSet2TableAdapters.GuarantorsTableAdapter
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
