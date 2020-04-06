<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NotaFiscal
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NotaFiscal))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtLivroNota = New System.Windows.Forms.TextBox()
        Me.cboFuncNota = New System.Windows.Forms.ComboBox()
        Me.txtValorItem = New System.Windows.Forms.TextBox()
        Me.cboCodLivro = New System.Windows.Forms.ComboBox()
        Me.mskCPF = New System.Windows.Forms.MaskedTextBox()
        Me.ID_Nota = New System.Windows.Forms.ComboBox()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.lblValorTotal = New System.Windows.Forms.Label()
        Me.txtPesquisaNota = New System.Windows.Forms.TextBox()
        Me.dtgNota = New System.Windows.Forms.DataGridView()
        Me.btnAdicionarCompra = New System.Windows.Forms.PictureBox()
        Me.btnOK = New System.Windows.Forms.PictureBox()
        Me.txtid_nota = New System.Windows.Forms.TextBox()
        Me.txtcodlivro = New System.Windows.Forms.TextBox()
        Me.txtQtde = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.mskDataEmissao = New System.Windows.Forms.Label()
        Me.pbxPesquisar = New System.Windows.Forms.PictureBox()
        Me.dtgCarrinho = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.PictureBox()
        Me.btnDelete = New System.Windows.Forms.PictureBox()
        Me.cboPesquisaNota = New System.Windows.Forms.ComboBox()
        Me.txtValorUnit = New System.Windows.Forms.TextBox()
        Me.cbocarrinho = New System.Windows.Forms.ComboBox()
        Me.btnHelp = New System.Windows.Forms.PictureBox()
        Me.btnEND = New System.Windows.Forms.PictureBox()
        CType(Me.dtgNota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAdicionarCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnOK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxPesquisar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgCarrinho, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEND, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtLivroNota
        '
        Me.txtLivroNota.BackColor = System.Drawing.Color.White
        Me.txtLivroNota.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLivroNota.Enabled = False
        Me.txtLivroNota.ForeColor = System.Drawing.Color.Black
        Me.txtLivroNota.Location = New System.Drawing.Point(199, 350)
        Me.txtLivroNota.Name = "txtLivroNota"
        Me.txtLivroNota.Size = New System.Drawing.Size(177, 13)
        Me.txtLivroNota.TabIndex = 5
        '
        'cboFuncNota
        '
        Me.cboFuncNota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFuncNota.ForeColor = System.Drawing.Color.Black
        Me.cboFuncNota.FormattingEnabled = True
        Me.cboFuncNota.Location = New System.Drawing.Point(145, 405)
        Me.cboFuncNota.Name = "cboFuncNota"
        Me.cboFuncNota.Size = New System.Drawing.Size(238, 21)
        Me.cboFuncNota.TabIndex = 4
        '
        'txtValorItem
        '
        Me.txtValorItem.BackColor = System.Drawing.Color.White
        Me.txtValorItem.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtValorItem.Enabled = False
        Me.txtValorItem.ForeColor = System.Drawing.Color.Black
        Me.txtValorItem.Location = New System.Drawing.Point(515, 396)
        Me.txtValorItem.Name = "txtValorItem"
        Me.txtValorItem.Size = New System.Drawing.Size(123, 13)
        Me.txtValorItem.TabIndex = 6
        '
        'cboCodLivro
        '
        Me.cboCodLivro.BackColor = System.Drawing.Color.PowderBlue
        Me.cboCodLivro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboCodLivro.Enabled = False
        Me.cboCodLivro.FormattingEnabled = True
        Me.cboCodLivro.Location = New System.Drawing.Point(264, 444)
        Me.cboCodLivro.Name = "cboCodLivro"
        Me.cboCodLivro.Size = New System.Drawing.Size(50, 24)
        Me.cboCodLivro.TabIndex = 115
        Me.cboCodLivro.Visible = False
        '
        'mskCPF
        '
        Me.mskCPF.BackColor = System.Drawing.Color.White
        Me.mskCPF.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mskCPF.ForeColor = System.Drawing.Color.Black
        Me.mskCPF.Location = New System.Drawing.Point(152, 380)
        Me.mskCPF.Mask = "999.999.999-99"
        Me.mskCPF.Name = "mskCPF"
        Me.mskCPF.Size = New System.Drawing.Size(227, 13)
        Me.mskCPF.TabIndex = 3
        '
        'ID_Nota
        '
        Me.ID_Nota.BackColor = System.Drawing.Color.PowderBlue
        Me.ID_Nota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ID_Nota.Enabled = False
        Me.ID_Nota.FormattingEnabled = True
        Me.ID_Nota.Location = New System.Drawing.Point(145, 74)
        Me.ID_Nota.Name = "ID_Nota"
        Me.ID_Nota.Size = New System.Drawing.Size(81, 24)
        Me.ID_Nota.TabIndex = 113
        Me.ID_Nota.Visible = False
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.BackColor = System.Drawing.Color.Transparent
        Me.Label69.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.ForeColor = System.Drawing.Color.DimGray
        Me.Label69.Location = New System.Drawing.Point(120, 450)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(29, 18)
        Me.Label69.TabIndex = 112
        Me.Label69.Text = "R$"
        '
        'lblValorTotal
        '
        Me.lblValorTotal.AutoSize = True
        Me.lblValorTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblValorTotal.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValorTotal.ForeColor = System.Drawing.Color.DimGray
        Me.lblValorTotal.Location = New System.Drawing.Point(146, 450)
        Me.lblValorTotal.Name = "lblValorTotal"
        Me.lblValorTotal.Size = New System.Drawing.Size(63, 18)
        Me.lblValorTotal.TabIndex = 111
        Me.lblValorTotal.Text = "000,00"
        '
        'txtPesquisaNota
        '
        Me.txtPesquisaNota.BackColor = System.Drawing.Color.White
        Me.txtPesquisaNota.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPesquisaNota.ForeColor = System.Drawing.Color.Black
        Me.txtPesquisaNota.Location = New System.Drawing.Point(346, 110)
        Me.txtPesquisaNota.Name = "txtPesquisaNota"
        Me.txtPesquisaNota.Size = New System.Drawing.Size(225, 13)
        Me.txtPesquisaNota.TabIndex = 2
        '
        'dtgNota
        '
        Me.dtgNota.AllowUserToAddRows = False
        Me.dtgNota.AllowUserToDeleteRows = False
        Me.dtgNota.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dtgNota.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgNota.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dtgNota.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgNota.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgNota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgNota.Cursor = System.Windows.Forms.Cursors.Default
        Me.dtgNota.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtgNota.Location = New System.Drawing.Point(42, 174)
        Me.dtgNota.Name = "dtgNota"
        Me.dtgNota.ReadOnly = True
        Me.dtgNota.Size = New System.Drawing.Size(221, 125)
        Me.dtgNota.TabIndex = 105
        '
        'btnAdicionarCompra
        '
        Me.btnAdicionarCompra.BackColor = System.Drawing.Color.Transparent
        Me.btnAdicionarCompra.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdicionarCompra.Location = New System.Drawing.Point(580, 96)
        Me.btnAdicionarCompra.Name = "btnAdicionarCompra"
        Me.btnAdicionarCompra.Size = New System.Drawing.Size(51, 37)
        Me.btnAdicionarCompra.TabIndex = 120
        Me.btnAdicionarCompra.TabStop = False
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.Transparent
        Me.btnOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOK.Location = New System.Drawing.Point(463, 442)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(124, 33)
        Me.btnOK.TabIndex = 121
        Me.btnOK.TabStop = False
        '
        'txtid_nota
        '
        Me.txtid_nota.BackColor = System.Drawing.Color.White
        Me.txtid_nota.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtid_nota.Enabled = False
        Me.txtid_nota.ForeColor = System.Drawing.Color.Black
        Me.txtid_nota.Location = New System.Drawing.Point(145, 56)
        Me.txtid_nota.Name = "txtid_nota"
        Me.txtid_nota.Size = New System.Drawing.Size(105, 13)
        Me.txtid_nota.TabIndex = 123
        '
        'txtcodlivro
        '
        Me.txtcodlivro.BackColor = System.Drawing.Color.White
        Me.txtcodlivro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcodlivro.Enabled = False
        Me.txtcodlivro.ForeColor = System.Drawing.Color.Black
        Me.txtcodlivro.Location = New System.Drawing.Point(187, 323)
        Me.txtcodlivro.Name = "txtcodlivro"
        Me.txtcodlivro.Size = New System.Drawing.Size(147, 13)
        Me.txtcodlivro.TabIndex = 124
        '
        'txtQtde
        '
        Me.txtQtde.BackColor = System.Drawing.Color.White
        Me.txtQtde.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtQtde.Enabled = False
        Me.txtQtde.ForeColor = System.Drawing.Color.Black
        Me.txtQtde.Location = New System.Drawing.Point(502, 362)
        Me.txtQtde.Name = "txtQtde"
        Me.txtQtde.Size = New System.Drawing.Size(137, 13)
        Me.txtQtde.TabIndex = 5
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'mskDataEmissao
        '
        Me.mskDataEmissao.AutoSize = True
        Me.mskDataEmissao.BackColor = System.Drawing.Color.Transparent
        Me.mskDataEmissao.ForeColor = System.Drawing.Color.Black
        Me.mskDataEmissao.Location = New System.Drawing.Point(455, 60)
        Me.mskDataEmissao.Name = "mskDataEmissao"
        Me.mskDataEmissao.Size = New System.Drawing.Size(110, 13)
        Me.mskDataEmissao.TabIndex = 126
        Me.mskDataEmissao.Text = "__/__/____ __:__:__"
        '
        'pbxPesquisar
        '
        Me.pbxPesquisar.AccessibleDescription = " "
        Me.pbxPesquisar.BackColor = System.Drawing.Color.Transparent
        Me.pbxPesquisar.Enabled = False
        Me.pbxPesquisar.Image = CType(resources.GetObject("pbxPesquisar.Image"), System.Drawing.Image)
        Me.pbxPesquisar.Location = New System.Drawing.Point(539, 50)
        Me.pbxPesquisar.Name = "pbxPesquisar"
        Me.pbxPesquisar.Size = New System.Drawing.Size(127, 51)
        Me.pbxPesquisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxPesquisar.TabIndex = 127
        Me.pbxPesquisar.TabStop = False
        Me.pbxPesquisar.Visible = False
        '
        'dtgCarrinho
        '
        Me.dtgCarrinho.AllowUserToAddRows = False
        Me.dtgCarrinho.AllowUserToDeleteRows = False
        Me.dtgCarrinho.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dtgCarrinho.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgCarrinho.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dtgCarrinho.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgCarrinho.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dtgCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgCarrinho.Cursor = System.Windows.Forms.Cursors.Default
        Me.dtgCarrinho.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtgCarrinho.Location = New System.Drawing.Point(397, 175)
        Me.dtgCarrinho.Name = "dtgCarrinho"
        Me.dtgCarrinho.ReadOnly = True
        Me.dtgCarrinho.Size = New System.Drawing.Size(221, 124)
        Me.dtgCarrinho.TabIndex = 128
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Location = New System.Drawing.Point(298, 172)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(64, 42)
        Me.btnAdd.TabIndex = 129
        Me.btnAdd.TabStop = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Location = New System.Drawing.Point(300, 250)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(64, 42)
        Me.btnDelete.TabIndex = 130
        Me.btnDelete.TabStop = False
        '
        'cboPesquisaNota
        '
        Me.cboPesquisaNota.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cboPesquisaNota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPesquisaNota.ForeColor = System.Drawing.SystemColors.MenuText
        Me.cboPesquisaNota.FormattingEnabled = True
        Me.cboPesquisaNota.Items.AddRange(New Object() {"ID", "Título", "ISBN"})
        Me.cboPesquisaNota.Location = New System.Drawing.Point(119, 104)
        Me.cboPesquisaNota.Name = "cboPesquisaNota"
        Me.cboPesquisaNota.Size = New System.Drawing.Size(194, 21)
        Me.cboPesquisaNota.TabIndex = 1
        '
        'txtValorUnit
        '
        Me.txtValorUnit.BackColor = System.Drawing.Color.White
        Me.txtValorUnit.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtValorUnit.Enabled = False
        Me.txtValorUnit.ForeColor = System.Drawing.Color.Black
        Me.txtValorUnit.Location = New System.Drawing.Point(489, 327)
        Me.txtValorUnit.Name = "txtValorUnit"
        Me.txtValorUnit.Size = New System.Drawing.Size(151, 13)
        Me.txtValorUnit.TabIndex = 133
        '
        'cbocarrinho
        '
        Me.cbocarrinho.BackColor = System.Drawing.Color.PowderBlue
        Me.cbocarrinho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbocarrinho.Enabled = False
        Me.cbocarrinho.FormattingEnabled = True
        Me.cbocarrinho.Location = New System.Drawing.Point(326, 444)
        Me.cbocarrinho.Name = "cbocarrinho"
        Me.cbocarrinho.Size = New System.Drawing.Size(50, 24)
        Me.cbocarrinho.TabIndex = 134
        Me.cbocarrinho.Visible = False
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.Transparent
        Me.btnHelp.Cursor = System.Windows.Forms.Cursors.Help
        Me.btnHelp.Location = New System.Drawing.Point(588, 14)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(24, 20)
        Me.btnHelp.TabIndex = 136
        Me.btnHelp.TabStop = False
        '
        'btnEND
        '
        Me.btnEND.BackColor = System.Drawing.Color.Transparent
        Me.btnEND.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEND.Location = New System.Drawing.Point(613, 15)
        Me.btnEND.Name = "btnEND"
        Me.btnEND.Size = New System.Drawing.Size(24, 20)
        Me.btnEND.TabIndex = 135
        Me.btnEND.TabStop = False
        '
        'NotaFiscal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(666, 503)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnEND)
        Me.Controls.Add(Me.cbocarrinho)
        Me.Controls.Add(Me.txtValorUnit)
        Me.Controls.Add(Me.cboPesquisaNota)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dtgCarrinho)
        Me.Controls.Add(Me.pbxPesquisar)
        Me.Controls.Add(Me.mskDataEmissao)
        Me.Controls.Add(Me.txtQtde)
        Me.Controls.Add(Me.txtcodlivro)
        Me.Controls.Add(Me.txtid_nota)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnAdicionarCompra)
        Me.Controls.Add(Me.txtLivroNota)
        Me.Controls.Add(Me.cboFuncNota)
        Me.Controls.Add(Me.txtValorItem)
        Me.Controls.Add(Me.cboCodLivro)
        Me.Controls.Add(Me.mskCPF)
        Me.Controls.Add(Me.ID_Nota)
        Me.Controls.Add(Me.Label69)
        Me.Controls.Add(Me.lblValorTotal)
        Me.Controls.Add(Me.txtPesquisaNota)
        Me.Controls.Add(Me.dtgNota)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NotaFiscal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nota Fiscal"
        CType(Me.dtgNota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAdicionarCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnOK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxPesquisar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgCarrinho, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnHelp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEND, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtLivroNota As System.Windows.Forms.TextBox
    Friend WithEvents cboFuncNota As System.Windows.Forms.ComboBox
    Friend WithEvents txtValorItem As System.Windows.Forms.TextBox
    Friend WithEvents cboCodLivro As System.Windows.Forms.ComboBox
    Friend WithEvents mskCPF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ID_Nota As System.Windows.Forms.ComboBox
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents lblValorTotal As System.Windows.Forms.Label
    Friend WithEvents txtPesquisaNota As System.Windows.Forms.TextBox
    Friend WithEvents dtgNota As System.Windows.Forms.DataGridView
    Friend WithEvents btnAdicionarCompra As System.Windows.Forms.PictureBox
    Friend WithEvents btnOK As System.Windows.Forms.PictureBox
    Friend WithEvents txtid_nota As System.Windows.Forms.TextBox
    Friend WithEvents txtcodlivro As System.Windows.Forms.TextBox
    Friend WithEvents txtQtde As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents mskDataEmissao As System.Windows.Forms.Label
    Friend WithEvents pbxPesquisar As System.Windows.Forms.PictureBox
    Friend WithEvents dtgCarrinho As System.Windows.Forms.DataGridView
    Friend WithEvents btnAdd As System.Windows.Forms.PictureBox
    Friend WithEvents btnDelete As System.Windows.Forms.PictureBox
    Friend WithEvents cboPesquisaNota As System.Windows.Forms.ComboBox
    Friend WithEvents txtValorUnit As System.Windows.Forms.TextBox
    Friend WithEvents cbocarrinho As System.Windows.Forms.ComboBox
    Friend WithEvents btnHelp As System.Windows.Forms.PictureBox
    Friend WithEvents btnEND As System.Windows.Forms.PictureBox
End Class
