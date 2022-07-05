Public Class Form9
    Private grade As Double

    Private Sub tb1_TextChanged(sender As Object, e As EventArgs) Handles tb1.TextChanged
        grade = Val(tb1.Text)
        Select Case grade
            Case 98 To 100
                tb2.Text = "1.00"
            Case 95 To 97.99
                tb2.Text = "1.25"
            Case 92 To 94.99
                tb2.Text = "1.50"
            Case 89 To 91.99
                tb2.Text = "1.75"
            Case 85 To 88.99
                tb2.Text = "2.00"
            Case 82 To 84.99
                tb2.Text = "2.25"
            Case 80 To 81.99
                tb2.Text = "2.50"
            Case 77 To 79.99
                tb2.Text = "2.75"
            Case 75 To 76.99
                tb2.Text = "3.00"
            Case Else
                tb2.Text = "Out-Of-Range!"
        End Select
    End Sub
End Class