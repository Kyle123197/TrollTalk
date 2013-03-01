Module Module1

    Public strPrefix As String
    Public strSuffix As String
    Public strReplaceBefore1 As String
    Public strReplaceBefore2 As String
    Public strReplaceBefore3 As String
    Public strReplaceBefore4 As String
    Public strReplaceBefore5 As String
    Public strReplaceBefore6 As String
    Public strReplaceBefore7 As String
    Public strReplaceBefore8 As String
    Public strReplaceBefore9 As String
    Public strReplaceBefore10 As String
    Public strReplaceBefore11 As String
    Public strReplaceBefore12 As String
    Public strReplaceAfter1 As String
    Public strReplaceAfter2 As String
    Public strReplaceAfter3 As String
    Public strReplaceAfter4 As String
    Public strReplaceAfter5 As String
    Public strReplaceAfter6 As String
    Public strReplaceAfter7 As String
    Public strReplaceAfter8 As String
    Public strReplaceAfter9 As String
    Public strReplaceAfter10 As String
    Public strReplaceAfter11 As String
    Public strReplaceAfter12 As String

    Public Function AltCap(ByRef strAlternatingCaps As String) As String

        Dim intAlternatingCaps As Integer, StrCurrentCharacter As String
        For intAlternatingCaps = 1 To Len(strAlternatingCaps)

            StrCurrentCharacter = Mid(strAlternatingCaps, intAlternatingCaps, 1)

            If intAlternatingCaps Mod 2 = 0 Then
                Mid(strAlternatingCaps, intAlternatingCaps, 1) = LCase(StrCurrentCharacter)
            Else
                Mid(strAlternatingCaps, intAlternatingCaps, 1) = UCase(StrCurrentCharacter)
            End If

        Next intAlternatingCaps
        AltCap = strAlternatingCaps

    End Function

End Module
