Imports DotNetBrowser
Imports DotNetBrowser.Events
Imports DotNetBrowser.WinForms
Imports System
Imports System.IO.Ports
Imports System.Data.OleDb

Public Class Game
    Private start As DateTime
    Private timeLeft As Integer
    Private rootPuzzlePath As String = "http://localhost:8080/prod/"
    Dim mySerialPort As New SerialPort("COM5")
    Private puzzles As New List(Of Puzzle)
    Dim curPuzzle As Integer = 0
    Dim puzzleCount As Integer
    Dim playerCount As Integer
    Protected Friend _GameMaster As EscapeTruckGameMaster

    Enum difficulty
        Easy
        Medium
        Hard
    End Enum



    Public Sub New(pzCount As Integer)
        InitializeComponent()

        puzzleCount = pzCount

        start = Now()

        ' timer
        'Me.browser.Browser.LoadURL("http://localhost:8080/prod/lottery/")
        timeLeft = 5 * 60 * 100
        tmrGame.Start()

        ' add the puzzles
        Dim provider As String
        Dim dataFile As String
        Dim connString As String
        Dim myConnection As OleDbConnection = New OleDbConnection
        Dim dr As OleDbDataReader
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = "EscapeTruck.accdb" ' Change it to your Access Database location
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String
        str = "SELECT * FROM AvailablePuzzles ORDER BY  Rnd(-Timer() * [ID])"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        While dr.Read() And puzzles.Count < 3
            puzzles.Add(New Puzzle(dr("PuzzleName"), rootPuzzlePath & dr("Path"), dr("ID")))
        End While
        myConnection.Close()

        ' Serial
        mySerialPort.BaudRate = 9600
        mySerialPort.Parity = Parity.None
        mySerialPort.StopBits = StopBits.One
        mySerialPort.DataBits = 8
        mySerialPort.Handshake = Handshake.None
        mySerialPort.RtsEnable = True
        AddHandler mySerialPort.DataReceived, AddressOf DataReceivedHandler
        'mySerialPort.Open()

        ' show the puzzle
        'Me.browser = puzzles.Item(0).browser
        StartNextPuzzle()


    End Sub



    Private Sub btnSubmitGuess_Click(sender As Object, e As EventArgs) Handles btnSubmitGuess.Click
        Me.TestGuess(Me.txtInput.Text)
    End Sub

    Private Sub btnCloseForm_Click(sender As Object, e As EventArgs) Handles btnCloseForm.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrGame.Tick
        'timeLeft = tmrGame.
        If timeLeft > 0 Then
            ' Display the new time left
            ' by updating the Time Left label.
            timeLeft -= 10
            'timeLabel.Text = (timeLeft / 100)
            Dim minutes As Integer = Math.Floor((timeLeft / 100) / 60)
            Dim seconds As Double = (timeLeft - (minutes * 60 * 100)) / 100
            timeLabel.Text = minutes & ":" & CInt(Math.Floor(seconds)).ToString("D2")





        Else
            ' If the user ran out of time, stop the timer, show
            ' a MessageBox, and fill in the answers.
            tmrGame.Stop()
            timeLabel.Text = "Time's up!"
            MessageBox.Show("You didn't finish in time.", "Sorry!")
        End If
    End Sub

    Private Sub form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'may need some extra checking on nothing....
        'If e.KeyCode = Keys.Return Then
        '    e.SuppressKeyPress = True
        '    SendKeys.Send("{Tab}")
        'End If
    End Sub

    Private Shared Sub DataReceivedHandler(
                        sender As Object,
                        e As SerialDataReceivedEventArgs)
        Dim sp As SerialPort = CType(sender, SerialPort)
        Dim indata As String = sp.ReadExisting()
        Console.WriteLine("Data Received:")
        Console.Write(indata)
    End Sub

    Private Sub btnDisable_Click(sender As Object, e As EventArgs) 
        mySerialPort.Write("DISABLE|1000")
    End Sub

    Private Sub StartNextPuzzle()
        tmrGame.Stop()

        Dim pz As Puzzle = puzzles.Item(curPuzzle)
        Me.browser.Browser.LoadURL(pz.path)
        lblPath.Text = pz.path
        curPuzzle = curPuzzle + 1

        Dim finishedLoading As Boolean = False
        While Not finishedLoading
            Dim documentTitle As JSValue = Me.browser.Browser.ExecuteJavaScriptAndReturnValue("document.title")

            If (documentTitle.IsString() AndAlso documentTitle.ToString().Length > 0) Then
                'Console.WriteLine("Document Title = " + documentTitle.GetString());                
                finishedLoading = True
            End If
        End While
        lblAnswer.Text = Me.browser.Browser.Title

        tmrGame.Start()
    End Sub

    Public Sub TestGuess(ByVal guess As String)
        Dim guessResponse As JSValue
        Dim result As String
        Dim answer As String

        Try
            guessResponse = Me.browser.Browser.ExecuteJavaScriptAndReturnValue("testGuess")
            result = guessResponse.AsFunction().InvokeAndReturnValue(Nothing, guess).ToString()
            answer = Me.browser.Browser.ExecuteJavaScriptAndReturnValue("answer").ToString()

            If result = "1" Then
                MsgBox("Good job")
                StartNextPuzzle()
            Else
                MsgBox("Nope! " & answer)
            End If
        Catch
            answer = "bob"
        End Try
    End Sub
End Class