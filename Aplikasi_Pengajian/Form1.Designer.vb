<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblNIP = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.lblRek = New System.Windows.Forms.Label()
        Me.lblJabatan = New System.Windows.Forms.Label()
        Me.lblTanggal = New System.Windows.Forms.Label()
        Me.txtNIP = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtRek = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.lblJudul = New System.Windows.Forms.Label()
        Me.lblJK = New System.Windows.Forms.Label()
        Me.rbLaki = New System.Windows.Forms.RadioButton()
        Me.rbPerempuan = New System.Windows.Forms.RadioButton()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.dtpTanggal = New System.Windows.Forms.DateTimePicker()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.lblAlamat = New System.Windows.Forms.Label()
        Me.cbJabatan = New System.Windows.Forms.ComboBox()
        Me.lblId = New System.Windows.Forms.Label()
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
        'lblNIP
        '
        Me.lblNIP.AutoSize = True
        Me.lblNIP.BackColor = System.Drawing.Color.Transparent
        Me.lblNIP.ForeColor = System.Drawing.Color.Black
        Me.lblNIP.Location = New System.Drawing.Point(54, 140)
        Me.lblNIP.Name = "lblNIP"
        Me.lblNIP.Size = New System.Drawing.Size(38, 21)
        Me.lblNIP.TabIndex = 0
        Me.lblNIP.Text = "NIP"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.BackColor = System.Drawing.Color.Transparent
        Me.lblNama.ForeColor = System.Drawing.Color.Black
        Me.lblNama.Location = New System.Drawing.Point(54, 182)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(62, 21)
        Me.lblNama.TabIndex = 1
        Me.lblNama.Text = "Nama"
        '
        'lblRek
        '
        Me.lblRek.AutoSize = True
        Me.lblRek.BackColor = System.Drawing.Color.Transparent
        Me.lblRek.ForeColor = System.Drawing.Color.Black
        Me.lblRek.Location = New System.Drawing.Point(54, 332)
        Me.lblRek.Name = "lblRek"
        Me.lblRek.Size = New System.Drawing.Size(114, 21)
        Me.lblRek.TabIndex = 2
        Me.lblRek.Text = "No Rekening"
        '
        'lblJabatan
        '
        Me.lblJabatan.AutoSize = True
        Me.lblJabatan.BackColor = System.Drawing.Color.Transparent
        Me.lblJabatan.ForeColor = System.Drawing.Color.Black
        Me.lblJabatan.Location = New System.Drawing.Point(54, 377)
        Me.lblJabatan.Name = "lblJabatan"
        Me.lblJabatan.Size = New System.Drawing.Size(83, 21)
        Me.lblJabatan.TabIndex = 3
        Me.lblJabatan.Text = "Jabatan"
        '
        'lblTanggal
        '
        Me.lblTanggal.AutoSize = True
        Me.lblTanggal.BackColor = System.Drawing.Color.Transparent
        Me.lblTanggal.ForeColor = System.Drawing.Color.Black
        Me.lblTanggal.Location = New System.Drawing.Point(54, 419)
        Me.lblTanggal.Name = "lblTanggal"
        Me.lblTanggal.Size = New System.Drawing.Size(137, 21)
        Me.lblTanggal.TabIndex = 4
        Me.lblTanggal.Text = "Tanggal Masuk"
        '
        'txtNIP
        '
        Me.txtNIP.Location = New System.Drawing.Point(146, 140)
        Me.txtNIP.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNIP.Name = "txtNIP"
        Me.txtNIP.Size = New System.Drawing.Size(116, 28)
        Me.txtNIP.TabIndex = 1
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(146, 182)
        Me.txtNama.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(326, 28)
        Me.txtNama.TabIndex = 3
        '
        'txtRek
        '
        Me.txtRek.Location = New System.Drawing.Point(146, 332)
        Me.txtRek.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRek.Name = "txtRek"
        Me.txtRek.Size = New System.Drawing.Size(326, 28)
        Me.txtRek.TabIndex = 7
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(521, 111)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(629, 390)
        Me.DataGridView1.TabIndex = 15
        '
        'btnCari
        '
        Me.btnCari.BackgroundImage = CType(resources.GetObject("btnCari.BackgroundImage"), System.Drawing.Image)
        Me.btnCari.ForeColor = System.Drawing.Color.White
        Me.btnCari.Location = New System.Drawing.Point(279, 136)
        Me.btnCari.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(87, 36)
        Me.btnCari.TabIndex = 14
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.BackgroundImage = CType(resources.GetObject("btnSimpan.BackgroundImage"), System.Drawing.Image)
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Location = New System.Drawing.Point(39, 468)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(94, 35)
        Me.btnSimpan.TabIndex = 10
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.BackgroundImage = CType(resources.GetObject("btnEdit.BackgroundImage"), System.Drawing.Image)
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(162, 468)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(94, 35)
        Me.btnEdit.TabIndex = 11
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.BackgroundImage = CType(resources.GetObject("btnHapus.BackgroundImage"), System.Drawing.Image)
        Me.btnHapus.ForeColor = System.Drawing.Color.White
        Me.btnHapus.Location = New System.Drawing.Point(282, 468)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(94, 35)
        Me.btnHapus.TabIndex = 12
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'lblJudul
        '
        Me.lblJudul.AutoSize = True
        Me.lblJudul.BackColor = System.Drawing.Color.Transparent
        Me.lblJudul.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Underline)
        Me.lblJudul.ForeColor = System.Drawing.Color.Black
        Me.lblJudul.Location = New System.Drawing.Point(505, 50)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(194, 30)
        Me.lblJudul.TabIndex = 15
        Me.lblJudul.Text = "DATA PEGAWAI"
        '
        'lblJK
        '
        Me.lblJK.AutoSize = True
        Me.lblJK.BackColor = System.Drawing.Color.Transparent
        Me.lblJK.ForeColor = System.Drawing.Color.Black
        Me.lblJK.Location = New System.Drawing.Point(54, 229)
        Me.lblJK.Name = "lblJK"
        Me.lblJK.Size = New System.Drawing.Size(118, 21)
        Me.lblJK.TabIndex = 16
        Me.lblJK.Text = "Jenis Kelamin"
        '
        'rbLaki
        '
        Me.rbLaki.AutoSize = True
        Me.rbLaki.BackColor = System.Drawing.Color.Transparent
        Me.rbLaki.ForeColor = System.Drawing.Color.Black
        Me.rbLaki.Location = New System.Drawing.Point(150, 229)
        Me.rbLaki.Name = "rbLaki"
        Me.rbLaki.Size = New System.Drawing.Size(100, 25)
        Me.rbLaki.TabIndex = 4
        Me.rbLaki.TabStop = True
        Me.rbLaki.Text = "Laki-laki"
        Me.rbLaki.UseVisualStyleBackColor = False
        '
        'rbPerempuan
        '
        Me.rbPerempuan.AutoSize = True
        Me.rbPerempuan.BackColor = System.Drawing.Color.Transparent
        Me.rbPerempuan.ForeColor = System.Drawing.Color.Black
        Me.rbPerempuan.Location = New System.Drawing.Point(232, 229)
        Me.rbPerempuan.Name = "rbPerempuan"
        Me.rbPerempuan.Size = New System.Drawing.Size(131, 25)
        Me.rbPerempuan.TabIndex = 5
        Me.rbPerempuan.TabStop = True
        Me.rbPerempuan.Text = "Perempuan"
        Me.rbPerempuan.UseVisualStyleBackColor = False
        '
        'btnKembali
        '
        Me.btnKembali.BackgroundImage = CType(resources.GetObject("btnKembali.BackgroundImage"), System.Drawing.Image)
        Me.btnKembali.ForeColor = System.Drawing.Color.White
        Me.btnKembali.Location = New System.Drawing.Point(399, 468)
        Me.btnKembali.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(94, 35)
        Me.btnKembali.TabIndex = 13
        Me.btnKembali.Text = "Kembali"
        Me.btnKembali.UseVisualStyleBackColor = True
        '
        'dtpTanggal
        '
        Me.dtpTanggal.Location = New System.Drawing.Point(146, 414)
        Me.dtpTanggal.Name = "dtpTanggal"
        Me.dtpTanggal.Size = New System.Drawing.Size(200, 28)
        Me.dtpTanggal.TabIndex = 9
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(146, 268)
        Me.txtAlamat.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(326, 45)
        Me.txtAlamat.TabIndex = 6
        '
        'lblAlamat
        '
        Me.lblAlamat.AutoSize = True
        Me.lblAlamat.BackColor = System.Drawing.Color.Transparent
        Me.lblAlamat.ForeColor = System.Drawing.Color.Black
        Me.lblAlamat.Location = New System.Drawing.Point(54, 268)
        Me.lblAlamat.Name = "lblAlamat"
        Me.lblAlamat.Size = New System.Drawing.Size(72, 21)
        Me.lblAlamat.TabIndex = 21
        Me.lblAlamat.Text = "Alamat"
        '
        'cbJabatan
        '
        Me.cbJabatan.FormattingEnabled = True
        Me.cbJabatan.Location = New System.Drawing.Point(146, 377)
        Me.cbJabatan.Name = "cbJabatan"
        Me.cbJabatan.Size = New System.Drawing.Size(322, 29)
        Me.cbJabatan.TabIndex = 8
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(13, 13)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(0, 21)
        Me.lblId.TabIndex = 24
        Me.lblId.Visible = False
        '
        'menuHome
        '
        Me.menuHome.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.menuHome.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.DataPegawaiToolStripMenuItem, Me.PenggajianToolStripMenuItem, Me.LihatDatabaseToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.menuHome.Location = New System.Drawing.Point(0, 0)
        Me.menuHome.Name = "menuHome"
        Me.menuHome.Size = New System.Drawing.Size(1179, 33)
        Me.menuHome.TabIndex = 25
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
        Me.cr.Location = New System.Drawing.Point(497, 0)
        Me.cr.Name = "cr"
        Me.cr.OcxState = CType(resources.GetObject("cr.OcxState"), System.Windows.Forms.AxHost.State)
        Me.cr.Size = New System.Drawing.Size(28, 28)
        Me.cr.TabIndex = 26
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1179, 552)
        Me.Controls.Add(Me.cr)
        Me.Controls.Add(Me.menuHome)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.cbJabatan)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.lblAlamat)
        Me.Controls.Add(Me.dtpTanggal)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.rbPerempuan)
        Me.Controls.Add(Me.rbLaki)
        Me.Controls.Add(Me.lblJK)
        Me.Controls.Add(Me.lblJudul)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtRek)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtNIP)
        Me.Controls.Add(Me.lblTanggal)
        Me.Controls.Add(Me.lblJabatan)
        Me.Controls.Add(Me.lblRek)
        Me.Controls.Add(Me.lblNama)
        Me.Controls.Add(Me.lblNIP)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Pegawai"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuHome.ResumeLayout(False)
        Me.menuHome.PerformLayout()
        CType(Me.cr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNIP As System.Windows.Forms.Label
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents lblRek As System.Windows.Forms.Label
    Friend WithEvents lblJabatan As System.Windows.Forms.Label
    Friend WithEvents lblTanggal As System.Windows.Forms.Label
    Friend WithEvents txtNIP As System.Windows.Forms.TextBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents txtRek As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents lblJK As System.Windows.Forms.Label
    Friend WithEvents rbLaki As System.Windows.Forms.RadioButton
    Friend WithEvents rbPerempuan As System.Windows.Forms.RadioButton
    Friend WithEvents btnKembali As System.Windows.Forms.Button
    Friend WithEvents dtpTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents lblAlamat As System.Windows.Forms.Label
    Friend WithEvents cbJabatan As System.Windows.Forms.ComboBox
    Friend WithEvents lblId As System.Windows.Forms.Label
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
