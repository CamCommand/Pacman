Public Class frm1
    'for hs
    Dim i As Integer = 0
    Friend WithEvents player _
   As New System.Media.SoundPlayer
    Friend WithEvents player2 _
  As New System.Media.SoundPlayer
    Dim myHS As String = "HSpac.txt"
    'pellets
    Dim p1 As Integer
    Dim p2 As Integer
    Dim p3 As Integer
    Dim p4 As Integer
    Dim p5 As Integer
    Dim lop As Integer
    'for the fruit
    Dim fruit As Integer
    Dim pic1 As Integer
    'falsh end
    Dim flash As Integer = 0
    'duke move
    Dim duke As Integer
    Dim fruitnum As Integer = 0
    Private Sub hit()
        player.Stream = My.Resources.PacManDeath
        player.Play()
        tmrlife.Enabled = True
        tmrstart.Enabled = True
        tmrpac.Enabled = False
        tmrchange.Enabled = False
        lblstart.Visible = True
        picpac.Location = New Point(50, 100)
        picpac.Image = My.Resources.pacman0
        lbllife2.Text = lbllife2.Text - 1
        lbllife1.BackColor = Color.Red
        lbllife2.BackColor = Color.Red
        lbllvl1.BackColor = Color.Red
        lbllvl2.BackColor = Color.Red
        lblscore1.BackColor = Color.Red
        lblscore2.BackColor = Color.Red
        lblhs1.BackColor = Color.Red
        lblhs2.BackColor = Color.Red
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If lblstart.Visible = False Then
            If e.KeyCode = Keys.Up Then
                picpac.Image = My.Resources.pacman3
                If picpac.Top <> 50 Then
                    picpac.Top -= 50
                End If
            End If
            If e.KeyCode = Keys.Down Then
                picpac.Image = My.Resources.pacman1
                If picpac.Top <> 500 Then
                    picpac.Top += 50
                End If
            End If
            If e.KeyCode = Keys.Right Then
                picpac.Image = My.Resources.pacman0
                If picpac.Left <> 800 Then
                    picpac.Left += 50
                End If
            End If
            If e.KeyCode = Keys.Left Then
                picpac.Image = My.Resources.pacman2
                If picpac.Left <> 0 Then
                    picpac.Left -= 50
                End If
            End If
            If picpac.Bounds.IntersectsWith(lbllvl1.Bounds) Or picpac.Bounds.IntersectsWith(lbllvl2.Bounds) Or picpac.Bounds.IntersectsWith(lblscore1.Bounds) Or picpac.Bounds.IntersectsWith(lblscore2.Bounds) Or picpac.Bounds.IntersectsWith(lbllife1.Bounds) Or picpac.Bounds.IntersectsWith(lbllife2.Bounds) Or picpac.Bounds.IntersectsWith(lblhs1.Bounds) Or picpac.Bounds.IntersectsWith(lblhs2.Bounds) Then
                tmrsub.Enabled = True
            End If
            If picpac.Bounds.IntersectsWith(picf.Bounds) And picf.Visible = True Then
                picf.Visible = False
                lblscore2.Text += 50
                tmrf.Enabled = True
            End If
            If picpac.Bounds.IntersectsWith(picpellet1.Bounds) And picpellet1.Visible = True Then
                player.Stream = My.Resources.PacManMunch
                player.Play()
                picpellet1.Visible = False
                lblscore2.Text = lblscore2.Text + 10
            End If
            If picpac.Bounds.IntersectsWith(picpellet2.Bounds) And picpellet2.Visible = True Then
                player.Stream = My.Resources.PacManMunch
                player.Play()
                picpellet2.Visible = False
                lblscore2.Text = lblscore2.Text + 10
            End If
            If picpac.Bounds.IntersectsWith(picpellet3.Bounds) And picpellet3.Visible = True Then
                player.Stream = My.Resources.PacManMunch
                player.Play()
                picpellet3.Visible = False
                lblscore2.Text = lblscore2.Text + 10
            End If
            If picpac.Bounds.IntersectsWith(picpellet4.Bounds) And picpellet4.Visible = True Then
                player.Stream = My.Resources.PacManMunch
                player.Play()
                picpellet4.Visible = False
                lblscore2.Text = lblscore2.Text + 10
            End If
            If picpac.Bounds.IntersectsWith(picpellet5.Bounds) And picpellet5.Visible = True Then
                player.Stream = My.Resources.PacManMunch
                player.Play()
                picpellet5.Visible = False
                lblscore2.Text = lblscore2.Text + 10
            End If
            If picpellet1.Visible = False And picpellet2.Visible = False And picpellet3.Visible = False And picpellet4.Visible = False And picpellet5.Visible = False And picend.Visible = False Then
                tmrflash.Enabled = True
                picend.Visible = True
                lbl1.Visible = True 'here cameron
            End If
            If picpac.Bounds.IntersectsWith(picend.Bounds) And picend.Visible = True Then
                tmrduke.Enabled = False
                tmrflash.Enabled = False
                tmrstart.Enabled = True
                tmrpac.Enabled = False
                tmrchange.Enabled = False
                lblstart.Visible = True
                lbllvl2.Text = lbllvl2.Text + 1
                lblscore2.Text = lblscore2.Text + 50
                picpac.Location = New Point(50, 100)
                picpac.Image = My.Resources.pacman0
                picf.Visible = False
                picend.Visible = False
                lbl1.Visible = False
                picpellet1.Visible = True
                picpellet2.Visible = True
                picpellet3.Visible = True
                picpellet4.Visible = True
                picpellet5.Visible = True
                picinky.Location = New Point(0, 182)
                picpinky.Location = New Point(300, 500)
                picclyde.Location = New Point(775, 300)
                picblinky.Location = New Point(200, 60)
                picduke.Location = New Point(748, 66)
                tmrpac.Interval = tmrpac.Interval - 50
                If lblscore2.Text = 450 Then
                    player2.Stream = My.Resources.PacManExtraMan
                    player2.Play()
                    lbllife2.Text = lbllife2.Text + 1
                    tmrduke.Interval = tmrduke.Interval - 50
                End If
                If lblscore2.Text = 750 Then
                    player2.Stream = My.Resources.PacManExtraMan
                    player2.Play()
                    lbllife2.Text = lbllife2.Text + 1
                    tmrduke.Interval = tmrduke.Interval - 50
                End If
                If lblscore2.Text = 1000 Then
                    player2.Stream = My.Resources.PacManExtraMan
                    player2.Play()
                    lbllife2.Text = lbllife2.Text + 1
                    tmrduke.Interval = tmrduke.Interval - 50
                End If
                'when done change to 3
                If lbllvl2.Text >= 3 Then
                    tmrduke.Enabled = True
                End If
                If tmrstart.Enabled = True And lblstart.Text = 5 Then
                    player.Stream = My.Resources.PacManIntermission
                    player.Play()
                End If
            End If
            If picpac.Bounds.IntersectsWith(picinky.Bounds) Then
                Call hit()
            End If
            If picpac.Bounds.IntersectsWith(picpinky.Bounds) Then
              Call hit()
            End If
            If picpac.Bounds.IntersectsWith(picblinky.Bounds) Then
              Call hit()
            End If
            If picpac.Bounds.IntersectsWith(picclyde.Bounds) Then
               Call hit()
            End If
            If picduke.Bounds.IntersectsWith(picpac.Bounds) And picduke.Visible = True Then
                Call hit()
            End If
        End If
        If picpac.Bounds.IntersectsWith(picf.Bounds) And picf.Visible = True Then
            player2.Stream = My.Resources.PacManEatingFruit
            player2.Play()
        End If
    End Sub
    Private Sub tmrpac_Tick(sender As System.Object, e As System.EventArgs) Handles tmrpac.Tick
        picblinky.Top += 50
        picclyde.Left -= 75
        picpinky.Top -= 50
        picinky.Left += 25
        If picinky.Bounds.IntersectsWith(pichidden2.Bounds) Then
            picinky.Location = New Point(0, 182)
        End If
        If picinky.Bounds.IntersectsWith(picpac.Bounds) Then
        Call hit()
        End If
        If picpinky.Bounds.IntersectsWith(picbar.Bounds) Then
            picpinky.Location = New Point(300, 500)
        End If
        If picpinky.Bounds.IntersectsWith(picpac.Bounds) Then
         Call hit()
        End If
        If picclyde.Bounds.IntersectsWith(pichidden1.Bounds) Then
            picclyde.Location = New Point(775, 300)
        End If
        If picclyde.Bounds.IntersectsWith(picpac.Bounds) Then
           Call hit()
        End If
        If picblinky.Bounds.IntersectsWith(pichidden4.Bounds) Then
            picblinky.Location = New Point(200, 60)
        End If
        If picblinky.Bounds.IntersectsWith(picpac.Bounds) Then
           Call hit()
        End If
        If picduke.Bounds.IntersectsWith(picpac.Bounds) And picduke.Visible = True Then
           Call hit()
        End If
    End Sub

    Private Sub tmrchange_Tick(sender As System.Object, e As System.EventArgs) Handles tmrchange.Tick
        If picpellet1.Visible = True Then
            picpellet1.Image = My.Resources.pellet32
            p1 += 1
            If p1 >= 2 Then
                picpellet1.Image = My.Resources.pellet2
                p1 = 0
            End If
        End If
        If picpellet2.Visible = True Then
            picpellet2.Image = My.Resources.pellet32
            p2 += 1
            If p2 >= 2 Then
                picpellet2.Image = My.Resources.pellet2
                p2 = 0
            End If
        End If
        If picpellet3.Visible = True Then
            picpellet3.Image = My.Resources.pellet32
            p3 += 1
            If p3 >= 2 Then
                picpellet3.Image = My.Resources.pellet2
                p3 = 0
            End If
        End If
        If picpellet4.Visible = True Then
            picpellet4.Image = My.Resources.pellet32
            p4 += 1
            If p4 >= 2 Then
                picpellet4.Image = My.Resources.pellet2
                p4 = 0
            End If
        End If
        If picpellet5.Visible = True Then
            picpellet5.Image = My.Resources.pellet32
            p5 += 1
            If p5 >= 2 Then
                picpellet5.Image = My.Resources.pellet2
                p5 = 0
            End If
        End If
    End Sub

    Private Sub tmrlife_Tick(sender As System.Object, e As System.EventArgs) Handles tmrlife.Tick
        lop += 1
        If lop = 1 Then
            tmrlife.Enabled = False
            lbllife1.BackColor = Color.Black
            lbllife2.BackColor = Color.Black
            lbllvl1.BackColor = Color.Black
            lbllvl2.BackColor = Color.Black
            lblscore1.BackColor = Color.Black
            lblscore2.BackColor = Color.Black
            lblhs1.BackColor = Color.Black
            lblhs2.BackColor = Color.Black
            lop = 0
        End If
    End Sub

    Private Sub tmrstart_Tick(sender As System.Object, e As System.EventArgs) Handles tmrstart.Tick
        lblstart.Text -= 1
        If lblstart.Text = 0 Then
            tmrchange.Enabled = True
            tmrf.Enabled = True
            tmrlife.Enabled = True
            tmrpac.Enabled = True
            tmrstart.Enabled = False
            lblstart.Visible = False
            lblstart.Text = 5
        End If
    End Sub

    Private Sub tmrcon_Tick(sender As System.Object, e As System.EventArgs) Handles tmrcon.Tick
        If lbllife2.Text = 0 Then
            lblgo.Visible = True
            picduke.Visible = False
            tmrduke.Enabled = False
            picpac.Visible = False
            tmrf.Enabled = False
            picblinky.Visible = False
            picclyde.Visible = False
            lblstart.Visible = False
            picinky.Visible = False
            picpinky.Visible = False
            picpellet1.Visible = False
            picpellet2.Visible = False
            picpellet3.Visible = False
            picpellet4.Visible = False
            picpellet5.Visible = False
            lbl1.Visible = False
            picf.Visible = False
            lbllvl1.Visible = False
            lbllvl2.Visible = False
            lbllife1.Visible = False
            lbllife2.Visible = False
            lblscore1.Visible = False
            lblscore2.Visible = False
            lbllife1.Visible = False
            lbllife2.Visible = False
            tmrcon.Enabled = False
            tmrlife.Enabled = False
            tmrpac.Enabled = False
            tmrchange.Enabled = False
            tmrlife.Enabled = False
            lblhs1.Visible = False
            lblhs2.Visible = False
            MsgBox("Game Over, your score is " & lblscore2.Text & ", and you got to Level " & lbllvl2.Text)
            If Val(lblhs2.Text) < Val(lblscore2.Text) Then
                If My.Computer.FileSystem.FileExists(myHS) Then
                    My.Computer.FileSystem.DeleteFile(myHS)
                End If
                My.Computer.FileSystem.WriteAllText( _
                    myHS, lblscore2.Text & vbCrLf, True)
                MsgBox("You beat the high score!")
            End If

            Me.Close()
        End If
    End Sub
    Private Sub fruit2()
        'call
        Randomize()
        pic1 = ((4 * Rnd()) + 1)
        If pic1 = 1 Then
            picf.Image = My.Resources.f1
            picf.Visible = True
            pic1 = 0
            If picpac.Bounds.IntersectsWith(picf.Bounds) And picf.Visible = True Then
                fruitnum += 1
                picf.Visible = False
                lblscore2.Text += 10
                tmrf.Enabled = True
            End If
        End If
        If pic1 = 2 Then
            picf.Image = My.Resources.f2
            picf.Visible = True
            pic1 = 0
            If picpac.Bounds.IntersectsWith(picf.Bounds) And picf.Visible = True Then
                fruitnum += 1
                picf.Visible = False
                lblscore2.Text += 20
                tmrf.Enabled = True
            End If
        End If
        If pic1 = 3 Then
            picf.Image = My.Resources.f3
            picf.Visible = True
            pic1 = 0
            If picpac.Bounds.IntersectsWith(picf.Bounds) And picf.Visible = True Then
                fruitnum += 1
                picf.Visible = False
                lblscore2.Text += 40
                tmrf.Enabled = True
            End If
        End If
        If pic1 = 4 Then
            picf.Image = My.Resources.f4
            picf.Visible = True
            pic1 = 0
            If picpac.Bounds.IntersectsWith(picf.Bounds) And picf.Visible = True Then
                fruitnum += 1
                picf.Visible = False
                lblscore2.Text += 50
                tmrf.Enabled = True
            End If
        End If
    End Sub
    Private Sub tmrf_Tick(sender As System.Object, e As System.EventArgs) Handles tmrf.Tick
        If lblscore2.Text = 210 Or lblscore2.Text = 212 Or lblscore2.Text = 214 Or lblscore2.Text = 216 Or lblscore2.Text = 218 Or lblscore2.Text = 208 Then
            Call fruit2()
        End If
        If lblscore2.Text = 470 Or lblscore2.Text = 472 Or lblscore2.Text = 474 Or lblscore2.Text = 476 Or lblscore2.Text = 478 Or lblscore2.Text = 468 Then
            Call fruit2()
        End If
        If lblscore2.Text = 1000 Or lblscore2.Text = 1002 Or lblscore2.Text = 1004 Or lblscore2.Text = 1006 Or lblscore2.Text = 1008 Or lblscore2.Text = 998 Then
            Call fruit2()
        End If
    End Sub
    Private Sub tmrflash_Tick(sender As System.Object, e As System.EventArgs) Handles tmrflash.Tick
        flash += 1
        If flash = 1 Then
            lbl1.ForeColor = Color.Red
            If lblscore2.Text >= 1000 Then
                lbllife1.BackColor = Color.Red
                lbllife2.BackColor = Color.Red
                lbllvl1.BackColor = Color.Red
                lbllvl2.BackColor = Color.Red
                lblscore1.BackColor = Color.Red
                lblscore2.BackColor = Color.Red
            End If
        End If
        If flash = 2 Then
            lbl1.ForeColor = Color.Blue
            If lblscore2.Text >= 1000 Then
                lbllife1.BackColor = Color.Blue
                lbllife2.BackColor = Color.Blue
                lbllvl1.BackColor = Color.Blue
                lbllvl2.BackColor = Color.Blue
                lblscore1.BackColor = Color.Blue
                lblscore2.BackColor = Color.Blue
            End If
        End If
        If flash = 3 Then
            lbl1.ForeColor = Color.Yellow
            If lblscore2.Text >= 1000 Then
                lbllife1.BackColor = Color.Yellow
                lbllife2.BackColor = Color.Yellow
                lbllvl1.BackColor = Color.Yellow
                lbllvl2.BackColor = Color.Yellow
                lblscore1.BackColor = Color.Yellow
                lblscore2.BackColor = Color.Yellow
            End If
        End If
        If flash = 4 Then
            lbl1.ForeColor = Color.Green
            If lblscore2.Text >= 1000 Then
                lbllife1.BackColor = Color.Green
                lbllife2.BackColor = Color.Green
                lbllvl1.BackColor = Color.Green
                lbllvl2.BackColor = Color.Green
                lblscore1.BackColor = Color.Green
                lblscore2.BackColor = Color.Green
            End If
            flash = 0
        End If
    End Sub

    Private Sub tmrduke_Tick(sender As System.Object, e As System.EventArgs) Handles tmrduke.Tick
        'tiss good boi all of it _

        If lblstart.Visible = False Then
            picduke.Visible = True
            If picpac.Left < picduke.Left And picpac.Top < picduke.Top Then
                picduke.Left -= 5
                picduke.Top -= 5
            End If
            If picpac.Left < picduke.Left And picpac.Top > picduke.Top Then
                picduke.Left -= 5
                picduke.Top += 5
            End If
            If picpac.Left > picduke.Left And picpac.Top < picduke.Top Then
                picduke.Left += 5
                picduke.Top -= 5
            End If
            If picpac.Left > picduke.Left And picpac.Top > picduke.Top Then
                picduke.Left += 5
                picduke.Top += 5
            End If
            If picpac.Left = picduke.Left Then
                picduke.Left -= 5
            End If
            If picpac.Left = picduke.Left Then
                picduke.Left += 5
            End If
            If picpac.Top = picduke.Top Then
                picduke.Top -= 5
            End If
            If picpac.Top = picduke.Top Then
                picduke.Top += 5
            End If
        End If
    End Sub

    Private Sub tmrsub_Tick(sender As System.Object, e As System.EventArgs) Handles tmrsub.Tick
        If lblscore2.Text >= 2 Then
            lblscore2.Text -= 2
            tmrsub.Enabled = False
        End If
    End Sub

    Private Sub frm1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If tmrstart.Enabled = True And lblstart.Text = 5 Then
            player.Stream = My.Resources.PacManIntermission
            player.Play()
        End If
        Try
            lblhs2.Text = _
                My.Computer.FileSystem.ReadAllText(myHS)
        Catch ex As Exception
            lblhs2.Text = "0"
        End Try
    End Sub

    Private Sub tmrhs_Tick(sender As System.Object, e As System.EventArgs) Handles tmrhs.Tick
        i += 1
        If i = 1 Then
            lblhs2.ForeColor = Color.Blue
        End If
        If i = 2 Then
            lblhs2.ForeColor = Color.Yellow
        End If
        If i = 3 Then
            lblhs2.ForeColor = Color.Red
        End If
        If i = 4 Then
            lblhs2.ForeColor = Color.Green
        End If
        If i = 5 Then
            lblhs2.ForeColor = Color.White
            i = 0
        End If
    End Sub
End Class
