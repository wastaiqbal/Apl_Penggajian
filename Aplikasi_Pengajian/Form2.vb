Imports System.Data.Odbc

Public Class Form2
    Sub TampilGrid()
        Call koneksi()
        da = New OdbcDataAdapter("select nip, nama, no_rek, gaji_pokok, uang_lembur, potongan, gaji_total, tgl_transfer From tb_pegawai", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tb_pegawai")
        DataGridView1.DataSource = ds.Tables("tb_pegawai")
        DataGridView1.Columns("nama").Width = 200
        DataGridView1.ReadOnly = True
    End Sub

    Sub EnableData()
        txtGajiPokok.Enabled = True
        txtLamaLembur.Enabled = True
        txtPotongan.Enabled = True
        dtpTransferMasuk.Enabled = True
    End Sub

    Sub DisableData()
        txtGajiPokok.Enabled = False
        txtLamaLembur.Enabled = False
        txtLembur.Enabled = False
        txtPotongan.Enabled = False
        txtGaji.Enabled = False
        dtpTransferMasuk.Enabled = False
    End Sub

    Sub KosongData()
        txtNIP.Text = ""
        txtNama.Text = ""
        txtRek.Text = ""
        txtGajiPokok.Text = ""
        txtLamaLembur.Text = ""
        txtLembur.Text = ""
        txtPotongan.Text = ""
        txtGaji.Text = ""
        dtpTransferMasuk.Text = ""
    End Sub

    Private Sub btnKembali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKembali.Click
        FormHome.Show()
        Me.Close()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call TampilGrid()
        Call DisableData()
    End Sub

    Private Sub txtLamaLembur_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLamaLembur.TextChanged
        If Not txtLamaLembur.Text = "" Then
            Dim lama_lembur_txt As String = txtLamaLembur.Text
            Dim lama_lembur As Integer
            Dim lembur As Integer
            lembur = CType(txtLembur.Text, Integer)

            lama_lembur = CType(lama_lembur_txt, Integer)
            lembur = lama_lembur * 100000
            txtLembur.Text = lembur
        Else
            txtLembur.Text = 0
        End If
    End Sub

    Private Sub btnCari_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCari.Click
        Call koneksi()
        cmd = New OdbcCommand("SELECT * FROM tb_pegawai WHERE nip = '" & txtNIP.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            MsgBox("Data tidak ditemukan")
            txtNIP.Focus()
        Else
            Call EnableData()
            txtNIP.Text = rd.Item("nip")
            txtNama.Text = rd.Item("nama")
            txtGajiPokok.Text = rd.Item("gaji_pokok")
            txtRek.Text = rd.Item("no_rek")
            txtLembur.Text = rd.Item("uang_lembur")
            txtLamaLembur.Text = txtLembur.Text / 100000
            txtPotongan.Text = rd.Item("potongan")
            txtGaji.Text = rd.Item("gaji_total")
            dtpTransferMasuk.Value = rd.Item("tgl_transfer")
            txtNIP.Focus()
        End If
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        If txtGaji.Text = "" Or txtLamaLembur.Text = "" Or txtLembur.Text = "" Or txtPotongan.Text = "" Or txtGaji.Text = "" Then
            MsgBox("Data yang diinput tidak boleh kosong !")
        Else
            Call koneksi()
            Dim update As String = "UPDATE `tb_pegawai` SET gaji_pokok = '" & txtGajiPokok.Text & "', uang_lembur = '" & txtLembur.Text & "', potongan = '" & txtPotongan.Text & "', gaji_total = '" & txtGaji.Text & "', tgl_masuk = '" & Format(dtpTransferMasuk.Value, "yyyy-MM-dd") & "' WHERE nip = '" & txtNIP.Text & "' "
            cmd = New OdbcCommand(update, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil diinput")
            Call TampilGrid()
            Call KosongData()
        End If
    End Sub

    Private Sub btnHitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHitung.Click
            Dim gajipokok As Integer = CType(txtGajiPokok.Text, Integer)
            Dim lembur As Integer = CType(txtLembur.Text, Integer)
            Dim potongan As Integer = CType(txtPotongan.Text, Integer)
            txtGaji.Text = gajipokok + lembur - potongan
    End Sub

    Private Sub EditDataPegawaiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditDataPegawaiToolStripMenuItem.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub UpdatePenggajianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdatePenggajianToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        If MessageBox.Show("Apakah Anda Yakin Ingin Keluar ?", "Keluar Aplikasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            FormHome.Close()
            FormLogin.Close()
        End If
    End Sub

    Private Sub HomeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeToolStripMenuItem.Click
        Me.Close()
        FormHome.Show()
    End Sub

    Private Sub DataToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DataToolStripMenuItem.Click
        Me.Close()
        Form3.Show()
    End Sub

    Private Sub PenggajianToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles PenggajianToolStripMenuItem1.Click
        cr.ReportFileName = "Report1.rpt"
        cr.WindowState = Crystal.WindowStateConstants.crptMaximized
        cr.RetrieveDataFiles()
        cr.Action = 1
    End Sub

    Private Sub DataGridView1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.Click
        Call DisableData()

        txtNIP.Text = DataGridView1.CurrentRow.Cells(0).Value
        txtNama.Text = DataGridView1.CurrentRow.Cells(1).Value
        txtRek.Text = DataGridView1.CurrentRow.Cells(2).Value
        txtGajiPokok.Text = DataGridView1.CurrentRow.Cells(3).FormattedValue
        txtLamaLembur.Text = DataGridView1.CurrentRow.Cells(4).DefaultNewRowValue
        txtLembur.Text = DataGridView1.CurrentRow.Cells(5).DefaultNewRowValue
        txtGaji.Text = DataGridView1.CurrentRow.Cells(6).FormattedValue
        dtpTransferMasuk.Text = DataGridView1.CurrentRow.Cells(7).Value
    End Sub
End Class