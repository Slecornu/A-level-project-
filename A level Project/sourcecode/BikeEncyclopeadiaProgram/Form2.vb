Public Class HelpInformation

    ' THIS PRIVATE SUB-ROUTINE CLOSES THE FORM Form2 ONCE CLICKED
    ' TO ALLOW THE USER TO NAVIGATE BACK TO THE MAIN PROGRAM
    Private Sub GoBackButton_Click(sender As Object, e As EventArgs) Handles GoBackButton.Click

        Me.Close()
        ' Closes form2, to navigate back to form1 
    End Sub

    ' THIS PRIVATE SUB-ROUITNE IS TO INCREASE THE SIZE OF THE FORM TO FIT SCREEN
    Private Sub HelpInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' The two lines of code bellow allows the program to go full screen
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None ' Ths line removes the boardes of the program
        Me.WindowState = FormWindowState.Maximized ' This line maximises the program to fit the screen size
    End Sub

End Class