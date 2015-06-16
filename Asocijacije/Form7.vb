Imports System.Data.SqlClient
Public Class Form7
    'Dim AsocBroj As Integer = 0

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Start.Click
        PocetniIzbornik.Hide()
        Dim i1, i2, i3, i4 As Natjecatelj
        If Me.Igrac1.SelectedItem Is Nothing Then
            i1 = New Natjecatelj
            i1.ImePrezime = "Prvi"
        Else
            i1 = Me.Igrac1.SelectedItem
        End If

        If Me.Igrac2.SelectedItem Is Nothing Then
            i2 = New Natjecatelj
            i2.ImePrezime = "Drugi"
        Else
            i2 = Me.Igrac2.SelectedItem
        End If

        If Me.Igrac3.SelectedItem Is Nothing Then
            i3 = New Natjecatelj
            i3.ImePrezime = "Treći"
        Else
            i3 = Me.Igrac3.SelectedItem
        End If

        If Me.Igrac4.SelectedItem Is Nothing Then
            i4 = New Natjecatelj
            i4.ImePrezime = "Četvrti"
        Else
            i4 = Me.Igrac4.SelectedItem
        End If


        'form10.Show()

        Dim F1 As New Form1(i1, i2, i3, i4)
        F1.Show()

        Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Unos.Click
        Dim UN As New UnosNatjecatelja
        UN.Show()
        Me.Close()
    End Sub

    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AsocijacijeDataSet.Natjecatelj' table. You can move, or remove it, as needed.
        'Me.NatjecateljTableAdapter.Fill(Me.AsocijacijeDataSet.Natjecatelj)
        ucitajPodatke()

    End Sub

    Public Sub ucitajPodatke()
        Me.Igrac1.Items.Clear()
        Me.Igrac2.Items.Clear()
        Me.Igrac3.Items.Clear()
        Me.Igrac4.Items.Clear()

        Me.Igrac1.Text() = ""
        Me.Igrac2.Text() = ""
        Me.Igrac3.Text() = ""
        Me.Igrac4.Text() = ""

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
            Me.Igrac2.Items.Add(k)
            Me.Igrac3.Items.Add(k)
            Me.Igrac4.Items.Add(k)

            'Me.Igrac1.Items.Item(Me.Igrac1.SelectedItem).Tag = k
            'Me.Igrac2.Items.Item(Me.Igrac2.SelectedItem).Tag = k
            'Me.Igrac3.Items.Item(Me.Igrac3.SelectedItem).Tag = k
            'Me.Igrac4.Items.Item(Me.Igrac4.SelectedItem).Tag = k
        End While
        veza.Close()

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PocetniIzbornik.Label1.Show()
        PocetniIzbornik.Label2.Show()
        PocetniIzbornik.Izlaz.Show()
        PocetniIzbornik.Naslov.Show()
        PocetniIzbornik.GroupBox1.Show()
        Me.Close()
    End Sub

   
End Class