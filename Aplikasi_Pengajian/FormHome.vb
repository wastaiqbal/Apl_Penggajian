Public Class FormHome

    Private Sub EditDataPegawaiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditDataPegawaiToolStripMenuItem.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub UpdatePenggajianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdatePenggajianToolStripMenuItem.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        If MessageBox.Show("Apakah Anda Yakin Ingin Keluar ?", "Keluar Aplikasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            FormLogin.Close()
        End If
    End Sub

    Private Sub HomeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub PenggajianToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles PenggajianToolStripMenuItem1.Click
        cr.ReportFileName = "Report1.rpt"
        cr.WindowState = Crystal.WindowStateConstants.crptMaximized
        cr.RetrieveDataFiles()
        cr.Action = 1
    End Sub

    Private Sub DataToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DataToolStripMenuItem.Click
        Me.Hide()
        Form3.Show()
    End Sub
End Class