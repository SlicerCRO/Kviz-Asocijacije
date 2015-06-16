<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Start = New System.Windows.Forms.Button
        Me.Unos = New System.Windows.Forms.Button
        Me.Igrac1 = New System.Windows.Forms.ComboBox
        Me.Igrac2 = New System.Windows.Forms.ComboBox
        Me.Igrac3 = New System.Windows.Forms.ComboBox
        Me.Igrac4 = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(307, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Odaberite natjecatelje:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Igrač 1:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Igrač 2:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Igrač 3:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 24)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Igrač 4:"
        '
        'Start
        '
        Me.Start.DialogResult = System.Windows.Forms.DialogResult.No
        Me.Start.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Start.Location = New System.Drawing.Point(12, 212)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(357, 30)
        Me.Start.TabIndex = 9
        Me.Start.Text = "Započnite s igrom!"
        Me.Start.UseVisualStyleBackColor = True
        '
        'Unos
        '
        Me.Unos.DialogResult = System.Windows.Forms.DialogResult.No
        Me.Unos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Unos.Location = New System.Drawing.Point(11, 180)
        Me.Unos.Name = "Unos"
        Me.Unos.Size = New System.Drawing.Size(182, 26)
        Me.Unos.TabIndex = 10
        Me.Unos.Text = "Unesite novog natjecatelja"
        Me.Unos.UseVisualStyleBackColor = True
        '
        'Igrac1
        '
        Me.Igrac1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Igrac1.FormattingEnabled = True
        Me.Igrac1.Location = New System.Drawing.Point(84, 45)
        Me.Igrac1.Name = "Igrac1"
        Me.Igrac1.Size = New System.Drawing.Size(284, 24)
        Me.Igrac1.TabIndex = 11
        '
        'Igrac2
        '
        Me.Igrac2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Igrac2.FormattingEnabled = True
        Me.Igrac2.Location = New System.Drawing.Point(84, 80)
        Me.Igrac2.Name = "Igrac2"
        Me.Igrac2.Size = New System.Drawing.Size(284, 24)
        Me.Igrac2.TabIndex = 12
        '
        'Igrac3
        '
        Me.Igrac3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Igrac3.FormattingEnabled = True
        Me.Igrac3.Location = New System.Drawing.Point(84, 115)
        Me.Igrac3.Name = "Igrac3"
        Me.Igrac3.Size = New System.Drawing.Size(283, 24)
        Me.Igrac3.TabIndex = 13
        '
        'Igrac4
        '
        Me.Igrac4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Igrac4.FormattingEnabled = True
        Me.Igrac4.Location = New System.Drawing.Point(85, 150)
        Me.Igrac4.Name = "Igrac4"
        Me.Igrac4.Size = New System.Drawing.Size(283, 24)
        Me.Igrac4.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.No
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Button1.Location = New System.Drawing.Point(199, 180)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(170, 26)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Povratak na izbornik"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 248)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Igrac4)
        Me.Controls.Add(Me.Igrac3)
        Me.Controls.Add(Me.Igrac2)
        Me.Controls.Add(Me.Igrac1)
        Me.Controls.Add(Me.Unos)
        Me.Controls.Add(Me.Start)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form7"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form7"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Start As System.Windows.Forms.Button
    Friend WithEvents Unos As System.Windows.Forms.Button
    Friend WithEvents Igrac1 As System.Windows.Forms.ComboBox
    Friend WithEvents Igrac2 As System.Windows.Forms.ComboBox
    Friend WithEvents Igrac3 As System.Windows.Forms.ComboBox
    Friend WithEvents Igrac4 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
