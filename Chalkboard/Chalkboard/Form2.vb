Public Class FacultyLogin
    ' This is the module that allows faculty to login
    ' Registration button is set to invisible. Only necessary for initial setup.

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If (txtUsername.Text = My.Settings.facultyUsername And txtPassword.Text = My.Settings.facultyPassword) Then
            ' This is a placeholder to confirm login. Remove once other module is built.
            'MsgBox("Login successful!", MsgBoxStyle.Information)
            FacultyControlPanel.Show()
            Me.Close()
        Else
            MsgBox("Incorrect login information. Please try again.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    ' CHANGE THE VISIBILITY OF THIS BUTTON BEFORE SUBMITTING FOR GRADE!
    ' It's not necessary, but also not right.
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        My.Settings.facultyUsername = txtUsername.Text
        My.Settings.facultyPassword = txtPassword.Text
        My.Settings.Save()
        MsgBox("Registration is successful!", MsgBoxStyle.Information)
    End Sub
End Class