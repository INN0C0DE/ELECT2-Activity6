Public Class Form6
    Private letter As String

    Private Sub tb1_TextChanged(sender As Object, e As EventArgs) Handles tb1.TextChanged
        letter = tb1.Text

        Select Case letter
            Case "B", "b"
                tb2.Text = "Battleship!"
            Case "C", "c"
                tb2.Text = "Cruiser!"
            Case "D", "d"
                tb2.Text = "Destroyer!"
            Case "F", "f"
                tb2.Text = "Frigate!"
            Case Else
                tb2.Text = ""
        End Select
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tb2_TextChanged(sender As Object, e As EventArgs) Handles tb2.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class