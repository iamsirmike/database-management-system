Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlTypes
Public Class Vacancies
    Dim con As New SqlConnection("Data Source=(local);Initial Catalog=EACONSULT;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim dt As New DataTable
    Dim i As Integer
    Dim dr As SqlDataReader

    Sub Reset()
        txtsearchID.Text = ""
        txtsearchname.Text = ""
        txtcompanyname.Text = ""
        txtlocation.Text = ""
        txttelephone.Text = ""
        ComboBox1.Text = ""

    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtcompanyname.Text = "" Then
            MsgBox("Please enter a Staff ID")
            txtcompanyname.Focus()

        ElseIf txtlocation.Text = "" Then
            MsgBox("Pleaase enter First Name")
            txtlocation.Focus()

        ElseIf txttelephone.Text = "" Then
            MsgBox("Please enter Last Name")
            txttelephone.Focus()


        Else



            Try



                con.Close()
                con.Open()


                Using cmd As New SqlCommand("INSERT INTO Vacancies(COMPANYNAME, LOCATION, TELEPHONE, V_DATE, DEPLOYED, DATEDEPLOYED) VALUES ('" & txtcompanyname.Text & "', '" & txtlocation.Text & "', '" & txttelephone.Text & "','" & dtpvacancydate.Text & "', '" & ComboBox1.Text & "', '" & dtpdatedeployed.Text & "' )", con)


                    i = cmd.ExecuteNonQuery

                End Using
                MsgBox("Submitted Sucessfully")
                con.Close()
                con.Open()



            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
            'display in datagrid view after saving
            Try
                Dim searchDt As New DataTable

                con.Close()
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "SELECT * FROM Vacancies"

                dr = cmd.ExecuteReader

                If dr.HasRows Then
                    con.Close()
                    con.Open()
                    With cmd
                        .Connection = con
                        .CommandText = "SELECT * From Vacancies"
                    End With
                    da.SelectCommand = cmd
                    dt.Clear()
                    da.Fill(searchDt)
                    Me.DataGridView1.DataSource = searchDt
                    con.Close()

                End If

            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()
            End Try
            Reset()

        End If
    End Sub

    Private Sub Vacancies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EACONSULTDataSet14.Vacancies' table. You can move, or remove it, as needed.
        Me.VacanciesTableAdapter2.Fill(Me.EACONSULTDataSet14.Vacancies)


    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtsearchname.Text = "" Then


            If MessageBox.Show("Are you sure you want to Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Try
                    con.Close()

                    con.Open()

                    With cmd
                        .Connection = con
                        .CommandText = "DELETE FROM Vacancies WHERE COMPANYNAME ='" & txtsearchID.Text & "'"
                        i = .ExecuteNonQuery
                    End With

                    If i > 0 Then
                        MsgBox("DELETED")
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                    con.Close()
                    con.Close()
                End Try
                'display in datagrid view after saving
                Try
                    Dim searchDt As New DataTable

                    con.Close()
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "SELECT * FROM Vacancies"


                    dr = cmd.ExecuteReader

                    If dr.HasRows Then
                        con.Close()
                        con.Open()
                        With cmd
                            .Connection = con
                            .CommandText = "SELECT * FROM Vacancies"

                        End With
                        da.SelectCommand = cmd
                        dt.Clear()
                        da.Fill(searchDt)
                        Me.DataGridView1.DataSource = searchDt
                        con.Close()

                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                    con.Close()
                End Try
                Reset()

            End If
        Else

            If MessageBox.Show("Are you sure you want to Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Try
                    con.Close()

                    con.Open()

                    With cmd
                        .Connection = con
                        .CommandText = "DELETE FROM Vacancies WHERE COMPANYNAME ='" & txtsearchname.Text & "'"
                        i = .ExecuteNonQuery
                    End With

                    If i > 0 Then
                        MsgBox("DELETED")
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                    con.Close()
                    con.Open()

                End Try
                'display in datagrid view after saving
                Try
                    Dim searchDt As New DataTable

                    con.Close()
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "SELECT * FROM Vacancies"

                    dr = cmd.ExecuteReader

                    If dr.HasRows Then
                        con.Close()
                        con.Open()
                        With cmd
                            .Connection = con
                            .CommandText = "SELECT * FROM Vacancies"
                        End With
                        da.SelectCommand = cmd
                        dt.Clear()
                        da.Fill(searchDt)
                        Me.DataGridView1.DataSource = searchDt
                        con.Close()

                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                    con.Close()
                End Try

                Reset()
            End If

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Reset()

    End Sub

    Private Sub btnNewRecord_Click(sender As Object, e As EventArgs) Handles btnNewRecord.Click
        Reset()

    End Sub

    Private Sub bnsearch2_Click(sender As Object, e As EventArgs) Handles bnsearch2.Click
        Try
            Dim searchDt As New DataTable
            If txtsearchname.Text = "" Then
                MsgBox("Please enter the COMPANY Name to be searched")
                txtsearchname.Focus()
            Else
                con.Close()
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "SELECT COMPANYNAME from Vacancies WHERE COMPANYNAME =  '" & txtsearchname.Text & "'"

                dr = cmd.ExecuteReader

                If dr.HasRows Then
                    con.Close()
                    con.Open()
                    With cmd
                        .Connection = con
                        .CommandText = "SELECT * From Vacancies WHERE COMPANYNAME  = '" & txtsearchname.Text & "'"
                    End With
                    da.SelectCommand = cmd
                    dt.Clear()
                    da.Fill(searchDt)
                    Me.DataGridView1.DataSource = searchDt
                    con.Close()

                Else
                    MsgBox("This Company Name does not exist")
                    txtsearchID.Focus()
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        Try
            txtcompanyname.Text = DataGridView1.Item(0, e.RowIndex).Value
            txtlocation.Text = DataGridView1.Item(1, e.RowIndex).Value
            txttelephone.Text = DataGridView1.Item(2, e.RowIndex).Value
            dtpvacancydate.Text = DataGridView1.Item(3, e.RowIndex).Value
            ComboBox1.Text = DataGridView1.Item(4, e.RowIndex).Value
            dtpdatedeployed.Text = DataGridView1.Item(5, e.RowIndex).Value




        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class