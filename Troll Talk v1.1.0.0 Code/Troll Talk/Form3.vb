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
End Class