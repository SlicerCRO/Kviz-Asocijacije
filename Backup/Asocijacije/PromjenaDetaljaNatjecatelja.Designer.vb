<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PromjenaDetaljaNatjecatelja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PromjenaDetaljaNatjecatelja))
        Dim DatumRodjenjaLabel As System.Windows.Forms.Label
        Dim AdresaStanovanjaLabel As System.Windows.Forms.Label
        Dim MjestoStanovanjaLabel As System.Windows.Forms.Label
        Dim TelefonLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim PostaLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.SifraNatjecateljaTextBox = New System.Windows.Forms.TextBox
        Me.Promijeni = New System.Windows.Forms.Button
        Me.ImePrezimeTextBox = New System.Windows.Forms.TextBox
        Me.DatumRodjenjaDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.AdresaStanovanjaTextBox = New System.Windows.Forms.TextBox
        Me.MjestoStanovanjaTextBox = New System.Windows.Forms.TextBox
        Me.TelefonTextBox = New System.Windows.Forms.TextBox
        Me.EmailTextBox = New System.Windows.Forms.TextBox
        Me.PostaTextBox = New System.Windows.Forms.TextBox
        Me.Obrisi = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.AsocijacijeDataSet = New Asocijacije.AsocijacijeDataSet
        Me.NatjecateljTableAdapter = New Asocijacije.AsocijacijeDataSetTableAdapters.NatjecateljTableAdapter
        Me.TableAdapterManager = New Asocijacije.AsocijacijeDataSetTableAdapters.TableAdapterManager
        Me.NatjecateljDataGridView = New System.Windows.Forms.DataGridView
        Me.imePrezime = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.datumRodjenja = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.adresaStanovanja = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.mjestoStanovanja = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.posta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.telefon = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn
        ImePrezimeLabel = New System.Windows.Forms.Label
        DatumRodjenjaLabel = New System.Windows.Forms.Label
        AdresaStanovanjaLabel = New System.Windows.Forms.Label
        MjestoStanovanjaLabel = New System.Windows.Forms.Label
        TelefonLabel = New System.Windows.Forms.Label
        EmailLabel = New System.Windows.Forms.Label
        PostaLabel = New System.Windows.Forms.Label
        CType(Me.AsocijacijeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NatjecateljDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImePrezimeLabel
        '
        resources.ApplyResources(ImePrezimeLabel, "ImePrezimeLabel")
        ImePrezimeLabel.Name = "ImePrezimeLabel"
        '
        'DatumRodjenjaLabel
        '
        resources.ApplyResources(DatumRodjenjaLabel, "DatumRodjenjaLabel")
        DatumRodjenjaLabel.Name = "DatumRodjenjaLabel"
        '
        'AdresaStanovanjaLabel
        '
        resources.ApplyResources(AdresaStanovanjaLabel, "AdresaStanovanjaLabel")
        AdresaStanovanjaLabel.Name = "AdresaStanovanjaLabel"
        '
        'MjestoStanovanjaLabel
        '
        resources.ApplyResources(MjestoStanovanjaLabel, "MjestoStanovanjaLabel")
        MjestoStanovanjaLabel.Name = "MjestoStanovanjaLabel"
        '
        'TelefonLabel
        '
        resources.ApplyResources(TelefonLabel, "TelefonLabel")
        TelefonLabel.Name = "TelefonLabel"
        '
        'EmailLabel
        '
        resources.ApplyResources(EmailLabel, "EmailLabel")
        EmailLabel.Name = "EmailLabel"
        '
        'PostaLabel
        '
        resources.ApplyResources(PostaLabel, "PostaLabel")
        PostaLabel.Name = "PostaLabel"
        '
        'SifraNatjecateljaTextBox
        '
        resources.ApplyResources(Me.SifraNatjecateljaTextBox, "SifraNatjecateljaTextBox")
        Me.SifraNatjecateljaTextBox.Name = "SifraNatjecateljaTextBox"
        '
        'Promijeni
        '
        resources.ApplyResources(Me.Promijeni, "Promijeni")
        Me.Promijeni.Name = "Promijeni"
        Me.Promijeni.UseVisualStyleBackColor = True
        '
        'ImePrezimeTextBox
        '
        resources.ApplyResources(Me.ImePrezimeTextBox, "ImePrezimeTextBox")
        Me.ImePrezimeTextBox.Name = "ImePrezimeTextBox"
        '
        'DatumRodjenjaDateTimePicker
        '
        resources.ApplyResources(Me.DatumRodjenjaDateTimePicker, "DatumRodjenjaDateTimePicker")
        Me.DatumRodjenjaDateTimePicker.Name = "DatumRodjenjaDateTimePicker"
        '
        'AdresaStanovanjaTextBox
        '
        resources.ApplyResources(Me.AdresaStanovanjaTextBox, "AdresaStanovanjaTextBox")
        Me.AdresaStanovanjaTextBox.Name = "AdresaStanovanjaTextBox"
        '
        'MjestoStanovanjaTextBox
        '
        resources.ApplyResources(Me.MjestoStanovanjaTextBox, "MjestoStanovanjaTextBox")
        Me.MjestoStanovanjaTextBox.Name = "MjestoStanovanjaTextBox"
        '
        'TelefonTextBox
        '
        resources.ApplyResources(Me.TelefonTextBox, "TelefonTextBox")
        Me.TelefonTextBox.Name = "TelefonTextBox"
        '
        'EmailTextBox
        '
        resources.ApplyResources(Me.EmailTextBox, "EmailTextBox")
        Me.EmailTextBox.Name = "EmailTextBox"
        '
        'PostaTextBox
        '
        resources.ApplyResources(Me.PostaTextBox, "PostaTextBox")
        Me.PostaTextBox.Name = "PostaTextBox"
        '
        'Obrisi
        '
        Me.Obrisi.DialogResult = System.Windows.Forms.DialogResult.No
        resources.ApplyResources(Me.Obrisi, "Obrisi")
        Me.Obrisi.Name = "Obrisi"
        Me.Obrisi.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.No
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AsocijacijeDataSet
        '
        Me.AsocijacijeDataSet.DataSetName = "AsocijacijeDataSet"
        Me.AsocijacijeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NatjecateljTableAdapter
        '
        Me.NatjecateljTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.NatjecateljTableAdapter = Me.NatjecateljTableAdapter
        Me.TableAdapterManager.UpdateOrder = Asocijacije.AsocijacijeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'NatjecateljDataGridView
        '
        Me.NatjecateljDataGridView.AllowUserToAddRows = False
        Me.NatjecateljDataGridView.AllowUserToDeleteRows = False
        Me.NatjecateljDataGridView.AllowUserToOrderColumns = True
        resources.ApplyResources(Me.NatjecateljDataGridView, "NatjecateljDataGridView")
        Me.NatjecateljDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.NatjecateljDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.imePrezime, Me.datumRodjenja, Me.adresaStanovanja, Me.mjestoStanovanja, Me.posta, Me.telefon, Me.email})
        Me.NatjecateljDataGridView.Name = "NatjecateljDataGridView"
        Me.NatjecateljDataGridView.ReadOnly = True
        '
        'imePrezime
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.imePrezime.DefaultCellStyle = DataGridViewCellStyle1
        resources.ApplyResources(Me.imePrezime, "imePrezime")
        Me.imePrezime.Name = "imePrezime"
        Me.imePrezime.ReadOnly = True
        '
        'datumRodjenja
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.datumRodjenja.DefaultCellStyle = DataGridViewCellStyle2
        resources.ApplyResources(Me.datumRodjenja, "datumRodjenja")
        Me.datumRodjenja.Name = "datumRodjenja"
        Me.datumRodjenja.ReadOnly = True
        '
        'adresaStanovanja
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.adresaStanovanja.DefaultCellStyle = DataGridViewCellStyle3
        resources.ApplyResources(Me.adresaStanovanja, "adresaStanovanja")
        Me.adresaStanovanja.Name = "adresaStanovanja"
        Me.adresaStanovanja.ReadOnly = True
        '
        'mjestoStanovanja
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.mjestoStanovanja.DefaultCellStyle = DataGridViewCellStyle4
        resources.ApplyResources(Me.mjestoStanovanja, "mjestoStanovanja")
        Me.mjestoStanovanja.Name = "mjestoStanovanja"
        Me.mjestoStanovanja.ReadOnly = True
        '
        'posta
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.posta.DefaultCellStyle = DataGridViewCellStyle5
        resources.ApplyResources(Me.posta, "posta")
        Me.posta.Name = "posta"
        Me.posta.ReadOnly = True
        '
        'telefon
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.telefon.DefaultCellStyle = DataGridViewCellStyle6
        resources.ApplyResources(Me.telefon, "telefon")
        Me.telefon.Name = "telefon"
        Me.telefon.ReadOnly = True
        '
        'email
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.email.DefaultCellStyle = DataGridViewCellStyle7
        resources.ApplyResources(Me.email, "email")
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        '
        'PromjenaDetaljaNatjecatelja
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.NatjecateljDataGridView)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Obrisi)
        Me.Controls.Add(Me.SifraNatjecateljaTextBox)
        Me.Controls.Add(Me.Promijeni)
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
        Me.Name = "PromjenaDetaljaNatjecatelja"
        Me.TopMost = True
        CType(Me.AsocijacijeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NatjecateljDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SifraNatjecateljaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Promijeni As System.Windows.Forms.Button
    Friend WithEvents ImePrezimeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DatumRodjenjaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents AdresaStanovanjaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MjestoStanovanjaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PostaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Obrisi As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents AsocijacijeDataSet As Asocijacije.AsocijacijeDataSet
    Friend WithEvents NatjecateljTableAdapter As Asocijacije.AsocijacijeDataSetTableAdapters.NatjecateljTableAdapter
    Friend WithEvents TableAdapterManager As Asocijacije.AsocijacijeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NatjecateljDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents imePrezime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datumRodjenja As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents adresaStanovanja As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mjestoStanovanja As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents posta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents telefon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents email As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
