<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormHome))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.menuHome.SuspendLayout()
        CType(Me.cr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(287, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Selamat Datang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(71, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(655, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Silahkan pilih menu pada menu bar untuk mengakses fitur-fiturnya"
        '
        'menuHome
        '
        Me.menuHome.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.menuHome.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.DataPegawaiToolStripMenuItem, Me.PenggajianToolStripMenuItem, Me.LihatDatabaseToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.menuHome.Location = New System.Drawing.Point(0, 0)
        Me.menuHome.Name = "menuHome"
        Me.menuHome.Size = New System.Drawing.Size(797, 24)
        Me.menuHome.TabIndex = 2
        Me.menuHome.Text = "Menu Home"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'DataPegawaiToolStripMenuItem
        '
        Me.DataPegawaiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditDataPegawaiToolStripMenuItem})
        Me.DataPegawaiToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.DataPegawaiToolStripMenuItem.Name = "DataPegawaiToolStripMenuItem"
        Me.DataPegawaiToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.DataPegawaiToolStripMenuItem.Text = "Data Pegawai"
        '
        'EditDataPegawaiToolStripMenuItem
        '
        Me.EditDataPegawaiToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.EditDataPegawaiToolStripMenuItem.Name = "EditDataPegawaiToolStripMenuItem"
        Me.EditDataPegawaiToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.EditDataPegawaiToolStripMenuItem.Text = "Update Data Pegawai"
        '
        'PenggajianToolStripMenuItem
        '
        Me.PenggajianToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdatePenggajianToolStripMenuItem})
        Me.PenggajianToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.PenggajianToolStripMenuItem.Name = "PenggajianToolStripMenuItem"
        Me.PenggajianToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.PenggajianToolStripMenuItem.Text = "Penggajian"
        '
        'UpdatePenggajianToolStripMenuItem
        '
        Me.UpdatePenggajianToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.UpdatePenggajianToolStripMenuItem.Name = "UpdatePenggajianToolStripMenuItem"
        Me.UpdatePenggajianToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.UpdatePenggajianToolStripMenuItem.Text = "Update Penggajian"
        '
        'LihatDatabaseToolStripMenuItem
        '
        Me.LihatDatabaseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataToolStripMenuItem, Me.PenggajianToolStripMenuItem1})
        Me.LihatDatabaseToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.LihatDatabaseToolStripMenuItem.Name = "LihatDatabaseToolStripMenuItem"
        Me.LihatDatabaseToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LihatDatabaseToolStripMenuItem.Text = "Laporan"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DataToolStripMenuItem.Text = "Data"
        '
        'PenggajianToolStripMenuItem1
        '
        Me.PenggajianToolStripMenuItem1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.PenggajianToolStripMenuItem1.Name = "PenggajianToolStripMenuItem1"
        Me.PenggajianToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.PenggajianToolStripMenuItem1.Text = "Penggajian"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'cr
        '
        Me.cr.Enabled = True
        Me.cr.Location = New System.Drawing.Point(485, 0)
        Me.cr.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cr.Name = "cr"
        Me.cr.OcxState = CType(resources.GetObject("cr.OcxState"), System.Windows.Forms.AxHost.State)
        Me.cr.Size = New System.Drawing.Size(28, 28)
        Me.cr.TabIndex = 3
        '
        'FormHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplikasi_Pengajian.My.Resources.Resources.aplikasi_penggajian_karyawan_berbasis_web
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(797, 477)
        Me.Controls.Add(Me.cr)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.menuHome)
        Me.DoubleBuffered = True
        Me.MainMenuStrip = Me.menuHome
        Me.Name = "FormHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplikasi Penggajian"
        Me.menuHome.ResumeLayout(False)
        Me.menuHome.PerformLayout()
        CType(Me.cr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
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
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
End Class
