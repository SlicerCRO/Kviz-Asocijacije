<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Natjecatelj = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Dalje = New System.Windows.Forms.Button
        Me.AsocBr = New System.Windows.Forms.Label
        Me.tmrWait = New System.Windows.Forms.Timer(Me.components)
        Me.lblRemaining = New System.Windows.Forms.Label
        Me.Button22 = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.bod04 = New System.Windows.Forms.Label
        Me.bod03 = New System.Windows.Forms.Label
        Me.bod02 = New System.Windows.Forms.Label
        Me.bod01 = New System.Windows.Forms.Label
        Me.Igrac2 = New System.Windows.Forms.Label
        Me.Igrac1 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.LabelX = New System.Windows.Forms.Label
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Opcije = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PauzaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IzlazToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.Pauza = New System.Windows.Forms.Button
        Me.PauzaSlika = New System.Windows.Forms.PictureBox
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.Igrac3 = New System.Windows.Forms.Label
        Me.Igrac4 = New System.Windows.Forms.Label
        Me.Opcije.SuspendLayout()
        CType(Me.PauzaSlika, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Natjecatelj
        '
        Me.Natjecatelj.AutoSize = True
        Me.Natjecatelj.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Natjecatelj.Location = New System.Drawing.Point(162, 551)
        Me.Natjecatelj.Name = "Natjecatelj"
        Me.Natjecatelj.Size = New System.Drawing.Size(166, 45)
        Me.Natjecatelj.TabIndex = 30
        Me.Natjecatelj.Text = "Natjecatelj"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label9.Location = New System.Drawing.Point(37, 563)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 26)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Na potezu je:"
        '
        'Dalje
        '
        Me.Dalje.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Dalje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Dalje.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Dalje.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Dalje.ForeColor = System.Drawing.Color.Black
        Me.Dalje.Location = New System.Drawing.Point(243, 604)
        Me.Dalje.Name = "Dalje"
        Me.Dalje.Size = New System.Drawing.Size(165, 51)
        Me.Dalje.TabIndex = 42
        Me.Dalje.Text = "Dalje !"
        Me.Dalje.UseVisualStyleBackColor = False
        '
        'AsocBr
        '
        Me.AsocBr.AutoSize = True
        Me.AsocBr.Font = New System.Drawing.Font("Playbill", 26.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AsocBr.Location = New System.Drawing.Point(354, 9)
        Me.AsocBr.Name = "AsocBr"
        Me.AsocBr.Size = New System.Drawing.Size(98, 35)
        Me.AsocBr.TabIndex = 43
        Me.AsocBr.Text = "Asocijacija"
        '
        'tmrWait
        '
        '
        'lblRemaining
        '
        Me.lblRemaining.AutoSize = True
        Me.lblRemaining.Font = New System.Drawing.Font("Matura MT Script Capitals", 30.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemaining.ForeColor = System.Drawing.Color.DarkRed
        Me.lblRemaining.Location = New System.Drawing.Point(471, 608)
        Me.lblRemaining.Name = "lblRemaining"
        Me.lblRemaining.Size = New System.Drawing.Size(68, 54)
        Me.lblRemaining.TabIndex = 44
        Me.lblRemaining.Text = "30"
        '
        'Button22
        '
        Me.Button22.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button22.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button22.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Button22.ForeColor = System.Drawing.Color.Black
        Me.Button22.Location = New System.Drawing.Point(605, 604)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(247, 51)
        Me.Button22.TabIndex = 45
        Me.Button22.Text = "Pokaži rješenje"
        Me.Button22.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Impact", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkRed
        Me.Label10.Location = New System.Drawing.Point(599, 560)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(258, 36)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Preostalo krugova: 2"
        '
        'bod04
        '
        Me.bod04.AutoSize = True
        Me.bod04.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.bod04.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bod04.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bod04.Location = New System.Drawing.Point(239, 120)
        Me.bod04.Name = "bod04"
        Me.bod04.Size = New System.Drawing.Size(72, 25)
        Me.bod04.TabIndex = 62
        Me.bod04.Text = "0"
        Me.bod04.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bod03
        '
        Me.bod03.AutoSize = True
        Me.bod03.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.bod03.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bod03.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bod03.Location = New System.Drawing.Point(239, 93)
        Me.bod03.Name = "bod03"
        Me.bod03.Size = New System.Drawing.Size(72, 25)
        Me.bod03.TabIndex = 61
        Me.bod03.Text = "0"
        Me.bod03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bod02
        '
        Me.bod02.AutoSize = True
        Me.bod02.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.bod02.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bod02.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bod02.Location = New System.Drawing.Point(239, 66)
        Me.bod02.Name = "bod02"
        Me.bod02.Size = New System.Drawing.Size(72, 25)
        Me.bod02.TabIndex = 60
        Me.bod02.Text = "0"
        Me.bod02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bod01
        '
        Me.bod01.AutoSize = True
        Me.bod01.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.bod01.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bod01.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bod01.Location = New System.Drawing.Point(239, 39)
        Me.bod01.Name = "bod01"
        Me.bod01.Size = New System.Drawing.Size(72, 25)
        Me.bod01.TabIndex = 59
        Me.bod01.Text = "0"
        Me.bod01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Igrac2
        '
        Me.Igrac2.AutoSize = True
        Me.Igrac2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Igrac2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Igrac2.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Igrac2.Location = New System.Drawing.Point(5, 66)
        Me.Igrac2.Name = "Igrac2"
        Me.Igrac2.Size = New System.Drawing.Size(78, 25)
        Me.Igrac2.TabIndex = 56
        Me.Igrac2.Text = "Igrač 2:"
        Me.Igrac2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Igrac1
        '
        Me.Igrac1.AutoSize = True
        Me.Igrac1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Igrac1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Igrac1.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Igrac1.ForeColor = System.Drawing.Color.Red
        Me.Igrac1.Location = New System.Drawing.Point(5, 39)
        Me.Igrac1.Name = "Igrac1"
        Me.Igrac1.Size = New System.Drawing.Size(78, 25)
        Me.Igrac1.TabIndex = 55
        Me.Igrac1.Text = "Igrač 1:"
        Me.Igrac1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label12.Location = New System.Drawing.Point(239, 14)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 20)
        Me.Label12.TabIndex = 54
        Me.Label12.Text = "Bodovi"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label13.Location = New System.Drawing.Point(5, 14)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(226, 20)
        Me.Label13.TabIndex = 53
        Me.Label13.Text = "Natjecatelji"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelX
        '
        Me.LabelX.AutoSize = True
        Me.LabelX.Font = New System.Drawing.Font("Matura MT Script Capitals", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX.ForeColor = System.Drawing.Color.DarkRed
        Me.LabelX.Location = New System.Drawing.Point(800, 541)
        Me.LabelX.Name = "LabelX"
        Me.LabelX.Size = New System.Drawing.Size(0, 39)
        Me.LabelX.TabIndex = 77
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.Opcije
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Tag = "MenuStrip1"
        Me.NotifyIcon1.Text = "Asocijacije"
        Me.NotifyIcon1.Visible = True
        '
        'Opcije
        '
        Me.Opcije.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PauzaToolStripMenuItem, Me.IzlazToolStripMenuItem1})
        Me.Opcije.Name = "Opcije"
        Me.Opcije.Size = New System.Drawing.Size(193, 48)
        Me.Opcije.Text = "Opcije"
        '
        'PauzaToolStripMenuItem
        '
        Me.PauzaToolStripMenuItem.Name = "PauzaToolStripMenuItem"
        Me.PauzaToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.PauzaToolStripMenuItem.Text = "Pauza"
        '
        'IzlazToolStripMenuItem1
        '
        Me.IzlazToolStripMenuItem1.Name = "IzlazToolStripMenuItem1"
        Me.IzlazToolStripMenuItem1.Size = New System.Drawing.Size(192, 22)
        Me.IzlazToolStripMenuItem1.Text = "Izlaz iz trenutnog kviza"
        '
        'Pauza
        '
        Me.Pauza.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Pauza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Pauza.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Pauza.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Pauza.ForeColor = System.Drawing.Color.Black
        Me.Pauza.Location = New System.Drawing.Point(42, 604)
        Me.Pauza.Name = "Pauza"
        Me.Pauza.Size = New System.Drawing.Size(165, 51)
        Me.Pauza.TabIndex = 81
        Me.Pauza.Text = "Pauza"
        Me.Pauza.UseVisualStyleBackColor = False
        '
        'PauzaSlika
        '
        Me.PauzaSlika.BackgroundImage = Global.Asocijacije.My.Resources.Resources.asocijacijen_kutija
        Me.PauzaSlika.Image = Global.Asocijacije.My.Resources.Resources.asocijacijen_kutija
        Me.PauzaSlika.InitialImage = Global.Asocijacije.My.Resources.Resources.asocijacijen_kutija
        Me.PauzaSlika.Location = New System.Drawing.Point(12, 47)
        Me.PauzaSlika.Name = "PauzaSlika"
        Me.PauzaSlika.Size = New System.Drawing.Size(900, 652)
        Me.PauzaSlika.TabIndex = 83
        Me.PauzaSlika.TabStop = False
        Me.PauzaSlika.Visible = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.84077!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.15924!))
        Me.TableLayoutPanel1.Controls.Add(Me.Igrac3, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Igrac4, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label13, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.bod04, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.bod03, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.bod02, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.bod01, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Igrac2, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Igrac1, 0, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(917, 141)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(316, 147)
        Me.TableLayoutPanel1.TabIndex = 85
        '
        'Igrac3
        '
        Me.Igrac3.AutoSize = True
        Me.Igrac3.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Igrac3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Igrac3.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Igrac3.Location = New System.Drawing.Point(5, 93)
        Me.Igrac3.Name = "Igrac3"
        Me.Igrac3.Size = New System.Drawing.Size(78, 25)
        Me.Igrac3.TabIndex = 87
        Me.Igrac3.Text = "Igrač 3:"
        Me.Igrac3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Igrac4
        '
        Me.Igrac4.AutoSize = True
        Me.Igrac4.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Igrac4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Igrac4.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Igrac4.Location = New System.Drawing.Point(5, 120)
        Me.Igrac4.Name = "Igrac4"
        Me.Igrac4.Size = New System.Drawing.Size(78, 25)
        Me.Igrac4.TabIndex = 63
        Me.Igrac4.Text = "Igrač 4:"
        Me.Igrac4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1272, 860)
        Me.ContextMenuStrip = Me.Opcije
        Me.Controls.Add(Me.Pauza)
        Me.Controls.Add(Me.PauzaSlika)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.AsocBr)
        Me.Controls.Add(Me.LabelX)
        Me.Controls.Add(Me.Dalje)
        Me.Controls.Add(Me.Button22)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblRemaining)
        Me.Controls.Add(Me.Natjecatelj)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Opcije.ResumeLayout(False)
        CType(Me.PauzaSlika, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Natjecatelj As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Dalje As System.Windows.Forms.Button
    Friend WithEvents AsocBr As System.Windows.Forms.Label
    Friend WithEvents tmrWait As System.Windows.Forms.Timer
    Friend WithEvents lblRemaining As System.Windows.Forms.Label
    Friend WithEvents Button22 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents bod04 As System.Windows.Forms.Label
    Friend WithEvents bod03 As System.Windows.Forms.Label
    Friend WithEvents bod02 As System.Windows.Forms.Label
    Friend WithEvents bod01 As System.Windows.Forms.Label
    Friend WithEvents Igrac2 As System.Windows.Forms.Label
    Friend WithEvents Igrac1 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents LabelX As System.Windows.Forms.Label
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents Opcije As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents IzlazToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Pauza As System.Windows.Forms.Button
    Friend WithEvents PauzaSlika As System.Windows.Forms.PictureBox
    Friend WithEvents PauzaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Igrac4 As System.Windows.Forms.Label
    Friend WithEvents Igrac3 As System.Windows.Forms.Label

End Class
