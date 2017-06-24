Imports DotNetBrowser
Imports DotNetBrowser.Events
Imports DotNetBrowser.WinForms

Public Class Form1

    Public Sub New()
        InitializeComponent()
        Me.browser.Browser.LoadURL("http://localhost:8080/escape/puzzles/scrambled_numeric_words/index.html?a=234")
    End Sub



    Private Sub btnSubmitGuess_Click(sender As Object, e As EventArgs) Handles btnSubmitGuess.Click
        Dim guessResponse As JSValue
        Dim result As String
        Dim answer As String
        'guessResponse = Me.browser.Browser.ExecuteJavaScriptAndReturnValue("testGuess('" &
        'Me.txtInput.Text &
        '                                                          "');")

        guessResponse = Me.browser.Browser.ExecuteJavaScriptAndReturnValue("testGuess")
        result = guessResponse.AsFunction().InvokeAndReturnValue(Nothing, Me.txtInput.Text).ToString()
        answer = Me.browser.Browser.ExecuteJavaScriptAndReturnValue("answer").ToString()


        MsgBox(result.ToString())

        If result = "1" Then
            MsgBox("Good job")
        Else
            MsgBox("Nope! " & answer)
        End If


    End Sub

    Private Sub btnCloseForm_Click(sender As Object, e As EventArgs) Handles btnCloseForm.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class