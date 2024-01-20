Public Class addStaffCategoryForm

    Private staffCategory As New staffCategory
    Private isdragging As Boolean
    Private clickPoint As Point

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click

        Dim staffCategoryName As String = Nothing

        If String.IsNullOrWhiteSpace(txtStaffCategoryName.Text) Then
            CustomMessageBox.Show("Staff Category Name is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            staffCategoryName = txtStaffCategoryName.Text.TrimEnd()
        End If

        staffCategory.addCategory(staffCategoryName)
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub editStaffForm_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
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
        cmdAdd.ForeColor = Color.White
    End Sub

    Private Sub cmdAdd_MouseLeave(sender As Object, e As EventArgs) Handles cmdAdd.MouseLeave
        cmdAdd.BackColor = Color.White
        cmdAdd.ForeColor = Color.DimGray
    End Sub
End Class