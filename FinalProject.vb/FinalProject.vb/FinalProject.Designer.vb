<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogInForm
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
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.chkAdmin = New System.Windows.Forms.CheckBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.lblPassWord = New System.Windows.Forms.Label()
        Me.txtPassWord = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Location = New System.Drawing.Point(35, 41)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(83, 17)
        Me.lblUserName.TabIndex = 0
        Me.lblUserName.Text = "User Name:"
        '
        'chkAdmin
        '
        Me.chkAdmin.AutoSize = True
        Me.chkAdmin.Location = New System.Drawing.Point(124, 152)
        Me.chkAdmin.Name = "chkAdmin"
        Me.chkAdmin.Size = New System.Drawing.Size(69, 21)
        Me.chkAdmin.TabIndex = 1
        Me.chkAdmin.Text = "Admin"
        Me.chkAdmin.UseVisualStyleBackColor = True
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(124, 41)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(127, 22)
        Me.txtUserName.TabIndex = 2
        '
        'lblPassWord
        '
        Me.lblPassWord.AutoSize = True
        Me.lblPassWord.Location = New System.Drawing.Point(45, 104)
        Me.lblPassWord.Name = "lblPassWord"
        Me.lblPassWord.Size = New System.Drawing.Size(73, 17)
        Me.lblPassWord.TabIndex = 0
        Me.lblPassWord.Text = "Password:"
        '
        'txtPassWord
        '
        Me.txtPassWord.Location = New System.Drawing.Point(124, 101)
        Me.txtPassWord.Name = "txtPassWord"
        Me.txtPassWord.Size = New System.Drawing.Size(127, 22)
        Me.txtPassWord.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(38, 197)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 39)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(176, 197)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 39)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'LogInForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(283, 259)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtPassWord)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.chkAdmin)
        Me.Controls.Add(Me.lblPassWord)
        Me.Controls.Add(Me.lblUserName)
        Me.Name = "LogInForm"
        Me.Text = "LOG IN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUserName As Label
    Friend WithEvents chkAdmin As CheckBox
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents lblPassWord As Label
    Friend WithEvents txtPassWord As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnExit As Button
End Class
