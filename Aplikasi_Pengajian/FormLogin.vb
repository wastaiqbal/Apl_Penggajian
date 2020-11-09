Imports System.Data.Odbc

Public Class FormLogin
    Private Sub btnMasuk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMasuk.Click
        Call koneksi()
        cmd = New OdbcCommand("SELECT * FROM tb_akun WHERE username = '" & txtUsername.Text & "' AND password='" & txtPassword.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            MsgBox("Username dan Passoword Belum Terdaftar")
            txtUsername.Focus()
        Else
            txtUsername.Text = ""
            txtPassword.Text = ""
            FormHome.Show()
            Me.Hide()
        End If
    End Sub


    Private Sub lblLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblLink.LinkClicked
        Me.Hide()
        FormDaftarAkun.Show()

    End Sub

    Private Sub FormLogin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class