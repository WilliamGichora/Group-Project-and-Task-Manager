<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateReport
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
        Me.ReportsContainerPanel1 = New System.Windows.Forms.Panel()
        Me.BudgetExcellButton2 = New System.Windows.Forms.Button()
        Me.ProjectTextReportButton1 = New System.Windows.Forms.Button()
        Me.ReportsContainerPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReportsContainerPanel1
        '
        Me.ReportsContainerPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReportsContainerPanel1.BackColor = System.Drawing.SystemColors.Info
        Me.ReportsContainerPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReportsContainerPanel1.Controls.Add(Me.BudgetExcellButton2)
        Me.ReportsContainerPanel1.Controls.Add(Me.ProjectTextReportButton1)
        Me.ReportsContainerPanel1.Location = New System.Drawing.Point(58, 37)
        Me.ReportsContainerPanel1.Name = "ReportsContainerPanel1"
        Me.ReportsContainerPanel1.Size = New System.Drawing.Size(316, 383)
        Me.ReportsContainerPanel1.TabIndex = 0
        '
        'BudgetExcellButton2
        '
        Me.BudgetExcellButton2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BudgetExcellButton2.BackColor = System.Drawing.SystemColors.MenuBar
        Me.BudgetExcellButton2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BudgetExcellButton2.Location = New System.Drawing.Point(26, 250)
        Me.BudgetExcellButton2.Name = "BudgetExcellButton2"
        Me.BudgetExcellButton2.Size = New System.Drawing.Size(253, 75)
        Me.BudgetExcellButton2.TabIndex = 1
        Me.BudgetExcellButton2.Text = "Create Excell Budget Structure"
        Me.BudgetExcellButton2.UseVisualStyleBackColor = False
        '
        'ProjectTextReportButton1
        '
        Me.ProjectTextReportButton1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProjectTextReportButton1.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ProjectTextReportButton1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProjectTextReportButton1.Location = New System.Drawing.Point(26, 35)
        Me.ProjectTextReportButton1.Name = "ProjectTextReportButton1"
        Me.ProjectTextReportButton1.Size = New System.Drawing.Size(253, 75)
        Me.ProjectTextReportButton1.TabIndex = 0
        Me.ProjectTextReportButton1.Text = "Create Text Report"
        Me.ProjectTextReportButton1.UseVisualStyleBackColor = False
        '
        'CreateReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 450)
        Me.Controls.Add(Me.ReportsContainerPanel1)
        Me.Name = "CreateReport"
        Me.Text = "CreateReport"
        Me.ReportsContainerPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportsContainerPanel1 As Windows.Forms.Panel
    Friend WithEvents ProjectTextReportButton1 As Windows.Forms.Button
    Friend WithEvents BudgetExcellButton2 As Windows.Forms.Button
End Class
