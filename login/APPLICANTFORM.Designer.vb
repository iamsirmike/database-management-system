<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class APPLICANTFORM
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
        Me.txtcontact = New System.Windows.Forms.TextBox()
        Me.txtnationality = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Checkboxverified = New System.Windows.Forms.CheckBox()
        Me.txteducationalqualification = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtotherqualification = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtemergencyname = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtlastschoolattended = New System.Windows.Forms.TextBox()
        Me.txtemergencycontact = New System.Windows.Forms.TextBox()
        Me.label = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpRegistered = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Browse = New System.Windows.Forms.Button()
        Me.Picture = New System.Windows.Forms.PictureBox()
        Me.txtResidence = New System.Windows.Forms.TextBox()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.cmbMR = New System.Windows.Forms.ComboBox()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtlastname = New System.Windows.Forms.TextBox()
        Me.txtfirstname = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.EACONSULTDataSet = New EACONSULT.EACONSULTDataSet()
        Me.ApplicantTableAdapter = New EACONSULT.EACONSULTDataSetTableAdapters.ApplicantTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ACTIONS.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApplicantBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EACONSULTDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ACTIONS.Location = New System.Drawing.Point(41, 433)
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
        Me.GroupBox2.Location = New System.Drawing.Point(41, 59)
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
        Me.REGISTRATION.Location = New System.Drawing.Point(25, 16)
        Me.REGISTRATION.Name = "REGISTRATION"
        Me.REGISTRATION.Size = New System.Drawing.Size(401, 31)
        Me.REGISTRATION.TabIndex = 9
        Me.REGISTRATION.Text = "APPLICANT REGISTRATION"
        '
        'txtcontact
        '
        Me.txtcontact.Location = New System.Drawing.Point(124, 148)
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.Size = New System.Drawing.Size(194, 20)
        Me.txtcontact.TabIndex = 8
        '
        'txtnationality
        '
        Me.txtnationality.Location = New System.Drawing.Point(736, 110)
        Me.txtnationality.Name = "txtnationality"
        Me.txtnationality.Size = New System.Drawing.Size(194, 20)
        Me.txtnationality.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(650, 117)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 13)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Nationality"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Checkboxverified)
        Me.GroupBox1.Controls.Add(Me.txteducationalqualification)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.txtotherqualification)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.txtemergencyname)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtlastschoolattended)
        Me.GroupBox1.Controls.Add(Me.txtemergencycontact)
        Me.GroupBox1.Controls.Add(Me.label)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtcontact)
        Me.GroupBox1.Controls.Add(Me.txtnationality)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.dtpRegistered)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Browse)
        Me.GroupBox1.Controls.Add(Me.Picture)
        Me.GroupBox1.Controls.Add(Me.txtResidence)
        Me.GroupBox1.Controls.Add(Me.dtpDOB)
        Me.GroupBox1.Controls.Add(Me.cmbMR)
        Me.GroupBox1.Controls.Add(Me.cmbGender)
        Me.GroupBox1.Controls.Add(Me.txtemail)
        Me.GroupBox1.Controls.Add(Me.txtlastname)
        Me.GroupBox1.Controls.Add(Me.txtfirstname)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtid)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(41, 130)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1156, 296)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal details"
        '
        'Checkboxverified
        '
        Me.Checkboxverified.AutoSize = True
        Me.Checkboxverified.Location = New System.Drawing.Point(946, 250)
        Me.Checkboxverified.Name = "Checkboxverified"
        Me.Checkboxverified.Size = New System.Drawing.Size(103, 17)
        Me.Checkboxverified.TabIndex = 18
        Me.Checkboxverified.Text = "Terms accepted"
        Me.Checkboxverified.UseVisualStyleBackColor = True
        '
        'txteducationalqualification
        '
        Me.txteducationalqualification.Location = New System.Drawing.Point(179, 249)
        Me.txteducationalqualification.Name = "txteducationalqualification"
        Me.txteducationalqualification.Size = New System.Drawing.Size(148, 20)
        Me.txteducationalqualification.TabIndex = 14
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(49, 255)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(124, 13)
        Me.Label19.TabIndex = 39
        Me.Label19.Text = "Educational Qualification"
        '
        'txtotherqualification
        '
        Me.txtotherqualification.Location = New System.Drawing.Point(456, 248)
        Me.txtotherqualification.Name = "txtotherqualification"
        Me.txtotherqualification.Size = New System.Drawing.Size(194, 20)
        Me.txtotherqualification.TabIndex = 15
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(344, 255)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(94, 13)
        Me.Label21.TabIndex = 35
        Me.Label21.Text = "Other Qualification"
        '
        'txtemergencyname
        '
        Me.txtemergencyname.Location = New System.Drawing.Point(153, 202)
        Me.txtemergencyname.Name = "txtemergencyname"
        Me.txtemergencyname.Size = New System.Drawing.Size(194, 20)
        Me.txtemergencyname.TabIndex = 11
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(402, 348)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(103, 13)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "Date Of Registration"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(43, 206)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(104, 13)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "Emergency C. Name"
        '
        'txtlastschoolattended
        '
        Me.txtlastschoolattended.Location = New System.Drawing.Point(736, 195)
        Me.txtlastschoolattended.Name = "txtlastschoolattended"
        Me.txtlastschoolattended.Size = New System.Drawing.Size(194, 20)
        Me.txtlastschoolattended.TabIndex = 13
        '
        'txtemergencycontact
        '
        Me.txtemergencycontact.Location = New System.Drawing.Point(477, 199)
        Me.txtemergencycontact.Name = "txtemergencycontact"
        Me.txtemergencycontact.Size = New System.Drawing.Size(164, 20)
        Me.txtemergencycontact.TabIndex = 12
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Location = New System.Drawing.Point(650, 202)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(69, 13)
        Me.label.TabIndex = 29
        Me.label.Text = "L.S Attended"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(371, 202)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(100, 13)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "Emergency Contact"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(656, 251)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Date Of Registration"
        '
        'dtpRegistered
        '
        Me.dtpRegistered.CustomFormat = "dd/MMM/yyyy"
        Me.dtpRegistered.Enabled = False
        Me.dtpRegistered.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpRegistered.Location = New System.Drawing.Point(784, 244)
        Me.dtpRegistered.Name = "dtpRegistered"
        Me.dtpRegistered.Size = New System.Drawing.Size(123, 20)
        Me.dtpRegistered.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(40, 154)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Telephone"
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
        'txtResidence
        '
        Me.txtResidence.Location = New System.Drawing.Point(736, 143)
        Me.txtResidence.Name = "txtResidence"
        Me.txtResidence.Size = New System.Drawing.Size(194, 20)
        Me.txtResidence.TabIndex = 10
        '
        'dtpDOB
        '
        Me.dtpDOB.CustomFormat = "dd/MMM/yyyy"
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDOB.Location = New System.Drawing.Point(736, 63)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(123, 20)
        Me.dtpDOB.TabIndex = 4
        '
        'cmbMR
        '
        Me.cmbMR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMR.FormattingEnabled = True
        Me.cmbMR.Items.AddRange(New Object() {"Single", "Married", "Widow", "Separated"})
        Me.cmbMR.Location = New System.Drawing.Point(447, 104)
        Me.cmbMR.Name = "cmbMR"
        Me.cmbMR.Size = New System.Drawing.Size(144, 21)
        Me.cmbMR.TabIndex = 6
        '
        'cmbGender
        '
        Me.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"M", "F"})
        Me.cmbGender.Location = New System.Drawing.Point(124, 109)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(60, 21)
        Me.cmbGender.TabIndex = 5
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(447, 147)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(194, 20)
        Me.txtemail.TabIndex = 9
        '
        'txtlastname
        '
        Me.txtlastname.Location = New System.Drawing.Point(447, 67)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(194, 20)
        Me.txtlastname.TabIndex = 3
        '
        'txtfirstname
        '
        Me.txtfirstname.Location = New System.Drawing.Point(124, 70)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(194, 20)
        Me.txtfirstname.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(650, 150)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Residence"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(650, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Date Of Birth"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(335, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Marital Status"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Gender"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(335, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "E-mail"
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
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'txtid
        '
        Me.txtid.Enabled = False
        Me.txtid.Location = New System.Drawing.Point(124, 34)
        Me.txtid.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(109, 20)
        Me.txtid.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "First Name"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FIRSTNAMEDataGridViewTextBoxColumn, Me.LASTNAMEDataGridViewTextBoxColumn, Me.DOBDataGridViewTextBoxColumn, Me.GENDERDataGridViewTextBoxColumn, Me.MSTATUSDataGridViewTextBoxColumn, Me.NATIONALITYDataGridViewTextBoxColumn, Me.PHONEDataGridViewTextBoxColumn, Me.EMAILDataGridViewTextBoxColumn, Me.RADDRESSDataGridViewTextBoxColumn, Me.ECNAMEDataGridViewTextBoxColumn, Me.ECONTACTDataGridViewTextBoxColumn, Me.LSATTENDEDDataGridViewTextBoxColumn, Me.EDUQUALIFICATIONDataGridViewTextBoxColumn, Me.OTHERQUALIFICATIONDataGridViewTextBoxColumn, Me.REGDATEDataGridViewTextBoxColumn, Me.PhotoDataGridViewImageColumn})
        Me.DataGridView1.DataSource = Me.ApplicantBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(41, 516)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1156, 82)
        Me.DataGridView1.TabIndex = 12
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
        Me.ApplicantBindingSource.DataSource = Me.EACONSULTDataSet
        '
        'EACONSULTDataSet
        '
        Me.EACONSULTDataSet.DataSetName = "EACONSULTDataSet"
        Me.EACONSULTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ApplicantTableAdapter
        '
        Me.ApplicantTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(961, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 41)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "MOVE TO PAGE 2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'APPLICANTFORM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1222, 613)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ACTIONS)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.REGISTRATION)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "APPLICANTFORM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "APPLICANTFORM"
        Me.ACTIONS.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApplicantBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EACONSULTDataSet, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtcontact As System.Windows.Forms.TextBox
    Friend WithEvents txtnationality As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dtpRegistered As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Private WithEvents Browse As System.Windows.Forms.Button
    Public WithEvents Picture As System.Windows.Forms.PictureBox
    Friend WithEvents txtResidence As System.Windows.Forms.TextBox
    Friend WithEvents dtpDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbMR As System.Windows.Forms.ComboBox
    Friend WithEvents cmbGender As System.Windows.Forms.ComboBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents txtlastname As System.Windows.Forms.TextBox
    Friend WithEvents txtfirstname As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txteducationalqualification As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtotherqualification As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtemergencyname As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtlastschoolattended As System.Windows.Forms.TextBox
    Friend WithEvents txtemergencycontact As System.Windows.Forms.TextBox
    Friend WithEvents label As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents EACONSULTDataSet As EACONSULT.EACONSULTDataSet
    Friend WithEvents ApplicantBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ApplicantTableAdapter As EACONSULT.EACONSULTDataSetTableAdapters.ApplicantTableAdapter
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
    Friend WithEvents Checkboxverified As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
