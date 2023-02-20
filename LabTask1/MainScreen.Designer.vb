<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainScreen))
        Me.GameScreen = New System.Windows.Forms.PictureBox()
        Me.AboutBTN = New System.Windows.Forms.Button()
        Me.BTNStart = New System.Windows.Forms.Button()
        Me.BTNPause = New System.Windows.Forms.Button()
        Me.BTNSetting = New System.Windows.Forms.Button()
        Me.BTNLeft = New System.Windows.Forms.Button()
        Me.BTNRight = New System.Windows.Forms.Button()
        CType(Me.GameScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GameScreen
        '
        Me.GameScreen.BackgroundImage = CType(resources.GetObject("GameScreen.BackgroundImage"), System.Drawing.Image)
        Me.GameScreen.Location = New System.Drawing.Point(184, 12)
        Me.GameScreen.Name = "GameScreen"
        Me.GameScreen.Size = New System.Drawing.Size(432, 426)
        Me.GameScreen.TabIndex = 0
        Me.GameScreen.TabStop = False
        '
        'AboutBTN
        '
        Me.AboutBTN.BackgroundImage = CType(resources.GetObject("AboutBTN.BackgroundImage"), System.Drawing.Image)
        Me.AboutBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AboutBTN.Location = New System.Drawing.Point(12, 12)
        Me.AboutBTN.Name = "AboutBTN"
        Me.AboutBTN.Size = New System.Drawing.Size(146, 34)
        Me.AboutBTN.TabIndex = 1
        Me.AboutBTN.Text = "About"
        Me.AboutBTN.UseVisualStyleBackColor = True
        '
        'BTNStart
        '
        Me.BTNStart.Image = CType(resources.GetObject("BTNStart.Image"), System.Drawing.Image)
        Me.BTNStart.Location = New System.Drawing.Point(633, 80)
        Me.BTNStart.Name = "BTNStart"
        Me.BTNStart.Size = New System.Drawing.Size(155, 55)
        Me.BTNStart.TabIndex = 2
        Me.BTNStart.UseVisualStyleBackColor = True
        '
        'BTNPause
        '
        Me.BTNPause.Location = New System.Drawing.Point(633, 141)
        Me.BTNPause.Name = "BTNPause"
        Me.BTNPause.Size = New System.Drawing.Size(155, 23)
        Me.BTNPause.TabIndex = 3
        Me.BTNPause.Text = "PAUSE"
        Me.BTNPause.UseVisualStyleBackColor = True
        '
        'BTNSetting
        '
        Me.BTNSetting.Location = New System.Drawing.Point(633, 12)
        Me.BTNSetting.Name = "BTNSetting"
        Me.BTNSetting.Size = New System.Drawing.Size(155, 23)
        Me.BTNSetting.TabIndex = 4
        Me.BTNSetting.Text = "Setting"
        Me.BTNSetting.UseVisualStyleBackColor = True
        '
        'BTNLeft
        '
        Me.BTNLeft.BackgroundImage = CType(resources.GetObject("BTNLeft.BackgroundImage"), System.Drawing.Image)
        Me.BTNLeft.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTNLeft.Location = New System.Drawing.Point(633, 233)
        Me.BTNLeft.Name = "BTNLeft"
        Me.BTNLeft.Size = New System.Drawing.Size(71, 90)
        Me.BTNLeft.TabIndex = 5
        Me.BTNLeft.Text = "Left"
        Me.BTNLeft.UseVisualStyleBackColor = True
        '
        'BTNRight
        '
        Me.BTNRight.BackgroundImage = CType(resources.GetObject("BTNRight.BackgroundImage"), System.Drawing.Image)
        Me.BTNRight.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTNRight.Location = New System.Drawing.Point(717, 233)
        Me.BTNRight.Name = "BTNRight"
        Me.BTNRight.Size = New System.Drawing.Size(71, 90)
        Me.BTNRight.TabIndex = 6
        Me.BTNRight.Text = "Right"
        Me.BTNRight.UseVisualStyleBackColor = True
        '
        'MainScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BTNRight)
        Me.Controls.Add(Me.BTNLeft)
        Me.Controls.Add(Me.BTNSetting)
        Me.Controls.Add(Me.BTNPause)
        Me.Controls.Add(Me.BTNStart)
        Me.Controls.Add(Me.AboutBTN)
        Me.Controls.Add(Me.GameScreen)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainScreen"
        Me.Text = "Playroom"
        CType(Me.GameScreen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GameScreen As PictureBox
    Friend WithEvents AboutBTN As Button
    Friend WithEvents BTNStart As Button
    Friend WithEvents BTNPause As Button
    Friend WithEvents BTNSetting As Button
    Friend WithEvents BTNLeft As Button
    Friend WithEvents BTNRight As Button
End Class
