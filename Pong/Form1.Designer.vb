<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ball = New System.Windows.Forms.PictureBox()
        Me.paddle1 = New System.Windows.Forms.PictureBox()
        Me.paddle2 = New System.Windows.Forms.PictureBox()
        Me.p1Points = New System.Windows.Forms.TextBox()
        Me.p2Points = New System.Windows.Forms.TextBox()
        Me.pauseBackground = New System.Windows.Forms.Panel()
        Me.pausedLabel = New System.Windows.Forms.Label()
        Me.pauseResumeButton = New System.Windows.Forms.Button()
        Me.pauseMainMenuButton = New System.Windows.Forms.Button()
        Me.resultsBackground = New System.Windows.Forms.Panel()
        Me.resultPlayAgainButton = New System.Windows.Forms.Button()
        Me.resultMainMenuButton = New System.Windows.Forms.Button()
        Me.resultPlayer2 = New System.Windows.Forms.Label()
        Me.resultPlayer1 = New System.Windows.Forms.Label()
        Me.resultWellDone = New System.Windows.Forms.Label()
        Me.menuBackground = New System.Windows.Forms.Panel()
        Me.menuPlayButton = New System.Windows.Forms.Button()
        Me.menuTitle = New System.Windows.Forms.Label()
        Me.menuAIPlayButton = New System.Windows.Forms.Button()
        CType(Me.ball, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.paddle1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.paddle2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pauseBackground.SuspendLayout()
        Me.resultsBackground.SuspendLayout()
        Me.menuBackground.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'ball
        '
        Me.ball.BackColor = System.Drawing.SystemColors.Control
        Me.ball.Location = New System.Drawing.Point(355, 181)
        Me.ball.Name = "ball"
        Me.ball.Size = New System.Drawing.Size(20, 20)
        Me.ball.TabIndex = 0
        Me.ball.TabStop = False
        '
        'paddle1
        '
        Me.paddle1.BackColor = System.Drawing.SystemColors.Control
        Me.paddle1.Location = New System.Drawing.Point(12, 181)
        Me.paddle1.Name = "paddle1"
        Me.paddle1.Size = New System.Drawing.Size(20, 100)
        Me.paddle1.TabIndex = 1
        Me.paddle1.TabStop = False
        '
        'paddle2
        '
        Me.paddle2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.paddle2.BackColor = System.Drawing.SystemColors.Control
        Me.paddle2.Location = New System.Drawing.Point(750, 181)
        Me.paddle2.Name = "paddle2"
        Me.paddle2.Size = New System.Drawing.Size(20, 100)
        Me.paddle2.TabIndex = 2
        Me.paddle2.TabStop = False
        '
        'p1Points
        '
        Me.p1Points.BackColor = System.Drawing.SystemColors.MenuText
        Me.p1Points.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.p1Points.Enabled = False
        Me.p1Points.Font = New System.Drawing.Font("SimSun", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.p1Points.ForeColor = System.Drawing.SystemColors.Window
        Me.p1Points.Location = New System.Drawing.Point(269, 12)
        Me.p1Points.Name = "p1Points"
        Me.p1Points.ReadOnly = True
        Me.p1Points.Size = New System.Drawing.Size(125, 92)
        Me.p1Points.TabIndex = 3
        '
        'p2Points
        '
        Me.p2Points.BackColor = System.Drawing.SystemColors.MenuText
        Me.p2Points.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.p2Points.Enabled = False
        Me.p2Points.Font = New System.Drawing.Font("SimSun", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.p2Points.ForeColor = System.Drawing.SystemColors.Window
        Me.p2Points.Location = New System.Drawing.Point(411, 12)
        Me.p2Points.Name = "p2Points"
        Me.p2Points.ReadOnly = True
        Me.p2Points.Size = New System.Drawing.Size(125, 92)
        Me.p2Points.TabIndex = 5
        '
        'pauseBackground
        '
        Me.pauseBackground.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.pauseBackground.Controls.Add(Me.pausedLabel)
        Me.pauseBackground.Controls.Add(Me.pauseResumeButton)
        Me.pauseBackground.Controls.Add(Me.pauseMainMenuButton)
        Me.pauseBackground.Location = New System.Drawing.Point(255, 71)
        Me.pauseBackground.Name = "pauseBackground"
        Me.pauseBackground.Size = New System.Drawing.Size(300, 235)
        Me.pauseBackground.TabIndex = 6
        '
        'pausedLabel
        '
        Me.pausedLabel.AutoSize = True
        Me.pausedLabel.Font = New System.Drawing.Font("SimSun", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.pausedLabel.Location = New System.Drawing.Point(46, 36)
        Me.pausedLabel.Name = "pausedLabel"
        Me.pausedLabel.Size = New System.Drawing.Size(205, 60)
        Me.pausedLabel.TabIndex = 2
        Me.pausedLabel.Text = "Paused"
        Me.pausedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pauseResumeButton
        '
        Me.pauseResumeButton.Location = New System.Drawing.Point(100, 110)
        Me.pauseResumeButton.Name = "pauseResumeButton"
        Me.pauseResumeButton.Size = New System.Drawing.Size(94, 29)
        Me.pauseResumeButton.TabIndex = 1
        Me.pauseResumeButton.Text = "Resume"
        Me.pauseResumeButton.UseVisualStyleBackColor = True
        '
        'pauseMainMenuButton
        '
        Me.pauseMainMenuButton.Location = New System.Drawing.Point(100, 156)
        Me.pauseMainMenuButton.Name = "pauseMainMenuButton"
        Me.pauseMainMenuButton.Size = New System.Drawing.Size(94, 29)
        Me.pauseMainMenuButton.TabIndex = 0
        Me.pauseMainMenuButton.Text = "Main Menu"
        Me.pauseMainMenuButton.UseVisualStyleBackColor = True
        '
        'resultsBackground
        '
        Me.resultsBackground.BackColor = System.Drawing.SystemColors.GrayText
        Me.resultsBackground.Controls.Add(Me.resultPlayAgainButton)
        Me.resultsBackground.Controls.Add(Me.resultMainMenuButton)
        Me.resultsBackground.Controls.Add(Me.resultPlayer2)
        Me.resultsBackground.Controls.Add(Me.resultPlayer1)
        Me.resultsBackground.Controls.Add(Me.resultWellDone)
        Me.resultsBackground.Location = New System.Drawing.Point(141, 22)
        Me.resultsBackground.Name = "resultsBackground"
        Me.resultsBackground.Size = New System.Drawing.Size(500, 350)
        Me.resultsBackground.TabIndex = 7
        '
        'resultPlayAgainButton
        '
        Me.resultPlayAgainButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.resultPlayAgainButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.resultPlayAgainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.resultPlayAgainButton.Font = New System.Drawing.Font("SimSun", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.resultPlayAgainButton.Location = New System.Drawing.Point(268, 263)
        Me.resultPlayAgainButton.Name = "resultPlayAgainButton"
        Me.resultPlayAgainButton.Size = New System.Drawing.Size(229, 84)
        Me.resultPlayAgainButton.TabIndex = 4
        Me.resultPlayAgainButton.Text = "Play Again"
        Me.resultPlayAgainButton.UseVisualStyleBackColor = False
        '
        'resultMainMenuButton
        '
        Me.resultMainMenuButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.resultMainMenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.resultMainMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.resultMainMenuButton.Font = New System.Drawing.Font("SimSun", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.resultMainMenuButton.Location = New System.Drawing.Point(3, 263)
        Me.resultMainMenuButton.Name = "resultMainMenuButton"
        Me.resultMainMenuButton.Size = New System.Drawing.Size(229, 84)
        Me.resultMainMenuButton.TabIndex = 3
        Me.resultMainMenuButton.Text = "Main Menu"
        Me.resultMainMenuButton.UseVisualStyleBackColor = False
        '
        'resultPlayer2
        '
        Me.resultPlayer2.AutoSize = True
        Me.resultPlayer2.Font = New System.Drawing.Font("SimSun", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.resultPlayer2.Location = New System.Drawing.Point(170, 145)
        Me.resultPlayer2.Name = "resultPlayer2"
        Me.resultPlayer2.Size = New System.Drawing.Size(195, 43)
        Me.resultPlayer2.TabIndex = 2
        Me.resultPlayer2.Text = "Player 2"
        '
        'resultPlayer1
        '
        Me.resultPlayer1.AutoSize = True
        Me.resultPlayer1.Font = New System.Drawing.Font("SimSun", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.resultPlayer1.Location = New System.Drawing.Point(160, 142)
        Me.resultPlayer1.Name = "resultPlayer1"
        Me.resultPlayer1.Size = New System.Drawing.Size(195, 43)
        Me.resultPlayer1.TabIndex = 1
        Me.resultPlayer1.Text = "Player 1"
        '
        'resultWellDone
        '
        Me.resultWellDone.AutoSize = True
        Me.resultWellDone.BackColor = System.Drawing.SystemColors.GrayText
        Me.resultWellDone.Font = New System.Drawing.Font("SimSun", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.resultWellDone.Location = New System.Drawing.Point(65, 18)
        Me.resultWellDone.Name = "resultWellDone"
        Me.resultWellDone.Size = New System.Drawing.Size(394, 80)
        Me.resultWellDone.TabIndex = 0
        Me.resultWellDone.Text = "Well Done"
        '
        'menuBackground
        '
        Me.menuBackground.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.menuBackground.Controls.Add(Me.menuAIPlayButton)
        Me.menuBackground.Controls.Add(Me.menuPlayButton)
        Me.menuBackground.Controls.Add(Me.menuTitle)
        Me.menuBackground.Location = New System.Drawing.Point(2, 2)
        Me.menuBackground.Name = "menuBackground"
        Me.menuBackground.Size = New System.Drawing.Size(776, 399)
        Me.menuBackground.TabIndex = 8
        '
        'menuPlayButton
        '
        Me.menuPlayButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.menuPlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.menuPlayButton.Font = New System.Drawing.Font("SimSun", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.menuPlayButton.Location = New System.Drawing.Point(204, 260)
        Me.menuPlayButton.Name = "menuPlayButton"
        Me.menuPlayButton.Size = New System.Drawing.Size(171, 66)
        Me.menuPlayButton.TabIndex = 1
        Me.menuPlayButton.Text = "Play 1v1"
        Me.menuPlayButton.UseVisualStyleBackColor = False
        '
        'menuTitle
        '
        Me.menuTitle.AutoSize = True
        Me.menuTitle.Font = New System.Drawing.Font("SimSun", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.menuTitle.ForeColor = System.Drawing.SystemColors.Control
        Me.menuTitle.Location = New System.Drawing.Point(299, 20)
        Me.menuTitle.Name = "menuTitle"
        Me.menuTitle.Size = New System.Drawing.Size(194, 80)
        Me.menuTitle.TabIndex = 0
        Me.menuTitle.Text = "Pong"
        '
        'menuAIPlayButton
        '
        Me.menuAIPlayButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.menuAIPlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.menuAIPlayButton.Font = New System.Drawing.Font("SimSun", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.menuAIPlayButton.Location = New System.Drawing.Point(407, 260)
        Me.menuAIPlayButton.Name = "menuAIPlayButton"
        Me.menuAIPlayButton.Size = New System.Drawing.Size(171, 66)
        Me.menuAIPlayButton.TabIndex = 2
        Me.menuAIPlayButton.Text = "Play 1vAI"
        Me.menuAIPlayButton.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(782, 403)
        Me.Controls.Add(Me.menuBackground)
        Me.Controls.Add(Me.resultsBackground)
        Me.Controls.Add(Me.pauseBackground)
        Me.Controls.Add(Me.paddle2)
        Me.Controls.Add(Me.paddle1)
        Me.Controls.Add(Me.ball)
        Me.Controls.Add(Me.p2Points)
        Me.Controls.Add(Me.p1Points)
        Me.MinimumSize = New System.Drawing.Size(800, 450)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.ball, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.paddle1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.paddle2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pauseBackground.ResumeLayout(False)
        Me.pauseBackground.PerformLayout()
        Me.resultsBackground.ResumeLayout(False)
        Me.resultsBackground.PerformLayout()
        Me.menuBackground.ResumeLayout(False)
        Me.menuBackground.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents ball As PictureBox
    Friend WithEvents paddle1 As PictureBox
    Friend WithEvents paddle2 As PictureBox
    Friend WithEvents p1Points As TextBox
    Friend WithEvents p2Points As TextBox
    Friend WithEvents pauseBackground As Panel
    Friend WithEvents pauseResumeButton As Button
    Friend WithEvents pauseMainMenuButton As Button
    Friend WithEvents pausedLabel As Label
    Friend WithEvents resultsBackground As Panel
    Friend WithEvents resultWellDone As Label
    Friend WithEvents resultPlayer1 As Label
    Friend WithEvents resultPlayer2 As Label
    Friend WithEvents resultPlayAgainButton As Button
    Friend WithEvents resultMainMenuButton As Button
    Friend WithEvents menuBackground As Panel
    Friend WithEvents menuTitle As Label
    Friend WithEvents menuPlayButton As Button
    Friend WithEvents menuAIPlayButton As Button
End Class
