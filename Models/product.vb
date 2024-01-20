Imports System.IO
Imports System.Transactions
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Crypto

Public Class Product
    Inherits DbConnection
    Public Property DtProducts As New DataTable()

    Public Sub New()
        dtProducts.Columns.Add("ProductID", GetType(Integer))
        dtProducts.Columns.Add("ProdDescription", GetType(String))
        dtProducts.Columns.Add("ProductType", GetType(String))
        dtProducts.Columns.Add("Price", GetType(Decimal))

    End Sub

    Public Function LoadProductData() As DataTable
        Dim dtProducts As New DataTable()

        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                dtProducts.Clear()
                Dim query As String = "SELECT p.ProductID, p.prodDescription,pc.prodCategoryDescription,p.price, s.quantity FROM product p 
                                       INNER JOIN prodCategory pc ON(p.prodCategoryID = pc.prodCategoryID) INNER JOIN stock s ON(s.productID = p.productID) ORDER BY p.ProductID;"

                Dim adapter As New MySqlDataAdapter(query, conn)
                adapter.Fill(dtProducts)
            End Using

        Catch ex As MySqlException
            CustomMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dtProducts
    End Function

    Public Sub AddRecord(prodDescription As String, price As Decimal, productType As Integer, quantity As Integer)

        Dim transaction As MySqlTransaction
        Dim conn As MySqlConnection = Nothing
        Try
            conn = GetConnection()
            conn.Open()
            Using cmd As New MySqlCommand
                transaction = conn.BeginTransaction()
                cmd.Transaction = transaction
                Dim query As String = "INSERT INTO product(prodDescription, price, prodCategoryID) VALUES(@prodDescription, @price, @productType)"
                Dim rowsAffected As Integer
                With cmd
                    .Connection = conn
                    .CommandText = query
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@prodDescription", prodDescription)
                    .Parameters.AddWithValue("@productType", productType)
                    .Parameters.AddWithValue("@price", price)
                End With

                rowsAffected += cmd.ExecuteNonQuery()
                cmd.Parameters.Clear()
                query = "INSERT INTO stock(productID, quantity) VALUES(last_insert_id(), @quantity);"

                With cmd
                    .CommandText = query
                    .Parameters.AddWithValue("@quantity", quantity)
                End With
                rowsAffected += cmd.ExecuteNonQuery()
                productForm.dgvProducts.DataSource = LoadProductData()
                If rowsAffected > 0 Then
                    CustomMessageBox.Show("Successfully Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                transaction.Commit()

            End Using
        Catch ex As MySqlException
            transaction.Rollback()
            CustomMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Subroutine to load the records to textbox and picturebox
    Public Sub LoadtoEdit(productID As Integer)
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim query As String = "SELECT p.prodDescription,p.prodCategoryID,p.price,s.quantity FROM product p 
                                       INNER JOIN prodCategory pc ON(p.prodCategoryID = pc.prodCategoryID) 
                                       INNER JOIN stock s ON(p.productID = s.productID) WHERE p.productID = @productID;"
                Dim cmd As New MySqlCommand

                With cmd
                    .Connection = conn
                    .CommandText = query
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@productID", productID)
                End With

                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    editProductForm.txtProduct.Text = reader("prodDescription").ToString()
                    EditProductForm.comboProductType.SelectedValue = CInt(reader("prodCategoryID"))
                    EditProductForm.txtPrice.Text = reader("price").ToString()
                    EditProductForm.txtQuantity.Text = reader("quantity").ToString()
                Else
                    CustomMessageBox.Show("No data found for the specified product ID.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                reader.Close()
            End Using
        Catch ex As MySqlException
            CustomMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub UpdateProduct(productID As Integer, productDescription As String, prodCategoryID As Integer, price As Decimal)

        Dim query As String = "UPDATE product SET prodDescription = @productDescription, price = @price, prodCategoryID = @prodCategoryID WHERE productID = @productID;"

        Try

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim cmd As New MySqlCommand

                With cmd
                    .Connection = conn
                    .CommandText = query
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@productID", productID)
                    .Parameters.AddWithValue("@productDescription", productDescription)
                    .Parameters.AddWithValue("@prodCategoryID", prodCategoryID)
                    .Parameters.AddWithValue("@price", price)

                End With
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                productForm.dgvProducts.DataSource = LoadProductData()
                If rowsAffected > 0 Then
                    CustomMessageBox.Show("Successfully Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using

        Catch ex As MySqlException
            CustomMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub DeleteProduct(productID As Integer)
        Try
            Using conn As MySqlConnection = GetConnection()
                Dim cmd As New MySqlCommand
                Dim rowsAffected As Integer
                conn.Open()
                Dim query As String = "DELETE FROM product WHERE productID = @productID;"
                With cmd
                    .Connection = conn
                    .CommandText = query
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@productID", productID)
                End With

                rowsAffected = cmd.ExecuteNonQuery()
                productForm.dgvProducts.DataSource = LoadProductData()
                If rowsAffected > 0 Then
                    CustomMessageBox.Show("Sucessfully deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If


            End Using

        Catch ex As MySqlException
            CustomMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub PopulateComboBox()
        Dim query As String = "SELECT * FROM prodCategory"
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim dataSet As New DataSet()

                adapter.Fill(dataSet, "prodCategory")
                addProductForm.cmbProductType.DisplayMember = "prodCategoryDescription"
                addProductForm.cmbProductType.ValueMember = "prodCategoryID"
                addProductForm.cmbProductType.DataSource = dataSet.Tables("prodCategory")
                EditProductForm.comboProductType.DisplayMember = "prodCategoryDescription"
                EditProductForm.comboProductType.ValueMember = "prodCategoryID"
                EditProductForm.comboProductType.DataSource = dataSet.Tables("prodCategory")
            End Using
        Catch ex As MySqlException
            CustomMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
