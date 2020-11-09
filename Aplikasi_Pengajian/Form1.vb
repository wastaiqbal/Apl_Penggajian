Imports System.Data.Odbc

Public Class Form1
    Sub TampilGrid()
        Call koneksi()
        da = New OdbcDataAdapter("select nip, nama, jenis_kelamin, alamat, no_rek, jabatan, tgl_masuk From tb_pegawai", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tb_pegawai")
        DataGridView1.DataSource = ds.Tables("tb_pegawai")
        DataGridView1.Columns("nama").Width = 200
        DataGridView1.Columns("alamat").Width = 300
        DataGridView1.ReadOnly = True
    End Sub

    Sub TampilCombo()
        cbJabatan.Items.Add("Teknisi")
        cbJabatan.Items.Add("Keuangan")
        cbJabatan.Items.Add("Perhubungan")
        cbJabatan.Items.Add("Sekertaris")

    End Sub

    Sub KosongData()
        txtNIP.Text = ""
        txtNama.Text = ""
        cbJabatan.Text = ""
        rbLaki.Checked = False
        rbPerempuan.Checked = False
        txtAlamat.Text = ""
        txtRek.Text = ""
        dtpTanggal.Text = ""
    End Sub

    Sub simpan_primary()
        Dim jk As String
        If rbLaki.Checked = True Then
            jk = rbLaki.Text
        Else
            jk = rbPerempuan.Text
        End If
        If txtNIP.Text = "" Or txtNama.Text = "" Or txtAlamat.Text = "" Or cbJabatan.Text = "" Or jk = "" Or txtRek.Text = "" Then
            MsgBox("Data yang diinput tidak boleh kosong !")
        Else
            Call koneksi()
            Dim input As String = "INSERT INTO `tb_pegawai` ( nip, nama, jenis_kelamin, alamat, no_rek, jabatan, tgl_masuk, tgl_transfer) VALUES ('" & txtNIP.Text & "', '" & txtNama.Text & "', '" & jk & "', '" & txtAlamat.Text & "', '" & txtRek.Text & "', '" & cbJabatan.Text & "', '" & Format(dtpTanggal.Value, "yyyy-MM-dd") & "', '" & Format(Now, "yyyy-MM-dd") & "')"
            cmd = New OdbcCommand(input, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil diinput")
            Call TampilGrid()
            Call KosongData()
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call TampilGrid()
        Call TampilCombo()
        Call KosongData()
    End Sub

    Private Sub btnKembali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKembali.Click
        FormHome.Show()
        Me.Close()
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        Try
            Call simpan_primary()
        Catch ex As Exception
            MsgBox("NIP tidak bisa sama")
        End Try
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim jk As String
        If rbLaki.Checked = True Then
            jk = rbLaki.Text
        Else
            jk = rbPerempuan.Text
        End If

        If txtNIP.Text = "" Or txtNama.Text = "" Or txtAlamat.Text = "" Or cbJabatan.Text = "" Or jk = "" Or txtRek.Text = "" Then
            MsgBox("Data yang diinput tidak boleh kosong !")
        Else
            btnSimpan.Enabled = False
            Call koneksi()
            Dim update As String = "UPDATE `tb_pegawai` SET nip = '" & txtNIP.Text & "', nama = '" & txtNama.Text & "', jenis_kelamin = '" & jk & "', alamat = '" & txtAlamat.Text & "', no_rek = '" & txtRek.Text & "', jabatan = '" & cbJabatan.Text & "', tgl_masuk = '" & Format(dtpTanggal.Value, "yyyy-MM-dd") & "', tgl_transfer = '" & Format(Now, "yyyy-MM-dd") & "' WHERE id = '" & lblId.Text & "'"
            cmd = New OdbcCommand(update, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil diupdate")
            Call TampilGrid()
            Call KosongData()
            btnSimpan.Enabled = True
        End If
    End Sub

    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click 
        Call koneksi()
        cmd = New OdbcCommand("SELECT * FROM tb_pegawai WHERE nip = '" & txtNIP.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            MsgBox("Data tidak ditemukan")
            txtNIP.Focus()
        Else
            btnHapus.Enabled = True
            txtNama.Enabled = True
            txtRek.Enabled = True
            txtAlamat.Enabled = True
            txtRek.Enabled = True
            cbJabatan.Enabled = True
            dtpTanggal.Enabled = True

            txtNIP.Text = rd.Item("nip")
            txtNama.Text = rd.Item("nama")
            If rd.Item("jenis_kelamin") = "Laki-laki" Then
                rbLaki.Checked = True
            Else
                rbPerempuan.Checked = True
            End If
            txtAlamat.Text = rd.Item("alamat")
            txtRek.Text = rd.Item("no_rek")
            cbJabatan.Text = rd.Item("jabatan")
            dtpTanggal.Value = rd.Item("tgl_masuk")
            lblId.Text = rd.Item("id")
            txtNIP.Focus()
            End If
    End Sub


    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        If txtNIP.Text = "" Then
            MsgBox("Kolom NIP tidak boleh kosong !")
        Else
            If MessageBox.Show("Apakah anda yakin ingin menghapus data " & txtNama.Text & " ?", "Konfirmasi Hapus Data", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Call koneksi()
                cmd = New OdbcCommand("DELETE FROM tb_pegawai WHERE id = '" & lblId.Text & "'", conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data berhasil dihapus")
                Call TampilGrid()
                Call KosongData()
            End If
        End If
    End Sub

    Private Sub EditDataPegawaiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditDataPegawaiToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub UpdatePenggajianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdatePenggajianToolStripMenuItem.Click
        Me.Close()
        Form2.Show()
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

        txtNIP.Text = DataGridView1.CurrentRow.Cells(0).Value
        txtNama.Text = DataGridView1.CurrentRow.Cells(1).Value
        txtRek.Text = DataGridView1.CurrentRow.Cells(2).Value

        txtAlamat.Text = DataGridView1.CurrentRow.Cells(3).Value
        txtRek.Text = DataGridView1.CurrentRow.Cells(4).Value
        cbJabatan.Text = DataGridView1.CurrentRow.Cells(5).Value
        dtpTanggal.Text = DataGridView1.CurrentRow.Cells(6).Value

        btnHapus.Enabled = False
        txtNama.Enabled = False
        txtRek.Enabled = False
        txtAlamat.Enabled = False
        txtRek.Enabled = False
        cbJabatan.Enabled = False
        dtpTanggal.Enabled = False

    End Sub
End Class