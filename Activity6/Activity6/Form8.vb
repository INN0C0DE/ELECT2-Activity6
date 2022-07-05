Public Class Form8

    Private Sub tb1_TextChanged(sender As Object, e As EventArgs) Handles tb1.TextChanged
        If tb1.Text = "" Then
            tb2.Text = ""
        ElseIf Val(tb1.Text) >= 98 And Val(tb1.Text) <= 100 Then
            tb2.Text = "1.00"
        ElseIf Val(tb1.Text) >= 95 And Val(tb1.Text) <= 97.99 Then
            tb2.Text = "1.25"
        ElseIf Val(tb1.Text) >= 92 And Val(tb1.Text) <= 94.99 Then
            tb2.Text = "1.50"
        ElseIf Val(tb1.Text) >= 89 And Val(tb1.Text) <= 91.99 Then
            tb2.Text = "1.75"
        ElseIf Val(tb1.Text) >= 85 And Val(tb1.Text) <= 88.99 Then
            tb2.Text = "2.00"
        ElseIf Val(tb1.Text) >= 82 And Val(tb1.Text) <= 84.99 Then
            tb2.Text = "2.25"
        ElseIf Val(tb1.Text) >= 80 And Val(tb1.Text) <= 81.99 Then
            tb2.Text = "2.50"
        ElseIf Val(tb1.Text) >= 77 And Val(tb1.Text) <= 79.99 Then
            tb2.Text = "2.75"
        ElseIf Val(tb1.Text) >= 75 And Val(tb1.Text) <= 76.99 Then
            tb2.Text = "3.00"
        Else
            tb2.Text = "Out-Of-Range"
        End If
    End Sub
End Class