<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFunctions
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AssignGradeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SendGradeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnterMarkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComputeGradeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtMark = New System.Windows.Forms.TextBox()
        Me.TxtGrade = New System.Windows.Forms.TextBox()
        Me.TxtComment = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LstResult = New System.Windows.Forms.ListBox()
        Me.EnterMark2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CaseGradeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResultsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AssignGradeToolStripMenuItem, Me.SendGradeToolStripMenuItem, Me.ResultsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(647, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AssignGradeToolStripMenuItem
        '
        Me.AssignGradeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnterMarkToolStripMenuItem, Me.ComputeGradeToolStripMenuItem, Me.CommentToolStripMenuItem})
        Me.AssignGradeToolStripMenuItem.Name = "AssignGradeToolStripMenuItem"
        Me.AssignGradeToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.AssignGradeToolStripMenuItem.Text = "Assign Grade"
        '
        'SendGradeToolStripMenuItem
        '
        Me.SendGradeToolStripMenuItem.Name = "SendGradeToolStripMenuItem"
        Me.SendGradeToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.SendGradeToolStripMenuItem.Text = "Send Grade"
        '
        'EnterMarkToolStripMenuItem
        '
        Me.EnterMarkToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnterMark2ToolStripMenuItem})
        Me.EnterMarkToolStripMenuItem.Name = "EnterMarkToolStripMenuItem"
        Me.EnterMarkToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.EnterMarkToolStripMenuItem.Text = "Enter Mark"
        '
        'ComputeGradeToolStripMenuItem
        '
        Me.ComputeGradeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CaseGradeToolStripMenuItem})
        Me.ComputeGradeToolStripMenuItem.Name = "ComputeGradeToolStripMenuItem"
        Me.ComputeGradeToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.ComputeGradeToolStripMenuItem.Text = "Compute Grade"
        '
        'CommentToolStripMenuItem
        '
        Me.CommentToolStripMenuItem.Name = "CommentToolStripMenuItem"
        Me.CommentToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.CommentToolStripMenuItem.Text = "Comment"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LstResult)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.TxtComment)
        Me.Panel1.Controls.Add(Me.TxtGrade)
        Me.Panel1.Controls.Add(Me.TxtMark)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(31, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(578, 255)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Mark"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Grade"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Comment"
        '
        'TxtMark
        '
        Me.TxtMark.Location = New System.Drawing.Point(75, 16)
        Me.TxtMark.Name = "TxtMark"
        Me.TxtMark.Size = New System.Drawing.Size(200, 20)
        Me.TxtMark.TabIndex = 5
        '
        'TxtGrade
        '
        Me.TxtGrade.Location = New System.Drawing.Point(75, 46)
        Me.TxtGrade.Name = "TxtGrade"
        Me.TxtGrade.Size = New System.Drawing.Size(200, 20)
        Me.TxtGrade.TabIndex = 6
        '
        'TxtComment
        '
        Me.TxtComment.Location = New System.Drawing.Point(75, 80)
        Me.TxtComment.Name = "TxtComment"
        Me.TxtComment.Size = New System.Drawing.Size(200, 20)
        Me.TxtComment.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(19, 129)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Result"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LstResult
        '
        Me.LstResult.FormattingEnabled = True
        Me.LstResult.Location = New System.Drawing.Point(100, 115)
        Me.LstResult.Name = "LstResult"
        Me.LstResult.Size = New System.Drawing.Size(459, 121)
        Me.LstResult.TabIndex = 9
        '
        'EnterMark2ToolStripMenuItem
        '
        Me.EnterMark2ToolStripMenuItem.Name = "EnterMark2ToolStripMenuItem"
        Me.EnterMark2ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EnterMark2ToolStripMenuItem.Text = "Enter Mark 2"
        '
        'CaseGradeToolStripMenuItem
        '
        Me.CaseGradeToolStripMenuItem.Name = "CaseGradeToolStripMenuItem"
        Me.CaseGradeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CaseGradeToolStripMenuItem.Text = "Case Grade"
        '
        'ResultsToolStripMenuItem
        '
        Me.ResultsToolStripMenuItem.Name = "ResultsToolStripMenuItem"
        Me.ResultsToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.ResultsToolStripMenuItem.Text = "Results"
        '
        'FrmFunctions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 363)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmFunctions"
        Me.Text = "FrmFunctions"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AssignGradeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnterMarkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComputeGradeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SendGradeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CommentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LstResult As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TxtComment As System.Windows.Forms.TextBox
    Friend WithEvents TxtGrade As System.Windows.Forms.TextBox
    Friend WithEvents TxtMark As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents EnterMark2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CaseGradeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResultsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
