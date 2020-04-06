<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Livro
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Livro))
        Me.txtGenero = New System.Windows.Forms.TextBox()
        Me.cboFornLivro = New System.Windows.Forms.ComboBox()
        Me.ID_Livro = New System.Windows.Forms.ComboBox()
        Me.mskPrecoLivro = New System.Windows.Forms.MaskedTextBox()
        Me.pbxLivro = New System.Windows.Forms.PictureBox()
        Me.txtEditora = New System.Windows.Forms.TextBox()
        Me.txtAutorLivro = New System.Windows.Forms.TextBox()
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.txtTituloLivro = New System.Windows.Forms.TextBox()
        Me.txtPesquisaLivro = New System.Windows.Forms.TextBox()
        Me.dtgLivro = New System.Windows.Forms.DataGridView()
        Me.txtIDLivro = New System.Windows.Forms.TextBox()
        Me.btnInserirImg = New System.Windows.Forms.PictureBox()
        Me.btnNovoLivro = New System.Windows.Forms.PictureBox()
        Me.btnCadastraLivro = New System.Windows.Forms.PictureBox()
        Me.btnAlterLivro = New System.Windows.Forms.PictureBox()
        Me.btnExcluiLivro = New System.Windows.Forms.PictureBox()
        Me.btnPesquisaLivro = New System.Windows.Forms.PictureBox()
        Me.btnSinopse = New System.Windows.Forms.PictureBox()
        Me.pbxExclui = New System.Windows.Forms.PictureBox()
        Me.pbxAlter = New System.Windows.Forms.PictureBox()
        Me.pbxNovo = New System.Windows.Forms.PictureBox()
        Me.pbxCadastrar = New System.Windows.Forms.PictureBox()
        Me.pbxEscolherfoto = New System.Windows.Forms.PictureBox()
        Me.pbxSinopse = New System.Windows.Forms.PictureBox()
        Me.pbxPesquisar = New System.Windows.Forms.PictureBox()
        Me.txtQtde = New System.Windows.Forms.TextBox()
        Me.cboPesquisaLivro = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnHelp = New System.Windows.Forms.PictureBox()
        Me.btnEND = New System.Windows.Forms.PictureBox()
        Me.txtEdicao = New System.Windows.Forms.TextBox()
        Me.btnAddAutor = New System.Windows.Forms.PictureBox()
        Me.pbxAutor = New System.Windows.Forms.PictureBox()
        CType(Me.pbxLivro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgLivro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnInserirImg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNovoLivro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCadastraLivro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAlterLivro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExcluiLivro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPesquisaLivro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSinopse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxExclui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxAlter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxNovo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxCadastrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxEscolherfoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxSinopse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxPesquisar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEND, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAddAutor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxAutor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtGenero
        '
        Me.txtGenero.BackColor = System.Drawing.Color.White
        Me.txtGenero.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGenero.ForeColor = System.Drawing.Color.Black
        Me.txtGenero.Location = New System.Drawing.Point(89, 124)
        Me.txtGenero.Name = "txtGenero"
        Me.txtGenero.Size = New System.Drawing.Size(199, 13)
        Me.txtGenero.TabIndex = 3
        '
        'cboFornLivro
        '
        Me.cboFornLivro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFornLivro.ForeColor = System.Drawing.Color.Black
        Me.cboFornLivro.FormattingEnabled = True
        Me.cboFornLivro.Location = New System.Drawing.Point(116, 205)
        Me.cboFornLivro.Name = "cboFornLivro"
        Me.cboFornLivro.Size = New System.Drawing.Size(135, 21)
        Me.cboFornLivro.TabIndex = 7
        '
        'ID_Livro
        '
        Me.ID_Livro.BackColor = System.Drawing.Color.PowderBlue
        Me.ID_Livro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ID_Livro.Enabled = False
        Me.ID_Livro.FormattingEnabled = True
        Me.ID_Livro.Location = New System.Drawing.Point(195, 45)
        Me.ID_Livro.Name = "ID_Livro"
        Me.ID_Livro.Size = New System.Drawing.Size(77, 24)
        Me.ID_Livro.TabIndex = 88
        Me.ID_Livro.Visible = False
        '
        'mskPrecoLivro
        '
        Me.mskPrecoLivro.BackColor = System.Drawing.Color.White
        Me.mskPrecoLivro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mskPrecoLivro.ForeColor = System.Drawing.Color.Black
        Me.mskPrecoLivro.Location = New System.Drawing.Point(375, 50)
        Me.mskPrecoLivro.Mask = "99,99"
        Me.mskPrecoLivro.Name = "mskPrecoLivro"
        Me.mskPrecoLivro.Size = New System.Drawing.Size(97, 13)
        Me.mskPrecoLivro.TabIndex = 9
        '
        'pbxLivro
        '
        Me.pbxLivro.BackColor = System.Drawing.Color.DarkGray
        Me.pbxLivro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxLivro.Location = New System.Drawing.Point(359, 122)
        Me.pbxLivro.Name = "pbxLivro"
        Me.pbxLivro.Size = New System.Drawing.Size(146, 158)
        Me.pbxLivro.TabIndex = 80
        Me.pbxLivro.TabStop = False
        '
        'txtEditora
        '
        Me.txtEditora.BackColor = System.Drawing.Color.White
        Me.txtEditora.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEditora.ForeColor = System.Drawing.Color.Black
        Me.txtEditora.Location = New System.Drawing.Point(89, 144)
        Me.txtEditora.Name = "txtEditora"
        Me.txtEditora.Size = New System.Drawing.Size(199, 13)
        Me.txtEditora.TabIndex = 4
        '
        'txtAutorLivro
        '
        Me.txtAutorLivro.BackColor = System.Drawing.Color.White
        Me.txtAutorLivro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAutorLivro.ForeColor = System.Drawing.Color.Black
        Me.txtAutorLivro.Location = New System.Drawing.Point(89, 187)
        Me.txtAutorLivro.Name = "txtAutorLivro"
        Me.txtAutorLivro.Size = New System.Drawing.Size(199, 13)
        Me.txtAutorLivro.TabIndex = 6
        '
        'txtISBN
        '
        Me.txtISBN.BackColor = System.Drawing.Color.White
        Me.txtISBN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtISBN.ForeColor = System.Drawing.Color.Black
        Me.txtISBN.Location = New System.Drawing.Point(89, 79)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(199, 13)
        Me.txtISBN.TabIndex = 1
        '
        'txtTituloLivro
        '
        Me.txtTituloLivro.BackColor = System.Drawing.Color.White
        Me.txtTituloLivro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTituloLivro.ForeColor = System.Drawing.Color.Black
        Me.txtTituloLivro.Location = New System.Drawing.Point(89, 103)
        Me.txtTituloLivro.Name = "txtTituloLivro"
        Me.txtTituloLivro.Size = New System.Drawing.Size(199, 13)
        Me.txtTituloLivro.TabIndex = 2
        '
        'txtPesquisaLivro
        '
        Me.txtPesquisaLivro.BackColor = System.Drawing.Color.White
        Me.txtPesquisaLivro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPesquisaLivro.ForeColor = System.Drawing.Color.Black
        Me.txtPesquisaLivro.Location = New System.Drawing.Point(319, 326)
        Me.txtPesquisaLivro.Name = "txtPesquisaLivro"
        Me.txtPesquisaLivro.Size = New System.Drawing.Size(209, 13)
        Me.txtPesquisaLivro.TabIndex = 11
        '
        'dtgLivro
        '
        Me.dtgLivro.AllowUserToAddRows = False
        Me.dtgLivro.AllowUserToDeleteRows = False
        Me.dtgLivro.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dtgLivro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgLivro.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dtgLivro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgLivro.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgLivro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgLivro.Cursor = System.Windows.Forms.Cursors.Default
        Me.dtgLivro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtgLivro.Location = New System.Drawing.Point(40, 355)
        Me.dtgLivro.Name = "dtgLivro"
        Me.dtgLivro.ReadOnly = True
        Me.dtgLivro.Size = New System.Drawing.Size(588, 118)
        Me.dtgLivro.TabIndex = 92
        '
        'txtIDLivro
        '
        Me.txtIDLivro.BackColor = System.Drawing.Color.White
        Me.txtIDLivro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIDLivro.Enabled = False
        Me.txtIDLivro.Location = New System.Drawing.Point(88, 50)
        Me.txtIDLivro.Name = "txtIDLivro"
        Me.txtIDLivro.Size = New System.Drawing.Size(88, 13)
        Me.txtIDLivro.TabIndex = 97
        '
        'btnInserirImg
        '
        Me.btnInserirImg.BackColor = System.Drawing.Color.Transparent
        Me.btnInserirImg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInserirImg.Location = New System.Drawing.Point(384, 67)
        Me.btnInserirImg.Name = "btnInserirImg"
        Me.btnInserirImg.Size = New System.Drawing.Size(76, 50)
        Me.btnInserirImg.TabIndex = 98
        Me.btnInserirImg.TabStop = False
        '
        'btnNovoLivro
        '
        Me.btnNovoLivro.BackColor = System.Drawing.Color.Transparent
        Me.btnNovoLivro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNovoLivro.Location = New System.Drawing.Point(533, 45)
        Me.btnNovoLivro.Name = "btnNovoLivro"
        Me.btnNovoLivro.Size = New System.Drawing.Size(52, 55)
        Me.btnNovoLivro.TabIndex = 99
        Me.btnNovoLivro.TabStop = False
        '
        'btnCadastraLivro
        '
        Me.btnCadastraLivro.BackColor = System.Drawing.Color.Transparent
        Me.btnCadastraLivro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCadastraLivro.Location = New System.Drawing.Point(533, 106)
        Me.btnCadastraLivro.Name = "btnCadastraLivro"
        Me.btnCadastraLivro.Size = New System.Drawing.Size(52, 55)
        Me.btnCadastraLivro.TabIndex = 100
        Me.btnCadastraLivro.TabStop = False
        '
        'btnAlterLivro
        '
        Me.btnAlterLivro.BackColor = System.Drawing.Color.Transparent
        Me.btnAlterLivro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAlterLivro.Location = New System.Drawing.Point(534, 171)
        Me.btnAlterLivro.Name = "btnAlterLivro"
        Me.btnAlterLivro.Size = New System.Drawing.Size(52, 55)
        Me.btnAlterLivro.TabIndex = 101
        Me.btnAlterLivro.TabStop = False
        '
        'btnExcluiLivro
        '
        Me.btnExcluiLivro.BackColor = System.Drawing.Color.Transparent
        Me.btnExcluiLivro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluiLivro.Location = New System.Drawing.Point(531, 232)
        Me.btnExcluiLivro.Name = "btnExcluiLivro"
        Me.btnExcluiLivro.Size = New System.Drawing.Size(51, 55)
        Me.btnExcluiLivro.TabIndex = 102
        Me.btnExcluiLivro.TabStop = False
        '
        'btnPesquisaLivro
        '
        Me.btnPesquisaLivro.BackColor = System.Drawing.Color.Transparent
        Me.btnPesquisaLivro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPesquisaLivro.Location = New System.Drawing.Point(536, 310)
        Me.btnPesquisaLivro.Name = "btnPesquisaLivro"
        Me.btnPesquisaLivro.Size = New System.Drawing.Size(52, 38)
        Me.btnPesquisaLivro.TabIndex = 103
        Me.btnPesquisaLivro.TabStop = False
        '
        'btnSinopse
        '
        Me.btnSinopse.BackColor = System.Drawing.Color.Transparent
        Me.btnSinopse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSinopse.Location = New System.Drawing.Point(289, 226)
        Me.btnSinopse.Name = "btnSinopse"
        Me.btnSinopse.Size = New System.Drawing.Size(63, 60)
        Me.btnSinopse.TabIndex = 104
        Me.btnSinopse.TabStop = False
        '
        'pbxExclui
        '
        Me.pbxExclui.AccessibleDescription = " "
        Me.pbxExclui.BackColor = System.Drawing.Color.Transparent
        Me.pbxExclui.Enabled = False
        Me.pbxExclui.Image = CType(resources.GetObject("pbxExclui.Image"), System.Drawing.Image)
        Me.pbxExclui.Location = New System.Drawing.Point(570, 248)
        Me.pbxExclui.Name = "pbxExclui"
        Me.pbxExclui.Size = New System.Drawing.Size(85, 44)
        Me.pbxExclui.TabIndex = 111
        Me.pbxExclui.TabStop = False
        Me.pbxExclui.Visible = False
        '
        'pbxAlter
        '
        Me.pbxAlter.AccessibleDescription = " "
        Me.pbxAlter.BackColor = System.Drawing.Color.Transparent
        Me.pbxAlter.Enabled = False
        Me.pbxAlter.Image = CType(resources.GetObject("pbxAlter.Image"), System.Drawing.Image)
        Me.pbxAlter.Location = New System.Drawing.Point(574, 185)
        Me.pbxAlter.Name = "pbxAlter"
        Me.pbxAlter.Size = New System.Drawing.Size(82, 32)
        Me.pbxAlter.TabIndex = 110
        Me.pbxAlter.TabStop = False
        Me.pbxAlter.Visible = False
        '
        'pbxNovo
        '
        Me.pbxNovo.AccessibleDescription = " "
        Me.pbxNovo.BackColor = System.Drawing.Color.Transparent
        Me.pbxNovo.Enabled = False
        Me.pbxNovo.Image = CType(resources.GetObject("pbxNovo.Image"), System.Drawing.Image)
        Me.pbxNovo.Location = New System.Drawing.Point(573, 58)
        Me.pbxNovo.Name = "pbxNovo"
        Me.pbxNovo.Size = New System.Drawing.Size(72, 34)
        Me.pbxNovo.TabIndex = 109
        Me.pbxNovo.TabStop = False
        Me.pbxNovo.Visible = False
        '
        'pbxCadastrar
        '
        Me.pbxCadastrar.AccessibleDescription = " "
        Me.pbxCadastrar.BackColor = System.Drawing.Color.Transparent
        Me.pbxCadastrar.Enabled = False
        Me.pbxCadastrar.Image = CType(resources.GetObject("pbxCadastrar.Image"), System.Drawing.Image)
        Me.pbxCadastrar.Location = New System.Drawing.Point(569, 126)
        Me.pbxCadastrar.Name = "pbxCadastrar"
        Me.pbxCadastrar.Size = New System.Drawing.Size(90, 37)
        Me.pbxCadastrar.TabIndex = 108
        Me.pbxCadastrar.TabStop = False
        Me.pbxCadastrar.Visible = False
        '
        'pbxEscolherfoto
        '
        Me.pbxEscolherfoto.AccessibleDescription = " "
        Me.pbxEscolherfoto.BackColor = System.Drawing.Color.Transparent
        Me.pbxEscolherfoto.Enabled = False
        Me.pbxEscolherfoto.Image = CType(resources.GetObject("pbxEscolherfoto.Image"), System.Drawing.Image)
        Me.pbxEscolherfoto.Location = New System.Drawing.Point(318, 35)
        Me.pbxEscolherfoto.Name = "pbxEscolherfoto"
        Me.pbxEscolherfoto.Size = New System.Drawing.Size(161, 47)
        Me.pbxEscolherfoto.TabIndex = 112
        Me.pbxEscolherfoto.TabStop = False
        Me.pbxEscolherfoto.Visible = False
        '
        'pbxSinopse
        '
        Me.pbxSinopse.AccessibleDescription = " "
        Me.pbxSinopse.BackColor = System.Drawing.Color.Transparent
        Me.pbxSinopse.Enabled = False
        Me.pbxSinopse.Image = CType(resources.GetObject("pbxSinopse.Image"), System.Drawing.Image)
        Me.pbxSinopse.Location = New System.Drawing.Point(331, 242)
        Me.pbxSinopse.Name = "pbxSinopse"
        Me.pbxSinopse.Size = New System.Drawing.Size(174, 47)
        Me.pbxSinopse.TabIndex = 113
        Me.pbxSinopse.TabStop = False
        Me.pbxSinopse.Visible = False
        '
        'pbxPesquisar
        '
        Me.pbxPesquisar.AccessibleDescription = " "
        Me.pbxPesquisar.BackColor = System.Drawing.Color.Transparent
        Me.pbxPesquisar.Enabled = False
        Me.pbxPesquisar.Image = CType(resources.GetObject("pbxPesquisar.Image"), System.Drawing.Image)
        Me.pbxPesquisar.Location = New System.Drawing.Point(511, 274)
        Me.pbxPesquisar.Name = "pbxPesquisar"
        Me.pbxPesquisar.Size = New System.Drawing.Size(134, 57)
        Me.pbxPesquisar.TabIndex = 114
        Me.pbxPesquisar.TabStop = False
        Me.pbxPesquisar.Visible = False
        '
        'txtQtde
        '
        Me.txtQtde.BackColor = System.Drawing.Color.White
        Me.txtQtde.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtQtde.ForeColor = System.Drawing.Color.Black
        Me.txtQtde.Location = New System.Drawing.Point(118, 231)
        Me.txtQtde.Name = "txtQtde"
        Me.txtQtde.Size = New System.Drawing.Size(133, 13)
        Me.txtQtde.TabIndex = 8
        '
        'cboPesquisaLivro
        '
        Me.cboPesquisaLivro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPesquisaLivro.FormattingEnabled = True
        Me.cboPesquisaLivro.Items.AddRange(New Object() {"ID", "Título", "ISBN", "Autor", "Editora", "Gênero"})
        Me.cboPesquisaLivro.Location = New System.Drawing.Point(113, 321)
        Me.cboPesquisaLivro.Name = "cboPesquisaLivro"
        Me.cboPesquisaLivro.Size = New System.Drawing.Size(172, 21)
        Me.cboPesquisaLivro.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(22, 264)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 23)
        Me.Label1.TabIndex = 126
        Me.Label1.Text = "(*) Campos obrigatórios!"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(294, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 23)
        Me.Label7.TabIndex = 125
        Me.Label7.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(294, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 23)
        Me.Label2.TabIndex = 127
        Me.Label2.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(294, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 23)
        Me.Label3.TabIndex = 129
        Me.Label3.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(294, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 23)
        Me.Label4.TabIndex = 128
        Me.Label4.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(293, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 23)
        Me.Label5.TabIndex = 131
        Me.Label5.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(293, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 23)
        Me.Label6.TabIndex = 130
        Me.Label6.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(252, 229)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(20, 23)
        Me.Label8.TabIndex = 133
        Me.Label8.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(252, 207)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(20, 23)
        Me.Label9.TabIndex = 132
        Me.Label9.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(477, 49)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(20, 23)
        Me.Label10.TabIndex = 134
        Me.Label10.Text = "*"
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.Transparent
        Me.btnHelp.Cursor = System.Windows.Forms.Cursors.Help
        Me.btnHelp.Location = New System.Drawing.Point(582, 12)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(24, 20)
        Me.btnHelp.TabIndex = 136
        Me.btnHelp.TabStop = False
        '
        'btnEND
        '
        Me.btnEND.BackColor = System.Drawing.Color.Transparent
        Me.btnEND.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEND.Location = New System.Drawing.Point(607, 13)
        Me.btnEND.Name = "btnEND"
        Me.btnEND.Size = New System.Drawing.Size(24, 20)
        Me.btnEND.TabIndex = 135
        Me.btnEND.TabStop = False
        '
        'txtEdicao
        '
        Me.txtEdicao.BackColor = System.Drawing.Color.White
        Me.txtEdicao.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEdicao.ForeColor = System.Drawing.Color.Black
        Me.txtEdicao.Location = New System.Drawing.Point(89, 166)
        Me.txtEdicao.Name = "txtEdicao"
        Me.txtEdicao.Size = New System.Drawing.Size(199, 13)
        Me.txtEdicao.TabIndex = 5
        '
        'btnAddAutor
        '
        Me.btnAddAutor.BackColor = System.Drawing.Color.Transparent
        Me.btnAddAutor.BackgroundImage = CType(resources.GetObject("btnAddAutor.BackgroundImage"), System.Drawing.Image)
        Me.btnAddAutor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddAutor.Location = New System.Drawing.Point(312, 182)
        Me.btnAddAutor.Name = "btnAddAutor"
        Me.btnAddAutor.Size = New System.Drawing.Size(24, 24)
        Me.btnAddAutor.TabIndex = 137
        Me.btnAddAutor.TabStop = False
        '
        'pbxAutor
        '
        Me.pbxAutor.AccessibleDescription = " "
        Me.pbxAutor.BackColor = System.Drawing.Color.Transparent
        Me.pbxAutor.Enabled = False
        Me.pbxAutor.Image = CType(resources.GetObject("pbxAutor.Image"), System.Drawing.Image)
        Me.pbxAutor.Location = New System.Drawing.Point(276, 144)
        Me.pbxAutor.Name = "pbxAutor"
        Me.pbxAutor.Size = New System.Drawing.Size(98, 47)
        Me.pbxAutor.TabIndex = 138
        Me.pbxAutor.TabStop = False
        Me.pbxAutor.Visible = False
        '
        'Livro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(666, 503)
        Me.Controls.Add(Me.pbxAutor)
        Me.Controls.Add(Me.btnAddAutor)
        Me.Controls.Add(Me.txtEdicao)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnEND)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboPesquisaLivro)
        Me.Controls.Add(Me.txtQtde)
        Me.Controls.Add(Me.pbxPesquisar)
        Me.Controls.Add(Me.pbxSinopse)
        Me.Controls.Add(Me.pbxEscolherfoto)
        Me.Controls.Add(Me.pbxExclui)
        Me.Controls.Add(Me.pbxAlter)
        Me.Controls.Add(Me.pbxNovo)
        Me.Controls.Add(Me.pbxCadastrar)
        Me.Controls.Add(Me.btnSinopse)
        Me.Controls.Add(Me.btnPesquisaLivro)
        Me.Controls.Add(Me.btnExcluiLivro)
        Me.Controls.Add(Me.btnAlterLivro)
        Me.Controls.Add(Me.btnCadastraLivro)
        Me.Controls.Add(Me.btnNovoLivro)
        Me.Controls.Add(Me.btnInserirImg)
        Me.Controls.Add(Me.txtIDLivro)
        Me.Controls.Add(Me.txtPesquisaLivro)
        Me.Controls.Add(Me.dtgLivro)
        Me.Controls.Add(Me.txtGenero)
        Me.Controls.Add(Me.cboFornLivro)
        Me.Controls.Add(Me.ID_Livro)
        Me.Controls.Add(Me.txtTituloLivro)
        Me.Controls.Add(Me.txtISBN)
        Me.Controls.Add(Me.mskPrecoLivro)
        Me.Controls.Add(Me.txtAutorLivro)
        Me.Controls.Add(Me.txtEditora)
        Me.Controls.Add(Me.pbxLivro)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Livro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Livro"
        CType(Me.pbxLivro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgLivro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnInserirImg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNovoLivro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCadastraLivro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAlterLivro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExcluiLivro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPesquisaLivro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSinopse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxExclui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxAlter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxNovo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxCadastrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxEscolherfoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxSinopse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxPesquisar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnHelp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEND, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAddAutor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxAutor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtGenero As System.Windows.Forms.TextBox
    Friend WithEvents cboFornLivro As System.Windows.Forms.ComboBox
    Friend WithEvents ID_Livro As System.Windows.Forms.ComboBox
    Friend WithEvents mskPrecoLivro As System.Windows.Forms.MaskedTextBox
    Friend WithEvents pbxLivro As System.Windows.Forms.PictureBox
    Friend WithEvents txtEditora As System.Windows.Forms.TextBox
    Friend WithEvents txtAutorLivro As System.Windows.Forms.TextBox
    Friend WithEvents txtISBN As System.Windows.Forms.TextBox
    Friend WithEvents txtTituloLivro As System.Windows.Forms.TextBox
    Friend WithEvents txtPesquisaLivro As System.Windows.Forms.TextBox
    Friend WithEvents dtgLivro As System.Windows.Forms.DataGridView
    Friend WithEvents txtIDLivro As System.Windows.Forms.TextBox
    Friend WithEvents btnInserirImg As System.Windows.Forms.PictureBox
    Friend WithEvents btnNovoLivro As System.Windows.Forms.PictureBox
    Friend WithEvents btnCadastraLivro As System.Windows.Forms.PictureBox
    Friend WithEvents btnAlterLivro As System.Windows.Forms.PictureBox
    Friend WithEvents btnExcluiLivro As System.Windows.Forms.PictureBox
    Friend WithEvents btnPesquisaLivro As System.Windows.Forms.PictureBox
    Friend WithEvents btnSinopse As System.Windows.Forms.PictureBox
    Friend WithEvents pbxExclui As System.Windows.Forms.PictureBox
    Friend WithEvents pbxAlter As System.Windows.Forms.PictureBox
    Friend WithEvents pbxNovo As System.Windows.Forms.PictureBox
    Friend WithEvents pbxCadastrar As System.Windows.Forms.PictureBox
    Friend WithEvents pbxEscolherfoto As System.Windows.Forms.PictureBox
    Friend WithEvents pbxSinopse As System.Windows.Forms.PictureBox
    Friend WithEvents pbxPesquisar As System.Windows.Forms.PictureBox
    Friend WithEvents txtQtde As System.Windows.Forms.TextBox
    Friend WithEvents cboPesquisaLivro As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnHelp As System.Windows.Forms.PictureBox
    Friend WithEvents btnEND As System.Windows.Forms.PictureBox
    Friend WithEvents txtEdicao As System.Windows.Forms.TextBox
    Friend WithEvents btnAddAutor As System.Windows.Forms.PictureBox
    Friend WithEvents pbxAutor As System.Windows.Forms.PictureBox
End Class
