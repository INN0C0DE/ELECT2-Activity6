Public Class Form11
    Private n1, n2 As Integer

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        n1 = 0
        n2 = 0

    End Sub

    Private Sub tb1_TextChanged(sender As Object, e As EventArgs) Handles tb1.TextChanged
        n1 = Val(tb1.Text)


    End Sub

    Private Sub tb2_TextChanged(sender As Object, e As EventArgs) Handles tb2.TextChanged
        n2 = Val(tb2.Text)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tb3.Text = n1 + n2
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        tb3.Text = n1 - n2
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        tb3.Text = n1 * n2
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        tb3.Text = n1 / n2
    End Sub
End Class