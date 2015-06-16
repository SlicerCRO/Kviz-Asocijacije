Imports System.Data.SqlClient
Public Class PromjenaDetaljaNatjecatelja

    Private Sub Promijeni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Promijeni.Click
        Dim tr As SqlTransaction
        Dim veza As New SqlConnection(My.Settings.veza)
        veza.Open()
        tr = veza.BeginTransaction
        Dim k As New SqlCommand("update natjecatelj set imePrezime=@imePrezime, datumRodjenja=@datumRodjenja, adresaStanovanja=@adresaStanovanja, posta=@posta, mjestoStanovanja=@mjestoStanovanja, telefon=@telefon, email=@email where sifraNatjecatelja=@sifraNatjecatelja", veza, tr)
        k.Parameters.Add("@sifraNatjecatelja", SqlDbType.Int).Value = Me.SifraNatjecateljaTextBox.Text
        k.Parameters.Add("@imePrezime", SqlDbType.NVarChar, 100).Value = Me.ImePrezimeTextBox.Text
        k.Parameters.Add("@datumRodjenja", SqlDbType.DateTime).Value = Me.DatumRodjenjaDateTimePicker.Value
        k.Parameters.Add("@adresaStanovanja", SqlDbType.NVarChar, 100).Value = Me.AdresaStanovanjaTextBox.Text

        If Me.PostaTextBox.Text <> "" Then
            k.Parameters.Add("@posta", SqlDbType.Int).Value = Me.PostaTextBox.Text
        Else
            k.Parameters.Add("@posta", SqlDbType.Int).Value = 0
        End If
        k.Parameters.Add("@mjestoStanovanja", SqlDbType.NVarChar, 50).Value = Me.MjestoStanovanjaTextBox.Text
        k.Parameters.Add("@telefon", SqlDbType.VarChar, 20).Value = Me.TelefonTextBox.Text
        k.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = Me.EmailTextBox.Text

        Try
            k.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Niste odabrali igrača!", "Greška")
        End Try

        tr.Commit()
        veza.Close()
        napuniPodatke()
        'Me.Close()
    End Sub

    Private Sub Obrisi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Obrisi.Click
        Dim tr As SqlTransaction
        Dim veza As New SqlConnection(My.Settings.veza)
        Dim Result As DialogResult
        Result = MessageBox.Show("Jeste li sigurni da želite obrisati odabranog igrača?", "Potvrdite brisanje", _
                 MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If Result = System.Windows.Forms.DialogResult.Yes Then
            veza.Open()
            tr = veza.BeginTransaction
            Dim k As New SqlCommand("delete FROM NatjecateljKviz where sifraNatjecatelja=@sifraNatjecatelja delete FROM NatjecateljTablica where sifraNatjecatelja=@sifraNatjecatelja  delete FROM Natjecatelj where sifraNatjecatelja=@sifraNatjecatelja", veza, tr)
            'MessageBox.Show(Me.SifraNatjecateljaTextBox.Text)
            Try
                k.Parameters.Add("@sifraNatjecatelja", SqlDbType.Int).Value = Me.SifraNatjecateljaTextBox.Text
                k.ExecuteNonQuery()
                tr.Commit()
            Catch ex As Exception
                MessageBox.Show("Niste odabrali igrača!", "Greška")
            End Try

            veza.Close()
            napuniPodatke()
        End If
    End Sub

    Private Sub PromjenaDetaljaNatjecatelja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AsocijacijeDataSet.Natjecatelj' table. You can move, or remove it, as needed.
        'Me.NatjecateljTableAdapter.Fill(Me.AsocijacijeDataSet.Natjecatelj)
        'Dim odabraniNatjecatelj As Natjecatelj
        'odabraniNatjecatelj = Form7.Igrac1.Tag
        napuniPodatke()

        'MessageBox.Show(odabraniNatjecatelj.ImePrezime)
        'Me.SifraNatjecateljaTextBox.Text = odabraniNatjecatelj.SifraNatjecatelja
        'Me.ImePrezimeTextBox.Text = odabraniNatjecatelj.ImePrezime
        'Me.DatumRodjenjaDateTimePicker.Value = odabraniNatjecatelj.DatumRodjenja
        'Me.AdresaStanovanjaTextBox.Text = odabraniNatjecatelj.AdresaStanovanja
        'Me.PostaTextBox.Text = odabraniNatjecatelj.Posta
        'Me.MjestoStanovanjaTextBox.Text = odabraniNatjecatelj.MjestoStanovanja
        'Me.TelefonTextBox.Text = odabraniNatjecatelj.Telefon
        'Me.EmailTextBox.Text = odabraniNatjecatelj.Email


    End Sub

    Public Sub napuniPodatke()
        Me.NatjecateljDataGridView.Rows.Clear()
        Dim veza As New SqlConnection(My.Settings.veza)
        Dim k As New SqlCommand( _
        " select sifraNatjecatelja, " & _
        " imePrezime as 'Ime i prezime', " & _
        " datumRodjenja as 'Datum rođenja', " & _
        " adresaStanovanja as 'Adresa stanovanja', " & _
        " mjestoStanovanja as 'Mjesto stanovanja', " & _
        " telefon as 'Telefon', " & _
        " email as 'E-mail', " & _
        " posta as 'Poštanski broj' " & _
        " from natjecatelj ", veza)
        Console.WriteLine(k.CommandText)
        veza.Open()
        Dim rs As SqlDataReader = k.ExecuteReader

        Dim n As Natjecatelj
        While rs.Read
            n = New Natjecatelj
            n.SifraNatjecatelja = rs.Item("sifraNatjecatelja")
            n.ImePrezime = rs.Item("Ime i prezime")
            Try
                n.DatumRodjenja = rs.Item("Datum rođenja")
            Catch ex As Exception

            End Try

            Try
                n.AdresaStanovanja = rs.Item("Adresa stanovanja")
            Catch ex As Exception

            End Try
            Try
                n.MjestoStanovanja = rs.Item("Mjesto stanovanja")
            Catch ex As Exception

            End Try
            Try
                n.Posta = rs.Item("Poštanski broj")
            Catch ex As Exception

            End Try
            Try
                n.Telefon = rs.Item("Telefon")
            Catch ex As Exception

            End Try
            Try
                n.Email = rs.Item("E-mail")
            Catch ex As Exception

            End Try




            Dim niz(8) As String
            niz(0) = n.ImePrezime
            niz(1) = n.DatumRodjenja.ToString("dd. MM. yyyy")
            niz(2) = n.AdresaStanovanja
            niz(3) = n.MjestoStanovanja
            niz(4) = n.Posta
            niz(5) = n.Telefon
            niz(6) = n.Email
            niz(7) = n.SifraNatjecatelja

            Me.NatjecateljDataGridView.Rows.Add(niz)
            Me.NatjecateljDataGridView.Rows.Item(Me.NatjecateljDataGridView.RowCount - 1).Tag = n

        End While
        veza.Close()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PocetniIzbornik.Label1.Show()
        PocetniIzbornik.Label2.Show()
        PocetniIzbornik.Izlaz.Show()
        PocetniIzbornik.Naslov.Show()
        PocetniIzbornik.GroupBox1.Show()
        Me.Close()
    End Sub

    Private Sub NatjecateljDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles NatjecateljDataGridView.CellContentClick

    End Sub

    Private Sub NatjecateljDataGridView_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles NatjecateljDataGridView.CellContentDoubleClick
        Dim odabraniNatjecatelj As New Natjecatelj
        odabraniNatjecatelj = Me.NatjecateljDataGridView.CurrentRow.Tag

        Me.SifraNatjecateljaTextBox.Text = odabraniNatjecatelj.SifraNatjecatelja
        Me.ImePrezimeTextBox.Text = odabraniNatjecatelj.ImePrezime
        Me.DatumRodjenjaDateTimePicker.Value = odabraniNatjecatelj.DatumRodjenja
        Me.AdresaStanovanjaTextBox.Text = odabraniNatjecatelj.AdresaStanovanja
        Me.MjestoStanovanjaTextBox.Text = odabraniNatjecatelj.MjestoStanovanja
        Me.TelefonTextBox.Text = odabraniNatjecatelj.Telefon
        Me.EmailTextBox.Text = odabraniNatjecatelj.Email
        Me.PostaTextBox.Text = odabraniNatjecatelj.Posta
    End Sub

End Class