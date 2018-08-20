Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlTypes
Public Class Guarantor
    Dim con As New SqlConnection("Data Source=(local);Initial Catalog=EACONSULT;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim dt As New DataTable
    Dim i As Integer
    Dim dr As SqlDataReader

    Sub reset()
        txtapplicantid.Text = ""
        txtFirstName.Text = ""
        txtSurname.Text = ""
        txtreligion.Text = ""
        txtResidence.Text = ""
        txtcontact.Text = ""
        txtemail.Text = ""
        txtoccupation.Text = ""
        txtoccupationaddress.Text = ""
        txtofficetelephone.Text = ""
        txtidtype.Text = ""
        txtidnumber.Text = ""
        Picture.Image = Nothing
        txtsearchID.Text = ""
        txtsearchname.Text = ""
    End Sub
    Private Sub dtpDOB_ValueChanged(sender As Object, e As EventArgs) Handles dtpDOB.ValueChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtapplicantid.Text = "" Then
            MsgBox("Please enter a SerialNO")
            txtapplicantid.Focus()

        ElseIf txtFirstName.Text = "" Then
            MsgBox("Pleaase enter Surname")
            txtFirstName.Focus()

        ElseIf txtSurname.Text = "" Then
            MsgBox("Please enter First Name")
            txtSurname.Focus()

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


                Using cmd As New SqlCommand("INSERT INTO Guarantors(ID, FIRSTNAME, SURNAME, DOB, RELIGION, R_ADDRESS, TELEPHONE, EMAIL, OCCUPATION, O_ADDRESS, OFFICE_TEL,ID_TYPE,ID_NUMBER,REG_DATE, Photo ) VALUES ('" & txtapplicantid.Text & "', '" & txtFirstName.Text & "', '" & txtSurname.Text & "','" & dtpDOB.Text & "', '" & txtreligion.Text & "', '" & txtResidence.Text & "', '" & txtcontact.Text & "', '" & txtemail.Text & "', '" & txtoccupation.Text & "', '" & txtoccupationaddress.Text & "', '" & txtofficetelephone.Text & "','" & txtidtype.Text & "', '" & txtidnumber.Text & "', '" & dtpdateofregistration.Text & "', @Photo )", con)

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
                cmd.CommandText = "SELECT * FROM Guarantors"

                dr = cmd.ExecuteReader

                If dr.HasRows Then
                    con.Close()
                    con.Open()
                    With cmd
                        .Connection = con
                        .CommandText = "SELECT * From Guarantors"
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
        End If
        reset()
    End Sub

    Private Sub Guarantor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EACONSULTDataSet2.Guarantors' table. You can move, or remove it, as needed.
        Me.GuarantorsTableAdapter.Fill(Me.EACONSULTDataSet2.Guarantors)

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

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtsearchname.Text = "" Then


            If MessageBox.Show("Are you sure you want to Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Try
                    con.Close()

                    con.Open()

                    With cmd
                        .Connection = con
                        .CommandText = "DELETE FROM Guarantors WHERE ID ='" & txtsearchID.Text & "'"
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
                    cmd.CommandText = "SELECT * FROM Guarantors"

                    dr = cmd.ExecuteReader

                    If dr.HasRows Then
                        con.Close()
                        con.Open()
                        With cmd
                            .Connection = con
                            .CommandText = "SELECT * From Guarantors"
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
            End If
        Else

            If MessageBox.Show("Are you sure you want to Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Try
                    con.Close()

                    con.Open()

                    With cmd
                        .Connection = con
                        .CommandText = "DELETE FROM Guarantors WHERE FIRSTNAME ='" & txtsearchname.Text & "'"
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
                    cmd.CommandText = "SELECT * FROM Guarantors"

                    dr = cmd.ExecuteReader

                    If dr.HasRows Then
                        con.Close()
                        con.Open()
                        With cmd
                            .Connection = con
                            .CommandText = "SELECT * From Guarantors"
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

            End If
        End If
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
                cmd.CommandText = "SELECT ID from Guarantors WHERE ID = '" & txtsearchID.Text & "'"

                dr = cmd.ExecuteReader

                If dr.HasRows Then
                    con.Close()
                    con.Open()
                    With cmd
                        .Connection = con
                        .CommandText = "SELECT * From Guarantors WHERE ID = '" & txtsearchID.Text & "'"
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
                MsgBox("Please enter the Applicant's First Name to be searched")
                txtsearchname.Focus()
            Else
                con.Close()
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "SELECT ID from Guarantors WHERE FIRSTNAME =  '" & txtsearchname.Text & "'"

                dr = cmd.ExecuteReader

                If dr.HasRows Then
                    con.Close()
                    con.Open()
                    With cmd
                        .Connection = con
                        .CommandText = "SELECT * From Guarantors WHERE FIRSTNAME  = '" & txtsearchname.Text & "'"
                    End With
                    da.SelectCommand = cmd
                    dt.Clear()
                    da.Fill(searchDt)
                    Me.DataGridView1.DataSource = searchDt
                    con.Close()

                Else
                    MsgBox("This Applicant's First Name does not exist")
                    txtsearchID.Focus()
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        reset()
    End Sub

    Private Sub btnNewRecord_Click(sender As Object, e As EventArgs) Handles btnNewRecord.Click
        reset()
    End Sub

    Private Sub btnUpdate_record_Click(sender As Object, e As EventArgs) Handles btnUpdate_record.Click
        Try



            con.Close()
            con.Open()

            With cmd
                .Connection = con
                If txtapplicantid.Text = "" Then
                    MsgBox("Please input the ID number")
                Else


                    .CommandText = "UPDATE Guarantors SET ID ='" & txtapplicantid.Text & "',FIRSTNAME = '" & txtFirstName.Text & "',SURNAME= '" & txtSurname.Text & "',DOB = '" & dtpDOB.Text & "',RELIGION ='" & txtreligion.Text & "', R_ADDRESS= '" & txtResidence.Text & "',TELEPHONE= '" & txtcontact.Text & "', EMAIL= '" & txtemail.Text & "', OCCUPATION= '" & txtoccupation.Text & "', O_ADDRESS= '" & txtoccupationaddress.Text & "', OFFICE_TEL= '" & txtofficetelephone.Text & "', ID_TYPE= '" & txtidtype.Text & "', ID_NUMBER= '" & txtidnumber.Text & "', REG_DATE= '" & dtpdateofregistration.Text & "' WHERE ID ='" & txtapplicantid.Text & "'"
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
            cmd.CommandText = "SELECT * FROM Guarantors"

            dr = cmd.ExecuteReader

            If dr.HasRows Then
                con.Close()
                con.Open()
                With cmd
                    .Connection = con
                    .CommandText = "SELECT * From Guarantors"
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
            txtapplicantid.Text = DataGridView1.Item(0, e.RowIndex).Value
            txtFirstName.Text = DataGridView1.Item(1, e.RowIndex).Value
            txtSurname.Text = DataGridView1.Item(2, e.RowIndex).Value
            dtpDOB.Text = DataGridView1.Item(3, e.RowIndex).Value
            txtreligion.Text = DataGridView1.Item(4, e.RowIndex).Value
            txtResidence.Text = DataGridView1.Item(5, e.RowIndex).Value
            txtcontact.Text = DataGridView1.Item(6, e.RowIndex).Value
            txtemail.Text = DataGridView1.Item(7, e.RowIndex).Value
            txtoccupation.Text = DataGridView1.Item(8, e.RowIndex).Value
            txtoccupationaddress.Text = DataGridView1.Item(9, e.RowIndex).Value
            txtofficetelephone.Text = DataGridView1.Item(10, e.RowIndex).Value
            txtidtype.Text = DataGridView1.Item(11, e.RowIndex).Value
            txtidnumber.Text = DataGridView1.Item(12, e.RowIndex).Value
            dtpdateofregistration.Text = DataGridView1.Item(13, e.RowIndex).Value

            'code to display picture from gridview to picture box
            Dim pic() As Byte = DataGridView1.Item(14, e.RowIndex).Value
            Dim ms As New MemoryStream(pic)
            Picture.Image = Image.FromStream(ms)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class