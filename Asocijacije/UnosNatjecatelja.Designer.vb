<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UnosNatjecatelja
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
        Dim ImePrezimeLabel As System.Windows.Forms.Label
        Dim DatumRodjenjaLabel As System.Windows.Forms.Label
        Dim AdresaStanovanjaLabel As System.Windows.Forms.Label
        Dim MjestoStanovanjaLabel As System.Windows.Forms.Label
        Dim TelefonLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim PostaLabel As System.Windows.Forms.Label
        Me.SifraNatjecateljaTextBox = New System.Windows.Forms.TextBox
        Me.Unos = New System.Windows.Forms.Button
        Me.ImePrezimeTextBox = New System.Windows.Forms.TextBox
        Me.DatumRodjenjaDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.AdresaStanovanjaTextBox = New System.Windows.Forms.TextBox
        Me.MjestoStanovanjaTextBox = New System.Windows.Forms.TextBox
        Me.TelefonTextBox = New System.Windows.Forms.TextBox
        Me.EmailTextBox = New System.Windows.Forms.TextBox
        Me.PostaTextBox = New System.Windows.Forms.TextBox
        Me.Odustani = New System.Windows.Forms.Button
        ImePrezimeLabel = New System.Windows.Forms.Label
        DatumRodjenjaLabel = New System.Windows.Forms.Label
        AdresaStanovanjaLabel = New System.Windows.Forms.Label
        MjestoStanovanjaLabel = New System.Windows.Forms.Label
        TelefonLabel = New System.Windows.Forms.Label
        EmailLabel = New System.Windows.Forms.Label
        PostaLabel = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'ImePrezimeLabel
        '
        ImePrezimeLabel.AutoSize = True
        ImePrezimeLabel.Location = New System.Drawing.Point(15, 24)
        ImePrezimeLabel.Name = "ImePrezimeLabel"
        ImePrezimeLabel.Size = New System.Drawing.Size(72, 13)
        ImePrezimeLabel.TabIndex = 24
        ImePrezimeLabel.Text = "Ime i Prezime:"
        '
        'DatumRodjenjaLabel
        '
        DatumRodjenjaLabel.AutoSize = True
        DatumRodjenjaLabel.Location = New System.Drawing.Point(15, 51)
        DatumRodjenjaLabel.Name = "DatumRodjenjaLabel"
        DatumRodjenjaLabel.Size = New System.Drawing.Size(85, 13)
        DatumRodjenjaLabel.TabIndex = 26
        DatumRodjenjaLabel.Text = "Datum Rođenja:"
        '
        'AdresaStanovanjaLabel
        '
        AdresaStanovanjaLabel.AutoSize = True
        AdresaStanovanjaLabel.Location = New System.Drawing.Point(15, 76)
        AdresaStanovanjaLabel.Name = "AdresaStanovanjaLabel"
        AdresaStanovanjaLabel.Size = New System.Drawing.Size(100, 13)
        AdresaStanovanjaLabel.TabIndex = 28
        AdresaStanovanjaLabel.Text = "Adresa Stanovanja:"
        '
        'MjestoStanovanjaLabel
        '
        MjestoStanovanjaLabel.AutoSize = True
        MjestoStanovanjaLabel.Location = New System.Drawing.Point(15, 128)
        MjestoStanovanjaLabel.Name = "MjestoStanovanjaLabel"
        MjestoStanovanjaLabel.Size = New System.Drawing.Size(98, 13)
        MjestoStanovanjaLabel.TabIndex = 30
        MjestoStanovanjaLabel.Text = "Mjesto Stanovanja:"
        '
        'TelefonLabel
        '
        TelefonLabel.AutoSize = True
        TelefonLabel.Location = New System.Drawing.Point(15, 154)
        TelefonLabel.Name = "TelefonLabel"
        TelefonLabel.Size = New System.Drawing.Size(46, 13)
        TelefonLabel.TabIndex = 32
        TelefonLabel.Text = "Telefon:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(15, 180)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 34
        EmailLabel.Text = "Email:"
        '
        'PostaLabel
        '
        PostaLabel.AutoSize = True
        PostaLabel.Location = New System.Drawing.Point(15, 102)
        PostaLabel.Name = "PostaLabel"
        PostaLabel.Size = New System.Drawing.Size(37, 13)
        PostaLabel.TabIndex = 36
        PostaLabel.Text = "Pošta:"
        '
        'SifraNatjecateljaTextBox
        '
        Me.SifraNatjecateljaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.SifraNatjecateljaTextBox.Location = New System.Drawing.Point(355, -7)
        Me.SifraNatjecateljaTextBox.Name = "SifraNatjecateljaTextBox"
        Me.SifraNatjecateljaTextBox.Size = New System.Drawing.Size(10, 10)
        Me.SifraNatjecateljaTextBox.TabIndex = 39
        '
        'Unos
        '
        Me.Unos.Location = New System.Drawing.Point(158, 213)
        Me.Unos.Name = "Unos"
        Me.Unos.Size = New System.Drawing.Size(207, 23)
        Me.Unos.TabIndex = 38
        Me.Unos.Text = "Unesi novog natjecatelja"
        Me.Unos.UseVisualStyleBackColor = True
        '
        'ImePrezimeTextBox
        '
        Me.ImePrezimeTextBox.Location = New System.Drawing.Point(125, 21)
        Me.ImePrezimeTextBox.Name = "ImePrezimeTextBox"
        Me.ImePrezimeTextBox.Size = New System.Drawing.Size(240, 20)
        Me.ImePrezimeTextBox.TabIndex = 25
        '
        'DatumRodjenjaDateTimePicker
        '
        Me.DatumRodjenjaDateTimePicker.Location = New System.Drawing.Point(125, 47)
        Me.DatumRodjenjaDateTimePicker.Name = "DatumRodjenjaDateTimePicker"
        Me.DatumRodjenjaDateTimePicker.Size = New System.Drawing.Size(240, 20)
        Me.DatumRodjenjaDateTimePicker.TabIndex = 27
        '
        'AdresaStanovanjaTextBox
        '
        Me.AdresaStanovanjaTextBox.Location = New System.Drawing.Point(125, 73)
        Me.AdresaStanovanjaTextBox.Name = "AdresaStanovanjaTextBox"
        Me.AdresaStanovanjaTextBox.Size = New System.Drawing.Size(240, 20)
        Me.AdresaStanovanjaTextBox.TabIndex = 29
        '
        'MjestoStanovanjaTextBox
        '
        Me.MjestoStanovanjaTextBox.Location = New System.Drawing.Point(125, 125)
        Me.MjestoStanovanjaTextBox.Name = "MjestoStanovanjaTextBox"
        Me.MjestoStanovanjaTextBox.Size = New System.Drawing.Size(240, 20)
        Me.MjestoStanovanjaTextBox.TabIndex = 31
        '
        'TelefonTextBox
        '
        Me.TelefonTextBox.Location = New System.Drawing.Point(125, 151)
        Me.TelefonTextBox.Name = "TelefonTextBox"
        Me.TelefonTextBox.Size = New System.Drawing.Size(240, 20)
        Me.TelefonTextBox.TabIndex = 33
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(125, 177)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(240, 20)
        Me.EmailTextBox.TabIndex = 35
        '
        'PostaTextBox
        '
        Me.PostaTextBox.Location = New System.Drawing.Point(125, 99)
        Me.PostaTextBox.Name = "PostaTextBox"
        Me.PostaTextBox.Size = New System.Drawing.Size(240, 20)
        Me.PostaTextBox.TabIndex = 37
        '
        'Odustani
        '
        Me.Odustani.Location = New System.Drawing.Point(18, 213)
        Me.Odustani.Name = "Odustani"
        Me.Odustani.Size = New System.Drawing.Size(134, 23)
        Me.Odustani.TabIndex = 40
        Me.Odustani.Text = "Odustani"
        Me.Odustani.UseVisualStyleBackColor = True
        '
        'UnosNatjecatelja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 248)
        Me.Controls.Add(Me.Odustani)
        Me.Controls.Add(Me.SifraNatjecateljaTextBox)
        Me.Controls.Add(Me.Unos)
        Me.Controls.Add(ImePrezimeLabel)
        Me.Controls.Add(Me.ImePrezimeTextBox)
        Me.Controls.Add(DatumRodjenjaLabel)
        Me.Controls.Add(Me.DatumRodjenjaDateTimePicker)
        Me.Controls.Add(AdresaStanovanjaLabel)
        Me.Controls.Add(Me.AdresaStanovanjaTextBox)
        Me.Controls.Add(MjestoStanovanjaLabel)
        Me.Controls.Add(Me.MjestoStanovanjaTextBox)
        Me.Controls.Add(TelefonLabel)
        Me.Controls.Add(Me.TelefonTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(PostaLabel)
        Me.Controls.Add(Me.PostaTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(200, 700)
        Me.Name = "UnosNatjecatelja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UnosNatjecatelja"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SifraNatjecateljaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Unos As System.Windows.Forms.Button
    Friend WithEvents ImePrezimeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DatumRodjenjaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents AdresaStanovanjaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MjestoStanovanjaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PostaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Odustani As System.Windows.Forms.Button
End Class
