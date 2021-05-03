Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 410
        Dim dt As DataTable = dtGetir("select * from musteriler order by adsoyad")
        For i = 0 To dt.Rows.Count - 1
            dgMusteri.Rows.Add(dt.Rows(i)("musteriNo").ToString(), dt.Rows(i)("adsoyad").ToString(),
            dt.Rows(i)("tel").ToString(), dt.Rows(i)("adres").ToString())
        Next
    End Sub

    Private Sub btnTemizle_Click(sender As Object, e As EventArgs) Handles btnTemizle.Click
        For Each c In Me.Controls
            If TypeOf c Is TextBox Then
                c.text = ""
            End If
        Next
    End Sub

    Private Sub dgMusteri_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgMusteri.CellClick
        txtMusteriNo.Text = dgMusteri.CurrentRow.Cells(0).Value.ToString()
        txtAdsoyad.Text = dgMusteri.CurrentRow.Cells(1).Value.ToString()
        txtTel.Text = dgMusteri.CurrentRow.Cells(2).Value.ToString()
        txtAdres.Text = dgMusteri.CurrentRow.Cells(3).Value.ToString()
        Me.Width = 410
    End Sub

    Private Sub btnGozat_Click(sender As Object, e As EventArgs) Handles btnGozat.Click
        Me.Width = 1116
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtAra.TextChanged
        dgMusteri.Rows.Clear()
        Dim dt As DataTable = dtGetir("select * from musteriler where adsoyad like '" & txtAra.Text & "%' or tel like '" & txtAra.Text & "%'
            or adres like '" & txtAra.Text & "%' order by adsoyad")
        For i = 0 To dt.Rows.Count - 1
            dgMusteri.Rows.Add(dt.Rows(i)("musteriNo").ToString(), dt.Rows(i)("adsoyad").ToString(),
            dt.Rows(i)("tel").ToString(), dt.Rows(i)("adres").ToString())
        Next
    End Sub

    Private Sub btnKapat_Click(sender As Object, e As EventArgs) Handles btnKapat.Click
        Me.Close()
    End Sub

    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        Dim gun As Integer = dtTarih.Value.Day
        Dim ay As Integer = dtTarih.Value.Month
        Dim yil As Integer = dtTarih.Value.Year

        Dim musteriNo As Integer = Convert.ToInt32(txtMusteriNo.Text)
        Dim ucret As Double = Convert.ToDouble(txtUcret.Text)

        sqlCalistir("insert into kayitlar
            (baslik,aciklama,kayGun,kayAy,kayYil,ucret,musteriNo) values ('" & txtBaslik.Text & "','" & txtAciklama.Text & "'," & gun & "," & ay & "," & yil & "," & ucret & "," & musteriNo & ")")

        If txtOdeme.Text <> "" Then

            Dim odenen As Double = Convert.ToDouble(txtOdeme.Text)

            vt.sqlCalistir("insert into odemeler (odemeGun,odemeAy,odemeYil,odenen,musteriNo) 
                values( " & gun & "," & ay & "," & yil & "," & odenen & "," & musteriNo & ")")
        End If

        MsgBox("İş Kaydı Yapılmıştır", MsgBoxStyle.Information, "İşlem Tamam")
        btnTemizle.PerformClick()
    End Sub

    Private Sub btnYeni_Click(sender As Object, e As EventArgs) Handles btnYeni.Click
        Form2.MdiParent = Me.ParentForm
        Form2.Show()
    End Sub
End Class
