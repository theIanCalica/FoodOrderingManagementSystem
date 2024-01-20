Imports CrystalDecisions.[Shared].Json
Imports Org.BouncyCastle.Math.EC.Custom

Public Class editStaffForm
    Private staff As New staff
    Private DOB As Date
    Private hireDate As Date
    Public selectedstaffID As Integer
    Private isDragging As Boolean = False
    Private clickPoint As Point
    Private Sub EditStaffForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DOB = dtpDOB.Value.Date
        hireDate = dtpHiredate.Value.Date
        dtpHiredate.Format = DateTimePickerFormat.Custom
        dtpHiredate.CustomFormat = "MMMM/dd/yyyy" ' Month name, day, and year format
        dtpDOB.Format = DateTimePickerFormat.Custom
        dtpDOB.CustomFormat = "MMMM/dd/yyyy"  ' Month name, day, and year format
    End Sub

    Private Sub CmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        Dim firstName As String
        Dim lastName As String
        Dim staffCategoryID As Integer
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

        If String.IsNullOrWhiteSpace(cmbStaffCategory.Text) Then
            cmbStaffCategory.Focus()
            CustomMessageBox.Show("Staff Category is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            staffCategoryID = cmbStaffCategory.SelectedIndex()
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

        staff.editStaff(selectedstaffID, firstName, lastName, staffCategoryID, phoneNo, DOB, hireDate)
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Me.Close()
    End Sub

    Private Sub CmdAdd_MouseHover(sender As Object, e As EventArgs) Handles cmdEdit.MouseHover
        cmdEdit.BackColor = Color.FromArgb(107, 83, 255)
        cmdEdit.ForeColor = Color.White
    End Sub

    Private Sub CmdAdd_MouseLeave(sender As Object, e As EventArgs) Handles cmdEdit.MouseLeave
        cmdEdit.BackColor = Color.White
        cmdEdit.ForeColor = Color.DimGray
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


End Class