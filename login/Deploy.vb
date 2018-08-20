Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlTypes
Public Class Deploy
    Dim con As New SqlConnection("Data Source=(local);Initial Catalog=EACONSULT;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim dt As New DataTable
    Dim i As Integer
    Dim dr As SqlDataReader

    Sub reset()
        txtstaffid.Text = ""
        txtFirstName.Text = ""
        txtlastname.Text = ""
        txtcompanyname.Text = ""
        txtResidence.Text = ""
        txttypeofjob.Text = ""
        txtsalary.Text = ""
        Picture.Image = Nothing


    End Sub
    Private Sub Deploy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EACONSULTDataSet5.Deploy' table. You can move, or remove it, as needed.
        'Me.DeployTableAdapter.Fill(Me.EACONSULTDataSet5.Deploy)

    End Sub

    Private Sub txtstaffid_TextChanged(sender As Object, e As EventArgs) Handles txtstaffid.TextChanged

    End Sub

    Private Sub txtstaffid_Enter(sender As Object, e As EventArgs)
        
    End Sub

    Private Sub txtstaffid_Leave(sender As Object, e As EventArgs) Handles txtstaffid.Leave
        Dim con As New SqlConnection
        Dim comm As New SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim dataset As New DataSet
        Dim dr As SqlDataReader

        con.ConnectionString = "Data Source=(local);Initial Catalog=EACONSULT;Integrated Security=True"
        If txtstaffid.Text = "" Then
            MsgBox("Enter Staff ID ")



        Else
            comm.CommandText = "select * from Applicant where ID = '" & txtstaffid.Text & "' "
            con.Close()
            con.Open()

            comm.Connection = con
            adapter.SelectCommand = comm
            adapter.Fill(dataset, "Applicant")
            Dim count As Integer = dataset.Tables("Applicant").Rows.Count
            Dim dt As New DataTable

            If count > 0 Then
                dr = comm.ExecuteReader()

                While dr.Read()
                    MessageBox.Show("Record Found")

                    ' TextBox1.Text = dr.GetValue(0)
                    txtstaffid.Text = dr.GetValue(0)
                    txtFirstName.Text = dr.GetValue(1)
                    txtlastname.Text = dr.GetValue(2)


                    ' PictureBox1.Image = DataGridView1.Item(12, e.RowIndex).Value

                    Dim pic() As Byte = dataset.Tables("Applicant").Rows(count - 1)("photo")
                    Dim ms As New MemoryStream(pic)
                    Picture.Image = Image.FromStream(ms)



                End While
            Else
                MessageBox.Show("No record found,please enter the correct SerialNo.")

                con.Close()

            End If
        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtstaffid.Text = "" Then
            MsgBox("Please enter a Staff ID")
            txtstaffid.Focus()

        ElseIf txtFirstName.Text = "" Then
            MsgBox("Pleaase enter First Name")
            txtFirstName.Focus()

        ElseIf txtlastname.Text = "" Then
            MsgBox("Please enter Last Name")
            txtlastname.Focus()

        ElseIf Picture.Image Is Nothing Then
            MsgBox("Please add an Image")
            Browse.Focus()


        Else



            Try


                Dim mstream As New System.IO.MemoryStream()
                Picture.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim arrImage() As Byte = mstream.GetBuffer()
                mstream.Close()

                con.Close()
                con.Open()


                Using cmd As New SqlCommand("INSERT INTO Deploy(ID, FIRSTNAME, LASTNAME, DATEDEPLOYED, COMPANYNAME, LOCATION, TYPEOFJOB, SALARY, PHOTO ) VALUES ('" & txtstaffid.Text & "', '" & txtFirstName.Text & "', '" & txtlastname.Text & "','" & dtpdatedeployed.Text & "', '" & txtcompanyname.Text & "', '" & txtResidence.Text & "', '" & txttypeofjob.Text & "','" & txtsalary.Text & "', @Photo )", con)

                    cmd.Parameters.AddWithValue("@Photo", arrImage)
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
                cmd.CommandText = "SELECT * FROM Deploy"

                dr = cmd.ExecuteReader

                If dr.HasRows Then
                    con.Close()
                    con.Open()
                    With cmd
                        .Connection = con
                        .CommandText = "SELECT * From Deploy"
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
            reset()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        reset()

    End Sub

    Private Sub btnNewRecord_Click(sender As Object, e As EventArgs) Handles btnNewRecord.Click
        reset()

    End Sub

    Private Sub bnsearch1_Click(sender As Object, e As EventArgs) Handles bnsearch1.Click
        Try
            Dim searchDt As New DataTable
            If txtsearchID.Text = "" Then
                MsgBox("Please enter the Applicant ID to be searched")
                txtsearchID.Focus()
            Else
                con.Close()
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "SELECT ID from Deploy WHERE ID = '" & txtsearchID.Text & "'"

                dr = cmd.ExecuteReader

                If dr.HasRows Then
                    con.Close()
                    con.Open()
                    With cmd
                        .Connection = con
                        .CommandText = "SELECT * From Deploy WHERE ID = '" & txtsearchID.Text & "'"
                    End With
                    da.SelectCommand = cmd
                    dt.Clear()
                    da.Fill(searchDt)
                    Me.DataGridView1.DataSource = searchDt
                    con.Close()

                Else
                    MsgBox("This Applicant ID does not exist")
                    txtsearchID.Focus()
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub bnsearch2_Click(sender As Object, e As EventArgs) Handles bnsearch2.Click
        Try
            Dim searchDt As New DataTable
            If txtsearchname.Text = "" Then
                MsgBox("Please enter the Applicant First Name to be searched")
                txtsearchname.Focus()
            Else
                con.Close()
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "SELECT ID from Deploy WHERE FIRSTNAME =  '" & txtsearchname.Text & "'"

                dr = cmd.ExecuteReader

                If dr.HasRows Then
                    con.Close()
                    con.Open()
                    With cmd
                        .Connection = con
                        .CommandText = "SELECT * From Deploy WHERE FIRSTNAME  = '" & txtsearchname.Text & "'"
                    End With
                    da.SelectCommand = cmd
                    dt.Clear()
                    da.Fill(searchDt)
                    Me.DataGridView1.DataSource = searchDt
                    con.Close()

                Else
                    MsgBox("This Applicant First Name does not exist")
                    txtsearchID.Focus()
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtsearchname.Text = "" Then


            If MessageBox.Show("Are you sure you want to Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Try
                    con.Close()

                    con.Open()

                    With cmd
                        .Connection = con
                        .CommandText = "DELETE FROM Deploy WHERE ID ='" & txtsearchID.Text & "'"
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
                    cmd.CommandText = "SELECT * FROM Deploy"

                    dr = cmd.ExecuteReader

                    If dr.HasRows Then
                        con.Close()
                        con.Open()
                        With cmd
                            .Connection = con
                            .CommandText = "SELECT * FROM Deploy"
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
                reset()
            End If
        Else

            If MessageBox.Show("Are you sure you want to Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Try
                    con.Close()

                    con.Open()

                    With cmd
                        .Connection = con
                        .CommandText = "DELETE FROM Deploy WHERE FIRSTNAME ='" & txtsearchname.Text & "'"
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
                    cmd.CommandText = "SELECT * FROM Deploy"

                    dr = cmd.ExecuteReader

                    If dr.HasRows Then
                        con.Close()
                        con.Open()
                        With cmd
                            .Connection = con
                            .CommandText = "SELECT * FROM Deploy"
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

                reset()
            End If

        End If
    End Sub

    Private Sub btnUpdate_record_Click(sender As Object, e As EventArgs) Handles btnUpdate_record.Click
        Try



            con.Close()
            con.Open()

            With cmd
                .Connection = con
                If txtstaffid.Text = "" Then
                    MsgBox("Please input the Applicant ID number")
                Else


                    .CommandText = "UPDATE Deploy SET ID ='" & txtstaffid.Text & "',FIRSTNAME = '" & txtFirstName.Text & "',LASTNAME= '" & txtlastname.Text & "',DATEDEPLOYED = '" & dtpdatedeployed.Text & "',COMPANYNAME ='" & txtcompanyname.Text & "', LOCATION= '" & txtResidence.Text & "', TYPEOFJOB= '" & txttypeofjob.Text & "',SALARY= '" & txtsalary.Text & "' WHERE ID ='" & txtstaffid.Text & "'"
                    i = .ExecuteNonQuery
                End If
            End With

            If i > 0 Then
                MsgBox("Changes were saved successfully")
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
            cmd.CommandText = "SELECT * FROM Deploy"

            dr = cmd.ExecuteReader

            If dr.HasRows Then
                con.Close()
                con.Open()
                With cmd
                    .Connection = con
                    .CommandText = "SELECT * From Deploy"
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
        reset()
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        Try
            txtstaffid.Text = DataGridView1.Item(0, e.RowIndex).Value
            txtFirstName.Text = DataGridView1.Item(1, e.RowIndex).Value
            txtlastname.Text = DataGridView1.Item(2, e.RowIndex).Value
            dtpdatedeployed.Text = DataGridView1.Item(3, e.RowIndex).Value
            txtcompanyname.Text = DataGridView1.Item(4, e.RowIndex).Value
            txtResidence.Text = DataGridView1.Item(5, e.RowIndex).Value
            txttypeofjob.Text = DataGridView1.Item(6, e.RowIndex).Value
            txtsalary.Text = DataGridView1.Item(7, e.RowIndex).Value

            'code to display picture from gridview to picture box
            Dim pic() As Byte = DataGridView1.Item(8, e.RowIndex).Value
            Dim ms As New MemoryStream(pic)
            Picture.Image = Image.FromStream(ms)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class