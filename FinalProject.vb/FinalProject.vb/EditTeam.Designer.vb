<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditTeam
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
        Me.lblPlayerName = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblPlayerHeight = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lblPlayerNumber = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.lblPlayerWeight = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.btnAddPlayer = New System.Windows.Forms.Button()
        Me.btnDeletePlayer = New System.Windows.Forms.Button()
        Me.dgvEditTeam = New System.Windows.Forms.DataGridView()
        CType(Me.dgvEditTeam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPlayerName
        '
        Me.lblPlayerName.AutoSize = True
        Me.lblPlayerName.Location = New System.Drawing.Point(53, 21)
        Me.lblPlayerName.Name = "lblPlayerName"
        Me.lblPlayerName.Size = New System.Drawing.Size(49, 17)
        Me.lblPlayerName.TabIndex = 0
        Me.lblPlayerName.Text = "Name:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(108, 21)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(170, 22)
        Me.TextBox1.TabIndex = 1
        '
        'lblPlayerHeight
        '
        Me.lblPlayerHeight.AutoSize = True
        Me.lblPlayerHeight.Location = New System.Drawing.Point(331, 21)
        Me.lblPlayerHeight.Name = "lblPlayerHeight"
        Me.lblPlayerHeight.Size = New System.Drawing.Size(53, 17)
        Me.lblPlayerHeight.TabIndex = 0
        Me.lblPlayerHeight.Text = "Height:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(390, 21)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(147, 22)
        Me.TextBox2.TabIndex = 1
        '
        'lblPlayerNumber
        '
        Me.lblPlayerNumber.AutoSize = True
        Me.lblPlayerNumber.Location = New System.Drawing.Point(40, 62)
        Me.lblPlayerNumber.Name = "lblPlayerNumber"
        Me.lblPlayerNumber.Size = New System.Drawing.Size(62, 17)
        Me.lblPlayerNumber.TabIndex = 0
        Me.lblPlayerNumber.Text = "Number:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(108, 59)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(170, 22)
        Me.TextBox3.TabIndex = 1
        '
        'lblPlayerWeight
        '
        Me.lblPlayerWeight.AutoSize = True
        Me.lblPlayerWeight.Location = New System.Drawing.Point(328, 59)
        Me.lblPlayerWeight.Name = "lblPlayerWeight"
        Me.lblPlayerWeight.Size = New System.Drawing.Size(56, 17)
        Me.lblPlayerWeight.TabIndex = 0
        Me.lblPlayerWeight.Text = "Weight:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(390, 59)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(147, 22)
        Me.TextBox4.TabIndex = 1
        '
        'btnAddPlayer
        '
        Me.btnAddPlayer.Location = New System.Drawing.Point(156, 113)
        Me.btnAddPlayer.Name = "btnAddPlayer"
        Me.btnAddPlayer.Size = New System.Drawing.Size(88, 30)
        Me.btnAddPlayer.TabIndex = 2
        Me.btnAddPlayer.Text = "Add"
        Me.btnAddPlayer.UseVisualStyleBackColor = True
        '
        'btnDeletePlayer
        '
        Me.btnDeletePlayer.Location = New System.Drawing.Point(390, 113)
        Me.btnDeletePlayer.Name = "btnDeletePlayer"
        Me.btnDeletePlayer.Size = New System.Drawing.Size(88, 30)
        Me.btnDeletePlayer.TabIndex = 2
        Me.btnDeletePlayer.Text = "Delete"
        Me.btnDeletePlayer.UseVisualStyleBackColor = True
        '
        'dgvEditTeam
        '
        Me.dgvEditTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEditTeam.Location = New System.Drawing.Point(12, 162)
        Me.dgvEditTeam.Name = "dgvEditTeam"
        Me.dgvEditTeam.RowTemplate.Height = 24
        Me.dgvEditTeam.Size = New System.Drawing.Size(613, 378)
        Me.dgvEditTeam.TabIndex = 3
        '
        'EditTeam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 552)
        Me.Controls.Add(Me.dgvEditTeam)
        Me.Controls.Add(Me.btnDeletePlayer)
        Me.Controls.Add(Me.btnAddPlayer)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.lblPlayerWeight)
        Me.Controls.Add(Me.lblPlayerHeight)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.lblPlayerNumber)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblPlayerName)
        Me.Name = "EditTeam"
        Me.Text = "EditTeam"
        CType(Me.dgvEditTeam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPlayerName As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblPlayerHeight As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lblPlayerNumber As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents lblPlayerWeight As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents btnAddPlayer As Button
    Friend WithEvents btnDeletePlayer As Button
    Friend WithEvents dgvEditTeam As DataGridView
End Class
