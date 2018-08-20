Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlTypes

Imports System.Security.Cryptography
Imports System.Text

Public Class APPLICANTFORM
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
        txtid.Clear()
        txtfirstname.Clear()
        txtlastname.Clear()
        cmbGender.Text = ""
        cmbMR.Text = ""
        txtnationality.Text = ""
        txtcontact.Clear()
        txtResidence.Clear()
        txtemail.Clear()
        txtemergencyname.Clear()
        txtemergencycontact.Clear()
        txtlastschoolattended.Clear()
        txteducationalqualification.Clear()
        txtotherqualification.Clear()
        Picture.Image = Nothing
        txtsearchID.Clear()
        txtsearchname.Clear()


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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtid.Text = "" Then
            MsgBox("Please enter a SerialNO")
            txtid.Focus()

        ElseIf txtfirstname.Text = "" Then
            MsgBox("Pleaase enter Surname")
            txtfirstname.Focus()

        ElseIf txtlastname.Text = "" Then
            MsgBox("Please enter First Name")
            txtlastname.Focus()

        ElseIf cmbGender.Text = "" Then
            MsgBox("Choose a Gneder")
            cmbGender.Focus()

        ElseIf cmbMR.Text = "" Then
            MsgBox("Choose a marital status")
            cmbMR.Focus()



        ElseIf Picture.Image Is Nothing Then
            MsgBox("Please add an Image")
            Browse.Focus()

        ElseIf Checkboxverified.Checked = False Then
            MsgBox("Terms must be accepted")
            Checkboxverified.Focus()





        Else



            Try


                Dim mstream As New System.IO.MemoryStream()
                Picture.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim arrImage() As Byte = mstream.GetBuffer()
                mstream.Close()

                con.Close()
                con.Open()


                Using cmd As New SqlCommand("INSERT INTO Applicant(ID, FIRSTNAME, LASTNAME, DOB, GENDER, M_STATUS, NATIONALITY, PHONE, EMAIL, R_ADDRESS, E_C_NAME,E_CONTACT,L_S_ATTENDED,EDU_QUALIFICATION,OTHER_QUALIFICATION,REG_DATE, Photo ) VALUES ('" & txtid.Text & "', '" & txtfirstname.Text & "', '" & txtlastname.Text & "','" & dtpDOB.Text & "', '" & cmbGender.Text & "', '" & cmbMR.Text & "', '" & txtnationality.Text & "', '" & txtcontact.Text & "', '" & txtemail.Text & "', '" & txtResidence.Text & "', '" & txtemergencyname.Text & "','" & txtemergencycontact.Text & "', '" & txtlastschoolattended.Text & "', '" & txteducationalqualification.Text & "','" & txtotherqualification.Text & "', '" & dtpRegistered.Text & "', @Photo )", con)

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
                cmd.CommandText = "SELECT * FROM Applicant"

                dr = cmd.ExecuteReader

                If dr.HasRows Then
                    con.Close()
                    con.Open()
                    With cmd
                        .Connection = con
                        .CommandText = "SELECT * From Applicant"
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

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If txtid.Text = "" Then
            MsgBox("Please enter a SerialNO")
            txtid.Focus()

        ElseIf txtfirstname.Text = "" Then
            MsgBox("Pleaase enter Surname")
            txtfirstname.Focus()

        ElseIf txtlastname.Text = "" Then
            MsgBox("Please enter First Name")
            txtlastname.Focus()

        ElseIf cmbGender.Text = "" Then
            MsgBox("Choose a Gneder")
            cmbGender.Focus()

        ElseIf cmbMR.Text = "" Then
            MsgBox("Choose a marital status")
            cmbMR.Focus()



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


                Using cmd As New SqlCommand("INSERT INTO Deleted_applicants(ID, FIRSTNAME, LASTNAME, DOB, GENDER, M_STATUS, NATIONALITY, PHONE, EMAIL, R_ADDRESS, E_C_NAME,E_CONTACT,L_S_ATTENDED,EDU_QUALIFICATION,OTHER_QUALIFICATION,REG_DATE, Photo ) VALUES ('" & txtid.Text & "', '" & txtfirstname.Text & "', '" & txtlastname.Text & "','" & dtpDOB.Text & "', '" & cmbGender.Text & "', '" & cmbMR.Text & "', '" & txtnationality.Text & "', '" & txtcontact.Text & "', '" & txtemail.Text & "', '" & txtResidence.Text & "', '" & txtemergencyname.Text & "','" & txtemergencycontact.Text & "', '" & txtlastschoolattended.Text & "', '" & txteducationalqualification.Text & "','" & txtotherqualification.Text & "', '" & dtpRegistered.Text & "', @Photo )", con)

                    cmd.Parameters.AddWithValue("@Photo", arrImage)
                    i = cmd.ExecuteNonQuery

                End Using
                MsgBox("Submitted Sucessfully")
                con.Close()
                con.Open()



            Catch ex As Exception
                MsgBox(ex.Message)

            End Try

        End If

        'delete starts here
        If txtsearchname.Text = "" Then


            If MessageBox.Show("Are you sure you want to Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Try
                    con.Close()

                    con.Open()

                    With cmd
                        .Connection = con
                        .CommandText = "DELETE FROM Applicant WHERE ID ='" & txtsearchID.Text & "'"
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
                    cmd.CommandText = "SELECT * FROM Applicant"

                    dr = cmd.ExecuteReader

                    If dr.HasRows Then
                        con.Close()
                        con.Open()
                        With cmd
                            .Connection = con
                            .CommandText = "SELECT * From Applicant"
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
                        .CommandText = "DELETE FROM Applicant WHERE FIRSTNAME ='" & txtsearchname.Text & "'"
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
                    cmd.CommandText = "SELECT * FROM Applicant"

                    dr = cmd.ExecuteReader

                    If dr.HasRows Then
                        con.Close()
                        con.Open()
                        With cmd
                            .Connection = con
                            .CommandText = "SELECT * From Applicant"
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        reset()
    End Sub

    Private Sub btnNewRecord_Click(sender As Object, e As EventArgs) Handles btnNewRecord.Click

        txtid.Text = "EA-" & GetUniqueKey(5)
        'Dim con As New SqlConnection
        ' Dim comm As New SqlCommand
        ' Dim adapter As New SqlDataAdapter
        ' Dim dataset As New DataSet
        ' Dim dr As SqlDataReader


        ' con.ConnectionString = "Data Source=(local);Initial Catalog=EACONSULT;Integrated Security=True"

        ' Try
        'reset()



        ' comm.CommandText = "select MAX(ID) from Applicant"
        ' con.Close()
        ' con.Open()
        ' comm.Connection = con
        ' adapter.SelectCommand = comm
        ' adapter.Fill(DataSet, "Applicant")
        '  Dim count As Integer = DataSet.Tables("Applicant").Rows.Count
        '  Dim dt As New DataTable

        '  If count > 0 Then
        'dr = comm.ExecuteReader()


        ' While dr.Read()



        'txtid.Text = dr.GetValue(0)
        'txtid.Text = txtid.Text + 1






        'End While
        ' End If

        ' Catch ex As Exception
        'MsgBox(ex.Message)
        '  con.Close()
        '
        'End Try


    End Sub

    Private Sub btnUpdate_record_Click(sender As Object, e As EventArgs) Handles btnUpdate_record.Click
        Try



            con.Close()
            con.Open()

            With cmd
                .Connection = con
                If txtid.Text = "" Then
                    MsgBox("Please input the ID number")
                Else


                    .CommandText = "UPDATE Applicant SET ID ='" & txtid.Text & "',FIRSTNAME = '" & txtfirstname.Text & "',LASTNAME= '" & txtlastname.Text & "',DOB = '" & dtpDOB.Text & "',GENDER ='" & cmbGender.Text & "', M_STATUS= '" & cmbMR.Text & "',NATIONALITY= '" & txtnationality.Text & "', PHONE= '" & txtcontact.Text & "', EMAIL = '" & txtemail.Text & "', R_ADDRESS= '" & txtResidence.Text & "', E_C_NAME= '" & txtemergencyname.Text & "', E_CONTACT= '" & txtemergencycontact.Text & "', L_S_ATTENDED= '" & txtlastschoolattended.Text & "', EDU_QUALIFICATION= '" & txteducationalqualification.Text & "', OTHER_QUALIFICATION= '" & txtotherqualification.Text & "', REG_DATE= '" & dtpRegistered.Text & "' WHERE ID ='" & txtid.Text & "'"
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
            cmd.CommandText = "SELECT * FROM Applicant"

            dr = cmd.ExecuteReader

            If dr.HasRows Then
                con.Close()
                con.Open()
                With cmd
                    .Connection = con
                    .CommandText = "SELECT * From Applicant"
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

    Private Sub APPLICANTFORM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EACONSULTDataSet.Applicant' table. You can move, or remove it, as needed.
        Me.ApplicantTableAdapter.Fill(Me.EACONSULTDataSet.Applicant)

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
                cmd.CommandText = "SELECT ID from Applicant WHERE ID = '" & txtsearchID.Text & "'"

                dr = cmd.ExecuteReader

                If dr.HasRows Then
                    con.Close()
                    con.Open()
                    With cmd
                        .Connection = con
                        .CommandText = "SELECT * From Applicant WHERE ID = '" & txtsearchID.Text & "'"
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        Try
            txtid.Text = DataGridView1.Item(0, e.RowIndex).Value
            txtfirstname.Text = DataGridView1.Item(1, e.RowIndex).Value
            txtlastname.Text = DataGridView1.Item(2, e.RowIndex).Value
            dtpDOB.Text = DataGridView1.Item(3, e.RowIndex).Value
            cmbGender.Text = DataGridView1.Item(4, e.RowIndex).Value
            cmbMR.Text = DataGridView1.Item(5, e.RowIndex).Value
            txtnationality.Text = DataGridView1.Item(6, e.RowIndex).Value
            txtcontact.Text = DataGridView1.Item(7, e.RowIndex).Value
            txtemail.Text = DataGridView1.Item(8, e.RowIndex).Value
            txtResidence.Text = DataGridView1.Item(9, e.RowIndex).Value
            txtemergencyname.Text = DataGridView1.Item(10, e.RowIndex).Value
            txtemergencycontact.Text = DataGridView1.Item(11, e.RowIndex).Value
            txtlastschoolattended.Text = DataGridView1.Item(12, e.RowIndex).Value
            txteducationalqualification.Text = DataGridView1.Item(13, e.RowIndex).Value
            txtotherqualification.Text = DataGridView1.Item(14, e.RowIndex).Value
            dtpRegistered.Text = DataGridView1.Item(15, e.RowIndex).Value

            'code to display picture from gridview to picture box
            Dim pic() As Byte = DataGridView1.Item(16, e.RowIndex).Value
            Dim ms As New MemoryStream(pic)
            Picture.Image = Image.FromStream(ms)


        Catch ex As Exception
            MsgBox(ex.Message)
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
                cmd.CommandText = "SELECT ID from Applicant WHERE FIRSTNAME =  '" & txtsearchname.Text & "'"

                dr = cmd.ExecuteReader

                If dr.HasRows Then
                    con.Close()
                    con.Open()
                    With cmd
                        .Connection = con
                        .CommandText = "SELECT * From Applicant WHERE FIRSTNAME  = '" & txtsearchname.Text & "'"
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        APPLICANT2.Show()

    End Sub
End Class