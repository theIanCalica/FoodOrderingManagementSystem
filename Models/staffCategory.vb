Imports System.Web.Configuration
Imports MySql.Data.MySqlClient

Public Class staffCategory
    Inherits DbConnection
    Public Function load() As DataTable
        Dim query As String = "SELECT * FROM staffCategory;"
        Dim stCategoryDT As New DataTable
        Try
            Using conn As MySqlConnection = GetConnection()
                Dim adapter As New MySqlDataAdapter(query, conn)
                adapter.Fill(stCategoryDT)
            End Using
        Catch ex As MySqlException
            CustomMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return stCategoryDT
    End Function

    Public Sub addCategory(staffCategoryname As String)
        Dim query As String = "INSERT INTO staffCategory(staffCategoryname) VALUES(@staffCategoryname);"
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim cmd As New MySqlCommand
                Dim rowsAffected As Integer
                With cmd
                    .Connection = conn
                    .CommandText = query
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@staffCategoryname", staffCategoryname)
                End With

                rowsAffected = cmd.ExecuteNonQuery
                If rowsAffected > 0 Then
                    CustomMessageBox.Show("Successfully Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                staffCategoryForm.dgvStaffCategory.DataSource = load()
            End Using
        Catch ex As Exception
            CustomMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub update(staffCategoryID As Integer, staffCategoryname As String)
        Dim query As String = "UPDATE staffCategory SET staffCategoryname = @staffCategoryname WHERE staffCategoryID = @staffCategoryID;"
        Dim rowsAffected As Integer

        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim cmd As New MySqlCommand

                With cmd
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Connection = conn
                    .Parameters.AddWithValue("@staffCategoryID", staffCategoryID)
                    .Parameters.AddWithValue("@staffCategoryname", staffCategoryname)
                End With

                rowsAffected = cmd.ExecuteNonQuery

                If rowsAffected > 0 Then
                    CustomMessageBox.Show("Successfully updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                staffCategoryForm.dgvStaffCategory.DataSource = load()
            End Using

        Catch ex As mysqlException
            CustomMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub delete(staffCategoryID As Integer)
        Dim query As String = "DELETE FROM staffCategory WHERE staffCategoryID = @staffCategoryID;"
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim cmd As New MySqlCommand
                Dim rowsAffected As Integer

                With cmd
                    .CommandText = query
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@staffCategoryID", staffCategoryID)
                End With

                rowsAffected = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    CustomMessageBox.Show("Successfully deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                staffCategoryForm.dgvStaffCategory.DataSource = load()
            End Using
        Catch ex As MySqlException
            CustomMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub loadtoEdit(staffCategoryID As Integer)
        Dim query As String = "SELECT * FROM staffCategory WHERE staffCategoryID = @staffCategoryID;"
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Dim cmd As New MySqlCommand

            With cmd
                .CommandText = query
                .Connection = conn
                .CommandType = CommandType.Text
                .Parameters.AddWithValue("@staffCategoryID", staffCategoryID)
            End With

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                editStaffCategoryForm.txtStaffCategoryName.Text = reader("staffCategoryname")
            End While

            reader.Close()

        End Using
    End Sub

    Public Function search(searchString As String) As DataTable
        Dim staffCategoryDT As New DataTable
        Dim query As String = "SELECT * FROM staffCategory WHERE staffCategoryname LIKE '%" + searchString + "%';"
        Try
            Using conn As MySqlConnection = GetConnection()
                Dim adapter As New MySqlDataAdapter(query, conn)
                adapter.Fill(staffCategoryDT)
            End Using
        Catch ex As Exception
            CustomMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return staffCategoryDT
    End Function
End Class
