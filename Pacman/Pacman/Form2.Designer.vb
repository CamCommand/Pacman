<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm2))
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.tmr1 = New System.Windows.Forms.Timer(Me.components)
        Me.pichide1 = New System.Windows.Forms.PictureBox()
        Me.pic2 = New System.Windows.Forms.PictureBox()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        CType(Me.pichide1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.BackColor = System.Drawing.Color.Black
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.Yellow
        Me.lbl1.Location = New System.Drawing.Point(14, 29)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(461, 108)
        Me.lbl1.TabIndex = 0
        Me.lbl1.Text = "PACMAN"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.BackColor = System.Drawing.Color.Black
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.Yellow
        Me.lbl2.Location = New System.Drawing.Point(13, 141)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(346, 33)
        Me.lbl2.TabIndex = 1
        Me.lbl2.Text = "by Cameron Drummond"
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.Color.Black
        Me.btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.ForeColor = System.Drawing.Color.Yellow
        Me.btn1.Location = New System.Drawing.Point(285, 214)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(137, 56)
        Me.btn1.TabIndex = 2
        Me.btn1.Text = "Start"
        Me.btn1.UseVisualStyleBackColor = False
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.Color.Black
        Me.btn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.ForeColor = System.Drawing.Color.Yellow
        Me.btn2.Location = New System.Drawing.Point(32, 201)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(176, 82)
        Me.btn2.TabIndex = 3
        Me.btn2.Text = "How To Play"
        Me.btn2.UseVisualStyleBackColor = False
        '
        'btn3
        '
        Me.btn3.BackColor = System.Drawing.Color.Black
        Me.btn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.ForeColor = System.Drawing.Color.Yellow
        Me.btn3.Location = New System.Drawing.Point(152, 298)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(184, 69)
        Me.btn3.TabIndex = 4
        Me.btn3.Text = "End Game"
        Me.btn3.UseVisualStyleBackColor = False
        '
        'tmr1
        '
        Me.tmr1.Enabled = True
        Me.tmr1.Interval = 25
        '
        'pichide1
        '
        Me.pichide1.Location = New System.Drawing.Point(-10, 0)
        Me.pichide1.Name = "pichide1"
        Me.pichide1.Size = New System.Drawing.Size(10, 63)
        Me.pichide1.TabIndex = 7
        Me.pichide1.TabStop = False
        '
        'pic2
        '
        Me.pic2.Image = Global.Pacman.My.Resources.Resources.f3
        Me.pic2.Location = New System.Drawing.Point(32, 324)
        Me.pic2.Name = "pic2"
        Me.pic2.Size = New System.Drawing.Size(53, 43)
        Me.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic2.TabIndex = 6
        Me.pic2.TabStop = False
        '
        'pic1
        '
        Me.pic1.Image = Global.Pacman.My.Resources.Resources.pacman2
        Me.pic1.Location = New System.Drawing.Point(440, 12)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(35, 30)
        Me.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic1.TabIndex = 5
        Me.pic1.TabStop = False
        '
        'frm2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(487, 390)
        Me.Controls.Add(Me.pichide1)
        Me.Controls.Add(Me.pic2)
        Me.Controls.Add(Me.pic1)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Opening"
        CType(Me.pichide1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents pic1 As System.Windows.Forms.PictureBox
    Friend WithEvents pic2 As System.Windows.Forms.PictureBox
    Friend WithEvents pichide1 As System.Windows.Forms.PictureBox
    Friend WithEvents tmr1 As System.Windows.Forms.Timer
End Class
