
Imports System.Drawing
Imports System.Windows.Forms



Public Class MiniPanelForm
    Inherits Form

    Private excelSelectedProj As String
    Public Property SelectedProjectName As String

    Public Sub New()
        InitializeComponents()
    End Sub

    Private Sub InitializeComponents()
        Me.Text = "Mini Panel Example"
        Me.Size = New Size(300, 150)

        Dim projectNameLabel As New Label()
        With projectNameLabel
            .Text = "Project Name:"
            .Location = New Point(10, 10)
            .AutoSize = True
        End With

        Dim projectComboBox As New ComboBox()
        With projectComboBox
            .Location = New Point(10, 30)
            .Width = 200
            For Each project In Form1.savedProjects
                projectComboBox.Items.Add(project.ProjectName)
            Next
        End With

        Dim okButton As New Button()
        With okButton
            .Text = "OK"
            .Location = New Point(10, 70)
            .AutoSize = True
            AddHandler .Click, AddressOf OkButton_Click
        End With

        Me.Controls.Add(projectNameLabel)
        Me.Controls.Add(projectComboBox)
        Me.Controls.Add(okButton)
    End Sub

    Private Sub OkButton_Click(sender As Object, e As EventArgs)
        SelectedProjectName = DirectCast(Me.Controls(1), ComboBox).SelectedItem.ToString()

        Me.Close()
    End Sub
End Class
