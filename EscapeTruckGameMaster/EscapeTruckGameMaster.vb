Public Class Truck
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        myGame = New Game
        myGame.Show()
    End Sub

    Private Sub Truck_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GameCom = My.Computer.Ports.OpenSerialPort("COM6")
        With GameCom
            .BaudRate = 9600
            .Parity = Parity.None
            .StopBits = StopBits.One
            .DataBits = 8
            .Handshake = Handshake.None
            .RtsEnable = True

            AddHandler .DataReceived, AddressOf DataReceivedHandler
        End With
        'GameCom.Open()
    End Sub

    Private Shared Sub DataReceivedHandler(
                        sender As Object,
                        e As SerialDataReceivedEventArgs)
        Dim sp As SerialPort = CType(sender, SerialPort)
        Dim indata As String = sp.ReadExisting()
        Console.WriteLine("Data Received:")
        Console.Write(indata)

        If Not IsNothing(myGame) Then
            myGame.txtInput.Text = indata
            myGame.btnSubmitGuess.PerformClick()
        End If
    End Sub
End Class