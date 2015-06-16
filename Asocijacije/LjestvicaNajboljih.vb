Imports System.Data.SqlClient
Public Class LjestvicaNajboljih

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PocetniIzbornik.Label1.Show()
        PocetniIzbornik.Label2.Show()
        PocetniIzbornik.Izlaz.Show()
        PocetniIzbornik.Naslov.Show()
        PocetniIzbornik.GroupBox1.Show()
        Me.Close()
    End Sub

    Public Sub napuniLjestvicu()
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim niz(1000, 4) As String
        Dim IME(1000), st1, st2 As String
        Dim n As Natjecatelj
        Dim dt1, dt2 As String
        
        dt1 = DateTimePicker1.Value
        dt2 = DateTimePicker2.Value
        'dt1 = DateTime.ParseExact(DateTimePicker1.Value, "yyMMdd", System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat)
        'MessageBox.Show(dt1)
        'MessageBox.Show(dt2)
        st1 = ""
        st2 = ""
        If DateTimePicker1.Value.Day > 9 Then
            If DateTimePicker1.Value.Month > 9 Then
                'MessageBox.Show("Datum veći, mjesec veći")
                st1 = (dt1.Substring(6, 4) & "-" & dt1.Substring(3, 2) & "-" & dt1.Substring(0, 2))
            Else
                'MessageBox.Show("Datum veći, mjesec manji")
                st1 = (dt1.Substring(5, 4) & "-0" & dt1.Substring(3, 1) & "-" & dt1.Substring(0, 2))
            End If
        Else
            If DateTimePicker1.Value.Month > 9 Then
                'MessageBox.Show("Datum manji, mjesec veći")
                st1 = (dt1.Substring(5, 4) & "-" & dt1.Substring(2, 2) & "-0" & dt1.Substring(0, 1))
            Else
                'MessageBox.Show("Datum manji, mjesec manji")
                st1 = (dt1.Substring(4, 4) & "-0" & dt1.Substring(2, 1) & "-0" & dt1.Substring(0, 1))
            End If
        End If

        If DateTimePicker2.Value.Day > 9 Then
            If DateTimePicker2.Value.Month > 9 Then
                'MessageBox.Show("Datum veći, mjesec veći")
                st2 = (dt2.Substring(6, 4) & "-" & dt2.Substring(3, 2) & "-" & dt2.Substring(0, 2))
            Else
                'MessageBox.Show("Datum veći, mjesec manji")
                st2 = (dt2.Substring(5, 4) & "-0" & dt2.Substring(3, 1) & "-" & dt2.Substring(0, 2))
            End If
        Else
            If DateTimePicker2.Value.Month > 9 Then
                'MessageBox.Show("Datum manji, mjesec veći")
                st2 = (dt2.Substring(5, 4) & "-" & dt2.Substring(2, 2) & "-0" & dt2.Substring(0, 1))
            Else
                'MessageBox.Show("Datum manji, mjesec manji")
                st2 = (dt2.Substring(4, 4) & "-0" & dt2.Substring(2, 1) & "-0" & dt2.Substring(0, 1))
            End If
        End If

        'st1 = (dt1.Substring(5, 4) & "-0" & dt1.Substring(3, 1) & "-" & dt1.Substring(0, 2))

        'MessageBox.Show(st1 & " - " & st2)
        Me.LjestvicaDataGridView.Rows.Clear()
        Dim veza As New SqlConnection(My.Settings.veza)
        'Dim k As New SqlCommand(" SELECT B.imePrezime as 'Ime i prezime', SUM(A.ukupnoBodova) AS UB FROM NatjecateljKviz AS A INNER JOIN Natjecatelj AS B ON A.sifraNatjecatelja = B.sifraNatjecatelja GROUP BY B.imePrezime ORDER BY 'UB' DESC ", veza)
        Dim k As New SqlCommand(" SELECT B.imePrezime AS 'Ime i prezime', SUM(A.ukupnoBodova) AS UB FROM NatjecateljKviz AS A INNER JOIN Natjecatelj AS B ON A.sifraNatjecatelja = B.sifraNatjecatelja INNER JOIN Kviz AS C ON A.sifraKviza = C.sifraKviza WHERE (C.datumOdigravanja BETWEEN '" & st1 & "' AND '" & st2 & "' ) GROUP BY B.imePrezime ORDER BY 'UB' DESC ", veza)
        'Dim k1 As New SqlCommand(" SELECT B.imePrezime as IP, COUNT(B.imePrezime) AS PKR FROM NatjecateljTablica AS A INNER JOIN Natjecatelj AS B ON A.sifraNatjecatelja = B.sifraNatjecatelja WHERE(A.pogodioKonacnoRjesenje = 1) GROUP BY B.imePrezime ", veza)
        Dim k1 As New SqlCommand(" SELECT B.imePrezime AS IP, COUNT(B.imePrezime) AS PKR FROM NatjecateljTablica AS A INNER JOIN Natjecatelj AS B ON A.sifraNatjecatelja = B.sifraNatjecatelja INNER JOIN Kviz AS c ON A.sifrakviza = c.sifraKviza WHERE (A.pogodioKonacnoRjesenje = 1) AND (C.datumOdigravanja BETWEEN '" & st1 & "' AND '" & st2 & "' ) GROUP BY B.imePrezime ", veza)
        veza.Open()
        Dim rs As SqlDataReader = k.ExecuteReader

        While rs.Read
            i = i + 1
            n = New Natjecatelj
            n.ImePrezime = rs.Item("Ime i prezime")
            n.Posta = rs.Item("UB")

            niz(i, 0) = i
            niz(i, 1) = n.ImePrezime
            niz(i, 2) = n.Posta


            'Me.LjestvicaDataGridView.Rows.Item(Me.LjestvicaDataGridView.RowCount - 1).Tag = n

        End While
        veza.Close()

        i = 0
        j = 0
        veza.Open()
        Dim rs1 As SqlDataReader = k1.ExecuteReader
        While rs1.Read
            j = j + 1
            For i = 1 To 1000
                'MessageBox.Show(i & " - " & niz(i, 1) & " Item-" & rs1.Item("IP"))
                If niz(i, 1) = rs1.Item("IP") Then

                    n = New Natjecatelj
                    n.SifraNatjecatelja = rs1.Item("PKR")
                    niz(i, 3) = n.SifraNatjecatelja
                End If
            Next

        End While
        For i = 1 To 30
            Me.LjestvicaDataGridView.Rows.Add(niz(i, 0), niz(i, 1), niz(i, 2), niz(i, 3))

        Next


        veza.Close()
    End Sub

    Private Sub LjestvicaNajboljih_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimePicker1.Value = "01-01-2009"
        DateTimePicker2.Value = DateTimePicker2.Value
        napuniLjestvicu()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        napuniLjestvicu()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        napuniLjestvicu()
    End Sub

End Class