Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports System.IO
Imports System.Text.RegularExpressions

Public Class Staff
    Inherits DbConnection
    Public Function Load() As DataTable
        Dim dtStaff As New DataTable()
        Try

            Dim query As String = "SELECT s.staffID, s.fName as FirstName, s.lName as LastName, sc.staffCategoryname as StaffCategory, s.phoneNo as PhoneNo,
                       s.DOB, s.hireDate as HireDate FROM staff s INNER JOIN staffCategory sc ON(s.staffCategoryID = sc.staffCategoryID);"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim adapter As New MySqlDataAdapter(query, conn)
                adapter.Fill(dtStaff)
            End Using
        Catch ex As MySqlException
            CustomMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dtStaff
    End Function

    Public Sub AddStaff(fname As String, lname As String, staffCategoryID As Integer, phoneNo As String, DOB As Date, hireDate As Date)
        Dim query As String = "INSERT INTO staff(fName,lName,staffCategoryID,phoneNo,DOB,hireDate) VALUES(@fName,@lName,@staffCategoryID,@phoneNo,@DOB,@hireDate);"
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim cmd As New MySqlCommand
                Dim rowsAffected As Integer
                With cmd
                    .Connection = conn
                    .CommandText = query
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@fName", fname)
                    .Parameters.AddWithValue("@lName", lname)
                    .Parameters.AddWithValue("@staffCategoryID", staffCategoryID)
                    .Parameters.AddWithValue("@phoneNo", phoneNo)
                    .Parameters.AddWithValue("@DOB", DOB)
                    .Parameters.AddWithValue("@hireDate", hireDate)
                End With
                rowsAffected = cmd.ExecuteNonQuery()
                StaffForm.dgvStaff.DataSource = load()
            End Using
        Catch ex As MySqlException
            CustomMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub EditStaff(staffID As Integer, fname As String, lname As String, staffCategoryID As Integer, phoneNo As String, DOB As Date, hireDate As Date)
        Dim query As String = "UPDATE staff SET fName = @fName,lName = @lName, staffCategoryID = @staffCategoryID, phoneNo = @phoneNo, DOB = @DOB, hireDate = @hireDate,
                              WHERE staffID = @staffID;"
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim cmd As New MySqlCommand

                With cmd
                    .Connection = conn
                    .CommandText = query
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@fName", fname)
                    .Parameters.AddWithValue("@lName", lname)
                    .Parameters.AddWithValue("@staffCategoryID", staffCategoryID)
                    .Parameters.AddWithValue("@phoneNo", phoneNo)
                    .Parameters.AddWithValue("@DOB", DOB)
                    .Parameters.AddWithValue("@hireDate", hireDate)
                    .Parameters.AddWithValue("@staffID", staffID)
                End With
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    CustomMessageBox.Show("Successfully updated", "Edit staff", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        Catch ex As Exception
            CustomMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub DeleteStaff(staffID As Integer)
        Dim query As String = "DELETE FROM staff WHERE staffID = @staffID;"
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim cmd As New MySqlCommand
                With cmd
                    .Connection = conn
                    .CommandText = query
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@staffID", staffID)
                End With
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    CustomMessageBox.Show("Successfully deleted", "Delete staff", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        Catch ex As Exception
            CustomMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub LoadtoEdit(staffID As Integer)
        Dim query As String = "SELECT fName, lName, staffCategoryID, phoneNo, DOB, hireDate FROM staff WHERE staffID = @staffID;"

        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim cmd As New MySqlCommand
                With cmd
                    .Connection = conn
                    .CommandText = query
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@staffID", staffID)
                End With
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                While reader.Read()
                    editStaffForm.txtFirstname.Text = reader("fName").ToString()
                    editStaffForm.txtLastname.Text = reader("lName").ToString()
                    editStaffForm.cmbStaffCategory.SelectedValue = CInt(reader("staffCategoryID")) ' Update this line
                    editStaffForm.cmbStaffCategory.Refresh()
                    editStaffForm.txtPhoneno.Text = reader("phoneNo").ToString()
                    editStaffForm.dtpDOB.Value = Convert.ToDateTime(reader("DOB"))
                    editStaffForm.dtpHiredate.Value = Convert.ToDateTime(reader("hireDate"))
                End While
                reader.Close()
            End Using
        Catch ex As MySqlException
            CustomMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub PopulateComboBox()
        Dim query As String = "SELECT * FROM staffCategory"
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim dataSet As New DataSet()

                adapter.Fill(dataSet, "staffCategory")
                addStaffForm.cmbStaffcategory.DisplayMember = "staffCategoryname"
                addStaffForm.cmbStaffcategory.ValueMember = "staffCategoryID"
                addStaffForm.cmbStaffcategory.DataSource = dataSet.Tables("staffCategory")

                editStaffForm.cmbStaffCategory.DisplayMember = "staffCategoryname"
                editStaffForm.cmbStaffCategory.ValueMember = "staffCategoryID"
                editStaffForm.cmbStaffCategory.DataSource = dataSet.Tables("staffCategory")
            End Using
        Catch ex As Exception
            CustomMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function IsPhilippinePhoneNumber(phoneNumber As String) As Boolean
        ' Use regular expression to check if the phone number is valid.
        ' It should match either "09XXXXXXXXX" or "+639XXXXXXXXX" format.
        Dim regex As New Regex("^(09|(\+639))(?<!\+6399)\d{9}$")

        ' Return True if the phone number matches the pattern, False otherwise.
        Return regex.IsMatch(phoneNumber)
    End Function

    Public Function Search(searchString As String) As DataTable
        Dim staffDT As New DataTable
        Try
            Dim query As String = "SELECT s.fName as FirstName,s.lName as LastName,sc.staffCategoryname as StaffCategory,s.phoneNo as PhoneNo,s.DOB,
                                   s.hireDate AS HireDate FROM staff s INNER JOIN staffCategory sc ON(s.staffCategoryID = sc.staffCategoryID) 
                                   WHERE s.fName LIKE '%" + searchString + "%' OR s.lName LIKE '%" + searchString + "%';"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim adapter As New MySqlDataAdapter(query, conn)
                adapter.Fill(staffDT)
            End Using
        Catch ex As MySqlException
            CustomMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return staffDT
    End Function
End Class
