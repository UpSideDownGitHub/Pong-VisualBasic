
Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography

Public Class Form1
    ' paddle variables
    Dim p1PaddleUp As Boolean = False
    Dim p1PaddleDown As Boolean = False
    Dim p2PaddleUp As Boolean = False
    Dim p2PaddleDown As Boolean = False
    Dim paddleSpeed As Decimal = 10

    ' ball variables
    Dim ballVelocity As Point = New Point(5, 5)
    Dim minYVel As Integer = 5
    Dim maxYVel As Integer = 10

    ' points
    Dim p1PointsNum As Integer = 0
    Dim p2PointsNum As Integer = 0

    ' pause menu
    Dim paused As Boolean = False

    ' results menu
    Dim results As Boolean = False

    ' main menu
    Dim mainmenu As Boolean = False

    ' AI
    Dim playingAI As Boolean = False
    Dim movingTowards As Boolean = True
    Dim AIMovementSpeed As Decimal = 4

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' set all of the default sizes
        p1Points.Text = p1PointsNum
        p2Points.Text = p2PointsNum
        disablePauseMenu()
        disableResultsMenu()
        enableMainMenu()
    End Sub

    Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        ' set the new position of every item as the size has changed
        enablePauseMenu()
        ' points lable
        p1Points.Location = New Point(Size.Width / 2 - p1Points.Width, 10)
        p2Points.Location = New Point(Size.Width / 2 + p2Points.Width / 2, 10)
        ' pause menu
        pauseBackground.Location = New Point(Size.Width / 2 - pauseBackground.Width / 2, Size.Height / 2 - pauseBackground.Height / 2)
        ' results menu
        resultsBackground.Location = New Point(Size.Width / 2 - resultsBackground.Width / 2, Size.Height / 2 - resultsBackground.Height / 2)
        ' main menu
        menuTitle.Location = New Point(Size.Width / 2 - menuTitle.Width / 2, 50)
        menuPlayButton.Location = New Point(Size.Width / 2 - menuPlayButton.Width - 25, Size.Height / 2)
        menuAIPlayButton.Location = New Point(Size.Width / 2 + 25, Size.Height / 2)
        'paddles
        paddle1.Location = New Point(paddle1.Location.X, Size.Height / 2 - paddle1.Height / 2)
        paddle2.Location = New Point(paddle2.Location.X, Size.Height / 2 - paddle2.Height / 2)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not paused And Not results And Not mainmenu Then
            gameLoop()
        End If
    End Sub

    Sub gameLoop()
        ' paddle movement 
        If p1PaddleUp Then
            If paddle1.Location.Y >= 0 Then
                paddle1.Location = New Point(paddle1.Location.X, paddle1.Location.Y - paddleSpeed)
            End If
        ElseIf p1PaddleDown Then
            If paddle1.Location.Y <= ActiveForm.Height - paddle2.Height * 1.5 Then
                paddle1.Location = New Point(paddle1.Location.X, paddle1.Location.Y + paddleSpeed)
            End If
        End If
        If Not playingAI Then
            If p2PaddleUp Then
                If paddle2.Location.Y >= 0 Then
                    paddle2.Location = New Point(paddle2.Location.X, paddle2.Location.Y - paddleSpeed)
                End If
            ElseIf p2PaddleDown Then
                If paddle2.Location.Y <= ActiveForm.Height - paddle2.Height * 1.5 Then
                    paddle2.Location = New Point(paddle2.Location.X, paddle2.Location.Y + paddleSpeed)
                End If
            End If
        ElseIf movingTowards Then
            ' move the paddle2 to match the balls current location
            If ball.Location.Y > paddle2.Location.Y Then
                If paddle2.Location.Y <= ActiveForm.Height - paddle2.Height * 1.5 Then
                    paddle2.Location = New Point(paddle2.Location.X, paddle2.Location.Y + AIMovementSpeed)
                End If
            Else
                If paddle2.Location.Y >= 0 Then
                    paddle2.Location = New Point(paddle2.Location.X, paddle2.Location.Y - AIMovementSpeed)
                End If
            End If
        End If


        ' ball movement
        ball.Location = New Point(ball.Location.X + ballVelocity.X, ball.Location.Y + ballVelocity.Y)
        If (ball.Location.Y <= 0 Or ball.Location.Y >= ActiveForm.Height - ball.Height * 3) Then
            ballVelocity.Y = -ballVelocity.Y
        End If

        ' ball & paddle collision
        If ball.Bounds.IntersectsWith(paddle1.Bounds) Or ball.Bounds.IntersectsWith(paddle2.Bounds) Then
            ballVelocity.X = -ballVelocity.X
            ball.Location = New Point(ball.Location.X + ballVelocity.X * 5, ball.Location.Y + ballVelocity.Y)
            If playingAI Then
                movingTowards = Not movingTowards
            End If
        End If

        ' ball scoring
        If ball.Location.X <= 0 Then
            p2PointsNum += 1
            p2Points.Text = p2PointsNum
            ballVelocity.X = -ballVelocity.X
            If playingAI Then
                movingTowards = True
            End If
            resetBall()
        ElseIf ball.Location.X >= ActiveForm.Width - ball.Width * 1.5 Then
            p1PointsNum += 1
            p1Points.Text = p1PointsNum
            ballVelocity.X = -ballVelocity.X
            If playingAI Then
                movingTowards = False
            End If
            resetBall()
        End If

        If p1PointsNum = 11 Or p2PointsNum = 11 Then
            enableResultsMenu()
        End If
    End Sub

    Sub restartGame()
        p1PointsNum = 0
        p2PointsNum = 0
        p1Points.Text = p1PointsNum
        p2Points.Text = p2PointsNum
        disableResultsMenu()
        disablePauseMenu()
        resetBall()
    End Sub

    Sub resetBall()
        ball.Location = New Point(ActiveForm.Width / 2, ActiveForm.Height / 2)
        ballVelocity = New Point(ballVelocity.X, RandomNumberGenerator.GetInt32(minYVel, maxYVel))
    End Sub

    ' check for input
    Private Sub Control_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If Not results And Not mainmenu Then
            If e.KeyCode = Keys.Escape And Not paused Then
                enablePauseMenu()
            ElseIf e.KeyCode = Keys.Escape And paused Then
                disablePauseMenu()
            End If
        End If

        If Not paused And Not results And Not mainmenu Then
            If e.KeyCode = Keys.W Then
                p1PaddleUp = True
            ElseIf e.KeyCode = Keys.S Then
                p1PaddleDown = True
            End If
            If Not playingAI Then
                If e.KeyCode = Keys.Up Then
                    p2PaddleUp = True
                ElseIf e.KeyCode = Keys.Down Then
                    p2PaddleDown = True
                End If
            End If
        End If
    End Sub
    Private Sub Control_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If Not paused And Not results And Not mainmenu Then
            If e.KeyCode = Keys.W Then
                p1PaddleUp = False
            ElseIf e.KeyCode = Keys.S Then
                p1PaddleDown = False
            End If
            If Not playingAI Then
                If e.KeyCode = Keys.Up Then
                    p2PaddleUp = False
                ElseIf e.KeyCode = Keys.Down Then
                    p2PaddleDown = False
                End If
            End If
        End If
    End Sub



    Private Sub resume_button_Click(sender As Object, e As EventArgs) Handles pauseResumeButton.Click
        If paused Then
            disablePauseMenu()
        End If
    End Sub

    Private Sub mainmenu_button_Click(sender As Object, e As EventArgs) Handles pauseMainMenuButton.Click
        If paused Then
            enableMainMenu()
        End If
    End Sub
    Private Sub resultMainMenuButton_Click(sender As Object, e As EventArgs) Handles resultMainMenuButton.Click
        If results Then
            enableMainMenu()
        End If
    End Sub

    Private Sub resultPlayAgainButton_Click(sender As Object, e As EventArgs) Handles resultPlayAgainButton.Click
        If results Then
            restartGame()
        End If
    End Sub
    Private Sub menuPlayButton_Click(sender As Object, e As EventArgs) Handles menuPlayButton.Click
        If mainmenu Then
            disableMainMenu()
            restartGame()
        End If
    End Sub
    Private Sub menuAIPlayButton_Click(sender As Object, e As EventArgs) Handles menuAIPlayButton.Click
        If mainmenu Then
            playingAI = True
            disableMainMenu()
            restartGame()
        End If
    End Sub

    Sub enablePauseMenu()
        paused = True
        pauseBackground.Enabled = True
        pausedLabel.Enabled = True
        pauseResumeButton.Enabled = True
        pauseMainMenuButton.Enabled = True
        pauseBackground.Visible = True
        pausedLabel.Visible = True
        pauseResumeButton.Visible = True
        pauseMainMenuButton.Visible = True
    End Sub
    Sub disablePauseMenu()
        paused = False
        pauseBackground.Enabled = False
        pausedLabel.Enabled = False
        pauseResumeButton.Enabled = False
        pauseMainMenuButton.Enabled = False
        pauseBackground.Visible = False
        pausedLabel.Visible = False
        pauseResumeButton.Visible = False
        pauseMainMenuButton.Visible = False
    End Sub
    Sub enableResultsMenu()
        results = True
        resultsBackground.Enabled = True
        resultWellDone.Enabled = True
        resultMainMenuButton.Enabled = True
        resultPlayAgainButton.Enabled = True
        resultsBackground.Visible = True
        resultWellDone.Visible = True
        resultMainMenuButton.Visible = True
        resultPlayAgainButton.Visible = True
        If p1PointsNum > p2PointsNum Then
            resultPlayer1.Enabled = True
            resultPlayer1.Visible = True
        Else
            resultPlayer2.Enabled = True
            resultPlayer2.Visible = True
        End If
    End Sub
    Sub disableResultsMenu()
        results = False
        resultsBackground.Enabled = False
        resultWellDone.Enabled = False
        resultMainMenuButton.Enabled = False
        resultPlayAgainButton.Enabled = False
        resultsBackground.Visible = False
        resultWellDone.Visible = False
        resultMainMenuButton.Visible = False
        resultPlayAgainButton.Visible = False
        If p1PointsNum > p2PointsNum Then
            resultPlayer1.Enabled = False
            resultPlayer1.Visible = False
        Else
            resultPlayer2.Enabled = False
            resultPlayer2.Visible = False
        End If
    End Sub
    Sub enableMainMenu()
        mainmenu = True
        menuBackground.Enabled = True
        menuPlayButton.Enabled = True
        menuTitle.Enabled = True
        menuBackground.Visible = True
        menuPlayButton.Visible = True
        menuTitle.Visible = True
    End Sub
    Sub disableMainMenu()
        mainmenu = False
        menuBackground.Enabled = False
        menuPlayButton.Enabled = False
        menuTitle.Enabled = False
        menuBackground.Visible = False
        menuPlayButton.Visible = False
        menuTitle.Visible = False
    End Sub


End Class
