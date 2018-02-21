
Public NotInheritable Class SplashScreen1

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).

    Public p1Name, p2Name As String
    Public singlePlayer As Boolean

    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    End Sub

    Private Sub ApplicationTitle_Click(sender As System.Object, e As System.EventArgs) Handles ApplicationTitle.Click
        Me.Close()  'closes splashscreen
        frmMain.Enabled = True  'enables frmMain
        'frmMain.TopMost = True  'makes frmMain topmost

        Dim gameSelect As Integer = MessageBox.Show("Would you like to play this as a two player game?", "Game Type Select", MessageBoxButtons.YesNo)
        If gameSelect = DialogResult.Yes Then
            Do Until p1Name <> Nothing
                p1Name = InputBox("What is the name of the first player?", "Player One Name Input")
                frmMain.playerOne = p1Name
            Loop

            'verifies and request user input
            Do Until p2Name <> Nothing
                p2Name = InputBox("What is the name of the second player?", "Player Two Name Input")
                frmMain.playerTwo = p2Name
            Loop

            frmMain.btnComputerBet.Visible = False
            frmMain.singlePlayer = False
        ElseIf gameSelect = DialogResult.No Then
            Do Until p1Name <> Nothing
                p1Name = InputBox("What is your name?", "Player Name")
                frmMain.playerOne = p1Name

                frmMain.singlePlayer = True
                frmMain.picComp25.Enabled = False
                frmMain.picComp50.Enabled = False
                frmMain.picComp100.Enabled = False
                frmMain.picComp500.Enabled = False
                frmMain.picComp1000.Enabled = False

                frmMain.btnComputerBet.Visible = True
                
            Loop
            frmMain.playerTwo = "Computer"
        End If
        ''verifies and requests user input
        'Do Until p1Name <> Nothing
        '    p1Name = InputBox("What is the name of the first player?", "Player One Name Input")
        '    frmMain.playerOne = p1Name
        'Loop

        ''verifies and request user input
        'Do Until p2Name <> Nothing
        '    p2Name = InputBox("What is the name of the second player?", "Player Two Name Input")
        '    frmMain.playerTwo = p2Name
        'Loop

        MessageBox.Show("Each player begins with $1500, and can make a bet before each round. If you win the round, you get the amount of money that all players bet. if a draw is achieved, then both players will get their money back. Jack Cards are worth 11, Queen cards are worth 12, King cards are worth 13 and Ace cards are worth 1", "Rules")


        frmMain.TopMost = True  'set frmMain to be TopMost

        'displays usernames
        frmMain.lblUser.Text = p1Name
        frmMain.lblComputer.Text = p2Name
    End Sub
End Class
