Public Class Form12

    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            CheckBox1.Checked = True
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
            CheckBox5.Checked = True
            CheckBox6.Checked = False

            tb1.Text = "1,500"

        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            CheckBox1.Checked = True
            CheckBox2.Checked = True
            CheckBox3.Checked = False
            CheckBox4.Checked = True
            CheckBox5.Checked = True
            CheckBox6.Checked = False

            tb1.Text = "1,700"
        End If

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            CheckBox1.Checked = True
            CheckBox2.Checked = True
            CheckBox3.Checked = True
            CheckBox4.Checked = True
            CheckBox5.Checked = True
            CheckBox6.Checked = True

            tb1.Text = "2,000"
        End If
    End Sub
End Class