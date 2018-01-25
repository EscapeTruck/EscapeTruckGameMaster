Imports DotNetBrowser
Imports DotNetBrowser.Events
Imports DotNetBrowser.WinForms
Imports System.IO.Ports

Public Class Game

    Private timeLeft As Integer
    Private serialPort As System.IO.Ports.SerialPort


    Public Sub New()
        InitializeComponent()
        Me.browser.Browser.LoadURL("http://localhost:8080/escape/puzzles/prod/lottery/")
        timeLeft = 5 * 60 * 100
        tmrGame.Start()

        serialPort = New IO.Ports.SerialPort("COM1", 9600, IO.Ports.Parity.None, 8)

    End Sub



    Private Sub btnSubmitGuess_Click(sender As Object, e As EventArgs) Handles btnSubmitGuess.Click
        Dim guessResponse As JSValue
        Dim result As String
        Dim answer As String

        Try
            guessResponse = Me.browser.Browser.ExecuteJavaScriptAndReturnValue("testGuess")
            result = guessResponse.AsFunction().InvokeAndReturnValue(Nothing, Me.txtInput.Text).ToString()
            answer = Me.browser.Browser.ExecuteJavaScriptAndReturnValue("answer").ToString()

            If result = "1" Then
                MsgBox("Good job")
                Me.browser.Browser.LoadURL("http://localhost:8080/escape/puzzles/prod/scrambled_numeric_words/")
            Else
                MsgBox("Nope! " & answer)
            End If
        Catch
            answer = "bob"
        End Try
    End Sub

    Private Sub btnCloseForm_Click(sender As Object, e As EventArgs) Handles btnCloseForm.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrGame.Tick
        If timeLeft > 0 Then
            ' Display the new time left
            ' by updating the Time Left label.
            timeLeft -= 1
            timeLabel.Text = (timeLeft / 100)
            Dim minutes As Integer = Math.Floor((timeLeft / 100) / 60)
            Dim seconds As Double = (timeLeft - (minutes * 60 * 100)) / 100
            timeLabel.Text = minutes & ":" & seconds


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
End Class