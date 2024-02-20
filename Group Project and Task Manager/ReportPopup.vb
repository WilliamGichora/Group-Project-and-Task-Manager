Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Windows.Forms

Public Class ReportPopup
    Private selectedProject As String
    Private reportNumber As Integer

    Public Sub New(reportNumber As Integer)
        InitializeComponent()
        Me.reportNumber = reportNumber
    End Sub

    Private Sub ReportPopupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each project In Form1.savedProjects
            ProjectComboBox1.Items.Add(project.ProjectName)
        Next
    End Sub

    Private Sub ExportToWordButton_Click(sender As Object, e As EventArgs) Handles ExportToWordButton.Click
        If ProjectComboBox1.SelectedIndex = -1 Then
            MessageBox.Show("Please select a project.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        selectedProject = ProjectComboBox1.SelectedItem.ToString()

        Dim introductionText = IntroductionRichTextBox.Text
        Dim completedTasksText = CompletedTasksRichTextBox.Text
        Dim progressText = ProjectProgressRichTextBox.Text
        Dim aobText = AOBRichTextBox.Text

        ' CreatING a Word document
        Dim wordApp As New Word.Application()
        Dim doc As Word.Document = wordApp.Documents.Add()

        ' AddING content to the Word document
        doc.Content.Text = $"Project Name: {selectedProject}{vbCrLf}{vbCrLf}" &
                           $"Introduction:{vbCrLf}{introductionText}{vbCrLf}{vbCrLf}" &
                           $"Completed Tasks:{vbCrLf}{completedTasksText}{vbCrLf}{vbCrLf}" &
                           $"Project Progress:{vbCrLf}{progressText}{vbCrLf}{vbCrLf}" &
                           $"AOB:{vbCrLf}{aobText}"

        Dim reportNumber As Integer = GetNextReportNumber(selectedProject)

        Dim reportsFolderPath As String = Path.Combine(Application.StartupPath, "Resources", "Reports")
        If Not Directory.Exists(reportsFolderPath) Then
            Directory.CreateDirectory(reportsFolderPath)
        End If

        Dim filePath As String = Path.Combine(reportsFolderPath, $"{selectedProject}_Report_{reportNumber}.docx")
        Me.Close()

        Try
            doc.SaveAs2(filePath)
            MessageBox.Show($"Report exported to: {filePath}", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show($"Error saving the report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            doc.Close()
            wordApp.Quit()
        End Try
        Me.Close()
    End Sub

    Private Function GetNextReportNumber(projectName As String) As Integer
        Dim directoryPath As String = Path.Combine(Application.StartupPath, "Resources", "Reports")
        Dim files = Directory.GetFiles(directoryPath, $"{projectName}_Report_*.docx")

        Return files.Length + 1
    End Function

End Class