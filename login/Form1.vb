Imports System.Data.SqlClient
Public Class Form1
    Dim con As New SqlConnection("Data Source=(local);Initial Catalog=EACONSULT;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim dt As New DataTable
    Dim i As Integer
    Dim dr As SqlDataReader
    Dim rd As SqlDataReader
    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles txtusername.Click
        txtusername.Text = ""
    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles txtpassword.Click
        txtpassword.UseSystemPasswordChar = True
        txtpassword.Text = ""
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lbllogin.Click
        Try
            If admin.Checked = True Then
                con.Close()
                con.Open()
                With cmd
                    .Connection = con
                    .CommandText = "SELECT Username,Pass from Admin_t WHERE Username = '" & txtusername.Text & "' and Pass ='" & txtpassword.Text & "'"

                    rd = .ExecuteReader
                End With
                If rd.HasRows Then
                    con.Close()
                    con.Open()
                    MsgBox("Log In successful")

                    txtusername.Text = "USER"
                    txtpassword.Text = ""

                    Me.Hide()
                    AdminForm.Show()





                Else
                    MessageBox.Show("Unknown User!")

                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try

        Try
            If admin.Checked = False Then

                con.Close()
                con.Open()
                With cmd
                    .Connection = con
                    .CommandText = "SELECT Username,Pass from Users WHERE Username = '" & txtusername.Text & "' and Pass ='" & txtpassword.Text & "'"

                    rd = .ExecuteReader
                End With
                If rd.HasRows Then
                    con.Close()
                    con.Open()
                    MsgBox("Log In successful")

                    txtusername.Text = "USER"
                    txtpassword.Text = ""

                    Me.Hide()
                    HOME.Show()






                Else
                    MessageBox.Show("Unknown User!")

                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try


    End Sub

    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub txtpassword_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub txtusername_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Select()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        Application.Exit()

    End Sub
End Class
