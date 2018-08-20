Public Class StaffView

    Private Sub StaffView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EACONSULTDataSet4.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.EACONSULTDataSet4.Staff)

    End Sub
End Class