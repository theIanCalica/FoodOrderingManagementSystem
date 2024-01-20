Public Class EditProductForm
    Public selectedProductID As Integer
    Private selectedCategoryID As Integer
    Private product As New Product
    Private Sub EditProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        product.PopulateComboBox()

    End Sub

    Private Sub cmbProductType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboProductType.SelectionChangeCommitted
        Dim a As Integer = comboProductType.SelectedValue
        MessageBox.Show(a)
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        Dim productDescription As String
        Dim price As Decimal
        Dim quantity As Integer

        'Checks if the txtProduct is null
        If String.IsNullOrWhiteSpace(txtProduct.Text) Then
            CustomMessageBox.Show("Product is required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtProduct.Focus()
            Exit Sub
        Else
            productDescription = txtProduct.Text
        End If

        'Checks if the txtProductType is null
        If String.IsNullOrWhiteSpace(comboProductType.Text) Then
            CustomMessageBox.Show("Product type is required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboProductType.Focus()
            Exit Sub
        Else
            selectedCategoryID = comboProductType.SelectedValue
        End If

        'Checks if the txtPrice is null
        If String.IsNullOrWhiteSpace(txtPrice.Text) Then
            CustomMessageBox.Show("Price is required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPrice.Focus()
            Exit Sub
        ElseIf Not Integer.TryParse(txtPrice.Text, price) Then
            price = CDec(txtPrice.Text)
        End If

        'Checks if the txtQuantity is NOTHING
        If String.IsNullOrWhiteSpace(txtQuantity.Text) Then
            CustomMessageBox.Show("Quantity is required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtQuantity.Focus()
            Exit Sub
        ElseIf Not Integer.TryParse(txtQuantity.Text, quantity) Then
            CustomMessageBox.Show("Quantity should be a valid number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
    End Sub

    Private Sub comboProductType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboProductType.SelectedIndexChanged
        MessageBox.Show(comboProductType.SelectedValue)
    End Sub
End Class