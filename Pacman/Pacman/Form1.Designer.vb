<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm1))
        Me.tmrpac = New System.Windows.Forms.Timer(Me.components)
        Me.lbllvl1 = New System.Windows.Forms.Label()
        Me.lbllvl2 = New System.Windows.Forms.Label()
        Me.lblscore1 = New System.Windows.Forms.Label()
        Me.lblscore2 = New System.Windows.Forms.Label()
        Me.lbllife2 = New System.Windows.Forms.Label()
        Me.lbllife1 = New System.Windows.Forms.Label()
        Me.tmrchange = New System.Windows.Forms.Timer(Me.components)
        Me.tmrlife = New System.Windows.Forms.Timer(Me.components)
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lblstart = New System.Windows.Forms.Label()
        Me.tmrstart = New System.Windows.Forms.Timer(Me.components)
        Me.tmrcon = New System.Windows.Forms.Timer(Me.components)
        Me.lblgo = New System.Windows.Forms.Label()
        Me.tmrf = New System.Windows.Forms.Timer(Me.components)
        Me.tmrflash = New System.Windows.Forms.Timer(Me.components)
        Me.tmrduke = New System.Windows.Forms.Timer(Me.components)
        Me.tmrsub = New System.Windows.Forms.Timer(Me.components)
        Me.lblhs1 = New System.Windows.Forms.Label()
        Me.lblhs2 = New System.Windows.Forms.Label()
        Me.tmrhs = New System.Windows.Forms.Timer(Me.components)
        Me.picblinky = New System.Windows.Forms.PictureBox()
        Me.picinky = New System.Windows.Forms.PictureBox()
        Me.picpinky = New System.Windows.Forms.PictureBox()
        Me.picclyde = New System.Windows.Forms.PictureBox()
        Me.picpac = New System.Windows.Forms.PictureBox()
        Me.pichidden4 = New System.Windows.Forms.PictureBox()
        Me.pichidden3 = New System.Windows.Forms.PictureBox()
        Me.pichidden2 = New System.Windows.Forms.PictureBox()
        Me.pichidden1 = New System.Windows.Forms.PictureBox()
        Me.picend = New System.Windows.Forms.PictureBox()
        Me.picf = New System.Windows.Forms.PictureBox()
        Me.picduke = New System.Windows.Forms.PictureBox()
        Me.picpellet1 = New System.Windows.Forms.PictureBox()
        Me.picpellet3 = New System.Windows.Forms.PictureBox()
        Me.picpellet2 = New System.Windows.Forms.PictureBox()
        Me.picpellet4 = New System.Windows.Forms.PictureBox()
        Me.picpellet5 = New System.Windows.Forms.PictureBox()
        Me.picbar = New System.Windows.Forms.PictureBox()
        CType(Me.picblinky, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picinky, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picpinky, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picclyde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picpac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pichidden4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pichidden3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pichidden2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pichidden1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picend, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picduke, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picpellet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picpellet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picpellet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picpellet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picpellet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picbar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrpac
        '
        Me.tmrpac.Interval = 400
        '
        'lbllvl1
        '
        Me.lbllvl1.AutoSize = True
        Me.lbllvl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllvl1.ForeColor = System.Drawing.Color.White
        Me.lbllvl1.Location = New System.Drawing.Point(441, 23)
        Me.lbllvl1.Name = "lbllvl1"
        Me.lbllvl1.Size = New System.Drawing.Size(52, 18)
        Me.lbllvl1.TabIndex = 5
        Me.lbllvl1.Text = "Level:"
        '
        'lbllvl2
        '
        Me.lbllvl2.AutoSize = True
        Me.lbllvl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllvl2.ForeColor = System.Drawing.Color.White
        Me.lbllvl2.Location = New System.Drawing.Point(493, 23)
        Me.lbllvl2.Name = "lbllvl2"
        Me.lbllvl2.Size = New System.Drawing.Size(17, 18)
        Me.lbllvl2.TabIndex = 6
        Me.lbllvl2.Text = "1"
        '
        'lblscore1
        '
        Me.lblscore1.AutoSize = True
        Me.lblscore1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblscore1.ForeColor = System.Drawing.Color.White
        Me.lblscore1.Location = New System.Drawing.Point(516, 23)
        Me.lblscore1.Name = "lblscore1"
        Me.lblscore1.Size = New System.Drawing.Size(58, 18)
        Me.lblscore1.TabIndex = 7
        Me.lblscore1.Text = "Score:"
        '
        'lblscore2
        '
        Me.lblscore2.AutoSize = True
        Me.lblscore2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblscore2.ForeColor = System.Drawing.Color.White
        Me.lblscore2.Location = New System.Drawing.Point(574, 23)
        Me.lblscore2.Name = "lblscore2"
        Me.lblscore2.Size = New System.Drawing.Size(17, 18)
        Me.lblscore2.TabIndex = 8
        Me.lblscore2.Text = "0"
        '
        'lbllife2
        '
        Me.lbllife2.AutoSize = True
        Me.lbllife2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllife2.ForeColor = System.Drawing.Color.White
        Me.lbllife2.Location = New System.Drawing.Point(674, 23)
        Me.lbllife2.Name = "lbllife2"
        Me.lbllife2.Size = New System.Drawing.Size(17, 18)
        Me.lbllife2.TabIndex = 10
        Me.lbllife2.Text = "3"
        '
        'lbllife1
        '
        Me.lbllife1.AutoSize = True
        Me.lbllife1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllife1.ForeColor = System.Drawing.Color.White
        Me.lbllife1.Location = New System.Drawing.Point(622, 23)
        Me.lbllife1.Name = "lbllife1"
        Me.lbllife1.Size = New System.Drawing.Size(52, 18)
        Me.lbllife1.TabIndex = 9
        Me.lbllife1.Text = "Lives:"
        '
        'tmrchange
        '
        Me.tmrchange.Interval = 500
        '
        'tmrlife
        '
        Me.tmrlife.Interval = 500
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.BackColor = System.Drawing.Color.RoyalBlue
        Me.lbl1.Font = New System.Drawing.Font("Centaur", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.Black
        Me.lbl1.Location = New System.Drawing.Point(806, 523)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(42, 16)
        Me.lbl1.TabIndex = 21
        Me.lbl1.Text = "In Here"
        Me.lbl1.Visible = False
        '
        'lblstart
        '
        Me.lblstart.AutoSize = True
        Me.lblstart.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstart.ForeColor = System.Drawing.Color.Yellow
        Me.lblstart.Location = New System.Drawing.Point(12, 9)
        Me.lblstart.Name = "lblstart"
        Me.lblstart.Size = New System.Drawing.Size(31, 36)
        Me.lblstart.TabIndex = 22
        Me.lblstart.Text = "5"
        '
        'tmrstart
        '
        Me.tmrstart.Enabled = True
        Me.tmrstart.Interval = 1000
        '
        'tmrcon
        '
        Me.tmrcon.Enabled = True
        Me.tmrcon.Interval = 10
        '
        'lblgo
        '
        Me.lblgo.AutoSize = True
        Me.lblgo.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgo.ForeColor = System.Drawing.Color.Red
        Me.lblgo.Location = New System.Drawing.Point(162, 218)
        Me.lblgo.Name = "lblgo"
        Me.lblgo.Size = New System.Drawing.Size(549, 108)
        Me.lblgo.TabIndex = 23
        Me.lblgo.Text = "Game Over"
        Me.lblgo.Visible = False
        '
        'tmrf
        '
        '
        'tmrflash
        '
        Me.tmrflash.Interval = 50
        '
        'tmrduke
        '
        Me.tmrduke.Interval = 250
        '
        'tmrsub
        '
        Me.tmrsub.Interval = 1000
        '
        'lblhs1
        '
        Me.lblhs1.AutoSize = True
        Me.lblhs1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhs1.ForeColor = System.Drawing.Color.White
        Me.lblhs1.Location = New System.Drawing.Point(697, 23)
        Me.lblhs1.Name = "lblhs1"
        Me.lblhs1.Size = New System.Drawing.Size(90, 18)
        Me.lblhs1.TabIndex = 26
        Me.lblhs1.Text = "Highscore:"
        '
        'lblhs2
        '
        Me.lblhs2.AutoSize = True
        Me.lblhs2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhs2.ForeColor = System.Drawing.Color.White
        Me.lblhs2.Location = New System.Drawing.Point(787, 23)
        Me.lblhs2.Name = "lblhs2"
        Me.lblhs2.Size = New System.Drawing.Size(0, 18)
        Me.lblhs2.TabIndex = 27
        '
        'tmrhs
        '
        Me.tmrhs.Enabled = True
        '
        'picblinky
        '
        Me.picblinky.Image = Global.Pacman.My.Resources.Resources.blinky
        Me.picblinky.Location = New System.Drawing.Point(200, 60)
        Me.picblinky.Name = "picblinky"
        Me.picblinky.Size = New System.Drawing.Size(50, 50)
        Me.picblinky.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picblinky.TabIndex = 16
        Me.picblinky.TabStop = False
        '
        'picinky
        '
        Me.picinky.Image = Global.Pacman.My.Resources.Resources.inky
        Me.picinky.Location = New System.Drawing.Point(-20, 200)
        Me.picinky.Name = "picinky"
        Me.picinky.Size = New System.Drawing.Size(50, 50)
        Me.picinky.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picinky.TabIndex = 19
        Me.picinky.TabStop = False
        '
        'picpinky
        '
        Me.picpinky.Image = Global.Pacman.My.Resources.Resources.pinky
        Me.picpinky.Location = New System.Drawing.Point(300, 500)
        Me.picpinky.Name = "picpinky"
        Me.picpinky.Size = New System.Drawing.Size(50, 50)
        Me.picpinky.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picpinky.TabIndex = 18
        Me.picpinky.TabStop = False
        '
        'picclyde
        '
        Me.picclyde.Image = Global.Pacman.My.Resources.Resources.Clyde
        Me.picclyde.Location = New System.Drawing.Point(800, 300)
        Me.picclyde.Name = "picclyde"
        Me.picclyde.Size = New System.Drawing.Size(50, 50)
        Me.picclyde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picclyde.TabIndex = 17
        Me.picclyde.TabStop = False
        '
        'picpac
        '
        Me.picpac.BackColor = System.Drawing.Color.Transparent
        Me.picpac.Image = Global.Pacman.My.Resources.Resources.pacman0
        Me.picpac.Location = New System.Drawing.Point(50, 100)
        Me.picpac.Name = "picpac"
        Me.picpac.Size = New System.Drawing.Size(50, 50)
        Me.picpac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picpac.TabIndex = 0
        Me.picpac.TabStop = False
        '
        'pichidden4
        '
        Me.pichidden4.Location = New System.Drawing.Point(0, 555)
        Me.pichidden4.Name = "pichidden4"
        Me.pichidden4.Size = New System.Drawing.Size(840, 20)
        Me.pichidden4.TabIndex = 4
        Me.pichidden4.TabStop = False
        '
        'pichidden3
        '
        Me.pichidden3.Location = New System.Drawing.Point(0, -10)
        Me.pichidden3.Name = "pichidden3"
        Me.pichidden3.Size = New System.Drawing.Size(839, 10)
        Me.pichidden3.TabIndex = 3
        Me.pichidden3.TabStop = False
        '
        'pichidden2
        '
        Me.pichidden2.Location = New System.Drawing.Point(850, 0)
        Me.pichidden2.Name = "pichidden2"
        Me.pichidden2.Size = New System.Drawing.Size(10, 561)
        Me.pichidden2.TabIndex = 2
        Me.pichidden2.TabStop = False
        '
        'pichidden1
        '
        Me.pichidden1.Location = New System.Drawing.Point(-10, 0)
        Me.pichidden1.Name = "pichidden1"
        Me.pichidden1.Size = New System.Drawing.Size(10, 561)
        Me.pichidden1.TabIndex = 1
        Me.pichidden1.TabStop = False
        '
        'picend
        '
        Me.picend.BackColor = System.Drawing.Color.RoyalBlue
        Me.picend.Location = New System.Drawing.Point(800, 505)
        Me.picend.Name = "picend"
        Me.picend.Size = New System.Drawing.Size(50, 50)
        Me.picend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picend.TabIndex = 20
        Me.picend.TabStop = False
        Me.picend.Visible = False
        '
        'picf
        '
        Me.picf.Image = Global.Pacman.My.Resources.Resources.f1
        Me.picf.Location = New System.Drawing.Point(390, 361)
        Me.picf.Name = "picf"
        Me.picf.Size = New System.Drawing.Size(50, 50)
        Me.picf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picf.TabIndex = 24
        Me.picf.TabStop = False
        Me.picf.Visible = False
        '
        'picduke
        '
        Me.picduke.BackColor = System.Drawing.Color.Transparent
        Me.picduke.Image = Global.Pacman.My.Resources.Resources.duke
        Me.picduke.Location = New System.Drawing.Point(748, 66)
        Me.picduke.Name = "picduke"
        Me.picduke.Size = New System.Drawing.Size(100, 100)
        Me.picduke.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picduke.TabIndex = 25
        Me.picduke.TabStop = False
        Me.picduke.Visible = False
        '
        'picpellet1
        '
        Me.picpellet1.Image = Global.Pacman.My.Resources.Resources.pellet2
        Me.picpellet1.Location = New System.Drawing.Point(100, 154)
        Me.picpellet1.Name = "picpellet1"
        Me.picpellet1.Size = New System.Drawing.Size(25, 25)
        Me.picpellet1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picpellet1.TabIndex = 11
        Me.picpellet1.TabStop = False
        '
        'picpellet3
        '
        Me.picpellet3.Image = Global.Pacman.My.Resources.Resources.pellet2
        Me.picpellet3.Location = New System.Drawing.Point(100, 400)
        Me.picpellet3.Name = "picpellet3"
        Me.picpellet3.Size = New System.Drawing.Size(25, 25)
        Me.picpellet3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picpellet3.TabIndex = 13
        Me.picpellet3.TabStop = False
        '
        'picpellet2
        '
        Me.picpellet2.Image = Global.Pacman.My.Resources.Resources.pellet2
        Me.picpellet2.Location = New System.Drawing.Point(400, 250)
        Me.picpellet2.Name = "picpellet2"
        Me.picpellet2.Size = New System.Drawing.Size(25, 25)
        Me.picpellet2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picpellet2.TabIndex = 12
        Me.picpellet2.TabStop = False
        '
        'picpellet4
        '
        Me.picpellet4.Image = Global.Pacman.My.Resources.Resources.pellet2
        Me.picpellet4.Location = New System.Drawing.Point(700, 150)
        Me.picpellet4.Name = "picpellet4"
        Me.picpellet4.Size = New System.Drawing.Size(25, 29)
        Me.picpellet4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picpellet4.TabIndex = 14
        Me.picpellet4.TabStop = False
        '
        'picpellet5
        '
        Me.picpellet5.Image = Global.Pacman.My.Resources.Resources.pellet2
        Me.picpellet5.Location = New System.Drawing.Point(575, 500)
        Me.picpellet5.Name = "picpellet5"
        Me.picpellet5.Size = New System.Drawing.Size(25, 25)
        Me.picpellet5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picpellet5.TabIndex = 15
        Me.picpellet5.TabStop = False
        '
        'picbar
        '
        Me.picbar.BackColor = System.Drawing.Color.RoyalBlue
        Me.picbar.Location = New System.Drawing.Point(-7, 50)
        Me.picbar.Name = "picbar"
        Me.picbar.Size = New System.Drawing.Size(861, 10)
        Me.picbar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbar.TabIndex = 28
        Me.picbar.TabStop = False
        '
        'frm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(849, 552)
        Me.Controls.Add(Me.picduke)
        Me.Controls.Add(Me.picclyde)
        Me.Controls.Add(Me.picpinky)
        Me.Controls.Add(Me.picinky)
        Me.Controls.Add(Me.picblinky)
        Me.Controls.Add(Me.picbar)
        Me.Controls.Add(Me.lblstart)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.pichidden4)
        Me.Controls.Add(Me.pichidden3)
        Me.Controls.Add(Me.pichidden2)
        Me.Controls.Add(Me.pichidden1)
        Me.Controls.Add(Me.lbllife1)
        Me.Controls.Add(Me.lblscore1)
        Me.Controls.Add(Me.lbllvl1)
        Me.Controls.Add(Me.lbllife2)
        Me.Controls.Add(Me.lblscore2)
        Me.Controls.Add(Me.lbllvl2)
        Me.Controls.Add(Me.picend)
        Me.Controls.Add(Me.lblgo)
        Me.Controls.Add(Me.picpellet1)
        Me.Controls.Add(Me.picpellet3)
        Me.Controls.Add(Me.picpellet2)
        Me.Controls.Add(Me.picpellet4)
        Me.Controls.Add(Me.picpellet5)
        Me.Controls.Add(Me.lblhs1)
        Me.Controls.Add(Me.lblhs2)
        Me.Controls.Add(Me.picpac)
        Me.Controls.Add(Me.picf)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pacman"
        CType(Me.picblinky, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picinky, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picpinky, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picclyde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picpac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pichidden4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pichidden3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pichidden2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pichidden1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picend, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picduke, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picpellet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picpellet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picpellet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picpellet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picpellet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picbar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picpac As System.Windows.Forms.PictureBox
    Friend WithEvents tmrpac As System.Windows.Forms.Timer
    Friend WithEvents pichidden1 As System.Windows.Forms.PictureBox
    Friend WithEvents pichidden2 As System.Windows.Forms.PictureBox
    Friend WithEvents pichidden3 As System.Windows.Forms.PictureBox
    Friend WithEvents pichidden4 As System.Windows.Forms.PictureBox
    Friend WithEvents lbllvl1 As System.Windows.Forms.Label
    Friend WithEvents lbllvl2 As System.Windows.Forms.Label
    Friend WithEvents lblscore1 As System.Windows.Forms.Label
    Friend WithEvents lblscore2 As System.Windows.Forms.Label
    Friend WithEvents lbllife2 As System.Windows.Forms.Label
    Friend WithEvents lbllife1 As System.Windows.Forms.Label
    Friend WithEvents picpellet1 As System.Windows.Forms.PictureBox
    Friend WithEvents picpellet2 As System.Windows.Forms.PictureBox
    Friend WithEvents picpellet3 As System.Windows.Forms.PictureBox
    Friend WithEvents picpellet4 As System.Windows.Forms.PictureBox
    Friend WithEvents picpellet5 As System.Windows.Forms.PictureBox
    Friend WithEvents picblinky As System.Windows.Forms.PictureBox
    Friend WithEvents tmrchange As System.Windows.Forms.Timer
    Friend WithEvents picclyde As System.Windows.Forms.PictureBox
    Friend WithEvents picpinky As System.Windows.Forms.PictureBox
    Friend WithEvents picinky As System.Windows.Forms.PictureBox
    Friend WithEvents picend As System.Windows.Forms.PictureBox
    Friend WithEvents tmrlife As System.Windows.Forms.Timer
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lblstart As System.Windows.Forms.Label
    Friend WithEvents tmrstart As System.Windows.Forms.Timer
    Friend WithEvents tmrcon As System.Windows.Forms.Timer
    Friend WithEvents lblgo As System.Windows.Forms.Label
    Friend WithEvents picf As System.Windows.Forms.PictureBox
    Friend WithEvents tmrf As System.Windows.Forms.Timer
    Friend WithEvents tmrflash As System.Windows.Forms.Timer
    Friend WithEvents picduke As System.Windows.Forms.PictureBox
    Friend WithEvents tmrduke As System.Windows.Forms.Timer
    Friend WithEvents tmrsub As System.Windows.Forms.Timer
    Friend WithEvents lblhs1 As System.Windows.Forms.Label
    Friend WithEvents lblhs2 As System.Windows.Forms.Label
    Friend WithEvents tmrhs As System.Windows.Forms.Timer
    Friend WithEvents picbar As System.Windows.Forms.PictureBox

End Class
