<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPoker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPoker))
        Me.lblID = New System.Windows.Forms.Label()
        Me.btnHold1 = New System.Windows.Forms.Button()
        Me.btnHold2 = New System.Windows.Forms.Button()
        Me.btnHold3 = New System.Windows.Forms.Button()
        Me.btnHold4 = New System.Windows.Forms.Button()
        Me.btnHold5 = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnDraw = New System.Windows.Forms.Button()
        Me.lblRules = New System.Windows.Forms.Label()
        Me.lblInstruct = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.picCard1 = New System.Windows.Forms.PictureBox()
        Me.picCard2 = New System.Windows.Forms.PictureBox()
        Me.picCard3 = New System.Windows.Forms.PictureBox()
        Me.picCard4 = New System.Windows.Forms.PictureBox()
        Me.picCard5 = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.lstOutScore = New System.Windows.Forms.ListBox()
        Me.lblOutScore = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        CType(Me.picCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCard2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCard3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCard4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCard5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(12, 9)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(164, 39)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "Mark D. Ingham and Kevin Kwok" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CS 115 - C" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Spring 2017"
        '
        'btnHold1
        '
        Me.btnHold1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnHold1.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHold1.Location = New System.Drawing.Point(77, 329)
        Me.btnHold1.Name = "btnHold1"
        Me.btnHold1.Size = New System.Drawing.Size(92, 35)
        Me.btnHold1.TabIndex = 2
        Me.btnHold1.Text = "Hold"
        Me.btnHold1.UseVisualStyleBackColor = True
        Me.btnHold1.Visible = False
        '
        'btnHold2
        '
        Me.btnHold2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnHold2.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHold2.Location = New System.Drawing.Point(198, 329)
        Me.btnHold2.Name = "btnHold2"
        Me.btnHold2.Size = New System.Drawing.Size(92, 35)
        Me.btnHold2.TabIndex = 3
        Me.btnHold2.Text = "Hold"
        Me.btnHold2.UseVisualStyleBackColor = True
        Me.btnHold2.Visible = False
        '
        'btnHold3
        '
        Me.btnHold3.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnHold3.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHold3.Location = New System.Drawing.Point(319, 329)
        Me.btnHold3.Name = "btnHold3"
        Me.btnHold3.Size = New System.Drawing.Size(92, 35)
        Me.btnHold3.TabIndex = 4
        Me.btnHold3.Text = "Hold"
        Me.btnHold3.UseVisualStyleBackColor = True
        Me.btnHold3.Visible = False
        '
        'btnHold4
        '
        Me.btnHold4.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnHold4.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHold4.Location = New System.Drawing.Point(440, 329)
        Me.btnHold4.Name = "btnHold4"
        Me.btnHold4.Size = New System.Drawing.Size(92, 35)
        Me.btnHold4.TabIndex = 5
        Me.btnHold4.Text = "Hold"
        Me.btnHold4.UseVisualStyleBackColor = True
        Me.btnHold4.Visible = False
        '
        'btnHold5
        '
        Me.btnHold5.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnHold5.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHold5.Location = New System.Drawing.Point(561, 329)
        Me.btnHold5.Name = "btnHold5"
        Me.btnHold5.Size = New System.Drawing.Size(92, 35)
        Me.btnHold5.TabIndex = 6
        Me.btnHold5.Text = "Hold"
        Me.btnHold5.UseVisualStyleBackColor = True
        Me.btnHold5.Visible = False
        '
        'btnStart
        '
        Me.btnStart.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(319, 384)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(92, 43)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start Game"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnDraw
        '
        Me.btnDraw.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDraw.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDraw.Location = New System.Drawing.Point(319, 385)
        Me.btnDraw.Name = "btnDraw"
        Me.btnDraw.Size = New System.Drawing.Size(92, 43)
        Me.btnDraw.TabIndex = 1
        Me.btnDraw.Text = "Draw"
        Me.btnDraw.UseVisualStyleBackColor = True
        Me.btnDraw.Visible = False
        '
        'lblRules
        '
        Me.lblRules.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRules.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRules.Location = New System.Drawing.Point(49, 73)
        Me.lblRules.Name = "lblRules"
        Me.lblRules.Size = New System.Drawing.Size(295, 124)
        Me.lblRules.TabIndex = 8
        Me.lblRules.Text = resources.GetString("lblRules.Text")
        '
        'lblInstruct
        '
        Me.lblInstruct.AutoSize = True
        Me.lblInstruct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblInstruct.Font = New System.Drawing.Font("Imprint MT Shadow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstruct.Location = New System.Drawing.Point(120, 46)
        Me.lblInstruct.Name = "lblInstruct"
        Me.lblInstruct.Size = New System.Drawing.Size(145, 27)
        Me.lblInstruct.TabIndex = 9
        Me.lblInstruct.Text = "Rules of Poker"
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResult.Font = New System.Drawing.Font("Imprint MT Shadow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(453, 46)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(100, 27)
        Me.lblResult.TabIndex = 10
        Me.lblResult.Text = "Results"
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picCard1
        '
        Me.picCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picCard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCard1.Location = New System.Drawing.Point(77, 213)
        Me.picCard1.Name = "picCard1"
        Me.picCard1.Size = New System.Drawing.Size(92, 110)
        Me.picCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCard1.TabIndex = 12
        Me.picCard1.TabStop = False
        Me.picCard1.Visible = False
        '
        'picCard2
        '
        Me.picCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picCard2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCard2.Location = New System.Drawing.Point(198, 213)
        Me.picCard2.Name = "picCard2"
        Me.picCard2.Size = New System.Drawing.Size(92, 110)
        Me.picCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCard2.TabIndex = 13
        Me.picCard2.TabStop = False
        Me.picCard2.Visible = False
        '
        'picCard3
        '
        Me.picCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picCard3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCard3.Location = New System.Drawing.Point(319, 213)
        Me.picCard3.Name = "picCard3"
        Me.picCard3.Size = New System.Drawing.Size(92, 110)
        Me.picCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCard3.TabIndex = 14
        Me.picCard3.TabStop = False
        Me.picCard3.Visible = False
        '
        'picCard4
        '
        Me.picCard4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picCard4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCard4.Location = New System.Drawing.Point(440, 213)
        Me.picCard4.Name = "picCard4"
        Me.picCard4.Size = New System.Drawing.Size(92, 110)
        Me.picCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCard4.TabIndex = 15
        Me.picCard4.TabStop = False
        Me.picCard4.Visible = False
        '
        'picCard5
        '
        Me.picCard5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picCard5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCard5.Location = New System.Drawing.Point(561, 213)
        Me.picCard5.Name = "picCard5"
        Me.picCard5.Size = New System.Drawing.Size(92, 110)
        Me.picCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCard5.TabIndex = 16
        Me.picCard5.TabStop = False
        Me.picCard5.Visible = False
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(561, 385)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(92, 43)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnRestart
        '
        Me.btnRestart.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnRestart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestart.Location = New System.Drawing.Point(319, 386)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(92, 43)
        Me.btnRestart.TabIndex = 7
        Me.btnRestart.Text = "Play Again"
        Me.btnRestart.UseVisualStyleBackColor = True
        Me.btnRestart.Visible = False
        '
        'lstOutScore
        '
        Me.lstOutScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOutScore.FormattingEnabled = True
        Me.lstOutScore.ItemHeight = 20
        Me.lstOutScore.Location = New System.Drawing.Point(384, 73)
        Me.lstOutScore.Name = "lstOutScore"
        Me.lstOutScore.Size = New System.Drawing.Size(238, 124)
        Me.lstOutScore.TabIndex = 17
        Me.lstOutScore.TabStop = False
        '
        'lblOutScore
        '
        Me.lblOutScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOutScore.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutScore.Location = New System.Drawing.Point(640, 73)
        Me.lblOutScore.Name = "lblOutScore"
        Me.lblOutScore.Size = New System.Drawing.Size(79, 124)
        Me.lblOutScore.TabIndex = 18
        Me.lblOutScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScore
        '
        Me.lblScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblScore.Font = New System.Drawing.Font("Imprint MT Shadow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(640, 21)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(79, 52)
        Me.lblScore.TabIndex = 19
        Me.lblScore.Text = "Total Score"
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmPoker
        '
        Me.AcceptButton = Me.btnStart
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(731, 440)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblOutScore)
        Me.Controls.Add(Me.lstOutScore)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.picCard5)
        Me.Controls.Add(Me.picCard4)
        Me.Controls.Add(Me.picCard3)
        Me.Controls.Add(Me.picCard2)
        Me.Controls.Add(Me.picCard1)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblInstruct)
        Me.Controls.Add(Me.lblRules)
        Me.Controls.Add(Me.btnDraw)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnHold5)
        Me.Controls.Add(Me.btnHold4)
        Me.Controls.Add(Me.btnHold3)
        Me.Controls.Add(Me.btnHold2)
        Me.Controls.Add(Me.btnHold1)
        Me.Controls.Add(Me.lblID)
        Me.Name = "frmPoker"
        Me.Text = "Poker Game"
        CType(Me.picCard1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCard2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCard3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCard4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCard5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblID As Label
    Friend WithEvents btnHold1 As Button
    Friend WithEvents btnHold2 As Button
    Friend WithEvents btnHold3 As Button
    Friend WithEvents btnHold4 As Button
    Friend WithEvents btnHold5 As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents btnDraw As Button
    Friend WithEvents lblRules As Label
    Friend WithEvents lblInstruct As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents picCard1 As PictureBox
    Friend WithEvents picCard2 As PictureBox
    Friend WithEvents picCard3 As PictureBox
    Friend WithEvents picCard4 As PictureBox
    Friend WithEvents picCard5 As PictureBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnRestart As Button
    Friend WithEvents lstOutScore As ListBox
    Friend WithEvents lblOutScore As Label
    Friend WithEvents lblScore As Label
End Class
