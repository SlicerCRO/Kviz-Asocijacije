Imports Asocijacije.Form1
Public Class Form2
    'Dim i1, i2, i3, i4 As String

    'Public Sub New()

    '    ' This call is required by the Windows Form Designer.
    '    InitializeComponent()

    '    ' Add any initialization after the InitializeComponent() call.
    'End Sub

    'Public Sub New(ByVal igrac1 As String, ByVal igrac2 As String, ByVal igrac3 As String, ByVal igrac4 As String)

    '    ' This call is required by the Windows Form Designer.
    '    InitializeComponent()

    '    ' Add any initialization after the InitializeComponent() call.
    '    i1 = igrac1
    '    'MessageBox.Show(i1.ImePrezime)
    '    i2 = igrac2
    '    i3 = igrac3
    '    i4 = igrac4

    'End Sub
    'Dim f1 As New Form1
    Private Sub TextBox1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyUp
        Dim odg As String
        odg = Me.TextBox1.Text
        If e.KeyCode = Keys.Enter Then
            If Me.TextBox1.Text Like Asoc1.SA.Text Then
                T.SA.BackColor = Color.Green
                T.SA.Text = Asoc1.SA.Text
                T.SA_Change()
            Else
                provdalj = False
                'dalj()
            End If
            Me.Hide()
            'f1.x1()
        End If
    End Sub

    Private Sub Odustani_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Odustani.Click
        rjesava = True
        Me.Hide()
    End Sub

  
End Class