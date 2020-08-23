Imports System.IO.Ports
Imports System.Text
Public Class Form1

    Dim strIn = "", strOut = "", portID = "COM1"
    Dim command As Integer





    Private Sub port_Click(sender As Object, e As EventArgs) Handles port.Click
        portID = port_select.SelectedItem
        If portID IsNot Nothing Then
            serial.PortName = portID
            serial.BaudRate = 115200
            serial.DataBits = 8
            serial.Parity = Parity.None
            serial.StopBits = StopBits.One
            serial.Encoding = Encoding.UTF8
            serial.Open()
            received_text.AppendText("Port set : " + portID + Environment.NewLine)
            port.Enabled = False
            Send.Enabled = True
            str_out.Enabled = True
            clrtxt.Enabled = True
        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Send.Click
        If str_out.Text IsNot "" Then
            serial_out(str_out.Text)
            strOut = " >> " + str_out.Text
            received_text.AppendText(strOut + Environment.NewLine)
            strOut = ""
            str_out.Clear()

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetSerialPortNames()
        received_text.TextAlign = HorizontalAlignment.Left

    End Sub

    Sub serial_out(data As String)

        serial.WriteLine(data)

    End Sub
    Private Delegate Sub Delegate_RcvDataToTextBox(data As String)

    Private Sub str_out_Enter(sender As Object, e As EventArgs) Handles str_out.Enter
        str_out.Clear()

    End Sub



    Private Sub port_select_TextChanged(sender As Object, e As EventArgs) Handles port_select.TextChanged
        port.Enabled = True

    End Sub

    Sub serial_DataReceived(ByVal sender As System.Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles serial.DataReceived
        If serial.IsOpen = False Then
            Return
        End If

        Try

            Dim data As String
            data = serial.ReadLine()
            Invoke(New Delegate_RcvDataToTextBox(AddressOf Me.RcvDataToTextBox), data)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles clrtxt.Click
        received_text.Clear()

    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If serial.IsOpen And True Then
            serial.Close()
        End If
    End Sub



    Private Sub RcvDataToTextBox(data As String)

        If IsNothing(data) = False Then
            received_text.AppendText(data + Environment.NewLine)
        End If

    End Sub
    Sub GetSerialPortNames()
        For Each sp As String In My.Computer.Ports.SerialPortNames
            port_select.Items.Add(sp)
        Next
    End Sub
End Class
