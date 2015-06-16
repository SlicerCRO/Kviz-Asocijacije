Public Class Tablice
    Public Sub New()

    End Sub


    Public Sub New(ByVal jmbg As String, ByVal ime As String, ByVal prezime As String, ByVal email As String)
        Me._sifraTablice = SifraTablice
        Me._brojTablice = BrojTablice
        Me._a1 = A1
        Me._a2 = A2
        Me._a3 = A3
        Me._a4 = A4
        Me._b1 = B1
        Me._b2 = B2
        Me._b3 = B3
        Me._b4 = B4
        Me._c1 = C1
        Me._c2 = C2
        Me._c3 = C3
        Me._c4 = C4
        Me._d1 = D1
        Me._d2 = D2
        Me._d3 = D3
        Me._d4 = D4
        Me._stupacA = StupacA
        Me._stupacB = StupacB
        Me._stupacC = StupacC
        Me._stupacD = StupacD
        Me._konacnoRjesenje = KonacnoRjesenje
        Me._iskoristena = Iskoristena
    End Sub


    Private _sifraTablice As Integer
    Public Property SifraTablice() As Integer
        Get
            Return _sifraTablice
        End Get
        Set(ByVal value As Integer)
            _sifraTablice = value
        End Set
    End Property


    Private _brojTablice As Integer
    Public Property BrojTablice() As Integer
        Get
            Return _brojTablice
        End Get
        Set(ByVal value As Integer)
            _brojTablice = value
        End Set
    End Property


    Private _a1 As String
    Public Property A1() As String
        Get
            Return _a1
        End Get
        Set(ByVal value As String)
            _a1 = value
        End Set
    End Property


    Private _a2 As String
    Public Property A2() As String
        Get
            Return _a2
        End Get
        Set(ByVal value As String)
            _a2 = value
        End Set
    End Property


    Private _a3 As String
    Public Property A3() As String
        Get
            Return _a3
        End Get
        Set(ByVal value As String)
            _a3 = value
        End Set
    End Property


    Private _a4 As String
    Public Property A4() As String
        Get
            Return _a4
        End Get
        Set(ByVal value As String)
            _a4 = value
        End Set
    End Property


    Private _b1 As String
    Public Property B1() As String
        Get
            Return _b1
        End Get
        Set(ByVal value As String)
            _b1 = value
        End Set
    End Property


    Private _b2 As String
    Public Property B2() As String
        Get
            Return _b2
        End Get
        Set(ByVal value As String)
            _b2 = value
        End Set
    End Property


    Private _b3 As String
    Public Property B3() As String
        Get
            Return _b3
        End Get
        Set(ByVal value As String)
            _b3 = value
        End Set
    End Property


    Private _b4 As String
    Public Property B4() As String
        Get
            Return _b4
        End Get
        Set(ByVal value As String)
            _b4 = value
        End Set
    End Property


    Private _c1 As String
    Public Property C1() As String
        Get
            Return _c1
        End Get
        Set(ByVal value As String)
            _c1 = value
        End Set
    End Property


    Private _c2 As String
    Public Property C2() As String
        Get
            Return _c2
        End Get
        Set(ByVal value As String)
            _c2 = value
        End Set
    End Property


    Private _c3 As String
    Public Property C3() As String
        Get
            Return _c3
        End Get
        Set(ByVal value As String)
            _c3 = value
        End Set
    End Property


    Private _c4 As String
    Public Property C4() As String
        Get
            Return _c4
        End Get
        Set(ByVal value As String)
            _c4 = value
        End Set
    End Property


    Private _d1 As String
    Public Property D1() As String
        Get
            Return _d1
        End Get
        Set(ByVal value As String)
            _d1 = value
        End Set
    End Property


    Private _d2 As String
    Public Property D2() As String
        Get
            Return _d2
        End Get
        Set(ByVal value As String)
            _d2 = value
        End Set
    End Property


    Private _d3 As String
    Public Property D3() As String
        Get
            Return _d3
        End Get
        Set(ByVal value As String)
            _d3 = value
        End Set
    End Property


    Private _d4 As String
    Public Property D4() As String
        Get
            Return _d4
        End Get
        Set(ByVal value As String)
            _d4 = value
        End Set
    End Property


    Private _stupacA As String
    Public Property StupacA() As String
        Get
            Return _stupacA
        End Get
        Set(ByVal value As String)
            _stupacA = value
        End Set
    End Property


    Private _stupacB As String
    Public Property StupacB() As String
        Get
            Return _stupacB
        End Get
        Set(ByVal value As String)
            _stupacB = value
        End Set
    End Property


    Private _stupacC As String
    Public Property StupacC() As String
        Get
            Return _stupacC
        End Get
        Set(ByVal value As String)
            _stupacC = value
        End Set
    End Property


    Private _stupacD As String
    Public Property StupacD() As String
        Get
            Return _stupacD
        End Get
        Set(ByVal value As String)
            _stupacD = value
        End Set
    End Property


    Private _konacnoRjesenje As String
    Public Property KonacnoRjesenje() As String
        Get
            Return _konacnoRjesenje
        End Get
        Set(ByVal value As String)
            _konacnoRjesenje = value
        End Set
    End Property


    Private _iskoristena As Boolean
    Public Property Iskoristena() As Boolean
        Get
            Return _iskoristena
        End Get
        Set(ByVal value As Boolean)
            _iskoristena = value
        End Set
    End Property


    Public Overrides Function ToString() As String
        Return Me._brojTablice
    End Function
End Class
