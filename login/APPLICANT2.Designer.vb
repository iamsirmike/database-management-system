<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class APPLICANT2
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
        Me.txtlastplaceworked = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtmanagersno = New System.Windows.Forms.TextBox()
        Me.txtjob1 = New System.Windows.Forms.TextBox()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EACONSULTDataSet3 = New EACONSULT.EACONSULTDataSet3()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtjob2 = New System.Windows.Forms.TextBox()
        Me.txtjob3 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtapplicantid = New System.Windows.Forms.TextBox()
        Me.StaffTableAdapter = New EACONSULT.EACONSULTDataSet3TableAdapters.StaffTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ACTIONS = New System.Windows.Forms.GroupBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.REGISTRATION = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbyearsworked = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbareyouacomputerliterate = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbaccesstous = New System.Windows.Forms.ComboBox()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EACONSULTDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.ACTIONS.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtlastplaceworked
        '
        Me.txtlastplaceworked.Location = New System.Drawing.Point(140, 111)
        Me.txtlastplaceworked.Name = "txtlastplaceworked"
        Me.txtlastplaceworked.Size = New System.Drawing.Size(194, 20)
        Me.txtlastplaceworked.TabIndex = 25
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(40, 113)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 13)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Last place worked"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(650, 113)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Years Worked"
        '
        'txtmanagersno
        '
        Me.txtmanagersno.Location = New System.Drawing.Point(447, 106)
        Me.txtmanagersno.Name = "txtmanagersno"
        Me.txtmanagersno.Size = New System.Drawing.Size(194, 20)
        Me.txtmanagersno.TabIndex = 15
        '
        'txtjob1
        '
        Me.txtjob1.Location = New System.Drawing.Point(224, 67)
        Me.txtjob1.Name = "txtjob1"
        Me.txtjob1.Size = New System.Drawing.Size(194, 20)
        Me.txtjob1.TabIndex = 11
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
        Me.GroupBox1.Controls.Add(Me.cmbaccesstous)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cmbareyouacomputerliterate)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmbyearsworked)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtlastplaceworked)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtmanagersno)
        Me.GroupBox1.Controls.Add(Me.txtjob1)
        Me.GroupBox1.Controls.Add(Me.txtjob2)
        Me.GroupBox1.Controls.Add(Me.txtjob3)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtapplicantid)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(43, 81)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1019, 248)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal details"
        '
        'txtjob2
        '
        Me.txtjob2.Location = New System.Drawing.Point(470, 67)
        Me.txtjob2.Name = "txtjob2"
        Me.txtjob2.Size = New System.Drawing.Size(194, 20)
        Me.txtjob2.TabIndex = 10
        '
        'txtjob3
        '
        Me.txtjob3.Location = New System.Drawing.Point(736, 67)
        Me.txtjob3.Name = "txtjob3"
        Me.txtjob3.Size = New System.Drawing.Size(194, 20)
        Me.txtjob3.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(346, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Managers No"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Types Of Job"
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
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(213, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 33)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "&Clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ACTIONS
        '
        Me.ACTIONS.Controls.Add(Me.Button1)
        Me.ACTIONS.Controls.Add(Me.btnSave)
        Me.ACTIONS.Location = New System.Drawing.Point(43, 351)
        Me.ACTIONS.Name = "ACTIONS"
        Me.ACTIONS.Size = New System.Drawing.Size(355, 77)
        Me.ACTIONS.TabIndex = 16
        Me.ACTIONS.TabStop = False
        Me.ACTIONS.Text = "Actions"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(85, 19)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(95, 33)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'REGISTRATION
        '
        Me.REGISTRATION.AutoSize = True
        Me.REGISTRATION.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGISTRATION.Location = New System.Drawing.Point(37, 9)
        Me.REGISTRATION.Name = "REGISTRATION"
        Me.REGISTRATION.Size = New System.Drawing.Size(283, 31)
        Me.REGISTRATION.TabIndex = 14
        Me.REGISTRATION.Text = "APPLICANT FORM2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(700, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "3. "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(444, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "2."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(192, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "1."
        '
        'cmbyearsworked
        '
        Me.cmbyearsworked.FormattingEnabled = True
        Me.cmbyearsworked.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "Others.."})
        Me.cmbyearsworked.Location = New System.Drawing.Point(769, 104)
        Me.cmbyearsworked.Name = "cmbyearsworked"
        Me.cmbyearsworked.Size = New System.Drawing.Size(121, 21)
        Me.cmbyearsworked.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Are you a computer literate?"
        '
        'cmbareyouacomputerliterate
        '
        Me.cmbareyouacomputerliterate.FormattingEnabled = True
        Me.cmbareyouacomputerliterate.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmbareyouacomputerliterate.Location = New System.Drawing.Point(195, 153)
        Me.cmbareyouacomputerliterate.Name = "cmbareyouacomputerliterate"
        Me.cmbareyouacomputerliterate.Size = New System.Drawing.Size(121, 21)
        Me.cmbareyouacomputerliterate.TabIndex = 32
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(346, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(153, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "How did you get access to us?"
        '
        'cmbaccesstous
        '
        Me.cmbaccesstous.FormattingEnabled = True
        Me.cmbaccesstous.Items.AddRange(New Object() {"Through the internet", "poster", "flyer", "other.."})
        Me.cmbaccesstous.Location = New System.Drawing.Point(505, 156)
        Me.cmbaccesstous.Name = "cmbaccesstous"
        Me.cmbaccesstous.Size = New System.Drawing.Size(121, 21)
        Me.cmbaccesstous.TabIndex = 34
        '
        'APPLICANT2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1119, 576)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ACTIONS)
        Me.Controls.Add(Me.REGISTRATION)
        Me.Name = "APPLICANT2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "APPLICANT2"
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EACONSULTDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ACTIONS.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtlastplaceworked As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtmanagersno As System.Windows.Forms.TextBox
    Friend WithEvents txtjob1 As System.Windows.Forms.TextBox
    Friend WithEvents StaffBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EACONSULTDataSet3 As EACONSULT.EACONSULTDataSet3
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbaccesstous As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbareyouacomputerliterate As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbyearsworked As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtjob2 As System.Windows.Forms.TextBox
    Friend WithEvents txtjob3 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtapplicantid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents StaffTableAdapter As EACONSULT.EACONSULTDataSet3TableAdapters.StaffTableAdapter
    Public WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ACTIONS As System.Windows.Forms.GroupBox
    Public WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents REGISTRATION As System.Windows.Forms.Label
End Class
