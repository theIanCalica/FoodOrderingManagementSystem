Public Class prodEditcategoryForm
    Private prodCategory As New prodCategory
    Public selectedProdCategoryID As Integer
    Private isDragging As Boolean
    Private clickPoint As Point
    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim categoryDes As String = ""
        Dim categoryID As Integer = prodcategoryForm.prodcategoryID
        If String.IsNullOrWhiteSpace(txtCategory.Text) Then
            CustomMessageBox.Show("Category is required")
            Exit Sub
        Else
            categoryDes = txtCategory.Text
        End If

        prodCategory.update(categoryID, categoryDes)
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_MouseHover(sender As Object, e As EventArgs) Handles cmdSave.MouseHover
        cmdSave.BackColor = Color.FromArgb(107, 83, 255)
        cmdSave.ForeColor = Color.White
    End Sub

    Private Sub cmdSave_MouseLeave(sender As Object, e As EventArgs) Handles cmdSave.MouseLeave
        cmdSave.BackColor = Color.White
        cmdSave.ForeColor = Color.DimGray
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
End Class