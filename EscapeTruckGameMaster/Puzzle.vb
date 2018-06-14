Public Class Puzzle
    Private _ID As Integer
    Private _Name As String
    Private _URL As String
    Private _DeviceName As String
    Private _SupportedClues As List(Of String)

    Enum PuzzleStatus
        Loading
        Pending
        Started
        Solved
        Failed
    End Enum

    Dim status As PuzzleStatus

    Public Sub New(url As String)
        _URL = url

        status = PuzzleStatus.Loading
    End Sub

    Public Property URL As String
        Get
            Return _URL
        End Get
        Set(value As String)
            _URL = value
        End Set
    End Property
End Class
