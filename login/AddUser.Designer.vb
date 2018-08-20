<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUser
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRETYPE = New System.Windows.Forms.TextBox()
        Me.bnCLEAR = New System.Windows.Forms.Button()
        Me.bnADD = New System.Windows.Forms.Button()
        Me.txtPASSWORD = New System.Windows.Forms.TextBox()
        Me.txtUSERNAME = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtRETYPE)
        Me.GroupBox1.Controls.Add(Me.bnCLEAR)
        Me.GroupBox1.Controls.Add(Me.bnADD)
        Me.GroupBox1.Controls.Add(Me.txtPASSWORD)
        Me.GroupBox1.Controls.Add(Me.txtUSERNAME)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(83, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(421, 233)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "USER DETAILS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "RETYPE_PASSWORD:"
        '
        'txtRETYPE
        '
        Me.txtRETYPE.Location = New System.Drawing.Point(157, 125)
        Me.txtRETYPE.Multiline = True
        Me.txtRETYPE.Name = "txtRETYPE"
        Me.txtRETYPE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRETYPE.Size = New System.Drawing.Size(172, 26)
        Me.txtRETYPE.TabIndex = 6
        '
        'bnCLEAR
        '
        Me.bnCLEAR.Location = New System.Drawing.Point(263, 173)
        Me.bnCLEAR.Name = "bnCLEAR"
        Me.bnCLEAR.Size = New System.Drawing.Size(75, 31)
        Me.bnCLEAR.TabIndex = 5
        Me.bnCLEAR.Text = "CLEAR"
        Me.bnCLEAR.UseVisualStyleBackColor = True
        '
        'bnADD
        '
        Me.bnADD.Location = New System.Drawing.Point(157, 173)
        Me.bnADD.Name = "bnADD"
        Me.bnADD.Size = New System.Drawing.Size(75, 31)
        Me.bnADD.TabIndex = 4
        Me.bnADD.Text = "ADD"
        Me.bnADD.UseVisualStyleBackColor = True
        '
        'txtPASSWORD
        '
        Me.txtPASSWORD.Location = New System.Drawing.Point(159, 83)
        Me.txtPASSWORD.Multiline = True
        Me.txtPASSWORD.Name = "txtPASSWORD"
        Me.txtPASSWORD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPASSWORD.Size = New System.Drawing.Size(172, 26)
        Me.txtPASSWORD.TabIndex = 3
        '
        'txtUSERNAME
        '
        Me.txtUSERNAME.Location = New System.Drawing.Point(157, 34)
        Me.txtUSERNAME.Multiline = True
        Me.txtUSERNAME.Name = "txtUSERNAME"
        Me.txtUSERNAME.Size = New System.Drawing.Size(172, 29)
        Me.txtUSERNAME.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PASSWORD:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "USERNAME:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Lime
        Me.Label4.Location = New System.Drawing.Point(236, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 24)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "ADD USER"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.MidnightBlue
        Me.PictureBox1.Location = New System.Drawing.Point(0, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(593, 50)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'AddUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(586, 327)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "AddUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddUser"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRETYPE As System.Windows.Forms.TextBox
    Friend WithEvents bnCLEAR As System.Windows.Forms.Button
    Friend WithEvents bnADD As System.Windows.Forms.Button
    Friend WithEvents txtPASSWORD As System.Windows.Forms.TextBox
    Friend WithEvents txtUSERNAME As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
