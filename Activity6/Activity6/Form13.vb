Public Class Form13
    Private n1, cash, twoGives, threeGives As Integer

    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tb1_TextChanged(sender As Object, e As EventArgs) Handles tb1.TextChanged
        n1 = Val(tb1.Text)
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If rb1.Checked = True Then
            cash = n1 * 0.1
            tb2.Text = n1 - cash
        ElseIf rb2.Checked = True Then
            twoGives = n1 * 0.05
            tb2.Text = n1 + twoGives
        ElseIf rb3.Checked = True Then
            threeGives = n1 * 0.1
            tb2.Text = n1 + threeGives
        End If
    End Sub
End Class