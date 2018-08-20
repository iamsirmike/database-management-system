Public Class Deployedview

    Private Sub Deployedview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EACONSULTDataSet7.Deploy' table. You can move, or remove it, as needed.
        Me.DeployTableAdapter.Fill(Me.EACONSULTDataSet7.Deploy)

    End Sub
End Class