<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDaftarAkun
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDaftarAkun))
        Me.btnDaftar = New System.Windows.Forms.Button()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUPassword = New System.Windows.Forms.TextBox()
        Me.lblNIP = New System.Windows.Forms.Label()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.brnKembali = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDaftar
        '
        Me.btnDaftar.BackgroundImage = CType(resources.GetObject("btnDaftar.BackgroundImage"), System.Drawing.Image)
        Me.btnDaftar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDaftar.ForeColor = System.Drawing.Color.White
        Me.btnDaftar.Location = New System.Drawing.Point(232, 278)
        Me.btnDaftar.Name = "btnDaftar"
        Me.btnDaftar.Size = New System.Drawing.Size(105, 30)
        Me.btnDaftar.TabIndex = 6
        Me.btnDaftar.Text = "Daftarkan"
        Me.btnDaftar.UseVisualStyleBackColor = True
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(190, 155)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(148, 20)
        Me.txtUsername.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(62, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Password"
        '
        'txtUPassword
        '
        Me.txtUPassword.Location = New System.Drawing.Point(190, 229)
        Me.txtUPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtUPassword.Name = "txtUPassword"
        Me.txtUPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtUPassword.Size = New System.Drawing.Size(148, 20)
        Me.txtUPassword.TabIndex = 5
        '
        'lblNIP
        '
        Me.lblNIP.AutoSize = True
        Me.lblNIP.BackColor = System.Drawing.Color.Transparent
        Me.lblNIP.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.lblNIP.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblNIP.Location = New System.Drawing.Point(62, 157)
        Me.lblNIP.Name = "lblNIP"
        Me.lblNIP.Size = New System.Drawing.Size(75, 16)
        Me.lblNIP.TabIndex = 41
        Me.lblNIP.Text = "Username"
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.BackColor = System.Drawing.Color.Transparent
        Me.lblLogin.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblLogin.Location = New System.Drawing.Point(99, 27)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(207, 36)
        Me.lblLogin.TabIndex = 40
        Me.lblLogin.Text = "DAFTAR AKUN"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(190, 81)
        Me.txtNama.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(148, 20)
        Me.txtNama.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(62, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 16)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Nama"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(190, 118)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(148, 20)
        Me.txtEmail.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Location = New System.Drawing.Point(62, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 16)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Email"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(190, 192)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(148, 20)
        Me.txtPassword.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(62, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 16)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Ulangi Password"
        '
        'brnKembali
        '
        Me.brnKembali.BackgroundImage = CType(resources.GetObject("brnKembali.BackgroundImage"), System.Drawing.Image)
        Me.brnKembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brnKembali.ForeColor = System.Drawing.Color.White
        Me.brnKembali.Location = New System.Drawing.Point(113, 278)
        Me.brnKembali.Name = "brnKembali"
        Me.brnKembali.Size = New System.Drawing.Size(105, 30)
        Me.brnKembali.TabIndex = 7
        Me.brnKembali.Text = "Kembali"
        Me.brnKembali.UseVisualStyleBackColor = True
        '
        'FormDaftarAkun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cyan
        Me.BackgroundImage = Global.Aplikasi_Pengajian.My.Resources.Resources.images__5_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(407, 353)
        Me.Controls.Add(Me.brnKembali)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnDaftar)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUPassword)
        Me.Controls.Add(Me.lblNIP)
        Me.Controls.Add(Me.lblLogin)
        Me.MaximizeBox = False
        Me.Name = "FormDaftarAkun"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Daftar Akun"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDaftar As System.Windows.Forms.Button
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtUPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblNIP As System.Windows.Forms.Label
    Friend WithEvents lblLogin As System.Windows.Forms.Label
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents brnKembali As System.Windows.Forms.Button
End Class
