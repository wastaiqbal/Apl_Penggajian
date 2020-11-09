Imports System.Data.Odbc

Module ModuleKoneksi
    Public conn As OdbcConnection
    Public da As OdbcDataAdapter
    Public ds As DataSet
    Public cmd As OdbcCommand
    Public rd As OdbcDataReader
    Public str As String

    Public Sub koneksi()
        str = "Driver={MYSQL ODBC 3.51 Driver};database=apl_penggajian;server=localhost;uid=root"
        conn = New OdbcConnection(str)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

End Module
