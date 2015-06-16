Imports System.Data.SqlClient
Public Class otvori
    Public Sub Otvori()
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
            Asoc1.A1.Text = rs.Item("A1")
            Asoc1.A2.Text = rs.Item("A2")
            Asoc1.A3.Text = rs.Item("A3")
            Asoc1.A4.Text = rs.Item("A4")
            Asoc1.B1.Text = rs.Item("B1")
            Asoc1.B2.Text = rs.Item("B2")
            Asoc1.B3.Text = rs.Item("B3")
            Asoc1.B4.Text = rs.Item("B4")
            Asoc1.C1.Text = rs.Item("C1")
            Asoc1.C2.Text = rs.Item("C2")
            Asoc1.C3.Text = rs.Item("C3")
            Asoc1.C4.Text = rs.Item("C4")
            Asoc1.D1.Text = rs.Item("D1")
            Asoc1.D2.Text = rs.Item("D2")
            Asoc1.D3.Text = rs.Item("D3")
            Asoc1.D4.Text = rs.Item("D4")
            Asoc1.SA.Text = rs.Item("SA")
            Asoc1.SB.Text = rs.Item("SB")
            Asoc1.SC.Text = rs.Item("SC")
            Asoc1.SD.Text = rs.Item("SD")
            Asoc1.KON.Text = rs.Item("KON")
        End While
        veza.Close()
        'Dim tr As SqlTransaction
        'tr = veza.BeginTransaction
        'komanda = New SqlCommand("update tablice set brojtablice=3 where sifratablice=3", veza, tr)
        'Dim tr As SqlTransaction
        'tr = veza.BeginTransaction
        'komanda = New SqlCommand("update tablice set iskoristena=1 where brojTablice=2", veza, tr)
        'tr.Commit()

    End Sub

End Class
