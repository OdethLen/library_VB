Public Class Register

    Protected _name As String
    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Protected _lastname As String
    Public Property Lastname As String
        Get
            Return _lastname
        End Get
        Set(value As String)
            _lastname = value
        End Set
    End Property

    Protected _date As DateTime
    Public Property [Date] As DateTime
        Get
            Return _date
        End Get
        Set(value As DateTime)
            _date = value
        End Set
    End Property

    Public Sub New()
        _name = ""
        _lastname = ""
        _date = DateTime.Now
    End Sub

    Public Sub New(name As String, lastname As String, [date] As DateTime)
        _name = name
        _lastname = lastname
        _date = [date]
    End Sub

    Public Overrides Function ToString() As String
        Return "Name : " & _name & " " & _lastname & " Date: " & _date.ToString()
    End Function

End Class
