Public Class editStaffCategoryForm
    Private staffCategory As New staffCategory
    Public selectedStaffCategoryID As Integer
    Private isDragging As Boolean
    Private clickPoint As Point
    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        Dim staffCategoryname As String
        If String.IsNullOrWhiteSpace(txtStaffCategoryName.Text) Then
            CustomMessageBox.Show("Staff Category Name is required")
            Exit Sub
        Else
            staffCategoryname = txtStaffCategoryName.Text.TrimEnd
        End If

        staffCategory.update(selectedStaffCategoryID, staffCategoryname)
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

    Private Sub cmdEdit_MouseHover(sender As Object, e As EventArgs) Handles cmdEdit.MouseHover
        cmdEdit.BackColor = Color.FromArgb(107, 83, 255)
        cmdEdit.ForeColor = Color.White
    End Sub

    Private Sub cmdEdit_MouseLeave(sender As Object, e As EventArgs) Handles cmdEdit.MouseLeave
        cmdEdit.BackColor = Color.White
        cmdEdit.ForeColor = Color.DimGray
    End Sub
End Class