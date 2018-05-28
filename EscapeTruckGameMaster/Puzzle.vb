Public Class Puzzle
    Dim ID As Integer
    Dim name As String
    Public path As String

    Enum PuzzleStatus
        Loading
        Pending
        Started
        Solved
        Failed
    End Enum

    Dim status As PuzzleStatus

    Public Sub New(inName As String, inPath As String, inID As Integer)
        name = inName
        path = inPath
        ID = inID
        status = PuzzleStatus.Loading

    End Sub
End Class
