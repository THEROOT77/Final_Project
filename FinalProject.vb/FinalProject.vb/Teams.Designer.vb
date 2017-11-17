<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Teams
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
        Me.cmboTeams = New System.Windows.Forms.ComboBox()
        Me.lblTeamSelect = New System.Windows.Forms.Label()
        Me.dgvTeams = New System.Windows.Forms.DataGridView()
        CType(Me.dgvTeams, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmboTeams
        '
        Me.cmboTeams.FormattingEnabled = True
        Me.cmboTeams.Items.AddRange(New Object() {"Fort Wayne", "Denver", "North Dakota state", "Omaha", "Oral Roberts", "South Dakota", "South Dakota State", "Western Illinois"})
        Me.cmboTeams.Location = New System.Drawing.Point(210, 50)
        Me.cmboTeams.Name = "cmboTeams"
        Me.cmboTeams.Size = New System.Drawing.Size(177, 24)
        Me.cmboTeams.TabIndex = 0
        '
        'lblTeamSelect
        '
        Me.lblTeamSelect.AutoSize = True
        Me.lblTeamSelect.Location = New System.Drawing.Point(92, 53)
        Me.lblTeamSelect.Name = "lblTeamSelect"
        Me.lblTeamSelect.Size = New System.Drawing.Size(112, 17)
        Me.lblTeamSelect.TabIndex = 1
        Me.lblTeamSelect.Text = "Choose a Team:"
        '
        'dgvTeams
        '
        Me.dgvTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTeams.Location = New System.Drawing.Point(12, 102)
        Me.dgvTeams.Name = "dgvTeams"
        Me.dgvTeams.RowTemplate.Height = 24
        Me.dgvTeams.Size = New System.Drawing.Size(606, 345)
        Me.dgvTeams.TabIndex = 2
        '
        'Teams
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 459)
        Me.Controls.Add(Me.dgvTeams)
        Me.Controls.Add(Me.lblTeamSelect)
        Me.Controls.Add(Me.cmboTeams)
        Me.Name = "Teams"
        Me.Text = "Teams"
        CType(Me.dgvTeams, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmboTeams As ComboBox
    Friend WithEvents lblTeamSelect As Label
    Friend WithEvents dgvTeams As DataGridView
End Class
