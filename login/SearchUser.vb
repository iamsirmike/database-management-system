Imports System.Data.SqlClient
Public Class SearchUser
    Dim con As New SqlConnection("Data Source=(local);Initial Catalog=EACONSULT;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim dt As New DataTable
    Dim i As Integer
    Dim dr As SqlDataReader
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try


            txtUSERNAME.Text = DataGridView1.Item(0, e.RowIndex).Value
            txtPASSWORD.Text = DataGridView1.Item(1, e.RowIndex).Value

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SearchUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSEARCH.Focus()

    End Sub

    Private Sub bnSearch_Click(sender As Object, e As EventArgs) Handles bnSearch.Click
        Try
            Dim searchDt As New DataTable
            If txtSEARCH.Text = "" Then
                MsgBox("Please enter the User Name to be searched")
                txtSEARCH.Focus()
            Else

                con.Open()
                cmd.Connection = con
                cmd.CommandText = "SELECT Username from Users WHERE Username = '" & txtSEARCH.Text & "'"

                dr = cmd.ExecuteReader

                If dr.HasRows Then
                    con.Close()
                    con.Open()
                    With cmd
                        .Connection = con
                        .CommandText = "SELECT * From Users WHERE Username = '" & txtSEARCH.Text & "'"
                    End With
                    da.SelectCommand = cmd
                    dt.Clear()
                    da.Fill(searchDt)
                    Me.DataGridView1.DataSource = searchDt
                    con.Close()

                Else
                    MsgBox("This User Name does not exist")
                    txtSEARCH.Focus()
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub bnDELETE_Click(sender As Object, e As EventArgs) Handles bnDELETE.Click
        Try
            con.Open()

            With cmd
                .Connection = con
                .CommandText = "DELETE FROM Users WHERE Username ='" & txtSEARCH.Text & "'"
                i = .ExecuteNonQuery
            End With

            If i > 0 Then
                MsgBox("DELETED")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()



        End Try
        txtUSERNAME.Text = ""
        txtPASSWORD.Text = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        bnADD.Enabled = True
        bnDELETE.Enabled = True

    End Sub

    Private Sub bnADD_Click(sender As Object, e As EventArgs) Handles bnADD.Click
        Try
            con.Close()

            con.Open()

            With cmd
                .Connection = con
                If txtSEARCH.Text = "" Then
                    MsgBox("Username NEEDED")
                Else


                    .CommandText = "UPDATE Users SET Pass ='" & txtPASSWORD.Text & "',Username = '" & txtUSERNAME.Text & "' WHERE username ='" & txtSEARCH.Text & "'"
                    i = .ExecuteNonQuery
                End If
            End With

            If i > 0 Then
                MsgBox("Changes were saved successfully")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
        DataGridView1.Rows.RemoveAt(0)
        txtUSERNAME.Text = ""
        txtPASSWORD.Text = ""
        txtRETYPE.Text = ""
        txtSEARCH.Text = ""

    End Sub
End Class