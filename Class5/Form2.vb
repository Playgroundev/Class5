Public Class FrmLogin

    Private Sub NextFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextFormToolStripMenuItem.Click
        Me.Hide()
        FrmFunctions.Show()
    End Sub

    Private Sub PreviousFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreviousFormToolStripMenuItem.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub DATAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DATAToolStripMenuItem.Click
        Dim Mark As Integer
        Mark = Val(TxtData.Text)
        FrmFunctions.LstResult.Items.Add(Mark)
    End Sub
End Class