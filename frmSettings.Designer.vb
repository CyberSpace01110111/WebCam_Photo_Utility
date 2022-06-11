<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.lblImageFolder = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.ckOpenImageFolder = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(19, 66)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(106, 35)
        Me.btnBrowse.TabIndex = 0
        Me.btnBrowse.Text = "Browse..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'lblImageFolder
        '
        Me.lblImageFolder.Location = New System.Drawing.Point(139, 67)
        Me.lblImageFolder.Name = "lblImageFolder"
        Me.lblImageFolder.Size = New System.Drawing.Size(596, 103)
        Me.lblImageFolder.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(156, 225)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(184, 46)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(435, 225)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(184, 46)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(19, 107)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(106, 35)
        Me.btnOpen.TabIndex = 0
        Me.btnOpen.Text = "Open Folder"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'ckOpenImageFolder
        '
        Me.ckOpenImageFolder.AutoSize = True
        Me.ckOpenImageFolder.Location = New System.Drawing.Point(159, 325)
        Me.ckOpenImageFolder.Name = "ckOpenImageFolder"
        Me.ckOpenImageFolder.Size = New System.Drawing.Size(232, 17)
        Me.ckOpenImageFolder.TabIndex = 3
        Me.ckOpenImageFolder.Text = "Open the IMages folder after taking a photo"
        Me.ckOpenImageFolder.UseVisualStyleBackColor = True
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ckOpenImageFolder)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblImageFolder)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.btnBrowse)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSettings"
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBrowse As Button
    Friend WithEvents lblImageFolder As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnOpen As Button
    Friend WithEvents ckOpenImageFolder As CheckBox
End Class
