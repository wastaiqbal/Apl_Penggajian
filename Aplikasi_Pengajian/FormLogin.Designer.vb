<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblNIP = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMasuk = New System.Windows.Forms.Button()
        Me.lblLink = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.BackColor = System.Drawing.Color.Transparent
        Me.lblLogin.Font = New System.Drawing.Font("Century Gothic", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblLogin.Location = New System.Drawing.Point(292, 56)
        Me.lblLogin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(162, 55)
        Me.lblLogin.TabIndex = 33
        Me.lblLogin.Text = "LOGIN"
        '
        'txtUsername
        '
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(360, 135)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtUsername.Multiline = True
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(172, 35)
        Me.txtUsername.TabIndex = 36
        '
        'lblNIP
        '
        Me.lblNIP.AutoSize = True
        Me.lblNIP.BackColor = System.Drawing.Color.Transparent
        Me.lblNIP.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNIP.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblNIP.Location = New System.Drawing.Point(224, 135)
        Me.lblNIP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNIP.Name = "lblNIP"
        Me.lblNIP.Padding = New System.Windows.Forms.Padding(4)
        Me.lblNIP.Size = New System.Drawing.Size(117, 32)
        Me.lblNIP.TabIndex = 35
        Me.lblNIP.Text = "Username"
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(360, 182)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(172, 36)
        Me.txtPassword.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(226, 182)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(4)
        Me.Label1.Size = New System.Drawing.Size(114, 32)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Password"
        '
        'btnMasuk
        '
        Me.btnMasuk.BackgroundImage = Global.Aplikasi_Pengajian.My.Resources.Resources.images__5_
        Me.btnMasuk.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMasuk.ForeColor = System.Drawing.Color.White
        Me.btnMasuk.Location = New System.Drawing.Point(244, 235)
        Me.btnMasuk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnMasuk.Name = "btnMasuk"
        Me.btnMasuk.Size = New System.Drawing.Size(285, 51)
        Me.btnMasuk.TabIndex = 39
        Me.btnMasuk.Text = "Sign In !"
        Me.btnMasuk.UseVisualStyleBackColor = True
        '
        'lblLink
        '
        Me.lblLink.AutoSize = True
        Me.lblLink.BackColor = System.Drawing.Color.Transparent
        Me.lblLink.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLink.LinkColor = System.Drawing.Color.Black
        Me.lblLink.Location = New System.Drawing.Point(278, 291)
        Me.lblLink.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLink.Name = "lblLink"
        Me.lblLink.Size = New System.Drawing.Size(195, 25)
        Me.lblLink.TabIndex = 40
        Me.lblLink.TabStop = True
        Me.lblLink.Text = "Belum Punya Akun ?"
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.BackgroundImage = Global.Aplikasi_Pengajian.My.Resources.Resources.images__5_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(757, 384)
        Me.Controls.Add(Me.lblLink)
        Me.Controls.Add(Me.btnMasuk)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblNIP)
        Me.Controls.Add(Me.lblLogin)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblLogin As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblNIP As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnMasuk As System.Windows.Forms.Button
    Friend WithEvents lblLink As System.Windows.Forms.LinkLabel
End Class
