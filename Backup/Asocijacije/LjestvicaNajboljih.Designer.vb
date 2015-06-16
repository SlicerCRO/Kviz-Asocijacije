<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LjestvicaNajboljih
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
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.LjestvicaDataGridView = New System.Windows.Forms.DataGridView
        Me.Button1 = New System.Windows.Forms.Button
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Mjesto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Natjecatelj = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UkupnoBodova = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PogodjenoKonacnihRjesenja = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.LjestvicaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LjestvicaDataGridView
        '
        Me.LjestvicaDataGridView.AllowUserToAddRows = False
        Me.LjestvicaDataGridView.AllowUserToDeleteRows = False
        Me.LjestvicaDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LjestvicaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LjestvicaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Mjesto, Me.Natjecatelj, Me.UkupnoBodova, Me.PogodjenoKonacnihRjesenja})
        Me.LjestvicaDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.LjestvicaDataGridView.Name = "LjestvicaDataGridView"
        Me.LjestvicaDataGridView.ReadOnly = True
        Me.LjestvicaDataGridView.Size = New System.Drawing.Size(414, 764)
        Me.LjestvicaDataGridView.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.No
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Button1.Location = New System.Drawing.Point(0, 723)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(414, 41)
        Me.Button1.TabIndex = 58
        Me.Button1.Text = "Povratak na izbornik"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(30, 707)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(180, 20)
        Me.DateTimePicker1.TabIndex = 59
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(236, 707)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(178, 20)
        Me.DateTimePicker2.TabIndex = 60
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(1, 707)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 20)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Od:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(206, 708)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 18)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Do:"
        '
        'Mjesto
        '
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Mjesto.DefaultCellStyle = DataGridViewCellStyle29
        Me.Mjesto.HeaderText = "Mjesto"
        Me.Mjesto.Name = "Mjesto"
        Me.Mjesto.ReadOnly = True
        Me.Mjesto.Width = 50
        '
        'Natjecatelj
        '
        DataGridViewCellStyle30.NullValue = "-"
        Me.Natjecatelj.DefaultCellStyle = DataGridViewCellStyle30
        Me.Natjecatelj.HeaderText = "Natjecatelj"
        Me.Natjecatelj.Name = "Natjecatelj"
        Me.Natjecatelj.ReadOnly = True
        Me.Natjecatelj.Width = 200
        '
        'UkupnoBodova
        '
        DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle31.Format = "E0"
        DataGridViewCellStyle31.NullValue = "0"
        Me.UkupnoBodova.DefaultCellStyle = DataGridViewCellStyle31
        Me.UkupnoBodova.HeaderText = "Ukupno Bodova"
        Me.UkupnoBodova.Name = "UkupnoBodova"
        Me.UkupnoBodova.ReadOnly = True
        Me.UkupnoBodova.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.UkupnoBodova.Width = 60
        '
        'PogodjenoKonacnihRjesenja
        '
        DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle32.Format = "N0"
        DataGridViewCellStyle32.NullValue = "0"
        Me.PogodjenoKonacnihRjesenja.DefaultCellStyle = DataGridViewCellStyle32
        Me.PogodjenoKonacnihRjesenja.HeaderText = "Pogođeno konačnih rješenja"
        Me.PogodjenoKonacnihRjesenja.Name = "PogodjenoKonacnihRjesenja"
        Me.PogodjenoKonacnihRjesenja.ReadOnly = True
        Me.PogodjenoKonacnihRjesenja.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.PogodjenoKonacnihRjesenja.Width = 60
        '
        'LjestvicaNajboljih
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 764)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LjestvicaDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LjestvicaNajboljih"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LjestvicaNajboljih"
        Me.TopMost = True
        CType(Me.LjestvicaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LjestvicaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Mjesto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Natjecatelj As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UkupnoBodova As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PogodjenoKonacnihRjesenja As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
