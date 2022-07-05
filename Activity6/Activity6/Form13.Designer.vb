<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form13
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form13))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rb3 = New System.Windows.Forms.RadioButton()
        Me.rb2 = New System.Windows.Forms.RadioButton()
        Me.rb1 = New System.Windows.Forms.RadioButton()
        Me.tb1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.tb2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb3)
        Me.GroupBox1.Controls.Add(Me.rb2)
        Me.GroupBox1.Controls.Add(Me.rb1)
        Me.GroupBox1.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(225, 209)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MODE OF PAYMENTS:"
        '
        'rb3
        '
        Me.rb3.AutoSize = True
        Me.rb3.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb3.Location = New System.Drawing.Point(21, 141)
        Me.rb3.Name = "rb3"
        Me.rb3.Size = New System.Drawing.Size(158, 60)
        Me.rb3.TabIndex = 2
        Me.rb3.TabStop = True
        Me.rb3.Text = "Three Payments" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(10% interest)"
        Me.rb3.UseVisualStyleBackColor = True
        '
        'rb2
        '
        Me.rb2.AutoSize = True
        Me.rb2.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb2.Location = New System.Drawing.Point(21, 75)
        Me.rb2.Name = "rb2"
        Me.rb2.Size = New System.Drawing.Size(145, 60)
        Me.rb2.TabIndex = 1
        Me.rb2.TabStop = True
        Me.rb2.Text = "Two Payments" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(5% interest)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.rb2.UseVisualStyleBackColor = True
        '
        'rb1
        '
        Me.rb1.AutoSize = True
        Me.rb1.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb1.Location = New System.Drawing.Point(21, 37)
        Me.rb1.Name = "rb1"
        Me.rb1.Size = New System.Drawing.Size(189, 32)
        Me.rb1.TabIndex = 0
        Me.rb1.TabStop = True
        Me.rb1.Text = "Cash (10% discount)"
        Me.rb1.UseVisualStyleBackColor = True
        '
        'tb1
        '
        Me.tb1.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb1.Location = New System.Drawing.Point(260, 62)
        Me.tb1.Name = "tb1"
        Me.tb1.Size = New System.Drawing.Size(133, 31)
        Me.tb1.TabIndex = 18
        Me.tb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(255, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 28)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Enter tuition fee:"
        '
        'btn1
        '
        Me.btn1.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.Location = New System.Drawing.Point(260, 99)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(133, 39)
        Me.btn1.TabIndex = 19
        Me.btn1.Text = "COMPUTE"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'tb2
        '
        Me.tb2.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb2.Location = New System.Drawing.Point(249, 195)
        Me.tb2.Name = "tb2"
        Me.tb2.Size = New System.Drawing.Size(159, 31)
        Me.tb2.TabIndex = 21
        Me.tb2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(243, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 28)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Your total tuition fee:"
        '
        'Form13
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(422, 252)
        Me.Controls.Add(Me.tb2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.tb1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form13"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tuition Fee Assessment System"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rb3 As System.Windows.Forms.RadioButton
    Friend WithEvents rb2 As System.Windows.Forms.RadioButton
    Friend WithEvents rb1 As System.Windows.Forms.RadioButton
    Friend WithEvents tb1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents tb2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
