
Public Class MDIParent1
    Private Sub ÇıkışToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÇıkışToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub İşTakipToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles İşTakipToolStripMenuItem.Click
        Form1.MdiParent = Me
        Form1.Show()
    End Sub

    Private Sub MüşteriEkleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MüşteriEkleToolStripMenuItem.Click
        Form2.MdiParent = Me
        Form2.Show()
    End Sub

    Private Sub ÖdemeAlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÖdemeAlToolStripMenuItem.Click
        Form3.MdiParent = Me
        Form3.Show()
    End Sub
End Class
