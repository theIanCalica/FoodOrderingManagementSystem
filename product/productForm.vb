Public Class ProductForm
    Private productModule As New product
    Public productID As Integer
    Private clickPoint As Point
    Private isDragging As Boolean

    Private Sub Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvProducts.DataSource = productModule.LoadProductData()
        'Create a datagridviewimagecolumn for "Edit"
        Dim editButtonColumn As New DataGridViewImageColumn With {
            .HeaderText = "Edit",
            .Image = My.Resources.pencil,
            .Name = "Edit",
            .ImageLayout = DataGridViewImageCellLayout.Zoom
        }
        dgvProducts.Columns.Add(editButtonColumn)

        ' Create a DataGridViewButtonColumn for "Delete" button
        Dim deleteButtonColumn As New DataGridViewImageColumn With {
            .HeaderText = "Delete",
            .Image = My.Resources.recycle_bin,
            .Name = "Delete",
            .ImageLayout = DataGridViewImageCellLayout.Zoom
        }
        dgvProducts.Columns.Add(deleteButtonColumn)
    End Sub

    Private Sub DgvProducts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellClick
        If e.RowIndex >= 0 Then
            ' Handle the "Edit" button click
            If e.ColumnIndex = dgvProducts.Columns("Edit").Index Then
                Dim productID As Integer = CInt(dgvProducts.Rows(e.RowIndex).Cells("ProductID").Value)
                editProductForm.Show()
                editProductForm.selectedProductID = productID
                productModule.LoadtoEdit(productID)
            End If

            ' Handle the "Delete" button click
            If e.ColumnIndex = dgvProducts.Columns("Delete").Index Then
                Dim productID As Integer = CInt(dgvProducts.Rows(e.RowIndex).Cells("ProductID").Value)
                productModule.deleteProduct(productID)
            End If
        End If
    End Sub

    Private Sub CmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        addProductForm.Show()
    End Sub

    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub DgvProducts_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgvProducts.CellPainting
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            dgvProducts.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        End If

        If e.RowIndex = -1 AndAlso e.ColumnIndex >= 0 Then
            e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End If
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