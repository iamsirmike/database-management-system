Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Public Class Income
    'variables
    Dim Amount As Double

    'database declaration
    Dim con As New SqlConnection("Data Source=(local);Initial Catalog=EACONSULT;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim dt As New DataTable
    Dim i As Integer
    Dim dr As SqlDataReader

    Public Shared Function GetUniqueKey(ByVal maxSize As Integer) As String
        Dim chars As Char() = New Char(61) {}
        chars = "123456789".ToCharArray()
        Dim data As Byte() = New Byte(0) {}
        Dim crypto As New RNGCryptoServiceProvider()
        crypto.GetNonZeroBytes(data)
        data = New Byte(maxSize - 1) {}
        crypto.GetNonZeroBytes(data)
        Dim result As New StringBuilder(maxSize)
        For Each b As Byte In data
            result.Append(chars(b Mod (chars.Length)))
        Next
        Return result.ToString()
    End Function
    Sub reset()
        txtID.Clear()
        txtpurpose.Clear()
        txtamount.Clear()
        txtdescription.Clear()
        txttotal.Clear()

    End Sub
    Private Sub Income_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bnsave.Enabled = False
        bnclear.Enabled = False
        bncalc.Enabled = False
    End Sub

    Private Sub bnsave_Click(sender As Object, e As EventArgs) Handles bnsave.Click

        'insert statement


        If txtID.Text = "" Then
            MsgBox("ID shouldnt be empty")
            txtID.Focus()

        ElseIf txtpurpose.Text = "" Then
            MsgBox("There should be a purpose")
            txtpurpose.Focus()

        ElseIf txtamount.Text = "" Then
            MsgBox("Amount shouldnt be empty")
            txtamount.Focus()

        Else
            Try
                con.Close()
                con.Open()


                Using cmd As New SqlCommand("INSERT INTO Income(ID, Purpose, Amount, IDescription, IDate, TOTAL) VALUES ('" & txtID.Text & "', '" & txtpurpose.Text & "', '" & txtamount.Text & "', '" & txtdescription.Text & "', '" & dtpdate.Text & "', '" & txttotal.Text & "')", con)


                    i = cmd.ExecuteNonQuery

                End Using
                MsgBox("Submitted Sucessfully")
                con.Close()
                con.Open()



            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End If
        reset()
        bnsave.Enabled = False
        bnnew.Enabled = True


    End Sub

    Private Sub bnclear_Click(sender As Object, e As EventArgs) Handles bnclear.Click
        reset()
        bnnew.Enabled = True
    End Sub

    Private Sub bncalc_Click(sender As Object, e As EventArgs) Handles bncalc.Click
        Dim con As New SqlConnection
        Dim comm As New SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim dataset As New DataSet
        Dim dr As SqlDataReader


        con.ConnectionString = "Data Source=(local);Initial Catalog=EACONSULT;Integrated Security=True"

        If txtID.Text = "" Then
            MsgBox("ID shouldnt be empty")
            txtID.Focus()

        ElseIf txtpurpose.Text = "" Then
            MsgBox("There should be a purpose")
            txtpurpose.Focus()

        ElseIf txtamount.Text = "" Then
            MsgBox("Amount shouldnt be empty")
            txtamount.Focus()

        Else : Try




                comm.CommandText = "select MAX(TOTAL) from Income"
                con.Close()
                con.Open()
                comm.Connection = con
                adapter.SelectCommand = comm
                adapter.Fill(dataset, "Income")
                Dim count As Integer = dataset.Tables("Income").Rows.Count
                Dim dt As New DataTable

                If count > 0 Then
                    dr = comm.ExecuteReader()


                    While dr.Read()


                        txttotal.Text = dr.GetValue(0)
                        Amount = txtamount.Text
                        txttotal.Text = txttotal.Text + Amount








                    End While
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()

            End Try
        End If
        bnsave.Enabled = True
        bncalc.Enabled = False

    End Sub

    Private Sub bnnew_Click(sender As Object, e As EventArgs) Handles bnnew.Click
        'total
        txtID.Text = "E-" & GetUniqueKey(5)
        bncalc.Enabled = True
        bnclear.Enabled = True
        bnnew.Enabled = False

    End Sub
End Class