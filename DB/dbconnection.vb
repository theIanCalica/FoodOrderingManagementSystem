Imports MySql.Data.MySqlClient

Public MustInherit Class DbConnection

    Private ReadOnly connectionString As String = "Server=localhost;Database=dbJojimis;User ID=root;Password=;"
    Protected Function GetConnection() As MySqlConnection
        Return New MySqlConnection(connectionString)
    End Function
End Class
