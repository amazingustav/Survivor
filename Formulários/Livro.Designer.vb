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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Livro))
        Me.txtGenero = New System.Windows.Forms.TextBox
        Me.cboFornLivro = New System.Windows.Forms.ComboBox
        Me.ID_Livro = New System.Windows.Forms.ComboBox
        Me.mskPrecoLivro = New System.Windows.Forms.MaskedTextBox
        Me.pbxLivro = New System.Windows.Forms.PictureBox
        Me.txtEditora = New System.Windows.Forms.TextBox
        Me.txtAutorLivro = New System.Windows.Forms.TextBox
        Me.txtISBN = New System.Windows.Forms.TextBox
        Me.txtTituloLivro = New System.Windows.Forms.TextBox
        Me.txtPesquisaLivro = New System.Windows.Forms.TextBox
        Me.dtgLivro = New System.Windows.Forms.DataGridView
        Me.cboPesquisaLivro = New System.Windows.Forms.TextBox
        Me.txtIDLivro = New System.Windows.Forms.TextBox
        Me.btnInserirImg = New System.Windows.Forms.PictureBox
        Me.btnNovoLivro = New System.Windows.Forms.PictureBox
        Me.btnCadastraLivro = New System.Windows.Forms.PictureBox
        Me.btnAlterLivro = New System.Windows.Forms.PictureBox
        Me.btnExcluiLivro = New System.Windows.Forms.PictureBox
        Me.btnPesquisaLivro = New System.Windows.Forms.PictureBox
        Me.btnSinopse = New System.Windows.Forms.PictureBox
        Me.pbxExclui = New System.Windows.Forms.PictureBox
        Me.pbxAlter = New System.Windows.Forms.PictureBox
        Me.pbxNovo = New System.Windows.Forms.PictureBox
        Me.pbxCadastrar = New System.Windows.Forms.PictureBox
        Me.pbxEscolherfoto = New System.Windows.Forms.PictureBox
        Me.pbxSinopse = New System.Windows.Forms.PictureBox
        Me.pbxPesquisar = New System.Windows.Forms.PictureBox
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
        Me.SuspendLayout()
        '
        'txtGenero
        '
        Me.txtGenero.BackColor = System.Drawing.Color.Silver
        Me.txtGenero.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGenero.ForeColor = System.Drawing.Color.Black
        Me.txtGenero.Location = New System.Drawing.Point(379, 21)
        Me.txtGenero.Name = "txtGenero"
        Me.txtGenero.Size = New System.Drawing.Size(104, 13)
        Me.txtGenero.TabIndex = 7
        '
        'cboFornLivro
        '
        Me.cboFornLivro.ForeColor = System.Drawing.Color.Black
        Me.cboFornLivro.FormattingEnabled = True
        Me.cboFornLivro.Location = New System.Drawing.Point(152, 178)
        Me.cboFornLivro.Name = "cboFornLivro"
        Me.cboFornLivro.Size = New System.Drawing.Size(117, 21)
        Me.cboFornLivro.TabIndex = 6
        '
        'ID_Livro
        '
        Me.ID_Livro.BackColor = System.Drawing.Color.PowderBlue
        Me.ID_Livro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ID_Livro.Enabled = False
        Me.ID_Livro.FormattingEnabled = True
        Me.ID_Livro.Location = New System.Drawing.Point(237, 271)
        Me.ID_Livro.Name = "ID_Livro"
        Me.ID_Livro.Size = New System.Drawing.Size(77, 24)
        Me.ID_Livro.TabIndex = 88
        Me.ID_Livro.Visible = False
        '
        'mskPrecoLivro
        '
        Me.mskPrecoLivro.BackColor = System.Drawing.Color.Silver
        Me.mskPrecoLivro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mskPrecoLivro.ForeColor = System.Drawing.Color.Black
        Me.mskPrecoLivro.Location = New System.Drawing.Point(152, 132)
        Me.mskPrecoLivro.Mask = "99,99"
        Me.mskPrecoLivro.Name = "mskPrecoLivro"
        Me.mskPrecoLivro.Size = New System.Drawing.Size(117, 13)
        Me.mskPrecoLivro.TabIndex = 4
        '
        'pbxLivro
        '
        Me.pbxLivro.BackColor = System.Drawing.Color.DarkGray
        Me.pbxLivro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxLivro.Location = New System.Drawing.Point(327, 95)
        Me.pbxLivro.Name = "pbxLivro"
        Me.pbxLivro.Size = New System.Drawing.Size(140, 170)
        Me.pbxLivro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbxLivro.TabIndex = 80
        Me.pbxLivro.TabStop = False
        '
        'txtEditora
        '
        Me.txtEditora.BackColor = System.Drawing.Color.Silver
        Me.txtEditora.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEditora.ForeColor = System.Drawing.Color.Black
        Me.txtEditora.Location = New System.Drawing.Point(152, 156)
        Me.txtEditora.Name = "txtEditora"
        Me.txtEditora.Size = New System.Drawing.Size(117, 13)
        Me.txtEditora.TabIndex = 5
        '
        'txtAutorLivro
        '
        Me.txtAutorLivro.BackColor = System.Drawing.Color.Silver
        Me.txtAutorLivro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAutorLivro.ForeColor = System.Drawing.Color.Black
        Me.txtAutorLivro.Location = New System.Drawing.Point(152, 105)
        Me.txtAutorLivro.Name = "txtAutorLivro"
        Me.txtAutorLivro.Size = New System.Drawing.Size(117, 13)
        Me.txtAutorLivro.TabIndex = 3
        '
        'txtISBN
        '
        Me.txtISBN.BackColor = System.Drawing.Color.Silver
        Me.txtISBN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtISBN.ForeColor = System.Drawing.Color.Black
        Me.txtISBN.Location = New System.Drawing.Point(152, 54)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(117, 13)
        Me.txtISBN.TabIndex = 1
        '
        'txtTituloLivro
        '
        Me.txtTituloLivro.BackColor = System.Drawing.Color.Silver
        Me.txtTituloLivro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTituloLivro.ForeColor = System.Drawing.Color.Black
        Me.txtTituloLivro.Location = New System.Drawing.Point(152, 81)
        Me.txtTituloLivro.Name = "txtTituloLivro"
        Me.txtTituloLivro.Size = New System.Drawing.Size(117, 13)
        Me.txtTituloLivro.TabIndex = 2
        '
        'txtPesquisaLivro
        '
        Me.txtPesquisaLivro.BackColor = System.Drawing.Color.Silver
        Me.txtPesquisaLivro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPesquisaLivro.ForeColor = System.Drawing.Color.Black
        Me.txtPesquisaLivro.Location = New System.Drawing.Point(291, 315)
        Me.txtPesquisaLivro.Name = "txtPesquisaLivro"
        Me.txtPesquisaLivro.Size = New System.Drawing.Size(227, 13)
        Me.txtPesquisaLivro.TabIndex = 9
        '
        'dtgLivro
        '
        Me.dtgLivro.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dtgLivro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgLivro.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dtgLivro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgLivro.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgLivro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgLivro.Cursor = System.Windows.Forms.Cursors.Cross
        Me.dtgLivro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtgLivro.Location = New System.Drawing.Point(45, 341)
        Me.dtgLivro.Name = "dtgLivro"
        Me.dtgLivro.Size = New System.Drawing.Size(569, 127)
        Me.dtgLivro.TabIndex = 92
        '
        'cboPesquisaLivro
        '
        Me.cboPesquisaLivro.AutoCompleteCustomSource.AddRange(New String() {"Nível", "Nome"})
        Me.cboPesquisaLivro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboPesquisaLivro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cboPesquisaLivro.BackColor = System.Drawing.Color.Silver
        Me.cboPesquisaLivro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cboPesquisaLivro.ForeColor = System.Drawing.Color.Black
        Me.cboPesquisaLivro.Location = New System.Drawing.Point(109, 315)
        Me.cboPesquisaLivro.Name = "cboPesquisaLivro"
        Me.cboPesquisaLivro.Size = New System.Drawing.Size(118, 13)
        Me.cboPesquisaLivro.TabIndex = 8
        '
        'txtIDLivro
        '
        Me.txtIDLivro.BackColor = System.Drawing.Color.PowderBlue
        Me.txtIDLivro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIDLivro.Enabled = False
        Me.txtIDLivro.Location = New System.Drawing.Point(151, 26)
        Me.txtIDLivro.Name = "txtIDLivro"
        Me.txtIDLivro.Size = New System.Drawing.Size(61, 13)
        Me.txtIDLivro.TabIndex = 97
        '
        'btnInserirImg
        '
        Me.btnInserirImg.BackColor = System.Drawing.Color.Transparent
        Me.btnInserirImg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInserirImg.Location = New System.Drawing.Point(350, 41)
        Me.btnInserirImg.Name = "btnInserirImg"
        Me.btnInserirImg.Size = New System.Drawing.Size(76, 50)
        Me.btnInserirImg.TabIndex = 98
        Me.btnInserirImg.TabStop = False
        '
        'btnNovoLivro
        '
        Me.btnNovoLivro.BackColor = System.Drawing.Color.Transparent
        Me.btnNovoLivro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNovoLivro.Location = New System.Drawing.Point(521, 14)
        Me.btnNovoLivro.Name = "btnNovoLivro"
        Me.btnNovoLivro.Size = New System.Drawing.Size(52, 55)
        Me.btnNovoLivro.TabIndex = 99
        Me.btnNovoLivro.TabStop = False
        '
        'btnCadastraLivro
        '
        Me.btnCadastraLivro.BackColor = System.Drawing.Color.Transparent
        Me.btnCadastraLivro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCadastraLivro.Location = New System.Drawing.Point(521, 77)
        Me.btnCadastraLivro.Name = "btnCadastraLivro"
        Me.btnCadastraLivro.Size = New System.Drawing.Size(52, 55)
        Me.btnCadastraLivro.TabIndex = 100
        Me.btnCadastraLivro.TabStop = False
        '
        'btnAlterLivro
        '
        Me.btnAlterLivro.BackColor = System.Drawing.Color.Transparent
        Me.btnAlterLivro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAlterLivro.Location = New System.Drawing.Point(521, 148)
        Me.btnAlterLivro.Name = "btnAlterLivro"
        Me.btnAlterLivro.Size = New System.Drawing.Size(52, 55)
        Me.btnAlterLivro.TabIndex = 101
        Me.btnAlterLivro.TabStop = False
        '
        'btnExcluiLivro
        '
        Me.btnExcluiLivro.BackColor = System.Drawing.Color.Transparent
        Me.btnExcluiLivro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluiLivro.Location = New System.Drawing.Point(519, 212)
        Me.btnExcluiLivro.Name = "btnExcluiLivro"
        Me.btnExcluiLivro.Size = New System.Drawing.Size(51, 55)
        Me.btnExcluiLivro.TabIndex = 102
        Me.btnExcluiLivro.TabStop = False
        '
        'btnPesquisaLivro
        '
        Me.btnPesquisaLivro.BackColor = System.Drawing.Color.Transparent
        Me.btnPesquisaLivro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPesquisaLivro.Location = New System.Drawing.Point(536, 296)
        Me.btnPesquisaLivro.Name = "btnPesquisaLivro"
        Me.btnPesquisaLivro.Size = New System.Drawing.Size(52, 38)
        Me.btnPesquisaLivro.TabIndex = 103
        Me.btnPesquisaLivro.TabStop = False
        '
        'btnSinopse
        '
        Me.btnSinopse.BackColor = System.Drawing.Color.Transparent
        Me.btnSinopse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSinopse.Location = New System.Drawing.Point(44, 213)
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
        Me.pbxExclui.Location = New System.Drawing.Point(558, 228)
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
        Me.pbxAlter.Location = New System.Drawing.Point(561, 162)
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
        Me.pbxNovo.Location = New System.Drawing.Point(561, 27)
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
        Me.pbxCadastrar.Location = New System.Drawing.Point(557, 97)
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
        Me.pbxEscolherfoto.Location = New System.Drawing.Point(306, -3)
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
        Me.pbxSinopse.Location = New System.Drawing.Point(97, 219)
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
        Me.pbxPesquisar.Location = New System.Drawing.Point(536, 302)
        Me.pbxPesquisar.Name = "pbxPesquisar"
        Me.pbxPesquisar.Size = New System.Drawing.Size(113, 44)
        Me.pbxPesquisar.TabIndex = 114
        Me.pbxPesquisar.TabStop = False
        Me.pbxPesquisar.Visible = False
        '
        'Livro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(648, 489)
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
        Me.Controls.Add(Me.cboPesquisaLivro)
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
    Friend WithEvents cboPesquisaLivro As System.Windows.Forms.TextBox
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
End Class
