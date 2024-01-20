Imports System.IO

Public Class StaffForm
    Private staff As New staff
    Public selectedStaffID As Integer
    Private clickPoint As Point
    Private isDragging As Boolean = False

    Private Sub StaffForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvStaff.DataSource = staff.load()
        staff.PopulateComboBox()
        ' Create a DataGridViewImageColumn for "Edit" button
        Dim editButtonColumn As New DataGridViewImageColumn With {
            .HeaderText = "Edit",
            .Image = My.Resources.pencil,
            .Name = "Edit",
            .ImageLayout = DataGridViewImageCellLayout.Zoom
        }
        dgvStaff.Columns.Add(editButtonColumn)

        ' Create a DataGridViewImageColumn for "Delete" button
        Dim deleteButtonColumn As New DataGridViewImageColumn With {
            .HeaderText = "Delete",
            .Image = My.Resources.recycle_bin,
            .ImageLayout = DataGridViewImageCellLayout.Zoom,
            .Name = "Delete"
        }
        dgvStaff.Columns.Add(deleteButtonColumn)
    End Sub

    Private Sub CmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        addStaffForm.Show()
    End Sub

    Private Sub DgvStaff_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStaff.CellClick


        If e.RowIndex >= 0 AndAlso e.ColumnIndex = dgvStaff.Columns("Edit").Index Then
            selectedStaffID = CInt(dgvStaff.Rows(e.RowIndex).Cells("staffID").Value)

            staff.LoadtoEdit(selectedStaffID)
            editStaffForm.selectedstaffID = selectedStaffID
            editStaffForm.Show()

        ElseIf e.RowIndex >= 0 AndAlso e.ColumnIndex = dgvStaff.Columns("Delete").Index Then
            selectedStaffID = CInt(dgvStaff.Rows(e.RowIndex).Cells("staffID").Value)
            staff.deleteStaff(selectedStaffID)
            dgvStaff.DataSource = staff.load()

        End If
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        dgvStaff.DataSource = staff.search(txtSearch.Text.TrimEnd)
    End Sub

    Private Sub CmdAdd_MouseHover(sender As Object, e As EventArgs) Handles cmdAdd.MouseHover
        cmdAdd.BackColor = Color.FromArgb(107, 83, 255)
        cmdAdd.IconColor = Color.White
    End Sub

    Private Sub CmdAdd_MouseLeave(sender As Object, e As EventArgs) Handles cmdAdd.MouseLeave
        cmdAdd.BackColor = Color.White
        cmdAdd.IconColor = Color.DarkOrchid
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