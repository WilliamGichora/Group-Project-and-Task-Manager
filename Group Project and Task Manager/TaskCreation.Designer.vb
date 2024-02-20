<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TaskCreation
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
        Me.TaskCreationPanel = New System.Windows.Forms.Panel()
        Me.ViewTasksPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CreateTasksButton1 = New System.Windows.Forms.Button()
        Me.TaskCreationPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TaskCreationPanel
        '
        Me.TaskCreationPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TaskCreationPanel.Controls.Add(Me.Label2)
        Me.TaskCreationPanel.Controls.Add(Me.ViewTasksPanel2)
        Me.TaskCreationPanel.Controls.Add(Me.Panel1)
        Me.TaskCreationPanel.Location = New System.Drawing.Point(55, 12)
        Me.TaskCreationPanel.Name = "TaskCreationPanel"
        Me.TaskCreationPanel.Size = New System.Drawing.Size(513, 426)
        Me.TaskCreationPanel.TabIndex = 0
        '
        'ViewTasksPanel2
        '
        Me.ViewTasksPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ViewTasksPanel2.Location = New System.Drawing.Point(3, 144)
        Me.ViewTasksPanel2.Name = "ViewTasksPanel2"
        Me.ViewTasksPanel2.Size = New System.Drawing.Size(507, 279)
        Me.ViewTasksPanel2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(177, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "View My Tasks"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.CreateTasksButton1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(510, 113)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(161, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Create My Tasks"
        '
        'CreateTasksButton1
        '
        Me.CreateTasksButton1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.CreateTasksButton1.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateTasksButton1.Location = New System.Drawing.Point(150, 49)
        Me.CreateTasksButton1.Name = "CreateTasksButton1"
        Me.CreateTasksButton1.Size = New System.Drawing.Size(153, 41)
        Me.CreateTasksButton1.TabIndex = 3
        Me.CreateTasksButton1.Text = "Create Daily Tasks"
        Me.CreateTasksButton1.UseVisualStyleBackColor = False
        '
        'TaskCreation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 450)
        Me.Controls.Add(Me.TaskCreationPanel)
        Me.Name = "TaskCreation"
        Me.Text = "TaskCreation"
        Me.TaskCreationPanel.ResumeLayout(False)
        Me.TaskCreationPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TaskCreationPanel As Windows.Forms.Panel
    Friend WithEvents ViewTasksPanel2 As Windows.Forms.FlowLayoutPanel
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents CreateTasksButton1 As Windows.Forms.Button
End Class
