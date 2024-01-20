Public Class MainMenu
    Dim sidebarExpand As Boolean
    Dim currentForm As Form

    'Private Sub sidebarTimer_Tick(sender As Object, e As EventArgs)
    '    If sidebarExpand Then
    '        sidebar.Width -= 10
    '        If sidebar.Width = sidebar.MinimumSize.Width Then
    '            sidebarExpand = False
    '            'sidebarTimer.Stop()
    '        Else
    '            sidebar.Width += 10
    '            If sidebar.Width = sidebar.MaximumSize.Width Then
    '                sidebarExpand = True
    '                ' sidebarTimer.Stop()
    '            End If
    '        End If

    '    End If
    'End Sub

    Private Sub ShowFormInPanel(formToShow As Form)
        ' Check if a form is already displayed, and close it before showing the new form
        If currentForm IsNot Nothing Then
            currentForm.Close()
            currentForm.Dispose()
        End If

        ' Set the properties of the form to be displayed
        formToShow.TopLevel = False
        formToShow.FormBorderStyle = FormBorderStyle.None
        formToShow.Dock = DockStyle.Fill

        ' Add the form as a child control to the panelContainer
        pnlContainer.Controls.Add(formToShow)

        ' Set the currentForm reference to the new form
        currentForm = formToShow

        ' Show the form
        formToShow.Show()
    End Sub

    Private Sub CmdDashboard_Click_1(sender As Object, e As EventArgs) Handles cmdDashboard.Click
        ShowFormInPanel(dashBoardForm)
        Me.Size = New Size(1650, 850)
        pnlContainer.Size = New Size(1650, 850)
    End Sub

    Private Sub CndMessage_Click(sender As Object, e As EventArgs) Handles cndMessage.Click
        ShowFormInPanel(emailForm)
    End Sub

    Private Sub CmdProductCategory_Click(sender As Object, e As EventArgs) Handles cmdProductscategory.Click
        ShowFormInPanel(prodcategoryForm)
    End Sub

    Private Sub CndReports_Click(sender As Object, e As EventArgs) Handles cndReports.Click
        ShowFormInPanel()
    End Sub

    Private Sub CmdProducts_Click_1(sender As Object, e As EventArgs) Handles cmdProducts.Click
        ShowFormInPanel(ProductForm)
    End Sub

    Private Sub CmdStaff_Click(sender As Object, e As EventArgs) Handles cmdStaff.Click
        ShowFormInPanel(StaffForm)
    End Sub

    Private Sub CmdStaffCategory_Click(sender As Object, e As EventArgs) Handles cmdStaffCategory.Click
        ShowFormInPanel(staffCategoryForm)
    End Sub
End Class