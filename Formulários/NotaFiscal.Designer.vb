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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NotaFiscal))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtLivroNota = New System.Windows.Forms.TextBox()
        Me.cboFuncNota = New System.Windows.Forms.ComboBox()
        Me.txtValorVenda = New System.Windows.Forms.TextBox()
        Me.cboCodLivro = New System.Windows.Forms.ComboBox()
        Me.mskCPF = New System.Windows.Forms.MaskedTextBox()
        Me.ID_Nota = New System.Windows.Forms.ComboBox()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.lblValorTotal = New System.Windows.Forms.Label()
        Me.txtPesquisaNota = New System.Windows.Forms.TextBox()
        Me.dtgNota = New System.Windows.Forms.DataGridView()
        Me.btnAdicionarCompra = New System.Windows.Forms.PictureBox()
        Me.btnOK = New System.Windows.Forms.PictureBox()
        Me.cboPesquisaNota = New System.Windows.Forms.TextBox()
        Me.txtid_nota = New System.Windows.Forms.TextBox()
        Me.txtcodlivro = New System.Windows.Forms.TextBox()
        Me.txtQtde = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.mskDataEmissao = New System.Windows.Forms.Label()
        Me.pbxPesquisar = New System.Windows.Forms.PictureBox()
        Me.dtgCarrinho = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.PictureBox()
        Me.btnDelete = New System.Windows.Forms.PictureBox()
        CType(Me.dtgNota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAdicionarCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnOK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxPesquisar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgCarrinho, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtLivroNota
        '
        Me.txtLivroNota.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtLivroNota.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLivroNota.ForeColor = System.Drawing.Color.Black
        Me.txtLivroNota.Location = New System.Drawing.Point(220, 332)
        Me.txtLivroNota.Name = "txtLivroNota"
        Me.txtLivroNota.Size = New System.Drawing.Size(131, 13)
        Me.txtLivroNota.TabIndex = 5
        '
        'cboFuncNota
        '
        Me.cboFuncNota.ForeColor = System.Drawing.Color.Black
        Me.cboFuncNota.FormattingEnabled = True
        Me.cboFuncNota.Location = New System.Drawing.Point(219, 383)
        Me.cboFuncNota.Name = "cboFuncNota"
        Me.cboFuncNota.Size = New System.Drawing.Size(132, 21)
        Me.cboFuncNota.TabIndex = 4
        '
        'txtValorVenda
        '
        Me.txtValorVenda.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtValorVenda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtValorVenda.ForeColor = System.Drawing.Color.Black
        Me.txtValorVenda.Location = New System.Drawing.Point(539, 308)
        Me.txtValorVenda.Name = "txtValorVenda"
        Me.txtValorVenda.Size = New System.Drawing.Size(64, 13)
        Me.txtValorVenda.TabIndex = 6
        '
        'cboCodLivro
        '
        Me.cboCodLivro.BackColor = System.Drawing.Color.PowderBlue
        Me.cboCodLivro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboCodLivro.Enabled = False
        Me.cboCodLivro.FormattingEnabled = True
        Me.cboCodLivro.Location = New System.Drawing.Point(374, 421)
        Me.cboCodLivro.Name = "cboCodLivro"
        Me.cboCodLivro.Size = New System.Drawing.Size(50, 24)
        Me.cboCodLivro.TabIndex = 115
        Me.cboCodLivro.Visible = False
        '
        'mskCPF
        '
        Me.mskCPF.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.mskCPF.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mskCPF.ForeColor = System.Drawing.Color.Black
        Me.mskCPF.Location = New System.Drawing.Point(223, 358)
        Me.mskCPF.Mask = "999.999.999-99"
        Me.mskCPF.Name = "mskCPF"
        Me.mskCPF.Size = New System.Drawing.Size(111, 13)
        Me.mskCPF.TabIndex = 3
        '
        'ID_Nota
        '
        Me.ID_Nota.BackColor = System.Drawing.Color.PowderBlue
        Me.ID_Nota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ID_Nota.Enabled = False
        Me.ID_Nota.FormattingEnabled = True
        Me.ID_Nota.Location = New System.Drawing.Point(270, 421)
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
        Me.Label69.Location = New System.Drawing.Point(135, 427)
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
        Me.lblValorTotal.Location = New System.Drawing.Point(163, 427)
        Me.lblValorTotal.Name = "lblValorTotal"
        Me.lblValorTotal.Size = New System.Drawing.Size(63, 18)
        Me.lblValorTotal.TabIndex = 111
        Me.lblValorTotal.Text = "000,00"
        '
        'txtPesquisaNota
        '
        Me.txtPesquisaNota.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtPesquisaNota.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPesquisaNota.ForeColor = System.Drawing.Color.Black
        Me.txtPesquisaNota.Location = New System.Drawing.Point(290, 85)
        Me.txtPesquisaNota.Name = "txtPesquisaNota"
        Me.txtPesquisaNota.Size = New System.Drawing.Size(210, 13)
        Me.txtPesquisaNota.TabIndex = 2
        '
        'dtgNota
        '
        Me.dtgNota.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dtgNota.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgNota.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dtgNota.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgNota.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgNota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgNota.Cursor = System.Windows.Forms.Cursors.Cross
        Me.dtgNota.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtgNota.Location = New System.Drawing.Point(55, 149)
        Me.dtgNota.Name = "dtgNota"
        Me.dtgNota.Size = New System.Drawing.Size(215, 127)
        Me.dtgNota.TabIndex = 105
        '
        'btnAdicionarCompra
        '
        Me.btnAdicionarCompra.BackColor = System.Drawing.Color.Transparent
        Me.btnAdicionarCompra.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdicionarCompra.Location = New System.Drawing.Point(538, 66)
        Me.btnAdicionarCompra.Name = "btnAdicionarCompra"
        Me.btnAdicionarCompra.Size = New System.Drawing.Size(51, 37)
        Me.btnAdicionarCompra.TabIndex = 120
        Me.btnAdicionarCompra.TabStop = False
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.Transparent
        Me.btnOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOK.Location = New System.Drawing.Point(464, 418)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(114, 33)
        Me.btnOK.TabIndex = 121
        Me.btnOK.TabStop = False
        '
        'cboPesquisaNota
        '
        Me.cboPesquisaNota.AutoCompleteCustomSource.AddRange(New String() {"Código", "CNPJ", "CEP", "Bairro", "Cidade", "Fornecedor", "Endereço", "Inscrição", "Vendedor", "Telefone", "Celular", "Produtos desse fornecedor"})
        Me.cboPesquisaNota.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboPesquisaNota.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cboPesquisaNota.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.cboPesquisaNota.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cboPesquisaNota.ForeColor = System.Drawing.Color.Black
        Me.cboPesquisaNota.Location = New System.Drawing.Point(111, 85)
        Me.cboPesquisaNota.Name = "cboPesquisaNota"
        Me.cboPesquisaNota.Size = New System.Drawing.Size(133, 13)
        Me.cboPesquisaNota.TabIndex = 1
        '
        'txtid_nota
        '
        Me.txtid_nota.BackColor = System.Drawing.Color.PowderBlue
        Me.txtid_nota.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtid_nota.Enabled = False
        Me.txtid_nota.ForeColor = System.Drawing.Color.Black
        Me.txtid_nota.Location = New System.Drawing.Point(160, 34)
        Me.txtid_nota.Name = "txtid_nota"
        Me.txtid_nota.Size = New System.Drawing.Size(74, 13)
        Me.txtid_nota.TabIndex = 123
        '
        'txtcodlivro
        '
        Me.txtcodlivro.BackColor = System.Drawing.Color.PowderBlue
        Me.txtcodlivro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcodlivro.Enabled = False
        Me.txtcodlivro.ForeColor = System.Drawing.Color.Black
        Me.txtcodlivro.Location = New System.Drawing.Point(217, 303)
        Me.txtcodlivro.Name = "txtcodlivro"
        Me.txtcodlivro.Size = New System.Drawing.Size(74, 13)
        Me.txtcodlivro.TabIndex = 124
        '
        'txtQtde
        '
        Me.txtQtde.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtQtde.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtQtde.ForeColor = System.Drawing.Color.Black
        Me.txtQtde.Location = New System.Drawing.Point(541, 342)
        Me.txtQtde.Name = "txtQtde"
        Me.txtQtde.Size = New System.Drawing.Size(64, 13)
        Me.txtQtde.TabIndex = 7
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
        Me.mskDataEmissao.Location = New System.Drawing.Point(458, 32)
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
        Me.pbxPesquisar.Location = New System.Drawing.Point(540, 73)
        Me.pbxPesquisar.Name = "pbxPesquisar"
        Me.pbxPesquisar.Size = New System.Drawing.Size(113, 44)
        Me.pbxPesquisar.TabIndex = 127
        Me.pbxPesquisar.TabStop = False
        Me.pbxPesquisar.Visible = False
        '
        'dtgCarrinho
        '
        Me.dtgCarrinho.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dtgCarrinho.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgCarrinho.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dtgCarrinho.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgCarrinho.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgCarrinho.Cursor = System.Windows.Forms.Cursors.Cross
        Me.dtgCarrinho.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtgCarrinho.Location = New System.Drawing.Point(398, 149)
        Me.dtgCarrinho.Name = "dtgCarrinho"
        Me.dtgCarrinho.Size = New System.Drawing.Size(215, 127)
        Me.dtgCarrinho.TabIndex = 128
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Location = New System.Drawing.Point(300, 147)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(64, 42)
        Me.btnAdd.TabIndex = 129
        Me.btnAdd.TabStop = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Location = New System.Drawing.Point(303, 225)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(64, 42)
        Me.btnDelete.TabIndex = 130
        Me.btnDelete.TabStop = False
        '
        'NotaFiscal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(666, 503)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dtgCarrinho)
        Me.Controls.Add(Me.pbxPesquisar)
        Me.Controls.Add(Me.mskDataEmissao)
        Me.Controls.Add(Me.txtQtde)
        Me.Controls.Add(Me.txtcodlivro)
        Me.Controls.Add(Me.txtid_nota)
        Me.Controls.Add(Me.cboPesquisaNota)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnAdicionarCompra)
        Me.Controls.Add(Me.txtLivroNota)
        Me.Controls.Add(Me.cboFuncNota)
        Me.Controls.Add(Me.txtValorVenda)
        Me.Controls.Add(Me.cboCodLivro)
        Me.Controls.Add(Me.mskCPF)
        Me.Controls.Add(Me.ID_Nota)
        Me.Controls.Add(Me.Label69)
        Me.Controls.Add(Me.lblValorTotal)
        Me.Controls.Add(Me.txtPesquisaNota)
        Me.Controls.Add(Me.dtgNota)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "NotaFiscal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TopMost = True
        CType(Me.dtgNota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAdicionarCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnOK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxPesquisar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgCarrinho, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDelete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtLivroNota As System.Windows.Forms.TextBox
    Friend WithEvents cboFuncNota As System.Windows.Forms.ComboBox
    Friend WithEvents txtValorVenda As System.Windows.Forms.TextBox
    Friend WithEvents cboCodLivro As System.Windows.Forms.ComboBox
    Friend WithEvents mskCPF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ID_Nota As System.Windows.Forms.ComboBox
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents lblValorTotal As System.Windows.Forms.Label
    Friend WithEvents txtPesquisaNota As System.Windows.Forms.TextBox
    Friend WithEvents dtgNota As System.Windows.Forms.DataGridView
    Friend WithEvents btnAdicionarCompra As System.Windows.Forms.PictureBox
    Friend WithEvents btnOK As System.Windows.Forms.PictureBox
    Friend WithEvents cboPesquisaNota As System.Windows.Forms.TextBox
    Friend WithEvents txtid_nota As System.Windows.Forms.TextBox
    Friend WithEvents txtcodlivro As System.Windows.Forms.TextBox
    Friend WithEvents txtQtde As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents mskDataEmissao As System.Windows.Forms.Label
    Friend WithEvents pbxPesquisar As System.Windows.Forms.PictureBox
    Friend WithEvents dtgCarrinho As System.Windows.Forms.DataGridView
    Friend WithEvents btnAdd As System.Windows.Forms.PictureBox
    Friend WithEvents btnDelete As System.Windows.Forms.PictureBox
End Class
