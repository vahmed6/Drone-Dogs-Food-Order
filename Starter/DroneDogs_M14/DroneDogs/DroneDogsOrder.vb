Public Class DroneDogsOrder

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click


        'Declare constants
        Const DBL_COST_PER_DOG As Double = 1.99
        Const DBL_SALES_TAX_RATE As Double = 0.06

        'Declare variables
        Dim intNumBeefDogs As Integer
        Dim intNumPorkDogs As Integer
        Dim intNumTurkeyDogs As Integer
        Dim intNumTotDogs As Integer
        Dim dblSubtotal As Double
        Dim dblSalesTax As Double
        Dim dblTotalCost As Double

        'Extract user typed quantities from text boxes and conver to integers
        intNumBeefDogs = Convert.ToInt32(txtBeefDogs.Text)
        intNumPorkDogs = Convert.ToInt32(txtPorkDogs.Text)
        intNumTurkeyDogs = Convert.ToInt32(txtTurkeyDogs.Text)

        'Run a conditional check for negative numbers
        If intNumBeefDogs < 0 Or intNumPorkDogs < 0 Or intNumTurkeyDogs < 0 Then
            MessageBox.Show("Error...Please enter a positive value")
        Else

        End If

        'Calculate total number of hot dogs ordered 
        intNumTotDogs = intNumBeefDogs + intNumPorkDogs + intNumTurkeyDogs

        'Calculate subtotal, sales tax, and total amounts
        dblSubtotal = intNumTotDogs * DBL_COST_PER_DOG
        dblSalesTax = dblSubtotal * DBL_SALES_TAX_RATE
        dblTotalCost = dblSubtotal + dblSalesTax

        'Convert numbers back to text and display in text boxes
        txtSubtotal.Text = dblSubtotal.ToString("c2")
        txtSalesTax.Text = dblSalesTax.ToString("c2")
        txtTotalCost.Text = dblTotalCost.ToString("c2")

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the form
        MessageBox.Show("Thank you for ordering from DroneDogs")
        Me.Close()
    End Sub


    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        'Make the customer form visible
        CustomerForm.Show()
    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear all text fields
        txtBeefDogs.Text = ""
        txtPorkDogs.Text = ""
        txtTurkeyDogs.Text = ""
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtEmail.Text = ""
        txtSubtotal.Text = ""
        txtSalesTax.Text = ""
        txtTotalCost.Text = ""
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'Check the permission check box, the total cost text box and the email text box
        'Display an error message if any of them are empty
        'Otherwise, display a message box thanking them for ordering
        If chkPermission.Checked = False Then
            MessageBox.Show("ERROR...You must check the location permission check box.")
        ElseIf txtTotalCost.Text = "" Then
            MessageBox.Show("ERROR...You must order at least one item.")
        ElseIf txtEmail.Text = "" Then
            MessageBox.Show("ERROR...Please get customer information for this order.")
        Else
            MessageBox.Show("Thank you for ordering from DroneDogs!")
        End If
    End Sub


End Class