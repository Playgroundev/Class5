Public Class FrmFunctions

    Private Sub EnterMarkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnterMarkToolStripMenuItem.Click
        Dim Marks As Integer
        Marks = InputBox("Enter mark")
        TxtMark.Text = Marks

    End Sub

    Private Sub EnterMark2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnterMark2ToolStripMenuItem.Click
        TxtMark.Text = InputBox("Enter Mark 2")
    End Sub

    Private Sub ComputeGradeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComputeGradeToolStripMenuItem.Click
        Dim Marks As Integer
        Marks = Val(TxtMark.Text)
        If Marks < 49 Then
            TxtGrade.Text = "FAIL"
        ElseIf Marks >= 50 & Marks < 100 Then
            TxtGrade.Text = "PASS"
        End If
    End Sub

    Private Sub CaseGradeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CaseGradeToolStripMenuItem.Click
        Dim Marks As Integer
        Marks = Val(TxtMark.Text)

        Select Case Marks
            Case 0 To 49
                TxtGrade.Text = "FAIL"
            Case 50 To 100
                TxtGrade.Text = "PASS"
            Case Else
                MsgBox("Invalid")


        End Select

    End Sub

    Private Sub CommentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommentToolStripMenuItem.Click
        If TxtGrade.Text = "FAIL" Then
            TxtComment.Text = "PLEASE REPEAT COURSE"
        ElseIf TxtGrade.Text = "PASS" Then
            TxtComment.Text = "CONGRATULATIONS PROCEED"



        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        LstResult.Items.Add(TxtMark.Text)
        LstResult.Items.Add(TxtGrade.Text)
        LstResult.Items.Add(TxtComment.Text)



    End Sub

    Private Sub ResultsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResultsToolStripMenuItem.Click
        LstResult.Items.Add(TxtMark.Text + " " + TxtGrade.Text + " " + TxtComment.Text)

    End Sub
End Class