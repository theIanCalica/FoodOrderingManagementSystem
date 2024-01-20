<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class editStaffForm
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
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPhoneno = New System.Windows.Forms.TextBox()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.dtpHiredate = New System.Windows.Forms.DateTimePicker()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbStaffCategory = New System.Windows.Forms.ComboBox()
        Me.pnlHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.IconButton1)
        Me.pnlHeader.Controls.Add(Me.PictureBox1)
        Me.pnlHeader.Controls.Add(Me.Label4)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(566, 192)
        Me.pnlHeader.TabIndex = 3
        '
        'IconButton1
        '
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Xmark
        Me.IconButton1.IconColor = System.Drawing.Color.White
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.Location = New System.Drawing.Point(517, 0)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(49, 44)
        Me.IconButton1.TabIndex = 14
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.foodOrdeing_managementSystem.My.Resources.Resources.staffMain
        Me.PictureBox1.Location = New System.Drawing.Point(24, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(191, 131)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Sans Serif Collection", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(231, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(263, 82)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Edit Staff"
        '
        'txtPhoneno
        '
        Me.txtPhoneno.Location = New System.Drawing.Point(288, 378)
        Me.txtPhoneno.Name = "txtPhoneno"
        Me.txtPhoneno.Size = New System.Drawing.Size(167, 22)
        Me.txtPhoneno.TabIndex = 46
        '
        'cmdEdit
        '
        Me.cmdEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdEdit.ForeColor = System.Drawing.Color.DimGray
        Me.cmdEdit.Location = New System.Drawing.Point(462, 512)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(92, 44)
        Me.cmdEdit.TabIndex = 45
        Me.cmdEdit.Text = "Done"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'dtpHiredate
        '
        Me.dtpHiredate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHiredate.Location = New System.Drawing.Point(288, 468)
        Me.dtpHiredate.Name = "dtpHiredate"
        Me.dtpHiredate.Size = New System.Drawing.Size(167, 22)
        Me.dtpHiredate.TabIndex = 44
        '
        'dtpDOB
        '
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDOB.Location = New System.Drawing.Point(288, 423)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(167, 22)
        Me.dtpDOB.TabIndex = 43
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Sans Serif Collection", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(105, 465)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 29)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Hire date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Sans Serif Collection", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(105, 420)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 29)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Date of birth"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Sans Serif Collection", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(105, 378)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 29)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Phone number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sans Serif Collection", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(105, 331)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 29)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Staff category"
        '
        'txtLastname
        '
        Me.txtLastname.Location = New System.Drawing.Point(288, 286)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(167, 22)
        Me.txtLastname.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sans Serif Collection", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(105, 282)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 29)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Last name"
        '
        'txtFirstname
        '
        Me.txtFirstname.Location = New System.Drawing.Point(288, 241)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(167, 22)
        Me.txtFirstname.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sans Serif Collection", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(105, 241)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 29)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "First name"
        '
        'cmbStaffCategory
        '
        Me.cmbStaffCategory.FormattingEnabled = True
        Me.cmbStaffCategory.Location = New System.Drawing.Point(288, 334)
        Me.cmbStaffCategory.Name = "cmbStaffCategory"
        Me.cmbStaffCategory.Size = New System.Drawing.Size(167, 24)
        Me.cmbStaffCategory.TabIndex = 48
        '
        'editStaffForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(566, 568)
        Me.Controls.Add(Me.cmbStaffCategory)
        Me.Controls.Add(Me.txtPhoneno)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.dtpHiredate)
        Me.Controls.Add(Me.dtpDOB)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLastname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFirstname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "editStaffForm"
        Me.Text = "editStaffForm"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPhoneno As TextBox
    Friend WithEvents cmdEdit As Button
    Friend WithEvents dtpHiredate As DateTimePicker
    Friend WithEvents dtpDOB As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLastname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents cmbStaffCategory As ComboBox
End Class
