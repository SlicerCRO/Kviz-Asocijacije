<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PocetniIzbornik
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PocetniIzbornik))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Izlaz = New System.Windows.Forms.Label()
        Me.Naslov = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.UnosTablice = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Opcije = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.IzlazToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.Opcije.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(6, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pokreni novi kviz"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Impact", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(6, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(433, 45)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Pogledaj ljestvicu najboljih"
        '
        'Izlaz
        '
        Me.Izlaz.AutoSize = True
        Me.Izlaz.Font = New System.Drawing.Font("Impact", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Izlaz.ForeColor = System.Drawing.Color.Navy
        Me.Izlaz.Location = New System.Drawing.Point(6, 328)
        Me.Izlaz.Name = "Izlaz"
        Me.Izlaz.Size = New System.Drawing.Size(272, 45)
        Me.Izlaz.TabIndex = 2
        Me.Izlaz.Text = "Izlaz iz programa"
        '
        'Naslov
        '
        Me.Naslov.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Naslov.AutoSize = True
        Me.Naslov.Font = New System.Drawing.Font("Segoe Script", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Naslov.ForeColor = System.Drawing.Color.Navy
        Me.Naslov.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Naslov.Location = New System.Drawing.Point(217, 9)
        Me.Naslov.Name = "Naslov"
        Me.Naslov.Size = New System.Drawing.Size(697, 102)
        Me.Naslov.TabIndex = 3
        Me.Naslov.Text = "KVIZ ASOCIJACIJE"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.GroupBox1.Controls.Add(Me.UnosTablice)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Izlaz)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(301, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(485, 386)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Izbornik:"
        '
        'UnosTablice
        '
        Me.UnosTablice.AutoSize = True
        Me.UnosTablice.Font = New System.Drawing.Font("Impact", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnosTablice.ForeColor = System.Drawing.Color.Navy
        Me.UnosTablice.Location = New System.Drawing.Point(6, 256)
        Me.UnosTablice.Name = "UnosTablice"
        Me.UnosTablice.Size = New System.Drawing.Size(298, 45)
        Me.UnosTablice.TabIndex = 4
        Me.UnosTablice.Text = "Unesi novu tablicu"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Impact", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(6, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(472, 45)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Promijeni detalje natjecatelja"
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
        Me.Opcije.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IzlazToolStripMenuItem1})
        Me.Opcije.Name = "Opcije"
        Me.Opcije.Size = New System.Drawing.Size(163, 26)
        Me.Opcije.Text = "Opcije"
        '
        'IzlazToolStripMenuItem1
        '
        Me.IzlazToolStripMenuItem1.Name = "IzlazToolStripMenuItem1"
        Me.IzlazToolStripMenuItem1.Size = New System.Drawing.Size(162, 22)
        Me.IzlazToolStripMenuItem1.Text = "Izlaz iz programa"
        '
        'PocetniIzbornik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1112, 569)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Naslov)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "PocetniIzbornik"
        Me.Text = "PocetniIzbornik"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Opcije.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Izlaz As System.Windows.Forms.Label
    Friend WithEvents Naslov As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents UnosTablice As System.Windows.Forms.Label
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents Opcije As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents IzlazToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
