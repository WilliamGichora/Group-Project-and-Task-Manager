Imports System.Windows.Forms

Public Class Login
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim username As String = UsernameTextBox.Text
        Dim password As String = PasswordTextBox.Text


        If ProfileHandler.CheckLogin(username, password) Then
            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim Dashboard As New Form1()
            Dashboard.Show()
            Me.Close()
        Else
            MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub SetProfilelink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SetProfilelink.LinkClicked
        Dim setProfileForm As New SetProfileForm()
        setProfileForm.ShowDialog()
    End Sub
End Class
Module Program
    Sub Main()
        Application.Run(New Login())
    End Sub
End Module
