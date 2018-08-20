Public Class HOME
    Sub New()
        InitializeComponent()

        AddHandler panHeader.MouseDown, New MouseEventHandler(AddressOf ctl_MouseDown)
        AddHandler panHeader.MouseMove, New MouseEventHandler(AddressOf ctl_MouseMove)
        AddHandler panHeader.MouseUp, New MouseEventHandler(AddressOf ctl_MouseUp)


    End Sub

#Region "MOUSE-EVENTS ON PANEL CONTROL"
    Private m_WindowState As FormWindowState = FormWindowState.Normal
    Private m_MousePressed As Boolean = False
    Private m_oldx As Integer, m_oldy As Integer

    Private Sub ctl_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
        Dim TS As Point = Me.PointToScreen(e.Location)
        m_oldx = TS.X
        m_oldy = TS.Y
        m_MousePressed = True

    End Sub

    Private Sub ctl_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
        m_MousePressed = False

    End Sub

    Private Sub ctl_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
        If m_MousePressed = True AndAlso m_WindowState <> FormWindowState.Maximized Then
            Dim TS As Point = Me.PointToScreen(e.Location)

            Me.Location = New Point(Me.Location.X + (TS.X - m_oldx), Me.Location.Y + (TS.Y - m_oldy))
            m_oldx = TS.X
            m_oldy = TS.Y
        End If
       

    End Sub
#End Region



    Private Sub HOME_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover

    End Sub

    Private Sub PictureBox1_DragEnter(sender As Object, e As DragEventArgs) Handles PictureBox1.DragEnter
        PictureBox1.BackColor = Color.Aqua
    End Sub

    Private Sub PictureBox1_DragLeave(sender As Object, e As EventArgs) Handles PictureBox1.DragLeave
        PictureBox1.BackColor = Color.White
    End Sub

    Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox2.MouseEnter
        PictureBox2.BackColor = Color.Aqua
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.BackColor = Color.White
    End Sub

    Private Sub PictureBox3_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox3.MouseEnter
        PictureBox3.BackColor = Color.Aqua
    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.BackColor = Color.White
    End Sub

    Private Sub PictureBox4_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox4.MouseEnter
        PictureBox4.BackColor = Color.Aqua
    End Sub

    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.BackColor = Color.White
    End Sub

    Private Sub panHeader_Paint(sender As Object, e As PaintEventArgs) Handles panHeader.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        APPLICANTFORM.Show()


    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Guarantor.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Staff.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Deploy.Show()

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        FINANCE.Show()

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Vacancies.Show()
    End Sub

    Private Sub PanBody_Paint(sender As Object, e As PaintEventArgs) Handles PanBody.Paint

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub LogOut_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LogOut.LinkClicked
        Me.Hide()
        Form1.Show()

    End Sub
End Class