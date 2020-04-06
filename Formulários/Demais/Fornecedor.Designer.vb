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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fornecedor))
        Me.txtNomeFant = New System.Windows.Forms.TextBox()
        Me.ID_Forn = New System.Windows.Forms.ComboBox()
        Me.mskCNPJ = New System.Windows.Forms.MaskedTextBox()
        Me.txtCidadeForn = New System.Windows.Forms.TextBox()
        Me.txtBairroForn = New System.Windows.Forms.TextBox()
        Me.txtEmailForn = New System.Windows.Forms.TextBox()
        Me.mskCEPforn = New System.Windows.Forms.MaskedTextBox()
        Me.mskTelForn = New System.Windows.Forms.MaskedTextBox()
        Me.txtEnderForn = New System.Windows.Forms.TextBox()
        Me.txtNomeForn = New System.Windows.Forms.TextBox()
        Me.txtPesquisaForn = New System.Windows.Forms.TextBox()
        Me.dtgFornecedor = New System.Windows.Forms.DataGridView()
        Me.btnExcluiForn = New System.Windows.Forms.PictureBox()
        Me.btnAlterForn = New System.Windows.Forms.PictureBox()
        Me.btnCadastraForn = New System.Windows.Forms.PictureBox()
        Me.btnNovoForn = New System.Windows.Forms.PictureBox()
        Me.btnPesquisaForn = New System.Windows.Forms.PictureBox()
        Me.txtIDforn = New System.Windows.Forms.TextBox()
        Me.pbxExclui = New System.Windows.Forms.PictureBox()
        Me.pbxAlter = New System.Windows.Forms.PictureBox()
        Me.pbxNovo = New System.Windows.Forms.PictureBox()
        Me.pbxCadastrar = New System.Windows.Forms.PictureBox()
        Me.pbxPesquisar = New System.Windows.Forms.PictureBox()
        Me.cboPesquisaForn = New System.Windows.Forms.ComboBox()
        Me.cboUFforn = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnHelp = New System.Windows.Forms.PictureBox()
        Me.btnEND = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCompleForn = New System.Windows.Forms.TextBox()
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
        CType(Me.btnHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEND, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNomeFant
        '
        Me.txtNomeFant.BackColor = System.Drawing.Color.White
        Me.txtNomeFant.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNomeFant.ForeColor = System.Drawing.Color.Black
        Me.txtNomeFant.Location = New System.Drawing.Point(92, 72)
        Me.txtNomeFant.Name = "txtNomeFant"
        Me.txtNomeFant.Size = New System.Drawing.Size(197, 13)
        Me.txtNomeFant.TabIndex = 1
        '
        'ID_Forn
        '
        Me.ID_Forn.BackColor = System.Drawing.Color.PowderBlue
        Me.ID_Forn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ID_Forn.Enabled = False
        Me.ID_Forn.FormattingEnabled = True
        Me.ID_Forn.Location = New System.Drawing.Point(201, 41)
        Me.ID_Forn.Name = "ID_Forn"
        Me.ID_Forn.Size = New System.Drawing.Size(77, 24)
        Me.ID_Forn.TabIndex = 85
        Me.ID_Forn.Visible = False
        '
        'mskCNPJ
        '
        Me.mskCNPJ.BackColor = System.Drawing.Color.White
        Me.mskCNPJ.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mskCNPJ.ForeColor = System.Drawing.Color.Black
        Me.mskCNPJ.Location = New System.Drawing.Point(96, 114)
        Me.mskCNPJ.Mask = "00.000.000/0000-99"
        Me.mskCNPJ.Name = "mskCNPJ"
        Me.mskCNPJ.Size = New System.Drawing.Size(182, 13)
        Me.mskCNPJ.TabIndex = 3
        '
        'txtCidadeForn
        '
        Me.txtCidadeForn.BackColor = System.Drawing.Color.White
        Me.txtCidadeForn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCidadeForn.ForeColor = System.Drawing.Color.Black
        Me.txtCidadeForn.Location = New System.Drawing.Point(415, 89)
        Me.txtCidadeForn.Name = "txtCidadeForn"
        Me.txtCidadeForn.Size = New System.Drawing.Size(202, 13)
        Me.txtCidadeForn.TabIndex = 7
        '
        'txtBairroForn
        '
        Me.txtBairroForn.BackColor = System.Drawing.Color.White
        Me.txtBairroForn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBairroForn.ForeColor = System.Drawing.Color.Black
        Me.txtBairroForn.Location = New System.Drawing.Point(411, 109)
        Me.txtBairroForn.Name = "txtBairroForn"
        Me.txtBairroForn.Size = New System.Drawing.Size(206, 13)
        Me.txtBairroForn.TabIndex = 8
        '
        'txtEmailForn
        '
        Me.txtEmailForn.BackColor = System.Drawing.Color.White
        Me.txtEmailForn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmailForn.ForeColor = System.Drawing.Color.Black
        Me.txtEmailForn.Location = New System.Drawing.Point(92, 158)
        Me.txtEmailForn.Name = "txtEmailForn"
        Me.txtEmailForn.Size = New System.Drawing.Size(186, 13)
        Me.txtEmailForn.TabIndex = 5
        '
        'mskCEPforn
        '
        Me.mskCEPforn.BackColor = System.Drawing.Color.White
        Me.mskCEPforn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mskCEPforn.ForeColor = System.Drawing.Color.Black
        Me.mskCEPforn.Location = New System.Drawing.Point(397, 129)
        Me.mskCEPforn.Mask = "00000-999"
        Me.mskCEPforn.Name = "mskCEPforn"
        Me.mskCEPforn.Size = New System.Drawing.Size(220, 13)
        Me.mskCEPforn.TabIndex = 9
        '
        'mskTelForn
        '
        Me.mskTelForn.BackColor = System.Drawing.Color.White
        Me.mskTelForn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mskTelForn.ForeColor = System.Drawing.Color.Black
        Me.mskTelForn.Location = New System.Drawing.Point(108, 136)
        Me.mskTelForn.Mask = "(99) 0000-0000"
        Me.mskTelForn.Name = "mskTelForn"
        Me.mskTelForn.Size = New System.Drawing.Size(170, 13)
        Me.mskTelForn.TabIndex = 4
        '
        'txtEnderForn
        '
        Me.txtEnderForn.BackColor = System.Drawing.Color.White
        Me.txtEnderForn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEnderForn.ForeColor = System.Drawing.Color.Black
        Me.txtEnderForn.Location = New System.Drawing.Point(433, 70)
        Me.txtEnderForn.Name = "txtEnderForn"
        Me.txtEnderForn.Size = New System.Drawing.Size(184, 13)
        Me.txtEnderForn.TabIndex = 6
        '
        'txtNomeForn
        '
        Me.txtNomeForn.BackColor = System.Drawing.Color.White
        Me.txtNomeForn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNomeForn.ForeColor = System.Drawing.Color.Black
        Me.txtNomeForn.Location = New System.Drawing.Point(155, 94)
        Me.txtNomeForn.Name = "txtNomeForn"
        Me.txtNomeForn.Size = New System.Drawing.Size(134, 13)
        Me.txtNomeForn.TabIndex = 2
        '
        'txtPesquisaForn
        '
        Me.txtPesquisaForn.BackColor = System.Drawing.Color.White
        Me.txtPesquisaForn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPesquisaForn.ForeColor = System.Drawing.Color.Black
        Me.txtPesquisaForn.Location = New System.Drawing.Point(321, 326)
        Me.txtPesquisaForn.Name = "txtPesquisaForn"
        Me.txtPesquisaForn.Size = New System.Drawing.Size(214, 13)
        Me.txtPesquisaForn.TabIndex = 13
        '
        'dtgFornecedor
        '
        Me.dtgFornecedor.AllowUserToAddRows = False
        Me.dtgFornecedor.AllowUserToDeleteRows = False
        Me.dtgFornecedor.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dtgFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgFornecedor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dtgFornecedor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgFornecedor.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgFornecedor.Cursor = System.Windows.Forms.Cursors.Default
        Me.dtgFornecedor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtgFornecedor.Location = New System.Drawing.Point(37, 354)
        Me.dtgFornecedor.Name = "dtgFornecedor"
        Me.dtgFornecedor.ReadOnly = True
        Me.dtgFornecedor.Size = New System.Drawing.Size(595, 121)
        Me.dtgFornecedor.TabIndex = 87
        '
        'btnExcluiForn
        '
        Me.btnExcluiForn.BackColor = System.Drawing.Color.Transparent
        Me.btnExcluiForn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluiForn.Location = New System.Drawing.Point(475, 234)
        Me.btnExcluiForn.Name = "btnExcluiForn"
        Me.btnExcluiForn.Size = New System.Drawing.Size(47, 54)
        Me.btnExcluiForn.TabIndex = 94
        Me.btnExcluiForn.TabStop = False
        '
        'btnAlterForn
        '
        Me.btnAlterForn.BackColor = System.Drawing.Color.Transparent
        Me.btnAlterForn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAlterForn.Location = New System.Drawing.Point(415, 235)
        Me.btnAlterForn.Name = "btnAlterForn"
        Me.btnAlterForn.Size = New System.Drawing.Size(51, 54)
        Me.btnAlterForn.TabIndex = 93
        Me.btnAlterForn.TabStop = False
        '
        'btnCadastraForn
        '
        Me.btnCadastraForn.BackColor = System.Drawing.Color.Transparent
        Me.btnCadastraForn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCadastraForn.Location = New System.Drawing.Point(356, 235)
        Me.btnCadastraForn.Name = "btnCadastraForn"
        Me.btnCadastraForn.Size = New System.Drawing.Size(51, 54)
        Me.btnCadastraForn.TabIndex = 92
        Me.btnCadastraForn.TabStop = False
        '
        'btnNovoForn
        '
        Me.btnNovoForn.BackColor = System.Drawing.Color.Transparent
        Me.btnNovoForn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNovoForn.Location = New System.Drawing.Point(294, 235)
        Me.btnNovoForn.Name = "btnNovoForn"
        Me.btnNovoForn.Size = New System.Drawing.Size(51, 54)
        Me.btnNovoForn.TabIndex = 91
        Me.btnNovoForn.TabStop = False
        '
        'btnPesquisaForn
        '
        Me.btnPesquisaForn.BackColor = System.Drawing.Color.Transparent
        Me.btnPesquisaForn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPesquisaForn.Location = New System.Drawing.Point(537, 311)
        Me.btnPesquisaForn.Name = "btnPesquisaForn"
        Me.btnPesquisaForn.Size = New System.Drawing.Size(51, 37)
        Me.btnPesquisaForn.TabIndex = 95
        Me.btnPesquisaForn.TabStop = False
        '
        'txtIDforn
        '
        Me.txtIDforn.BackColor = System.Drawing.Color.White
        Me.txtIDforn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIDforn.Enabled = False
        Me.txtIDforn.Location = New System.Drawing.Point(92, 43)
        Me.txtIDforn.Name = "txtIDforn"
        Me.txtIDforn.Size = New System.Drawing.Size(88, 13)
        Me.txtIDforn.TabIndex = 96
        '
        'pbxExclui
        '
        Me.pbxExclui.AccessibleDescription = " "
        Me.pbxExclui.BackColor = System.Drawing.Color.Transparent
        Me.pbxExclui.Enabled = False
        Me.pbxExclui.Image = CType(resources.GetObject("pbxExclui.Image"), System.Drawing.Image)
        Me.pbxExclui.Location = New System.Drawing.Point(469, 273)
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
        Me.pbxAlter.Location = New System.Drawing.Point(404, 271)
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
        Me.pbxNovo.Location = New System.Drawing.Point(285, 271)
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
        Me.pbxCadastrar.Location = New System.Drawing.Point(339, 270)
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
        Me.pbxPesquisar.Location = New System.Drawing.Point(503, 276)
        Me.pbxPesquisar.Name = "pbxPesquisar"
        Me.pbxPesquisar.Size = New System.Drawing.Size(123, 43)
        Me.pbxPesquisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxPesquisar.TabIndex = 103
        Me.pbxPesquisar.TabStop = False
        Me.pbxPesquisar.Visible = False
        '
        'cboPesquisaForn
        '
        Me.cboPesquisaForn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPesquisaForn.FormattingEnabled = True
        Me.cboPesquisaForn.Items.AddRange(New Object() {"ID", "Nome", "CNPJ", "CEP", "Telefone"})
        Me.cboPesquisaForn.Location = New System.Drawing.Point(112, 320)
        Me.cboPesquisaForn.Name = "cboPesquisaForn"
        Me.cboPesquisaForn.Size = New System.Drawing.Size(176, 21)
        Me.cboPesquisaForn.TabIndex = 12
        '
        'cboUFforn
        '
        Me.cboUFforn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUFforn.FormattingEnabled = True
        Me.cboUFforn.Items.AddRange(New Object() {"AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.cboUFforn.Location = New System.Drawing.Point(384, 165)
        Me.cboUFforn.Name = "cboUFforn"
        Me.cboUFforn.Size = New System.Drawing.Size(77, 21)
        Me.cboUFforn.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(296, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 23)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(296, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 23)
        Me.Label2.TabIndex = 107
        Me.Label2.Text = "*"
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.Transparent
        Me.btnHelp.Cursor = System.Windows.Forms.Cursors.Help
        Me.btnHelp.Location = New System.Drawing.Point(590, 11)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(24, 20)
        Me.btnHelp.TabIndex = 109
        Me.btnHelp.TabStop = False
        '
        'btnEND
        '
        Me.btnEND.BackColor = System.Drawing.Color.Transparent
        Me.btnEND.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEND.Location = New System.Drawing.Point(615, 12)
        Me.btnEND.Name = "btnEND"
        Me.btnEND.Size = New System.Drawing.Size(24, 20)
        Me.btnEND.TabIndex = 108
        Me.btnEND.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(296, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 23)
        Me.Label3.TabIndex = 110
        Me.Label3.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(296, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 23)
        Me.Label4.TabIndex = 111
        Me.Label4.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(623, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 23)
        Me.Label5.TabIndex = 112
        Me.Label5.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(623, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 23)
        Me.Label6.TabIndex = 113
        Me.Label6.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(623, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 23)
        Me.Label7.TabIndex = 114
        Me.Label7.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(623, 130)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(20, 23)
        Me.Label8.TabIndex = 115
        Me.Label8.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(467, 170)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(20, 23)
        Me.Label9.TabIndex = 116
        Me.Label9.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(21, 265)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(216, 23)
        Me.Label10.TabIndex = 117
        Me.Label10.Text = "(*) Campos obrigatórios!"
        '
        'txtCompleForn
        '
        Me.txtCompleForn.BackColor = System.Drawing.Color.White
        Me.txtCompleForn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCompleForn.ForeColor = System.Drawing.Color.Black
        Me.txtCompleForn.Location = New System.Drawing.Point(470, 150)
        Me.txtCompleForn.Name = "txtCompleForn"
        Me.txtCompleForn.Size = New System.Drawing.Size(147, 13)
        Me.txtCompleForn.TabIndex = 10
        '
        'Fornecedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(666, 503)
        Me.Controls.Add(Me.txtCompleForn)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnEND)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboUFforn)
        Me.Controls.Add(Me.cboPesquisaForn)
        Me.Controls.Add(Me.pbxPesquisar)
        Me.Controls.Add(Me.pbxExclui)
        Me.Controls.Add(Me.pbxAlter)
        Me.Controls.Add(Me.pbxNovo)
        Me.Controls.Add(Me.pbxCadastrar)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
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
        CType(Me.btnHelp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEND, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents pbxExclui As System.Windows.Forms.PictureBox
    Friend WithEvents pbxAlter As System.Windows.Forms.PictureBox
    Friend WithEvents pbxNovo As System.Windows.Forms.PictureBox
    Friend WithEvents pbxCadastrar As System.Windows.Forms.PictureBox
    Friend WithEvents pbxPesquisar As System.Windows.Forms.PictureBox
    Friend WithEvents cboPesquisaForn As System.Windows.Forms.ComboBox
    Friend WithEvents cboUFforn As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnHelp As System.Windows.Forms.PictureBox
    Friend WithEvents btnEND As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCompleForn As System.Windows.Forms.TextBox
End Class
