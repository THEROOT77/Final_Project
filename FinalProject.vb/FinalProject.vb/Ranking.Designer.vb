<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ranking
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
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.cmboFilter = New System.Windows.Forms.ComboBox()
        Me.dgvRanking = New System.Windows.Forms.DataGridView()
        CType(Me.dgvRanking, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFilter
        '
        Me.lblFilter.AutoSize = True
        Me.lblFilter.Location = New System.Drawing.Point(153, 36)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(43, 17)
        Me.lblFilter.TabIndex = 0
        Me.lblFilter.Text = "Filter:"
        '
        'cmboFilter
        '
        Me.cmboFilter.FormattingEnabled = True
        Me.cmboFilter.Items.AddRange(New Object() {"Players", "Teams"})
        Me.cmboFilter.Location = New System.Drawing.Point(198, 33)
        Me.cmboFilter.Name = "cmboFilter"
        Me.cmboFilter.Size = New System.Drawing.Size(121, 24)
        Me.cmboFilter.TabIndex = 1
        '
        'dgvRanking
        '
        Me.dgvRanking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRanking.Location = New System.Drawing.Point(12, 79)
        Me.dgvRanking.Name = "dgvRanking"
        Me.dgvRanking.RowTemplate.Height = 24
        Me.dgvRanking.Size = New System.Drawing.Size(498, 294)
        Me.dgvRanking.TabIndex = 2
        '
        'Ranking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 385)
        Me.Controls.Add(Me.dgvRanking)
        Me.Controls.Add(Me.cmboFilter)
        Me.Controls.Add(Me.lblFilter)
        Me.Name = "Ranking"
        Me.Text = "Ranking"
        CType(Me.dgvRanking, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFilter As Label
    Friend WithEvents cmboFilter As ComboBox
    Friend WithEvents dgvRanking As DataGridView
End Class
