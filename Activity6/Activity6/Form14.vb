Public Class Form14
    Private noExam As Integer

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles cb4.CheckedChanged

    End Sub

    Private Sub rb1_CheckedChanged(sender As Object, e As EventArgs) Handles rb1.CheckedChanged
        If rb1.Checked = True Then
            cb1.Checked = True
            cb2.Checked = False
            cb3.Checked = True
            cb4.Checked = False
        End If
    End Sub

    Private Sub tb2_TextChanged(sender As Object, e As EventArgs) Handles tb2.TextChanged

    End Sub

    Private Sub tb1_TextChanged(sender As Object, e As EventArgs) Handles tb1.TextChanged
        noExam = Val(tb1.Text)

    End Sub

    Private Sub rb2_CheckedChanged(sender As Object, e As EventArgs) Handles rb2.CheckedChanged
        If rb2.Checked = True Then
            cb1.Checked = False
            cb2.Checked = False
            cb3.Checked = True
            cb4.Checked = False
        End If
    End Sub

    Private Sub rb3_CheckedChanged(sender As Object, e As EventArgs) Handles rb3.CheckedChanged
        If rb3.Checked = True Then
            cb1.Checked = True
            cb2.Checked = True
            cb3.Checked = True
            cb4.Checked = True
        End If
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If rb1.Checked = True Then
            tb2.Text = noExam * 12000
        ElseIf rb2.Checked = True Then
            tb2.Text = noExam * 1000
        ElseIf rb3.Checked = True Then
            tb2.Text = noExam * 700
        End If
    End Sub

    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
End Class