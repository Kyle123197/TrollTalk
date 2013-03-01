Public Class Form1

    Private Sub butTranslate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butTranslate.Click

        Dim strInput As String
        Dim strOutput As String

        strInput = tboxInput.Text

        If strInput.Length = 0 Then
            tboxOutput.Text = "The input must be at least one character long."

        ElseIf FormProfiles.radbutAradia.Checked = True Then
            strOutput = Replace(strInput, "O", "0")
            strOutput = Replace(strOutput, "o", "0")
            strOutput = Replace(strOutput, ".", "")
            strOutput = Replace(strOutput, "?", "")
            'tboxOutput.Text = strOutput
            tboxOutput.Text = StrConv(strOutput, vbLowerCase)
            tboxOutput.ForeColor = Color.Maroon

        ElseIf FormProfiles.radbutTavros.Checked = True Then
            strOutput = StrConv(strInput, vbProperCase)

            Dim strInputTavros As String
            Dim stroutputTavros As String
            Dim intTavros As Integer
            intTavros = strInput.Length - 1
            strInputTavros = strInput.Substring(0, 1)
            stroutputTavros = strInput.Substring(1, intTavros)

            strInputTavros = StrConv(strInputTavros, vbLowerCase)
            stroutputTavros = StrConv(stroutputTavros, vbUpperCase)
            stroutputTavros = Replace(stroutputTavros, ".", ",")
            stroutputTavros = Replace(stroutputTavros, "?", ",")
            stroutputTavros = Replace(stroutputTavros, "!", ",")
            stroutputTavros = Replace(stroutputTavros, ", A", ", a")
            stroutputTavros = Replace(stroutputTavros, ", B", ", b")
            stroutputTavros = Replace(stroutputTavros, ", C", ", c")
            stroutputTavros = Replace(stroutputTavros, ", D", ", d")
            stroutputTavros = Replace(stroutputTavros, ", E", ", e")
            stroutputTavros = Replace(stroutputTavros, ", F", ", f")
            stroutputTavros = Replace(stroutputTavros, ", G", ", g")
            stroutputTavros = Replace(stroutputTavros, ", H", ", h")
            stroutputTavros = Replace(stroutputTavros, ", I", ", i")
            stroutputTavros = Replace(stroutputTavros, ", J", ", j")
            stroutputTavros = Replace(stroutputTavros, ", K", ", k")
            stroutputTavros = Replace(stroutputTavros, ", L", ", l")
            stroutputTavros = Replace(stroutputTavros, ", M", ", m")
            stroutputTavros = Replace(stroutputTavros, ", N", ", n")
            stroutputTavros = Replace(stroutputTavros, ", L", ", l")
            stroutputTavros = Replace(stroutputTavros, ", O", ", o")
            stroutputTavros = Replace(stroutputTavros, ", P", ", p")
            stroutputTavros = Replace(stroutputTavros, ", Q", ", q")
            stroutputTavros = Replace(stroutputTavros, ", R", ", r")
            stroutputTavros = Replace(stroutputTavros, ", S", ", s")
            stroutputTavros = Replace(stroutputTavros, ", T", ", t")
            stroutputTavros = Replace(stroutputTavros, ", U", ", u")
            stroutputTavros = Replace(stroutputTavros, ", V", ", v")
            stroutputTavros = Replace(stroutputTavros, ", W", ", w")
            stroutputTavros = Replace(stroutputTavros, ", X", ", x")
            stroutputTavros = Replace(stroutputTavros, ", Y", ", y")
            stroutputTavros = Replace(stroutputTavros, ", Z", ", z")

            tboxOutput.Text = strInputTavros & stroutputTavros
            tboxOutput.ForeColor = Color.Brown

        ElseIf FormProfiles.radbutSollux.Checked = True Then
            strOutput = StrConv(strInput, vbLowerCase)
            strOutput = Replace(strOutput, "i", "ii")
            strOutput = Replace(strOutput, "s", "2")
            strOutput = Replace(strOutput, " to", " two")
            strOutput = Replace(strOutput, "to ", "two ")
            strOutput = Replace(strOutput, " too", " two")
            strOutput = Replace(strOutput, "too ", "two ")
            tboxOutput.Text = strOutput
            tboxOutput.ForeColor = Color.Goldenrod

        ElseIf FormProfiles.radbutKarkat.Checked = True Then
            strOutput = StrConv(strInput, vbUpperCase)
            tboxOutput.Text = strOutput
            tboxOutput.ForeColor = Color.Gray

        ElseIf FormProfiles.radbutNepeta.Checked = True Then
            strOutput = StrConv(strInput, vbLowerCase)
            strOutput = Replace(strOutput, "ee", "33")
            tboxOutput.Text = ":33 < " & strOutput
            tboxOutput.ForeColor = Color.Olive

        ElseIf FormProfiles.radbutKanaya.Checked = True Then
            'Kanaya's code
            'Proper Case
            'Replace any letter with a space before it with it's capital equivalant, including the space.

            strOutput = StrConv(strInput, vbProperCase)
            strOutput = Replace(strOutput, " a", " A")
            strOutput = Replace(strOutput, " b", " B")
            strOutput = Replace(strOutput, " c", " C")
            strOutput = Replace(strOutput, " d", " D")
            strOutput = Replace(strOutput, " e", " E")
            strOutput = Replace(strOutput, " f", " F")
            strOutput = Replace(strOutput, " g", " G")
            strOutput = Replace(strOutput, " h", " H")
            strOutput = Replace(strOutput, " i", " I")
            strOutput = Replace(strOutput, " j", " J")
            strOutput = Replace(strOutput, " k", " K")
            strOutput = Replace(strOutput, " l", " L")
            strOutput = Replace(strOutput, " m", " M")
            strOutput = Replace(strOutput, " n", " N")
            strOutput = Replace(strOutput, " l", " L")
            strOutput = Replace(strOutput, " o", " O")
            strOutput = Replace(strOutput, " p", " P")
            strOutput = Replace(strOutput, " q", " Q")
            strOutput = Replace(strOutput, " r", " R")
            strOutput = Replace(strOutput, " s", " S")
            strOutput = Replace(strOutput, " t", " T")
            strOutput = Replace(strOutput, " u", " U")
            strOutput = Replace(strOutput, " v", " V")
            strOutput = Replace(strOutput, " w", " W")
            strOutput = Replace(strOutput, " x", " X")
            strOutput = Replace(strOutput, " y", " Y")
            strOutput = Replace(strOutput, " z", " Z")
            tboxOutput.Text = strOutput
            tboxOutput.ForeColor = Color.SeaGreen

        ElseIf FormProfiles.radbutTerezi.Checked = True Then
            strOutput = StrConv(strInput, vbUpperCase)
            strOutput = Replace(strOutput, "A", "4")
            strOutput = Replace(strOutput, "I", "1")
            strOutput = Replace(strOutput, "E", "3")
            tboxOutput.Text = strOutput
            tboxOutput.ForeColor = Color.CadetBlue

        ElseIf FormProfiles.radbutVriska.Checked = True Then
            strOutput = StrConv(strInput, vbProperCase)
            strOutput = Replace(strOutput, "b", "8")
            strOutput = Replace(strOutput, "B", "8")
            strOutput = Replace(strOutput, "Eight", "8")
            strOutput = Replace(strOutput, "eight", "8")
            strOutput = Replace(strOutput, "ate", "8")
            tboxOutput.Text = strOutput
            tboxOutput.ForeColor = Color.DarkSlateBlue

        ElseIf FormProfiles.radbutEquius.Checked = True Then
            strOutput = StrConv(strInput, vbProperCase)
            strOutput = Replace(strOutput, "X", "%")
            strOutput = Replace(strOutput, "x", "%")
            strOutput = Replace(strOutput, "Cross", "%")
            strOutput = Replace(strOutput, "cross", "%")
            strOutput = Replace(strOutput, "Doublecross", "%%")
            strOutput = Replace(strOutput, "doublecross", "%%")
            strOutput = Replace(strOutput, "Loo", "100")
            strOutput = Replace(strOutput, "loo", "100")
            strOutput = Replace(strOutput, "Ool", "001")
            strOutput = Replace(strOutput, "ool", "001")
            strOutput = Replace(strOutput, "Nay", "Neigh")
            strOutput = Replace(strOutput, "nay", "neigh")
            strOutput = Replace(strOutput, "strong", "STRONG")
            strOutput = Replace(strOutput, "Strong", "STRONG")
            strOutput = Replace(strOutput, "Strength", "STRONGNESS")
            strOutput = Replace(strOutput, "strength", "STRONGNESS")
            strOutput = Replace(strOutput, ".", "")
            strOutput = Replace(strOutput, "?", "")
            strOutput = Replace(strOutput, "!", "")
            tboxOutput.Text = "D --> " & strOutput
            tboxOutput.ForeColor = Color.Navy

        ElseIf FormProfiles.radbutGamzee.Checked = True Then
            'Thank you:
            'http://www.dreamincode.net/forums/topic/13107-visual-basic-6-library-functions-%25e2%2580%2593-string-type/
            'This gave me the code for the AltCap Function
            'Had to change a few things, however.
            strOutput = Replace(strInput, " ", "  ")
            strOutput = AltCap(strOutput)
            strOutput = Replace(strOutput, "  ", " ")
            tboxOutput.Text = strOutput
            tboxOutput.ForeColor = Color.Purple

        ElseIf FormProfiles.radbutEridan.Checked = True Then
            'strOutput = StrConv(strInput, vbLowerCase)
            strOutput = Replace(strInput, "V", "VV")
            strOutput = Replace(strOutput, "v", "vv")
            strOutput = Replace(strOutput, "W", "WW")
            strOutput = Replace(strOutput, "w", "ww")
            strOutput = Replace(strOutput, "Of", "A")
            strOutput = Replace(strOutput, "of", "a")
            strOutput = Replace(strOutput, "ing", "in")
            strOutput = Replace(strOutput, "An ", "A ")
            strOutput = Replace(strOutput, "an ", "a ")
            strOutput = Replace(strOutput, "Want to", "Wanna")
            strOutput = Replace(strOutput, "want to", "wanna")
            strOutput = Replace(strOutput, "Going to", "Gonna")
            strOutput = Replace(strOutput, "going to", "gonna")
            strOutput = Replace(strOutput, ".", "")
            strOutput = Replace(strOutput, "?", "")
            strOutput = Replace(strOutput, "!", "")
            tboxOutput.Text = strOutput
            tboxOutput.ForeColor = Color.Purple

        ElseIf FormProfiles.radbutFeferi.Checked = True Then
            strOutput = Replace(strInput, "H", ")(")
            strOutput = Replace(strOutput, "h", ")(")
            strOutput = Replace(strOutput, "E", "-E")
            tboxOutput.Text = strOutput
            tboxOutput.ForeColor = Color.Purple

        ElseIf FormProfiles.radbutCustom.Checked = True Then
            If FormCustom.radbutCapitalizationStandard.Checked = True Then
                strOutput = StrConv(strInput, vbProperCase)
            ElseIf FormCustom.radbutCapitalizationAllCaps.Checked = True Then
                strOutput = StrConv(strInput, vbUpperCase)
            ElseIf FormCustom.radbutCapitalizationNoCaps.Checked = True Then
                strOutput = StrConv(strInput, vbLowerCase)
            ElseIf FormCustom.radbutCapitalizationEveryWord.Checked = True Then
                'Kanaya's code here
                strOutput = StrConv(strInput, vbProperCase)
                strOutput = Replace(strOutput, " a", " A")
                strOutput = Replace(strOutput, " b", " B")
                strOutput = Replace(strOutput, " c", " C")
                strOutput = Replace(strOutput, " d", " D")
                strOutput = Replace(strOutput, " e", " E")
                strOutput = Replace(strOutput, " f", " F")
                strOutput = Replace(strOutput, " g", " G")
                strOutput = Replace(strOutput, " h", " H")
                strOutput = Replace(strOutput, " i", " I")
                strOutput = Replace(strOutput, " j", " J")
                strOutput = Replace(strOutput, " k", " K")
                strOutput = Replace(strOutput, " l", " L")
                strOutput = Replace(strOutput, " m", " M")
                strOutput = Replace(strOutput, " n", " N")
                strOutput = Replace(strOutput, " l", " L")
                strOutput = Replace(strOutput, " o", " O")
                strOutput = Replace(strOutput, " p", " P")
                strOutput = Replace(strOutput, " q", " Q")
                strOutput = Replace(strOutput, " r", " R")
                strOutput = Replace(strOutput, " s", " S")
                strOutput = Replace(strOutput, " t", " T")
                strOutput = Replace(strOutput, " u", " U")
                strOutput = Replace(strOutput, " v", " V")
                strOutput = Replace(strOutput, " w", " W")
                strOutput = Replace(strOutput, " x", " X")
                strOutput = Replace(strOutput, " y", " Y")
                strOutput = Replace(strOutput, " z", " Z")
            ElseIf FormCustom.radbutCapitalizationInverted.Checked = True Then
                'Tavros's code here
                strOutput = StrConv(strInput, vbProperCase)

                Dim strInputInvert As String
                Dim stroutputInvert As String
                Dim intInvert As Integer
                intInvert = strInput.Length - 1
                strInputInvert = strInput.Substring(0, 1)
                stroutputInvert = strInput.Substring(1, intInvert)

                strInputInvert = StrConv(strInputInvert, vbLowerCase)
                stroutputInvert = StrConv(stroutputInvert, vbUpperCase)
                strOutput = Replace(strOutput, ". A", ". a")
                strOutput = Replace(strOutput, ". B", ". b")
                strOutput = Replace(strOutput, ". C", ". c")
                strOutput = Replace(strOutput, ". D", ". d")
                strOutput = Replace(strOutput, ". E", ". e")
                strOutput = Replace(strOutput, ". F", ". f")
                strOutput = Replace(strOutput, ". G", ". g")
                strOutput = Replace(strOutput, ". H", ". h")
                strOutput = Replace(strOutput, ". I", ". i")
                strOutput = Replace(strOutput, ". J", ". j")
                strOutput = Replace(strOutput, ". K", ". k")
                strOutput = Replace(strOutput, ". L", ". l")
                strOutput = Replace(strOutput, ". M", ". m")
                strOutput = Replace(strOutput, ". N", ". n")
                strOutput = Replace(strOutput, ". L", ". l")
                strOutput = Replace(strOutput, ". O", ". o")
                strOutput = Replace(strOutput, ". P", ". p")
                strOutput = Replace(strOutput, ". Q", ". q")
                strOutput = Replace(strOutput, ". R", ". r")
                strOutput = Replace(strOutput, ". S", ". s")
                strOutput = Replace(strOutput, ". T", ". t")
                strOutput = Replace(strOutput, ". U", ". u")
                strOutput = Replace(strOutput, ". V", ". v")
                strOutput = Replace(strOutput, ". W", ". w")
                strOutput = Replace(strOutput, ". X", ". x")
                strOutput = Replace(strOutput, ". Y", ". y")
                strOutput = Replace(strOutput, ". Z", ". z")
            ElseIf FormCustom.radbutCapitalizationAlternating.Checked = True Then
                'Gamzee's code here
                strOutput = Replace(strInput, " ", "  ")
                strOutput = AltCap(strOutput)
                strOutput = Replace(strOutput, "  ", " ")
            End If

            If FormCustom.chboxPunctuationStandard.Checked = True Then
                'Nothing
            End If
            If FormCustom.chboxPunctuationExclamation.Checked = False And FormCustom.chboxPunctuationStandard.Checked = False Then
                strOutput = Replace(strOutput, "!", ".")
            End If
            If FormCustom.chboxPunctuationQuestion.Checked = False And FormCustom.chboxPunctuationStandard.Checked = False Then
                strOutput = Replace(strOutput, "?", ".")
            End If
            If FormCustom.chboxPunctuationPeriod.Checked = False And FormCustom.chboxPunctuationStandard.Checked = False Then
                strOutput = Replace(strOutput, ".", "")
            End If

            strOutput = Replace(strOutput, strReplaceBefore1, strReplaceAfter1)
            strOutput = Replace(strOutput, strReplaceBefore2, strReplaceAfter2)
            strOutput = Replace(strOutput, strReplaceBefore3, strReplaceAfter3)
            strOutput = Replace(strOutput, strReplaceBefore4, strReplaceAfter4)
            strOutput = Replace(strOutput, strReplaceBefore5, strReplaceAfter5)
            strOutput = Replace(strOutput, strReplaceBefore6, strReplaceAfter6)
            strOutput = Replace(strOutput, strReplaceBefore7, strReplaceAfter7)
            strOutput = Replace(strOutput, strReplaceBefore8, strReplaceAfter8)
            strOutput = Replace(strOutput, strReplaceBefore9, strReplaceAfter9)
            strOutput = Replace(strOutput, strReplaceBefore10, strReplaceAfter10)
            strOutput = Replace(strOutput, strReplaceBefore11, strReplaceAfter11)
            strOutput = Replace(strOutput, strReplaceBefore12, strReplaceAfter12)

            If FormCustom.chboxOtherReverse.Checked = True Then
                strOutput = StrReverse(strOutput)
            End If

            tboxOutput.Text = strPrefix & strOutput & strSuffix

            tboxOutput.ForeColor = FormCustom.ColorDialog1.Color
            tboxOutput.Font = FormCustom.FontDialog1.Font

        Else 'tboxOutput.Text = "WHY! ISN'T! THIS! WORKING!" & vbNewLine & "(Hint: Click on one of the profile buttons.)"
            tboxOutput.Text = "(Hint: Click on one of the profile buttons.)"
        End If

    End Sub

    Private Sub butProfiles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butProfiles.Click

        FormProfiles.Show()
        Me.Hide()

    End Sub

    Private Sub butCustom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butCustom.Click

        FormCustom.Show()
        Me.Hide()

    End Sub

    Private Sub butChangelog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butChangelog.Click

        FormChangelog.Show()
        Me.Hide()

    End Sub

    Private Sub butCredits_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butCredits.Click

        FormCredits.Show()
        Me.Hide()

    End Sub

    Private Sub butExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butExit.Click

        FormProfiles.Close()
        FormCustom.Close()
        FormChangelog.Close()
        FormCredits.Close()
        FormContact.Close()
        Me.Close()

    End Sub

    Private Sub butContact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butContact.Click

        FormContact.Show()
        Me.Hide()

    End Sub
End Class
