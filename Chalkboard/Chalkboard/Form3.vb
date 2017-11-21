Public Class FacultyControlPanel
    'Faculty Main Control Panel
    Private Sub FacultyControlPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUsername.Text = My.Settings.facultyUsername
    End Sub

    'Display ALL student info here. Allow faculty to choose student by 
    ' inserting desired student from textbox or from property grid if you can 
    ' figure it out. This is hardest part.
    ' Student section will repeat all the saved application data
    ' into label fields so that they're incapable of being changed.
    ' This will satisfy all the requirements of the project.
End Class