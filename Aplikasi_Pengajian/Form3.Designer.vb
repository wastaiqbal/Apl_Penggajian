<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnKembali = New System.Windows.Forms.Button()
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
        Me.DataGridView1.Location = New System.Drawing.Point(18, 157)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1193, 518)
        Me.DataGridView1.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(496, 72)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(250, 30)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "DATABASE PEGAWAI"
        '
        'btnKembali
        '
        Me.btnKembali.BackgroundImage = Global.Aplikasi_Pengajian.My.Resources.Resources.images__5_
        Me.btnKembali.ForeColor = System.Drawing.Color.White
        Me.btnKembali.Location = New System.Drawing.Point(18, 69)
        Me.btnKembali.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(122, 40)
        Me.btnKembali.TabIndex = 46
        Me.btnKembali.Text = "Kembali"
        Me.btnKembali.UseVisualStyleBackColor = True
        '
        'menuHome
        '
        Me.menuHome.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.menuHome.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.DataPegawaiToolStripMenuItem, Me.PenggajianToolStripMenuItem, Me.LihatDatabaseToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.menuHome.Location = New System.Drawing.Point(0, 0)
        Me.menuHome.Name = "menuHome"
        Me.menuHome.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.menuHome.Size = New System.Drawing.Size(1241, 35)
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
        Me.cr.Location = New System.Drawing.Point(533, 7)
        Me.cr.Name = "cr"
        Me.cr.OcxState = CType(resources.GetObject("cr.OcxState"), System.Windows.Forms.AxHost.State)
        Me.cr.Size = New System.Drawing.Size(28, 28)
        Me.cr.TabIndex = 49
        '
        'Form3
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BackgroundImage = Global.Aplikasi_Pengajian.My.Resources.Resources.images__5_
        Me.ClientSize = New System.Drawing.Size(1241, 803)
        Me.Controls.Add(Me.cr)
        Me.Controls.Add(Me.menuHome)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Database Pegawai"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuHome.ResumeLayout(False)
        Me.menuHome.PerformLayout()
        CType(Me.cr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnKembali As System.Windows.Forms.Button
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
