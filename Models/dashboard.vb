
Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class Dashboard
    Inherits DbConnection
    Public Structure RevenueByDate
        Public Property [Date] As String
        Public Property TotalAmount As Decimal
    End Structure

    ' Fields & Properties

    Private startDate As DateTime
    Private endDate As DateTime
    Private numberDays As Integer
    Public Property NumCustomers As Integer
    Public Property NumProducts As Integer
    Public Property TopProductsList As List(Of KeyValuePair(Of String, Integer))
    Public Property UnderstockList As List(Of KeyValuePair(Of String, Integer))
    Public Property GrossRevenueList As List(Of RevenueByDate)
    Public Property NumOrders As Integer
    Public Property TotalRevenue As Decimal
    Public Property TotalProfit As Decimal
    Public Property dtUnderstock As New DataTable()


    Public Sub New()
        'Initialize the columns for the datatable of understock
        dtUnderstock.Columns.Add("Product Description", GetType(String))
        dtUnderstock.Columns.Add("Quantity", GetType(Integer))

        'Initialize the columns for the datatable of products

    End Sub

    Private Sub GetNumberItems()
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using command As New MySqlCommand()
                    command.Connection = conn

                    ' Get Total Number of Customers
                    command.CommandText = "SELECT COUNT(customerID) FROM customer"
                    NumCustomers = CInt(command.ExecuteScalar())

                    ' Get Total Number of Products
                    command.CommandText = "SELECT COUNT(productID) FROM product"
                    NumProducts = CInt(command.ExecuteScalar())

                    ' Get Total Number of Orders
                    ' Get Total Number of Orders
                    command.CommandText = "SELECT COUNT(orderID) FROM c_order WHERE date_ordered BETWEEN @fromDate AND @toDate;"
                    command.Parameters.AddWithValue("@fromDate", startDate)
                    command.Parameters.AddWithValue("@toDate", endDate)
                    NumOrders = CInt(command.ExecuteScalar())
                End Using
                conn.Close()
            End Using

        Catch ex As MySqlException
            CustomMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GetOrderAnalisys()
        GrossRevenueList = New List(Of RevenueByDate)
        TotalProfit = 0
        TotalRevenue = 0

        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using command As New MySqlCommand()
                    command.Connection = conn
                    command.CommandText = "SELECT c.date_ordered, SUM(op.quantity * p.price) AS TotalRevenue " &
                                      "FROM c_order c " &
                                      "INNER JOIN order_product op ON op.orderID = c.orderID " &
                                      "INNER JOIN product p ON op.productID = p.productID " &
                                      "WHERE c.date_ordered BETWEEN @fromDate AND @toDate " &
                                      "GROUP BY c.date_ordered;"

                    command.Parameters.Add("@fromDate", MySqlDbType.DateTime).Value = startDate
                    command.Parameters.Add("@toDate", MySqlDbType.DateTime).Value = endDate

                    Dim reader As MySqlDataReader = command.ExecuteReader()
                    Dim resultTable As New List(Of KeyValuePair(Of DateTime, Decimal))

                    While reader.Read()
                        resultTable.Add(New KeyValuePair(Of DateTime, Decimal)(DirectCast(reader(0), DateTime), DirectCast(reader(1), Decimal)))
                        TotalRevenue += DirectCast(reader(1), Decimal)
                    End While

                    TotalProfit = TotalRevenue * 0.2D ' 20%
                    reader.Close()


                    If numberDays <= 1 Then ' Group by Hours
                        GrossRevenueList = (From orderList In resultTable
                                            Let orderDate = orderList.Key.ToString("hh tt") ' Extract date part here
                                            Group orderList By orderDate Into order = Group ' Group by orderDate
                                            Select New RevenueByDate With {
                                                    .Date = orderDate,
                                                    .TotalAmount = order.Sum(Function(amount) amount.Value)
                                                }).ToList()
                    ElseIf numberDays <= 30 Then 'Group by Days
                        GrossRevenueList = (From orderList In resultTable
                                            Let orderDate = orderList.Key.ToString("dd MMM") ' Extract date part here
                                            Group orderList By orderDate Into order = Group ' Group by orderDate
                                            Select New RevenueByDate With {
                                                    .Date = orderDate,
                                                    .TotalAmount = order.Sum(Function(amount) amount.Value)
                                                }).ToList()
                    ElseIf numberDays <= 92 Then 'Group by Weeks
                        GrossRevenueList = (From orderList In resultTable
                                            Let orderDate = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                                    orderList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday).ToString() ' Extract date part here
                                            Group orderList By orderDate Into order = Group ' Group by orderDate
                                            Select New RevenueByDate With {
                                                    .Date = "Week " & orderDate,
                                                    .TotalAmount = order.Sum(Function(amount) amount.Value)
                                                }).ToList()
                    ElseIf numberDays <= (365 * 2) Then 'Group by months
                        Dim isYear As Boolean = numberDays <= 365
                        GrossRevenueList = (From orderList In resultTable
                                            Let orderDate = orderList.Key.ToString("MMM yyyy") ' Extract date part here
                                            Group orderList By orderDate Into order = Group ' Group by orderDate
                                            Select New RevenueByDate With {
                                                    .Date = If(isYear, orderDate.Substring(0, orderDate.IndexOf(" ")), orderDate),
                                                    .TotalAmount = order.Sum(Function(amount) amount.Value)
                                                }).ToList()
                    Else 'Group by years
                        GrossRevenueList = (From orderList In resultTable
                                            Let orderDate = orderList.Key.ToString("yyyy") ' Extract date part here
                                            Group orderList By orderDate Into order = Group ' Group by orderDate
                                            Select New RevenueByDate With {
                                                    .Date = orderDate,
                                                    .TotalAmount = order.Sum(Function(amount) amount.Value)
                                                }).ToList()
                    End If
                End Using
                conn.Close()
            End Using
        Catch ex As mysqlException
            MessageBox.Show(ex.Message + "order")
        End Try
    End Sub


    Private Sub GetProductAnalysis()
        TopProductsList = New List(Of KeyValuePair(Of String, Integer))()
        UnderstockList = New List(Of KeyValuePair(Of String, Integer))()

        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using command = New MySqlCommand()
                    Dim reader As MySqlDataReader
                    command.Connection = conn

                    ' Get Top 5 products
                    command.CommandText = "SELECT p.prodDescription, SUM(op.Quantity) AS Q " &
                                      "FROM order_product op " &
                                      "INNER JOIN product p ON p.productID = op.productID " &
                                      "INNER JOIN c_order o ON o.orderID = op.orderID " &
                                      "WHERE o.date_ordered BETWEEN @startDate AND @endDate " &
                                      "GROUP BY p.prodDescription " &
                                      "ORDER BY Q DESC " &
                                      "LIMIT 5;"
                    command.Parameters.Add("@startDate", MySqlDbType.DateTime).Value = startDate
                    command.Parameters.Add("@endDate", MySqlDbType.DateTime).Value = endDate

                    reader = command.ExecuteReader()
                    Do While reader.Read()
                        TopProductsList.Add(New KeyValuePair(Of String, Integer)(reader(0).ToString(), CInt(reader(1))))
                    Loop
                    reader.Close()

                    ' Get Understock
                    command.CommandText = "SELECT p.prodDescription, s.quantity FROM product p " &
                                      "INNER JOIN stock s ON p.productID = s.productID " &
                                      "WHERE s.quantity <= 15 " &
                                      "ORDER BY s.quantity DESC;"

                    reader = command.ExecuteReader()

                    Do While reader.Read()
                        Dim prodDescription As String = reader(0).ToString()
                        Dim quantity As Integer = CInt(reader(1))
                        dtUnderstock.Rows.Add(prodDescription, quantity)
                        UnderstockList.Add(New KeyValuePair(Of String, Integer)(reader(0).ToString(), CInt(reader(1))))
                    Loop


                    reader.Close()
                End Using
                conn.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function LoadData(startDate As DateTime, endDate As DateTime) As Boolean
        endDate = New DateTime(endDate.Year, endDate.Month, endDate.Day, endDate.Hour, endDate.Minute, 59)
        If startDate <> Me.startDate OrElse endDate <> Me.endDate Then
            Me.startDate = startDate
            Me.endDate = endDate
            Me.numberDays = (endDate - startDate).Days
            GetNumberItems()
            GetProductAnalysis()
            GetOrderAnalisys()
            Return True
        Else
            Return False
        End If
    End Function
End Class