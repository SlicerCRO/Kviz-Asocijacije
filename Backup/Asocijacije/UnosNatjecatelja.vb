Imports System.Data.SqlClient
Public Class UnosNatjecatelja

    Private Sub Unos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Unos.Click
        Dim tr As SqlTransaction
        Dim veza As New SqlConnection(My.Settings.veza)
        If Me.ImePrezimeTextBox.Text <> "" Then
            veza.Open()
            tr = veza.BeginTransaction
            Dim k As New SqlCommand("insert into natjecatelj ( imePrezime, datumRodjenja, adresaStanovanja, posta, mjestoStanovanja, telefon, email) " & _
                                    " values (@imePrezime, @datumRodjenja, @adresaStanovanja, @posta, @mjestoStanovanja, @telefon, @email)", veza, tr)
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
            k.ExecuteNonQuery()
            'End If
            tr.Commit()
            veza.Close()
            Form7.ucitajPodatke()
            Novaf7()
            Me.Close()
        Else
            MessageBox.Show("Unos imena je obavezan")
        End If

        'Form7.NatjecateljTableAdapter.Fill(Form7.AsocijacijeDataSet.Natjecatelj)
    End Sub

    Private Sub Odustani_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Odustani.Click
        Novaf7()
        Me.Close()
    End Sub

    Private Sub Novaf7()
        Dim f7 As New Form7
        f7.Show()
    End Sub
End Class