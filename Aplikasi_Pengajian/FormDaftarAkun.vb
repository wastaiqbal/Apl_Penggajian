Imports System.Data.Odbc

Public Class FormDaftarAkun

    Private Sub btnDaftar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDaftar.Click
        If txtNama.Text = "" Or txtEmail.Text = "" Or txtUPassword.Text = "" Or txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Data yang diinput harus lengkap !")
        Else
            If txtPassword.Text = txtUPassword.Text Then
                Call koneksi()
                Dim input As String = "INSERT INTO `tb_akun` (nama, email, username, password) VALUES ('" & txtNama.Text & "', '" & txtEmail.Text & "', '" & txtUsername.Text & "', '" & txtUPassword.Text & "')"
                cmd = New OdbcCommand(input, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Berhasil terdaftar !")
                FormLogin.Show()
                Me.Close()
            Else
                MsgBox("Password yang dimasukan berbeda")
            End If
        End If
    End Sub

    Private Sub brnKembali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brnKembali.Click
        FormLogin.Show()
        Me.Close()
    End Sub

    Private Sub FormDaftarAkun_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class