Imports System.Data.SqlClient
Public Class AddUser
    Dim con As New SqlConnection("Data Source=(local);Initial Catalog=EACONSULT;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim dt As New DataTable
    Dim i As Integer
    Dim dr As SqlDataReader
    Private Sub AddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bnADD_Click(sender As Object, e As EventArgs) Handles bnADD.Click
        Try
            con.Close()

            con.Open()

            If txtPASSWORD.Text = "" Or txtUSERNAME.Text = "" Then
                MsgBox("All Fields required")
                txtUSERNAME.Focus()

            ElseIf txtPASSWORD.Text <> txtRETYPE.Text Then
                MsgBox("PASSWORD DO NOT MATCH")
                txtRETYPE.Focus()
                ' ElseIf txtPASSWORD.Text <> txtRETYPE.Text Then
                '  MsgBox("PASSWORD DO NOT MATCH")

            Else

                Using cmd As New SqlCommand("INSERT INTO Users (Username, Pass) VALUES ('" & txtUSERNAME.Text & "', '" & txtPASSWORD.Text & "')", con)

                    i = cmd.ExecuteNonQuery

                    MsgBox("NEW USER ADDED")

                End Using

                con.Close()



            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        txtUSERNAME.Text = ""
        txtPASSWORD.Text = ""
        txtRETYPE.Text = ""
    End Sub

    Private Sub bnCLEAR_Click(sender As Object, e As EventArgs) Handles bnCLEAR.Click
        txtUSERNAME.Text = ""
        txtPASSWORD.Text = ""
        txtRETYPE.Text = ""
    End Sub
End Class