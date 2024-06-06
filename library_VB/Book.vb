Public Class Book
    Inherits Register

    Private _title As String

    Public Property Title As String
        Get
            Return _title
        End Get
        Set(value As String)
            _title = value
        End Set
    End Property

    Private _author As String

    Public Property Author As String
        Get
            Return _author
        End Get
        Set(value As String)
            _author = value
        End Set
    End Property

    Private _publisher As String

    Public Property Publisher As String
        Get
            Return _publisher
        End Get
        Set(value As String)
            _publisher = value
        End Set
    End Property

    Protected _enddate As DateTime

    Public Property Enddate As DateTime
        Get
            Return _enddate
        End Get
        Set(value As DateTime)
            _enddate = value
        End Set
    End Property

    ' Constructor sin parámetros
    Public Sub New()
        MyBase.New()
        _title = ""
        _author = ""
        _publisher = ""
        _enddate = DateTime.Now
    End Sub

    ' Constructor con parámetros
    Public Sub New(name As String, lastname As String, title As String, author As String, publisher As String, [date] As DateTime, enddate As DateTime)
        MyBase.New(name, lastname, [date])
        _title = title
        _author = author
        _publisher = publisher
        _enddate = enddate
    End Sub

    Public Overrides Function ToString() As String
        Return "Name: "
    End Function

End Class
