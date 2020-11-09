<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtPotongan = New System.Windows.Forms.TextBox()
        Me.txtGajiPokok = New System.Windows.Forms.TextBox()
        Me.txtRek = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtNIP = New System.Windows.Forms.TextBox()
        Me.lblPotongan = New System.Windows.Forms.Label()
        Me.lblGajiPokok = New System.Windows.Forms.Label()
        Me.lblRek = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.lblNIP = New System.Windows.Forms.Label()
        Me.txtGaji = New System.Windows.Forms.TextBox()
        Me.lblGaji = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTanggal = New System.Windows.Forms.Label()
        Me.txtLamaLembur = New System.Windows.Forms.TextBox()
        Me.lblLamaLembur = New System.Windows.Forms.Label()
        Me.txtLembur = New System.Windows.Forms.TextBox()
        Me.lblLembur = New System.Windows.Forms.Label()
        Me.dtpTransferMasuk = New System.Windows.Forms.DateTimePicker()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.lblUangLembur = New System.Windows.Forms.Label()
        Me.menuHome = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPegawaiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditDataPegawaiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenggajianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdatePenggajianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LihatDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenggajianToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cr = New AxCrystal.AxCrystalReport()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuHome.SuspendLayout()
        CType(Me.cr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(541, 105)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(696, 461)
        Me.DataGridView1.TabIndex = 25
        '
        'txtPotongan
        '
        Me.txtPotongan.Location = New System.Drawing.Point(181, 392)
        Me.txtPotongan.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPotongan.Name = "txtPotongan"
        Me.txtPotongan.Size = New System.Drawing.Size(326, 28)
        Me.txtPotongan.TabIndex = 6
        '
        'txtGajiPokok
        '
        Me.txtGajiPokok.Location = New System.Drawing.Point(181, 265)
        Me.txtGajiPokok.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtGajiPokok.Name = "txtGajiPokok"
        Me.txtGajiPokok.Size = New System.Drawing.Size(326, 28)
        Me.txtGajiPokok.TabIndex = 4
        '
        'txtRek
        '
        Me.txtRek.Enabled = False
        Me.txtRek.Location = New System.Drawing.Point(181, 220)
        Me.txtRek.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRek.Name = "txtRek"
        Me.txtRek.Size = New System.Drawing.Size(326, 28)
        Me.txtRek.TabIndex = 3
        '
        'txtNama
        '
        Me.txtNama.Enabled = False
        Me.txtNama.Location = New System.Drawing.Point(181, 176)
        Me.txtNama.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(326, 28)
        Me.txtNama.TabIndex = 2
        '
        'txtNIP
        '
        Me.txtNIP.Location = New System.Drawing.Point(181, 134)
        Me.txtNIP.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNIP.Name = "txtNIP"
        Me.txtNIP.Size = New System.Drawing.Size(116, 28)
        Me.txtNIP.TabIndex = 1
        '
        'lblPotongan
        '
        Me.lblPotongan.AutoSize = True
        Me.lblPotongan.BackColor = System.Drawing.Color.Transparent
        Me.lblPotongan.Location = New System.Drawing.Point(50, 394)
        Me.lblPotongan.Name = "lblPotongan"
        Me.lblPotongan.Size = New System.Drawing.Size(92, 21)
        Me.lblPotongan.TabIndex = 19
        Me.lblPotongan.Text = "Potongan"
        '
        'lblGajiPokok
        '
        Me.lblGajiPokok.AutoSize = True
        Me.lblGajiPokok.BackColor = System.Drawing.Color.Transparent
        Me.lblGajiPokok.Location = New System.Drawing.Point(50, 266)
        Me.lblGajiPokok.Name = "lblGajiPokok"
        Me.lblGajiPokok.Size = New System.Drawing.Size(98, 21)
        Me.lblGajiPokok.TabIndex = 18
        Me.lblGajiPokok.Text = "Gaji Pokok"
        '
        'lblRek
        '
        Me.lblRek.AutoSize = True
        Me.lblRek.BackColor = System.Drawing.Color.Transparent
        Me.lblRek.Location = New System.Drawing.Point(50, 222)
        Me.lblRek.Name = "lblRek"
        Me.lblRek.Size = New System.Drawing.Size(114, 21)
        Me.lblRek.TabIndex = 17
        Me.lblRek.Text = "No Rekening"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.BackColor = System.Drawing.Color.Transparent
        Me.lblNama.Location = New System.Drawing.Point(50, 177)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(62, 21)
        Me.lblNama.TabIndex = 16
        Me.lblNama.Text = "Nama"
        '
        'lblNIP
        '
        Me.lblNIP.AutoSize = True
        Me.lblNIP.BackColor = System.Drawing.Color.Transparent
        Me.lblNIP.Location = New System.Drawing.Point(50, 135)
        Me.lblNIP.Name = "lblNIP"
        Me.lblNIP.Size = New System.Drawing.Size(38, 21)
        Me.lblNIP.TabIndex = 15
        Me.lblNIP.Text = "NIP"
        '
        'txtGaji
        '
        Me.txtGaji.Enabled = False
        Me.txtGaji.Location = New System.Drawing.Point(181, 468)
        Me.txtGaji.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtGaji.Name = "txtGaji"
        Me.txtGaji.Size = New System.Drawing.Size(326, 28)
        Me.txtGaji.TabIndex = 8
        '
        'lblGaji
        '
        Me.lblGaji.AutoSize = True
        Me.lblGaji.BackColor = System.Drawing.Color.Transparent
        Me.lblGaji.Location = New System.Drawing.Point(50, 469)
        Me.lblGaji.Name = "lblGaji"
        Me.lblGaji.Size = New System.Drawing.Size(89, 21)
        Me.lblGaji.TabIndex = 30
        Me.lblGaji.Text = "Total Gaji"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(556, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(257, 30)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "DATA GAJI PEGAWAI"
        '
        'lblTanggal
        '
        Me.lblTanggal.AutoSize = True
        Me.lblTanggal.BackColor = System.Drawing.Color.Transparent
        Me.lblTanggal.Location = New System.Drawing.Point(50, 513)
        Me.lblTanggal.Name = "lblTanggal"
        Me.lblTanggal.Size = New System.Drawing.Size(145, 21)
        Me.lblTanggal.TabIndex = 33
        Me.lblTanggal.Text = "Tanggal Trasnfer"
        '
        'txtLamaLembur
        '
        Me.txtLamaLembur.Location = New System.Drawing.Point(181, 307)
        Me.txtLamaLembur.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtLamaLembur.Name = "txtLamaLembur"
        Me.txtLamaLembur.Size = New System.Drawing.Size(116, 28)
        Me.txtLamaLembur.TabIndex = 5
        '
        'lblLamaLembur
        '
        Me.lblLamaLembur.AutoSize = True
        Me.lblLamaLembur.BackColor = System.Drawing.Color.Transparent
        Me.lblLamaLembur.Location = New System.Drawing.Point(50, 308)
        Me.lblLamaLembur.Name = "lblLamaLembur"
        Me.lblLamaLembur.Size = New System.Drawing.Size(175, 21)
        Me.lblLamaLembur.TabIndex = 35
        Me.lblLamaLembur.Text = "Lama Lembur (Jam)"
        '
        'txtLembur
        '
        Me.txtLembur.Location = New System.Drawing.Point(181, 349)
        Me.txtLembur.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtLembur.Name = "txtLembur"
        Me.txtLembur.Size = New System.Drawing.Size(326, 28)
        Me.txtLembur.TabIndex = 38
        '
        'lblLembur
        '
        Me.lblLembur.AutoSize = True
        Me.lblLembur.BackColor = System.Drawing.Color.Transparent
        Me.lblLembur.Location = New System.Drawing.Point(50, 350)
        Me.lblLembur.Name = "lblLembur"
        Me.lblLembur.Size = New System.Drawing.Size(121, 21)
        Me.lblLembur.TabIndex = 37
        Me.lblLembur.Text = "Uang Lembur"
        '
        'dtpTransferMasuk
        '
        Me.dtpTransferMasuk.Location = New System.Drawing.Point(181, 513)
        Me.dtpTransferMasuk.Name = "dtpTransferMasuk"
        Me.dtpTransferMasuk.Size = New System.Drawing.Size(200, 28)
        Me.dtpTransferMasuk.TabIndex = 9
        '
        'btnKembali
        '
        Me.btnKembali.BackgroundImage = CType(resources.GetObject("btnKembali.BackgroundImage"), System.Drawing.Image)
        Me.btnKembali.ForeColor = System.Drawing.Color.White
        Me.btnKembali.Location = New System.Drawing.Point(279, 562)
        Me.btnKembali.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(97, 35)
        Me.btnKembali.TabIndex = 11
        Me.btnKembali.Text = "Kembali"
        Me.btnKembali.UseVisualStyleBackColor = True
        '
        'btnHitung
        '
        Me.btnHitung.BackgroundImage = CType(resources.GetObject("btnHitung.BackgroundImage"), System.Drawing.Image)
        Me.btnHitung.ForeColor = System.Drawing.Color.White
        Me.btnHitung.Location = New System.Drawing.Point(181, 428)
        Me.btnHitung.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(97, 31)
        Me.btnHitung.TabIndex = 7
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.BackgroundImage = CType(resources.GetObject("btnSimpan.BackgroundImage"), System.Drawing.Image)
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Location = New System.Drawing.Point(169, 562)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(97, 35)
        Me.btnSimpan.TabIndex = 10
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnCari
        '
        Me.btnCari.BackgroundImage = CType(resources.GetObject("btnCari.BackgroundImage"), System.Drawing.Image)
        Me.btnCari.ForeColor = System.Drawing.Color.White
        Me.btnCari.Location = New System.Drawing.Point(317, 133)
        Me.btnCari.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(94, 30)
        Me.btnCari.TabIndex = 12
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'lblUangLembur
        '
        Me.lblUangLembur.AutoSize = True
        Me.lblUangLembur.BackColor = System.Drawing.Color.Transparent
        Me.lblUangLembur.ForeColor = System.Drawing.Color.Red
        Me.lblUangLembur.Location = New System.Drawing.Point(313, 308)
        Me.lblUangLembur.Name = "lblUangLembur"
        Me.lblUangLembur.Size = New System.Drawing.Size(153, 21)
        Me.lblUangLembur.TabIndex = 46
        Me.lblUangLembur.Text = "Rp. 100.000 / Jam"
        '
        'menuHome
        '
        Me.menuHome.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.menuHome.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.DataPegawaiToolStripMenuItem, Me.PenggajianToolStripMenuItem, Me.LihatDatabaseToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.menuHome.Location = New System.Drawing.Point(0, 0)
        Me.menuHome.Name = "menuHome"
        Me.menuHome.Size = New System.Drawing.Size(1275, 33)
        Me.menuHome.TabIndex = 47
        Me.menuHome.Text = "Menu Home"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(73, 29)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'DataPegawaiToolStripMenuItem
        '
        Me.DataPegawaiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditDataPegawaiToolStripMenuItem})
        Me.DataPegawaiToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.DataPegawaiToolStripMenuItem.Name = "DataPegawaiToolStripMenuItem"
        Me.DataPegawaiToolStripMenuItem.Size = New System.Drawing.Size(130, 29)
        Me.DataPegawaiToolStripMenuItem.Text = "Data Pegawai"
        '
        'EditDataPegawaiToolStripMenuItem
        '
        Me.EditDataPegawaiToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.EditDataPegawaiToolStripMenuItem.Name = "EditDataPegawaiToolStripMenuItem"
        Me.EditDataPegawaiToolStripMenuItem.Size = New System.Drawing.Size(253, 30)
        Me.EditDataPegawaiToolStripMenuItem.Text = "Update Data Pegawai"
        '
        'PenggajianToolStripMenuItem
        '
        Me.PenggajianToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdatePenggajianToolStripMenuItem})
        Me.PenggajianToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.PenggajianToolStripMenuItem.Name = "PenggajianToolStripMenuItem"
        Me.PenggajianToolStripMenuItem.Size = New System.Drawing.Size(110, 29)
        Me.PenggajianToolStripMenuItem.Text = "Penggajian"
        '
        'UpdatePenggajianToolStripMenuItem
        '
        Me.UpdatePenggajianToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.UpdatePenggajianToolStripMenuItem.Name = "UpdatePenggajianToolStripMenuItem"
        Me.UpdatePenggajianToolStripMenuItem.Size = New System.Drawing.Size(233, 30)
        Me.UpdatePenggajianToolStripMenuItem.Text = "Update Penggajian"
        '
        'LihatDatabaseToolStripMenuItem
        '
        Me.LihatDatabaseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataToolStripMenuItem, Me.PenggajianToolStripMenuItem1})
        Me.LihatDatabaseToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.LihatDatabaseToolStripMenuItem.Name = "LihatDatabaseToolStripMenuItem"
        Me.LihatDatabaseToolStripMenuItem.Size = New System.Drawing.Size(88, 29)
        Me.LihatDatabaseToolStripMenuItem.Text = "Laporan"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(170, 30)
        Me.DataToolStripMenuItem.Text = "Data"
        '
        'PenggajianToolStripMenuItem1
        '
        Me.PenggajianToolStripMenuItem1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.PenggajianToolStripMenuItem1.Name = "PenggajianToolStripMenuItem1"
        Me.PenggajianToolStripMenuItem1.Size = New System.Drawing.Size(170, 30)
        Me.PenggajianToolStripMenuItem1.Text = "Penggajian"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(72, 29)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'cr
        '
        Me.cr.Enabled = True
        Me.cr.Location = New System.Drawing.Point(516, 0)
        Me.cr.Name = "cr"
        Me.cr.OcxState = CType(resources.GetObject("cr.OcxState"), System.Windows.Forms.AxHost.State)
        Me.cr.Size = New System.Drawing.Size(28, 28)
        Me.cr.TabIndex = 48
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BackgroundImage = Global.Aplikasi_Pengajian.My.Resources.Resources.images__5_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1275, 655)
        Me.Controls.Add(Me.cr)
        Me.Controls.Add(Me.menuHome)
        Me.Controls.Add(Me.lblUangLembur)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.dtpTransferMasuk)
        Me.Controls.Add(Me.txtLembur)
        Me.Controls.Add(Me.lblLembur)
        Me.Controls.Add(Me.txtLamaLembur)
        Me.Controls.Add(Me.lblLamaLembur)
        Me.Controls.Add(Me.lblTanggal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtGaji)
        Me.Controls.Add(Me.lblGaji)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtPotongan)
        Me.Controls.Add(Me.txtGajiPokok)
        Me.Controls.Add(Me.txtRek)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtNIP)
        Me.Controls.Add(Me.lblPotongan)
        Me.Controls.Add(Me.lblGajiPokok)
        Me.Controls.Add(Me.lblRek)
        Me.Controls.Add(Me.lblNama)
        Me.Controls.Add(Me.lblNIP)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Gaji Pegawai"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuHome.ResumeLayout(False)
        Me.menuHome.PerformLayout()
        CType(Me.cr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtPotongan As System.Windows.Forms.TextBox
    Friend WithEvents txtGajiPokok As System.Windows.Forms.TextBox
    Friend WithEvents txtRek As System.Windows.Forms.TextBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents txtNIP As System.Windows.Forms.TextBox
    Friend WithEvents lblPotongan As System.Windows.Forms.Label
    Friend WithEvents lblGajiPokok As System.Windows.Forms.Label
    Friend WithEvents lblRek As System.Windows.Forms.Label
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents lblNIP As System.Windows.Forms.Label
    Friend WithEvents txtGaji As System.Windows.Forms.TextBox
    Friend WithEvents lblGaji As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblTanggal As System.Windows.Forms.Label
    Friend WithEvents txtLamaLembur As System.Windows.Forms.TextBox
    Friend WithEvents lblLamaLembur As System.Windows.Forms.Label
    Friend WithEvents txtLembur As System.Windows.Forms.TextBox
    Friend WithEvents lblLembur As System.Windows.Forms.Label
    Friend WithEvents dtpTransferMasuk As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnKembali As System.Windows.Forms.Button
    Friend WithEvents btnHitung As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents lblUangLembur As System.Windows.Forms.Label
    Friend WithEvents menuHome As System.Windows.Forms.MenuStrip
    Friend WithEvents HomeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataPegawaiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditDataPegawaiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PenggajianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdatePenggajianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LihatDatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PenggajianToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cr As AxCrystal.AxCrystalReport
End Class
