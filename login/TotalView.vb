Public Class TotalView

    Private Sub TotalView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EACONSULTDataSet11.Total' table. You can move, or remove it, as needed.
        Me.TotalTableAdapter1.Fill(Me.EACONSULTDataSet11.Total)


    End Sub
End Class