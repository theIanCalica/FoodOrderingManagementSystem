Imports System.Net.Mail

Public Class emailForm
    Private Sub cmdAttach_Click(sender As Object, e As EventArgs) Handles cmdAttach.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            lblFilename.Text = OpenFileDialog1.FileName
            lblFilename.Show()
        End If
    End Sub
    Private Sub email_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFilename.Hide()
    End Sub

    Private Sub cmdAttach_MouseHover(sender As Object, e As EventArgs) Handles cmdAttach.MouseHover
        cmdAttach.BackColor = Color.FromArgb(149, 87, 198)
        cmdAttach.ForeColor = Color.White
    End Sub

    Private Sub cmdAttach_MouseLeave(sender As Object, e As EventArgs) Handles cmdAttach.MouseLeave
        cmdAttach.BackColor = Color.FromArgb(24, 28, 63)
        cmdAttach.ForeColor = Color.LightGray
    End Sub

    Private Sub cmdSend_MouseHover(sender As Object, e As EventArgs) Handles cmdSend.MouseHover
        cmdSend.BackColor = Color.FromArgb(149, 87, 198)
        cmdSend.ForeColor = Color.White
    End Sub

    Private Sub cmdSend_MouseLeave(sender As Object, e As EventArgs) Handles cmdSend.MouseLeave
        cmdSend.BackColor = Color.FromArgb(24, 28, 63)
        cmdSend.ForeColor = Color.LightGray
    End Sub

    Private Sub cmdSend_Click_1(sender As Object, e As EventArgs) Handles cmdSend.Click

        If txtTo.Text Is Nothing Then
            MessageBox.Show("Recipient is required")
            Exit Sub
        End If

        Dim mail As New MailMessage
        Dim smtServer As New SmtpClient("smtp.gmail.com")
        Dim attach As System.Net.Mail.Attachment

        If lblFilename.Text = Nothing Then
            ' No action will be made
        Else
            attach = New System.Net.Mail.Attachment(lblFilename.Text)
            mail.Attachments.Add(attach)
        End If

        mail.From = New MailAddress("jojimistaps.express@gmail.com")
        mail.To.Add(txtTo.Text)
        mail.Subject = txtSubject.Text
        mail.Body = txtBody.Text
        smtServer.Port = 587
        smtServer.Credentials = New System.Net.NetworkCredential("jojimistaps.express@gmail.com", "uieqxmwmhlgobvml")
        smtServer.EnableSsl = True
        smtServer.Send(mail)
        MessageBox.Show("mail sent")
    End Sub
End Class