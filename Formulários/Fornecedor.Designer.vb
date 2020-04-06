<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fornecedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fornecedor))
        Me.txtNomeFant = New System.Windows.Forms.TextBox
        Me.ID_Forn = New System.Windows.Forms.ComboBox
        Me.mskCNPJ = New System.Windows.Forms.MaskedTextBox
        Me.txtCidadeForn = New System.Windows.Forms.TextBox
        Me.txtBairroForn = New System.Windows.Forms.TextBox
        Me.txtEmailForn = New System.Windows.Forms.TextBox
        Me.mskCEPforn = New System.Windows.Forms.MaskedTextBox
        Me.mskTelForn = New System.Windows.Forms.MaskedTextBox
        Me.txtEnderForn = New System.Windows.Forms.TextBox
        Me.txtNomeForn = New System.Windows.Forms.TextBox
        Me.txtPesquisaForn = New System.Windows.Forms.TextBox
        Me.dtgFornecedor = New System.Windows.Forms.DataGridView
        Me.btnExcluiForn = New System.Windows.Forms.PictureBox
        Me.btnAlterForn = New System.Windows.Forms.PictureBox
        Me.btnCadastraForn = New System.Windows.Forms.PictureBox
        Me.btnNovoForn = New System.Windows.Forms.PictureBox
        Me.btnPesquisaForn = New System.Windows.Forms.PictureBox
        Me.txtIDforn = New System.Windows.Forms.TextBox
        Me.cboPesquisaForn = New System.Windows.Forms.TextBox
        Me.cboUFforn = New System.Windows.Forms.TextBox
        Me.pbxExclui = New System.Windows.Forms.PictureBox
        Me.pbxAlter = New System.Windows.Forms.PictureBox
        Me.pbxNovo = New System.Windows.Forms.PictureBox
        Me.pbxCadastrar = New System.Windows.Forms.PictureBox
        Me.pbxPesquisar = New System.Windows.Forms.PictureBox
        CType(Me.dtgFornecedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExcluiForn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAlterForn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCadastraForn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNovoForn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPesquisaForn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxExclui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxAlter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxNovo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxCadastrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxPesquisar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNomeFant
        '
        Me.txtNomeFant.BackColor = System.Drawing.Color.Silver
        Me.txtNomeFant.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNomeFant.ForeColor = System.Drawing.Color.Black
        Me.txtNomeFant.Location = New System.Drawing.Point(148, 53)
        Me.txtNomeFant.Name = "txtNomeFant"
        Me.txtNomeFant.Size = New System.Drawing.Size(116, 13)
        Me.txtNomeFant.TabIndex = 1
        '
        'ID_Forn
        '
        Me.ID_Forn.BackColor = System.Drawing.Color.PowderBlue
        Me.ID_Forn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ID_Forn.Enabled = False
        Me.ID_Forn.FormattingEnabled = True
        Me.ID_Forn.Location = New System.Drawing.Point(25, 185)
        Me.ID_Forn.Name = "ID_Forn"
        Me.ID_Forn.Size = New System.Drawing.Size(77, 24)
        Me.ID_Forn.TabIndex = 85
        Me.ID_Forn.Visible = False
        '
        'mskCNPJ
        '
        Me.mskCNPJ.BackColor = System.Drawing.Color.Silver
        Me.mskCNPJ.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mskCNPJ.ForeColor = System.Drawing.Color.Black
        Me.mskCNPJ.Location = New System.Drawing.Point(148, 104)
        Me.mskCNPJ.Mask = "00.000.000/0000-99"
        Me.mskCNPJ.Name = "mskCNPJ"
        Me.mskCNPJ.Size = New System.Drawing.Size(116, 13)
        Me.mskCNPJ.TabIndex = 3
        '
        'txtCidadeForn
        '
        Me.txtCidadeForn.BackColor = System.Drawing.Color.Silver
        Me.txtCidadeForn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCidadeForn.ForeColor = System.Drawing.Color.Black
        Me.txtCidadeForn.Location = New System.Drawing.Point(449, 25)
        Me.txtCidadeForn.Name = "txtCidadeForn"
        Me.txtCidadeForn.Size = New System.Drawing.Size(115, 13)
        Me.txtCidadeForn.TabIndex = 6
        '
        'txtBairroForn
        '
        Me.txtBairroForn.BackColor = System.Drawing.Color.Silver
        Me.txtBairroForn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBairroForn.ForeColor = System.Drawing.Color.Black
        Me.txtBairroForn.Location = New System.Drawing.Point(148, 156)
        Me.txtBairroForn.Name = "txtBairroForn"
        Me.txtBairroForn.Size = New System.Drawing.Size(116, 13)
        Me.txtBairroForn.TabIndex = 5
        '
        'txtEmailForn
        '
        Me.txtEmailForn.BackColor = System.Drawing.Color.Silver
        Me.txtEmailForn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmailForn.ForeColor = System.Drawing.Color.Black
        Me.txtEmailForn.Location = New System.Drawing.Point(448, 129)
        Me.txtEmailForn.Name = "txtEmailForn"
        Me.txtEmailForn.Size = New System.Drawing.Size(115, 13)
        Me.txtEmailForn.TabIndex = 10
        '
        'mskCEPforn
        '
        Me.mskCEPforn.BackColor = System.Drawing.Color.Silver
        Me.mskCEPforn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mskCEPforn.ForeColor = System.Drawing.Color.Black
        Me.mskCEPforn.Location = New System.Drawing.Point(448, 52)
        Me.mskCEPforn.Mask = "00000-999"
        Me.mskCEPforn.Name = "mskCEPforn"
        Me.mskCEPforn.Size = New System.Drawing.Size(78, 13)
        Me.mskCEPforn.TabIndex = 7
        '
        'mskTelForn
        '
        Me.mskTelForn.BackColor = System.Drawing.Color.Silver
        Me.mskTelForn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mskTelForn.ForeColor = System.Drawing.Color.Black
        Me.mskTelForn.Location = New System.Drawing.Point(448, 102)
        Me.mskTelForn.Mask = "(99) 0000-0000"
        Me.mskTelForn.Name = "mskTelForn"
        Me.mskTelForn.Size = New System.Drawing.Size(115, 13)
        Me.mskTelForn.TabIndex = 9
        '
        'txtEnderForn
        '
        Me.txtEnderForn.BackColor = System.Drawing.Color.Silver
        Me.txtEnderForn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEnderForn.ForeColor = System.Drawing.Color.Black
        Me.txtEnderForn.Location = New System.Drawing.Point(148, 131)
        Me.txtEnderForn.Name = "txtEnderForn"
        Me.txtEnderForn.Size = New System.Drawing.Size(116, 13)
        Me.txtEnderForn.TabIndex = 4
        '
        'txtNomeForn
        '
        Me.txtNomeForn.BackColor = System.Drawing.Color.Silver
        Me.txtNomeForn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNomeForn.ForeColor = System.Drawing.Color.Black
        Me.txtNomeForn.Location = New System.Drawing.Point(148, 79)
        Me.txtNomeForn.Name = "txtNomeForn"
        Me.txtNomeForn.Size = New System.Drawing.Size(116, 13)
        Me.txtNomeForn.TabIndex = 2
        '
        'txtPesquisaForn
        '
        Me.txtPesquisaForn.BackColor = System.Drawing.Color.Silver
        Me.txtPesquisaForn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPesquisaForn.ForeColor = System.Drawing.Color.Black
        Me.txtPesquisaForn.Location = New System.Drawing.Point(284, 312)
        Me.txtPesquisaForn.Name = "txtPesquisaForn"
        Me.txtPesquisaForn.Size = New System.Drawing.Size(220, 13)
        Me.txtPesquisaForn.TabIndex = 12
        '
        'dtgFornecedor
        '
        Me.dtgFornecedor.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dtgFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgFornecedor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dtgFornecedor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgFornecedor.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgFornecedor.Cursor = System.Windows.Forms.Cursors.Cross
        Me.dtgFornecedor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtgFornecedor.Location = New System.Drawing.Point(41, 339)
        Me.dtgFornecedor.Name = "dtgFornecedor"
        Me.dtgFornecedor.Size = New System.Drawing.Size(567, 127)
        Me.dtgFornecedor.TabIndex = 87
        '
        'btnExcluiForn
        '
        Me.btnExcluiForn.BackColor = System.Drawing.Color.Transparent
        Me.btnExcluiForn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluiForn.Location = New System.Drawing.Point(459, 209)
        Me.btnExcluiForn.Name = "btnExcluiForn"
        Me.btnExcluiForn.Size = New System.Drawing.Size(47, 54)
        Me.btnExcluiForn.TabIndex = 94
        Me.btnExcluiForn.TabStop = False
        '
        'btnAlterForn
        '
        Me.btnAlterForn.BackColor = System.Drawing.Color.Transparent
        Me.btnAlterForn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAlterForn.Location = New System.Drawing.Point(402, 210)
        Me.btnAlterForn.Name = "btnAlterForn"
        Me.btnAlterForn.Size = New System.Drawing.Size(51, 54)
        Me.btnAlterForn.TabIndex = 93
        Me.btnAlterForn.TabStop = False
        '
        'btnCadastraForn
        '
        Me.btnCadastraForn.BackColor = System.Drawing.Color.Transparent
        Me.btnCadastraForn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCadastraForn.Location = New System.Drawing.Point(343, 210)
        Me.btnCadastraForn.Name = "btnCadastraForn"
        Me.btnCadastraForn.Size = New System.Drawing.Size(51, 54)
        Me.btnCadastraForn.TabIndex = 92
        Me.btnCadastraForn.TabStop = False
        '
        'btnNovoForn
        '
        Me.btnNovoForn.BackColor = System.Drawing.Color.Transparent
        Me.btnNovoForn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNovoForn.Location = New System.Drawing.Point(285, 210)
        Me.btnNovoForn.Name = "btnNovoForn"
        Me.btnNovoForn.Size = New System.Drawing.Size(51, 54)
        Me.btnNovoForn.TabIndex = 91
        Me.btnNovoForn.TabStop = False
        '
        'btnPesquisaForn
        '
        Me.btnPesquisaForn.BackColor = System.Drawing.Color.Transparent
        Me.btnPesquisaForn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPesquisaForn.Location = New System.Drawing.Point(531, 295)
        Me.btnPesquisaForn.Name = "btnPesquisaForn"
        Me.btnPesquisaForn.Size = New System.Drawing.Size(51, 37)
        Me.btnPesquisaForn.TabIndex = 95
        Me.btnPesquisaForn.TabStop = False
        '
        'txtIDforn
        '
        Me.txtIDforn.BackColor = System.Drawing.Color.LightBlue
        Me.txtIDforn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIDforn.Enabled = False
        Me.txtIDforn.Location = New System.Drawing.Point(149, 25)
        Me.txtIDforn.Name = "txtIDforn"
        Me.txtIDforn.Size = New System.Drawing.Size(58, 13)
        Me.txtIDforn.TabIndex = 96
        '
        'cboPesquisaForn
        '
        Me.cboPesquisaForn.AutoCompleteCustomSource.AddRange(New String() {"Código", "Nome", "CNPJ", "CEP", "Bairro", "Cidade", "Endereço", "Telefone"})
        Me.cboPesquisaForn.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboPesquisaForn.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cboPesquisaForn.BackColor = System.Drawing.Color.Silver
        Me.cboPesquisaForn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cboPesquisaForn.ForeColor = System.Drawing.Color.Black
        Me.cboPesquisaForn.Location = New System.Drawing.Point(104, 312)
        Me.cboPesquisaForn.Name = "cboPesquisaForn"
        Me.cboPesquisaForn.Size = New System.Drawing.Size(133, 13)
        Me.cboPesquisaForn.TabIndex = 11
        '
        'cboUFforn
        '
        Me.cboUFforn.AutoCompleteCustomSource.AddRange(New String() {"AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.cboUFforn.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboUFforn.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cboUFforn.BackColor = System.Drawing.Color.Silver
        Me.cboUFforn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cboUFforn.ForeColor = System.Drawing.Color.Black
        Me.cboUFforn.Location = New System.Drawing.Point(448, 77)
        Me.cboUFforn.Name = "cboUFforn"
        Me.cboUFforn.Size = New System.Drawing.Size(38, 13)
        Me.cboUFforn.TabIndex = 8
        '
        'pbxExclui
        '
        Me.pbxExclui.AccessibleDescription = " "
        Me.pbxExclui.BackColor = System.Drawing.Color.Transparent
        Me.pbxExclui.Enabled = False
        Me.pbxExclui.Image = CType(resources.GetObject("pbxExclui.Image"), System.Drawing.Image)
        Me.pbxExclui.Location = New System.Drawing.Point(452, 255)
        Me.pbxExclui.Name = "pbxExclui"
        Me.pbxExclui.Size = New System.Drawing.Size(67, 44)
        Me.pbxExclui.TabIndex = 102
        Me.pbxExclui.TabStop = False
        Me.pbxExclui.Visible = False
        '
        'pbxAlter
        '
        Me.pbxAlter.AccessibleDescription = " "
        Me.pbxAlter.BackColor = System.Drawing.Color.Transparent
        Me.pbxAlter.Enabled = False
        Me.pbxAlter.Image = CType(resources.GetObject("pbxAlter.Image"), System.Drawing.Image)
        Me.pbxAlter.Location = New System.Drawing.Point(391, 252)
        Me.pbxAlter.Name = "pbxAlter"
        Me.pbxAlter.Size = New System.Drawing.Size(71, 44)
        Me.pbxAlter.TabIndex = 101
        Me.pbxAlter.TabStop = False
        Me.pbxAlter.Visible = False
        '
        'pbxNovo
        '
        Me.pbxNovo.AccessibleDescription = " "
        Me.pbxNovo.BackColor = System.Drawing.Color.Transparent
        Me.pbxNovo.Enabled = False
        Me.pbxNovo.Image = CType(resources.GetObject("pbxNovo.Image"), System.Drawing.Image)
        Me.pbxNovo.Location = New System.Drawing.Point(275, 253)
        Me.pbxNovo.Name = "pbxNovo"
        Me.pbxNovo.Size = New System.Drawing.Size(66, 44)
        Me.pbxNovo.TabIndex = 100
        Me.pbxNovo.TabStop = False
        Me.pbxNovo.Visible = False
        '
        'pbxCadastrar
        '
        Me.pbxCadastrar.AccessibleDescription = " "
        Me.pbxCadastrar.BackColor = System.Drawing.Color.Transparent
        Me.pbxCadastrar.Enabled = False
        Me.pbxCadastrar.Image = CType(resources.GetObject("pbxCadastrar.Image"), System.Drawing.Image)
        Me.pbxCadastrar.Location = New System.Drawing.Point(323, 252)
        Me.pbxCadastrar.Name = "pbxCadastrar"
        Me.pbxCadastrar.Size = New System.Drawing.Size(86, 44)
        Me.pbxCadastrar.TabIndex = 99
        Me.pbxCadastrar.TabStop = False
        Me.pbxCadastrar.Visible = False
        '
        'pbxPesquisar
        '
        Me.pbxPesquisar.AccessibleDescription = " "
        Me.pbxPesquisar.BackColor = System.Drawing.Color.Transparent
        Me.pbxPesquisar.Enabled = False
        Me.pbxPesquisar.Image = CType(resources.GetObject("pbxPesquisar.Image"), System.Drawing.Image)
        Me.pbxPesquisar.Location = New System.Drawing.Point(535, 300)
        Me.pbxPesquisar.Name = "pbxPesquisar"
        Me.pbxPesquisar.Size = New System.Drawing.Size(113, 44)
        Me.pbxPesquisar.TabIndex = 103
        Me.pbxPesquisar.TabStop = False
        Me.pbxPesquisar.Visible = False
        '
        'Fornecedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(647, 488)
        Me.Controls.Add(Me.pbxPesquisar)
        Me.Controls.Add(Me.pbxExclui)
        Me.Controls.Add(Me.pbxAlter)
        Me.Controls.Add(Me.pbxNovo)
        Me.Controls.Add(Me.pbxCadastrar)
        Me.Controls.Add(Me.cboUFforn)
        Me.Controls.Add(Me.cboPesquisaForn)
        Me.Controls.Add(Me.txtIDforn)
        Me.Controls.Add(Me.btnPesquisaForn)
        Me.Controls.Add(Me.btnExcluiForn)
        Me.Controls.Add(Me.btnAlterForn)
        Me.Controls.Add(Me.btnCadastraForn)
        Me.Controls.Add(Me.btnNovoForn)
        Me.Controls.Add(Me.txtPesquisaForn)
        Me.Controls.Add(Me.dtgFornecedor)
        Me.Controls.Add(Me.txtNomeFant)
        Me.Controls.Add(Me.ID_Forn)
        Me.Controls.Add(Me.mskCNPJ)
        Me.Controls.Add(Me.txtNomeForn)
        Me.Controls.Add(Me.txtCidadeForn)
        Me.Controls.Add(Me.txtBairroForn)
        Me.Controls.Add(Me.txtEmailForn)
        Me.Controls.Add(Me.mskCEPforn)
        Me.Controls.Add(Me.txtEnderForn)
        Me.Controls.Add(Me.mskTelForn)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Fornecedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fornecedor"
        Me.TopMost = True
        CType(Me.dtgFornecedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExcluiForn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAlterForn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCadastraForn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNovoForn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPesquisaForn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxExclui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxAlter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxNovo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxCadastrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxPesquisar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNomeFant As System.Windows.Forms.TextBox
    Friend WithEvents ID_Forn As System.Windows.Forms.ComboBox
    Friend WithEvents mskCNPJ As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCidadeForn As System.Windows.Forms.TextBox
    Friend WithEvents txtBairroForn As System.Windows.Forms.TextBox
    Friend WithEvents txtEmailForn As System.Windows.Forms.TextBox
    Friend WithEvents mskCEPforn As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskTelForn As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtEnderForn As System.Windows.Forms.TextBox
    Friend WithEvents txtNomeForn As System.Windows.Forms.TextBox
    Friend WithEvents txtPesquisaForn As System.Windows.Forms.TextBox
    Friend WithEvents dtgFornecedor As System.Windows.Forms.DataGridView
    Friend WithEvents btnExcluiForn As System.Windows.Forms.PictureBox
    Friend WithEvents btnAlterForn As System.Windows.Forms.PictureBox
    Friend WithEvents btnCadastraForn As System.Windows.Forms.PictureBox
    Friend WithEvents btnNovoForn As System.Windows.Forms.PictureBox
    Friend WithEvents btnPesquisaForn As System.Windows.Forms.PictureBox
    Friend WithEvents txtIDforn As System.Windows.Forms.TextBox
    Friend WithEvents cboPesquisaForn As System.Windows.Forms.TextBox
    Friend WithEvents cboUFforn As System.Windows.Forms.TextBox
    Friend WithEvents pbxExclui As System.Windows.Forms.PictureBox
    Friend WithEvents pbxAlter As System.Windows.Forms.PictureBox
    Friend WithEvents pbxNovo As System.Windows.Forms.PictureBox
    Friend WithEvents pbxCadastrar As System.Windows.Forms.PictureBox
    Friend WithEvents pbxPesquisar As System.Windows.Forms.PictureBox
End Class
