<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.tboxInput = New System.Windows.Forms.TextBox()
        Me.tboxOutput = New System.Windows.Forms.TextBox()
        Me.butTranslate = New System.Windows.Forms.Button()
        Me.butProfiles = New System.Windows.Forms.Button()
        Me.butCustom = New System.Windows.Forms.Button()
        Me.labAuthor = New System.Windows.Forms.Label()
        Me.butCredits = New System.Windows.Forms.Button()
        Me.butExit = New System.Windows.Forms.Button()
        Me.butChangelog = New System.Windows.Forms.Button()
        Me.butContact = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tboxInput
        '
        Me.tboxInput.Location = New System.Drawing.Point(12, 12)
        Me.tboxInput.Multiline = True
        Me.tboxInput.Name = "tboxInput"
        Me.tboxInput.Size = New System.Drawing.Size(443, 70)
        Me.tboxInput.TabIndex = 0
        '
        'tboxOutput
        '
        Me.tboxOutput.Location = New System.Drawing.Point(12, 165)
        Me.tboxOutput.Multiline = True
        Me.tboxOutput.Name = "tboxOutput"
        Me.tboxOutput.Size = New System.Drawing.Size(443, 70)
        Me.tboxOutput.TabIndex = 1
        '
        'butTranslate
        '
        Me.butTranslate.Location = New System.Drawing.Point(12, 89)
        Me.butTranslate.Name = "butTranslate"
        Me.butTranslate.Size = New System.Drawing.Size(443, 37)
        Me.butTranslate.TabIndex = 2
        Me.butTranslate.Text = "Translate"
        Me.butTranslate.UseVisualStyleBackColor = True
        '
        'butProfiles
        '
        Me.butProfiles.Location = New System.Drawing.Point(12, 132)
        Me.butProfiles.Name = "butProfiles"
        Me.butProfiles.Size = New System.Drawing.Size(218, 27)
        Me.butProfiles.TabIndex = 3
        Me.butProfiles.Text = "Profiles"
        Me.butProfiles.UseVisualStyleBackColor = True
        '
        'butCustom
        '
        Me.butCustom.Location = New System.Drawing.Point(236, 132)
        Me.butCustom.Name = "butCustom"
        Me.butCustom.Size = New System.Drawing.Size(219, 27)
        Me.butCustom.TabIndex = 4
        Me.butCustom.Text = "Create Custom Profile"
        Me.butCustom.UseVisualStyleBackColor = True
        '
        'labAuthor
        '
        Me.labAuthor.AutoSize = True
        Me.labAuthor.Location = New System.Drawing.Point(13, 245)
        Me.labAuthor.Name = "labAuthor"
        Me.labAuthor.Size = New System.Drawing.Size(55, 13)
        Me.labAuthor.TabIndex = 5
        Me.labAuthor.Text = "Kyle Alami"
        '
        'butCredits
        '
        Me.butCredits.Location = New System.Drawing.Point(193, 239)
        Me.butCredits.Name = "butCredits"
        Me.butCredits.Size = New System.Drawing.Size(82, 23)
        Me.butCredits.TabIndex = 6
        Me.butCredits.Text = "Legal stuff"
        Me.butCredits.UseVisualStyleBackColor = True
        '
        'butExit
        '
        Me.butExit.Location = New System.Drawing.Point(380, 240)
        Me.butExit.Name = "butExit"
        Me.butExit.Size = New System.Drawing.Size(75, 23)
        Me.butExit.TabIndex = 7
        Me.butExit.Text = "Exit"
        Me.butExit.UseVisualStyleBackColor = True
        '
        'butChangelog
        '
        Me.butChangelog.Location = New System.Drawing.Point(75, 239)
        Me.butChangelog.Name = "butChangelog"
        Me.butChangelog.Size = New System.Drawing.Size(112, 23)
        Me.butChangelog.TabIndex = 8
        Me.butChangelog.Text = "Changelog"
        Me.butChangelog.UseVisualStyleBackColor = True
        '
        'butContact
        '
        Me.butContact.Location = New System.Drawing.Point(281, 240)
        Me.butContact.Name = "butContact"
        Me.butContact.Size = New System.Drawing.Size(93, 23)
        Me.butContact.TabIndex = 9
        Me.butContact.Text = "Contact Info"
        Me.butContact.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 270)
        Me.Controls.Add(Me.butContact)
        Me.Controls.Add(Me.butChangelog)
        Me.Controls.Add(Me.butExit)
        Me.Controls.Add(Me.butCredits)
        Me.Controls.Add(Me.labAuthor)
        Me.Controls.Add(Me.butCustom)
        Me.Controls.Add(Me.butProfiles)
        Me.Controls.Add(Me.butTranslate)
        Me.Controls.Add(Me.tboxOutput)
        Me.Controls.Add(Me.tboxInput)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tboxInput As System.Windows.Forms.TextBox
    Friend WithEvents tboxOutput As System.Windows.Forms.TextBox
    Friend WithEvents butTranslate As System.Windows.Forms.Button
    Friend WithEvents butProfiles As System.Windows.Forms.Button
    Friend WithEvents butCustom As System.Windows.Forms.Button
    Friend WithEvents labAuthor As System.Windows.Forms.Label
    Friend WithEvents butCredits As System.Windows.Forms.Button
    Friend WithEvents butExit As System.Windows.Forms.Button
    Friend WithEvents butChangelog As System.Windows.Forms.Button
    Friend WithEvents butContact As System.Windows.Forms.Button

End Class
