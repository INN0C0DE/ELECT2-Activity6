Public Class Form5

    Private Sub tb1_TextChanged(sender As Object, e As EventArgs) Handles tb1.TextChanged
        If tb1.Text = "B" Or tb1.Text = "b" Then
            tb2.Text = "Battleship!"
        ElseIf tb1.Text = "C" Or tb1.Text = "c" Then
            tb2.Text = "Cruiser!"
        ElseIf tb1.Text = "D" Or tb1.Text = "d" Then
            tb2.Text = "Destroyer!"
        ElseIf tb1.Text = "F" Or tb1.Text = "f" Then
            tb2.Text = "Frigate!"
        Else
            tb2.Text = ""
        End If
    End Sub
End Class