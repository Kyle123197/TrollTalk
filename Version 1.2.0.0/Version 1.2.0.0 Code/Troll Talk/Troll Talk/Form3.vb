Public Class FormCustom

    

    Private Sub butExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butExit.Click

        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub FormCustom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



    End Sub

    Private Sub butCustom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butCustom.Click

        strPrefix = tboxPrefix.Text
        strSuffix = tboxSuffix.Text

        strReplaceAfter1 = tboxReplacementAfter1.Text
        strReplaceBefore1 = tboxReplacementBefore1.Text

        strReplaceAfter2 = tboxReplacementAfter2.Text
        strReplaceBefore2 = tboxReplacementBefore2.Text

        strReplaceAfter3 = tboxReplacementAfter3.Text
        strReplaceBefore3 = tboxReplacementBefore3.Text

        strReplaceAfter4 = tboxReplacementAfter4.Text
        strReplaceBefore4 = tboxReplacementBefore4.Text

        strReplaceAfter5 = tboxReplacementAfter5.Text
        strReplaceBefore5 = tboxReplacementBefore5.Text

        strReplaceAfter6 = tboxReplacementAfter6.Text
        strReplaceBefore6 = tboxReplacementBefore6.Text

        strReplaceAfter7 = tboxReplacementAfter7.Text
        strReplaceBefore7 = tboxReplacementBefore7.Text

        strReplaceAfter8 = tboxReplacementAfter8.Text
        strReplaceBefore8 = tboxReplacementBefore8.Text

        strReplaceAfter9 = tboxReplacementAfter9.Text
        strReplaceBefore9 = tboxReplacementBefore9.Text

        strReplaceAfter10 = tboxReplacementAfter10.Text
        strReplaceBefore10 = tboxReplacementBefore10.Text

        strReplaceAfter11 = tboxReplacementAfter11.Text
        strReplaceBefore11 = tboxReplacementBefore11.Text

        strReplaceAfter12 = tboxReplacementAfter12.Text
        strReplaceBefore12 = tboxReplacementBefore12.Text

        FormProfiles.radbutCustom.Text = tboxCustomName.Text

    End Sub

    Private Sub radbutCapitalizationStandard_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radbutCapitalizationStandard.CheckedChanged

    End Sub

    Private Sub chboxPunctuationStandard_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chboxPunctuationStandard.CheckedChanged

        chboxPunctuationExclamation.Checked = False
        chboxPunctuationPeriod.Checked = False
        chboxPunctuationQuestion.Checked = False

    End Sub

    Private Sub butCustomColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butCustomColor.Click

        ColorDialog1.ShowDialog()

    End Sub

    Private Sub butCustomFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butCustomFont.Click

        FontDialog1.ShowDialog()

    End Sub

    Private Sub chboxPunctuationExclamation_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chboxPunctuationExclamation.CheckedChanged



    End Sub

    Private Sub chboxPunctuationQuestion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chboxPunctuationQuestion.CheckedChanged



    End Sub

    Private Sub chboxPunctuationPeriod_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chboxPunctuationPeriod.CheckedChanged



    End Sub

    Private Sub butSaveSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butSaveSettings.Click

        My.Settings.boolCapStandard = radbutCapitalizationStandard.Checked
        My.Settings.boolCapAll = radbutCapitalizationAllCaps.Checked
        My.Settings.boolCapNone = radbutCapitalizationNoCaps.Checked
        My.Settings.boolCapEvery = radbutCapitalizationEveryWord.Checked
        My.Settings.boolCapInvert = radbutCapitalizationInverted.Checked
        My.Settings.boolCapAlt = radbutCapitalizationAlternating.Checked

        My.Settings.boolPuncStandard = chboxPunctuationStandard.Checked
        My.Settings.boolPuncExclaim = chboxPunctuationExclamation.Checked
        My.Settings.boolPuncQuestion = chboxPunctuationQuestion.Checked
        My.Settings.boolPuncPeriod = chboxPunctuationPeriod.Checked

        My.Settings.boolOtherReverse = chboxOtherReverse.Checked

        My.Settings.strPrefix = tboxPrefix.Text
        My.Settings.strSuffix = tboxSuffix.Text

        My.Settings.strCustomName = tboxCustomName.Text

        My.Settings.strReplaceBefore1 = tboxReplacementBefore1.Text
        My.Settings.strReplaceBefore2 = tboxReplacementBefore2.Text
        My.Settings.strReplaceBefore3 = tboxReplacementBefore3.Text
        My.Settings.strReplaceBefore4 = tboxReplacementBefore4.Text
        My.Settings.strReplaceBefore5 = tboxReplacementBefore5.Text
        My.Settings.strReplaceBefore6 = tboxReplacementBefore6.Text
        My.Settings.strReplaceBefore7 = tboxReplacementBefore7.Text
        My.Settings.strReplaceBefore8 = tboxReplacementBefore8.Text
        My.Settings.strReplaceBefore9 = tboxReplacementBefore9.Text
        My.Settings.strReplaceBefore10 = tboxReplacementBefore10.Text
        My.Settings.strReplaceBefore11 = tboxReplacementBefore11.Text
        My.Settings.strReplaceBefore12 = tboxReplacementBefore12.Text

        My.Settings.strReplaceAfter1 = tboxReplacementAfter1.Text
        My.Settings.strReplaceAfter2 = tboxReplacementAfter2.Text
        My.Settings.strReplaceAfter3 = tboxReplacementAfter3.Text
        My.Settings.strReplaceAfter4 = tboxReplacementAfter4.Text
        My.Settings.strReplaceAfter5 = tboxReplacementAfter5.Text
        My.Settings.strReplaceAfter6 = tboxReplacementAfter6.Text
        My.Settings.strReplaceAfter7 = tboxReplacementAfter7.Text
        My.Settings.strReplaceAfter8 = tboxReplacementAfter8.Text
        My.Settings.strReplaceAfter9 = tboxReplacementAfter9.Text
        My.Settings.strReplaceAfter10 = tboxReplacementAfter10.Text
        My.Settings.strReplaceAfter11 = tboxReplacementAfter11.Text
        My.Settings.strReplaceAfter12 = tboxReplacementAfter12.Text

    End Sub

    Private Sub butLoadSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butLoadSettings.Click

        tboxReplacementAfter1.Text = My.Settings.strReplaceAfter1
        tboxReplacementAfter2.Text = My.Settings.strReplaceAfter2
        tboxReplacementAfter3.Text = My.Settings.strReplaceAfter3
        tboxReplacementAfter4.Text = My.Settings.strReplaceAfter4
        tboxReplacementAfter5.Text = My.Settings.strReplaceAfter5
        tboxReplacementAfter6.Text = My.Settings.strReplaceAfter6
        tboxReplacementAfter7.Text = My.Settings.strReplaceAfter7
        tboxReplacementAfter8.Text = My.Settings.strReplaceAfter8
        tboxReplacementAfter9.Text = My.Settings.strReplaceAfter9
        tboxReplacementAfter10.Text = My.Settings.strReplaceAfter10
        tboxReplacementAfter11.Text = My.Settings.strReplaceAfter11
        tboxReplacementAfter12.Text = My.Settings.strReplaceAfter12

        tboxReplacementBefore1.Text = My.Settings.strReplaceBefore1
        tboxReplacementBefore2.Text = My.Settings.strReplaceBefore2
        tboxReplacementBefore3.Text = My.Settings.strReplaceBefore3
        tboxReplacementBefore4.Text = My.Settings.strReplaceBefore4
        tboxReplacementBefore5.Text = My.Settings.strReplaceBefore5
        tboxReplacementBefore6.Text = My.Settings.strReplaceBefore6
        tboxReplacementBefore7.Text = My.Settings.strReplaceBefore7
        tboxReplacementBefore8.Text = My.Settings.strReplaceBefore8
        tboxReplacementBefore9.Text = My.Settings.strReplaceBefore9
        tboxReplacementBefore10.Text = My.Settings.strReplaceBefore10
        tboxReplacementBefore11.Text = My.Settings.strReplaceBefore11
        tboxReplacementBefore12.Text = My.Settings.strReplaceBefore12

        tboxCustomName.Text = My.Settings.strCustomName

        tboxSuffix.Text = My.Settings.strSuffix
        tboxPrefix.Text = My.Settings.strPrefix

        chboxOtherReverse.Checked = My.Settings.boolOtherReverse

        chboxPunctuationPeriod.Checked = My.Settings.boolPuncPeriod
        chboxPunctuationQuestion.Checked = My.Settings.boolPuncQuestion
        chboxPunctuationExclamation.Checked = My.Settings.boolPuncExclaim
        chboxPunctuationStandard.Checked = My.Settings.boolPuncStandard

        radbutCapitalizationStandard.Checked = My.Settings.boolCapStandard
        radbutCapitalizationAllCaps.Checked = My.Settings.boolCapAll
        radbutCapitalizationNoCaps.Checked = My.Settings.boolCapNone
        radbutCapitalizationEveryWord.Checked = My.Settings.boolCapEvery
        radbutCapitalizationInverted.Checked = My.Settings.boolCapInvert
        radbutCapitalizationAlternating.Checked = My.Settings.boolCapAlt

    End Sub
End Class