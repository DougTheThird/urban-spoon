<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.tbFolderLocation = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.lbVersions = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbVersion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblProgress = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(473, 293)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(128, 23)
        Me.btnGenerate.TabIndex = 0
        Me.btnGenerate.Text = "Generate Script"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'tbFolderLocation
        '
        Me.tbFolderLocation.Location = New System.Drawing.Point(95, 30)
        Me.tbFolderLocation.Name = "tbFolderLocation"
        Me.tbFolderLocation.Size = New System.Drawing.Size(506, 20)
        Me.tbFolderLocation.TabIndex = 1
        Me.tbFolderLocation.Text = "Browse for latest files"
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(12, 28)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 2
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'lbVersions
        '
        Me.lbVersions.FormattingEnabled = True
        Me.lbVersions.Location = New System.Drawing.Point(12, 203)
        Me.lbVersions.Name = "lbVersions"
        Me.lbVersions.Size = New System.Drawing.Size(120, 108)
        Me.lbVersions.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 185)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Versions"
        '
        'tbVersion
        '
        Me.tbVersion.Location = New System.Drawing.Point(151, 203)
        Me.tbVersion.Name = "tbVersion"
        Me.tbVersion.Size = New System.Drawing.Size(100, 20)
        Me.tbVersion.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(148, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Add Version"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(151, 246)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(95, 82)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(506, 20)
        Me.TextBox1.TabIndex = 9
        Me.TextBox1.Text = "Paste the update location"
        '
        'lblProgress
        '
        Me.lblProgress.AutoSize = True
        Me.lblProgress.Location = New System.Drawing.Point(148, 359)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(0, 13)
        Me.lblProgress.TabIndex = 10
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 381)
        Me.Controls.Add(Me.lblProgress)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbVersion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbVersions)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.tbFolderLocation)
        Me.Controls.Add(Me.btnGenerate)
        Me.Name = "frmMain"
        Me.Text = "InstallForge Updatescript maker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGenerate As Button
    Friend WithEvents tbFolderLocation As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents lbVersions As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbVersion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblProgress As Label
End Class
