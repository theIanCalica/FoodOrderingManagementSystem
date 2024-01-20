Public Class staffCategoryForm
    Private staffCategory As New staffCategory
    Private isDragging As Boolean
    Private clickPoint As Point
    Public selectedStaffcategoryID As Integer
    Private Sub staffCategoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvStaffCategory.DataSource = staffCategory.load()
        Dim editButtonColumn As New DataGridViewImageColumn()
        editButtonColumn.HeaderText = "Edit"
        editButtonColumn.Image = My.Resources.pencil
        editButtonColumn.Name = "Edit"
        editButtonColumn.ImageLayout = DataGridViewImageCellLayout.Zoom
        dgvStaffCategory.Columns.Add(editButtonColumn)

        Dim deleteButtonColumn As New DataGridViewImageColumn()
        deleteButtonColumn.HeaderText = "Delete"
        deleteButtonColumn.Image = My.Resources.recycle_bin
        deleteButtonColumn.ImageLayout = DataGridViewImageCellLayout.Zoom
        deleteButtonColumn.Name = "Delete"
        dgvStaffCategory.Columns.Add(deleteButtonColumn)
    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        addStaffCategoryForm.Show()
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub staffCategoryForm_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        isDragging = True
        clickPoint = New Point(e.X, e.Y)
    End Sub

    Private Sub staffCategoryForm_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If isDragging Then
            Dim newPoint As Point = Me.PointToScreen(New Point(e.X, e.Y))
            newPoint.Offset(-clickPoint.X, -clickPoint.Y)
            Me.Location = newPoint
        End If
    End Sub

    Private Sub staffCategoryForm_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        isDragging = False
    End Sub

    Private Sub dgvStaffCategory_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStaffCategory.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = dgvStaffCategory.Columns("Edit").Index Then
            selectedStaffcategoryID = CInt(dgvStaffCategory.Rows(e.RowIndex).Cells("staffCategoryID").Value)
            CustomMessageBox.Show(selectedStaffcategoryID)
            staffCategory.loadtoEdit(selectedStaffcategoryID)
            editStaffCategoryForm.selectedStaffCategoryID = selectedStaffcategoryID
            editStaffCategoryForm.Show()

        ElseIf e.RowIndex >= 0 AndAlso e.ColumnIndex = dgvStaffCategory.Columns("Delete").Index Then
            selectedStaffcategoryID = CInt(dgvStaffCategory.Rows(e.RowIndex).Cells("staffCategoryID").Value)
            staffCategory.delete(selectedStaffcategoryID)

        End If
    End Sub

    Private Sub cmdAdd_MouseHover(sender As Object, e As EventArgs) Handles cmdAdd.MouseHover
        cmdAdd.BackColor = Color.FromArgb(107, 83, 255)
        cmdAdd.IconColor = Color.White
    End Sub

    Private Sub cmdAdd_MouseLeave(sender As Object, e As EventArgs) Handles cmdAdd.MouseLeave
        cmdAdd.BackColor = Color.White
        cmdAdd.IconColor = Color.DarkOrchid
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        dgvStaffCategory.DataSource = staffCategory.search(txtSearch.Text)
    End Sub
End Class