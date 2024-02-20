Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports Newtonsoft.Json

Public Class Form1
    Dim projectTemplateClass As New ProjectTemplate()
    Private myprojectData As New ProjectClass()
    Public Shared savedProjects As New List(Of ProjectClass)()

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Home_pageButton.Click
        switchPanel(ProjectPanel)

    End Sub

    Sub switchPanel(panel As Panel)
        SwitchingPanel.Controls.Clear()
        SwitchingPanel.Controls.Add(panel)

        panel.Dock = DockStyle.Fill

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Create_ProjectButton.Click
        switchPanel(ProjectTemplate.ProjectPanel1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles CrateTasksButton2.Click
        switchPanel(TaskCreation.TaskCreationPanel)

    End Sub

    Private Sub ReportButton3_Click(sender As Object, e As EventArgs) Handles ReportButton3.Click
        switchPanel(CreateReport.ReportsContainerPanel1)

    End Sub
    Private Sub SetProfileButton4_Click(sender As Object, e As EventArgs) Handles SetProfileButton4.Click
        Dim setProfileForm As New SetProfileForm()
        setProfileForm.ShowDialog()
    End Sub

    Private Sub GoToLoginButton1_Click(sender As Object, e As EventArgs) Handles GoToLoginButton1.Click
        Dim myLoginPage As New Login()
        myLoginPage.Show()
        Me.Close()
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSavedProjects()
    End Sub

    Private Sub LoadSavedProjects()
        Projects_SummaryPanel.Controls.Clear()
        Dim directoryPath As String = Path.Combine(Application.StartupPath, "Resources", "Saved Project")

        If Directory.Exists(directoryPath) Then
            Dim projectDirectories = Directory.GetDirectories(directoryPath)

            For Each projectDirectory In projectDirectories
                Dim projectName As String = Path.GetFileName(projectDirectory)
                Dim projectJsonPath As String = Path.Combine(projectDirectory, "ProjectDetails.json")

                If File.Exists(projectJsonPath) Then
                    Dim projectsJson As String = File.ReadAllText(projectJsonPath)
                    Dim project = JsonConvert.DeserializeObject(Of ProjectClass)(projectsJson)

                    UpdateProjectSummary(project)
                    savedProjects.Add(project)
                End If
            Next
        End If
    End Sub

    Public Sub UpdateProjectSummary(project As ProjectClass)

        Dim summaryPanel As New Panel()
        With summaryPanel
            .BackColor = Color.LightGray
            .Size = New Size(300, 150)

            Dim nameLabel As New Label With {
            .Text = $"Project Name: {project.ProjectName}",
            .Location = New Point(10, 10),
            .AutoSize = True
        }

            Dim startDateLabel As New Label With {
            .Text = $"Start Date: {project.StartDate}",
            .Location = New Point(10, 40),
            .AutoSize = True
        }

            Dim endDateLabel As New Label With {
            .Text = $"End Date: {project.EndDate}",
            .Location = New Point(10, 70),
            .AutoSize = True
        }

            Dim teamMembersLabel As New Label With {
            .Text = $"Team Members: {project.TeamMembers}",
            .Location = New Point(10, 100),
            .AutoSize = True
        }

            Dim deleteButton As New Button With {
           .Text = "Delete",
           .Location = New Point(120, 120),
           .Size = New Size(60, 25)
       }
            AddHandler deleteButton.Click, Sub(sender As Object, e As EventArgs)
                                               ' Handle delete button click here
                                               'HandleDeleteButtonClick(project)
                                           End Sub


            .Controls.Add(nameLabel)
            .Controls.Add(startDateLabel)
            .Controls.Add(endDateLabel)
            .Controls.Add(teamMembersLabel)
            .Controls.Add(deleteButton)
        End With


        Projects_SummaryPanel.Controls.Add(summaryPanel)

    End Sub

End Class