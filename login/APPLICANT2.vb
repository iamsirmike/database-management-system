Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlTypes
Public Class APPLICANT2
    Dim con As New SqlConnection("Data Source=(local);Initial Catalog=EACONSULT;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim dt As New DataTable
    Dim i As Integer
    Dim dr As SqlDataReader

    Sub reset()
        txtapplicantid.Text = ""
        txtjob1.Text = ""
        txtjob2.Text = ""
        txtjob3.Text = ""
        cmbaccesstous.Text = ""
        cmbareyouacomputerliterate.Text = ""
        cmbyearsworked.Text = ""
        txtmanagersno.Text = ""
        txtlastplaceworked.Text = ""
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            con.Close()
            con.Open()


            Using cmd As New SqlCommand("INSERT INTO Applicant2(T_O_JOB1, T_O_JOB2, T_O_JOB13, L_P_WORKED, MANAGER_NO, YEARS_WORKED, C_LITERATE, ACCESS_T_US, APPLICANTID ) VALUES ('" & txtjob1.Text & "', '" & txtjob2.Text & "','" & txtjob3.Text & "', '" & txtlastplaceworked.Text & "', '" & txtmanagersno.Text & "', '" & cmbyearsworked.Text & "', '" & cmbareyouacomputerliterate.Text & "', '" & cmbaccesstous.Text & "', '" & txtapplicantid.Text & "')", con)

                i = cmd.ExecuteNonQuery

            End Using
            MsgBox("Submitted Sucessfully")
            con.Close()
            con.Open()



        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        reset()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        reset()
    End Sub
End Class