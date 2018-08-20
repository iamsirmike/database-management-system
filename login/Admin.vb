Public Class AdminForm


    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        AddUser.Show()

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        SearchUser.Show()

    End Sub

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LOgOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOgOutToolStripMenuItem.Click
        Me.Close()
        Form1.Show()

    End Sub

    Private Sub CustomizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomizeToolStripMenuItem.Click
        Dim ColorDialog1 As New ColorDialog
        ColorDialog1.Color = Me.BackColor
        ColorDialog1.ShowDialog()
        Me.BackColor = ColorDialog1.Color
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        APPLICANTSVIEW.Show()
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        StaffView.Show()
    End Sub

    Private Sub IncomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncomeToolStripMenuItem.Click
        Income.Show()

    End Sub

    Private Sub ExpenseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExpenseToolStripMenuItem.Click
        Expense.Show()

    End Sub

    Private Sub VIEWORDERSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VIEWORDERSToolStripMenuItem.Click
        Guarantorsview.Show()

    End Sub

    Private Sub VIEWDeliveredToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VIEWDeliveredToolStripMenuItem.Click
        Deployedview.Show()

    End Sub

    Private Sub TotalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TotalToolStripMenuItem.Click
        Total.Show()

    End Sub

    Private Sub VIEWCustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VIEWCustomersToolStripMenuItem.Click
        APPLICANTSVIEW.Show()
    End Sub

    Private Sub ViewIncomeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ViewIncomeToolStripMenuItem1.Click
        incomeview.Show()

    End Sub

    Private Sub ViewExpenseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewExpenseToolStripMenuItem.Click
        Expenseview.Show()

    End Sub

    Private Sub ViewIncomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewIncomeToolStripMenuItem.Click
        TotalView.Show()

    End Sub

    Private Sub VIEWRegisteredToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VIEWRegisteredToolStripMenuItem.Click
        Vacanciesview.Show()
    End Sub

    Private Sub AboutSoftwareToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutSoftwareToolStripMenuItem.Click

    End Sub

    Private Sub STATSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles STATSToolStripMenuItem.Click
        Deleted.Show()
    End Sub

    Private Sub Page2ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Page2ViewToolStripMenuItem.Click
        APPLICANTFORM2VIEW.Show()

    End Sub
End Class