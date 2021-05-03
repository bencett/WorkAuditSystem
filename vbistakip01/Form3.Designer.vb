<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.btnTemizle = New System.Windows.Forms.Button()
        Me.btnGozat = New System.Windows.Forms.Button()
        Me.txtAdres = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAdsoyad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMusteriNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgKayitlar = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgOdemeler = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnKayitGetir = New System.Windows.Forms.Button()
        Me.lbBorc = New System.Windows.Forms.Label()
        Me.lbOdeme = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbBakiye = New System.Windows.Forms.Label()
        Me.dtTarih = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtOdeme = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnKaydet = New System.Windows.Forms.Button()
        CType(Me.dgKayitlar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgOdemeler, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTemizle
        '
        Me.btnTemizle.Location = New System.Drawing.Point(326, 25)
        Me.btnTemizle.Name = "btnTemizle"
        Me.btnTemizle.Size = New System.Drawing.Size(98, 29)
        Me.btnTemizle.TabIndex = 31
        Me.btnTemizle.Text = "Temizle"
        Me.btnTemizle.UseVisualStyleBackColor = True
        '
        'btnGozat
        '
        Me.btnGozat.Location = New System.Drawing.Point(228, 25)
        Me.btnGozat.Name = "btnGozat"
        Me.btnGozat.Size = New System.Drawing.Size(91, 29)
        Me.btnGozat.TabIndex = 30
        Me.btnGozat.Text = "Gözat"
        Me.btnGozat.UseVisualStyleBackColor = True
        '
        'txtAdres
        '
        Me.txtAdres.Enabled = False
        Me.txtAdres.Location = New System.Drawing.Point(565, 56)
        Me.txtAdres.Multiline = True
        Me.txtAdres.Name = "txtAdres"
        Me.txtAdres.Size = New System.Drawing.Size(273, 86)
        Me.txtAdres.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.Location = New System.Drawing.Point(451, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 17)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Adres"
        '
        'txtTel
        '
        Me.txtTel.Enabled = False
        Me.txtTel.Location = New System.Drawing.Point(565, 28)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(273, 22)
        Me.txtTel.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(451, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 17)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Tel"
        '
        'txtAdsoyad
        '
        Me.txtAdsoyad.Enabled = False
        Me.txtAdsoyad.Location = New System.Drawing.Point(124, 56)
        Me.txtAdsoyad.Name = "txtAdsoyad"
        Me.txtAdsoyad.Size = New System.Drawing.Size(300, 22)
        Me.txtAdsoyad.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 17)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Adı Soyadı"
        '
        'txtMusteriNo
        '
        Me.txtMusteriNo.Enabled = False
        Me.txtMusteriNo.Location = New System.Drawing.Point(124, 28)
        Me.txtMusteriNo.Name = "txtMusteriNo"
        Me.txtMusteriNo.Size = New System.Drawing.Size(97, 22)
        Me.txtMusteriNo.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 17)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Müşteri No"
        '
        'dgKayitlar
        '
        Me.dgKayitlar.AllowUserToAddRows = False
        Me.dgKayitlar.AllowUserToDeleteRows = False
        Me.dgKayitlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgKayitlar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dgKayitlar.Location = New System.Drawing.Point(14, 151)
        Me.dgKayitlar.Name = "dgKayitlar"
        Me.dgKayitlar.ReadOnly = True
        Me.dgKayitlar.RowTemplate.Height = 24
        Me.dgKayitlar.Size = New System.Drawing.Size(410, 296)
        Me.dgKayitlar.TabIndex = 32
        '
        'Column1
        '
        Me.Column1.HeaderText = "KN"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 50
        '
        'Column2
        '
        Me.Column2.HeaderText = "Tarih"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Yapılan İş"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Ücret"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'dgOdemeler
        '
        Me.dgOdemeler.AllowUserToAddRows = False
        Me.dgOdemeler.AllowUserToDeleteRows = False
        Me.dgOdemeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgOdemeler.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4})
        Me.dgOdemeler.Location = New System.Drawing.Point(454, 151)
        Me.dgOdemeler.Name = "dgOdemeler"
        Me.dgOdemeler.ReadOnly = True
        Me.dgOdemeler.RowTemplate.Height = 24
        Me.dgOdemeler.Size = New System.Drawing.Size(384, 296)
        Me.dgOdemeler.TabIndex = 33
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Öd.N"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Tarih"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Ödenen"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'btnKayitGetir
        '
        Me.btnKayitGetir.Location = New System.Drawing.Point(280, 99)
        Me.btnKayitGetir.Name = "btnKayitGetir"
        Me.btnKayitGetir.Size = New System.Drawing.Size(144, 29)
        Me.btnKayitGetir.TabIndex = 34
        Me.btnKayitGetir.Text = "Kayıt Getir"
        Me.btnKayitGetir.UseVisualStyleBackColor = True
        '
        'lbBorc
        '
        Me.lbBorc.AutoSize = True
        Me.lbBorc.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbBorc.Location = New System.Drawing.Point(294, 450)
        Me.lbBorc.Name = "lbBorc"
        Me.lbBorc.Size = New System.Drawing.Size(89, 39)
        Me.lbBorc.TabIndex = 35
        Me.lbBorc.Text = "0 TL"
        '
        'lbOdeme
        '
        Me.lbOdeme.AutoSize = True
        Me.lbOdeme.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbOdeme.Location = New System.Drawing.Point(709, 450)
        Me.lbOdeme.Name = "lbOdeme"
        Me.lbOdeme.Size = New System.Drawing.Size(89, 39)
        Me.lbOdeme.TabIndex = 36
        Me.lbOdeme.Text = "0 TL"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 514)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(146, 39)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Bakiye :"
        '
        'lbBakiye
        '
        Me.lbBakiye.AutoSize = True
        Me.lbBakiye.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbBakiye.Location = New System.Drawing.Point(164, 514)
        Me.lbBakiye.Name = "lbBakiye"
        Me.lbBakiye.Size = New System.Drawing.Size(89, 39)
        Me.lbBakiye.TabIndex = 38
        Me.lbBakiye.Text = "0 TL"
        '
        'dtTarih
        '
        Me.dtTarih.Location = New System.Drawing.Point(601, 514)
        Me.dtTarih.Name = "dtTarih"
        Me.dtTarih.Size = New System.Drawing.Size(237, 22)
        Me.dtTarih.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(486, 519)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 17)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Tarih"
        '
        'txtOdeme
        '
        Me.txtOdeme.Location = New System.Drawing.Point(601, 545)
        Me.txtOdeme.Name = "txtOdeme"
        Me.txtOdeme.Size = New System.Drawing.Size(121, 22)
        Me.txtOdeme.TabIndex = 43
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label12.Location = New System.Drawing.Point(486, 545)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(109, 17)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "Alınan Ödeme"
        '
        'btnKaydet
        '
        Me.btnKaydet.Location = New System.Drawing.Point(728, 542)
        Me.btnKaydet.Name = "btnKaydet"
        Me.btnKaydet.Size = New System.Drawing.Size(110, 29)
        Me.btnKaydet.TabIndex = 41
        Me.btnKaydet.Text = "Kaydet"
        Me.btnKaydet.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 602)
        Me.Controls.Add(Me.txtOdeme)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnKaydet)
        Me.Controls.Add(Me.dtTarih)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbBakiye)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbOdeme)
        Me.Controls.Add(Me.lbBorc)
        Me.Controls.Add(Me.btnKayitGetir)
        Me.Controls.Add(Me.dgOdemeler)
        Me.Controls.Add(Me.dgKayitlar)
        Me.Controls.Add(Me.btnTemizle)
        Me.Controls.Add(Me.btnGozat)
        Me.Controls.Add(Me.txtAdres)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAdsoyad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMusteriNo)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Name = "Form3"
        Me.Text = "Ödeme Al"
        CType(Me.dgKayitlar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgOdemeler, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTemizle As Button
    Friend WithEvents btnGozat As Button
    Friend WithEvents txtAdres As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTel As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAdsoyad As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMusteriNo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgKayitlar As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents dgOdemeler As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents btnKayitGetir As Button
    Friend WithEvents lbBorc As Label
    Friend WithEvents lbOdeme As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbBakiye As Label
    Friend WithEvents dtTarih As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents txtOdeme As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btnKaydet As Button
End Class
