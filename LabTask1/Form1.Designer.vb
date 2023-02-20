<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogIn))
        Me.BXUsername = New System.Windows.Forms.TextBox()
        Me.BXPassword = New System.Windows.Forms.TextBox()
        Me.BTNLogin = New System.Windows.Forms.Button()
        Me.BTNSignup = New System.Windows.Forms.Button()
        Me.ApplicationTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BXUsername
        '
        Me.BXUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BXUsername.Location = New System.Drawing.Point(326, 202)
        Me.BXUsername.Multiline = True
        Me.BXUsername.Name = "BXUsername"
        Me.BXUsername.Size = New System.Drawing.Size(254, 32)
        Me.BXUsername.TabIndex = 0
        '
        'BXPassword
        '
        Me.BXPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BXPassword.Location = New System.Drawing.Point(325, 254)
        Me.BXPassword.Multiline = True
        Me.BXPassword.Name = "BXPassword"
        Me.BXPassword.Size = New System.Drawing.Size(254, 32)
        Me.BXPassword.TabIndex = 1
        '
        'BTNLogin
        '
        Me.BTNLogin.BackgroundImage = CType(resources.GetObject("BTNLogin.BackgroundImage"), System.Drawing.Image)
        Me.BTNLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BTNLogin.Location = New System.Drawing.Point(335, 324)
        Me.BTNLogin.Name = "BTNLogin"
        Me.BTNLogin.Size = New System.Drawing.Size(83, 33)
        Me.BTNLogin.TabIndex = 2
        Me.BTNLogin.Text = "Log In"
        Me.BTNLogin.UseVisualStyleBackColor = True
        '
        'BTNSignup
        '
        Me.BTNSignup.BackgroundImage = CType(resources.GetObject("BTNSignup.BackgroundImage"), System.Drawing.Image)
        Me.BTNSignup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNSignup.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BTNSignup.Location = New System.Drawing.Point(441, 324)
        Me.BTNSignup.Name = "BTNSignup"
        Me.BTNSignup.Size = New System.Drawing.Size(83, 33)
        Me.BTNSignup.TabIndex = 3
        Me.BTNSignup.Text = "Sign Up"
        Me.BTNSignup.UseVisualStyleBackColor = True
        '
        'ApplicationTitle
        '
        Me.ApplicationTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ApplicationTitle.BackColor = System.Drawing.Color.Transparent
        Me.ApplicationTitle.Font = New System.Drawing.Font("ROG Fonts", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ApplicationTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ApplicationTitle.Location = New System.Drawing.Point(198, -11)
        Me.ApplicationTitle.Name = "ApplicationTitle"
        Me.ApplicationTitle.Size = New System.Drawing.Size(490, 165)
        Me.ApplicationTitle.TabIndex = 4
        Me.ApplicationTitle.Text = "Tron Ride Duel"
        Me.ApplicationTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormLogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(842, 495)
        Me.Controls.Add(Me.ApplicationTitle)
        Me.Controls.Add(Me.BTNSignup)
        Me.Controls.Add(Me.BTNLogin)
        Me.Controls.Add(Me.BXPassword)
        Me.Controls.Add(Me.BXUsername)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormLogIn"
        Me.Text = "LOG IN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BXUsername As TextBox
    Friend WithEvents BXPassword As TextBox
    Friend WithEvents BTNLogin As Button
    Friend WithEvents BTNSignup As Button
    Friend WithEvents ApplicationTitle As Label
End Class
