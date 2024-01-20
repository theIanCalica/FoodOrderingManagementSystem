Public Class prodcategoryForm
    Private prodcategory As New prodCategory
    Private addCategoryform As New prodaddCategoryform
    Private editCategoryForm As New prodEditcategoryForm
    Public prodcategoryID As Integer
    Private isDragging As Boolean
    Private clickPoint As Point
    Private Sub categoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvProdCategory.DataSource = prodcategory.load()
        ' Create a DataGridViewImageColumn for "Edit" button
        Dim editButtonColumn As New DataGridViewImageColumn()
        editButtonColumn.HeaderText = "Edit"
        editButtonColumn.Image = My.Resources.pencil
        editButtonColumn.Name = "Edit"
        editButtonColumn.ImageLayout = DataGridViewImageCellLayout.Zoom
        dgvProdCategory.Columns.Add(editButtonColumn)

        ' Create a DataGridViewImageColumn for "Delete" button
        Dim deleteButtonColumn As New DataGridViewImageColumn()
        deleteButtonColumn.HeaderText = "Delete"
        deleteButtonColumn.Image = My.Resources.recycle_bin
        deleteButtonColumn.ImageLayout = DataGridViewImageCellLayout.Zoom
        deleteButtonColumn.Name = "Delete"
        dgvProdCategory.Columns.Add(deleteButtonColumn)
    End Sub

    Private Sub dgvCategory_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvprodCategory.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = dgvprodCategory.Columns("Edit").Index Then
            prodcategoryID = CInt(dgvprodCategory.Rows(e.RowIndex).Cells("prodCategoryID").Value)
            Dim description As String = dgvprodCategory.Rows(e.RowIndex).Cells("prodCategoryDescription").Value.ToString()
            prodcategory.LoadtoEdit(prodcategoryID)
            prodEditcategoryForm.Show()
        ElseIf e.RowIndex >= 0 AndAlso e.ColumnIndex = dgvprodCategory.Columns("Delete").Index Then
            prodcategoryID = CInt(dgvprodCategory.Rows(e.RowIndex).Cells("prodCategoryID").Value)
            prodcategory.delete(prodcategoryID)
            dgvprodCategory.DataSource = prodcategory.load()
        End If
    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        addCategoryform.Show()
    End Sub
    Private Sub prodCategoryForm_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        isDragging = True
        clickPoint = New Point(e.X, e.Y)
    End Sub

    Private Sub editStaffForm_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If isDragging Then
            Dim newPoint As Point = Me.PointToScreen(New Point(e.X, e.Y))
            newPoint.Offset(-clickPoint.X, -clickPoint.Y)
            Me.Location = newPoint
        End If
    End Sub

    Private Sub editStaffForm_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        isDragging = False
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
        dgvprodCategory.DataSource = prodcategory.search(txtSearch.Text)
    End Sub

    Private Sub txtSearch_MouseClick(sender As Object, e As MouseEventArgs) Handles txtSearch.MouseClick
        txtSearch.Text = Nothing
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
End Class