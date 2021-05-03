Public Class Form3
    Private Sub btnTemizle_Click(sender As Object, e As EventArgs) Handles btnTemizle.Click
        For Each c In Me.Controls
            If TypeOf c Is TextBox Then
                c.text = ""
            End If
        Next
    End Sub

    Private Sub btnGozat_Click(sender As Object, e As EventArgs) Handles btnGozat.Click
        Form4.Show()
    End Sub

    Private Sub btnKayitGetir_Click(sender As Object, e As EventArgs) Handles btnKayitGetir.Click
        If txtMusteriNo.Text = "" Then
            MsgBox("Müşteri Seçiniz", MsgBoxStyle.Critical, "Hata")
            Return
        End If

        Dim musteriNo = Convert.ToInt32(txtMusteriNo.Text)

        Dim dtKay As DataTable = dtGetir("select * from kayitlar where musteriNo=" & musteriNo)

        dgKayitlar.Rows.Clear()
        For i = 0 To dtKay.Rows.Count - 1
            dgKayitlar.Rows.Add(dtKay.Rows(i)("kayitNo").ToString(), dtKay.Rows(i)("kayGun").ToString() & "." &
            dtKay.Rows(i)("kayAy").ToString() & "." & dtKay.Rows(i)("kayYil").ToString(), dtKay.Rows(i)("baslik").ToString(),
            dtKay.Rows(i)("ucret").ToString())
        Next

        Dim dtOde As DataTable = dtGetir("select * from odemeler where musteriNo=" & musteriNo)

        dgOdemeler.Rows.Clear()
        For i = 0 To dtOde.Rows.Count - 1
            dgOdemeler.Rows.Add(dtOde.Rows(i)("odemeNo").ToString(), dtOde.Rows(i)("odemeGun").ToString() & "." &
            dtOde.Rows(i)("odemeAy").ToString() & "." & dtOde.Rows(i)("odemeYil").ToString(),
            dtOde.Rows(i)("odenen").ToString())
        Next

        Dim borc As Double = 0

        For i = 0 To dgKayitlar.Rows.Count - 1
            borc += Convert.ToDouble(dgKayitlar.Rows(i).Cells(3).Value.ToString())
        Next
        lbBorc.Text = borc.ToString("0.00 TL")

        Dim odeme As Double = 0

        For i = 0 To dgOdemeler.Rows.Count - 1
            odeme += Convert.ToDouble(dgOdemeler.Rows(i).Cells(3).Value.ToString())
        Next
        lbOdeme.Text = odeme.ToString("0.00 TL")

        Dim bakiye As Double = odeme - borc
        lbBakiye.Text = bakiye.ToString("0.00 TL")
        If bakiye < 0 Then
            lbBakiye.ForeColor = Color.Red
        Else
            lbBakiye.ForeColor = Color.Green
        End If

    End Sub

    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        If txtOdeme.Text = "" Then
            MsgBox("Ödeme Giriniz", MsgBoxStyle.Critical, "Hata")
            Return
        End If

        Dim gun As Integer = dtTarih.Value.Day
        Dim ay As Integer = dtTarih.Value.Month
        Dim yil As Integer = dtTarih.Value.Year

        Dim musteriNo As Integer = Convert.ToInt32(txtMusteriNo.Text)

        Dim odenen As Double = Convert.ToDouble(txtOdeme.Text)

        vt.sqlCalistir("insert into odemeler (odemeGun,odemeAy,odemeYil,odenen,musteriNo) 
        values( " & gun & "," & ay & "," & yil & "," & odenen & "," & musteriNo & ")")
        btnKayitGetir.PerformClick()
    End Sub
End Class