Public Class Deleted

    Private Sub Deleted_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: This line of code loads data into the 'EACONSULTDataSet16.Deleted_applicants' table. You can move, or remove it, as needed.
            Me.Deleted_applicantsTableAdapter.Fill(Me.EACONSULTDataSet16.Deleted_applicants)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        

    End Sub
End Class