Public Class Form10
    Private n1, n2 As Integer '
    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        n1 = 0
        n2 = 0

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        tb3.Text = n1 + n2

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        tb3.Text = n1 - n2
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        tb3.Text = n1 * n2
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        tb3.Text = n1 / n2
    End Sub

    Private Sub tb1_TextChanged(sender As Object, e As EventArgs) Handles tb1.TextChanged
        n1 = Val(tb1.Text)
    End Sub

    Private Sub tb2_TextChanged(sender As Object, e As EventArgs) Handles tb2.TextChanged
        n2 = Val(tb2.Text)

    End Sub
End Class