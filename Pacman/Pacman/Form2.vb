Public Class frm2
    Friend WithEvents player _
    As New System.Media.SoundPlayer
    Dim trim As Integer
    Private Sub btn1_Click(sender As System.Object, e As System.EventArgs) Handles btn1.Click
        player.Stream = My.Resources.PacManIntroMusic
        player.Stop()
        frm1.Show()
        Me.MinimizeBox = True
    End Sub

    Private Sub btn2_Click(sender As System.Object, e As System.EventArgs) Handles btn2.Click
        MsgBox("Use the Arrow Keys to move Pacman around to collect the Pellets. Get them all while avoiding the ghosts. Fruit will appear at select time. While they suffle try to grab the right one. When you get all the pellets go to the End Gate. Through the End Gate you can earn more points and lives. The game increases in difficulty as you progress.")
    End Sub

    Private Sub btn3_Click(sender As System.Object, e As System.EventArgs) Handles btn3.Click
        Me.Close()
    End Sub

    Private Sub tmr1_Tick(sender As System.Object, e As System.EventArgs) Handles tmr1.Tick
        pic1.Left -= 7
        trim += 1
        If trim = 15 Then
            pic1.Image = My.Resources.pacmanclosed()
            trim = 0
        Else
            pic1.Image = My.Resources.pacman2
        End If
        If pic1.Bounds.IntersectsWith(pichide1.Bounds) Then
            pic1.Location = New Point(440, 12)
        End If
    End Sub
    Private Sub frm2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        player.Stream = My.Resources.PacManIntroMusic
        player.PlayLooping()
        DoubleBuffered = False
    End Sub

    Private Sub pic2_Click(sender As System.Object, e As System.EventArgs) Handles pic2.Click
        frm3.Show()
    End Sub
End Class