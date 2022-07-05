Public Class Form7

    Private Sub tb1_TextChanged(sender As Object, e As EventArgs) Handles tb1.TextChanged
        If tb1.Text = "" Then
            tb2.Text = ""
            ElseIf Val(tb1.Text) < 5 Then
                tb2.Text = "Little or No Damage!"
            ElseIf Val(tb1.Text) >= 5 And Val(tb1.Text) <= 5.5 Then
                tb2.Text = "Some Damage!"
            ElseIf Val(tb1.Text) >= 5.6 And Val(tb1.Text) <= 6.5 Then
                tb2.Text = "Serious Damage!"
            ElseIf Val(tb1.Text) >= 6.6 And Val(tb1.Text) <= 7.5 Then
                tb2.Text = "Disaster!"
            ElseIf Val(tb1.Text) > 7.5 Then
                tb2.Text = "Catastrophe!"
        End If
    End Sub
End Class