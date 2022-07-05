Public Class Form4

    Private Sub tb1_TextChanged(sender As Object, e As EventArgs) Handles tb1.TextChanged
        If tb1.Text = "" Then
            tb2.Text = ""
        ElseIf Val(tb1.Text) > 1100 Then
            tb2.Text = "It's a civilian aircraft!"
        ElseIf Val(tb1.Text) <= 1100 And Val(tb1.Text) >= 500 Then
            tb2.Text = "It's a military aircraft!"
        ElseIf Val(tb1.Text) < 500 Then
            tb2.Text = "It's a bird!"
        End If
    End Sub
End Class