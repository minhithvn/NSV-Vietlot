Module number
    Dim words, output As String
    Dim count = 0
    Dim letters As Array = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
    words = UCase(textbox1.Text)
    For Each x In letters
    For Each i In words
    If x = i Then
                count = count + 1
            End If
    Next
    If count <> 0 Then
            output = output & (x & " = " & count) & vbCrLf
            textOutputBox.Text = output
            letterReplaceBox.Text = words
        End If
        count = 0
    Next
End Module
