Public Class dashBoardForm
    Private model As Dashboard
    Private currentBtn As Button

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtStart.Value = DateTime.Today.AddDays(-7)
        dtEnd.Value = DateTime.Now
        cmdLast7days.Select()
        model = New Dashboard
        loaddata()
        highlightButtons(cmdLast7days)
    End Sub

    Private Sub loaddata()
        Dim refreshdata As Boolean = model.LoadData(dtStart.Value, dtEnd.Value)
        If refreshdata = True Then
            lblnumOrders.Text = model.NumOrders.ToString()
            lbltotRevenue.Text = "₱" + model.TotalRevenue.ToString()
            lbltotProfit.Text = "₱" + model.TotalProfit.ToString()
            lblnumCustomers.Text = model.NumCustomers.ToString()
            lblnumProducts.Text = model.NumProducts.ToString()
            chartGrossRevenue.DataSource = model.GrossRevenueList
            chartGrossRevenue.Series(0).XValueMember = "Date"
            chartGrossRevenue.Series(0).YValueMembers = "TotalAmount"
            chartGrossRevenue.DataBind()


            dgvUnderstock.DataSource = model.dtUnderstock

            chartTopproducts.DataSource = model.TopProductsList
            chartTopproducts.Series(0).XValueMember = "Key"
            chartTopproducts.Series(0).YValueMembers = "Value"
            chartTopproducts.DataBind()

        End If
    End Sub
    Private Sub highlightButtons(btn As Button)
        Dim button As Button = CType(btn, Button)

        ' Check if the clicked button is not the same as the currentBtn
        If currentBtn IsNot button Then
            button.BackColor = cmdLast7days.FlatAppearance.BorderColor
            button.ForeColor = Color.White

            ' Disable the previous button (if there is one)
            If currentBtn IsNot Nothing Then
                currentBtn.BackColor = Color.FromArgb(244, 248, 255)
                currentBtn.ForeColor = Color.FromArgb(124, 141, 181)
                currentBtn.Enabled = True
            End If

            currentBtn = button
        End If
    End Sub


    Private Sub cmdToday_Click(sender As Object, e As EventArgs) Handles cmdToday.Click
        dtStart.Value = DateTime.Today
        dtEnd.Value = DateTime.Now
        loaddata()
        highlightButtons(sender)
    End Sub

    Private Sub cmdLast7days_Click(sender As Object, e As EventArgs) Handles cmdLast7days.Click
        dtStart.Value = DateTime.Today.AddDays(-7)
        dtEnd.Value = DateTime.Now
        loaddata()
        highlightButtons(sender)
    End Sub

    Private Sub cmdLast30days_Click(sender As Object, e As EventArgs) Handles cmdLast30days.Click
        dtStart.Value = DateTime.Today.AddDays(-30)
        dtEnd.Value = DateTime.Now
        loaddata()
        highlightButtons(sender)
    End Sub

    Private Sub cmdMonth_Click(sender As Object, e As EventArgs) Handles cmdMonth.Click
        dtStart.Value = New DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)
        dtEnd.Value = DateTime.Now
        loaddata()
        highlightButtons(sender)
    End Sub

    Private Sub cmdCustom_Click(sender As Object, e As EventArgs) Handles cmdCustom.Click
        highlightButtons(sender)
        dtStart.Enabled = True
        dtEnd.Enabled = True
        cmdOK.Visible = True
    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
        loaddata()
    End Sub
End Class