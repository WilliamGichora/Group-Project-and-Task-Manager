Imports System.Drawing
Imports System.Windows.Forms

Public Class SetProfileForm
    Inherits Form

    Private WithEvents SetProfileButton As Button
    Private WithEvents UsernameTextBox As TextBox
    Private WithEvents PasswordTextBox As TextBox

    Public Sub New()
        InitializeComponents()
    End Sub

    Private Sub InitializeComponents()
        Me.Text = "Set Profile"
        Me.Size = New Size(300, 150)

        Dim usernameLabel As New Label With {
            .Text = "Username:",
            .Location = New Point(10, 10),
            .AutoSize = True
        }

        UsernameTextBox = New TextBox With {
            .Location = New Point(120, 10),
            .Width = 150
        }

        Dim passwordLabel As New Label With {
            .Text = "Password:",
            .Location = New Point(10, 40),
            .AutoSize = True
        }

        PasswordTextBox = New TextBox With {
            .Location = New Point(120, 40),
            .Width = 150,
            .PasswordChar = "*"c
        }

        SetProfileButton = New Button With {
            .Text = "Set Profile",
            .Location = New Point(10, 80),
            .AutoSize = True
        }

        Me.Controls.Add(usernameLabel)
        Me.Controls.Add(UsernameTextBox)
        Me.Controls.Add(passwordLabel)
        Me.Controls.Add(PasswordTextBox)
        Me.Controls.Add(SetProfileButton)
    End Sub

    Private Sub SetProfileButton_Click(sender As Object, e As EventArgs) Handles SetProfileButton.Click
        Dim username As String = UsernameTextBox.Text
        Dim password As String = PasswordTextBox.Text

        If Not String.IsNullOrEmpty(username) AndAlso Not String.IsNullOrEmpty(password) Then
            ProfileHandler.SetUserProfile(username, password)
            MessageBox.Show("User profile set successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()

        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Name = "SetProfileForm"
        Me.ResumeLayout(False)

    End Sub

End Class
