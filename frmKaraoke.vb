Option Strict On
Imports Microsoft.VisualBasic.Devices

Public Class frmKaraoke

    ' song and hourly costs, in USD
    Private _decSong As Decimal = 2.99D
    Private _decHourlyRate As Decimal = 8.99D

    Private Function ValidateInput() As Boolean
        ' validates user input from txtPurchaseInput

        ' variable definitions
        Dim intNumber As Integer
        Dim blnValid As Boolean = False

        ' attempt to parse user input
        Try
            intNumber = Convert.ToInt32(txtPurchaseInput.Text)
            ' if parse was successful, tests if value is positive
            If intNumber > 0D Then
                blnValid = True
                Return blnValid
            Else
                ' inform user that inputs must be a positive integer
                MsgBox("Please enter a number greater than 0.", , "Error")
            End If
        Catch Exception As FormatException
            ' if input contains non-numeric characters or a blank entry
            MsgBox("Please enter a number, and do not include any other symbols or spaces.", , "Error")
        Catch Exception As OverflowException
            ' if input is too large or small
            MsgBox("You have entered a number that is either too large or too small; please enter a more reasonable number.", , "Error")
        Catch Exception As SystemException
            ' generic exception catch, for any error not already handled
            MsgBox("Your entry is invalid. Please enter a number into the box.", , "Error")
        End Try

        ' if the input failed to validate, the text box will be cleared and refocused
        txtPurchaseInput.Focus()
        txtPurchaseInput.Clear()

        ' return boolean result
        Return blnValid

    End Function

    Private Function CalculateSongCost(ByVal intPass As Integer) As Decimal
        ' calculate cost of per-song karaoke with a given song number

        ' variable definition
        Dim decPassCost As Decimal

        ' multiply song count by price per song
        decPassCost = intPass * _decSong

        ' return result
        Return decPassCost
    End Function

    Private Function CalculateRoomCost(ByVal intPass As Integer) As Decimal
        ' calculate cost of per-hour private room rental with a given hour number

        ' variable definition
        Dim decPassCost As Decimal

        ' multiply hour count by price per hour
        decPassCost = intPass * _decHourlyRate

        ' return result
        Return decPassCost
    End Function

    Private Sub ClearForm()
        ' clears contents of operated labels, text box, and cbo
        ' also makes certain elements invisible and disables button controls
        lblPurchaseInputIndicator.Text = ""
        lblCost.Text = ""
        txtPurchaseInput.Clear()
        lblPurchaseInputIndicator.Visible = False
        lblCost.Visible = False
        txtPurchaseInput.Visible = False
        cboPurchaseType.SelectedIndex = -1
        btnCost.Enabled = False
        btnClear.Enabled = False

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' clears the form
        ClearForm()
    End Sub

    Private Sub btnCost_Click(sender As Object, e As EventArgs) Handles btnCost.Click
        ' calculates the cost of the customer's order

        ' variable definitions
        Dim blnAmountIsValid As Boolean = False
        Dim intValue As Integer
        Dim decTotal As Decimal

        ' validate input
        blnAmountIsValid = ValidateInput()

        ' if/else block from result of input validation
        If blnAmountIsValid Then
            ' assign input to variable; input should have already been verified so no need for exception handling here
            intValue = Convert.ToInt32(txtPurchaseInput.Text)

            'determine correct calculation based on cbo choice
            If cboPurchaseType.SelectedIndex = 0 Then
                ' customer chose per-song karaoke
                decTotal = CalculateSongCost(intValue)
            Else
                ' customer chose room rental
                decTotal = CalculateRoomCost(intValue)
            End If

            ' display the output
            lblCost.Visible = True
            lblCost.Text = "Total cost of your night is: " & decTotal.ToString("C")
        End If
    End Sub

    Private Sub cboPurchaseType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPurchaseType.SelectedIndexChanged
        ' alter appearance to reflect user choice

        ' boolean; helps avoid bug where text box becomes visible upon form clear
        Dim blnRecognizedChoice As Boolean = False

        If cboPurchaseType.SelectedIndex = 0 Then
            ' user selected per-song karaoke
            lblPurchaseInputIndicator.Text = "Enter number of songs for your session: "
            blnRecognizedChoice = True
        ElseIf cboPurchaseType.SelectedIndex = 1 Then
            ' user selected room rental
            lblPurchaseInputIndicator.Text = "Enter number of hours to rent a room: "
            blnRecognizedChoice = True
        End If

        If blnRecognizedChoice Then
            lblPurchaseInputIndicator.Visible = True
            txtPurchaseInput.Visible = True
            btnClear.Enabled = True
            btnCost.Enabled = True
            ' focus textbox
            txtPurchaseInput.Focus()
        End If
    End Sub

    Private Sub frmKaraoke_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' clear the form upon load
        ClearForm()
    End Sub
End Class
