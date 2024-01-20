Imports System.Text.RegularExpressions
Imports System.Windows.Controls

Public Class addStaffForm
    Dim DOB As Date
    Dim hireDate As Date
    Dim filepath As String
    Dim staff As New staff
    Private isDragging As Boolean = False
    Private clickPoint As Point
    Private staffCategoryID As Integer
    Private Sub CmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click

        Dim firstName As String
        Dim lastName As String

        Dim phoneNo As String = ""
        If String.IsNullOrWhiteSpace(txtFirstname.Text) Then
            CustomMessageBox.Show("First name is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtFirstname.Focus()
            Exit Sub
        Else
            firstName = txtFirstname.Text
        End If

        If String.IsNullOrWhiteSpace(txtLastname.Text) Then
            txtLastname.Focus()
            CustomMessageBox.Show("Last name is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            lastName = txtLastname.Text
        End If

        If String.IsNullOrWhiteSpace(cmbStaffcategory.Text) Then
            cmbStaffcategory.Focus()
            CustomMessageBox.Show("Staff Category is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            staffCategoryID = cmbStaffcategory.SelectedValue
        End If

        If Not staff.IsPhilippinePhoneNumber(txtPhoneno.Text.Trim) Then
            CustomMessageBox.Show("Please provide a valid philippine phone number", "Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPhoneno.Clear()
            txtPhoneno.Focus()
            Exit Sub
        ElseIf String.IsNullOrWhiteSpace(txtPhoneno.Text) Then
            txtPhoneno.Focus()
            CustomMessageBox.Show("Phone number is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            phoneNo = txtPhoneno.Text
        End If

        If DOB = Nothing Then
            MessageBox.Show("Date of Birth is required")
            dtpDOB.Focus()
            Exit Sub
        End If

        If hireDate = Nothing Then
            CustomMessageBox.Show("Hire date is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
            dtpHiredate.Focus()
        End If

        staff.AddStaff(firstName, lastName, staffCategoryID, phoneNo, DOB, hireDate)
        staffForm.dgvStaff.DataSource = staff.load()
    End Sub

    Private Sub DtpDOB_ValueChanged(sender As Object, e As EventArgs) Handles dtpDOB.ValueChanged
        DOB = dtpDOB.Value.Date
    End Sub

    Private Sub DtpHiredate_ValueChanged(sender As Object, e As EventArgs) Handles dtpHiredate.ValueChanged
        hireDate = dtpHiredate.Value.Date
    End Sub

    Private Sub AddStaffForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbStaffcategory.Text = Nothing
        txtFirstname.Focus()
    End Sub

    Private Sub CmdAdd_MouseHover(sender As Object, e As EventArgs) Handles cmdAdd.MouseHover
        cmdAdd.BackColor = Color.FromArgb(107, 83, 255)
        cmdAdd.ForeColor = Color.White
    End Sub

    Private Sub CmdAdd_MouseLeave(sender As Object, e As EventArgs) Handles cmdAdd.MouseLeave
        cmdAdd.BackColor = Color.White
        cmdAdd.ForeColor = Color.DimGray
    End Sub

    Private Sub EditStaffForm_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        isDragging = True
        clickPoint = New Point(e.X, e.Y)
    End Sub

    Private Sub EditStaffForm_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If isDragging Then
            Dim newPoint As Point = Me.PointToScreen(New Point(e.X, e.Y))
            newPoint.Offset(-clickPoint.X, -clickPoint.Y)
            Me.Location = newPoint
        End If
    End Sub

    Private Sub EditStaffForm_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        isDragging = False
    End Sub

    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub CmbStaffcategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStaffcategory.SelectedIndexChanged
        staffCategoryID = cmbStaffcategory.SelectedValue
        MessageBox.Show(staffCategoryID)
    End Sub
End Class