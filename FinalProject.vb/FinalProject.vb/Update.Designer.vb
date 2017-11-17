<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Update
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
        Me.lblHomeTeam = New System.Windows.Forms.Label()
        Me.lblHomeScore = New System.Windows.Forms.Label()
        Me.lblGameID = New System.Windows.Forms.Label()
        Me.lblAwayTeam = New System.Windows.Forms.Label()
        Me.lblAwayScore = New System.Windows.Forms.Label()
        Me.txtHomeText = New System.Windows.Forms.TextBox()
        Me.txtHomeScore = New System.Windows.Forms.TextBox()
        Me.txtAwayTeam = New System.Windows.Forms.TextBox()
        Me.txtAwayScore = New System.Windows.Forms.TextBox()
        Me.txtGameID = New System.Windows.Forms.TextBox()
        Me.dgvUpdate = New System.Windows.Forms.DataGridView()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lblHomeBestScorer = New System.Windows.Forms.Label()
        Me.lblAwayBestScorer = New System.Windows.Forms.Label()
        Me.txtHomeBestScorer = New System.Windows.Forms.TextBox()
        Me.txtAwayBestScorer = New System.Windows.Forms.TextBox()
        Me.lblHomeBestPoints = New System.Windows.Forms.Label()
        Me.txtHomeBestPoints = New System.Windows.Forms.TextBox()
        Me.lblAwayBestPoints = New System.Windows.Forms.Label()
        Me.txtAwayBestPoints = New System.Windows.Forms.TextBox()
        CType(Me.dgvUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHomeTeam
        '
        Me.lblHomeTeam.AutoSize = True
        Me.lblHomeTeam.Location = New System.Drawing.Point(160, 29)
        Me.lblHomeTeam.Name = "lblHomeTeam"
        Me.lblHomeTeam.Size = New System.Drawing.Size(89, 17)
        Me.lblHomeTeam.TabIndex = 0
        Me.lblHomeTeam.Text = "Home Team:"
        '
        'lblHomeScore
        '
        Me.lblHomeScore.AutoSize = True
        Me.lblHomeScore.Location = New System.Drawing.Point(160, 79)
        Me.lblHomeScore.Name = "lblHomeScore"
        Me.lblHomeScore.Size = New System.Drawing.Size(90, 17)
        Me.lblHomeScore.TabIndex = 0
        Me.lblHomeScore.Text = "Home Score:"
        '
        'lblGameID
        '
        Me.lblGameID.AutoSize = True
        Me.lblGameID.Location = New System.Drawing.Point(12, 57)
        Me.lblGameID.Name = "lblGameID"
        Me.lblGameID.Size = New System.Drawing.Size(67, 17)
        Me.lblGameID.TabIndex = 0
        Me.lblGameID.Text = "Game ID:"
        '
        'lblAwayTeam
        '
        Me.lblAwayTeam.AutoSize = True
        Me.lblAwayTeam.Location = New System.Drawing.Point(411, 29)
        Me.lblAwayTeam.Name = "lblAwayTeam"
        Me.lblAwayTeam.Size = New System.Drawing.Size(85, 17)
        Me.lblAwayTeam.TabIndex = 0
        Me.lblAwayTeam.Text = "Away Team:"
        '
        'lblAwayScore
        '
        Me.lblAwayScore.AutoSize = True
        Me.lblAwayScore.Location = New System.Drawing.Point(411, 84)
        Me.lblAwayScore.Name = "lblAwayScore"
        Me.lblAwayScore.Size = New System.Drawing.Size(86, 17)
        Me.lblAwayScore.TabIndex = 0
        Me.lblAwayScore.Text = "Away Score:"
        '
        'txtHomeText
        '
        Me.txtHomeText.Location = New System.Drawing.Point(247, 29)
        Me.txtHomeText.Name = "txtHomeText"
        Me.txtHomeText.Size = New System.Drawing.Size(136, 22)
        Me.txtHomeText.TabIndex = 1
        '
        'txtHomeScore
        '
        Me.txtHomeScore.Location = New System.Drawing.Point(247, 79)
        Me.txtHomeScore.Name = "txtHomeScore"
        Me.txtHomeScore.Size = New System.Drawing.Size(136, 22)
        Me.txtHomeScore.TabIndex = 1
        '
        'txtAwayTeam
        '
        Me.txtAwayTeam.Location = New System.Drawing.Point(497, 29)
        Me.txtAwayTeam.Name = "txtAwayTeam"
        Me.txtAwayTeam.Size = New System.Drawing.Size(136, 22)
        Me.txtAwayTeam.TabIndex = 1
        '
        'txtAwayScore
        '
        Me.txtAwayScore.Location = New System.Drawing.Point(497, 79)
        Me.txtAwayScore.Name = "txtAwayScore"
        Me.txtAwayScore.Size = New System.Drawing.Size(136, 22)
        Me.txtAwayScore.TabIndex = 1
        '
        'txtGameID
        '
        Me.txtGameID.Location = New System.Drawing.Point(85, 57)
        Me.txtGameID.Name = "txtGameID"
        Me.txtGameID.Size = New System.Drawing.Size(48, 22)
        Me.txtGameID.TabIndex = 1
        '
        'dgvUpdate
        '
        Me.dgvUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUpdate.Location = New System.Drawing.Point(12, 223)
        Me.dgvUpdate.Name = "dgvUpdate"
        Me.dgvUpdate.RowTemplate.Height = 24
        Me.dgvUpdate.Size = New System.Drawing.Size(618, 282)
        Me.dgvUpdate.TabIndex = 2
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(28, 171)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(84, 34)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'lblHomeBestScorer
        '
        Me.lblHomeBestScorer.AutoSize = True
        Me.lblHomeBestScorer.Location = New System.Drawing.Point(160, 124)
        Me.lblHomeBestScorer.Name = "lblHomeBestScorer"
        Me.lblHomeBestScorer.Size = New System.Drawing.Size(86, 17)
        Me.lblHomeBestScorer.TabIndex = 0
        Me.lblHomeBestScorer.Text = "Best Scorer:"
        '
        'lblAwayBestScorer
        '
        Me.lblAwayBestScorer.AutoSize = True
        Me.lblAwayBestScorer.Location = New System.Drawing.Point(411, 129)
        Me.lblAwayBestScorer.Name = "lblAwayBestScorer"
        Me.lblAwayBestScorer.Size = New System.Drawing.Size(86, 17)
        Me.lblAwayBestScorer.TabIndex = 0
        Me.lblAwayBestScorer.Text = "Best Scorer:"
        '
        'txtHomeBestScorer
        '
        Me.txtHomeBestScorer.Location = New System.Drawing.Point(247, 124)
        Me.txtHomeBestScorer.Name = "txtHomeBestScorer"
        Me.txtHomeBestScorer.Size = New System.Drawing.Size(136, 22)
        Me.txtHomeBestScorer.TabIndex = 1
        '
        'txtAwayBestScorer
        '
        Me.txtAwayBestScorer.Location = New System.Drawing.Point(497, 124)
        Me.txtAwayBestScorer.Name = "txtAwayBestScorer"
        Me.txtAwayBestScorer.Size = New System.Drawing.Size(136, 22)
        Me.txtAwayBestScorer.TabIndex = 1
        '
        'lblHomeBestPoints
        '
        Me.lblHomeBestPoints.AutoSize = True
        Me.lblHomeBestPoints.Location = New System.Drawing.Point(190, 171)
        Me.lblHomeBestPoints.Name = "lblHomeBestPoints"
        Me.lblHomeBestPoints.Size = New System.Drawing.Size(51, 17)
        Me.lblHomeBestPoints.TabIndex = 0
        Me.lblHomeBestPoints.Text = "Points:"
        '
        'txtHomeBestPoints
        '
        Me.txtHomeBestPoints.Location = New System.Drawing.Point(247, 171)
        Me.txtHomeBestPoints.Name = "txtHomeBestPoints"
        Me.txtHomeBestPoints.Size = New System.Drawing.Size(136, 22)
        Me.txtHomeBestPoints.TabIndex = 1
        '
        'lblAwayBestPoints
        '
        Me.lblAwayBestPoints.AutoSize = True
        Me.lblAwayBestPoints.Location = New System.Drawing.Point(437, 171)
        Me.lblAwayBestPoints.Name = "lblAwayBestPoints"
        Me.lblAwayBestPoints.Size = New System.Drawing.Size(51, 17)
        Me.lblAwayBestPoints.TabIndex = 0
        Me.lblAwayBestPoints.Text = "Points:"
        '
        'txtAwayBestPoints
        '
        Me.txtAwayBestPoints.Location = New System.Drawing.Point(494, 171)
        Me.txtAwayBestPoints.Name = "txtAwayBestPoints"
        Me.txtAwayBestPoints.Size = New System.Drawing.Size(136, 22)
        Me.txtAwayBestPoints.TabIndex = 1
        '
        'Update
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 517)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.dgvUpdate)
        Me.Controls.Add(Me.txtAwayBestScorer)
        Me.Controls.Add(Me.txtAwayScore)
        Me.Controls.Add(Me.txtGameID)
        Me.Controls.Add(Me.txtAwayBestPoints)
        Me.Controls.Add(Me.txtHomeBestPoints)
        Me.Controls.Add(Me.txtHomeBestScorer)
        Me.Controls.Add(Me.txtHomeScore)
        Me.Controls.Add(Me.txtAwayTeam)
        Me.Controls.Add(Me.lblAwayBestScorer)
        Me.Controls.Add(Me.txtHomeText)
        Me.Controls.Add(Me.lblAwayBestPoints)
        Me.Controls.Add(Me.lblAwayScore)
        Me.Controls.Add(Me.lblHomeBestPoints)
        Me.Controls.Add(Me.lblAwayTeam)
        Me.Controls.Add(Me.lblHomeBestScorer)
        Me.Controls.Add(Me.lblGameID)
        Me.Controls.Add(Me.lblHomeScore)
        Me.Controls.Add(Me.lblHomeTeam)
        Me.Name = "Update"
        Me.Text = "Update"
        CType(Me.dgvUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHomeTeam As Label
    Friend WithEvents lblHomeScore As Label
    Friend WithEvents lblGameID As Label
    Friend WithEvents lblAwayTeam As Label
    Friend WithEvents lblAwayScore As Label
    Friend WithEvents txtHomeText As TextBox
    Friend WithEvents txtHomeScore As TextBox
    Friend WithEvents txtAwayTeam As TextBox
    Friend WithEvents txtAwayScore As TextBox
    Friend WithEvents txtGameID As TextBox
    Friend WithEvents dgvUpdate As DataGridView
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lblHomeBestScorer As Label
    Friend WithEvents lblAwayBestScorer As Label
    Friend WithEvents txtHomeBestScorer As TextBox
    Friend WithEvents txtAwayBestScorer As TextBox
    Friend WithEvents lblHomeBestPoints As Label
    Friend WithEvents txtHomeBestPoints As TextBox
    Friend WithEvents lblAwayBestPoints As Label
    Friend WithEvents txtAwayBestPoints As TextBox
End Class
