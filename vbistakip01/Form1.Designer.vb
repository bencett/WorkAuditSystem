<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgMusteri = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtTarih = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMusteriNo = New System.Windows.Forms.TextBox()
        Me.txtAdsoyad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAdres = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBaslik = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAciklama = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtUcret = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnKaydet = New System.Windows.Forms.Button()
        Me.btnKapat = New System.Windows.Forms.Button()
        Me.btnGozat = New System.Windows.Forms.Button()
        Me.btnTemizle = New System.Windows.Forms.Button()
        Me.txtAra = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnYeni = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtOdeme = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.dgMusteri, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgMusteri
        '
        Me.dgMusteri.AllowUserToAddRows = False
        Me.dgMusteri.AllowUserToDeleteRows = False
        Me.dgMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMusteri.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dgMusteri.Location = New System.Drawing.Point(394, 93)
        Me.dgMusteri.Name = "dgMusteri"
        Me.dgMusteri.ReadOnly = True
        Me.dgMusteri.RowTemplate.Height = 24
        Me.dgMusteri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMusteri.Size = New System.Drawing.Size(692, 436)
        Me.dgMusteri.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "M.No"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 50
        '
        'Column2
        '
        Me.Column2.HeaderText = "Adı Soyadı"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Tel"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Adres"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tarih"
        '
        'dtTarih
        '
        Me.dtTarih.Location = New System.Drawing.Point(162, 47)
        Me.dtTarih.Name = "dtTarih"
        Me.dtTarih.Size = New System.Drawing.Size(200, 22)
        Me.dtTarih.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Müşteri No"
        '
        'txtMusteriNo
        '
        Me.txtMusteriNo.Enabled = False
        Me.txtMusteriNo.Location = New System.Drawing.Point(113, 90)
        Me.txtMusteriNo.Name = "txtMusteriNo"
        Me.txtMusteriNo.Size = New System.Drawing.Size(87, 22)
        Me.txtMusteriNo.TabIndex = 4
        '
        'txtAdsoyad
        '
        Me.txtAdsoyad.Enabled = False
        Me.txtAdsoyad.Location = New System.Drawing.Point(113, 118)
        Me.txtAdsoyad.Name = "txtAdsoyad"
        Me.txtAdsoyad.Size = New System.Drawing.Size(267, 22)
        Me.txtAdsoyad.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Adı Soyadı"
        '
        'txtTel
        '
        Me.txtTel.Enabled = False
        Me.txtTel.Location = New System.Drawing.Point(113, 146)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(267, 22)
        Me.txtTel.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Tel"
        '
        'txtAdres
        '
        Me.txtAdres.Enabled = False
        Me.txtAdres.Location = New System.Drawing.Point(113, 174)
        Me.txtAdres.Multiline = True
        Me.txtAdres.Name = "txtAdres"
        Me.txtAdres.Size = New System.Drawing.Size(267, 106)
        Me.txtAdres.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Adres"
        '
        'txtBaslik
        '
        Me.txtBaslik.Location = New System.Drawing.Point(113, 286)
        Me.txtBaslik.Name = "txtBaslik"
        Me.txtBaslik.Size = New System.Drawing.Size(267, 22)
        Me.txtBaslik.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 286)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Yapılan İş"
        '
        'txtAciklama
        '
        Me.txtAciklama.Location = New System.Drawing.Point(113, 342)
        Me.txtAciklama.Multiline = True
        Me.txtAciklama.Name = "txtAciklama"
        Me.txtAciklama.Size = New System.Drawing.Size(267, 106)
        Me.txtAciklama.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 345)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 17)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Açıklama"
        '
        'txtUcret
        '
        Me.txtUcret.Location = New System.Drawing.Point(113, 314)
        Me.txtUcret.Name = "txtUcret"
        Me.txtUcret.Size = New System.Drawing.Size(121, 22)
        Me.txtUcret.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 317)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 17)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Ücreti"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label9.Location = New System.Drawing.Point(240, 317)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 17)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "TL"
        '
        'btnKaydet
        '
        Me.btnKaydet.Location = New System.Drawing.Point(113, 500)
        Me.btnKaydet.Name = "btnKaydet"
        Me.btnKaydet.Size = New System.Drawing.Size(110, 29)
        Me.btnKaydet.TabIndex = 18
        Me.btnKaydet.Text = "Kaydet"
        Me.btnKaydet.UseVisualStyleBackColor = True
        '
        'btnKapat
        '
        Me.btnKapat.Location = New System.Drawing.Point(270, 500)
        Me.btnKapat.Name = "btnKapat"
        Me.btnKapat.Size = New System.Drawing.Size(110, 29)
        Me.btnKapat.TabIndex = 19
        Me.btnKapat.Text = "Kapat"
        Me.btnKapat.UseVisualStyleBackColor = True
        '
        'btnGozat
        '
        Me.btnGozat.Location = New System.Drawing.Point(206, 87)
        Me.btnGozat.Name = "btnGozat"
        Me.btnGozat.Size = New System.Drawing.Size(81, 29)
        Me.btnGozat.TabIndex = 20
        Me.btnGozat.Text = "Gözat"
        Me.btnGozat.UseVisualStyleBackColor = True
        '
        'btnTemizle
        '
        Me.btnTemizle.Location = New System.Drawing.Point(293, 87)
        Me.btnTemizle.Name = "btnTemizle"
        Me.btnTemizle.Size = New System.Drawing.Size(87, 29)
        Me.btnTemizle.TabIndex = 21
        Me.btnTemizle.Text = "Temizle"
        Me.btnTemizle.UseVisualStyleBackColor = True
        '
        'txtAra
        '
        Me.txtAra.Location = New System.Drawing.Point(520, 60)
        Me.txtAra.Name = "txtAra"
        Me.txtAra.Size = New System.Drawing.Size(319, 22)
        Me.txtAra.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label10.Location = New System.Drawing.Point(402, 63)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 17)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Müşteri Arama"
        '
        'btnYeni
        '
        Me.btnYeni.Location = New System.Drawing.Point(877, 58)
        Me.btnYeni.Name = "btnYeni"
        Me.btnYeni.Size = New System.Drawing.Size(159, 29)
        Me.btnYeni.TabIndex = 24
        Me.btnYeni.Text = "Yeni Müşteri"
        Me.btnYeni.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label11.Location = New System.Drawing.Point(254, 460)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(27, 17)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "TL"
        '
        'txtOdeme
        '
        Me.txtOdeme.Location = New System.Drawing.Point(127, 457)
        Me.txtOdeme.Name = "txtOdeme"
        Me.txtOdeme.Size = New System.Drawing.Size(121, 22)
        Me.txtOdeme.TabIndex = 26
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 457)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(109, 17)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Alınan Ödeme"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1098, 551)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtOdeme)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnYeni)
        Me.Controls.Add(Me.txtAra)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnTemizle)
        Me.Controls.Add(Me.btnGozat)
        Me.Controls.Add(Me.btnKapat)
        Me.Controls.Add(Me.btnKaydet)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtAciklama)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtUcret)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtBaslik)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtAdres)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAdsoyad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMusteriNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtTarih)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgMusteri)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgMusteri, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgMusteri As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents dtTarih As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMusteriNo As TextBox
    Friend WithEvents txtAdsoyad As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTel As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAdres As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBaslik As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAciklama As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtUcret As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnKaydet As Button
    Friend WithEvents btnKapat As Button
    Friend WithEvents btnGozat As Button
    Friend WithEvents btnTemizle As Button
    Friend WithEvents txtAra As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnYeni As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Label11 As Label
    Friend WithEvents txtOdeme As TextBox
    Friend WithEvents Label12 As Label
End Class
