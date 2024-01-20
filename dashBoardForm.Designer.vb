<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dashBoardForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dashBoardForm))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtStart = New System.Windows.Forms.DateTimePicker()
        Me.dtEnd = New System.Windows.Forms.DateTimePicker()
        Me.cmdCustom = New System.Windows.Forms.Button()
        Me.cmdToday = New System.Windows.Forms.Button()
        Me.cmdLast30days = New System.Windows.Forms.Button()
        Me.cmdLast7days = New System.Windows.Forms.Button()
        Me.cmdMonth = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lblnumOrders = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lbltotRevenue = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbltotProfit = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chartGrossRevenue = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chartTopproducts = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.lblnumProducts = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblnumCustomers = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.dgvUnderstock = New System.Windows.Forms.DataGridView()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chartGrossRevenue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chartTopproducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvUnderstock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(2, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dashboard"
        '
        'dtStart
        '
        Me.dtStart.Location = New System.Drawing.Point(163, 6)
        Me.dtStart.Name = "dtStart"
        Me.dtStart.Size = New System.Drawing.Size(93, 22)
        Me.dtStart.TabIndex = 1
        '
        'dtEnd
        '
        Me.dtEnd.Location = New System.Drawing.Point(325, 5)
        Me.dtEnd.Name = "dtEnd"
        Me.dtEnd.Size = New System.Drawing.Size(93, 22)
        Me.dtEnd.TabIndex = 2
        '
        'cmdCustom
        '
        Me.cmdCustom.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCustom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCustom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.cmdCustom.Location = New System.Drawing.Point(540, 3)
        Me.cmdCustom.Name = "cmdCustom"
        Me.cmdCustom.Size = New System.Drawing.Size(150, 36)
        Me.cmdCustom.TabIndex = 3
        Me.cmdCustom.Text = "Custom"
        Me.cmdCustom.UseVisualStyleBackColor = True
        '
        'cmdToday
        '
        Me.cmdToday.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdToday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdToday.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.cmdToday.Location = New System.Drawing.Point(685, 3)
        Me.cmdToday.Name = "cmdToday"
        Me.cmdToday.Size = New System.Drawing.Size(150, 36)
        Me.cmdToday.TabIndex = 4
        Me.cmdToday.Text = "Today"
        Me.cmdToday.UseVisualStyleBackColor = True
        '
        'cmdLast30days
        '
        Me.cmdLast30days.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdLast30days.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLast30days.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLast30days.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.cmdLast30days.Location = New System.Drawing.Point(974, 3)
        Me.cmdLast30days.Name = "cmdLast30days"
        Me.cmdLast30days.Size = New System.Drawing.Size(150, 36)
        Me.cmdLast30days.TabIndex = 6
        Me.cmdLast30days.Text = "Last 30 days"
        Me.cmdLast30days.UseVisualStyleBackColor = True
        '
        'cmdLast7days
        '
        Me.cmdLast7days.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdLast7days.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLast7days.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLast7days.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.cmdLast7days.Location = New System.Drawing.Point(828, 3)
        Me.cmdLast7days.Name = "cmdLast7days"
        Me.cmdLast7days.Size = New System.Drawing.Size(150, 36)
        Me.cmdLast7days.TabIndex = 5
        Me.cmdLast7days.Text = "Last 7 days"
        Me.cmdLast7days.UseVisualStyleBackColor = True
        '
        'cmdMonth
        '
        Me.cmdMonth.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMonth.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.cmdMonth.Location = New System.Drawing.Point(1121, 3)
        Me.cmdMonth.Name = "cmdMonth"
        Me.cmdMonth.Size = New System.Drawing.Size(150, 36)
        Me.cmdMonth.TabIndex = 7
        Me.cmdMonth.Text = "This month"
        Me.cmdMonth.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.lblnumOrders)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(12, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(313, 61)
        Me.Panel1.TabIndex = 8
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(0, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(77, 55)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 21
        Me.PictureBox3.TabStop = False
        '
        'lblnumOrders
        '
        Me.lblnumOrders.AutoSize = True
        Me.lblnumOrders.ForeColor = System.Drawing.Color.DimGray
        Me.lblnumOrders.Location = New System.Drawing.Point(83, 25)
        Me.lblnumOrders.Name = "lblnumOrders"
        Me.lblnumOrders.Size = New System.Drawing.Size(56, 16)
        Me.lblnumOrders.TabIndex = 10
        Me.lblnumOrders.Text = "1000000"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(83, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Number of orders"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.lbltotRevenue)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(343, 49)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(296, 61)
        Me.Panel2.TabIndex = 11
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(85, 61)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'lbltotRevenue
        '
        Me.lbltotRevenue.AutoSize = True
        Me.lbltotRevenue.ForeColor = System.Drawing.Color.DimGray
        Me.lbltotRevenue.Location = New System.Drawing.Point(92, 29)
        Me.lbltotRevenue.Name = "lbltotRevenue"
        Me.lbltotRevenue.Size = New System.Drawing.Size(56, 16)
        Me.lbltotRevenue.TabIndex = 10
        Me.lbltotRevenue.Text = "1000000"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(92, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Total Revenue"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.lbltotProfit)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Location = New System.Drawing.Point(653, 49)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(618, 61)
        Me.Panel3.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(85, 61)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'lbltotProfit
        '
        Me.lbltotProfit.AutoSize = True
        Me.lbltotProfit.ForeColor = System.Drawing.Color.DimGray
        Me.lbltotProfit.Location = New System.Drawing.Point(136, 25)
        Me.lbltotProfit.Name = "lbltotProfit"
        Me.lbltotProfit.Size = New System.Drawing.Size(56, 16)
        Me.lbltotProfit.TabIndex = 10
        Me.lbltotProfit.Text = "1000000"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(136, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 16)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Total Profit"
        '
        'chartGrossRevenue
        '
        ChartArea1.AxisX.IsMarginVisible = False
        ChartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Silver
        ChartArea1.AxisX.LineColor = System.Drawing.Color.White
        ChartArea1.AxisX.LineWidth = 0
        ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White
        ChartArea1.AxisX.MajorGrid.LineWidth = 0
        ChartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(111, Byte), Integer))
        ChartArea1.AxisX.MajorTickMark.Size = 3.0!
        ChartArea1.AxisY.IsMarginVisible = False
        ChartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Silver
        ChartArea1.AxisY.LabelStyle.Format = "₱0"
        ChartArea1.AxisY.LineColor = System.Drawing.Color.White
        ChartArea1.AxisY.LineWidth = 0
        ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(111, Byte), Integer))
        ChartArea1.AxisY.MajorTickMark.IntervalOffset = 0R
        ChartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        ChartArea1.BackColor = System.Drawing.Color.White
        ChartArea1.Name = "ChartArea1"
        Me.chartGrossRevenue.ChartAreas.Add(ChartArea1)
        Legend1.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(86, Byte), Integer))
        Legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Legend1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Legend1.IsTextAutoFit = False
        Legend1.Name = "Legend1"
        Me.chartGrossRevenue.Legends.Add(Legend1)
        Me.chartGrossRevenue.Location = New System.Drawing.Point(12, 137)
        Me.chartGrossRevenue.Name = "chartGrossRevenue"
        Series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom
        Series1.BackSecondaryColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(255, Byte), Integer))
        Series1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(255, Byte), Integer))
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea
        Series1.Color = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(127, Byte), Integer))
        Series1.Legend = "Legend1"
        Series1.MarkerColor = System.Drawing.Color.MediumPurple
        Series1.MarkerSize = 0
        Series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
        Series1.Name = "Series1"
        Me.chartGrossRevenue.Series.Add(Series1)
        Me.chartGrossRevenue.Size = New System.Drawing.Size(925, 349)
        Me.chartGrossRevenue.TabIndex = 12
        Me.chartGrossRevenue.Text = "Gross Revenue"
        Title1.Alignment = System.Drawing.ContentAlignment.TopLeft
        Title1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title1.ForeColor = System.Drawing.Color.WhiteSmoke
        Title1.Name = "Gross Revenue"
        Title1.Text = "Gross Revenue"
        Me.chartGrossRevenue.Titles.Add(Title1)
        '
        'chartTopproducts
        '
        ChartArea2.BackColor = System.Drawing.Color.White
        ChartArea2.BorderColor = System.Drawing.Color.Bisque
        ChartArea2.Name = "ChartArea1"
        Me.chartTopproducts.ChartAreas.Add(ChartArea2)
        Legend2.BackColor = System.Drawing.Color.White
        Legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom
        Legend2.ForeColor = System.Drawing.Color.Silver
        Legend2.Name = "Legend1"
        Me.chartTopproducts.Legends.Add(Legend2)
        Me.chartTopproducts.Location = New System.Drawing.Point(965, 137)
        Me.chartTopproducts.Name = "chartTopproducts"
        Series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft
        Series2.BackSecondaryColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Series2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(86, Byte), Integer))
        Series2.BorderWidth = 8
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Series2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Series2.IsValueShownAsLabel = True
        Series2.LabelForeColor = System.Drawing.Color.White
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry
        Me.chartTopproducts.Series.Add(Series2)
        Me.chartTopproducts.Size = New System.Drawing.Size(421, 644)
        Me.chartTopproducts.TabIndex = 13
        Me.chartTopproducts.Text = " "
        Title2.ForeColor = System.Drawing.Color.WhiteSmoke
        Title2.Name = "Title1"
        Title2.Text = "5 Best Selling Products"
        Me.chartTopproducts.Titles.Add(Title2)
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.PictureBox4)
        Me.Panel4.Controls.Add(Me.PictureBox5)
        Me.Panel4.Controls.Add(Me.lblnumProducts)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.lblnumCustomers)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Location = New System.Drawing.Point(12, 502)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(282, 231)
        Me.Panel4.TabIndex = 11
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(14, 130)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(77, 55)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 23
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(14, 32)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(77, 55)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 22
        Me.PictureBox5.TabStop = False
        '
        'lblnumProducts
        '
        Me.lblnumProducts.AutoSize = True
        Me.lblnumProducts.Font = New System.Drawing.Font("Heebo", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnumProducts.ForeColor = System.Drawing.Color.DimGray
        Me.lblnumProducts.Location = New System.Drawing.Point(108, 146)
        Me.lblnumProducts.Name = "lblnumProducts"
        Me.lblnumProducts.Size = New System.Drawing.Size(58, 19)
        Me.lblnumProducts.TabIndex = 15
        Me.lblnumProducts.Text = "1000000"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Heebo", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(108, 130)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(145, 22)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Number of Products"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Heebo", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(135, 29)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Total Counter"
        '
        'lblnumCustomers
        '
        Me.lblnumCustomers.AutoSize = True
        Me.lblnumCustomers.Font = New System.Drawing.Font("Heebo", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnumCustomers.ForeColor = System.Drawing.Color.DimGray
        Me.lblnumCustomers.Location = New System.Drawing.Point(108, 54)
        Me.lblnumCustomers.Name = "lblnumCustomers"
        Me.lblnumCustomers.Size = New System.Drawing.Size(58, 19)
        Me.lblnumCustomers.TabIndex = 10
        Me.lblnumCustomers.Text = "1000000"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Heebo", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(107, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(159, 22)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Number of Customers"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.PictureBox6)
        Me.Panel5.Controls.Add(Me.dgvUnderstock)
        Me.Panel5.Controls.Add(Me.Label15)
        Me.Panel5.Location = New System.Drawing.Point(325, 502)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(612, 293)
        Me.Panel5.TabIndex = 16
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.foodOrdeing_managementSystem.My.Resources.Resources.three_dots
        Me.PictureBox6.Location = New System.Drawing.Point(534, 0)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(75, 33)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 17
        Me.PictureBox6.TabStop = False
        '
        'dgvUnderstock
        '
        Me.dgvUnderstock.AllowUserToAddRows = False
        Me.dgvUnderstock.AllowUserToDeleteRows = False
        Me.dgvUnderstock.AllowUserToResizeColumns = False
        Me.dgvUnderstock.AllowUserToResizeRows = False
        Me.dgvUnderstock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUnderstock.BackgroundColor = System.Drawing.Color.White
        Me.dgvUnderstock.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvUnderstock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvUnderstock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(181, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUnderstock.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvUnderstock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(190, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvUnderstock.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvUnderstock.EnableHeadersVisualStyles = False
        Me.dgvUnderstock.GridColor = System.Drawing.Color.White
        Me.dgvUnderstock.Location = New System.Drawing.Point(18, 36)
        Me.dgvUnderstock.Name = "dgvUnderstock"
        Me.dgvUnderstock.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUnderstock.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvUnderstock.RowHeadersVisible = False
        Me.dgvUnderstock.RowHeadersWidth = 51
        Me.dgvUnderstock.RowTemplate.Height = 35
        Me.dgvUnderstock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUnderstock.Size = New System.Drawing.Size(577, 240)
        Me.dgvUnderstock.TabIndex = 16
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label15.Location = New System.Drawing.Point(21, 17)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(132, 16)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "Products Understock"
        '
        'cmdOK
        '
        Me.cmdOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.cmdOK.Location = New System.Drawing.Point(482, 3)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOK.Size = New System.Drawing.Size(62, 36)
        Me.cmdOK.TabIndex = 17
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        Me.cmdOK.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(160, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Total Revenue"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(322, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Total Revenue"
        '
        'dashBoardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1440, 807)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.chartTopproducts)
        Me.Controls.Add(Me.chartGrossRevenue)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmdMonth)
        Me.Controls.Add(Me.cmdLast30days)
        Me.Controls.Add(Me.cmdLast7days)
        Me.Controls.Add(Me.cmdToday)
        Me.Controls.Add(Me.cmdCustom)
        Me.Controls.Add(Me.dtEnd)
        Me.Controls.Add(Me.dtStart)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "dashBoardForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chartGrossRevenue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chartTopproducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvUnderstock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dtStart As DateTimePicker
    Friend WithEvents dtEnd As DateTimePicker
    Friend WithEvents cmdCustom As Button
    Friend WithEvents cmdToday As Button
    Friend WithEvents cmdLast30days As Button
    Friend WithEvents cmdLast7days As Button
    Friend WithEvents cmdMonth As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents lblnumOrders As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbltotRevenue As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lbltotProfit As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents chartGrossRevenue As DataVisualization.Charting.Chart
    Friend WithEvents chartTopproducts As DataVisualization.Charting.Chart
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblnumProducts As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblnumCustomers As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents dgvUnderstock As DataGridView
    Friend WithEvents cmdOK As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
End Class
