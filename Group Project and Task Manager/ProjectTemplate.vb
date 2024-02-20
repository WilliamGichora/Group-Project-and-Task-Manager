Imports System.Drawing
Imports System.IO
Imports System.Text
Imports Newtonsoft.Json
Imports System.Windows.Forms

Public Class ProjectTemplate
    Private directoryPath As String

    Public Sub Save_Button_Click(sender As Object, e As EventArgs) Handles Save_Button.Click
        Dim projectData As New ProjectClass With {
            .ProjectName = ProjectNameBox1.Text,
            .Description = descriptionBox.Text,
            .StartDate = startDatePicker.Value,
            .EndDate = endDatePicker.Value,
            .TeamMembers = teamMembersBox.Text,
            .Budget = Double.Parse(budgetBox.Text)
        }

        SaveProjectToFile(projectData)
    End Sub

    Private Sub SaveProjectToFile(project As ProjectClass)
        directoryPath = Path.Combine(Application.StartupPath, "Resources", "Saved Project")

        If Not Directory.Exists(directoryPath) Then
            Directory.CreateDirectory(directoryPath)
        End If

        Dim ProjectName As String = project.ProjectName
        ProjectName = String.Join("_", ProjectName.Split(Path.GetInvalidFileNameChars()))

        Dim projectDirectoryPath As String = Path.Combine(directoryPath, ProjectName)

        If Not Directory.Exists(projectDirectoryPath) Then
            Directory.CreateDirectory(projectDirectoryPath)
        End If

        ' Combining the project directory path with the image details file paths and a json file,so that it may be relative to any device.
        Dim imageFilePath As String = Path.Combine(projectDirectoryPath, "ProjectSnapshot.png")
        Dim detailsFilePath As String = Path.Combine(projectDirectoryPath, "ProjectDetails.txt")
        Dim detailsJsonFilePath As String = Path.Combine(projectDirectoryPath, "ProjectDetails.json")

        Dim bmp As New Bitmap(Me.Width, Me.Height)
        Me.DrawToBitmap(bmp, New Rectangle(0, 0, Me.Width, Me.Height))

        Using g As Graphics = Graphics.FromImage(bmp)
            Dim detailsFont As New Font("Arial", 12)
            Dim detailsBrush As New SolidBrush(Color.Black)

            Dim detailsText As String = $"Project Name:{project.ProjectName}" & vbCrLf & vbCrLf &
                               $"Description:{vbCrLf}{project.Description}" & vbCrLf & vbCrLf &
                               $"Start Date:{vbCrLf}{project.StartDate}" & vbCrLf & vbCrLf &
                               $"End Date:{vbCrLf}{project.EndDate}" & vbCrLf & vbCrLf &
                               $"Team Members:{vbCrLf}{project.TeamMembers}" & vbCrLf & vbCrLf & vbCrLf & vbCrLf &
                               $"Budget:{vbCrLf}{project.Budget}"

            Dim detailsPosition As New Point(10, 50)
            Dim lineHeight As Integer = CInt(detailsFont.GetHeight() + 5)

            For Each line In detailsText.Split(vbCrLf)
                g.DrawString(line, detailsFont, detailsBrush, detailsPosition)
                detailsPosition.Y += lineHeight
            Next
        End Using

        bmp.Save(imageFilePath, Imaging.ImageFormat.Png)


        Dim detailsContent As New StringBuilder()
        detailsContent.AppendLine($"Project Name: {vbCrLf} {project.ProjectName}")
        detailsContent.AppendLine($"Description: {project.Description}")
        detailsContent.AppendLine($"Start Date: {project.StartDate}")
        detailsContent.AppendLine($"End Date: {project.EndDate}")
        detailsContent.AppendLine($"Team Members:{vbCrLf} {project.TeamMembers}")
        detailsContent.AppendLine($"Budget: {project.Budget}")

        System.IO.File.WriteAllText(detailsFilePath, detailsContent.ToString())

        Dim projectsJson As String = JsonConvert.SerializeObject(project)
        System.IO.File.WriteAllText(detailsJsonFilePath, projectsJson)

        MessageBox.Show($"Project '{ProjectName}' saved with image and details to: {projectDirectoryPath}")

        Dim dashboardForm As Form1 = CType(Application.OpenForms("Dashboard"), Form1)
        If dashboardForm IsNot Nothing Then
            dashboardForm.UpdateProjectSummary(project)
        End If
    End Sub


End Class
