<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCustom
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radbutCapitalizationAlternating = New System.Windows.Forms.RadioButton()
        Me.radbutCapitalizationNoCaps = New System.Windows.Forms.RadioButton()
        Me.radbutCapitalizationInverted = New System.Windows.Forms.RadioButton()
        Me.radbutCapitalizationAllCaps = New System.Windows.Forms.RadioButton()
        Me.radbutCapitalizationStandard = New System.Windows.Forms.RadioButton()
        Me.radbutCapitalizationEveryWord = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chboxPunctuationPeriod = New System.Windows.Forms.CheckBox()
        Me.chboxPunctuationQuestion = New System.Windows.Forms.CheckBox()
        Me.chboxPunctuationExclamation = New System.Windows.Forms.CheckBox()
        Me.chboxPunctuationStandard = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tboxSuffix = New System.Windows.Forms.TextBox()
        Me.tboxPrefix = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tboxReplacementAfter12 = New System.Windows.Forms.TextBox()
        Me.tboxReplacementBefore12 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tboxReplacementAfter11 = New System.Windows.Forms.TextBox()
        Me.tboxReplacementBefore11 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tboxReplacementAfter10 = New System.Windows.Forms.TextBox()
        Me.tboxReplacementBefore10 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tboxReplacementAfter9 = New System.Windows.Forms.TextBox()
        Me.tboxReplacementBefore9 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tboxReplacementAfter8 = New System.Windows.Forms.TextBox()
        Me.tboxReplacementBefore8 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tboxReplacementAfter7 = New System.Windows.Forms.TextBox()
        Me.tboxReplacementBefore7 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tboxReplacementAfter6 = New System.Windows.Forms.TextBox()
        Me.tboxReplacementBefore6 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tboxReplacementAfter5 = New System.Windows.Forms.TextBox()
        Me.tboxReplacementBefore5 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tboxReplacementAfter4 = New System.Windows.Forms.TextBox()
        Me.tboxReplacementBefore4 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tboxReplacementAfter3 = New System.Windows.Forms.TextBox()
        Me.tboxReplacementBefore3 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tboxReplacementAfter2 = New System.Windows.Forms.TextBox()
        Me.tboxReplacementBefore2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tboxReplacementAfter1 = New System.Windows.Forms.TextBox()
        Me.tboxReplacementBefore1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.butExit = New System.Windows.Forms.Button()
        Me.butCustom = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.chboxOtherReverse = New System.Windows.Forms.CheckBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.butCustomColor = New System.Windows.Forms.Button()
        Me.butCustomFont = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radbutCapitalizationAlternating)
        Me.GroupBox1.Controls.Add(Me.radbutCapitalizationNoCaps)
        Me.GroupBox1.Controls.Add(Me.radbutCapitalizationInverted)
        Me.GroupBox1.Controls.Add(Me.radbutCapitalizationAllCaps)
        Me.GroupBox1.Controls.Add(Me.radbutCapitalizationStandard)
        Me.GroupBox1.Controls.Add(Me.radbutCapitalizationEveryWord)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(137, 159)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Capitalization"
        '
        'radbutCapitalizationAlternating
        '
        Me.radbutCapitalizationAlternating.AutoSize = True
        Me.radbutCapitalizationAlternating.Location = New System.Drawing.Point(7, 135)
        Me.radbutCapitalizationAlternating.Name = "radbutCapitalizationAlternating"
        Me.radbutCapitalizationAlternating.Size = New System.Drawing.Size(115, 17)
        Me.radbutCapitalizationAlternating.TabIndex = 5
        Me.radbutCapitalizationAlternating.TabStop = True
        Me.radbutCapitalizationAlternating.Text = "aLtErNaTiNg CaPs"
        Me.radbutCapitalizationAlternating.UseVisualStyleBackColor = True
        '
        'radbutCapitalizationNoCaps
        '
        Me.radbutCapitalizationNoCaps.AutoSize = True
        Me.radbutCapitalizationNoCaps.Location = New System.Drawing.Point(7, 66)
        Me.radbutCapitalizationNoCaps.Name = "radbutCapitalizationNoCaps"
        Me.radbutCapitalizationNoCaps.Size = New System.Drawing.Size(63, 17)
        Me.radbutCapitalizationNoCaps.TabIndex = 3
        Me.radbutCapitalizationNoCaps.TabStop = True
        Me.radbutCapitalizationNoCaps.Text = "no caps"
        Me.radbutCapitalizationNoCaps.UseVisualStyleBackColor = True
        '
        'radbutCapitalizationInverted
        '
        Me.radbutCapitalizationInverted.AutoSize = True
        Me.radbutCapitalizationInverted.Location = New System.Drawing.Point(7, 112)
        Me.radbutCapitalizationInverted.Name = "radbutCapitalizationInverted"
        Me.radbutCapitalizationInverted.Size = New System.Drawing.Size(110, 17)
        Me.radbutCapitalizationInverted.TabIndex = 4
        Me.radbutCapitalizationInverted.TabStop = True
        Me.radbutCapitalizationInverted.Text = "iNVERTED CAPS"
        Me.radbutCapitalizationInverted.UseVisualStyleBackColor = True
        '
        'radbutCapitalizationAllCaps
        '
        Me.radbutCapitalizationAllCaps.AutoSize = True
        Me.radbutCapitalizationAllCaps.Location = New System.Drawing.Point(7, 43)
        Me.radbutCapitalizationAllCaps.Name = "radbutCapitalizationAllCaps"
        Me.radbutCapitalizationAllCaps.Size = New System.Drawing.Size(75, 17)
        Me.radbutCapitalizationAllCaps.TabIndex = 1
        Me.radbutCapitalizationAllCaps.TabStop = True
        Me.radbutCapitalizationAllCaps.Text = "ALL CAPS"
        Me.radbutCapitalizationAllCaps.UseVisualStyleBackColor = True
        '
        'radbutCapitalizationStandard
        '
        Me.radbutCapitalizationStandard.AutoSize = True
        Me.radbutCapitalizationStandard.Location = New System.Drawing.Point(7, 20)
        Me.radbutCapitalizationStandard.Name = "radbutCapitalizationStandard"
        Me.radbutCapitalizationStandard.Size = New System.Drawing.Size(68, 17)
        Me.radbutCapitalizationStandard.TabIndex = 0
        Me.radbutCapitalizationStandard.TabStop = True
        Me.radbutCapitalizationStandard.Text = "Standard"
        Me.radbutCapitalizationStandard.UseVisualStyleBackColor = True
        '
        'radbutCapitalizationEveryWord
        '
        Me.radbutCapitalizationEveryWord.AutoSize = True
        Me.radbutCapitalizationEveryWord.Location = New System.Drawing.Point(7, 89)
        Me.radbutCapitalizationEveryWord.Name = "radbutCapitalizationEveryWord"
        Me.radbutCapitalizationEveryWord.Size = New System.Drawing.Size(81, 17)
        Me.radbutCapitalizationEveryWord.TabIndex = 2
        Me.radbutCapitalizationEveryWord.TabStop = True
        Me.radbutCapitalizationEveryWord.Text = "Every Word"
        Me.radbutCapitalizationEveryWord.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chboxPunctuationPeriod)
        Me.GroupBox2.Controls.Add(Me.chboxPunctuationQuestion)
        Me.GroupBox2.Controls.Add(Me.chboxPunctuationExclamation)
        Me.GroupBox2.Controls.Add(Me.chboxPunctuationStandard)
        Me.GroupBox2.Location = New System.Drawing.Point(156, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(125, 115)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Punctuation"
        '
        'chboxPunctuationPeriod
        '
        Me.chboxPunctuationPeriod.AutoSize = True
        Me.chboxPunctuationPeriod.Location = New System.Drawing.Point(7, 89)
        Me.chboxPunctuationPeriod.Name = "chboxPunctuationPeriod"
        Me.chboxPunctuationPeriod.Size = New System.Drawing.Size(62, 17)
        Me.chboxPunctuationPeriod.TabIndex = 3
        Me.chboxPunctuationPeriod.Text = "Period ."
        Me.chboxPunctuationPeriod.UseVisualStyleBackColor = True
        '
        'chboxPunctuationQuestion
        '
        Me.chboxPunctuationQuestion.AutoSize = True
        Me.chboxPunctuationQuestion.Location = New System.Drawing.Point(7, 66)
        Me.chboxPunctuationQuestion.Name = "chboxPunctuationQuestion"
        Me.chboxPunctuationQuestion.Size = New System.Drawing.Size(104, 17)
        Me.chboxPunctuationQuestion.TabIndex = 2
        Me.chboxPunctuationQuestion.Text = "Question Mark ?"
        Me.chboxPunctuationQuestion.UseVisualStyleBackColor = True
        '
        'chboxPunctuationExclamation
        '
        Me.chboxPunctuationExclamation.AutoSize = True
        Me.chboxPunctuationExclamation.Location = New System.Drawing.Point(7, 44)
        Me.chboxPunctuationExclamation.Name = "chboxPunctuationExclamation"
        Me.chboxPunctuationExclamation.Size = New System.Drawing.Size(116, 17)
        Me.chboxPunctuationExclamation.TabIndex = 1
        Me.chboxPunctuationExclamation.Text = "Exclamation Point !"
        Me.chboxPunctuationExclamation.UseVisualStyleBackColor = True
        '
        'chboxPunctuationStandard
        '
        Me.chboxPunctuationStandard.AutoSize = True
        Me.chboxPunctuationStandard.Location = New System.Drawing.Point(7, 20)
        Me.chboxPunctuationStandard.Name = "chboxPunctuationStandard"
        Me.chboxPunctuationStandard.Size = New System.Drawing.Size(69, 17)
        Me.chboxPunctuationStandard.TabIndex = 0
        Me.chboxPunctuationStandard.Text = "Standard"
        Me.chboxPunctuationStandard.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.tboxSuffix)
        Me.GroupBox3.Controls.Add(Me.tboxPrefix)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(449, 13)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(221, 97)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Prefix and Suffix"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(209, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Prefix appears before message, suffix after."
        '
        'tboxSuffix
        '
        Me.tboxSuffix.Location = New System.Drawing.Point(46, 66)
        Me.tboxSuffix.Name = "tboxSuffix"
        Me.tboxSuffix.Size = New System.Drawing.Size(153, 20)
        Me.tboxSuffix.TabIndex = 3
        '
        'tboxPrefix
        '
        Me.tboxPrefix.Location = New System.Drawing.Point(46, 20)
        Me.tboxPrefix.Name = "tboxPrefix"
        Me.tboxPrefix.Size = New System.Drawing.Size(153, 20)
        Me.tboxPrefix.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Suffix"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Prefix"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.tboxReplacementAfter12)
        Me.GroupBox4.Controls.Add(Me.tboxReplacementBefore12)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.tboxReplacementAfter11)
        Me.GroupBox4.Controls.Add(Me.tboxReplacementBefore11)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.tboxReplacementAfter10)
        Me.GroupBox4.Controls.Add(Me.tboxReplacementBefore10)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.tboxReplacementAfter9)
        Me.GroupBox4.Controls.Add(Me.tboxReplacementBefore9)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.tboxReplacementAfter8)
        Me.GroupBox4.Controls.Add(Me.tboxReplacementBefore8)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.tboxReplacementAfter7)
        Me.GroupBox4.Controls.Add(Me.tboxReplacementBefore7)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.tboxReplacementAfter6)
        Me.GroupBox4.Controls.Add(Me.tboxReplacementBefore6)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.tboxReplacementAfter5)
        Me.GroupBox4.Controls.Add(Me.tboxReplacementBefore5)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.tboxReplacementAfter4)
        Me.GroupBox4.Controls.Add(Me.tboxReplacementBefore4)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.tboxReplacementAfter3)
        Me.GroupBox4.Controls.Add(Me.tboxReplacementBefore3)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.tboxReplacementAfter2)
        Me.GroupBox4.Controls.Add(Me.tboxReplacementBefore2)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.tboxReplacementAfter1)
        Me.GroupBox4.Controls.Add(Me.tboxReplacementBefore1)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Location = New System.Drawing.Point(13, 179)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(561, 134)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Replacement"
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(517, 43)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(18, 38)
        Me.Label17.TabIndex = 37
        Me.Label17.Text = " |" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " |" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "V"
        '
        'tboxReplacementAfter12
        '
        Me.tboxReplacementAfter12.Location = New System.Drawing.Point(512, 84)
        Me.tboxReplacementAfter12.Name = "tboxReplacementAfter12"
        Me.tboxReplacementAfter12.Size = New System.Drawing.Size(36, 20)
        Me.tboxReplacementAfter12.TabIndex = 36
        '
        'tboxReplacementBefore12
        '
        Me.tboxReplacementBefore12.Location = New System.Drawing.Point(512, 20)
        Me.tboxReplacementBefore12.Name = "tboxReplacementBefore12"
        Me.tboxReplacementBefore12.Size = New System.Drawing.Size(36, 20)
        Me.tboxReplacementBefore12.TabIndex = 35
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(475, 43)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(18, 38)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = " |" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " |" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "V"
        '
        'tboxReplacementAfter11
        '
        Me.tboxReplacementAfter11.Location = New System.Drawing.Point(470, 84)
        Me.tboxReplacementAfter11.Name = "tboxReplacementAfter11"
        Me.tboxReplacementAfter11.Size = New System.Drawing.Size(36, 20)
        Me.tboxReplacementAfter11.TabIndex = 33
        '
        'tboxReplacementBefore11
        '
        Me.tboxReplacementBefore11.Location = New System.Drawing.Point(470, 20)
        Me.tboxReplacementBefore11.Name = "tboxReplacementBefore11"
        Me.tboxReplacementBefore11.Size = New System.Drawing.Size(36, 20)
        Me.tboxReplacementBefore11.TabIndex = 32
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(433, 43)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(18, 38)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = " |" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " |" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "V"
        '
        'tboxReplacementAfter10
        '
        Me.tboxReplacementAfter10.Location = New System.Drawing.Point(428, 84)
        Me.tboxReplacementAfter10.Name = "tboxReplacementAfter10"
        Me.tboxReplacementAfter10.Size = New System.Drawing.Size(36, 20)
        Me.tboxReplacementAfter10.TabIndex = 30
        '
        'tboxReplacementBefore10
        '
        Me.tboxReplacementBefore10.Location = New System.Drawing.Point(428, 20)
        Me.tboxReplacementBefore10.Name = "tboxReplacementBefore10"
        Me.tboxReplacementBefore10.Size = New System.Drawing.Size(36, 20)
        Me.tboxReplacementBefore10.TabIndex = 29
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(391, 43)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(18, 38)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = " |" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " |" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "V"
        '
        'tboxReplacementAfter9
        '
        Me.tboxReplacementAfter9.Location = New System.Drawing.Point(386, 84)
        Me.tboxReplacementAfter9.Name = "tboxReplacementAfter9"
        Me.tboxReplacementAfter9.Size = New System.Drawing.Size(36, 20)
        Me.tboxReplacementAfter9.TabIndex = 27
        '
        'tboxReplacementBefore9
        '
        Me.tboxReplacementBefore9.Location = New System.Drawing.Point(386, 20)
        Me.tboxReplacementBefore9.Name = "tboxReplacementBefore9"
        Me.tboxReplacementBefore9.Size = New System.Drawing.Size(36, 20)
        Me.tboxReplacementBefore9.TabIndex = 26
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(349, 43)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(18, 38)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = " |" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " |" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "V"
        '
        'tboxReplacementAfter8
        '
        Me.tboxReplacementAfter8.Location = New System.Drawing.Point(344, 84)
        Me.tboxReplacementAfter8.Name = "tboxReplacementAfter8"
        Me.tboxReplacementAfter8.Size = New System.Drawing.Size(36, 20)
        Me.tboxReplacementAfter8.TabIndex = 24
        '
        'tboxReplacementBefore8
        '
        Me.tboxReplacementBefore8.Location = New System.Drawing.Point(344, 20)
        Me.tboxReplacementBefore8.Name = "tboxReplacementBefore8"
        Me.tboxReplacementBefore8.Size = New System.Drawing.Size(36, 20)
        Me.tboxReplacementBefore8.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(307, 43)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(18, 38)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = " |" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " |" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "V"
        '
        'tboxReplacementAfter7
        '
        Me.tboxReplacementAfter7.Location = New System.Drawing.Point(302, 84)
        Me.tboxReplacementAfter7.Name = "tboxReplacementAfter7"
        Me.tboxReplacementAfter7.Size = New System.Drawing.Size(36, 20)
        Me.tboxReplacementAfter7.TabIndex = 21
        '
        'tboxReplacementBefore7
        '
        Me.tboxReplacementBefore7.Location = New System.Drawing.Point(302, 20)
        Me.tboxReplacementBefore7.Name = "tboxReplacementBefore7"
        Me.tboxReplacementBefore7.Size = New System.Drawing.Size(36, 20)
        Me.tboxReplacementBefore7.TabIndex = 20
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(265, 43)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(18, 38)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = " |" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " |" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "V"
        '
        'tboxReplacementAfter6
        '
        Me.tboxReplacementAfter6.Location = New System.Drawing.Point(260, 84)
        Me.tboxReplacementAfter6.Name = "tboxReplacementAfter6"
        Me.tboxReplacementAfter6.Size = New System.Drawing.Size(36, 20)
        Me.tboxReplacementAfter6.TabIndex = 18
        '
        'tboxReplacementBefore6
        '
        Me.tboxReplacementBefore6.Location = New System.Drawing.Point(260, 20)
        Me.tboxReplacementBefore6.Name = "tboxReplacementBefore6"
        Me.tboxReplacementBefore6.Size = New System.Drawing.Size(36, 20)
        Me.tboxReplacementBefore6.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(223, 43)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 38)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = " |" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " |" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "V"
        '
        'tboxReplacementAfter5
        '
        Me.tboxReplacementAfter5.Location = New System.Drawing.Point(218, 84)
        Me.tboxReplacementAfter5.Name = "tboxReplacementAfter5"
        Me.tboxReplacementAfter5.Size = New System.Drawing.Size(36, 20)
        Me.tboxReplacementAfter5.TabIndex = 15
        '
        'tboxReplacementBefore5
        '
        Me.tboxReplacementBefore5.Location = New System.Drawing.Point(218, 20)
        Me.tboxReplacementBefore5.Name = "tboxReplacementBefore5"
        Me.tboxReplacementBefore5.Size = New System.Drawing.Size(36, 20)
        Me.tboxReplacementBefore5.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(181, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 38)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = " |" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " |" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "V"
        '
        'tboxReplacementAfter4
        '
        Me.tboxReplacementAfter4.Location = New System.Drawing.Point(176, 84)
        Me.tboxReplacementAfter4.Name = "tboxReplacementAfter4"
        Me.tboxReplacementAfter4.Size = New System.Drawing.Size(36, 20)
        Me.tboxReplacementAfter4.TabIndex = 12
        '
        'tboxReplacementBefore4
        '
        Me.tboxReplacementBefore4.Location = New System.Drawing.Point(176, 20)
        Me.tboxReplacementBefore4.Name = "tboxReplacementBefore4"
        Me.tboxReplacementBefore4.Size = New System.Drawing.Size(36, 20)
        Me.tboxReplacementBefore4.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(141, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(18, 38)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = " |" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " |" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "V"
        '
        'tboxReplacementAfter3
        '
        Me.tboxReplacementAfter3.Location = New System.Drawing.Point(136, 84)
        Me.tboxReplacementAfter3.Name = "tboxReplacementAfter3"
        Me.tboxReplacementAfter3.Size = New System.Drawing.Size(36, 20)
        Me.tboxReplacementAfter3.TabIndex = 9
        '
        'tboxReplacementBefore3
        '
        Me.tboxReplacementBefore3.Location = New System.Drawing.Point(136, 20)
        Me.tboxReplacementBefore3.Name = "tboxReplacementBefore3"
        Me.tboxReplacementBefore3.Size = New System.Drawing.Size(36, 20)
        Me.tboxReplacementBefore3.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(99, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 38)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = " |" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " |" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "V"
        '
        'tboxReplacementAfter2
        '
        Me.tboxReplacementAfter2.Location = New System.Drawing.Point(94, 84)
        Me.tboxReplacementAfter2.Name = "tboxReplacementAfter2"
        Me.tboxReplacementAfter2.Size = New System.Drawing.Size(36, 20)
        Me.tboxReplacementAfter2.TabIndex = 6
        '
        'tboxReplacementBefore2
        '
        Me.tboxReplacementBefore2.Location = New System.Drawing.Point(94, 20)
        Me.tboxReplacementBefore2.Name = "tboxReplacementBefore2"
        Me.tboxReplacementBefore2.Size = New System.Drawing.Size(36, 20)
        Me.tboxReplacementBefore2.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(57, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 38)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = " |" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " |" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "V"
        '
        'tboxReplacementAfter1
        '
        Me.tboxReplacementAfter1.Location = New System.Drawing.Point(52, 84)
        Me.tboxReplacementAfter1.Name = "tboxReplacementAfter1"
        Me.tboxReplacementAfter1.Size = New System.Drawing.Size(36, 20)
        Me.tboxReplacementAfter1.TabIndex = 3
        '
        'tboxReplacementBefore1
        '
        Me.tboxReplacementBefore1.Location = New System.Drawing.Point(52, 20)
        Me.tboxReplacementBefore1.Name = "tboxReplacementBefore1"
        Me.tboxReplacementBefore1.Size = New System.Drawing.Size(36, 20)
        Me.tboxReplacementBefore1.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "After"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Before"
        '
        'butExit
        '
        Me.butExit.Location = New System.Drawing.Point(590, 289)
        Me.butExit.Name = "butExit"
        Me.butExit.Size = New System.Drawing.Size(75, 23)
        Me.butExit.TabIndex = 4
        Me.butExit.Text = "Exit"
        Me.butExit.UseVisualStyleBackColor = True
        '
        'butCustom
        '
        Me.butCustom.Location = New System.Drawing.Point(206, 142)
        Me.butCustom.Name = "butCustom"
        Me.butCustom.Size = New System.Drawing.Size(187, 23)
        Me.butCustom.TabIndex = 5
        Me.butCustom.Text = "Set Custom Profile"
        Me.butCustom.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.butCustomFont)
        Me.GroupBox5.Controls.Add(Me.butCustomColor)
        Me.GroupBox5.Controls.Add(Me.chboxOtherReverse)
        Me.GroupBox5.Location = New System.Drawing.Point(288, 13)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(155, 97)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Other"
        '
        'chboxOtherReverse
        '
        Me.chboxOtherReverse.AutoSize = True
        Me.chboxOtherReverse.Location = New System.Drawing.Point(7, 20)
        Me.chboxOtherReverse.Name = "chboxOtherReverse"
        Me.chboxOtherReverse.Size = New System.Drawing.Size(95, 17)
        Me.chboxOtherReverse.TabIndex = 0
        Me.chboxOtherReverse.Text = "Reverse Order"
        Me.chboxOtherReverse.UseVisualStyleBackColor = True
        '
        'butCustomColor
        '
        Me.butCustomColor.Location = New System.Drawing.Point(7, 39)
        Me.butCustomColor.Name = "butCustomColor"
        Me.butCustomColor.Size = New System.Drawing.Size(75, 23)
        Me.butCustomColor.TabIndex = 1
        Me.butCustomColor.Text = "Color"
        Me.butCustomColor.UseVisualStyleBackColor = True
        '
        'butCustomFont
        '
        Me.butCustomFont.Location = New System.Drawing.Point(7, 68)
        Me.butCustomFont.Name = "butCustomFont"
        Me.butCustomFont.Size = New System.Drawing.Size(75, 23)
        Me.butCustomFont.TabIndex = 2
        Me.butCustomFont.Text = "Font"
        Me.butCustomFont.UseVisualStyleBackColor = True
        '
        'FormCustom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 324)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.butCustom)
        Me.Controls.Add(Me.butExit)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormCustom"
        Me.Text = "Custom Profile"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radbutCapitalizationAlternating As System.Windows.Forms.RadioButton
    Friend WithEvents radbutCapitalizationNoCaps As System.Windows.Forms.RadioButton
    Friend WithEvents radbutCapitalizationInverted As System.Windows.Forms.RadioButton
    Friend WithEvents radbutCapitalizationAllCaps As System.Windows.Forms.RadioButton
    Friend WithEvents radbutCapitalizationStandard As System.Windows.Forms.RadioButton
    Friend WithEvents radbutCapitalizationEveryWord As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chboxPunctuationPeriod As System.Windows.Forms.CheckBox
    Friend WithEvents chboxPunctuationQuestion As System.Windows.Forms.CheckBox
    Friend WithEvents chboxPunctuationExclamation As System.Windows.Forms.CheckBox
    Friend WithEvents chboxPunctuationStandard As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tboxSuffix As System.Windows.Forms.TextBox
    Friend WithEvents tboxPrefix As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tboxReplacementAfter8 As System.Windows.Forms.TextBox
    Friend WithEvents tboxReplacementBefore8 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tboxReplacementAfter7 As System.Windows.Forms.TextBox
    Friend WithEvents tboxReplacementBefore7 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tboxReplacementAfter6 As System.Windows.Forms.TextBox
    Friend WithEvents tboxReplacementBefore6 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tboxReplacementAfter5 As System.Windows.Forms.TextBox
    Friend WithEvents tboxReplacementBefore5 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tboxReplacementAfter4 As System.Windows.Forms.TextBox
    Friend WithEvents tboxReplacementBefore4 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tboxReplacementAfter3 As System.Windows.Forms.TextBox
    Friend WithEvents tboxReplacementBefore3 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tboxReplacementAfter2 As System.Windows.Forms.TextBox
    Friend WithEvents tboxReplacementBefore2 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tboxReplacementAfter1 As System.Windows.Forms.TextBox
    Friend WithEvents tboxReplacementBefore1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents butExit As System.Windows.Forms.Button
    Friend WithEvents butCustom As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents tboxReplacementAfter12 As System.Windows.Forms.TextBox
    Friend WithEvents tboxReplacementBefore12 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents tboxReplacementAfter11 As System.Windows.Forms.TextBox
    Friend WithEvents tboxReplacementBefore11 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents tboxReplacementAfter10 As System.Windows.Forms.TextBox
    Friend WithEvents tboxReplacementBefore10 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tboxReplacementAfter9 As System.Windows.Forms.TextBox
    Friend WithEvents tboxReplacementBefore9 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents chboxOtherReverse As System.Windows.Forms.CheckBox
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents butCustomFont As System.Windows.Forms.Button
    Friend WithEvents butCustomColor As System.Windows.Forms.Button
End Class
