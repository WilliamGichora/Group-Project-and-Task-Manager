Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO
Imports System.Windows.Forms

Public Class CreateReport
    Private reportCount As Integer = 1

    Private Sub ProjectTextReportButton1_Click(sender As Object, e As EventArgs) Handles ProjectTextReportButton1.Click
        Dim reportPopupForm As New ReportPopup(reportCount)
        reportPopupForm.ShowDialog()

        reportCount += 1
    End Sub

    Private Sub BudgetExcellButton2_Click(sender As Object, e As EventArgs) Handles BudgetExcellButton2.Click
        Dim miniPanelForm As New MiniPanelForm()
        miniPanelForm.ShowDialog()

        Dim selectedProject As String = miniPanelForm.SelectedProjectName

        If String.IsNullOrEmpty(selectedProject) Then
            MessageBox.Show("Please select a project.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Find the project details based on the selected project name
        Dim projectDetails = Form1.savedProjects.Find(Function(proj) proj.ProjectName = selectedProject)

        If projectDetails IsNot Nothing Then
            ' Generate and save the Excel document in the "Reports" folder
            GenerateBudgetExcel(projectDetails, selectedProject)
        Else
            MessageBox.Show("Project details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub GenerateBudgetExcel(project As ProjectClass, projectName As String)
        ' Create Excel application
        Dim excelApp As New Excel.Application()
        Dim workbook As Excel.Workbook = excelApp.Workbooks.Add()
        Dim worksheet As Excel.Worksheet = workbook.Worksheets(1)

        ' Add project details to Excel worksheet
        worksheet.Cells(1, 1).Value = "Project Name"
        worksheet.Cells(1, 2).Value = project.ProjectName

        worksheet.Cells(2, 1).Value = "Budget Amount"
        worksheet.Cells(2, 2).Value = project.Budget

        ' Save the Excel file in the "Reports" folder with the project name and report count
        Dim reportsFolderPath As String = Path.Combine(Application.StartupPath, "Resources", "Reports")
        If Not Directory.Exists(reportsFolderPath) Then
            Directory.CreateDirectory(reportsFolderPath)
        End If

        Dim reportNumber As Integer = GetNextReportNumber(projectName, reportsFolderPath)

        Dim filePath As String = Path.Combine(reportsFolderPath, $"{projectName}_Report_{reportNumber}.xlsx")
        workbook.SaveAs(filePath)
        workbook.Close()
        excelApp.Quit()

        ' Release Excel objects
        ReleaseObject(worksheet)
        ReleaseObject(workbook)
        ReleaseObject(excelApp)

        Dim result As DialogResult = MessageBox.Show($"Budget Excel file saved to: {filePath}" & vbCrLf & "Do you want to open it now?", "Export Successful", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If result = DialogResult.Yes Then
            Try
                ' Open the Excel file using the default application
                Process.Start(filePath)
            Catch ex As Exception
                MessageBox.Show($"Error opening the Excel file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Function GetNextReportNumber(projectName As String, reportsFolderPath As String) As Integer
        Dim files = Directory.GetFiles(reportsFolderPath, $"{projectName}_Report_*.xlsx")

        Return files.Length + 1
    End Function

    ' Method to release Excel objects from memory
    Private Sub ReleaseObject(obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    ' ... (other methods)
End Class
