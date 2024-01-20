Imports System.IO
Imports System.Windows
Imports MySql.Data.MySqlClient

Public Class prodCategory
    Inherits DbConnection

    Public dtCategory As New DataTable()
    Public Function load() As DataTable
        Dim dtCategory As New DataTable
        Dim query As String = "SELECT * FROM prodCategory"
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim adapter As New MySqlDataAdapter(query, conn)
                adapter.Fill(dtCategory)
            End Using
        Catch ex As Exception
            CustomMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dtCategory
    End Function

    Public Function search(searchString As String) As DataTable
        Dim prodcategoryDT As New DataTable
        Dim query As String = "SELECT * FROM prodCategory WHERE prodCategoryDescription LIKE '%" + searchString + "%';"

        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim adapter As New MySqlDataAdapter(query, conn)
                adapter.Fill(prodcategoryDT)
            End Using
        Catch ex As MySqlException
            CustomMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return prodcategoryDT
    End Function

    Public Sub delete(categoryID As Integer)
        Dim query As String = "DELETE FROM prodCategory WHERE prodCategoryID = @categoryID;"
        Try
            Dim rowsAffected As Integer
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim cmd As New MySqlCommand
                With cmd
                    .Connection = conn
                    .CommandText = query
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@categoryID", categoryID)
                End With
                rowsAffected = cmd.ExecuteNonQuery()
                prodcategoryForm.dgvprodCategory.DataSource = load()
                If rowsAffected > 0 Then
                    CustomMessageBox.Show("Successfully Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End Using
        Catch ex As MySqlException
            CustomMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub update(categoryID As Integer, description As String)
        Dim query As String = "UPDATE prodCategory SET prodCategoryDescription = @description WHERE prodCategoryID = @categoryID;"
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim cmd As New MySqlCommand
                Dim rowsAffected As Integer
                With cmd
                    .Connection = conn
                    .CommandText = query
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@description", description)
                    .Parameters.AddWithValue("@categoryID", categoryID)
                End With
                rowsAffected = cmd.ExecuteNonQuery()
                prodcategoryForm.dgvprodCategory.DataSource = load()
                If rowsAffected > 0 Then
                    CustomMessageBox.Show("Successfully Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End Using
        Catch ex As MySqlException
            CustomMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub add(description As String)
        Dim query As String = "INSERT INTO prodCategory(prodCategoryDescription) VALUES(@description);"
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim cmd As New MySqlCommand
                Dim rowsAffected As Integer
                With cmd
                    .Connection = conn
                    .CommandText = query
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@description", description)
                End With
                rowsAffected = cmd.ExecuteNonQuery()
                prodcategoryForm.dgvprodCategory.DataSource = load()
                If rowsAffected > 0 Then
                    CustomMessageBox.Show("Successfully Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End Using
        Catch ex As MySqlException
            CustomMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub LoadtoEdit(categoryID As Integer)
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim query As String = "SELECT * FROM prodCategory WHERE prodCategoryID = @categoryID;"
                Dim cmd As New MySqlCommand

                With cmd
                    .Connection = conn
                    .CommandText = query
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@categoryID", categoryID)
                End With

                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    prodEditcategoryForm.txtCategory.Text = reader("prodCategoryDescription")
                End While
                reader.Close()

            End Using
        Catch ex As MySqlException
            CustomMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
