<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblComputer = New System.Windows.Forms.Label()
        Me.lblUserScore = New System.Windows.Forms.Label()
        Me.lblCPUScore = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.cardTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GameOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.picUser1000 = New System.Windows.Forms.PictureBox()
        Me.picUser500 = New System.Windows.Forms.PictureBox()
        Me.picUser100 = New System.Windows.Forms.PictureBox()
        Me.picUser50 = New System.Windows.Forms.PictureBox()
        Me.picUser25 = New System.Windows.Forms.PictureBox()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.picCompCard3 = New System.Windows.Forms.PictureBox()
        Me.picCompCard2 = New System.Windows.Forms.PictureBox()
        Me.picCompCard1 = New System.Windows.Forms.PictureBox()
        Me.picCard3 = New System.Windows.Forms.PictureBox()
        Me.picCard2 = New System.Windows.Forms.PictureBox()
        Me.picCard1 = New System.Windows.Forms.PictureBox()
        Me.picComp1000 = New System.Windows.Forms.PictureBox()
        Me.picComp500 = New System.Windows.Forms.PictureBox()
        Me.picComp100 = New System.Windows.Forms.PictureBox()
        Me.picComp50 = New System.Windows.Forms.PictureBox()
        Me.picComp25 = New System.Windows.Forms.PictureBox()
        Me.lblJackpot = New System.Windows.Forms.Label()
        Me.picJackpot = New System.Windows.Forms.PictureBox()
        Me.lblP1Money = New System.Windows.Forms.Label()
        Me.lblP2Money = New System.Windows.Forms.Label()
        Me.btnComputerBet = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picUser1000, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUser500, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUser100, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUser50, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUser25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCompCard3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCompCard2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCompCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCard3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCard2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picComp1000, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picComp500, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picComp100, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picComp50, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picComp25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picJackpot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPlay
        '
        Me.btnPlay.BackColor = System.Drawing.SystemColors.Control
        Me.btnPlay.Location = New System.Drawing.Point(290, 184)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(120, 22)
        Me.btnPlay.TabIndex = 6
        Me.btnPlay.Text = "Play Game"
        Me.btnPlay.UseVisualStyleBackColor = False
        '
        'lblResult
        '
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(116, 206)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(143, 51)
        Me.lblResult.TabIndex = 7
        Me.lblResult.Text = "RESULT"
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUser
        '
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(116, 47)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(143, 39)
        Me.lblUser.TabIndex = 8
        Me.lblUser.Text = "You"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblComputer
        '
        Me.lblComputer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComputer.Location = New System.Drawing.Point(438, 47)
        Me.lblComputer.Name = "lblComputer"
        Me.lblComputer.Size = New System.Drawing.Size(143, 39)
        Me.lblComputer.TabIndex = 9
        Me.lblComputer.Text = "Computer"
        Me.lblComputer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUserScore
        '
        Me.lblUserScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserScore.Location = New System.Drawing.Point(116, 177)
        Me.lblUserScore.Name = "lblUserScore"
        Me.lblUserScore.Size = New System.Drawing.Size(143, 39)
        Me.lblUserScore.TabIndex = 10
        Me.lblUserScore.Text = "Score"
        Me.lblUserScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCPUScore
        '
        Me.lblCPUScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPUScore.Location = New System.Drawing.Point(438, 177)
        Me.lblCPUScore.Name = "lblCPUScore"
        Me.lblCPUScore.Size = New System.Drawing.Size(143, 39)
        Me.lblCPUScore.TabIndex = 11
        Me.lblCPUScore.Text = "Score"
        Me.lblCPUScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScore
        '
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(438, 206)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(143, 57)
        Me.lblScore.TabIndex = 12
        Me.lblScore.Text = "You: 0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Computer: 0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Draw: 0"
        '
        'cardTimer
        '
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GameOptionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(721, 24)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GameOptionsToolStripMenuItem
        '
        Me.GameOptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetToolStripMenuItem})
        Me.GameOptionsToolStripMenuItem.Name = "GameOptionsToolStripMenuItem"
        Me.GameOptionsToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.GameOptionsToolStripMenuItem.Text = "Game Options"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'picUser1000
        '
        Me.picUser1000.Image = Global.CardGame_.My.Resources.Resources.PokerChip_1000
        Me.picUser1000.Location = New System.Drawing.Point(195, 330)
        Me.picUser1000.Name = "picUser1000"
        Me.picUser1000.Size = New System.Drawing.Size(64, 64)
        Me.picUser1000.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picUser1000.TabIndex = 19
        Me.picUser1000.TabStop = False
        Me.picUser1000.Tag = "5"
        '
        'picUser500
        '
        Me.picUser500.Image = Global.CardGame_.My.Resources.Resources.PokerChip_500
        Me.picUser500.Location = New System.Drawing.Point(120, 330)
        Me.picUser500.Name = "picUser500"
        Me.picUser500.Size = New System.Drawing.Size(64, 64)
        Me.picUser500.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picUser500.TabIndex = 18
        Me.picUser500.TabStop = False
        Me.picUser500.Tag = "4"
        '
        'picUser100
        '
        Me.picUser100.Image = Global.CardGame_.My.Resources.Resources.PokerChip_100
        Me.picUser100.Location = New System.Drawing.Point(229, 260)
        Me.picUser100.Name = "picUser100"
        Me.picUser100.Size = New System.Drawing.Size(64, 64)
        Me.picUser100.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picUser100.TabIndex = 17
        Me.picUser100.TabStop = False
        Me.picUser100.Tag = "3"
        '
        'picUser50
        '
        Me.picUser50.Image = Global.CardGame_.My.Resources.Resources.PokerChip_50
        Me.picUser50.Location = New System.Drawing.Point(155, 260)
        Me.picUser50.Name = "picUser50"
        Me.picUser50.Size = New System.Drawing.Size(64, 64)
        Me.picUser50.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picUser50.TabIndex = 16
        Me.picUser50.TabStop = False
        Me.picUser50.Tag = "2"
        '
        'picUser25
        '
        Me.picUser25.Image = CType(resources.GetObject("picUser25.Image"), System.Drawing.Image)
        Me.picUser25.Location = New System.Drawing.Point(84, 260)
        Me.picUser25.Name = "picUser25"
        Me.picUser25.Size = New System.Drawing.Size(64, 64)
        Me.picUser25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picUser25.TabIndex = 15
        Me.picUser25.TabStop = False
        Me.picUser25.Tag = "1"
        '
        'btnStop
        '
        Me.btnStop.Image = Global.CardGame_.My.Resources.Resources.STAHP
        Me.btnStop.Location = New System.Drawing.Point(305, 212)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(94, 94)
        Me.btnStop.TabIndex = 13
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'picCompCard3
        '
        Me.picCompCard3.Image = Global.CardGame_.My.Resources.Resources.cardback
        Me.picCompCard3.Location = New System.Drawing.Point(549, 89)
        Me.picCompCard3.Name = "picCompCard3"
        Me.picCompCard3.Size = New System.Drawing.Size(68, 85)
        Me.picCompCard3.TabIndex = 5
        Me.picCompCard3.TabStop = False
        Me.picCompCard3.Tag = "3"
        '
        'picCompCard2
        '
        Me.picCompCard2.Image = Global.CardGame_.My.Resources.Resources.cardback
        Me.picCompCard2.Location = New System.Drawing.Point(475, 89)
        Me.picCompCard2.Name = "picCompCard2"
        Me.picCompCard2.Size = New System.Drawing.Size(68, 85)
        Me.picCompCard2.TabIndex = 4
        Me.picCompCard2.TabStop = False
        Me.picCompCard2.Tag = "2"
        '
        'picCompCard1
        '
        Me.picCompCard1.Image = Global.CardGame_.My.Resources.Resources.cardback
        Me.picCompCard1.Location = New System.Drawing.Point(401, 89)
        Me.picCompCard1.Name = "picCompCard1"
        Me.picCompCard1.Size = New System.Drawing.Size(68, 85)
        Me.picCompCard1.TabIndex = 3
        Me.picCompCard1.TabStop = False
        Me.picCompCard1.Tag = "1"
        '
        'picCard3
        '
        Me.picCard3.Image = Global.CardGame_.My.Resources.Resources.cardback
        Me.picCard3.Location = New System.Drawing.Point(233, 89)
        Me.picCard3.Name = "picCard3"
        Me.picCard3.Size = New System.Drawing.Size(68, 85)
        Me.picCard3.TabIndex = 2
        Me.picCard3.TabStop = False
        Me.picCard3.Tag = "Card3"
        '
        'picCard2
        '
        Me.picCard2.Image = Global.CardGame_.My.Resources.Resources.cardback
        Me.picCard2.Location = New System.Drawing.Point(159, 89)
        Me.picCard2.Name = "picCard2"
        Me.picCard2.Size = New System.Drawing.Size(68, 85)
        Me.picCard2.TabIndex = 1
        Me.picCard2.TabStop = False
        Me.picCard2.Tag = "Card2"
        '
        'picCard1
        '
        Me.picCard1.Image = Global.CardGame_.My.Resources.Resources.cardback
        Me.picCard1.Location = New System.Drawing.Point(85, 89)
        Me.picCard1.Name = "picCard1"
        Me.picCard1.Size = New System.Drawing.Size(68, 85)
        Me.picCard1.TabIndex = 0
        Me.picCard1.TabStop = False
        Me.picCard1.Tag = "Card1"
        '
        'picComp1000
        '
        Me.picComp1000.Image = Global.CardGame_.My.Resources.Resources.PokerChip_1000
        Me.picComp1000.Location = New System.Drawing.Point(531, 330)
        Me.picComp1000.Name = "picComp1000"
        Me.picComp1000.Size = New System.Drawing.Size(64, 64)
        Me.picComp1000.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picComp1000.TabIndex = 24
        Me.picComp1000.TabStop = False
        Me.picComp1000.Tag = "5"
        '
        'picComp500
        '
        Me.picComp500.Image = Global.CardGame_.My.Resources.Resources.PokerChip_500
        Me.picComp500.Location = New System.Drawing.Point(456, 330)
        Me.picComp500.Name = "picComp500"
        Me.picComp500.Size = New System.Drawing.Size(64, 64)
        Me.picComp500.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picComp500.TabIndex = 23
        Me.picComp500.TabStop = False
        Me.picComp500.Tag = "4"
        '
        'picComp100
        '
        Me.picComp100.Image = Global.CardGame_.My.Resources.Resources.PokerChip_100
        Me.picComp100.Location = New System.Drawing.Point(565, 260)
        Me.picComp100.Name = "picComp100"
        Me.picComp100.Size = New System.Drawing.Size(64, 64)
        Me.picComp100.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picComp100.TabIndex = 22
        Me.picComp100.TabStop = False
        Me.picComp100.Tag = "3"
        '
        'picComp50
        '
        Me.picComp50.Image = Global.CardGame_.My.Resources.Resources.PokerChip_50
        Me.picComp50.Location = New System.Drawing.Point(491, 260)
        Me.picComp50.Name = "picComp50"
        Me.picComp50.Size = New System.Drawing.Size(64, 64)
        Me.picComp50.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picComp50.TabIndex = 21
        Me.picComp50.TabStop = False
        Me.picComp50.Tag = "2"
        '
        'picComp25
        '
        Me.picComp25.Image = CType(resources.GetObject("picComp25.Image"), System.Drawing.Image)
        Me.picComp25.Location = New System.Drawing.Point(420, 260)
        Me.picComp25.Name = "picComp25"
        Me.picComp25.Size = New System.Drawing.Size(64, 64)
        Me.picComp25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picComp25.TabIndex = 20
        Me.picComp25.TabStop = False
        Me.picComp25.Tag = "1"
        '
        'lblJackpot
        '
        Me.lblJackpot.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJackpot.Location = New System.Drawing.Point(199, 405)
        Me.lblJackpot.Name = "lblJackpot"
        Me.lblJackpot.Size = New System.Drawing.Size(302, 51)
        Me.lblJackpot.TabIndex = 25
        Me.lblJackpot.Text = "JACKPOT:"
        Me.lblJackpot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picJackpot
        '
        Me.picJackpot.Image = CType(resources.GetObject("picJackpot.Image"), System.Drawing.Image)
        Me.picJackpot.Location = New System.Drawing.Point(317, 459)
        Me.picJackpot.Name = "picJackpot"
        Me.picJackpot.Size = New System.Drawing.Size(64, 64)
        Me.picJackpot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picJackpot.TabIndex = 26
        Me.picJackpot.TabStop = False
        '
        'lblP1Money
        '
        Me.lblP1Money.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP1Money.Location = New System.Drawing.Point(12, 405)
        Me.lblP1Money.Name = "lblP1Money"
        Me.lblP1Money.Size = New System.Drawing.Size(233, 51)
        Me.lblP1Money.TabIndex = 27
        Me.lblP1Money.Text = "$1500"
        Me.lblP1Money.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblP2Money
        '
        Me.lblP2Money.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP2Money.Location = New System.Drawing.Point(470, 405)
        Me.lblP2Money.Name = "lblP2Money"
        Me.lblP2Money.Size = New System.Drawing.Size(233, 51)
        Me.lblP2Money.TabIndex = 28
        Me.lblP2Money.Text = "$1500"
        Me.lblP2Money.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnComputerBet
        '
        Me.btnComputerBet.BackColor = System.Drawing.SystemColors.Control
        Me.btnComputerBet.Location = New System.Drawing.Point(302, 312)
        Me.btnComputerBet.Name = "btnComputerBet"
        Me.btnComputerBet.Size = New System.Drawing.Size(102, 57)
        Me.btnComputerBet.TabIndex = 29
        Me.btnComputerBet.Text = "Generate Computer Bet"
        Me.btnComputerBet.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(721, 544)
        Me.Controls.Add(Me.btnComputerBet)
        Me.Controls.Add(Me.lblP2Money)
        Me.Controls.Add(Me.lblP1Money)
        Me.Controls.Add(Me.picJackpot)
        Me.Controls.Add(Me.lblJackpot)
        Me.Controls.Add(Me.picComp1000)
        Me.Controls.Add(Me.picComp500)
        Me.Controls.Add(Me.picComp100)
        Me.Controls.Add(Me.picComp50)
        Me.Controls.Add(Me.picComp25)
        Me.Controls.Add(Me.picUser1000)
        Me.Controls.Add(Me.picUser500)
        Me.Controls.Add(Me.picUser100)
        Me.Controls.Add(Me.picUser50)
        Me.Controls.Add(Me.picUser25)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblCPUScore)
        Me.Controls.Add(Me.lblUserScore)
        Me.Controls.Add(Me.lblComputer)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.picCompCard3)
        Me.Controls.Add(Me.picCompCard2)
        Me.Controls.Add(Me.picCompCard1)
        Me.Controls.Add(Me.picCard3)
        Me.Controls.Add(Me.picCard2)
        Me.Controls.Add(Me.picCard1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Card Game"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picUser1000, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUser500, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUser100, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUser50, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUser25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCompCard3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCompCard2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCompCard1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCard3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCard2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCard1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picComp1000, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picComp500, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picComp100, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picComp50, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picComp25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picJackpot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picCard1 As System.Windows.Forms.PictureBox
    Friend WithEvents picCard2 As System.Windows.Forms.PictureBox
    Friend WithEvents picCard3 As System.Windows.Forms.PictureBox
    Friend WithEvents picCompCard1 As System.Windows.Forms.PictureBox
    Friend WithEvents picCompCard2 As System.Windows.Forms.PictureBox
    Friend WithEvents picCompCard3 As System.Windows.Forms.PictureBox
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents lblComputer As System.Windows.Forms.Label
    Friend WithEvents lblUserScore As System.Windows.Forms.Label
    Friend WithEvents lblCPUScore As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents cardTimer As System.Windows.Forms.Timer
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GameOptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents picUser25 As System.Windows.Forms.PictureBox
    Friend WithEvents picUser50 As System.Windows.Forms.PictureBox
    Friend WithEvents picUser100 As System.Windows.Forms.PictureBox
    Friend WithEvents picUser500 As System.Windows.Forms.PictureBox
    Friend WithEvents picUser1000 As System.Windows.Forms.PictureBox
    Friend WithEvents picComp1000 As System.Windows.Forms.PictureBox
    Friend WithEvents picComp500 As System.Windows.Forms.PictureBox
    Friend WithEvents picComp100 As System.Windows.Forms.PictureBox
    Friend WithEvents picComp50 As System.Windows.Forms.PictureBox
    Friend WithEvents picComp25 As System.Windows.Forms.PictureBox
    Friend WithEvents lblJackpot As System.Windows.Forms.Label
    Friend WithEvents picJackpot As System.Windows.Forms.PictureBox
    Friend WithEvents lblP1Money As System.Windows.Forms.Label
    Friend WithEvents lblP2Money As System.Windows.Forms.Label
    Friend WithEvents btnComputerBet As System.Windows.Forms.Button

End Class
