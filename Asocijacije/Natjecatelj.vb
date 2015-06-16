Public Class Natjecatelj
    Public Sub New()

    End Sub


    Public Sub New(ByVal _sifraNatjecatelja As Integer, ByVal _imePrezima As String, ByVal _datumRodjenja As DateTime, ByVal _adresaStanovanja As String, ByVal _posta As Integer, ByVal _mjestoStanovanja As String, ByVal _telefon As String, ByVal _email As String)
        Me._sifraNatjecatelja = SifraNatjecatelja
        Me._imePrezime = ImePrezime
        Me._datumRodjenja = DatumRodjenja
        Me._adresaStanovanja = AdresaStanovanja
        Me._posta = Posta
        Me._mjestoStanovanja = MjestoStanovanja
        Me._telefon = Telefon
        Me._email = Email

    End Sub


    Private _sifraNatjecatelja As Integer
    Public Property SifraNatjecatelja() As Integer
        Get
            Return _sifraNatjecatelja
        End Get
        Set(ByVal value As Integer)
            _sifraNatjecatelja = value
        End Set
    End Property


    Private _posta As Integer
    Public Property Posta() As Integer
        Get
            Return _posta
        End Get
        Set(ByVal value As Integer)
            _posta = value
        End Set
    End Property


    Private _imePrezime As String
    Public Property ImePrezime() As String
        Get
            Return _imePrezime
        End Get
        Set(ByVal value As String)
            _imePrezime = value
        End Set
    End Property


    Private _datumRodjenja As DateTime
    Public Property DatumRodjenja() As DateTime
        Get
            Return _datumRodjenja
        End Get
        Set(ByVal value As DateTime)
            _datumRodjenja = value
        End Set
    End Property


    Private _adresaStanovanja As String
    Public Property AdresaStanovanja() As String
        Get
            Return _adresaStanovanja
        End Get
        Set(ByVal value As String)
            _adresaStanovanja = value
        End Set
    End Property


    Private _mjestoStanovanja As String
    Public Property MjestoStanovanja() As String
        Get
            Return _mjestoStanovanja
        End Get
        Set(ByVal value As String)
            _mjestoStanovanja = value
        End Set
    End Property


    Private _telefon As String
    Public Property Telefon() As String
        Get
            Return _telefon
        End Get
        Set(ByVal value As String)
            _telefon = value
        End Set
    End Property


    Private _email As String
    Public Property Email() As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property


    Public Overrides Function ToString() As String
        Return Me._imePrezime
    End Function
End Class
