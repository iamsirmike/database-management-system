Public Class Vacanciesview

    Private Sub Vacanciesview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EACONSULTDataSet15.Vacancies' table. You can move, or remove it, as needed.
        Me.VacanciesTableAdapter.Fill(Me.EACONSULTDataSet15.Vacancies)

    End Sub
End Class