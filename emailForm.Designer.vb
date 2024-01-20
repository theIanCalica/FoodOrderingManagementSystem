<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class emailForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.cmdAttach = New System.Windows.Forms.Button()
        Me.txtBody = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lblFilename = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdSend = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(47, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "To"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(47, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Subject"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(47, 338)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Body"
        '
        'txtTo
        '
        Me.txtTo.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTo.Location = New System.Drawing.Point(115, 135)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(864, 23)
        Me.txtTo.TabIndex = 3
        '
        'txtSubject
        '
        Me.txtSubject.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubject.Location = New System.Drawing.Point(115, 176)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(864, 23)
        Me.txtSubject.TabIndex = 4
        '
        'cmdAttach
        '
        Me.cmdAttach.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAttach.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.cmdAttach.FlatAppearance.BorderSize = 2
        Me.cmdAttach.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAttach.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAttach.ForeColor = System.Drawing.Color.DimGray
        Me.cmdAttach.Location = New System.Drawing.Point(50, 224)
        Me.cmdAttach.Name = "cmdAttach"
        Me.cmdAttach.Size = New System.Drawing.Size(92, 28)
        Me.cmdAttach.TabIndex = 5
        Me.cmdAttach.Text = "Attach file"
        Me.cmdAttach.UseVisualStyleBackColor = True
        '
        'txtBody
        '
        Me.txtBody.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBody.Location = New System.Drawing.Point(101, 267)
        Me.txtBody.Multiline = True
        Me.txtBody.Name = "txtBody"
        Me.txtBody.Size = New System.Drawing.Size(878, 276)
        Me.txtBody.TabIndex = 6
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lblFilename
        '
        Me.lblFilename.AutoSize = True
        Me.lblFilename.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilename.ForeColor = System.Drawing.Color.LightGray
        Me.lblFilename.Location = New System.Drawing.Point(148, 232)
        Me.lblFilename.Name = "lblFilename"
        Me.lblFilename.Size = New System.Drawing.Size(0, 16)
        Me.lblFilename.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1009, 100)
        Me.Panel1.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Silver
        Me.Label5.Location = New System.Drawing.Point(54, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 36)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Email"
        '
        'cmdSend
        '
        Me.cmdSend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSend.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.cmdSend.FlatAppearance.BorderSize = 2
        Me.cmdSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSend.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSend.ForeColor = System.Drawing.Color.DimGray
        Me.cmdSend.Location = New System.Drawing.Point(832, 559)
        Me.cmdSend.Name = "cmdSend"
        Me.cmdSend.Size = New System.Drawing.Size(147, 44)
        Me.cmdSend.TabIndex = 10
        Me.cmdSend.Text = "Send"
        Me.cmdSend.UseVisualStyleBackColor = True
        '
        'emailForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1009, 615)
        Me.Controls.Add(Me.cmdSend)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblFilename)
        Me.Controls.Add(Me.txtBody)
        Me.Controls.Add(Me.cmdAttach)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.txtTo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "emailForm"
        Me.Text = "email"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTo As TextBox
    Friend WithEvents txtSubject As TextBox
    Friend WithEvents cmdAttach As Button
    Friend WithEvents txtBody As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents lblFilename As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents cmdSend As Button
End Class
