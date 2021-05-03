Public Class Form2
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        If txtAdsoyad.Text = "" Or txtTel.Text = "" Or txtAdres.Text = "" Then
            MsgBox("Lütfen Tüm Alanları Doldurunuz!", MsgBoxStyle.Critical, "Hata")
            Return
        End If

        vt.sqlCalistir("insert into musteriler (adsoyad,tel,adres) values ('" & txtAdsoyad.Text & "','" & txtTel.Text & "','" & txtAdres.Text & "')")

        MsgBox("Müşteri Eklendi", MsgBoxStyle.Information, "İşlem Tamam")
        txtAdsoyad.Clear()
        txtTel.Clear()
        txtAdres.Clear()

    End Sub

    Private Sub btnKapat_Click(sender As Object, e As EventArgs) Handles btnKapat.Click
        Me.Close()
    End Sub
End Class