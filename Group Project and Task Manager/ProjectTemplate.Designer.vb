<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProjectTemplate
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
        Me.ProjectPanel1 = New System.Windows.Forms.Panel()
        Me.Save_Button = New System.Windows.Forms.Button()
        Me.budgetBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.teamMembersBox = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.endDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DescriptionLabel2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProjectNameBox1 = New System.Windows.Forms.TextBox()
        Me.startDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.descriptionBox = New System.Windows.Forms.RichTextBox()
        Me.NameLabel1 = New System.Windows.Forms.Label()
        Me.ProjectPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProjectPanel1
        '
        Me.ProjectPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProjectPanel1.BackColor = System.Drawing.SystemColors.Info
        Me.ProjectPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProjectPanel1.Controls.Add(Me.Save_Button)
        Me.ProjectPanel1.Controls.Add(Me.budgetBox)
        Me.ProjectPanel1.Controls.Add(Me.Label4)
        Me.ProjectPanel1.Controls.Add(Me.teamMembersBox)
        Me.ProjectPanel1.Controls.Add(Me.Label3)
        Me.ProjectPanel1.Controls.Add(Me.endDatePicker)
        Me.ProjectPanel1.Controls.Add(Me.Label2)
        Me.ProjectPanel1.Controls.Add(Me.DescriptionLabel2)
        Me.ProjectPanel1.Controls.Add(Me.Label1)
        Me.ProjectPanel1.Controls.Add(Me.ProjectNameBox1)
        Me.ProjectPanel1.Controls.Add(Me.startDatePicker)
        Me.ProjectPanel1.Controls.Add(Me.descriptionBox)
        Me.ProjectPanel1.Controls.Add(Me.NameLabel1)
        Me.ProjectPanel1.Location = New System.Drawing.Point(3, 5)
        Me.ProjectPanel1.Name = "ProjectPanel1"
        Me.ProjectPanel1.Size = New System.Drawing.Size(666, 527)
        Me.ProjectPanel1.TabIndex = 0
        '
        'Save_Button
        '
        Me.Save_Button.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Save_Button.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Save_Button.ForeColor = System.Drawing.Color.LawnGreen
        Me.Save_Button.Location = New System.Drawing.Point(277, 463)
        Me.Save_Button.Name = "Save_Button"
        Me.Save_Button.Size = New System.Drawing.Size(95, 35)
        Me.Save_Button.TabIndex = 12
        Me.Save_Button.Text = "Save"
        Me.Save_Button.UseVisualStyleBackColor = False
        '
        'budgetBox
        '
        Me.budgetBox.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.budgetBox.Location = New System.Drawing.Point(13, 417)
        Me.budgetBox.Name = "budgetBox"
        Me.budgetBox.Size = New System.Drawing.Size(127, 27)
        Me.budgetBox.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 392)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 22)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Budget"
        '
        'teamMembersBox
        '
        Me.teamMembersBox.Location = New System.Drawing.Point(8, 299)
        Me.teamMembersBox.Name = "teamMembersBox"
        Me.teamMembersBox.Size = New System.Drawing.Size(462, 90)
        Me.teamMembersBox.TabIndex = 9
        Me.teamMembersBox.Text = ""
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 274)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 22)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Team Members"
        '
        'endDatePicker
        '
        Me.endDatePicker.CalendarFont = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.endDatePicker.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.endDatePicker.Location = New System.Drawing.Point(288, 238)
        Me.endDatePicker.Name = "endDatePicker"
        Me.endDatePicker.Size = New System.Drawing.Size(200, 24)
        Me.endDatePicker.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(303, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 22)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Project End Date"
        '
        'DescriptionLabel2
        '
        Me.DescriptionLabel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DescriptionLabel2.AutoSize = True
        Me.DescriptionLabel2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionLabel2.Location = New System.Drawing.Point(9, 69)
        Me.DescriptionLabel2.Name = "DescriptionLabel2"
        Me.DescriptionLabel2.Size = New System.Drawing.Size(167, 22)
        Me.DescriptionLabel2.TabIndex = 5
        Me.DescriptionLabel2.Text = "Project Description"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 203)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 22)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Project Start Date"
        '
        'ProjectNameBox1
        '
        Me.ProjectNameBox1.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProjectNameBox1.Location = New System.Drawing.Point(9, 39)
        Me.ProjectNameBox1.Name = "ProjectNameBox1"
        Me.ProjectNameBox1.Size = New System.Drawing.Size(355, 27)
        Me.ProjectNameBox1.TabIndex = 3
        '
        'startDatePicker
        '
        Me.startDatePicker.CalendarFont = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startDatePicker.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startDatePicker.Location = New System.Drawing.Point(3, 235)
        Me.startDatePicker.Name = "startDatePicker"
        Me.startDatePicker.Size = New System.Drawing.Size(200, 27)
        Me.startDatePicker.TabIndex = 2
        '
        'descriptionBox
        '
        Me.descriptionBox.Location = New System.Drawing.Point(9, 94)
        Me.descriptionBox.Name = "descriptionBox"
        Me.descriptionBox.Size = New System.Drawing.Size(461, 90)
        Me.descriptionBox.TabIndex = 1
        Me.descriptionBox.Text = ""
        '
        'NameLabel1
        '
        Me.NameLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NameLabel1.AutoSize = True
        Me.NameLabel1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel1.Location = New System.Drawing.Point(9, 4)
        Me.NameLabel1.Name = "NameLabel1"
        Me.NameLabel1.Size = New System.Drawing.Size(121, 22)
        Me.NameLabel1.TabIndex = 0
        Me.NameLabel1.Text = "Project Name"
        '
        'ProjectTemplate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 538)
        Me.Controls.Add(Me.ProjectPanel1)
        Me.Name = "ProjectTemplate"
        Me.Text = "ProjectTemplate"
        Me.ProjectPanel1.ResumeLayout(False)
        Me.ProjectPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ProjectPanel1 As Windows.Forms.Panel
    Friend WithEvents ProjectNameBox1 As Windows.Forms.TextBox
    Friend WithEvents startDatePicker As Windows.Forms.DateTimePicker
    Friend WithEvents descriptionBox As Windows.Forms.RichTextBox
    Friend WithEvents NameLabel1 As Windows.Forms.Label
    Friend WithEvents DescriptionLabel2 As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents endDatePicker As Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Save_Button As Windows.Forms.Button
    Friend WithEvents budgetBox As Windows.Forms.TextBox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents teamMembersBox As Windows.Forms.RichTextBox
End Class
