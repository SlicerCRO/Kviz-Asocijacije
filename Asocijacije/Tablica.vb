Imports Asocijacije.Form1
Public Class Tablica
    Dim f1 As Form1
    Dim f2 As Form2
    Dim f3 As Form3
    Dim f4 As Form4
    Dim f5 As Form5
    Dim f6 As Form6

    Public Sub New(ByVal f2 As Form2, ByVal f3 As Form3, ByVal f4 As Form4, ByVal f5 As Form5, ByVal f6 As Form6)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.f2 = f2
        Me.f3 = f3
        Me.f4 = f4
        Me.f5 = f5
        Me.f6 = f6
    End Sub

    'Public Function x1() As Integer
    '    If Me.A1.BackColor = Color.Yellow Then
    '        If Me.B1.BackColor = Color.Yellow Then
    '            If Me.C1.BackColor = Color.Yellow Then
    '                If Me.D1.BackColor = Color.Yellow Then
    '                    If Me.A2.BackColor = Color.Yellow Then
    '                        If Me.B2.BackColor = Color.Yellow Then
    '                            If Me.C2.BackColor = Color.Yellow Then
    '                                If Me.D2.BackColor = Color.Yellow Then
    '                                    If Me.A3.BackColor = Color.Yellow Then
    '                                        If Me.B3.BackColor = Color.Yellow Then
    '                                            If Me.C3.BackColor = Color.Yellow Then
    '                                                If Me.D3.BackColor = Color.Yellow Then
    '                                                    If Me.A4.BackColor = Color.Yellow Then
    '                                                        If Me.B4.BackColor = Color.Yellow Then
    '                                                            If Me.C4.BackColor = Color.Yellow Then
    '                                                                If Me.D4.BackColor = Color.Yellow Then
    '                                                                    rjesava = True
    '                                                                    otvara = False
    '                                                                    x = x - 1
    '                                                                    Select Case x
    '                                                                        Case 5 To 8
    '                                                                            OstaloKrugova = 2
    '                                                                        Case 1 To 4
    '                                                                            OstaloKrugova = 1
    '                                                                        Case Else
    '                                                                            OstaloKrugova = 0
    '                                                                    End Select
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

    'Public Function x2() As Integer
    '    If Me.A1.BackColor = Color.Yellow Then
    '        If Me.B1.BackColor = Color.Yellow Then
    '            If Me.C1.BackColor = Color.Yellow Then
    '                If Me.D1.BackColor = Color.Yellow Then
    '                    If Me.A2.BackColor = Color.Yellow Then
    '                        If Me.B2.BackColor = Color.Yellow Then
    '                            If Me.C2.BackColor = Color.Yellow Then
    '                                If Me.D2.BackColor = Color.Yellow Then
    '                                    If Me.A3.BackColor = Color.Yellow Then
    '                                        If Me.B3.BackColor = Color.Yellow Then
    '                                            If Me.C3.BackColor = Color.Yellow Then
    '                                                If Me.D3.BackColor = Color.Yellow Then
    '                                                    If Me.A4.BackColor = Color.Yellow Then
    '                                                        If Me.B4.BackColor = Color.Yellow Then
    '                                                            If Me.C4.BackColor = Color.Yellow Then
    '                                                                If Me.D4.BackColor = Color.Yellow Then
    '                                                                    rjesava = True
    '                                                                    otvara = False
    '                                                                    x = x + 1
    '                                                                    Select Case x
    '                                                                        Case 5 To 8
    '                                                                            OstaloKrugova = 2
    '                                                                        Case 1 To 4
    '                                                                            OstaloKrugova = 1
    '                                                                        Case Else
    '                                                                            OstaloKrugova = 0
    '                                                                    End Select
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


    Private Sub pozatvaraj()
        'f2.hide()
        'f3.Hide()
        'f4.Hide()
        'f5.Hide()
        'f6.Hide()
    End Sub

    Private Sub A1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1.Click
        pozatvaraj()
        If otvara = True Then
            rjesava = True
            If Me.A1.BackColor <> Color.Yellow Then otvara = False
            Me.A1.BackColor = Color.Yellow
            Me.A1.Text = Asoc1.A1.Text
            'x1()
        End If
    End Sub

    Private Sub B1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1.Click
        pozatvaraj()
        If otvara = True Then
            rjesava = True
            If Me.B1.BackColor <> Color.Yellow Then otvara = False
            Me.B1.BackColor = Color.Yellow
            Me.B1.Text = Asoc1.B1.Text
            'x1()
        End If
    End Sub

    Private Sub C1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1.Click
        pozatvaraj()
        If otvara = True Then
            rjesava = True
            If Me.C1.BackColor <> Color.Yellow Then otvara = False
            Me.C1.BackColor = Color.Yellow
            Me.C1.Text = Asoc1.C1.Text
            'x1()
        End If
    End Sub

    Private Sub D1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D1.Click
        pozatvaraj()
        If otvara = True Then
            rjesava = True
            If Me.D1.BackColor <> Color.Yellow Then otvara = False
            Me.D1.BackColor = Color.Yellow
            Me.D1.Text = Asoc1.D1.Text
            'x1()
        End If
    End Sub

    Private Sub A2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A2.Click
        pozatvaraj()
        If otvara = True Then
            rjesava = True
            If Me.A2.BackColor <> Color.Yellow Then otvara = False
            Me.A2.BackColor = Color.Yellow
            Me.A2.Text = Asoc1.A2.Text
            'x1()
        End If
    End Sub

    Private Sub B2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B2.Click
        pozatvaraj()
        If otvara = True Then
            rjesava = True
            If Me.B2.BackColor <> Color.Yellow Then otvara = False
            Me.B2.BackColor = Color.Yellow
            Me.B2.Text = Asoc1.B2.Text
            'x1()
        End If
    End Sub

    Private Sub C2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C2.Click
        pozatvaraj()
        If otvara = True Then
            rjesava = True
            If Me.C2.BackColor <> Color.Yellow Then otvara = False
            Me.C2.BackColor = Color.Yellow
            Me.C2.Text = Asoc1.C2.Text
            'x1()
        End If
    End Sub

    Private Sub D2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D2.Click
        pozatvaraj()
        If otvara = True Then
            rjesava = True
            If Me.D2.BackColor <> Color.Yellow Then otvara = False
            Me.D2.BackColor = Color.Yellow
            Me.D2.Text = Asoc1.D2.Text
            'x1()
        End If
    End Sub

    Private Sub A3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A3.Click
        pozatvaraj()
        If otvara = True Then
            rjesava = True
            If Me.A3.BackColor <> Color.Yellow Then otvara = False
            Me.A3.BackColor = Color.Yellow
            Me.A3.Text = Asoc1.A3.Text
            'x1()
        End If
    End Sub

    Private Sub B3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B3.Click
        pozatvaraj()
        If otvara = True Then
            rjesava = True
            If Me.B3.BackColor <> Color.Yellow Then otvara = False
            Me.B3.BackColor = Color.Yellow
            Me.B3.Text = Asoc1.B3.Text
            'x1()
        End If
    End Sub

    Private Sub C3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C3.Click
        pozatvaraj()
        If otvara = True Then
            rjesava = True
            If Me.C3.BackColor <> Color.Yellow Then otvara = False
            Me.C3.BackColor = Color.Yellow
            Me.C3.Text = Asoc1.C3.Text
            'x1()
        End If
    End Sub

    Private Sub D3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D3.Click
        pozatvaraj()
        If otvara = True Then
            rjesava = True
            If Me.D3.BackColor <> Color.Yellow Then otvara = False
            Me.D3.BackColor = Color.Yellow
            Me.D3.Text = Asoc1.D3.Text
            'x1()
        End If
    End Sub

    Private Sub A4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A4.Click
        pozatvaraj()
        If otvara = True Then
            rjesava = True
            If Me.A4.BackColor <> Color.Yellow Then otvara = False
            Me.A4.BackColor = Color.Yellow
            Me.A4.Text = Asoc1.A4.Text
            'x1()
        End If
    End Sub

    Private Sub B4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B4.Click
        pozatvaraj()
        If otvara = True Then
            rjesava = True
            If Me.B4.BackColor <> Color.Yellow Then otvara = False
            Me.B4.BackColor = Color.Yellow
            Me.B4.Text = Asoc1.B4.Text
            'x1()
        End If
    End Sub

    Private Sub C4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C4.Click
        pozatvaraj()
        If otvara = True Then
            rjesava = True
            If Me.C4.BackColor <> Color.Yellow Then otvara = False
            Me.C4.BackColor = Color.Yellow
            Me.C4.Text = Asoc1.C4.Text
            'x1()
        End If
    End Sub

    Private Sub D4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D4.Click
        pozatvaraj()
        If otvara = True Then
            rjesava = True
            If Me.D4.BackColor <> Color.Yellow Then otvara = False
            Me.D4.BackColor = Color.Yellow
            Me.D4.Text = Asoc1.D4.Text
            'x1()
        End If
    End Sub

    Public Sub SA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SA.Click
        pozatvaraj()
        If otvara = False Then
            If rjesava = True Then
                'rjesava = False
                If Me.SA.BackColor <> Color.Green Then
                    If Me.SA.BackColor <> Color.LightGreen Then
                        'Dim f2 As New Form2
                        f2.MdiParent = f1
                        f2.TextBox1.Text = ""
                        f2.Show()
                        ''x1()
                    End If
                End If
            End If
        End If


    End Sub


    Public Sub SB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SB.Click
        pozatvaraj()
        If otvara = False Then
            If rjesava = True Then
                'rjesava = False
                If Me.SB.BackColor <> Color.Green Then
                    If Me.SB.BackColor <> Color.LightGreen Then
                        'Dim f3 As New Form3
                        f3.MdiParent = f1
                        f3.TextBox1.Text = ""
                        f3.Show()
                        ''x1()
                    End If
                End If
            End If
        End If


    End Sub


    Public Sub SC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SC.Click
        pozatvaraj()
        If otvara = False Then
            If rjesava = True Then
                'rjesava = False
                If Me.SC.BackColor <> Color.Green Then
                    If Me.SC.BackColor <> Color.LightGreen Then
                        'Dim f4 As New Form4
                        f4.MdiParent = f1
                        f4.TextBox1.Text = ""
                        f4.Show()
                        ''x1()
                    End If
                End If
            End If
        End If


    End Sub


    Public Sub SD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SD.Click
        pozatvaraj()
        If otvara = False Then
            If rjesava = True Then
                'rjesava = False
                If Me.SD.BackColor <> Color.Green Then
                    If Me.SD.BackColor <> Color.LightGreen Then
                        'Dim f5 As New Form5
                        f5.MdiParent = f1
                        f5.TextBox1.Text = ""
                        f5.Show()
                        ''x1()
                    End If
                End If
            End If
        End If


    End Sub


    Public Sub KON_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KON.Click
        pozatvaraj()
        If otvara = False Then
            If rjesava = True Then
                'rjesava = False
                If Me.KON.BackColor <> Color.Red Then
                    If Me.KON.BackColor <> Color.LightCoral Then
                        'Dim f6 As New Form6
                        f6.MdiParent = f1
                        f6.TextBox1.Text = ""
                        f6.Show()
                        ''x1()
                    End If
                End If
            End If
        End If


    End Sub

    Public Sub SA_Change()
        If Me.SA.BackColor = Color.Green Then
            If Me.KON.BackColor <> Color.Red Then
                rjesava = True
                otvara = False
                bodTr = bodTr + 5
            End If
            If Me.A1.BackColor <> Color.Yellow Then
                Me.A1.BackColor = Color.Yellow
                Me.A1.Text = Asoc1.A1.Text
                bodTr = bodTr + 1
            End If
            If Me.A2.BackColor <> Color.Yellow Then
                Me.A2.BackColor = Color.Yellow
                Me.A2.Text = Asoc1.A2.Text
                bodTr = bodTr + 1
            End If
            If Me.A3.BackColor <> Color.Yellow Then
                Me.A3.BackColor = Color.Yellow
                Me.A3.Text = Asoc1.A3.Text
                bodTr = bodTr + 1
            End If
            If Me.A4.BackColor <> Color.Yellow Then
                Me.A4.BackColor = Color.Yellow
                Me.A4.Text = Asoc1.A4.Text
                bodTr = bodTr + 1
            End If
            m_StopTime = Now.Add(TimeSpan.Parse("00:00:21"))
            zbroji = True
            rjesava = True
        End If
    End Sub

    Public Sub SB_Change()
        If Me.SB.BackColor = Color.Green Then
            If Me.KON.BackColor <> Color.Red Then
                rjesava = True
                otvara = False
                bodTr = bodTr + 5
            End If
            If Me.B1.BackColor <> Color.Yellow Then
                Me.B1.BackColor = Color.Yellow
                Me.B1.Text = Asoc1.B1.Text
                bodTr = bodTr + 1
            End If
            If Me.B2.BackColor <> Color.Yellow Then
                Me.B2.BackColor = Color.Yellow
                Me.B2.Text = Asoc1.B2.Text
                bodTr = bodTr + 1
            End If
            If Me.B3.BackColor <> Color.Yellow Then
                Me.B3.BackColor = Color.Yellow
                Me.B3.Text = Asoc1.B3.Text
                bodTr = bodTr + 1
            End If
            If Me.B4.BackColor <> Color.Yellow Then
                Me.B4.BackColor = Color.Yellow
                Me.B4.Text = Asoc1.B4.Text
                bodTr = bodTr + 1
            End If
            m_StopTime = Now.Add(TimeSpan.Parse("00:00:21"))
            zbroji = True
            rjesava = True
        End If
    End Sub


    Public Sub SC_Change()
        If Me.SC.BackColor = Color.Green Then
            If Me.KON.BackColor <> Color.Red Then
                rjesava = True
                otvara = False
                bodTr = bodTr + 5
            End If
            If Me.C1.BackColor <> Color.Yellow Then
                Me.C1.BackColor = Color.Yellow
                Me.C1.Text = Asoc1.C1.Text
                bodTr = bodTr + 1
            End If
            If Me.C2.BackColor <> Color.Yellow Then
                Me.C2.BackColor = Color.Yellow
                Me.C2.Text = Asoc1.C2.Text
                bodTr = bodTr + 1
            End If
            If Me.C3.BackColor <> Color.Yellow Then
                Me.C3.BackColor = Color.Yellow
                Me.C3.Text = Asoc1.C3.Text
                bodTr = bodTr + 1
            End If
            If Me.C4.BackColor <> Color.Yellow Then
                Me.C4.BackColor = Color.Yellow
                Me.C4.Text = Asoc1.C4.Text
                bodTr = bodTr + 1
            End If
            m_StopTime = Now.Add(TimeSpan.Parse("00:00:21"))
            zbroji = True
            rjesava = True
        End If
    End Sub

    Public Sub SD_Change()
        If Me.SD.BackColor = Color.Green Then
            If Me.KON.BackColor <> Color.Red Then
                rjesava = True
                otvara = False
                bodTr = bodTr + 5
            End If
            If Me.D1.BackColor <> Color.Yellow Then
                Me.D1.BackColor = Color.Yellow
                Me.D1.Text = Asoc1.D1.Text
                bodTr = bodTr + 1
            End If
            If Me.D2.BackColor <> Color.Yellow Then
                Me.D2.BackColor = Color.Yellow
                Me.D2.Text = Asoc1.D2.Text
                bodTr = bodTr + 1
            End If
            If Me.D3.BackColor <> Color.Yellow Then
                Me.D3.BackColor = Color.Yellow
                Me.D3.Text = Asoc1.D3.Text
                bodTr = bodTr + 1
            End If
            If Me.D4.BackColor <> Color.Yellow Then
                Me.D4.BackColor = Color.Yellow
                Me.D4.Text = Asoc1.D4.Text
                bodTr = bodTr + 1
            End If
            m_StopTime = Now.Add(TimeSpan.Parse("00:00:21"))
            zbroji = True
            rjesava = True
        End If
    End Sub

    'Public Function zbroj() As Integer
    '    m_StopTime = Now.Add(TimeSpan.Parse("00:00:31"))
    '    f1.tmrWait.Enabled = True
    '    Select Case f1.Natjecatelj.Text
    '        Case f1.Igrac1.Text
    '            bod1 = bod1 + bodTr
    '            'form10.bod01.Text = bod1
    '            f1.bod01.Text = bod1
    '            bodTr = 0
    '            Return bod1
    '        Case f1.Igrac2.Text
    '            bod2 = bod2 + bodTr
    '            'form10.bod02.Text = bod2
    '            f1.bod02.Text = bod2
    '            bodTr = 0
    '            Return bod2
    '        Case f1.Igrac3.Text
    '            bod3 = bod3 + bodTr
    '            'form10.bod03.Text = bod3
    '            f1.bod03.Text = bod3
    '            bodTr = 0
    '            Return bod3
    '        Case f1.Igrac4.Text
    '            bod4 = bod4 + bodTr
    '            'form10.bod04.Text = bod4
    '            f1.bod04.Text = bod4
    '            bodTr = 0
    '            Return bod4
    '    End Select
    'End Function

    Public Sub KON_Change()
        If Me.KON.BackColor = Color.Red Then
            ''x2()
            'If Bodovanje.AsocBroj = 4 Then
            '    f1.Dalje.Text = "KRAJ"
            'Else
            '    f1.Dalje.Text = "Iduća"
            '    'Label9.Text = "Pobjednik je:"
            'End If
            x = -1
            OstaloKrugova = 3
            

            SLIJEDI()
            bodTr = 10

            If Me.SA.BackColor <> Color.Green Then
                Me.SA.BackColor = Color.Green
                bodTr = bodTr + 3
                SA_Change()
                Me.SA.Text = Asoc1.SA.Text
            End If
            If Me.SB.BackColor <> Color.Green Then
                Me.SB.BackColor = Color.Green
                bodTr = bodTr + 3
                SB_Change()
                Me.SB.Text = Asoc1.SB.Text
            End If
            If Me.SC.BackColor <> Color.Green Then
                Me.SC.BackColor = Color.Green
                bodTr = bodTr + 3
                SC_Change()
                Me.SC.Text = Asoc1.SC.Text
            End If
            If Me.SD.BackColor <> Color.Green Then
                Me.SD.BackColor = Color.Green
                bodTr = bodTr + 3
                SD_Change()
                Me.SD.Text = Asoc1.SD.Text
            End If
            zbroji = True
        End If
        If Me.KON.BackColor = Color.LightCoral Then
            SLIJEDI()
            'If f1.AsocBr.Text = "Asocijacija 4/4" Then
            '    f1.Dalje.Text = "KRAJ"
            'Else
            '    f1.Dalje.Text = "Iduća"
            '    'Label9.Text = "Pobjednik je:"
            'End If
        End If

    End Sub

    

End Class