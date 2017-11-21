<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FacultyControlPanel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FacultyControlPanel))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome back, "
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(181, 28)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(115, 25)
        Me.lblUsername.TabIndex = 1
        Me.lblUsername.Text = "Placeholder"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(28, 108)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(176, 67)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Modify Student Records"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FacultyControlPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 397)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FacultyControlPanel"
        Me.Text = "Chalkboard - Control Panel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents Button1 As Button
End Class
