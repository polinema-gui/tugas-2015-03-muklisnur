Public Class Form1

    Private Sub ProblemBintangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProblemBintangToolStripMenuItem.Click
        Form2.MdiParent = Me
        Form2.Show()
    End Sub

    Private Sub MatriksKalkulatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MatriksKalkulatorToolStripMenuItem.Click
        Matriks.MdiParent = Me
        Matriks.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Environment.Exit(0)
    End Sub
End Class
