Public Class Form1

    Private Sub BtnWelcome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FrmWelcome.Click
        Me.Hide()
        FrmLogin.show()
    End Sub

    Private Sub LOGINToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOGINToolStripMenuItem.Click
        Dim Username As String
        Dim password As String
        Username = TxtUsername.Text
        password = TxtPassword.Text
        If Username = "BrianWinnie" And password = "123" Then
            Me.Hide()
            FrmLogin.Show()
        Else
            MsgBox("Incorrect UserName or Password")
            TxtUsername.Text() = ""
            TxtPassword.Text() = ""



        End If


    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOGOUTToolStripMenuItem.Click
        Close()

    End Sub
End Class
