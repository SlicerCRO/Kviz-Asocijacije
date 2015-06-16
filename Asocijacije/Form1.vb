Imports System.Data.SqlClient
Imports Asocijacije.Bodovanje

Public Class Form1
    Public Shared x As Integer
    Public Shared l As Integer
    Public Shared bool As Boolean = True
    Public Shared m_StopTime As Date
    Public Shared bod1 As Integer = 0
    Public Shared bod2 As Integer = 0
    Public Shared bod3 As Integer = 0
    Public Shared bod4 As Integer = 0
    Public Shared bodTr As Integer = 0
    Public Shared otvara As Boolean = True
    Private O As Boolean
    Private R As Boolean
    Public Shared rjesava As Boolean = False
    Private i1 As Natjecatelj
    Private i2 As Natjecatelj
    Private i3 As Natjecatelj
    Private i4 As Natjecatelj
    Private tabBod1 As Integer = 0
    Private tabBod2 As Integer = 0
    Private tabBod3 As Integer = 0
    Private tabBod4 As Integer = 0
    Private tB1 As Integer = 0
    Private tB2 As Integer = 0
    Private tB3 As Integer = 0
    Private tB4 As Integer = 0
    Private Mjesto1, Mjesto2, Mjesto3, Mjesto4 As Integer
    Public Shared T As Tablica
    Public Shared provdalj As Boolean = True
    Public Shared zbroji As Boolean = False
    Public Shared OstaloKrugova As Integer = 3
    Public f2 As Form2
    Public f3 As Form3
    Public f4 As Form4
    Public f5 As Form5
    Public f6 As Form6





    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByVal otvara As Boolean, ByVal rjesava As Boolean)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        O = otvara
        R = rjesava
    End Sub


    Public Sub New(ByVal igrac1 As Natjecatelj, ByVal igrac2 As Natjecatelj, ByVal igrac3 As Natjecatelj, ByVal igrac4 As Natjecatelj)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        i1 = igrac1
        'MessageBox.Show(i1.ImePrezime)
        i2 = igrac2
        i3 = igrac3
        i4 = igrac4

    End Sub

    Public Shared Function x1() As Integer
        If T.A1.BackColor = Color.Yellow Then
            If T.B1.BackColor = Color.Yellow Then
                If T.C1.BackColor = Color.Yellow Then
                    If T.D1.BackColor = Color.Yellow Then
                        If T.A2.BackColor = Color.Yellow Then
                            If T.B2.BackColor = Color.Yellow Then
                                If T.C2.BackColor = Color.Yellow Then
                                    If T.D2.BackColor = Color.Yellow Then
                                        If T.A3.BackColor = Color.Yellow Then
                                            If T.B3.BackColor = Color.Yellow Then
                                                If T.C3.BackColor = Color.Yellow Then
                                                    If T.D3.BackColor = Color.Yellow Then
                                                        If T.A4.BackColor = Color.Yellow Then
                                                            If T.B4.BackColor = Color.Yellow Then
                                                                If T.C4.BackColor = Color.Yellow Then
                                                                    If T.D4.BackColor = Color.Yellow Then
                                                                        rjesava = True
                                                                        otvara = False
                                                                        x = x - 1
                                                                        Select Case x
                                                                            Case 5 To 9
                                                                                OstaloKrugova = 2
                                                                            Case 1 To 4
                                                                                OstaloKrugova = 1
                                                                            Case Else
                                                                                OstaloKrugova = 0
                                                                        End Select
                                                                        'Me.Label10.Text = "Preostalo pokušaja"
                                                                        'Console.WriteLine(LabelX)
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        Return x
    End Function

    'Public Shared Function x2() As Integer
    '    If T.A1.BackColor = Color.Yellow Then
    '        If T.B1.BackColor = Color.Yellow Then
    '            If T.C1.BackColor = Color.Yellow Then
    '                If T.D1.BackColor = Color.Yellow Then
    '                    If T.A2.BackColor = Color.Yellow Then
    '                        If T.B2.BackColor = Color.Yellow Then
    '                            If T.C2.BackColor = Color.Yellow Then
    '                                If T.D2.BackColor = Color.Yellow Then
    '                                    If T.A3.BackColor = Color.Yellow Then
    '                                        If T.B3.BackColor = Color.Yellow Then
    '                                            If T.C3.BackColor = Color.Yellow Then
    '                                                If T.D3.BackColor = Color.Yellow Then
    '                                                    If T.A4.BackColor = Color.Yellow Then
    '                                                        If T.B4.BackColor = Color.Yellow Then
    '                                                            If T.C4.BackColor = Color.Yellow Then
    '                                                                If T.D4.BackColor = Color.Yellow Then
    '                                                                    rjesava = True
    '                                                                    otvara = False
    '                                                                    x = x + 1
    '                                                                    Select Case x
    '                                                                        Case 5 To 9
    '                                                                            OstaloKrugova = 2
    '                                                                        Case 1 To 4
    '                                                                            OstaloKrugova = 1
    '                                                                        Case Else
    '                                                                            OstaloKrugova = 0
    '                                                                    End Select
    '                                                                    'Me.Label10.Text = "Preostalo pokušaja"
    '                                                                    'Console.WriteLine(LabelX)
    '                                                                End If
    '                                                            End If
    '                                                        End If
    '                                                    End If
    '                                                End If
    '                                            End If
    '                                        End If
    '                                    End If
    '                                End If
    '                            End If
    '                        End If
    '                    End If
    '                End If
    '            End If
    '        End If
    '    End If
    '    Return x
    'End Function


    Public Function zbroj() As Integer
        zbroji = False
        'm_StopTime = Now.Add(TimeSpan.Parse("00:00:31"))
        'tmrWait.Enabled = True
        'MessageBox.Show(Natjecatelj.Text)
        If T.KON.BackColor = Color.Red Then
            Me.Label10.Text = ""
            Me.lblRemaining.Hide()
        End If
        Select Case Natjecatelj.Text
            Case Me.Igrac1.Text
                bod1 = bod1 + bodTr
                'form10.bod01.Text = bod1
                Me.bod01.Text = bod1
                'MessageBox.Show(Me.bod01.Text)
                bodTr = 0
                Return bod1
            Case Me.Igrac2.Text
                bod2 = bod2 + bodTr
                'form10.bod02.Text = bod2
                Me.bod02.Text = bod2
                'MessageBox.Show(Me.bod02.Text)
                bodTr = 0
                Return bod2
            Case Me.Igrac3.Text
                bod3 = bod3 + bodTr
                'form10.bod03.Text = bod3
                Me.bod03.Text = bod3
                'MessageBox.Show(Me.bod03.Text)
                bodTr = 0
                Return bod3
            Case Me.Igrac4.Text
                bod4 = bod4 + bodTr
                'form10.bod04.Text = bod4
                Me.bod04.Text = bod4
                'MessageBox.Show(Me.bod04.Text)
                bodTr = 0
                Return bod4
        End Select
    End Function

    Public Sub aktivniIgrac()
        Select Case Natjecatelj.Text
            Case Me.Igrac1.Text
                Natjecatelj.Text = Me.Igrac2.Text
                Me.Igrac1.ForeColor = Color.Black
                Me.Igrac2.ForeColor = Color.DarkRed
                Me.Igrac3.ForeColor = Color.Black
                Me.Igrac4.ForeColor = Color.Black
            Case Me.Igrac2.Text
                Natjecatelj.Text = Me.Igrac3.Text
                Me.Igrac1.ForeColor = Color.Black
                Me.Igrac2.ForeColor = Color.Black
                Me.Igrac3.ForeColor = Color.DarkRed
                Me.Igrac4.ForeColor = Color.Black
            Case Me.Igrac3.Text
                Natjecatelj.Text = Me.Igrac4.Text
                Me.Igrac1.ForeColor = Color.Black
                Me.Igrac2.ForeColor = Color.Black
                Me.Igrac3.ForeColor = Color.Black
                Me.Igrac4.ForeColor = Color.DarkRed
            Case Me.Igrac4.Text
                Natjecatelj.Text = Me.Igrac1.Text
                Me.Igrac1.ForeColor = Color.DarkRed
                Me.Igrac2.ForeColor = Color.Black
                Me.Igrac3.ForeColor = Color.Black
                Me.Igrac4.ForeColor = Color.Black
        End Select
    End Sub

    Public Function dalj() As String
        m_StopTime = Now.Add(TimeSpan.Parse("00:00:31"))
        tmrWait.Enabled = True
        otvara = True
        x1()
        If T.A1.BackColor = Color.Yellow Then
            If T.B1.BackColor = Color.Yellow Then
                If T.C1.BackColor = Color.Yellow Then
                    If T.D1.BackColor = Color.Yellow Then
                        If T.A2.BackColor = Color.Yellow Then
                            If T.B2.BackColor = Color.Yellow Then
                                If T.C2.BackColor = Color.Yellow Then
                                    If T.D2.BackColor = Color.Yellow Then
                                        If T.A3.BackColor = Color.Yellow Then
                                            If T.B3.BackColor = Color.Yellow Then
                                                If T.C3.BackColor = Color.Yellow Then
                                                    If T.D3.BackColor = Color.Yellow Then
                                                        If T.A4.BackColor = Color.Yellow Then
                                                            If T.B4.BackColor = Color.Yellow Then
                                                                If T.C4.BackColor = Color.Yellow Then
                                                                    If T.D4.BackColor = Color.Yellow Then
                                                                        otvara = False
                                                                        rjesava = True
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        provdalj = True

        'If T.KON.BackColor = Color.Red Or T.KON.BackColor = Color.LightCoral Then
        '    Me.Label10.Text = ""
        '    Me.lblRemaining.Text = ""
        'End If
        Me.f2.Hide()
        Me.f3.Hide()
        Me.f4.Hide()
        Me.f5.Hide()
        Me.f6.Hide()

        'For Each f As System.Windows.Forms.Form In Me.MdiChildren
        '    ' If f.Name = "tablica" Then
        '    'For Each ff As System.Windows.Forms.Form In f.MdiChildren
        '    '    MessageBox.Show(f.Name & ": " & ff.Name)
        '    '    If ff.Name = "f2" Then
        '    '        ff.Close()
        '    '    End If
        '    'Next
        '    ' End If
        '    MessageBox.Show(f.Name)

        'Next
        Me.aktivniIgrac()
        'MessageBox.Show(Natjecatelj.Text)
        Return Natjecatelj.Text
    End Function

    Private Sub iskor()
        'Dim tr As SqlTransaction
        'Dim veza1 As New SqlConnection(My.Settings.veza)
        'veza1.Open()
        'tr = veza1.BeginTransaction
        'Dim komanda As New SqlCommand("update tablice set iskoristena=0", veza1, tr)
        'komanda.ExecuteNonQuery()
        'tr.Commit()
        'veza1.Close()
    End Sub


    Private Sub updateBodova()
        Dim tr As SqlTransaction
        Dim veza As New SqlConnection(My.Settings.veza)
        Dim komanda As SqlCommand
        Dim pogodioKON1 As Integer = 0
        Dim pogodioKON2 As Integer = 0
        Dim pogodioKON3 As Integer = 0
        Dim pogodioKON4 As Integer = 0
        veza.Open()
        tr = veza.BeginTransaction
        tb1 = bod1 - tabBod1
        tb2 = bod2 - tabBod2
        tb3 = bod3 - tabBod3
        tb4 = bod4 - tabBod4
        tabBod1 = bod1
        tabBod2 = bod2
        tabBod3 = bod3
        tabBod4 = bod4

        If T.KON.BackColor = Color.Red Then
            Select Case Natjecatelj.Text
                Case Igrac1.Text
                    'MessageBox.Show(Igrac1.Text)
                    pogodioKON1 = 1
                Case Igrac2.Text
                    'MessageBox.Show(Igrac2.Text)
                    pogodioKON2 = 1
                Case Igrac3.Text
                    'MessageBox.Show(Igrac3.Text)
                    pogodioKON3 = 1
                Case Igrac4.Text
                    'MessageBox.Show(Igrac4.Text)
                    pogodioKON4 = 1
            End Select
        End If
        'MessageBox.Show(Bodovanje.sifraKviza, "-")
        If i1.SifraNatjecatelja <> 0 Then
            Select Case i1.ImePrezime
                Case Me.Igrac1.Text
                    komanda = New SqlCommand("insert into NatjecateljTablica(sifraNatjecatelja, sifraTablice, osvojioBodova, pogodioKonacnoRjesenje, sifrakviza) values(" & i1.SifraNatjecatelja & ", " & Bodovanje.sifraTablice & ", " & tB1 & ", " & pogodioKON1 & ", " & Bodovanje.sifraKviza & ")", veza, tr)
                    komanda.ExecuteNonQuery()
                Case Me.Igrac2.Text
                    komanda = New SqlCommand("insert into NatjecateljTablica(sifraNatjecatelja, sifraTablice, osvojioBodova, pogodioKonacnoRjesenje, sifrakviza) values(" & i1.SifraNatjecatelja & ", " & Bodovanje.sifraTablice & ", " & tB2 & ", " & pogodioKON2 & ", " & Bodovanje.sifraKviza & ")", veza, tr)
                    komanda.ExecuteNonQuery()
                Case Me.Igrac3.Text
                    komanda = New SqlCommand("insert into NatjecateljTablica(sifraNatjecatelja, sifraTablice, osvojioBodova, pogodioKonacnoRjesenje, sifrakviza) values(" & i1.SifraNatjecatelja & ", " & Bodovanje.sifraTablice & ", " & tB3 & ", " & pogodioKON3 & ", " & Bodovanje.sifraKviza & ")", veza, tr)
                    komanda.ExecuteNonQuery()
                Case Me.Igrac4.Text
                    komanda = New SqlCommand("insert into NatjecateljTablica(sifraNatjecatelja, sifraTablice, osvojioBodova, pogodioKonacnoRjesenje, sifrakviza) values(" & i1.SifraNatjecatelja & ", " & Bodovanje.sifraTablice & ", " & tB4 & ", " & pogodioKON4 & ", " & Bodovanje.sifraKviza & ")", veza, tr)
                    komanda.ExecuteNonQuery()
            End Select
        End If
        If i2.SifraNatjecatelja <> 0 Then
            Select Case i2.ImePrezime
                Case Me.Igrac1.Text
                    komanda = New SqlCommand("insert into NatjecateljTablica(sifraNatjecatelja, sifraTablice, osvojioBodova, pogodioKonacnoRjesenje, sifrakviza) values(" & i2.SifraNatjecatelja & ", " & Bodovanje.sifraTablice & ", " & tB1 & ", " & pogodioKON1 & ", " & Bodovanje.sifraKviza & ")", veza, tr)
                    komanda.ExecuteNonQuery()
                Case Me.Igrac2.Text
                    komanda = New SqlCommand("insert into NatjecateljTablica(sifraNatjecatelja, sifraTablice, osvojioBodova, pogodioKonacnoRjesenje, sifrakviza) values(" & i2.SifraNatjecatelja & ", " & Bodovanje.sifraTablice & ", " & tB2 & ", " & pogodioKON2 & ", " & Bodovanje.sifraKviza & ")", veza, tr)
                    komanda.ExecuteNonQuery()
                Case Me.Igrac3.Text
                    komanda = New SqlCommand("insert into NatjecateljTablica(sifraNatjecatelja, sifraTablice, osvojioBodova, pogodioKonacnoRjesenje, sifrakviza) values(" & i2.SifraNatjecatelja & ", " & Bodovanje.sifraTablice & ", " & tB3 & ", " & pogodioKON3 & ", " & Bodovanje.sifraKviza & ")", veza, tr)
                    komanda.ExecuteNonQuery()
                Case Me.Igrac4.Text
                    komanda = New SqlCommand("insert into NatjecateljTablica(sifraNatjecatelja, sifraTablice, osvojioBodova, pogodioKonacnoRjesenje, sifrakviza) values(" & i2.SifraNatjecatelja & ", " & Bodovanje.sifraTablice & ", " & tB4 & ", " & pogodioKON4 & ", " & Bodovanje.sifraKviza & ")", veza, tr)
                    komanda.ExecuteNonQuery()
            End Select
        End If
        If i3.SifraNatjecatelja <> 0 Then
            Select Case i3.ImePrezime
                Case Me.Igrac1.Text
                    komanda = New SqlCommand("insert into NatjecateljTablica(sifraNatjecatelja, sifraTablice, osvojioBodova, pogodioKonacnoRjesenje, sifrakviza) values(" & i3.SifraNatjecatelja & ", " & Bodovanje.sifraTablice & ", " & tB1 & ", " & pogodioKON1 & ", " & Bodovanje.sifraKviza & ")", veza, tr)
                    komanda.ExecuteNonQuery()
                Case Me.Igrac2.Text
                    komanda = New SqlCommand("insert into NatjecateljTablica(sifraNatjecatelja, sifraTablice, osvojioBodova, pogodioKonacnoRjesenje, sifrakviza) values(" & i3.SifraNatjecatelja & ", " & Bodovanje.sifraTablice & ", " & tB2 & ", " & pogodioKON2 & ", " & Bodovanje.sifraKviza & ")", veza, tr)
                    komanda.ExecuteNonQuery()
                Case Me.Igrac3.Text
                    komanda = New SqlCommand("insert into NatjecateljTablica(sifraNatjecatelja, sifraTablice, osvojioBodova, pogodioKonacnoRjesenje, sifrakviza) values(" & i3.SifraNatjecatelja & ", " & Bodovanje.sifraTablice & ", " & tB3 & ", " & pogodioKON3 & ", " & Bodovanje.sifraKviza & ")", veza, tr)
                    komanda.ExecuteNonQuery()
                Case Me.Igrac4.Text
                    komanda = New SqlCommand("insert into NatjecateljTablica(sifraNatjecatelja, sifraTablice, osvojioBodova, pogodioKonacnoRjesenje, sifrakviza) values(" & i3.SifraNatjecatelja & ", " & Bodovanje.sifraTablice & ", " & tB4 & ", " & pogodioKON4 & ", " & Bodovanje.sifraKviza & ")", veza, tr)
                    komanda.ExecuteNonQuery()
            End Select
        End If
        If i4.SifraNatjecatelja <> 0 Then
            Select Case i4.ImePrezime
                Case Me.Igrac1.Text
                    komanda = New SqlCommand("insert into NatjecateljTablica(sifraNatjecatelja, sifraTablice, osvojioBodova, pogodioKonacnoRjesenje, sifrakviza) values(" & i4.SifraNatjecatelja & ", " & Bodovanje.sifraTablice & ", " & tB1 & ", " & pogodioKON1 & ", " & Bodovanje.sifraKviza & ")", veza, tr)
                    komanda.ExecuteNonQuery()
                Case Me.Igrac2.Text
                    komanda = New SqlCommand("insert into NatjecateljTablica(sifraNatjecatelja, sifraTablice, osvojioBodova, pogodioKonacnoRjesenje, sifrakviza) values(" & i4.SifraNatjecatelja & ", " & Bodovanje.sifraTablice & ", " & tB2 & ", " & pogodioKON2 & ", " & Bodovanje.sifraKviza & ")", veza, tr)
                    komanda.ExecuteNonQuery()
                Case Me.Igrac3.Text
                    komanda = New SqlCommand("insert into NatjecateljTablica(sifraNatjecatelja, sifraTablice, osvojioBodova, pogodioKonacnoRjesenje, sifrakviza) values(" & i4.SifraNatjecatelja & ", " & Bodovanje.sifraTablice & ", " & tB3 & ", " & pogodioKON3 & ", " & Bodovanje.sifraKviza & ")", veza, tr)
                    komanda.ExecuteNonQuery()
                Case Me.Igrac4.Text
                    komanda = New SqlCommand("insert into NatjecateljTablica(sifraNatjecatelja, sifraTablice, osvojioBodova, pogodioKonacnoRjesenje, sifrakviza) values(" & i4.SifraNatjecatelja & ", " & Bodovanje.sifraTablice & ", " & tB4 & ", " & pogodioKON4 & ", " & Bodovanje.sifraKviza & ")", veza, tr)
                    komanda.ExecuteNonQuery()
            End Select
        End If
        tr.Commit()
        veza.Close()

    End Sub

    Private Sub poredak()
        If bod1 >= bod2 Then
            If bod1 >= bod3 Then
                If bod1 >= bod4 Then
                    Mjesto1 = 1
                    If bod2 >= bod3 Then
                        If bod2 >= bod4 Then
                            Mjesto2 = 2
                            If bod3 >= bod4 Then
                                Mjesto3 = 3
                                Mjesto4 = 4
                            Else
                                Mjesto4 = 3
                                Mjesto3 = 4
                            End If
                        Else
                            Mjesto4 = 2
                            Mjesto2 = 3
                            Mjesto3 = 4
                        End If
                    Else
                        If bod3 >= bod4 Then
                            Mjesto3 = 2
                            If bod2 >= bod4 Then
                                Mjesto2 = 3
                                Mjesto4 = 4
                            Else
                                Mjesto4 = 3
                                Mjesto2 = 4
                            End If
                        Else
                            Mjesto4 = 2
                            Mjesto3 = 3
                            Mjesto2 = 4
                        End If
                    End If
                Else
                    Mjesto4 = 1
                    Mjesto1 = 2
                    If bod2 >= bod3 Then
                        Mjesto2 = 3
                        Mjesto3 = 4
                    Else
                        Mjesto3 = 3
                        Mjesto2 = 4
                    End If
                End If
            ElseIf bod1 >= bod4 Then
                Mjesto3 = 1
                Mjesto1 = 2
                If bod2 >= bod4 Then
                    Mjesto2 = 3
                    Mjesto4 = 4
                Else
                    Mjesto4 = 3
                    Mjesto2 = 4
                End If
            Else
                Mjesto1 = 3
                Mjesto2 = 4
                If bod3 >= bod4 Then
                    Mjesto3 = 1
                    Mjesto4 = 2
                Else
                    Mjesto4 = 1
                    Mjesto3 = 2
                End If
            End If
        ElseIf bod1 >= bod3 Then
            If bod1 >= bod4 Then
                Mjesto2 = 1
                Mjesto1 = 2
                If bod3 >= bod4 Then
                    Mjesto3 = 3
                    Mjesto4 = 4
                Else
                    Mjesto4 = 3
                    Mjesto3 = 4
                End If
            Else
                Mjesto1 = 3
                Mjesto3 = 4
                If bod2 >= bod4 Then
                    Mjesto2 = 1
                    Mjesto4 = 2
                Else
                    Mjesto4 = 1
                    Mjesto2 = 2
                End If
            End If
        ElseIf bod1 >= bod4 Then
            Mjesto1 = 3
            Mjesto4 = 4
            If bod2 >= bod3 Then
                Mjesto2 = 1
                Mjesto3 = 2
            Else
                Mjesto3 = 1
                Mjesto2 = 2
            End If
        Else
            Mjesto1 = 4
            If bod2 >= bod3 Then
                If bod2 >= bod4 Then
                    Mjesto2 = 1
                    If bod3 >= bod4 Then
                        Mjesto3 = 2
                        Mjesto4 = 3
                    Else
                        Mjesto4 = 2
                        Mjesto3 = 3
                    End If
                Else
                    Mjesto4 = 1
                    Mjesto2 = 2
                    Mjesto3 = 3
                End If
            ElseIf bod2 >= bod4 Then
                Mjesto3 = 1
                Mjesto2 = 2
                Mjesto4 = 3
            Else
                Mjesto2 = 3
                If bod3 >= bod4 Then
                    Mjesto3 = 1
                    Mjesto4 = 2
                Else
                    Mjesto4 = 1
                    Mjesto3 = 2
                End If
            End If
        End If
    End Sub

    Public Sub Dalje_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dalje.Click
        If x <= 0 Then
            LabelX.Text = ""
            Label10.Text = ""
            x = 9
            Button22_Click(Me, e)
            If Bodovanje.AsocBroj = 4 Then
                Dalje.Text = "KRAJ"
            Else
                Dalje.Text = "Iduća"
            End If
        Else
            If Dalje.Text = "Dalje !" Then
                dalj()
            End If
        End If


        If Dalje.Text = "Iduća" Then
            'Form8.Show()
            'T.Close()
            updateBodova()
            f2.Close()
            f3.Close()
            f4.Close()
            f5.Close()
            f6.Close()
            T.Close()
            UnesiTablicu()
        End If

        If Dalje.Text = "KRAJ" Then
            iskor()
            updateBodova()

            Dim tr As SqlTransaction
            Dim veza1 As New SqlConnection(My.Settings.veza)
            Dim komanda As SqlCommand
            veza1.Open()
            tr = veza1.BeginTransaction
            'komanda = New SqlCommand("select sifraKviza from Kviz", veza1)
            'veza1.Open()
            'Dim rs As SqlDataReader = komanda.ExecuteReader
            'While rs.Read
            '    Bodovanje.sifraKviza = rs.Item("sifraKviza")
            'End While
            poredak()
            If i1.SifraNatjecatelja <> 0 Then
                Select Case i1.ImePrezime
                    Case Me.Igrac1.Text
                        komanda = New SqlCommand("insert into NatjecateljKviz(sifraKviza, sifraNatjecatelja, konacniPlasman, ukupnoBodova) values(" & sifraKviza & ", " & i1.SifraNatjecatelja & ", " & Mjesto1 & ", " & bod1 & ")", veza1, tr)
                        komanda.ExecuteNonQuery()
                    Case Me.Igrac2.Text
                        komanda = New SqlCommand("insert into NatjecateljKviz(sifraKviza, sifraNatjecatelja, konacniPlasman, ukupnoBodova) values(" & sifraKviza & ", " & i1.SifraNatjecatelja & ", " & Mjesto2 & ", " & bod2 & ")", veza1, tr)
                        komanda.ExecuteNonQuery()
                    Case Me.Igrac3.Text
                        komanda = New SqlCommand("insert into NatjecateljKviz(sifraKviza, sifraNatjecatelja, konacniPlasman, ukupnoBodova) values(" & sifraKviza & ", " & i1.SifraNatjecatelja & ", " & Mjesto3 & ", " & bod3 & ")", veza1, tr)
                        komanda.ExecuteNonQuery()
                    Case Me.Igrac4.Text
                        komanda = New SqlCommand("insert into NatjecateljKviz(sifraKviza, sifraNatjecatelja, konacniPlasman, ukupnoBodova) values(" & sifraKviza & ", " & i1.SifraNatjecatelja & ", " & Mjesto4 & ", " & bod4 & ")", veza1, tr)
                        komanda.ExecuteNonQuery()
                End Select
            End If
            If i2.SifraNatjecatelja <> 0 Then
                Select Case i2.ImePrezime
                    Case Me.Igrac1.Text
                        komanda = New SqlCommand("insert into NatjecateljKviz(sifraKviza, sifraNatjecatelja, konacniPlasman, ukupnoBodova) values(" & sifraKviza & ", " & i2.SifraNatjecatelja & ", " & Mjesto1 & ", " & bod1 & ")", veza1, tr)
                        komanda.ExecuteNonQuery()
                    Case Me.Igrac2.Text
                        komanda = New SqlCommand("insert into NatjecateljKviz(sifraKviza, sifraNatjecatelja, konacniPlasman, ukupnoBodova) values(" & sifraKviza & ", " & i2.SifraNatjecatelja & ", " & Mjesto2 & ", " & bod2 & ")", veza1, tr)
                        komanda.ExecuteNonQuery()
                    Case Me.Igrac3.Text
                        komanda = New SqlCommand("insert into NatjecateljKviz(sifraKviza, sifraNatjecatelja, konacniPlasman, ukupnoBodova) values(" & sifraKviza & ", " & i2.SifraNatjecatelja & ", " & Mjesto3 & ", " & bod3 & ")", veza1, tr)
                        komanda.ExecuteNonQuery()
                    Case Me.Igrac4.Text
                        komanda = New SqlCommand("insert into NatjecateljKviz(sifraKviza, sifraNatjecatelja, konacniPlasman, ukupnoBodova) values(" & sifraKviza & ", " & i2.SifraNatjecatelja & ", " & Mjesto4 & ", " & bod4 & ")", veza1, tr)
                        komanda.ExecuteNonQuery()
                End Select
            End If
            If i3.SifraNatjecatelja <> 0 Then
                Select Case i3.ImePrezime
                    Case Me.Igrac1.Text
                        komanda = New SqlCommand("insert into NatjecateljKviz(sifraKviza, sifraNatjecatelja, konacniPlasman, ukupnoBodova) values(" & sifraKviza & ", " & i3.SifraNatjecatelja & ", " & Mjesto1 & ", " & bod1 & ")", veza1, tr)
                        komanda.ExecuteNonQuery()
                    Case Me.Igrac2.Text
                        komanda = New SqlCommand("insert into NatjecateljKviz(sifraKviza, sifraNatjecatelja, konacniPlasman, ukupnoBodova) values(" & sifraKviza & ", " & i3.SifraNatjecatelja & ", " & Mjesto2 & ", " & bod2 & ")", veza1, tr)
                        komanda.ExecuteNonQuery()
                    Case Me.Igrac3.Text
                        komanda = New SqlCommand("insert into NatjecateljKviz(sifraKviza, sifraNatjecatelja, konacniPlasman, ukupnoBodova) values(" & sifraKviza & ", " & i3.SifraNatjecatelja & ", " & Mjesto3 & ", " & bod3 & ")", veza1, tr)
                        komanda.ExecuteNonQuery()
                    Case Me.Igrac4.Text
                        komanda = New SqlCommand("insert into NatjecateljKviz(sifraKviza, sifraNatjecatelja, konacniPlasman, ukupnoBodova) values(" & sifraKviza & ", " & i3.SifraNatjecatelja & ", " & Mjesto4 & ", " & bod4 & ")", veza1, tr)
                        komanda.ExecuteNonQuery()
                End Select
            End If
            If i4.SifraNatjecatelja <> 0 Then
                Select Case i4.ImePrezime
                    Case Me.Igrac1.Text
                        komanda = New SqlCommand("insert into NatjecateljKviz(sifraKviza, sifraNatjecatelja, konacniPlasman, ukupnoBodova) values(" & sifraKviza & ", " & i4.SifraNatjecatelja & ", " & Mjesto1 & ", " & bod1 & ")", veza1, tr)
                        komanda.ExecuteNonQuery()
                    Case Me.Igrac2.Text
                        komanda = New SqlCommand("insert into NatjecateljKviz(sifraKviza, sifraNatjecatelja, konacniPlasman, ukupnoBodova) values(" & sifraKviza & ", " & i4.SifraNatjecatelja & ", " & Mjesto2 & ", " & bod2 & ")", veza1, tr)
                        komanda.ExecuteNonQuery()
                    Case Me.Igrac3.Text
                        komanda = New SqlCommand("insert into NatjecateljKviz(sifraKviza, sifraNatjecatelja, konacniPlasman, ukupnoBodova) values(" & sifraKviza & ", " & i4.SifraNatjecatelja & ", " & Mjesto3 & ", " & bod3 & ")", veza1, tr)
                        komanda.ExecuteNonQuery()
                    Case Me.Igrac4.Text
                        komanda = New SqlCommand("insert into NatjecateljKviz(sifraKviza, sifraNatjecatelja, konacniPlasman, ukupnoBodova) values(" & sifraKviza & ", " & i4.SifraNatjecatelja & ", " & Mjesto4 & ", " & bod4 & ")", veza1, tr)
                        komanda.ExecuteNonQuery()
                End Select
            End If

            tr.Commit()
            veza1.Close()
            PocetniIzbornik.Show()
            PocetniIzbornik.Label1.Show()
            PocetniIzbornik.Label2.Show()
            PocetniIzbornik.Izlaz.Show()
            PocetniIzbornik.Naslov.Show()
            PocetniIzbornik.GroupBox1.Show()
            Me.Close()
            f2.Close()
            f3.Close()
            f4.Close()
            f5.Close()
            f6.Close()
            T.Close()

        End If
        'x1()
    End Sub
    Public Sub seating()
        Dim i As Integer
        Randomize()
        i = 23 * Rnd() + 1
        'Console.WriteLine(i)
        Select Case i
            Case 1
                'Me.Natjecatelj.Text = i1.ImePrezime
                Me.Igrac1.Text = i1.ImePrezime
                Me.Igrac2.Text = i2.ImePrezime
                Me.Igrac3.Text = i3.ImePrezime
                Me.Igrac4.Text = i4.ImePrezime
            Case 2
                'Me.Natjecatelj.Text = i1.ImePrezime
                Me.Igrac1.Text = i1.ImePrezime
                Me.Igrac2.Text = i2.ImePrezime
                Me.Igrac3.Text = i4.ImePrezime
                Me.Igrac4.Text = i3.ImePrezime
            Case 3
                'Me.Natjecatelj.Text = i1.ImePrezime
                Me.Igrac1.Text = i1.ImePrezime
                Me.Igrac2.Text = i3.ImePrezime
                Me.Igrac3.Text = i2.ImePrezime
                Me.Igrac4.Text = i4.ImePrezime
            Case 4
                'Me.Natjecatelj.Text = i1.ImePrezime
                Me.Igrac1.Text = i1.ImePrezime
                Me.Igrac2.Text = i3.ImePrezime
                Me.Igrac3.Text = i4.ImePrezime
                Me.Igrac4.Text = i2.ImePrezime
            Case 5
                'Me.Natjecatelj.Text = i1.ImePrezime
                Me.Igrac1.Text = i1.ImePrezime
                Me.Igrac2.Text = i4.ImePrezime
                Me.Igrac3.Text = i2.ImePrezime
                Me.Igrac4.Text = i3.ImePrezime
            Case 6
                'Me.Natjecatelj.Text = i1.ImePrezime
                Me.Igrac1.Text = i1.ImePrezime
                Me.Igrac2.Text = i4.ImePrezime
                Me.Igrac3.Text = i3.ImePrezime
                Me.Igrac4.Text = i2.ImePrezime
            Case 7
                'Me.Natjecatelj.Text = i1.ImePrezime
                Me.Igrac1.Text = i2.ImePrezime
                Me.Igrac2.Text = i1.ImePrezime
                Me.Igrac3.Text = i3.ImePrezime
                Me.Igrac4.Text = i4.ImePrezime
            Case 8
                'Me.Natjecatelj.Text = i1.ImePrezime
                Me.Igrac1.Text = i2.ImePrezime
                Me.Igrac2.Text = i1.ImePrezime
                Me.Igrac3.Text = i4.ImePrezime
                Me.Igrac4.Text = i3.ImePrezime
            Case 9
                'Me.Natjecatelj.Text = i1.ImePrezime
                Me.Igrac1.Text = i2.ImePrezime
                Me.Igrac2.Text = i3.ImePrezime
                Me.Igrac3.Text = i1.ImePrezime
                Me.Igrac4.Text = i4.ImePrezime
            Case 10
                'Me.Natjecatelj.Text = i1.ImePrezime
                Me.Igrac1.Text = i2.ImePrezime
                Me.Igrac2.Text = i3.ImePrezime
                Me.Igrac3.Text = i4.ImePrezime
                Me.Igrac4.Text = i1.ImePrezime
            Case 11
                'Me.Natjecatelj.Text = i1.ImePrezime
                Me.Igrac1.Text = i2.ImePrezime
                Me.Igrac2.Text = i4.ImePrezime
                Me.Igrac3.Text = i1.ImePrezime
                Me.Igrac4.Text = i3.ImePrezime
            Case 12
                'Me.Natjecatelj.Text = i1.ImePrezime
                Me.Igrac1.Text = i2.ImePrezime
                Me.Igrac2.Text = i4.ImePrezime
                Me.Igrac3.Text = i3.ImePrezime
                Me.Igrac4.Text = i1.ImePrezime
            Case 13
                'Me.Natjecatelj.Text = i1.ImePrezime
                Me.Igrac1.Text = i3.ImePrezime
                Me.Igrac2.Text = i2.ImePrezime
                Me.Igrac3.Text = i1.ImePrezime
                Me.Igrac4.Text = i4.ImePrezime
            Case 14
                'Me.Natjecatelj.Text = i1.ImePrezime
                Me.Igrac1.Text = i3.ImePrezime
                Me.Igrac2.Text = i2.ImePrezime
                Me.Igrac3.Text = i4.ImePrezime
                Me.Igrac4.Text = i1.ImePrezime
            Case 15
                'Me.Natjecatelj.Text = i1.ImePrezime
                Me.Igrac1.Text = i3.ImePrezime
                Me.Igrac2.Text = i1.ImePrezime
                Me.Igrac3.Text = i2.ImePrezime
                Me.Igrac4.Text = i4.ImePrezime
            Case 16
                'Me.Natjecatelj.Text = i1.ImePrezime
                Me.Igrac1.Text = i3.ImePrezime
                Me.Igrac2.Text = i1.ImePrezime
                Me.Igrac3.Text = i4.ImePrezime
                Me.Igrac4.Text = i2.ImePrezime
            Case 17
                'Me.Natjecatelj.Text = i1.ImePrezime
                Me.Igrac1.Text = i3.ImePrezime
                Me.Igrac2.Text = i4.ImePrezime
                Me.Igrac3.Text = i2.ImePrezime
                Me.Igrac4.Text = i1.ImePrezime
            Case 18
                'Me.Natjecatelj.Text = i1.ImePrezime
                Me.Igrac1.Text = i3.ImePrezime
                Me.Igrac2.Text = i4.ImePrezime
                Me.Igrac3.Text = i1.ImePrezime
                Me.Igrac4.Text = i2.ImePrezime
            Case 19
                'Me.Natjecatelj.Text = i1.ImePrezime
                Me.Igrac1.Text = i4.ImePrezime
                Me.Igrac2.Text = i2.ImePrezime
                Me.Igrac3.Text = i3.ImePrezime
                Me.Igrac4.Text = i1.ImePrezime
            Case 20
                'Me.Natjecatelj.Text = i1.ImePrezime
                Me.Igrac1.Text = i4.ImePrezime
                Me.Igrac2.Text = i2.ImePrezime
                Me.Igrac3.Text = i1.ImePrezime
                Me.Igrac4.Text = i3.ImePrezime
            Case 21
                'Me.Natjecatelj.Text = i1.ImePrezime
                Me.Igrac1.Text = i4.ImePrezime
                Me.Igrac2.Text = i3.ImePrezime
                Me.Igrac3.Text = i2.ImePrezime
                Me.Igrac4.Text = i1.ImePrezime
            Case 22
                'Me.Natjecatelj.Text = i1.ImePrezime
                Me.Igrac1.Text = i4.ImePrezime
                Me.Igrac2.Text = i3.ImePrezime
                Me.Igrac3.Text = i1.ImePrezime
                Me.Igrac4.Text = i2.ImePrezime
            Case 23
                'Me.Natjecatelj.Text = i1.ImePrezime
                Me.Igrac1.Text = i4.ImePrezime
                Me.Igrac2.Text = i1.ImePrezime
                Me.Igrac3.Text = i2.ImePrezime
                Me.Igrac4.Text = i3.ImePrezime
            Case 24
                'Me.Natjecatelj.Text = i1.ImePrezime
                Me.Igrac1.Text = i4.ImePrezime
                Me.Igrac2.Text = i1.ImePrezime
                Me.Igrac3.Text = i3.ImePrezime
                Me.Igrac4.Text = i2.ImePrezime
            
        End Select
    End Sub

    Private Sub UnesiTablicu()
        'InitializeComponent()
        Dim m As Integer
        f2 = New Form2
        f3 = New Form3
        f4 = New Form4
        f5 = New Form5
        f6 = New Form6
        T = New Tablica(f2, f3, f4, f5, f6)
        T.A1.Text = "A1"
        T.A2.Text = "A2"
        T.A3.Text = "A3"
        T.A4.Text = "A4"
        T.B1.Text = "B1"
        T.B2.Text = "B2"
        T.B3.Text = "B3"
        T.B4.Text = "B4"
        T.C1.Text = "C1"
        T.C2.Text = "C2"
        T.C3.Text = "C3"
        T.C4.Text = "C4"
        T.D1.Text = "D1"
        T.D2.Text = "D2"
        T.D3.Text = "D3"
        T.D4.Text = "D4"
        T.SA.Text = "STUPAC A"
        T.SB.Text = "STUPAC B"
        T.SC.Text = "STUPAC C"
        T.SD.Text = "STUPAC D"
        T.KON.Text = "KONAČNO RJEŠENJE"
        T.A1.BackColor = Color.Linen
        T.A2.BackColor = Color.Linen
        T.A3.BackColor = Color.Linen
        T.A4.BackColor = Color.Linen
        T.B1.BackColor = Color.Linen
        T.B2.BackColor = Color.Linen
        T.B3.BackColor = Color.Linen
        T.B4.BackColor = Color.Linen
        T.C1.BackColor = Color.Linen
        T.C2.BackColor = Color.Linen
        T.C3.BackColor = Color.Linen
        T.C4.BackColor = Color.Linen
        T.D1.BackColor = Color.Linen
        T.D2.BackColor = Color.Linen
        T.D3.BackColor = Color.Linen
        T.D4.BackColor = Color.Linen
        T.SA.BackColor = Color.LightSteelBlue
        T.SB.BackColor = Color.LightSteelBlue
        T.SC.BackColor = Color.LightSteelBlue
        T.SD.BackColor = Color.LightSteelBlue
        T.KON.BackColor = Color.CornflowerBlue

        otvara = True
        OstaloKrugova = 3
        Bodovanje.AsocBroj = Bodovanje.AsocBroj + 1
        AsocBr.Text = "Asocijacija broj " & Bodovanje.AsocBroj & "/4"
        Dalje.Text = "Dalje !"
        Label10.Text = ""
        LabelX.Text = ""
        ReciDalje = "Dalje !"
        m_StopTime = Now.Add(TimeSpan.Parse("00:00:31"))
        tmrWait.Enabled = True
        bod1 = Me.bod01.Text
        bod2 = Me.bod02.Text
        bod3 = Me.bod03.Text
        bod4 = Me.bod04.Text

        Select Case Bodovanje.AsocBroj
            Case 1
                Natjecatelj.Text = Me.Igrac4.Text
            Case 2
                Natjecatelj.Text = Me.Igrac1.Text
            Case 3
                Natjecatelj.Text = Me.Igrac2.Text
            Case 4
                Natjecatelj.Text = Me.Igrac3.Text
        End Select
        Me.aktivniIgrac()
        'form10.AsocBr.Text = AsocBr.Text
        'Dim i As Integer
        'For K As Integer = 1 To 20
        '    Randomize()
        '    i = 15 * Rnd() + 1
        '    Console.WriteLine(i)
        'Next
        x = 9
        Dim provAso As Boolean = False
        For m = 1 To 100
            Dim veza As New SqlConnection(My.Settings.veza)
            Dim i As Integer
            Dim j As Integer

            Dim kom As New SqlCommand("select count(sifratablice) as 'j' from tablice", veza)
            veza.Open()

            Dim rs1 As SqlDataReader = kom.ExecuteReader
            While rs1.Read
                j = rs1.Item("j") - 1
                'j = 0
            End While
            For k As Integer = 1 To 20
                Randomize()
                i = j * Rnd() + 1
                Console.WriteLine(i)
                'If m = 10 Then MessageBox.Show(i)
            Next
            veza.Close()

            Dim komanda1 As New SqlCommand("SELECT COUNT(a.sifraNatjecatelja) AS 'ISK' FROM NatjecateljTablica AS a INNER JOIN Tablice AS b ON a.sifraTablice = b.sifraTablice WHERE (b.brojTablice = " & i & ") AND (a.sifraNatjecatelja = " & i1.SifraNatjecatelja & " OR a.sifraNatjecatelja = " & i2.SifraNatjecatelja & " OR a.sifraNatjecatelja = " & i3.SifraNatjecatelja & " OR a.sifraNatjecatelja = " & i4.SifraNatjecatelja & " ) ", veza)
            veza.Open()
            Dim rs2 As SqlDataReader = komanda1.ExecuteReader
            Dim isk As Integer
            While rs2.Read
                'MessageBox.Show(rs2.Item("ISK"))
                isk = rs2.Item("ISK")
            End While
            veza.Close()

            If isk = 0 Then
                Dim komanda As New SqlCommand("select sifraTablice, A1, A2, A3, A4, B1, B2, B3, B4, C1, C2, C3, C4, D1, D2, D3, D4, stupacA as 'SA', stupacB as 'SB', stupacC as 'SC', stupacD as 'SD', konacnoRjesenje as 'KON' from Tablice where brojTablice=" & i, veza)
                veza.Open()
                Dim rs As SqlDataReader = komanda.ExecuteReader
                'Dim isk As Integer
                While rs.Read
                    sifraTablice = rs.Item("sifraTablice")
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

                veza.Open()
                'MessageBox.Show(i)
                Dim komanda3 As New SqlCommand("SELECT sifraTablice AS 'Sifra' FROM Tablice WHERE (brojTablice = " & i & " ) ", veza)
                Dim rs3 As SqlDataReader = komanda3.ExecuteReader
                While rs3.Read
                    'MessageBox.Show(rs3.Item("Sifra"))
                    l = rs3.Item("Sifra")
                    'MessageBox.Show(l)
                End While
                veza.Close()
                m = 100
            End If

            If m = 99 Then
                Dim A3 As New Asoc003
                A3.Show()
                A3.Odustani.Hide()
                MessageBox.Show("Nema dovoljno tablica za nastavak kviza. Potrebno je da netko tko NIJE natjecatelj u ovom kvizu unese novu tablicu.")
                veza.Open()
                Dim komanda4 As New SqlCommand("SELECT sifraTablice AS 'Sifra' FROM Tablice WHERE (brojTablice = " & j + 1 & " ) ", veza)
                Dim rs As SqlDataReader = komanda4.ExecuteReader
                While rs.Read
                    l = rs.Item("Sifra")
                    sifraTablice = l
                    'MessageBox.Show(L)
                End While
                veza.Close()
                Dim e As System.EventArgs = AcceptButton
                Pauza_Click(Me, e)
                provAso = True
                Dim veza1 As New SqlConnection(My.Settings.veza)
                Dim tr As SqlTransaction
                veza1.Open()
                tr = veza1.BeginTransaction

                Dim komanda2 As New SqlCommand("insert into TabliceKviz(sifraKviza, sifraTablice) values(" & Bodovanje.sifraKviza & ", " & l & ")", veza1, tr)
                komanda2.ExecuteNonQuery()
                tr.Commit()
                veza1.Close()
            End If
        Next

        If provAso = False Then
            Dim veza1 As New SqlConnection(My.Settings.veza)
            Dim tr As SqlTransaction
            veza1.Open()
            tr = veza1.BeginTransaction
            Dim komanda2 As New SqlCommand("insert into TabliceKviz(sifraKviza, sifraTablice) values(" & Bodovanje.sifraKviza & ", " & l & ")", veza1, tr)
            komanda2.ExecuteNonQuery()
            tr.Commit()
            veza1.Close()
        End If

        T.MdiParent = Me
        T.Show()
        bool = True
        Me.lblRemaining.Show()

        'x1()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'PocetniIzbornik.NotifyIcon1.Dispose()
        Dim tr As SqlTransaction
        Dim veza As New SqlConnection(My.Settings.veza)

        Dim komanda As New SqlCommand("select count(sifraKviza) as 'BR' from Kviz", veza)
        veza.Open()
        Dim rs As SqlDataReader = komanda.ExecuteReader
        While rs.Read
            br = rs.Item("BR") + 1
        End While
        veza.Close()

        veza.Open()
        tr = veza.BeginTransaction
        Dim komanda1 As New SqlCommand("insert into Kviz(brojKviza, datumOdigravanja) values(" & br & ",  getdate())", veza, tr)
        komanda1.ExecuteNonQuery()
        tr.Commit()
        veza.Close()

        komanda = New SqlCommand("select sifraKviza from Kviz where brojKviza=" & br, veza)
        veza.Open()
        Dim rs1 As SqlDataReader = komanda.ExecuteReader
        While rs1.Read
            Bodovanje.sifraKviza = rs1.Item("sifraKviza")
        End While
        veza.Close()

        'Select Case AsocBroj
        '    Case 3
        '        AsocBroj = 4
        '    Case 2
        '        AsocBroj = 3
        '    Case 1
        '        AsocBroj = 2
        '    Case 0
        '        seating()
        '        AsocBroj = 1
        'End Select
        'If Bodovanje.AsocBroj = 0 Then
        seating()
        Me.bod01.Text = "0"
        Me.bod02.Text = "0"
        Me.bod03.Text = "0"
        Me.bod04.Text = "0"
        'End If

        'Me.Igrac2.Text = Bodovanje.Igrac1.ImePrezime
        'Me.Igrac3.Text = Bodovanje.Igrac2.ImePrezime
        'Me.Igrac4.Text = Bodovanje.Igrac3.ImePrezime
        'Me.Igrac1.Text = Bodovanje.Igrac4.ImePrezime

        'MessageBox.Show(Bodovanje.AsocBroj)

        UnesiTablicu()

        'Asoc003.Provjeri_Click(e)


        'Select Case i
        '    Case 1
        '        Dim Aso1 As Boolean
        '        If Aso1 = False Then
        '            Asoc1.A1.Text = Asoc001.A1.Text
        '            Asoc1.A2.Text = Asoc001.A2.Text
        '            Asoc1.A3.Text = Asoc001.A3.Text
        '            Asoc1.A4.Text = Asoc001.A4.Text
        '            Asoc1.B1.Text = Asoc001.B1.Text
        '            Asoc1.B2.Text = Asoc001.B2.Text
        '            Asoc1.B3.Text = Asoc001.B3.Text
        '            Asoc1.B4.Text = Asoc001.B4.Text
        '            Asoc1.C1.Text = Asoc001.C1.Text
        '            Asoc1.C2.Text = Asoc001.C2.Text
        '            Asoc1.C3.Text = Asoc001.C3.Text
        '            Asoc1.C4.Text = Asoc001.C4.Text
        '            Asoc1.D1.Text = Asoc001.D1.Text
        '            Asoc1.D2.Text = Asoc001.D2.Text
        '            Asoc1.D3.Text = Asoc001.D3.Text
        '            Asoc1.D4.Text = Asoc001.D4.Text
        '            Asoc1.SA.Text = Asoc001.SA.Text
        '            Asoc1.SB.Text = Asoc001.SB.Text
        '            Asoc1.SC.Text = Asoc001.SC.Text
        '            Asoc1.SD.Text = Asoc001.SD.Text
        '            Asoc1.KON.Text = Asoc001.KON.Text
        '            Aso1 = True
        '            provAso = True
        '        End If

        '    Case 2
        '        Dim Aso2 As Boolean
        '        If Aso2 = False Then
        '            Asoc1.A1.Text = Asoc002.A1.Text
        '            Asoc1.A2.Text = Asoc002.A2.Text
        '            Asoc1.A3.Text = Asoc002.A3.Text
        '            Asoc1.A4.Text = Asoc002.A4.Text
        '            Asoc1.B1.Text = Asoc002.B1.Text
        '            Asoc1.B2.Text = Asoc002.B2.Text
        '            Asoc1.B3.Text = Asoc002.B3.Text
        '            Asoc1.B4.Text = Asoc002.B4.Text
        '            Asoc1.C1.Text = Asoc002.C1.Text
        '            Asoc1.C2.Text = Asoc002.C2.Text
        '            Asoc1.C3.Text = Asoc002.C3.Text
        '            Asoc1.C4.Text = Asoc002.C4.Text
        '            Asoc1.D1.Text = Asoc002.D1.Text
        '            Asoc1.D2.Text = Asoc002.D2.Text
        '            Asoc1.D3.Text = Asoc002.D3.Text
        '            Asoc1.D4.Text = Asoc002.D4.Text
        '            Asoc1.SA.Text = Asoc002.SA.Text
        '            Asoc1.SB.Text = Asoc002.SB.Text
        '            Asoc1.SC.Text = Asoc002.SC.Text
        '            Asoc1.SD.Text = Asoc002.SD.Text
        '            Asoc1.KON.Text = Asoc002.KON.Text
        '            Aso2 = True
        '            provAso = True
        '        End If

        '    Case 3
        '        Dim Aso3 As Boolean
        '        If Aso3 = False Then
        '            Asoc1.A1.Text = Asoc003.A1.Text
        '            Asoc1.A2.Text = Asoc003.A2.Text
        '            Asoc1.A3.Text = Asoc003.A3.Text
        '            Asoc1.A4.Text = Asoc003.A4.Text
        '            Asoc1.B1.Text = Asoc003.B1.Text
        '            Asoc1.B2.Text = Asoc003.B2.Text
        '            Asoc1.B3.Text = Asoc003.B3.Text
        '            Asoc1.B4.Text = Asoc003.B4.Text
        '            Asoc1.C1.Text = Asoc003.C1.Text
        '            Asoc1.C2.Text = Asoc003.C2.Text
        '            Asoc1.C3.Text = Asoc003.C3.Text
        '            Asoc1.C4.Text = Asoc003.C4.Text
        '            Asoc1.D1.Text = Asoc003.D1.Text
        '            Asoc1.D2.Text = Asoc003.D2.Text
        '            Asoc1.D3.Text = Asoc003.D3.Text
        '            Asoc1.D4.Text = Asoc003.D4.Text
        '            Asoc1.SA.Text = Asoc003.SA.Text
        '            Asoc1.SB.Text = Asoc003.SB.Text
        '            Asoc1.SC.Text = Asoc003.SC.Text
        '            Asoc1.SD.Text = Asoc003.SD.Text
        '            Asoc1.KON.Text = Asoc003.KON.Text
        '            Aso3 = True
        '            provAso = True
        '        End If
        'End Select

    End Sub

    'Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
    '    Dim duration As TimeSpan = TimeSpan.Parse(txtTime.Text)
    '    m_StopTime = Now.Add(duration)

    '    tmrWait.Enabled = True
    'End Sub

    'Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    '    Dim remaining As TimeSpan = m_StopTime.Subtract(Now)
    '    remaining = New TimeSpan(remaining.Hours, _
    '        remaining.Minutes, remaining.Seconds)
    '    If remaining.TotalSeconds < 0 Then remaining = _
    '        TimeSpan.Zero
    '    lblRemaining.Text = remaining.ToString

    '    If remaining.TotalSeconds <= 0 Then
    '        Me.WindowState = FormWindowState.Maximized
    '        Me.TopMost = True
    '        tmrWait.Enabled = False
    '    End If
    'End Sub


    Private Sub tmrWait_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrWait.Tick
        Dim remaining As TimeSpan = m_StopTime.Subtract(Now)
        remaining = New TimeSpan(remaining.Hours, remaining.Minutes, remaining.Seconds)
        If remaining.TotalSeconds < 0 Then remaining = TimeSpan.Zero
        If provdalj = False Then dalj()
        If zbroji = True Then zbroj()
        tmrWait.Enabled = bool
        If bool = False Then Me.lblRemaining.Text = ""
        Select Case OstaloKrugova
            Case 2
                Me.Label10.Text = "Preostalo Krugova: 2"
            Case 1
                Me.Label10.Text = "Preostalo Krugova: 1"
            Case 0
                Me.Label10.Text = "Preostalo Krugova: 0"
                Button22_Click(Me, e)
            Case Else
                Me.Label10.Text = ""
        End Select
        Me.Dalje.Text = ReciDalje
        Me.lblRemaining.Text = remaining.ToString
        Trim(Me.lblRemaining.Text)
        Me.lblRemaining.Text = Microsoft.VisualBasic.Right(Me.lblRemaining.Text, 2)

        If remaining.TotalSeconds <= 0 Then
            tmrWait.Enabled = False
            Dalje_Click(Me, e)
        End If
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        f2.Hide()
        f3.Hide()
        f4.Hide()
        f5.Hide()
        f6.Hide()
        x = -1
        bool = False
        OstaloKrugova = 3
        tmrWait.Enabled = False
        Me.Label10.Text = ""
        Me.lblRemaining.Hide()
        otvara = False
        rjesava = False
        If T.A1.BackColor <> Color.Yellow Then
            T.A1.BackColor = Color.LightYellow
            T.A1.Text = Asoc1.A1.Text
        End If
        If T.B1.BackColor <> Color.Yellow Then
            T.B1.BackColor = Color.LightYellow
            T.B1.Text = Asoc1.B1.Text
        End If
        If T.C1.BackColor <> Color.Yellow Then
            T.C1.BackColor = Color.LightYellow
            T.C1.Text = Asoc1.C1.Text
        End If
        If T.D1.BackColor <> Color.Yellow Then
            T.D1.BackColor = Color.LightYellow
            T.D1.Text = Asoc1.D1.Text
        End If
        If T.A2.BackColor <> Color.Yellow Then
            T.A2.BackColor = Color.LightYellow
            T.A2.Text = Asoc1.A2.Text
        End If
        If T.B2.BackColor <> Color.Yellow Then
            T.B2.BackColor = Color.LightYellow
            T.B2.Text = Asoc1.B2.Text
        End If
        If T.C2.BackColor <> Color.Yellow Then
            T.C2.BackColor = Color.LightYellow
            T.C2.Text = Asoc1.C2.Text
        End If
        If T.D2.BackColor <> Color.Yellow Then
            T.D2.BackColor = Color.LightYellow
            T.D2.Text = Asoc1.D2.Text
        End If
        If T.A3.BackColor <> Color.Yellow Then
            T.A3.BackColor = Color.LightYellow
            T.A3.Text = Asoc1.A3.Text
        End If
        If T.B3.BackColor <> Color.Yellow Then
            T.B3.BackColor = Color.LightYellow
            T.B3.Text = Asoc1.B3.Text
        End If
        If T.C3.BackColor <> Color.Yellow Then
            T.C3.BackColor = Color.LightYellow
            T.C3.Text = Asoc1.C3.Text
        End If
        If T.D3.BackColor <> Color.Yellow Then
            T.D3.BackColor = Color.LightYellow
            T.D3.Text = Asoc1.D3.Text
        End If
        If T.A4.BackColor <> Color.Yellow Then
            T.A4.BackColor = Color.LightYellow
            T.A4.Text = Asoc1.A4.Text
        End If
        If T.B4.BackColor <> Color.Yellow Then
            T.B4.BackColor = Color.LightYellow
            T.B4.Text = Asoc1.B4.Text
        End If
        If T.C4.BackColor <> Color.Yellow Then
            T.C4.BackColor = Color.LightYellow
            T.C4.Text = Asoc1.C4.Text
        End If
        If T.D4.BackColor <> Color.Yellow Then
            T.D4.BackColor = Color.LightYellow
            T.D4.Text = Asoc1.D4.Text
        End If
        If T.SA.BackColor <> Color.Green Then
            T.SA.BackColor = Color.LightGreen
            T.SA.Text = Asoc1.SA.Text
        End If
        If T.SB.BackColor <> Color.Green Then
            T.SB.BackColor = Color.LightGreen
            T.SB.Text = Asoc1.SB.Text
        End If
        If T.SC.BackColor <> Color.Green Then
            T.SC.BackColor = Color.LightGreen
            T.SC.Text = Asoc1.SC.Text
        End If
        If T.SD.BackColor <> Color.Green Then
            T.SD.BackColor = Color.LightGreen
            T.SD.Text = Asoc1.SD.Text
        End If
        If T.KON.BackColor <> Color.Red Then
            T.KON.BackColor = Color.LightCoral
            T.KON.Text = Asoc1.KON.Text
            'T.Show()
            SLIJEDI()
            Dalje.Text = ReciDalje
        End If

    End Sub

    Public Shared Sub SLIJEDI()
        bool = False
        
        If Bodovanje.AsocBroj >= 4 Then
            ReciDalje = "KRAJ"
        Else
            ReciDalje = "Iduća"
            'Label9.Text = "Pobjednik je:"
        End If
    End Sub

    Private Sub IzlazToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Result As DialogResult
        Result = MessageBox.Show("Jeste li sigurni da želite prekinuti ovaj kviz?", "Potvrdite izlaz", _
                 MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If Result = System.Windows.Forms.DialogResult.Yes Then
            PocetniIzbornik.Show()
            PocetniIzbornik.Label1.Show()
            PocetniIzbornik.Label2.Show()
            PocetniIzbornik.Izlaz.Show()
            PocetniIzbornik.Naslov.Show()
            PocetniIzbornik.GroupBox1.Show()
            Me.Close()
            f2.Close()
            f3.Close()
            f4.Close()
            f5.Close()
            f6.Close()
            T.Close()
        End If
    End Sub

    Private Sub IzlazToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IzlazToolStripMenuItem1.Click
        Dim Result As DialogResult
        Result = MessageBox.Show("Jeste li sigurni da želite prekinuti ovaj kviz?", "Potvrdite izlaz", _
                 MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If Result = System.Windows.Forms.DialogResult.Yes Then
            PocetniIzbornik.Show()
            PocetniIzbornik.Label1.Show()
            PocetniIzbornik.Label2.Show()
            PocetniIzbornik.Izlaz.Show()
            PocetniIzbornik.Naslov.Show()
            PocetniIzbornik.GroupBox1.Show()
            Me.Close()
            f2.Close()
            f3.Close()
            f4.Close()
            f5.Close()
            f6.Close()
            T.Close()
        End If
    End Sub

    Private Sub Pauza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pauza.Click
        If tmrWait.Enabled = True Then
            tmrWait.Enabled = False
            Me.f2.Hide()
            Me.f3.Hide()
            Me.f4.Hide()
            Me.f5.Hide()
            Me.f6.Hide()
            Me.Pauza.Text = "Nastavi"
            Me.PauzaSlika.Show()
        Else
            tmrWait.Enabled = True
            m_StopTime = Now.Add(TimeSpan.Parse("00:00:" & lblRemaining.Text))
            Me.Pauza.Text = "Pauza"
            Me.PauzaSlika.Hide()
            If otvara = False Then rjesava = True
        End If
    End Sub

    Private Sub PauzaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PauzaToolStripMenuItem.Click
        If tmrWait.Enabled = True Then
            tmrWait.Enabled = False
            Me.f2.Hide()
            Me.f3.Hide()
            Me.f4.Hide()
            Me.f5.Hide()
            Me.f6.Hide()
            Me.Pauza.Text = "Nastavi"
            Me.PauzaSlika.Show()
        Else
            tmrWait.Enabled = True
            m_StopTime = Now.Add(TimeSpan.Parse("00:00:" & lblRemaining.Text))
            Me.Pauza.Text = "Pauza"
            Me.PauzaSlika.Hide()
            If otvara = False Then rjesava = True
        End If
    End Sub

    'Private Sub PauzaSlika_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PauzaSlika.Click
    '    tmrWait.Enabled = True
    '    m_StopTime = Now.Add(TimeSpan.Parse("00:00:" & lblRemaining.Text))
    '    Me.PauzaSlika.Hide()
    '    If otvara = False Then rjesava = True
    'End Sub

    Private Sub IzlazIzProToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Result As DialogResult
        Result = MessageBox.Show("Jeste li sigurni da želite izići iz programa?", "Potvrdite izlaz", _
                 MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If Result = System.Windows.Forms.DialogResult.Yes Then PocetniIzbornik.Close()
    End Sub

End Class

