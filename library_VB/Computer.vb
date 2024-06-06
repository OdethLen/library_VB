Public Class Computer

    Inherits Register

    Protected _computernumber As Integer

    Public Property Computernumber As Integer
        Get
            Return Computernumber
        End Get
        Set(value As Integer)
            _computernumber = value
        End Set
    End Property

    ' Propiedad de solo lectura 
    Protected _cost As Double = 0.26

    Public ReadOnly Property Cost As Double
        Get
            Return _cost
        End Get
    End Property

    Private printnumber As Integer

    Public Property Print_number As Integer
        Get
            Return printnumber
        End Get
        Set(value As Integer)
            printnumber = value
        End Set
    End Property

    Private _total As Double

    Public Property Total As Double
        Get
            Return Total
        End Get
        Set(value As Double)
            _total = value
        End Set
    End Property

    ' Constructor
    Public Sub New()
        MyBase.New()
        computernumber = 0
        _cost = 0.26
        Total = 0
    End Sub

    Public Sub New(name As String, lastname As String, [date] As DateTime, computernumber As Integer, printnumber As Integer)
        MyBase.New(name, lastname, [date])
        Me.computernumber = computernumber
        Me.printnumber = printnumber
    End Sub

    Public Overrides Function ToString() As String
        Return "Name: " & Name & " Date: " & [Date].ToString() & " Computer number: " & computernumber.ToString()
    End Function

    ' Método con parámetros y regreso de datos
    Public Function Gettotal(cost As Double, printnumber As Integer) As Double
        Dim total As Double = cost * printnumber
        Return total
    End Function

End Class
