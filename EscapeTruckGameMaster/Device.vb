Public Class Device
    Private _Name As String
    Private _LastSeen As Date
    Private _IP As String

    Public Enum DeviceType
        Input
        Output
    End Enum

    Public Property Name As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
        End Set
    End Property

    Public Property LastSeen As Date
        Get
            Return _LastSeen
        End Get
        Set(value As Date)
            If value > _LastSeen Then
                _LastSeen = value
            End If
        End Set
    End Property

    Public Property IP As String
        Get
            Return _IP
        End Get
        Set(value As String)
            _IP = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return _Name
    End Function

    Public Sub CheckIn(IP As String)
        _IP = IP
        _LastSeen = Now()
    End Sub

    Public Sub TransmitUDP(ByRef truck As EscapeTruckGameMaster, message As String)
        truck.transmitToDevice(_IP, message)
    End Sub
End Class
