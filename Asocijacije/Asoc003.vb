Imports System.Data.SqlClient
Public Class Asoc003
    Public Sub ucitajPodatke()
        Me.Igrac1.Items.Clear()
        Me.Igrac1.Text() = ""


        Dim veza As New SqlConnection(My.Settings.veza)
        Dim komanda As New SqlCommand(" select sifranatjecatelja as 'Sifra natjecatelja', " + _
                                      " imePrezime as 'Ime i Prezime' from Natjecatelj", veza)
        veza.Open()
        Dim rs As SqlDataReader = komanda.ExecuteReader
        Dim k As Natjecatelj
        While rs.Read
            k = New Natjecatelj

            k.SifraNatjecatelja = rs.Item("Sifra natjecatelja")
            k.ImePrezime = rs.Item("Ime i Prezime")

            Dim niz(1) As String
            niz(0) = k.SifraNatjecatelja
            niz(1) = k.ImePrezime

            Me.Igrac1.Items.Add(k)

        End While
        veza.Close()

    End Sub

    Private Sub Unesi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Unesi.Click
        Dim tr As SqlTransaction
        Dim veza As New SqlConnection(My.Settings.veza)
        Dim j, k As Integer

        If Me.Igrac1.Text <> "" Then
            Dim kom As New SqlCommand("select count(sifratablice) as 'j' from tablice", veza)
            veza.Open()
            Dim rs1 As SqlDataReader = kom.ExecuteReader
            While rs1.Read
                j = rs1.Item("j")
            End While
            veza.Close()

            veza.Open()
            tr = veza.BeginTransaction
            Dim komanda As SqlCommand
            komanda = New SqlCommand("insert into Tablice (brojTablice, A1, A2, A3, A4, B1, B2, B3, B4, C1, C2, C3, C4, D1, D2, D3, D4, stupacA, stupacB, stupacC, stupacD, konacnoRjesenje) " & _
                                     " values (@brojTablice, @A1 , @A2, @A3, @A4, @B1, @B2, @B3, @B4, @C1, @C2, @C3, @C4, @D1, @D2, @D3, @D4, @stupacA, @stupacB, @stupacC, @stupacD, @konacnoRjesenje)", veza, tr)
            komanda.Parameters.Add("@brojTablice", SqlDbType.Int).Value = j + 1
            komanda.Parameters.Add("@A1", SqlDbType.NVarChar, 100).Value = Me.A1.Text
            komanda.Parameters.Add("@A2", SqlDbType.NVarChar, 100).Value = Me.A2.Text
            komanda.Parameters.Add("@A3", SqlDbType.NVarChar, 100).Value = Me.A3.Text
            komanda.Parameters.Add("@A4", SqlDbType.NVarChar, 100).Value = Me.A4.Text
            komanda.Parameters.Add("@B1", SqlDbType.NVarChar, 100).Value = Me.B1.Text
            komanda.Parameters.Add("@B2", SqlDbType.NVarChar, 100).Value = Me.B2.Text
            komanda.Parameters.Add("@B3", SqlDbType.NVarChar, 100).Value = Me.B3.Text
            komanda.Parameters.Add("@B4", SqlDbType.NVarChar, 100).Value = Me.B4.Text
            komanda.Parameters.Add("@C1", SqlDbType.NVarChar, 100).Value = Me.C1.Text
            komanda.Parameters.Add("@C2", SqlDbType.NVarChar, 100).Value = Me.C2.Text
            komanda.Parameters.Add("@C3", SqlDbType.NVarChar, 100).Value = Me.C3.Text
            komanda.Parameters.Add("@C4", SqlDbType.NVarChar, 100).Value = Me.C4.Text
            komanda.Parameters.Add("@D1", SqlDbType.NVarChar, 100).Value = Me.D1.Text
            komanda.Parameters.Add("@D2", SqlDbType.NVarChar, 100).Value = Me.D2.Text
            komanda.Parameters.Add("@D3", SqlDbType.NVarChar, 100).Value = Me.D3.Text
            komanda.Parameters.Add("@D4", SqlDbType.NVarChar, 100).Value = Me.D4.Text
            komanda.Parameters.Add("@stupacA", SqlDbType.NVarChar, 30).Value = Me.SA.Text
            komanda.Parameters.Add("@stupacB", SqlDbType.NVarChar, 30).Value = Me.SB.Text
            komanda.Parameters.Add("@stupacC", SqlDbType.NVarChar, 30).Value = Me.SC.Text
            komanda.Parameters.Add("@stupacD", SqlDbType.NVarChar, 30).Value = Me.SD.Text
            komanda.Parameters.Add("@konacnoRjesenje", SqlDbType.NVarChar, 100).Value = Me.KON.Text
            komanda.Parameters.Add("@iskoristena", SqlDbType.NVarChar, 100).Value = 0

            If Me.A1.Text.Length > 99 Then
                MessageBox.Show("Predug pojam u polju A1")
            ElseIf Me.A2.Text.Length > 99 Then
                MessageBox.Show("Predug pojam u polju A2")
            ElseIf Me.A3.Text.Length > 99 Then
                MessageBox.Show("Predug pojam u polju A3")
            ElseIf Me.A4.Text.Length > 99 Then
                MessageBox.Show("Predug pojam u polju A4")
            ElseIf Me.B1.Text.Length > 99 Then
                MessageBox.Show("Predug pojam u polju B1")
            ElseIf Me.B2.Text.Length > 99 Then
                MessageBox.Show("Predug pojam u polju B2")
            ElseIf Me.B3.Text.Length > 99 Then
                MessageBox.Show("Predug pojam u polju B3")
            ElseIf Me.B4.Text.Length > 99 Then
                MessageBox.Show("Predug pojam u polju B4")
            ElseIf Me.C1.Text.Length > 99 Then
                MessageBox.Show("Predug pojam u polju C1")
            ElseIf Me.C2.Text.Length > 99 Then
                MessageBox.Show("Predug pojam u polju C2")
            ElseIf Me.C3.Text.Length > 99 Then
                MessageBox.Show("Predug pojam u polju C3")
            ElseIf Me.C4.Text.Length > 99 Then
                MessageBox.Show("Predug pojam u polju C4")
            ElseIf Me.D1.Text.Length > 99 Then
                MessageBox.Show("Predug pojam u polju D1")
            ElseIf Me.D2.Text.Length > 99 Then
                MessageBox.Show("Predug pojam u polju D2")
            ElseIf Me.D3.Text.Length > 99 Then
                MessageBox.Show("Predug pojam u polju D3")
            ElseIf Me.D4.Text.Length > 99 Then
                MessageBox.Show("Predug pojam u polju D4")
            ElseIf Me.SA.Text.Length > 99 Then
                MessageBox.Show("Predug pojam u rješenju Stupca A")
            ElseIf Me.SB.Text.Length > 29 Then
                MessageBox.Show("Predug pojam u rješenju Stupca B")
            ElseIf Me.SC.Text.Length > 29 Then
                MessageBox.Show("Predug pojam u rješenju Stupca C")
            ElseIf Me.SD.Text.Length > 29 Then
                MessageBox.Show("Predug pojam u rješenju Stupca D")
            ElseIf Me.KON.Text.Length > 99 Then
                MessageBox.Show("Predug pojam u Konačnom rješenju")
            ElseIf Me.A1.Text = "" Then
                MessageBox.Show("Polje A1 je prazno!")
            ElseIf Me.A2.Text = "" Then
                MessageBox.Show("Polje A2 je prazno!")
            ElseIf Me.A3.Text = "" Then
                MessageBox.Show("Polje A3 je prazno!")
            ElseIf Me.A4.Text = "" Then
                MessageBox.Show("Polje A4 je prazno!")
            ElseIf Me.B1.Text = "" Then
                MessageBox.Show("Polje B1 je prazno!")
            ElseIf Me.B2.Text = "" Then
                MessageBox.Show("Polje B2 je prazno!")
            ElseIf Me.B3.Text = "" Then
                MessageBox.Show("Polje B3 je prazno!")
            ElseIf Me.B4.Text = "" Then
                MessageBox.Show("Polje B4 je prazno!")
            ElseIf Me.C1.Text = "" Then
                MessageBox.Show("Polje C1 je prazno!")
            ElseIf Me.C2.Text = "" Then
                MessageBox.Show("Polje C2 je prazno!")
            ElseIf Me.C3.Text = "" Then
                MessageBox.Show("Polje C3 je prazno!")
            ElseIf Me.C4.Text = "" Then
                MessageBox.Show("Polje C4 je prazno!")
            ElseIf Me.D1.Text = "" Then
                MessageBox.Show("Polje D1 je prazno!")
            ElseIf Me.D2.Text = "" Then
                MessageBox.Show("Polje D2 je prazno!")
            ElseIf Me.D3.Text = "" Then
                MessageBox.Show("Polje D3 je prazno!")
            ElseIf Me.D4.Text = "" Then
                MessageBox.Show("Polje D4 je prazno!")
            ElseIf Me.SA.Text = "" Then
                MessageBox.Show("Stupac A je prazan!")
            ElseIf Me.SB.Text = "" Then
                MessageBox.Show("Stupac B je prazan!")
            ElseIf Me.SC.Text = "" Then
                MessageBox.Show("Stupac C je prazan!")
            ElseIf Me.SD.Text = "" Then
                MessageBox.Show("Stupac D je prazan!")
            ElseIf Me.KON.Text = "" Then
                MessageBox.Show("Konačno rješenje je prazno!")

            Else
                komanda.ExecuteNonQuery()
                tr.Commit()
                veza.Close()

                veza.Open()
                Dim komanda1 As New SqlCommand("SELECT sifraTablice AS 'Sifra' FROM Tablice WHERE (brojTablice = " & j + 1 & " ) ", veza)
                Dim rs As SqlDataReader = komanda1.ExecuteReader
                While rs.Read
                    k = rs.Item("Sifra")
                    'MessageBox.Show(k)
                End While
                veza.Close()

                veza.Open()
                tr = veza.BeginTransaction
                komanda1 = New SqlCommand("insert into NatjecateljTablica(sifraNatjecatelja, sifraTablice, osvojioBodova, pogodioKonacnoRjesenje) values(" & Me.Igrac1.SelectedItem.SifraNatjecatelja & ", " & k & ", 0 , 0)", veza, tr)

                komanda1.ExecuteNonQuery()
                tr.Commit()
                veza.Close()

                Dim komanda2 As New SqlCommand("select sifraTablice, A1, A2, A3, A4, B1, B2, B3, B4, C1, C2, C3, C4, D1, D2, D3, D4, stupacA as 'SA', stupacB as 'SB', stupacC as 'SC', stupacD as 'SD', konacnoRjesenje as 'KON' from Tablice where brojTablice=" & j + 1, veza)
                veza.Open()
                Dim rs2 As SqlDataReader = komanda2.ExecuteReader
                'Dim isk As Integer
                While rs2.Read
                    Dim sifraTablice As Integer = rs2.Item("sifraTablice")
                    Asoc1.A1.Text = rs2.Item("A1")
                    Asoc1.A2.Text = rs2.Item("A2")
                    Asoc1.A3.Text = rs2.Item("A3")
                    Asoc1.A4.Text = rs2.Item("A4")
                    Asoc1.B1.Text = rs2.Item("B1")
                    Asoc1.B2.Text = rs2.Item("B2")
                    Asoc1.B3.Text = rs2.Item("B3")
                    Asoc1.B4.Text = rs2.Item("B4")
                    Asoc1.C1.Text = rs2.Item("C1")
                    Asoc1.C2.Text = rs2.Item("C2")
                    Asoc1.C3.Text = rs2.Item("C3")
                    Asoc1.C4.Text = rs2.Item("C4")
                    Asoc1.D1.Text = rs2.Item("D1")
                    Asoc1.D2.Text = rs2.Item("D2")
                    Asoc1.D3.Text = rs2.Item("D3")
                    Asoc1.D4.Text = rs2.Item("D4")
                    Asoc1.SA.Text = rs2.Item("SA")
                    Asoc1.SB.Text = rs2.Item("SB")
                    Asoc1.SC.Text = rs2.Item("SC")
                    Asoc1.SD.Text = rs2.Item("SD")
                    Asoc1.KON.Text = rs2.Item("KON")
                End While
                veza.Close()

       
                MessageBox.Show("Tablica " & j + 1 & " je unesena")
                PocetniIzbornik.Label1.Show()
                PocetniIzbornik.Label2.Show()
                PocetniIzbornik.Izlaz.Show()
                PocetniIzbornik.Naslov.Show()
                PocetniIzbornik.GroupBox1.Show()
                Me.Close()
            End If

        Else
            MessageBox.Show("Morate odabrati sebe kao osobu koja unosi tablicu!")
        End If


    End Sub

    Public Sub Provjeri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Provjeri.Click
        Dim veza As New SqlConnection(My.Settings.veza)
        Dim i As Integer
        Dim j As Integer

        Dim kom As New SqlCommand("select count(sifratablice) as 'j' from tablice", veza)
        veza.Open()

        Dim rs1 As SqlDataReader = kom.ExecuteReader
        While rs1.Read
            j = rs1.Item("j")
        End While
        For K As Integer = 1 To 20
            Randomize()
            i = j * Rnd() + 1
            Console.WriteLine(i)
        Next
        veza.Close()

        Dim komanda As New SqlCommand("select A1, A2, A3, A4, B1, B2, B3, B4, C1, C2, C3, C4, D1, D2, D3, D4, stupacA as 'SA', stupacB as 'SB', stupacC as 'SC', stupacD as 'SD', konacnoRjesenje as 'KON' from Tablice where brojTablice=" & i, veza)
        veza.Open()
        Dim rs As SqlDataReader = komanda.ExecuteReader

        While rs.Read
            Me.A1.Text = rs.Item("A1")
            Me.A2.Text = rs.Item("A2")
            Me.A3.Text = rs.Item("A3")
            Me.A4.Text = rs.Item("A4")
            Me.B1.Text = rs.Item("B1")
            Me.B2.Text = rs.Item("B2")
            Me.B3.Text = rs.Item("B3")
            Me.B4.Text = rs.Item("B4")
            Me.C1.Text = rs.Item("C1")
            Me.C2.Text = rs.Item("C2")
            Me.C3.Text = rs.Item("C3")
            Me.C4.Text = rs.Item("C4")
            Me.D1.Text = rs.Item("D1")
            Me.D2.Text = rs.Item("D2")
            Me.D3.Text = rs.Item("D3")
            Me.D4.Text = rs.Item("D4")
            Me.SA.Text = rs.Item("SA")
            Me.SB.Text = rs.Item("SB")
            Me.SC.Text = rs.Item("SC")
            Me.SD.Text = rs.Item("SD")
            Me.KON.Text = rs.Item("KON")
        End While

        'Dim tr As SqlTransaction
        'tr = veza.BeginTransaction
        'komanda = New SqlCommand("update tablice set brojtablice=3 where sifratablice=3", veza, tr)
        'tr.Commit()
        veza.Close()


    End Sub

    Private Sub Odustani_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Odustani.Click
        PocetniIzbornik.Label1.Show()
        PocetniIzbornik.Label2.Show()
        PocetniIzbornik.Izlaz.Show()
        PocetniIzbornik.Naslov.Show()
        PocetniIzbornik.GroupBox1.Show()
        Me.Close()
    End Sub

    Private Sub Asoc003_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ucitajPodatke()
    End Sub

End Class