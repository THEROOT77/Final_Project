<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GamesResultsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoundOf4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResultsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddResultsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblPhases = New System.Windows.Forms.Label()
        Me.cmboPhases = New System.Windows.Forms.ComboBox()
        Me.EditTeamsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RankingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GamesResultsToolStripMenuItem, Me.ResultsToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(673, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GamesResultsToolStripMenuItem
        '
        Me.GamesResultsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RoundOf4ToolStripMenuItem, Me.RankingToolStripMenuItem})
        Me.GamesResultsToolStripMenuItem.Name = "GamesResultsToolStripMenuItem"
        Me.GamesResultsToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.GamesResultsToolStripMenuItem.Text = "View"
        '
        'RoundOf4ToolStripMenuItem
        '
        Me.RoundOf4ToolStripMenuItem.Name = "RoundOf4ToolStripMenuItem"
        Me.RoundOf4ToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.RoundOf4ToolStripMenuItem.Text = "View Teams"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(45, 24)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'ResultsToolStripMenuItem
        '
        Me.ResultsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddResultsToolStripMenuItem, Me.EditTeamsToolStripMenuItem1})
        Me.ResultsToolStripMenuItem.Name = "ResultsToolStripMenuItem"
        Me.ResultsToolStripMenuItem.Size = New System.Drawing.Size(47, 24)
        Me.ResultsToolStripMenuItem.Text = "Edit"
        '
        'AddResultsToolStripMenuItem
        '
        Me.AddResultsToolStripMenuItem.Name = "AddResultsToolStripMenuItem"
        Me.AddResultsToolStripMenuItem.Size = New System.Drawing.Size(217, 26)
        Me.AddResultsToolStripMenuItem.Text = "Add/Update Results"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 124)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(634, 343)
        Me.DataGridView1.TabIndex = 1
        '
        'lblPhases
        '
        Me.lblPhases.AutoSize = True
        Me.lblPhases.Location = New System.Drawing.Point(30, 46)
        Me.lblPhases.Name = "lblPhases"
        Me.lblPhases.Size = New System.Drawing.Size(133, 17)
        Me.lblPhases.TabIndex = 3
        Me.lblPhases.Text = "Tournament Phase:"
        '
        'cmboPhases
        '
        Me.cmboPhases.FormattingEnabled = True
        Me.cmboPhases.Items.AddRange(New Object() {"First round", "Semi-Finals", "Finals"})
        Me.cmboPhases.Location = New System.Drawing.Point(169, 46)
        Me.cmboPhases.Name = "cmboPhases"
        Me.cmboPhases.Size = New System.Drawing.Size(166, 24)
        Me.cmboPhases.TabIndex = 4
        '
        'EditTeamsToolStripMenuItem1
        '
        Me.EditTeamsToolStripMenuItem1.Name = "EditTeamsToolStripMenuItem1"
        Me.EditTeamsToolStripMenuItem1.Size = New System.Drawing.Size(217, 26)
        Me.EditTeamsToolStripMenuItem1.Text = "Edit teams"
        '
        'RankingToolStripMenuItem
        '
        Me.RankingToolStripMenuItem.Name = "RankingToolStripMenuItem"
        Me.RankingToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.RankingToolStripMenuItem.Text = "Ranking"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 479)
        Me.Controls.Add(Me.cmboPhases)
        Me.Controls.Add(Me.lblPhases)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GamesResultsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RoundOf4ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResultsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddResultsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblPhases As Label
    Friend WithEvents cmboPhases As ComboBox
    Friend WithEvents RankingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditTeamsToolStripMenuItem1 As ToolStripMenuItem
End Class
