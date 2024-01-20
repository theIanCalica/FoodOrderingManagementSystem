Public Class addProductForm
    Private productModule As New product
    Private currentbtn As Button
    Private selectedProdCategoryID As Integer

    Private Sub CmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click

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
        If String.IsNullOrWhiteSpace(cmbProductType.Text) Then
            CustomMessageBox.Show("Product type is required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmbProductType.Focus()
            Exit Sub
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



        '
        'Calls the function from Productmodule And the highlightbutton sub routine from this form
        productModule.AddRecord(productDescription, price, selectedProdCategoryID, quantity)
        ClearAddForm()
    End Sub


    Private Sub AddProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        productModule.PopulateComboBox()

        AddHandler cmbProductType.SelectedIndexChanged, AddressOf cmbProductType_SelectedIndexChanged
    End Sub

    Private Sub CmbProductType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProductType.SelectedValueChanged
        selectedProdCategoryID = CInt(cmbProductType.SelectedValue)
    End Sub

    Private Sub ClearAddForm()
        txtProduct.Clear()
        cmbProductType.Text = ""
        txtPrice.Clear()
        txtQuantity.Clear()
        txtPrice.Clear()
    End Sub
End Class