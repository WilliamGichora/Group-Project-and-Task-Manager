<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportPopup
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
        Me.ContainerPanel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ExportToWordButton = New System.Windows.Forms.Button()
        Me.ProjectComboBox1 = New System.Windows.Forms.ComboBox()
        Me.IntroductionRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CompletedTasksRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ProjectProgressRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AOBRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.ContainerPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContainerPanel1
        '
        Me.ContainerPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ContainerPanel1.BackColor = System.Drawing.SystemColors.Info
        Me.ContainerPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ContainerPanel1.Controls.Add(Me.AOBRichTextBox)
        Me.ContainerPanel1.Controls.Add(Me.Label5)
        Me.ContainerPanel1.Controls.Add(Me.ProjectProgressRichTextBox)
        Me.ContainerPanel1.Controls.Add(Me.Label4)
        Me.ContainerPanel1.Controls.Add(Me.Label3)
        Me.ContainerPanel1.Controls.Add(Me.CompletedTasksRichTextBox)
        Me.ContainerPanel1.Controls.Add(Me.Label2)
        Me.ContainerPanel1.Controls.Add(Me.IntroductionRichTextBox)
        Me.ContainerPanel1.Controls.Add(Me.ProjectComboBox1)
        Me.ContainerPanel1.Controls.Add(Me.ExportToWordButton)
        Me.ContainerPanel1.Controls.Add(Me.Label1)
        Me.ContainerPanel1.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContainerPanel1.Location = New System.Drawing.Point(3, 2)
        Me.ContainerPanel1.Name = "ContainerPanel1"
        Me.ContainerPanel1.Size = New System.Drawing.Size(661, 564)
        Me.ContainerPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Project Name"
        '
        'ExportToWordButton
        '
        Me.ExportToWordButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ExportToWordButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ExportToWordButton.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExportToWordButton.Location = New System.Drawing.Point(222, 523)
        Me.ExportToWordButton.Name = "ExportToWordButton"
        Me.ExportToWordButton.Size = New System.Drawing.Size(197, 36)
        Me.ExportToWordButton.TabIndex = 1
        Me.ExportToWordButton.Text = "Export To Word Doc"
        Me.ExportToWordButton.UseVisualStyleBackColor = False
        '
        'ProjectComboBox1
        '
        Me.ProjectComboBox1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProjectComboBox1.FormattingEnabled = True
        Me.ProjectComboBox1.Location = New System.Drawing.Point(16, 37)
        Me.ProjectComboBox1.Name = "ProjectComboBox1"
        Me.ProjectComboBox1.Size = New System.Drawing.Size(174, 27)
        Me.ProjectComboBox1.TabIndex = 2
        '
        'IntroductionRichTextBox
        '
        Me.IntroductionRichTextBox.Location = New System.Drawing.Point(16, 92)
        Me.IntroductionRichTextBox.Name = "IntroductionRichTextBox"
        Me.IntroductionRichTextBox.Size = New System.Drawing.Size(537, 80)
        Me.IntroductionRichTextBox.TabIndex = 3
        Me.IntroductionRichTextBox.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 22)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Introduction"
        '
        'CompletedTasksRichTextBox
        '
        Me.CompletedTasksRichTextBox.Location = New System.Drawing.Point(16, 200)
        Me.CompletedTasksRichTextBox.Name = "CompletedTasksRichTextBox"
        Me.CompletedTasksRichTextBox.Size = New System.Drawing.Size(537, 80)
        Me.CompletedTasksRichTextBox.TabIndex = 5
        Me.CompletedTasksRichTextBox.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 22)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Completed Tasks"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 283)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 22)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Project Progress"
        '
        'ProjectProgressRichTextBox
        '
        Me.ProjectProgressRichTextBox.Location = New System.Drawing.Point(16, 308)
        Me.ProjectProgressRichTextBox.Name = "ProjectProgressRichTextBox"
        Me.ProjectProgressRichTextBox.Size = New System.Drawing.Size(537, 88)
        Me.ProjectProgressRichTextBox.TabIndex = 8
        Me.ProjectProgressRichTextBox.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 399)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 22)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Any Other Details"
        '
        'AOBRichTextBox
        '
        Me.AOBRichTextBox.Location = New System.Drawing.Point(16, 424)
        Me.AOBRichTextBox.Name = "AOBRichTextBox"
        Me.AOBRichTextBox.Size = New System.Drawing.Size(537, 88)
        Me.AOBRichTextBox.TabIndex = 10
        Me.AOBRichTextBox.Text = ""
        '
        'ReportPopup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 566)
        Me.Controls.Add(Me.ContainerPanel1)
        Me.Name = "ReportPopup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReportPopup"
        Me.ContainerPanel1.ResumeLayout(False)
        Me.ContainerPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ContainerPanel1 As Windows.Forms.Panel
    Friend WithEvents IntroductionRichTextBox As Windows.Forms.RichTextBox
    Friend WithEvents ProjectComboBox1 As Windows.Forms.ComboBox
    Friend WithEvents ExportToWordButton As Windows.Forms.Button
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents ProjectProgressRichTextBox As Windows.Forms.RichTextBox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents CompletedTasksRichTextBox As Windows.Forms.RichTextBox
    Friend WithEvents AOBRichTextBox As Windows.Forms.RichTextBox
    Friend WithEvents Label5 As Windows.Forms.Label
End Class
