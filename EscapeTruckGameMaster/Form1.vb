Imports DotNetBrowser
Imports DotNetBrowser.Events
Imports DotNetBrowser.WinForms

Public Class Form1
    Private browserView As WinFormsBrowserView

    Public Sub New()

        InitializeComponent()

        browserView = New WinFormsBrowserView()
        Controls.Add(browserView)

        browserView.Browser.LoadURL("http://google.com")
        AddHandler browserView.KeyDown, AddressOf OnBrowserKeyDown
        AddHandler browserView.KeyPress, AddressOf OnBrowserKeyPress
        AddHandler browserView.KeyUp, AddressOf OnBrowserKeyUp

    End Sub

    Public Sub OnBrowserKeyDown(sender As Object, e As KeyEventArgs)
        Debug.WriteLine("Key down event captured: key code = " + e.KeyCode.ToString())
        If (e.Alt) Then
            Debug.WriteLine("Alt down event captured")
        End If

        If (e.KeyCode = Keys.P) Then
            Debug.WriteLine("P down event captured")
        End If

        If (e.Alt And e.KeyCode = Keys.P) Then
            Debug.WriteLine("Alt+P captured")
        End If

    End Sub

    Public Sub OnBrowserKeyUp(sender As Object, e As KeyEventArgs)
        Debug.WriteLine("Key up event captured")
        If (e.Alt And e.KeyCode = Keys.P) Then
            Debug.WriteLine("Alt+P captured")
        End If

    End Sub

    Public Sub OnBrowserKeyPress(sender As Object, e As KeyPressEventArgs)
        Debug.WriteLine("Key press event captured")
    End Sub

End Class