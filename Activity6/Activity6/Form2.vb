Public Class Form2

    Private Sub tb1_TextChanged(sender As Object, e As EventArgs) Handles tb1.TextChanged
        If tb1.Text = "A" Or tb1.Text = "a" Then
            tb2.Text = "It's a Vowel!"
        ElseIf tb1.Text = "E" Or tb1.Text = "e" Then
            tb2.Text = "It's a Vowel!"
        ElseIf tb1.Text = "I" Or tb1.Text = "i" Then
            tb2.Text = "It's a Vowel!"
        ElseIf tb1.Text = "O" Or tb1.Text = "o" Then
            tb2.Text = "It's a Vowel!"
        ElseIf tb1.Text = "U" Or tb1.Text = "u" Then
            tb2.Text = "It's a Vowel!"
        ElseIf tb1.Text = "" Or tb1.Text = "" Then
            tb2.Text = ""
        Else
            tb2.Text = "It's a Consonant!"
        End If
    End Sub
End Class