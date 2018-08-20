Public Class Expenseview

    Private Sub Expenseview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EACONSULTDataSet9.Expense' table. You can move, or remove it, as needed.
        Me.ExpenseTableAdapter.Fill(Me.EACONSULTDataSet9.Expense)

    End Sub
End Class