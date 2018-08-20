Public Class APPLICANTFORM2VIEW

    Private Sub APPLICANTFORM2VIEW_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EACONSULTDataSet17.Applicant2' table. You can move, or remove it, as needed.
        Me.Applicant2TableAdapter.Fill(Me.EACONSULTDataSet17.Applicant2)

    End Sub
End Class