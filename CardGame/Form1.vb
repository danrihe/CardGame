Public Class frmMain
    Dim lowNum As Integer = 1
    Dim highNum As Integer = 10
    Dim userTotal As Integer = 0
    Dim computerTotal As Integer = 0
    'Dim lowNum As Integer = 1
    'Dim highNum As Integer = 10
    Dim userScore, computerScore, cardValue As Integer
    Dim draws As Integer = 0
    Dim userCard1, userCard2, userCard3, cpuCard1, cpuCard2, cpuCard3, p1Money, p2Money As Integer
    Dim splash As New SplashScreen1
    Public playerOne, playerTwo As String
    Dim jackpot As Integer
    Public singlePlayer, computerBet As Boolean

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        splash.Show()
        splash.TopMost = True
        Me.Enabled = False
        p1Money = 1500
        p2Money = 1500
        Me.btnStop.Visible = False
    End Sub

    Private Sub btnPlay_Click(sender As System.Object, e As System.EventArgs) Handles btnPlay.Click
        'Deal 3 cards to player
        'Deal 3 cards to computer

        If computerBet = False Then
            MessageBox.Show("Please generate a computer bet.")
        Else
            cardTimer.Enabled = True
            Me.btnStop.Visible = True
            Me.btnPlay.Visible = False
        End If

        'Dim betPlaced As Integer = MessageBox.Show("Have you placed your bet?", "BET PLACED?", MessageBoxButtons.YesNo)
        'If betPlaced = DialogResult.Yes Then
        '    Select Case RndInt(5, 1)
        '        Case 1
        '            p2Money -= 25
        '            jackpot += 25
        '        Case 2
        '            p2Money -= 50
        '            jackpot += 50
        '        Case 3
        '            p2Money -= 100
        '            jackpot += 100
        '        Case 4
        '            p2Money -= 500
        '            jackpot += 500
        '        Case 5
        '            p2Money -= 1000
        '            jackpot += 1000
        '    End Select

        'End If


    End Sub
    Function RndInt(ByVal firstNum As Integer, ByVal secondNum As Integer)
        Randomize()
        Return Int((firstNum - secondNum + 1) * Rnd() + secondNum)
    End Function
    Public Sub DealCard(ByRef picCard As PictureBox, ByRef intTotal As Integer)
        Select Case RndInt(4, 1)
            Case 1
                Select Case RndInt(13, 1)
                    Case 1
                        picCard.Image = My.Resources.DiamondsAce
                        intTotal += 1
                        cardValue = 1
                    Case 2
                        picCard.Image = My.Resources.Diamonds2
                        intTotal += 2
                        cardValue = 2
                    Case 3
                        picCard.Image = My.Resources.Diamonds3
                        intTotal += 3
                        cardValue = 3
                    Case 4
                        picCard.Image = My.Resources.Diamonds4
                        intTotal += 4
                        cardValue = 4
                    Case 5
                        picCard.Image = My.Resources.Diamonds5
                        intTotal += 5
                        cardValue = 5
                    Case 6
                        picCard.Image = My.Resources.Diamonds6
                        intTotal += 6
                        cardValue = 6
                    Case 7
                        picCard.Image = My.Resources.Diamonds7
                        intTotal += 7
                        cardValue = 7
                    Case 8
                        picCard.Image = My.Resources.Diamonds8
                        intTotal += 8
                        cardValue = 8
                    Case 9
                        picCard.Image = My.Resources.Diamonds9
                        intTotal += 9
                        cardValue = 9
                    Case 10
                        picCard.Image = My.Resources.Diamonds10
                        intTotal += 10
                        cardValue = 10
                    Case 11
                        picCard.Image = My.Resources.DiamondsJack
                        intTotal += 11
                        cardValue = 11
                    Case 12
                        picCard.Image = My.Resources.DiamondsQueen
                        intTotal += 12
                        cardValue = 12
                    Case 13
                        picCard.Image = My.Resources.DiamondsKing
                        intTotal += 13
                        cardValue = 13
                End Select
            Case 2
                Select Case RndInt(13, 1)
                    Case 1
                        picCard.Image = My.Resources.ClubsAce
                        intTotal += 1
                        cardValue = 1
                    Case 2
                        picCard.Image = My.Resources.Clubs2
                        intTotal += 2
                        cardValue = 2
                    Case 3
                        picCard.Image = My.Resources.Clubs3
                        intTotal += 3
                        cardValue = 3
                    Case 4
                        picCard.Image = My.Resources.Clubs4
                        intTotal += 4
                        cardValue = 4
                    Case 5
                        picCard.Image = My.Resources.Clubs5
                        intTotal += 5
                        cardValue = 5
                    Case 6
                        picCard.Image = My.Resources.Clubs6
                        intTotal += 6
                        cardValue = 6
                    Case 7
                        picCard.Image = My.Resources.Clubs7
                        intTotal += 7
                        cardValue = 7
                    Case 8
                        picCard.Image = My.Resources.Clubs8
                        intTotal += 8
                        cardValue = 8
                    Case 9
                        picCard.Image = My.Resources.Clubs9
                        intTotal += 9
                        cardValue = 9
                    Case 10
                        picCard.Image = My.Resources.Clubs10
                        intTotal += 10
                        cardValue = 10
                    Case 11
                        picCard.Image = My.Resources.ClubsJack
                        intTotal += 11
                        cardValue = 11
                    Case 12
                        picCard.Image = My.Resources.ClubsQueen
                        intTotal += 12
                        cardValue = 12
                    Case 13
                        picCard.Image = My.Resources.ClubsKing
                        intTotal += 13
                        cardValue = 13
                End Select
            Case 3
                Select Case RndInt(13, 1)
                    Case 1
                        picCard.Image = My.Resources.HeartsAce
                        intTotal += 1
                        cardValue = 1
                    Case 2
                        picCard.Image = My.Resources.Hearts2
                        intTotal += 2
                        cardValue = 2
                    Case 3
                        picCard.Image = My.Resources.Hearts3
                        intTotal += 3
                        cardValue = 3
                    Case 4
                        picCard.Image = My.Resources.Hearts4
                        intTotal += 4
                        cardValue = 4
                    Case 5
                        picCard.Image = My.Resources.Hearts5
                        intTotal += 5
                        cardValue = 5
                    Case 6
                        picCard.Image = My.Resources.Hearts6
                        intTotal += 6
                        cardValue = 6
                    Case 7
                        picCard.Image = My.Resources.Hearts7
                        intTotal += 7
                        cardValue = 7
                    Case 8
                        picCard.Image = My.Resources.Hearts8
                        intTotal += 8
                        cardValue = 8
                    Case 9
                        picCard.Image = My.Resources.Hearts9
                        intTotal += 9
                        cardValue = 9
                    Case 10
                        picCard.Image = My.Resources.Hearts10
                        intTotal += 10
                        cardValue = 10
                    Case 11
                        picCard.Image = My.Resources.HeartsJack
                        intTotal += 11
                        cardValue = 11
                    Case 12
                        picCard.Image = My.Resources.HeartsQueen
                        intTotal += 12
                        cardValue = 12
                    Case 13
                        picCard.Image = My.Resources.HeartsKing
                        intTotal += 13
                        cardValue = 13
                End Select
            Case 4
                Select Case RndInt(13, 1)
                    Case 1
                        picCard.Image = My.Resources.SpadesAce
                        intTotal += 1
                        cardValue = 1
                    Case 2
                        picCard.Image = My.Resources.Spades2
                        intTotal += 2
                        cardValue = 2
                    Case 3
                        picCard.Image = My.Resources.Spades3
                        intTotal += 3
                        cardValue = 3
                    Case 4
                        picCard.Image = My.Resources.Spades4
                        intTotal += 4
                        cardValue = 4
                    Case 5
                        picCard.Image = My.Resources.Spades5
                        intTotal += 5
                        cardValue = 5
                    Case 6
                        picCard.Image = My.Resources.Spades6
                        intTotal += 6
                        cardValue = 6
                    Case 7
                        picCard.Image = My.Resources.Spades7
                        intTotal += 7
                        cardValue = 7
                    Case 8
                        picCard.Image = My.Resources.Spades8
                        intTotal += 8
                        cardValue = 8
                    Case 9
                        picCard.Image = My.Resources.Spades9
                        intTotal += 9
                        cardValue = 9
                    Case 10
                        picCard.Image = My.Resources.Spades10
                        intTotal += 10
                        cardValue = 10
                    Case 11
                        picCard.Image = My.Resources.SpadesJack
                        intTotal += 11
                        cardValue = 11
                    Case 12
                        picCard.Image = My.Resources.SpadesQueen
                        intTotal += 12
                        cardValue = 12
                    Case 13
                        picCard.Image = My.Resources.SpadesKing
                        intTotal += 13
                        cardValue = 13
                End Select
        End Select
    End Sub

    Function Winner(ByVal userScore As Integer, ByVal computerScore As Integer)
        If userScore > computerScore Then
            Return 1
        ElseIf computerScore > userScore Then
            Return 2
        Else
            Return 0
        End If
    End Function

    Public Sub ShowScore(ByVal input As Integer, ByRef userScore As Integer, ByRef cpuScore As Integer, ByRef draws As Integer)
        Me.lblScore.Text = (playerOne & ": " & userScore & vbCrLf _
            & playerTwo & ": " & cpuScore & vbCrLf _
            & "Draws: " & draws)
    End Sub
    Public Sub UpdateScore(ByVal input As Integer, ByVal userScore As Integer, ByVal cpuScore As Integer)
        Me.lblUserScore.Text = "Score: " & userScore
        Me.lblCPUScore.Text = "Score: " & cpuScore
    End Sub

    Private Sub cardTimer_Tick(sender As System.Object, e As System.EventArgs) Handles cardTimer.Tick
        DealCard(Me.picCard1, userTotal)
        userCard1 = cardValue
        DealCard(Me.picCard2, userTotal)
        userCard2 = cardValue
        DealCard(Me.picCard3, userTotal)
        userCard3 = cardValue
        DealCard(Me.picCompCard1, computerTotal)
        cpuCard1 = cardValue
        DealCard(Me.picCompCard2, computerTotal)
        cpuCard2 = cardValue
        DealCard(Me.picCompCard3, computerTotal)
        cpuCard3 = cardValue
    End Sub

    Private Sub btnStop_Click(sender As System.Object, e As System.EventArgs) Handles btnStop.Click
        Me.btnStop.Visible = False

        computerBet = False
        cardTimer.Enabled = False

        userTotal = userCard1 + userCard2 + userCard3
        computerTotal = cpuCard1 + cpuCard2 + cpuCard3

        'If singlePlayer = True Then
        '    If computerTotal > 20 Then
        '        Select Case RndInt(2, 1)
        '            Case 1
        '                computerBet = 500
        '                p2Money -= 500
        '                jackpot += 500
        '            Case 2
        '                computerBet = 1000
        '                p2Money -= 1000
        '                jackpot += 1000
        '        End Select
        '    ElseIf computerTotal <= 20 And computerTotal >= 10 Then
        '        Select Case RndInt(3, 1)
        '            Case 1
        '                computerBet = 50
        '                p2Money -= 50
        '                jackpot += 50
        '            Case 2
        '                computerBet = 100
        '                p2Money -= 100
        '                jackpot += 100
        '            Case 3
        '                computerBet = 500
        '                p2Money -= 500
        '                jackpot += 500
        '        End Select
        '    ElseIf computerTotal < 10 Then
        '        Select Case RndInt(2, 1)
        '            Case 1
        '                computerBet = 25
        '                p2Money -= 25
        '                jackpot += 25
        '            Case 2
        '                computerBet = 50
        '                p2Money -= 50
        '                jackpot += 50
        '        End Select
        '    End If
        'End If
        'jackpotUpdate()
        'If SplashScreen1.singlePlayer = True Then
        '    If computerTotal >= 20 Then
        '        computerBet = RndInt(1000, 500)
        '        If computerBet > 750 Then
        '            computerBet = 1000
        '        Else
        '            computerBet = 500
        '        End If
        '    ElseIf computerTotal >= 10 And computerTotal <= 20 Then
        '        Do Until computerBet = 50 Or 100 Or 150
        '            computerBet = RndInt(300, 49)
        '        Loop
        '    Else
        '        Do Until computerBet = 25 Or 50
        '            computerBet = RndInt(50, 24)
        '        Loop
        '    End If
        'End If



        If Winner(userTotal, computerTotal) = 1 Then
            Me.lblResult.Text = playerOne & " wins!"
            userScore += 1
            p1Money += jackpot
            jackpot = 0
            Me.lblJackpot.Text = "$" & "0"
            Me.lblP1Money.Text = "$" & p1Money
        ElseIf Winner(userTotal, computerTotal) = 2 Then
            Me.lblResult.Text = playerTwo & " wins!"
            computerScore += 1
            p2Money += jackpot
            jackpot = 0
            Me.lblJackpot.Text = "$" & "0"
            Me.lblP2Money.Text = "$" & p2Money
        ElseIf Winner(userTotal, computerTotal) = 0 Then
            Me.lblResult.Text = "It's a draw!"
            draws += 1
        End If

        ShowScore(Winner(userTotal, computerTotal), userScore, computerScore, draws)
        UpdateScore(Winner(userTotal, computerTotal), userTotal, computerTotal)

        Me.btnPlay.Visible = True
    End Sub

  
    Private Sub ResetToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ResetToolStripMenuItem.Click
        userScore = 0
        computerScore = 0

        ShowScore(Winner(userTotal, computerTotal), userScore, computerScore, draws)
        Me.lblResult.Text = "RESET!"
    End Sub

    Private Sub UserBet_Click(sender As System.Object, e As System.EventArgs) Handles picUser25.Click, picUser50.Click, picUser100.Click, picUser500.Click, picUser1000.Click
        Dim chipChosen As PictureBox = sender
        Dim chipClicked As Integer = Val(chipChosen.Tag)

        If p1Money <= 0 Then
            MessageBox.Show("You have no more money left!")
        End If
        If chipClicked = 5 And p1Money < 1000 Then
            Me.picUser1000.Enabled = False
            MessageBox.Show("You don't have enough money!")
            p1Money += 1000
            jackpot -= 1000
        End If
        If chipClicked = 4 And p1Money < 500 Then
            Me.picUser500.Enabled = False
            MessageBox.Show("You don't have enough money!")
            p1Money += 500
            jackpot -= 500
        End If
        If chipClicked = 3 And p1Money < 100 Then
            Me.picUser100.Enabled = False
            MessageBox.Show("You don't have enough money!")
            p1Money += 100
            jackpot -= 100
        End If
        If chipClicked = 2 And p1Money < 50 Then
            Me.picUser50.Enabled = False
            MessageBox.Show("You don't have enough money!")
            p1Money += 50
            jackpot -= 50
        End If
        If chipClicked = 1 And p1Money < 25 Then
            Me.picUser25.Enabled = False
            MessageBox.Show("You don't have enough money!")
            p1Money += 25
            jackpot -= 25
        End If
        Select Case chipClicked
            Case 1
                jackpot += 25
                p1Money -= 25
                Me.picJackpot.Image = My.Resources.PokerChip_25
            Case 2
                jackpot += 50
                p1Money -= 50
                Me.picJackpot.Image = My.Resources.PokerChip_50
            Case 3
                jackpot += 100
                p1Money -= 100
                Me.picJackpot.Image = My.Resources.PokerChip_100
            Case 4
                jackpot += 500
                p1Money -= 500
                Me.picJackpot.Image = My.Resources.PokerChip_500
            Case 5
                jackpot += 1000
                p1Money -= 1000
                Me.picJackpot.Image = My.Resources.PokerChip_1000
        End Select


        'If picUser25.Tag Then
        '    jackpot += 25
        '    p1Money -= 25
        '    Me.picJackpot.Image = My.Resources.PokerChip_25
        'ElseIf picUser100.Tag Then
        '    jackpot += 100
        '    p1Money -= 100
        '    Me.picJackpot.Image = My.Resources.PokerChip_100
        'ElseIf picUser50.Tag Then
        '    jackpot += 50
        '    p1Money -= 50
        '    Me.picJackpot.Image = My.Resources.PokerChip_50
        'ElseIf picUser500.Tag Then
        '    jackpot += 500
        '    p1Money -= 500
        '    Me.picJackpot.Image = My.Resources.PokerChip_500
        'ElseIf picUser1000.Tag Then
        '    jackpot += 1000
        '    p1Money -= 1000
        '    Me.picJackpot.Image = My.Resources.PokerChip_1000
        'End If

        jackpotUpdate()
        'Me.lblJackpot.Text = "JACKPOT: $" & jackpot
    End Sub

    Public Sub jackpotUpdate()
        Me.lblJackpot.Text = "JACKPOT: $" & jackpot
        Me.lblP1Money.Text = "$" & p1Money
        Me.lblP2Money.Text = "$" & p2Money
    End Sub

    Private Sub CPUBet_Click(sender As System.Object, e As System.EventArgs) Handles picComp25.Click, picComp50.Click, picComp100.Click, picComp500.Click, picComp1000.Click
        Dim chipChosen As PictureBox = sender
        Dim chipClicked As Integer = Val(chipChosen.Tag)

        If p2Money <= 0 Then
            MessageBox.Show("You have run out of money!")
            p2Money = 0
        Else
            Select Case chipClicked
                Case 1
                    jackpot += 25
                    p2Money -= 25
                    Me.picJackpot.Image = My.Resources.PokerChip_25
                Case 2
                    jackpot += 50
                    p2Money -= 50
                    Me.picJackpot.Image = My.Resources.PokerChip_50
                Case 3
                    jackpot += 100
                    p2Money -= 100
                    Me.picJackpot.Image = My.Resources.PokerChip_100
                Case 4
                    jackpot += 500
                    p2Money -= 500
                    Me.picJackpot.Image = My.Resources.PokerChip_500
                Case 5
                    jackpot += 1000
                    p2Money -= 1000
                    Me.picJackpot.Image = My.Resources.PokerChip_1000
            End Select
        End If
        

        'If picComp25.Tag Then
        '    jackpot += 25
        '    p2Money -= 25
        '    Me.picJackpot.Image = My.Resources.PokerChip_25
        'ElseIf picComp100.Tag Then
        '    jackpot += 100
        '    p2Money -= 100
        '    Me.picJackpot.Image = My.Resources.PokerChip_100
        'ElseIf picComp50.Tag Then
        '    jackpot += 50
        '    p2Money -= 50
        '    Me.picJackpot.Image = My.Resources.PokerChip_50
        'ElseIf picComp500.Tag Then
        '    jackpot += 500
        '    p2Money -= 500
        '    Me.picJackpot.Image = My.Resources.PokerChip_500
        'ElseIf picComp1000.Tag Then
        '    jackpot += 1000
        '    p2Money -= 1000
        '    Me.picJackpot.Image = My.Resources.PokerChip_1000
        'End If

        jackpotUpdate()
    End Sub

    Private Sub btnComputerBet_Click(sender As System.Object, e As System.EventArgs) Handles btnComputerBet.Click
        Dim cpuBet As Integer
        Select Case RndInt(5, 1)
            Case 1
                p2Money -= 25
                jackpot += 25
                cpuBet = 25
            Case 2
                p2Money -= 50
                jackpot += 50
                cpuBet = 50
            Case 3
                p2Money -= 100
                jackpot += 100
                cpuBet = 100
            Case 4
                p2Money -= 500
                jackpot += 500
                cpuBet = 500
            Case 5
                p2Money -= 1000
                jackpot += 1000
                cpuBet = 1000
        End Select
        Me.btnComputerBet.Enabled = False
        computerBet = True
        MessageBox.Show("The computer has placed a bet of $" & cpuBet)
        Me.lblP2Money.Text = "$" & p2Money
        Me.lblJackpot.Text = "$" & jackpot
    End Sub
End Class
