Imports System.Drawing
Imports System.Windows.Forms

Public Class TaskCreation
    Private Sub CreateTasksButton1_Click(sender As Object, e As EventArgs) Handles CreateTasksButton1.Click

        Dim taskEntryPopup As New TaskEntryPopup()
        If taskEntryPopup.ShowDialog() = DialogResult.OK Then
            Dim selectedDate As String = taskEntryPopup.GetSelectedDate()
            Dim tasks As List(Of String) = taskEntryPopup.GetEnteredTasks()

            Dim miniPanel As New MiniPanel(selectedDate, tasks)

            ViewTasksPanel2.Controls.Add(miniPanel)
        End If
    End Sub

End Class

Public Class TaskEntryPopup
    Inherits Form

    ' Variables to store the selected date and entered tasks
    Private selectedDate As String
    Private enteredTasks As List(Of String)

    Private DateLabel As New Label()
    Private TaskTextArea As New TextBox()
    Private OkButton As New Button()

    Public Sub New()
        InitializeComponents()
    End Sub

    Public Function GetSelectedDate() As String
        Return selectedDate
    End Function

    Public Function GetEnteredTasks() As List(Of String)
        Return enteredTasks
    End Function

    Private Sub InitializeComponents()
        Me.Text = "Task Entry Popup"
        Me.Size = New Size(300, 200)
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False

        DateLabel.Text = DateTime.Now.ToString("dddd dd MMM yyyy")
        DateLabel.AutoSize = True
        DateLabel.Location = New Point(10, 10)

        TaskTextArea.Multiline = True
        TaskTextArea.ScrollBars = ScrollBars.Vertical
        TaskTextArea.Size = New Size(250, 100)
        TaskTextArea.Location = New Point(10, 40)

        OkButton.Text = "OK"
        OkButton.Location = New Point(10, 150)
        AddHandler OkButton.Click, AddressOf OkButton_Click

        Me.Controls.Add(DateLabel)
        Me.Controls.Add(TaskTextArea)
        Me.Controls.Add(OkButton)
    End Sub

    Private Sub OkButton_Click(sender As Object, e As EventArgs)

        selectedDate = DateLabel.Text
        enteredTasks = New List(Of String)()

        enteredTasks.AddRange(TaskTextArea.Lines.Where(Function(task) Not String.IsNullOrWhiteSpace(task)))

        DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Function CreateTaskTextBox() As TextBox
        Dim taskTextBox As New TextBox()
        taskTextBox.Width = 200
        Return taskTextBox
    End Function
End Class

Public Class MiniPanel
    Inherits Panel

    Private DateLabel As New Label()
    Private TasksListBox As New ListBox()

    Public Sub New(dateInfo As String, tasks As List(Of String))
        InitializeComponents(dateInfo, tasks)
    End Sub

    Private Sub InitializeComponents(dateInfo As String, tasks As List(Of String))

        DateLabel.Text = dateInfo
        DateLabel.AutoSize = True
        DateLabel.Location = New Point(10, 10)

        TasksListBox.Location = New Point(10, 30)
        TasksListBox.Size = New Size(180, 60)
        TasksListBox.Items.AddRange(tasks.ToArray())

        Me.Controls.Add(DateLabel)
        Me.Controls.Add(TasksListBox)
    End Sub
End Class
