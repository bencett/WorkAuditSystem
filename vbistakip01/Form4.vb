Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable = dtGetir("select * from musteriler order by adsoyad")
        For i = 0 To dt.Rows.Count - 1
            dgMusteri.Rows.Add(dt.Rows(i)("musteriNo").ToString(), dt.Rows(i)("adsoyad").ToString(),
            dt.Rows(i)("tel").ToString(), dt.Rows(i)("adres").ToString())
        Next
    End Sub

    Private Sub txtAra_TextChanged(sender As Object, e As EventArgs) Handles txtAra.TextChanged
        Dim dt As DataTable = dtGetir("select * from musteriler where adsoyad like '" & txtAra.Text & "%' or tel like '" & txtAra.Text & "%'
            or adres like '" & txtAra.Text & "%' order by adsoyad")
        For i = 0 To dt.Rows.Count - 1
            dgMusteri.Rows.Add(dt.Rows(i)("musteriNo").ToString(), dt.Rows(i)("adsoyad").ToString(),
            dt.Rows(i)("tel").ToString(), dt.Rows(i)("adres").ToString())
        Next
    End Sub

    Private Sub btnYeni_Click(sender As Object, e As EventArgs) Handles btnYeni.Click
        Form2.MdiParent = Me.ParentForm
        Form2.Show()
    End Sub

    Private Sub dgMusteri_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgMusteri.CellClick

        Form3.txtMusteriNo.Text = dgMusteri.CurrentRow.Cells(0).Value.ToString()
        Form3.txtAdsoyad.Text = dgMusteri.CurrentRow.Cells(1).Value.ToString()
        Form3.txtTel.Text = dgMusteri.CurrentRow.Cells(2).Value.ToString()
        Form3.txtAdres.Text = dgMusteri.CurrentRow.Cells(3).Value.ToString()
        Me.Close()
    End Sub
End Class