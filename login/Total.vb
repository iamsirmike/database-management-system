Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Public Class Total

    'database declaration
    Dim con As New SqlConnection("Data Source=(local);Initial Catalog=EACONSULT;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim dt As New DataTable
    Dim i As Integer
    Dim dr As SqlDataReader
    Private Sub Total_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection
        Dim comm As New SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim dataset As New DataSet
        Dim dr As SqlDataReader


        con.ConnectionString = "Data Source=(local);Initial Catalog=EACONSULT;Integrated Security=True"



        Try

            comm.CommandText = "select MAX(Total) from Income"
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


                    txtincome.Text = dr.GetValue(0)








                End While
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()

        End Try


        Try

            comm.CommandText = "select MAX(Total) from Expense"
            con.Close()
            con.Open()
            comm.Connection = con
            adapter.SelectCommand = comm
            adapter.Fill(dataset, "Expense")
            Dim count As Integer = dataset.Tables("Expense").Rows.Count
            Dim dt As New DataTable

            If count > 0 Then
                dr = comm.ExecuteReader()


                While dr.Read()


                    txtexpense.Text = dr.GetValue(0)








                End While
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txttotal.Text = txtincome.Text - txtexpense.Text
        If txttotal.Text > 0 Then
            MsgBox("CONGRATULATIONS THERE WAS A PROFIT GH¢  " + txttotal.Text)
        Else
            MsgBox("SORRY THERE WAS A LOSS OF GH¢ " + txttotal.Text)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            con.Close()
            con.Open()


            Using cmd As New SqlCommand("INSERT Total (TDATE, INCOME, EXPENSE, TOTAL) VALUES ('" & dtpdate.Text & "', '" & txtincome.Text & "', '" & txtexpense.Text & "', '" & txttotal.Text & "')", con)


                i = cmd.ExecuteNonQuery

            End Using
            MsgBox("Submitted Sucessfully")
            con.Close()
            con.Open()



        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub
End Class