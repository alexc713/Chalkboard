Public Class Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Terminate the application
        Me.Close()
    End Sub

    Private Sub btnFaculty_Click(sender As Object, e As EventArgs) Handles btnFaculty.Click
        ' Open the faculty login module
        FacultyLogin.Show()

        ' Close the current module
        Me.Hide()
    End Sub
End Class
