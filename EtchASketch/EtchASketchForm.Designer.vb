<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EtchASketchForm
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
        Me.components = New System.ComponentModel.Container()
        Me.DrawWaveformsButton = New System.Windows.Forms.Button()
        Me.SelectColorButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.EtchASketchMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrawWaveformsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EtchASketchToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.EtchASketchPictureBox = New System.Windows.Forms.PictureBox()
        Me.EtchASketchLabel = New System.Windows.Forms.Label()
        Me.EtchASketchColorDialog = New System.Windows.Forms.ColorDialog()
        Me.EtchASketchMenuStrip.SuspendLayout()
        CType(Me.EtchASketchPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DrawWaveformsButton
        '
        Me.DrawWaveformsButton.Location = New System.Drawing.Point(249, 702)
        Me.DrawWaveformsButton.Name = "DrawWaveformsButton"
        Me.DrawWaveformsButton.Size = New System.Drawing.Size(187, 48)
        Me.DrawWaveformsButton.TabIndex = 0
        Me.DrawWaveformsButton.Text = "&Draw Waveforms"
        Me.EtchASketchToolTip.SetToolTip(Me.DrawWaveformsButton, "Click to draw a Sin wave, Cos Wave, and Tan Wave.")
        Me.DrawWaveformsButton.UseVisualStyleBackColor = True
        '
        'SelectColorButton
        '
        Me.SelectColorButton.Location = New System.Drawing.Point(443, 702)
        Me.SelectColorButton.Name = "SelectColorButton"
        Me.SelectColorButton.Size = New System.Drawing.Size(187, 48)
        Me.SelectColorButton.TabIndex = 1
        Me.SelectColorButton.Text = "&Select Color"
        Me.EtchASketchToolTip.SetToolTip(Me.SelectColorButton, "Click to open a dialog to choose the color of your sketch.")
        Me.SelectColorButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(637, 702)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(187, 48)
        Me.ClearButton.TabIndex = 2
        Me.ClearButton.Text = "&Clear"
        Me.EtchASketchToolTip.SetToolTip(Me.ClearButton, "Click to clear the Etch-A-Sketch.")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(831, 702)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(187, 48)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "&Exit"
        Me.EtchASketchToolTip.SetToolTip(Me.ExitButton, "Click to exit the Etch-A-Sketch.")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'EtchASketchMenuStrip
        '
        Me.EtchASketchMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.EtchASketchMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.EtchASketchMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.EtchASketchMenuStrip.Name = "EtchASketchMenuStrip"
        Me.EtchASketchMenuStrip.Size = New System.Drawing.Size(1267, 28)
        Me.EtchASketchMenuStrip.TabIndex = 4
        Me.EtchASketchMenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DrawWaveformsToolStripMenuItem, Me.SelectColorToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(49, 24)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DrawWaveformsToolStripMenuItem
        '
        Me.DrawWaveformsToolStripMenuItem.Name = "DrawWaveformsToolStripMenuItem"
        Me.DrawWaveformsToolStripMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.DrawWaveformsToolStripMenuItem.Text = "Draw Waveforms"
        '
        'SelectColorToolStripMenuItem
        '
        Me.SelectColorToolStripMenuItem.Name = "SelectColorToolStripMenuItem"
        Me.SelectColorToolStripMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.SelectColorToolStripMenuItem.Text = "Select Color"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(133, 26)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'EtchASketchPictureBox
        '
        Me.EtchASketchPictureBox.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.EtchASketchPictureBox.Location = New System.Drawing.Point(12, 67)
        Me.EtchASketchPictureBox.Name = "EtchASketchPictureBox"
        Me.EtchASketchPictureBox.Size = New System.Drawing.Size(1243, 626)
        Me.EtchASketchPictureBox.TabIndex = 6
        Me.EtchASketchPictureBox.TabStop = False
        '
        'EtchASketchLabel
        '
        Me.EtchASketchLabel.AutoSize = True
        Me.EtchASketchLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.EtchASketchLabel.Location = New System.Drawing.Point(435, 32)
        Me.EtchASketchLabel.Name = "EtchASketchLabel"
        Me.EtchASketchLabel.Size = New System.Drawing.Size(384, 28)
        Me.EtchASketchLabel.TabIndex = 7
        Me.EtchASketchLabel.Text = "Click Inside The Etch-A-Sketch To Draw"
        '
        'EtchASketchForm
        '
        Me.AcceptButton = Me.DrawWaveformsButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ClearButton
        Me.ClientSize = New System.Drawing.Size(1267, 759)
        Me.Controls.Add(Me.EtchASketchLabel)
        Me.Controls.Add(Me.EtchASketchPictureBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.SelectColorButton)
        Me.Controls.Add(Me.DrawWaveformsButton)
        Me.Controls.Add(Me.EtchASketchMenuStrip)
        Me.MainMenuStrip = Me.EtchASketchMenuStrip
        Me.Name = "EtchASketchForm"
        Me.Text = "Etch-A-Sketch"
        Me.EtchASketchMenuStrip.ResumeLayout(False)
        Me.EtchASketchMenuStrip.PerformLayout()
        CType(Me.EtchASketchPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DrawWaveformsButton As Button
    Friend WithEvents SelectColorButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents EtchASketchMenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DrawWaveformsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EtchASketchToolTip As ToolTip
    Friend WithEvents EtchASketchPictureBox As PictureBox
    Friend WithEvents EtchASketchLabel As Label
    Friend WithEvents EtchASketchColorDialog As ColorDialog
End Class
