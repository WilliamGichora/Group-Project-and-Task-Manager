Imports System.IO
Imports System.Windows.Forms

Public Class ProfileHandler
    Private Shared usersFilePath As String = Path.Combine(Application.StartupPath, "Resources", "users.txt")

    Shared Sub EnsureUsersFileExists()
        If Not File.Exists(usersFilePath) Then
            File.Create(usersFilePath).Close()
        End If
    End Sub
    Public Shared Sub SetUserProfile(username As String, password As String)
        Try
            EnsureUsersFileExists()
            Using writer As StreamWriter = New StreamWriter(usersFilePath, True)
                writer.WriteLine($"{username},{password}{Environment.NewLine}")
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error saving user profile: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Public Shared Function CheckLogin(username As String, password As String) As Boolean
        Try
            Dim lines As String() = File.ReadAllLines(usersFilePath)
            For Each line As String In lines
                Dim parts As String() = line.Split(",")
                If parts.Length = 2 AndAlso parts(0) = username AndAlso parts(1) = password Then
                    Return True
                End If
            Next
        Catch ex As Exception
            MessageBox.Show($"Error checking login: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False
    End Function
End Class
