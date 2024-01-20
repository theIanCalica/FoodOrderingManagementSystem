Public Class prodaddCategoryform
    Private prodcategory As New prodCategory
    Private isDragging As Boolean
    Private clickPoint As Point
    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        Dim categorydescription As String = ""
        If String.IsNullOrWhiteSpace(txtCategory.Text) Then
            CustomMessageBox.Show("Category is required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            categorydescription = txtCategory.Text
        End If
        prodcategory.add(categorydescription)
    End Sub

    Private Sub cmdAdd_MouseHover(sender As Object, e As EventArgs) Handles cmdAdd.MouseHover
        cmdAdd.BackColor = Color.FromArgb(107, 83, 255)
        cmdAdd.ForeColor = Color.White
    End Sub

    Private Sub cmdAdd_MouseLeave(sender As Object, e As EventArgs) Handles cmdAdd.MouseLeave
        cmdAdd.BackColor = Color.White
        cmdAdd.ForeColor = Color.DimGray
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
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