Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlTypes
Public Class Staff
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
        txtposition.Text = ""
        txtcontact.Text = ""
        txtResidence.Text = ""
        txtsalary.Text = ""
        Picture.Image = Nothing
        txtsearchID.Text = ""
        txtsearchname.Text = ""





    End Sub
    Private Sub Browse_Click(sender As Object, e As EventArgs) Handles Browse.Click
        Try


            Dim picname As String
            Dim dlg As New OpenFileDialog
            dlg.Filter = Nothing
            picname = dlg.FileName
            dlg.ShowDialog()

            Picture.Image = Image.FromFile(dlg.FileName)
            'lblPicName.Text = picname
            'ofdBrowse.ShowDialog()
            Browse.Enabled = True

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub REGISTRATION_Click(sender As Object, e As EventArgs) Handles REGISTRATION.Click

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


                Using cmd As New SqlCommand("INSERT INTO Staff(STAFFID, FIRSTNAME, LASTNAME, POSITION, CONTACT, LOCATION, SALARY, Photo ) VALUES ('" & txtstaffid.Text & "', '" & txtFirstName.Text & "', '" & txtlastname.Text & "','" & txtposition.Text & "', '" & txtcontact.Text & "', '" & txtResidence.Text & "', '" & txtsalary.Text & "', @Photo )", con)

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
                cmd.CommandText = "SELECT * FROM Staff"

                dr = cmd.ExecuteReader

                If dr.HasRows Then
                    con.Close()
                    con.Open()
                    With cmd
                        .Connection = con
                        .CommandText = "SELECT * From Staff"
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

    Private Sub Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EACONSULTDataSet3.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.EACONSULTDataSet3.Staff)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnNewRecord_Click(sender As Object, e As EventArgs) Handles btnNewRecord.Click
        reset()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        reset()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtsearchname.Text = "" Then


            If MessageBox.Show("Are you sure you want to Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Try
                    con.Close()

                    con.Open()

                    With cmd
                        .Connection = con
                        .CommandText = "DELETE FROM Staff WHERE STAFFID ='" & txtsearchID.Text & "'"
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
                    cmd.CommandText = "SELECT * FROM Staff"

                    dr = cmd.ExecuteReader

                    If dr.HasRows Then
                        con.Close()
                        con.Open()
                        With cmd
                            .Connection = con
                            .CommandText = "SELECT * FROM Staff"
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
                        .CommandText = "DELETE FROM Staff WHERE FIRSTNAME ='" & txtsearchname.Text & "'"
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
                    cmd.CommandText = "SELECT * FROM Staff"

                    dr = cmd.ExecuteReader

                    If dr.HasRows Then
                        con.Close()
                        con.Open()
                        With cmd
                            .Connection = con
                            .CommandText = "SELECT * FROM Staff"
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

    Private Sub bnsearch1_Click(sender As Object, e As EventArgs) Handles bnsearch1.Click
        Try
            Dim searchDt As New DataTable
            If txtsearchID.Text = "" Then
                MsgBox("Please enter the Staff ID to be searched")
                txtsearchID.Focus()
            Else
                con.Close()
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "SELECT STAFFID from Staff WHERE STAFFID = '" & txtsearchID.Text & "'"

                dr = cmd.ExecuteReader

                If dr.HasRows Then
                    con.Close()
                    con.Open()
                    With cmd
                        .Connection = con
                        .CommandText = "SELECT * From Staff WHERE STAFFID = '" & txtsearchID.Text & "'"
                    End With
                    da.SelectCommand = cmd
                    dt.Clear()
                    da.Fill(searchDt)
                    Me.DataGridView1.DataSource = searchDt
                    con.Close()

                Else
                    MsgBox("This Staff ID does not exist")
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
                MsgBox("Please enter the Staff First Name to be searched")
                txtsearchname.Focus()
            Else
                con.Close()
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "SELECT ID from Staff WHERE FIRSTNAME =  '" & txtsearchname.Text & "'"

                dr = cmd.ExecuteReader

                If dr.HasRows Then
                    con.Close()
                    con.Open()
                    With cmd
                        .Connection = con
                        .CommandText = "SELECT * From Staff WHERE FIRSTNAME  = '" & txtsearchname.Text & "'"
                    End With
                    da.SelectCommand = cmd
                    dt.Clear()
                    da.Fill(searchDt)
                    Me.DataGridView1.DataSource = searchDt
                    con.Close()

                Else
                    MsgBox("This Staff First Name does not exist")
                    txtsearchID.Focus()
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub btnUpdate_record_Click(sender As Object, e As EventArgs) Handles btnUpdate_record.Click
        Try



            con.Close()
            con.Open()

            With cmd
                .Connection = con
                If txtstaffid.Text = "" Then
                    MsgBox("Please input the STAFF ID number")
                Else


                    .CommandText = "UPDATE Staff SET STAFFID ='" & txtstaffid.Text & "',FIRSTNAME = '" & txtFirstName.Text & "',LASTNAME= '" & txtlastname.Text & "',POSITION = '" & txtposition.Text & "',CONTACT ='" & txtcontact.Text & "', LOCATION= '" & txtResidence.Text & "',SALARY= '" & txtsalary.Text & "' WHERE STAFFID ='" & txtstaffid.Text & "'"
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
            cmd.CommandText = "SELECT * FROM Staff"

            dr = cmd.ExecuteReader

            If dr.HasRows Then
                con.Close()
                con.Open()
                With cmd
                    .Connection = con
                    .CommandText = "SELECT * From Staff"
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
            txtposition.Text = DataGridView1.Item(3, e.RowIndex).Value
            txtcontact.Text = DataGridView1.Item(4, e.RowIndex).Value
            txtResidence.Text = DataGridView1.Item(5, e.RowIndex).Value
            txtsalary.Text = DataGridView1.Item(6, e.RowIndex).Value

            'code to display picture from gridview to picture box
            Dim pic() As Byte = DataGridView1.Item(7, e.RowIndex).Value
            Dim ms As New MemoryStream(pic)
            Picture.Image = Image.FromStream(ms)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class