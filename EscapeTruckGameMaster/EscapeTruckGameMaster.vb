Imports System.Net.Sockets
Imports System.Text
Imports System.Threading
Imports System.ComponentModel
Imports System.Net

Public Class EscapeTruckGameMaster
    Private _Game As Game
    Private _Devices As New List(Of Device)
    Private _UDPPort As Integer = 9653
    Private _RemoteEndpoint As New _
              System.Net.IPEndPoint(System.Net.IPAddress.Any, 0)
    Private _ReceivingUdpClient As UdpClient
    Private _ReceivedData As String
    Private _Puzzles As New List(Of Puzzle)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim puzzleCount As Integer

        Try
            puzzleCount = CInt(cmboPuzzleCount.Text)
        Catch ex As Exception
            MsgBox("Please enter a player count. " & ex.Message)
            Exit Sub
        End Try

        _Game = New Game(puzzleCount)
        _Game._GameMaster = Me
        _Game.Show()

    End Sub

    Private Sub EscapeTruckGameMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _ReceivingUdpClient = New System.Net.Sockets.UdpClient(_UDPPort)
        Me._udpListener.RunWorkerAsync()
    End Sub


    Private Sub updListener_DoWork(sender As Object, e As DoWorkEventArgs) Handles _udpListener.DoWork
        ' Continuously listen for UDP
        Do While True
            Dim receiveBytes As [Byte]() = _ReceivingUdpClient.Receive(_RemoteEndpoint)
            _ReceivedData = Encoding.ASCII.GetString(receiveBytes)
            Console.WriteLine("UDP Packet Received From: " & _RemoteEndpoint.Address.ToString)
            _udpListener.ReportProgress(0, _ReceivedData & "|" & _RemoteEndpoint.Address.ToString)
        Loop

    End Sub


    Private Sub updListener_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles _udpListener.ProgressChanged
        Console.WriteLine(e.UserState.ToString)

        Dim arr As Array = e.UserState.ToString.Split("|")
        Dim deviceName As String = arr(0)
        Dim message As String = arr(1)
        Dim params As String = arr(2)

        Dim device As Device = (From d As Device In _Devices Where d.Name = deviceName Select d).FirstOrDefault()

        If IsNothing(device) Then
            device = New Device
            device.Name = deviceName
            _Devices.Add(device)
        End If
        device.CheckIn()


        DeviceGrid.DataSource = _Devices
        DeviceGrid.Refresh()

        ' What's the command?
        Select Case message
            Case "CONNECT"
                Dim ip As String = params
                device.CheckIn(ip)
                transmitToDevice(ip, "CONNECTED")
            Case "GUESS"
                If Not IsNothing(_Game) Then
                    Dim guess As String
                    guess = params
                    _Game.TestGuess(guess)
                End If
        End Select
    End Sub


    Sub RemoveByValue(Of TKey, TValue)(ByVal dictionary As Dictionary(Of TKey, TValue), ByVal someValue As TValue)

        Dim itemsToRemove = (From pair In dictionary
                             Where pair.Value.Equals(someValue)
                             Select pair.Key).ToArray()

        For Each item As TKey In itemsToRemove
            dictionary.Remove(item)
        Next

    End Sub

    Sub transmitToDevice(ip As String, message As String)
        Dim udpClient As New UdpClient

        Dim GLOIP As IPAddress
        Dim GLOINTPORT As Integer
        Dim bytCommand As Byte() = New Byte() {}

        GLOIP = IPAddress.Parse(ip)
        GLOINTPORT = _UDPPort
        udpClient.Connect(GLOIP, GLOINTPORT)
        bytCommand = Encoding.ASCII.GetBytes(message)
        Dim pRet As Integer = udpClient.Send(bytCommand, bytCommand.Length)
        Console.WriteLine("No of bytes send " & pRet)
    End Sub

    Private Sub DeviceGrid_CellContentClick(sender As System.Object, e As DataGridViewCellEventArgs) _
                                           Handles DeviceGrid.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
           e.RowIndex >= 0 Then
            Dim deviceName As String = DeviceGrid.Rows(e.RowIndex).Cells("DeviceGridName").Value
            Dim device As Device = (From d As Device In _Devices Where d.Name = deviceName Select d).FirstOrDefault()
            device.TransmitUDP(Me, "RESET")
        End If

    End Sub


    Private Sub GatherPuzzles()
        ' http://localhost:8080/prod/
        _Puzzles.Clear()

    End Sub


End Class