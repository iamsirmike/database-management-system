Public Class incomeview

    Private Sub incomeview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EACONSULTDataSet8.Income' table. You can move, or remove it, as needed.
        Me.IncomeTableAdapter.Fill(Me.EACONSULTDataSet8.Income)

    End Sub
End Class