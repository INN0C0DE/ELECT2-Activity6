Public Class Form3
    Private temp As Double

    Private Sub tb1_TextChanged(sender As Object, e As EventArgs) Handles tb1.TextChanged
        temp = Val(tb1.Text)

        If temp < 0 Then
            tb2.Text = "ICE!"
        ElseIf temp >= 0 And temp <= 100 Then
            tb2.Text = "WATER!"
        ElseIf temp > 100 Then
            tb2.Text = "STEAM!"
        Else
            tb2.Text = ""
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub tb2_TextChanged(sender As Object, e As EventArgs) Handles tb2.TextChanged

    End Sub
End Class