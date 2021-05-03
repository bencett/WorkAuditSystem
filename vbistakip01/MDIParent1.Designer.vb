<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent1
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
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.İşTakipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MüşterilerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÖdemeAlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MüşteriEkleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RaporlarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÇıkışToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.İşTakipToolStripMenuItem, Me.MüşterilerToolStripMenuItem, Me.ÖdemeAlToolStripMenuItem, Me.MüşteriEkleToolStripMenuItem, Me.RaporlarToolStripMenuItem, Me.ÇıkışToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(843, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'İşTakipToolStripMenuItem
        '
        Me.İşTakipToolStripMenuItem.Name = "İşTakipToolStripMenuItem"
        Me.İşTakipToolStripMenuItem.Size = New System.Drawing.Size(69, 24)
        Me.İşTakipToolStripMenuItem.Text = "İş Takip"
        '
        'MüşterilerToolStripMenuItem
        '
        Me.MüşterilerToolStripMenuItem.Name = "MüşterilerToolStripMenuItem"
        Me.MüşterilerToolStripMenuItem.Size = New System.Drawing.Size(87, 24)
        Me.MüşterilerToolStripMenuItem.Text = "Müşteriler"
        '
        'ÖdemeAlToolStripMenuItem
        '
        Me.ÖdemeAlToolStripMenuItem.Name = "ÖdemeAlToolStripMenuItem"
        Me.ÖdemeAlToolStripMenuItem.Size = New System.Drawing.Size(88, 24)
        Me.ÖdemeAlToolStripMenuItem.Text = "Ödeme Al"
        '
        'MüşteriEkleToolStripMenuItem
        '
        Me.MüşteriEkleToolStripMenuItem.Name = "MüşteriEkleToolStripMenuItem"
        Me.MüşteriEkleToolStripMenuItem.Size = New System.Drawing.Size(101, 24)
        Me.MüşteriEkleToolStripMenuItem.Text = "Müşteri Ekle"
        '
        'RaporlarToolStripMenuItem
        '
        Me.RaporlarToolStripMenuItem.Name = "RaporlarToolStripMenuItem"
        Me.RaporlarToolStripMenuItem.Size = New System.Drawing.Size(78, 24)
        Me.RaporlarToolStripMenuItem.Text = "Raporlar"
        '
        'ÇıkışToolStripMenuItem
        '
        Me.ÇıkışToolStripMenuItem.Name = "ÇıkışToolStripMenuItem"
        Me.ÇıkışToolStripMenuItem.Size = New System.Drawing.Size(51, 24)
        Me.ÇıkışToolStripMenuItem.Text = "Çıkış"
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 558)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MDIParent1"
        Me.Text = "MDIParent1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents İşTakipToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MüşterilerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÖdemeAlToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MüşteriEkleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RaporlarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÇıkışToolStripMenuItem As ToolStripMenuItem
End Class
