Public Class Guarantorsview

    Private Sub Guarantorsview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EACONSULTDataSet6.Guarantors' table. You can move, or remove it, as needed.
        Me.GuarantorsTableAdapter.Fill(Me.EACONSULTDataSet6.Guarantors)

    End Sub
End Class