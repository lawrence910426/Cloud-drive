Imports System.IO
Imports System.IO.Ports
Imports System.IO.Ports.SerialPort







Public Class Form1
    Dim ports(100) As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' SerialPort1.PortName
        'For i As Integer = 0 To My.Computer.Ports.SerialPortNames.Count - 1
        '    ports(i) = My.Computer.Ports.SerialPortNames(i)
        '    Console.WriteLine(My.Computer.Ports.SerialPortNames(i))
        'Next 
        SerialPort1 = New SerialPort(My.Computer.Screen.DeviceName)
        SerialPort1.Open()
    End Sub
    Sub serlod() Handles SerialPort1.DataReceived
        For i = 1 To SerialPort1.BytesToRead
            Console.WriteLine(SerialPort1.ReadLine())
        Next




    End Sub
End Class