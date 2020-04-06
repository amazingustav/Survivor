<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Funcionario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Funcionario))
        Me.mskSalario = New System.Windows.Forms.MaskedTextBox()
        Me.ID_Func = New System.Windows.Forms.ComboBox()
        Me.txtCargoFunc = New System.Windows.Forms.TextBox()
        Me.txtCidadeFunc = New System.Windows.Forms.TextBox()
        Me.txtBairroFunc = New System.Windows.Forms.TextBox()
        Me.txtEmailFunc = New System.Windows.Forms.TextBox()
        Me.mskCelFunc = New System.Windows.Forms.MaskedTextBox()
        Me.txtCompleFunc = New System.Windows.Forms.TextBox()
        Me.mskCEPfunc = New System.Windows.Forms.MaskedTextBox()
        Me.mskCPFfunc = New System.Windows.Forms.MaskedTextBox()
        Me.mskTelFunc = New System.Windows.Forms.MaskedTextBox()
        Me.txtEnderFunc = New System.Windows.Forms.TextBox()
        Me.txtRGFunc = New System.Windows.Forms.TextBox()
        Me.txtNomeFunc = New System.Windows.Forms.TextBox()
        Me.txtPesquisaFunc = New System.Windows.Forms.TextBox()
        Me.dtgFuncionario = New System.Windows.Forms.DataGridView()
        Me.btnPesquisaFunc = New System.Windows.Forms.PictureBox()
        Me.btnExcluiFunc = New System.Windows.Forms.PictureBox()
        Me.btnAlterFunc = New System.Windows.Forms.PictureBox()
        Me.btnCadastraFunc = New System.Windows.Forms.PictureBox()
        Me.btnNovoFunc = New System.Windows.Forms.PictureBox()
        Me.txtIDfunc = New System.Windows.Forms.TextBox()
        Me.pbxExclui = New System.Windows.Forms.PictureBox()
        Me.pbxAlter = New System.Windows.Forms.PictureBox()
        Me.pbxNovo = New System.Windows.Forms.PictureBox()
        Me.pbxCadastrar = New System.Windows.Forms.PictureBox()
        Me.pbxPesquisar = New System.Windows.Forms.PictureBox()
        Me.cboPesquisaFunc = New System.Windows.Forms.ComboBox()
        Me.cboUFfunc = New System.Windows.Forms.ComboBox()
        Me.btnHelp = New System.Windows.Forms.PictureBox()
        Me.btnEND = New System.Windows.Forms.PictureBox()
        Me.rdbMascFunc = New System.Windows.Forms.RadioButton()
        Me.rdbFemFunc = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.dtgFuncionario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPesquisaFunc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExcluiFunc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAlterFunc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCadastraFunc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNovoFunc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxExclui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxAlter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxNovo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxCadastrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxPesquisar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEND, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mskSalario
        '
        Me.mskSalario.BackColor = System.Drawing.Color.White
        Me.mskSalario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mskSalario.ForeColor = System.Drawing.Color.Black
        Me.mskSalario.Location = New System.Drawing.Point(464, 191)
        Me.mskSalario.Mask = "9999,99"
        Me.mskSalario.Name = "mskSalario"
        Me.mskSalario.Size = New System.Drawing.Size(110, 13)
        Me.mskSalario.TabIndex = 16
        Me.mskSalario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ID_Func
        '
        Me.ID_Func.BackColor = System.Drawing.Color.PowderBlue
        Me.ID_Func.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ID_Func.Enabled = False
        Me.ID_Func.FormattingEnabled = True
        Me.ID_Func.Location = New System.Drawing.Point(177, 41)
        Me.ID_Func.Name = "ID_Func"
        Me.ID_Func.Size = New System.Drawing.Size(77, 24)
        Me.ID_Func.TabIndex = 90
        Me.ID_Func.Visible = False
        '
        'txtCargoFunc
        '
        Me.txtCargoFunc.BackColor = System.Drawing.Color.White
        Me.txtCargoFunc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCargoFunc.ForeColor = System.Drawing.Color.Black
        Me.txtCargoFunc.Location = New System.Drawing.Point(464, 166)
        Me.txtCargoFunc.Name = "txtCargoFunc"
        Me.txtCargoFunc.Size = New System.Drawing.Size(106, 13)
        Me.txtCargoFunc.TabIndex = 15
        '
        'txtCidadeFunc
        '
        Me.txtCidadeFunc.BackColor = System.Drawing.Color.White
        Me.txtCidadeFunc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCidadeFunc.ForeColor = System.Drawing.Color.Black
        Me.txtCidadeFunc.Location = New System.Drawing.Point(410, 66)
        Me.txtCidadeFunc.Name = "txtCidadeFunc"
        Me.txtCidadeFunc.Size = New System.Drawing.Size(164, 13)
        Me.txtCidadeFunc.TabIndex = 10
        '
        'txtBairroFunc
        '
        Me.txtBairroFunc.BackColor = System.Drawing.Color.White
        Me.txtBairroFunc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBairroFunc.ForeColor = System.Drawing.Color.Black
        Me.txtBairroFunc.Location = New System.Drawing.Point(405, 85)
        Me.txtBairroFunc.Name = "txtBairroFunc"
        Me.txtBairroFunc.Size = New System.Drawing.Size(167, 13)
        Me.txtBairroFunc.TabIndex = 11
        '
        'txtEmailFunc
        '
        Me.txtEmailFunc.BackColor = System.Drawing.Color.White
        Me.txtEmailFunc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmailFunc.ForeColor = System.Drawing.Color.Black
        Me.txtEmailFunc.Location = New System.Drawing.Point(121, 184)
        Me.txtEmailFunc.Name = "txtEmailFunc"
        Me.txtEmailFunc.Size = New System.Drawing.Size(159, 13)
        Me.txtEmailFunc.TabIndex = 8
        '
        'mskCelFunc
        '
        Me.mskCelFunc.BackColor = System.Drawing.Color.White
        Me.mskCelFunc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mskCelFunc.ForeColor = System.Drawing.Color.Black
        Me.mskCelFunc.Location = New System.Drawing.Point(121, 165)
        Me.mskCelFunc.Mask = "(99) 0000-0000"
        Me.mskCelFunc.Name = "mskCelFunc"
        Me.mskCelFunc.Size = New System.Drawing.Size(159, 13)
        Me.mskCelFunc.TabIndex = 7
        '
        'txtCompleFunc
        '
        Me.txtCompleFunc.BackColor = System.Drawing.Color.White
        Me.txtCompleFunc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCompleFunc.ForeColor = System.Drawing.Color.Black
        Me.txtCompleFunc.Location = New System.Drawing.Point(457, 125)
        Me.txtCompleFunc.Name = "txtCompleFunc"
        Me.txtCompleFunc.Size = New System.Drawing.Size(117, 13)
        Me.txtCompleFunc.TabIndex = 13
        '
        'mskCEPfunc
        '
        Me.mskCEPfunc.BackColor = System.Drawing.Color.White
        Me.mskCEPfunc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mskCEPfunc.ForeColor = System.Drawing.Color.Black
        Me.mskCEPfunc.Location = New System.Drawing.Point(396, 104)
        Me.mskCEPfunc.Mask = "00000-999"
        Me.mskCEPfunc.Name = "mskCEPfunc"
        Me.mskCEPfunc.Size = New System.Drawing.Size(177, 13)
        Me.mskCEPfunc.TabIndex = 12
        '
        'mskCPFfunc
        '
        Me.mskCPFfunc.BackColor = System.Drawing.Color.White
        Me.mskCPFfunc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mskCPFfunc.ForeColor = System.Drawing.Color.Black
        Me.mskCPFfunc.Location = New System.Drawing.Point(121, 127)
        Me.mskCPFfunc.Mask = "000.000.000-99"
        Me.mskCPFfunc.Name = "mskCPFfunc"
        Me.mskCPFfunc.Size = New System.Drawing.Size(159, 13)
        Me.mskCPFfunc.TabIndex = 5
        '
        'mskTelFunc
        '
        Me.mskTelFunc.BackColor = System.Drawing.Color.White
        Me.mskTelFunc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mskTelFunc.ForeColor = System.Drawing.Color.Black
        Me.mskTelFunc.Location = New System.Drawing.Point(121, 146)
        Me.mskTelFunc.Mask = "(99) 0000-0000"
        Me.mskTelFunc.Name = "mskTelFunc"
        Me.mskTelFunc.Size = New System.Drawing.Size(159, 13)
        Me.mskTelFunc.TabIndex = 6
        '
        'txtEnderFunc
        '
        Me.txtEnderFunc.BackColor = System.Drawing.Color.White
        Me.txtEnderFunc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEnderFunc.ForeColor = System.Drawing.Color.Black
        Me.txtEnderFunc.Location = New System.Drawing.Point(424, 48)
        Me.txtEnderFunc.Name = "txtEnderFunc"
        Me.txtEnderFunc.Size = New System.Drawing.Size(149, 13)
        Me.txtEnderFunc.TabIndex = 9
        '
        'txtRGFunc
        '
        Me.txtRGFunc.BackColor = System.Drawing.Color.White
        Me.txtRGFunc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRGFunc.ForeColor = System.Drawing.Color.Black
        Me.txtRGFunc.Location = New System.Drawing.Point(121, 106)
        Me.txtRGFunc.Name = "txtRGFunc"
        Me.txtRGFunc.Size = New System.Drawing.Size(159, 13)
        Me.txtRGFunc.TabIndex = 4
        '
        'txtNomeFunc
        '
        Me.txtNomeFunc.BackColor = System.Drawing.Color.White
        Me.txtNomeFunc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNomeFunc.ForeColor = System.Drawing.Color.Black
        Me.txtNomeFunc.Location = New System.Drawing.Point(121, 71)
        Me.txtNomeFunc.Name = "txtNomeFunc"
        Me.txtNomeFunc.Size = New System.Drawing.Size(159, 13)
        Me.txtNomeFunc.TabIndex = 1
        '
        'txtPesquisaFunc
        '
        Me.txtPesquisaFunc.BackColor = System.Drawing.Color.White
        Me.txtPesquisaFunc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPesquisaFunc.ForeColor = System.Drawing.Color.Black
        Me.txtPesquisaFunc.Location = New System.Drawing.Point(321, 322)
        Me.txtPesquisaFunc.Name = "txtPesquisaFunc"
        Me.txtPesquisaFunc.Size = New System.Drawing.Size(200, 13)
        Me.txtPesquisaFunc.TabIndex = 18
        '
        'dtgFuncionario
        '
        Me.dtgFuncionario.AllowUserToAddRows = False
        Me.dtgFuncionario.AllowUserToDeleteRows = False
        Me.dtgFuncionario.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dtgFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgFuncionario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dtgFuncionario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgFuncionario.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgFuncionario.Cursor = System.Windows.Forms.Cursors.Default
        Me.dtgFuncionario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtgFuncionario.Location = New System.Drawing.Point(48, 350)
        Me.dtgFuncionario.Name = "dtgFuncionario"
        Me.dtgFuncionario.ReadOnly = True
        Me.dtgFuncionario.Size = New System.Drawing.Size(572, 119)
        Me.dtgFuncionario.TabIndex = 92
        '
        'btnPesquisaFunc
        '
        Me.btnPesquisaFunc.BackColor = System.Drawing.Color.Transparent
        Me.btnPesquisaFunc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPesquisaFunc.Location = New System.Drawing.Point(530, 307)
        Me.btnPesquisaFunc.Name = "btnPesquisaFunc"
        Me.btnPesquisaFunc.Size = New System.Drawing.Size(45, 37)
        Me.btnPesquisaFunc.TabIndex = 96
        Me.btnPesquisaFunc.TabStop = False
        '
        'btnExcluiFunc
        '
        Me.btnExcluiFunc.BackColor = System.Drawing.Color.Transparent
        Me.btnExcluiFunc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluiFunc.Location = New System.Drawing.Point(483, 223)
        Me.btnExcluiFunc.Name = "btnExcluiFunc"
        Me.btnExcluiFunc.Size = New System.Drawing.Size(51, 54)
        Me.btnExcluiFunc.TabIndex = 100
        Me.btnExcluiFunc.TabStop = False
        '
        'btnAlterFunc
        '
        Me.btnAlterFunc.BackColor = System.Drawing.Color.Transparent
        Me.btnAlterFunc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAlterFunc.Location = New System.Drawing.Point(424, 224)
        Me.btnAlterFunc.Name = "btnAlterFunc"
        Me.btnAlterFunc.Size = New System.Drawing.Size(51, 54)
        Me.btnAlterFunc.TabIndex = 99
        Me.btnAlterFunc.TabStop = False
        '
        'btnCadastraFunc
        '
        Me.btnCadastraFunc.BackColor = System.Drawing.Color.Transparent
        Me.btnCadastraFunc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCadastraFunc.Location = New System.Drawing.Point(364, 225)
        Me.btnCadastraFunc.Name = "btnCadastraFunc"
        Me.btnCadastraFunc.Size = New System.Drawing.Size(51, 54)
        Me.btnCadastraFunc.TabIndex = 98
        Me.btnCadastraFunc.TabStop = False
        '
        'btnNovoFunc
        '
        Me.btnNovoFunc.BackColor = System.Drawing.Color.Transparent
        Me.btnNovoFunc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNovoFunc.Location = New System.Drawing.Point(303, 225)
        Me.btnNovoFunc.Name = "btnNovoFunc"
        Me.btnNovoFunc.Size = New System.Drawing.Size(51, 54)
        Me.btnNovoFunc.TabIndex = 97
        Me.btnNovoFunc.TabStop = False
        '
        'txtIDfunc
        '
        Me.txtIDfunc.BackColor = System.Drawing.Color.White
        Me.txtIDfunc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIDfunc.Enabled = False
        Me.txtIDfunc.Location = New System.Drawing.Point(110, 47)
        Me.txtIDfunc.Name = "txtIDfunc"
        Me.txtIDfunc.Size = New System.Drawing.Size(51, 13)
        Me.txtIDfunc.TabIndex = 102
        '
        'pbxExclui
        '
        Me.pbxExclui.AccessibleDescription = " "
        Me.pbxExclui.BackColor = System.Drawing.Color.Transparent
        Me.pbxExclui.Enabled = False
        Me.pbxExclui.Image = CType(resources.GetObject("pbxExclui.Image"), System.Drawing.Image)
        Me.pbxExclui.Location = New System.Drawing.Point(512, 235)
        Me.pbxExclui.Name = "pbxExclui"
        Me.pbxExclui.Size = New System.Drawing.Size(82, 44)
        Me.pbxExclui.TabIndex = 107
        Me.pbxExclui.TabStop = False
        Me.pbxExclui.Visible = False
        '
        'pbxAlter
        '
        Me.pbxAlter.AccessibleDescription = " "
        Me.pbxAlter.BackColor = System.Drawing.Color.Transparent
        Me.pbxAlter.BackgroundImage = CType(resources.GetObject("pbxAlter.BackgroundImage"), System.Drawing.Image)
        Me.pbxAlter.Enabled = False
        Me.pbxAlter.Location = New System.Drawing.Point(460, 238)
        Me.pbxAlter.Name = "pbxAlter"
        Me.pbxAlter.Size = New System.Drawing.Size(89, 41)
        Me.pbxAlter.TabIndex = 106
        Me.pbxAlter.TabStop = False
        Me.pbxAlter.Visible = False
        '
        'pbxNovo
        '
        Me.pbxNovo.AccessibleDescription = " "
        Me.pbxNovo.BackColor = System.Drawing.Color.Transparent
        Me.pbxNovo.Enabled = False
        Me.pbxNovo.Image = CType(resources.GetObject("pbxNovo.Image"), System.Drawing.Image)
        Me.pbxNovo.Location = New System.Drawing.Point(335, 241)
        Me.pbxNovo.Name = "pbxNovo"
        Me.pbxNovo.Size = New System.Drawing.Size(69, 42)
        Me.pbxNovo.TabIndex = 105
        Me.pbxNovo.TabStop = False
        Me.pbxNovo.Visible = False
        '
        'pbxCadastrar
        '
        Me.pbxCadastrar.AccessibleDescription = " "
        Me.pbxCadastrar.BackColor = System.Drawing.Color.Transparent
        Me.pbxCadastrar.BackgroundImage = CType(resources.GetObject("pbxCadastrar.BackgroundImage"), System.Drawing.Image)
        Me.pbxCadastrar.Enabled = False
        Me.pbxCadastrar.Location = New System.Drawing.Point(393, 241)
        Me.pbxCadastrar.Name = "pbxCadastrar"
        Me.pbxCadastrar.Size = New System.Drawing.Size(95, 38)
        Me.pbxCadastrar.TabIndex = 104
        Me.pbxCadastrar.TabStop = False
        Me.pbxCadastrar.Visible = False
        '
        'pbxPesquisar
        '
        Me.pbxPesquisar.AccessibleDescription = " "
        Me.pbxPesquisar.BackColor = System.Drawing.Color.Transparent
        Me.pbxPesquisar.Enabled = False
        Me.pbxPesquisar.Image = CType(resources.GetObject("pbxPesquisar.Image"), System.Drawing.Image)
        Me.pbxPesquisar.Location = New System.Drawing.Point(512, 274)
        Me.pbxPesquisar.Name = "pbxPesquisar"
        Me.pbxPesquisar.Size = New System.Drawing.Size(113, 44)
        Me.pbxPesquisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxPesquisar.TabIndex = 108
        Me.pbxPesquisar.TabStop = False
        Me.pbxPesquisar.Visible = False
        '
        'cboPesquisaFunc
        '
        Me.cboPesquisaFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPesquisaFunc.FormattingEnabled = True
        Me.cboPesquisaFunc.Items.AddRange(New Object() {"ID", "Nome", "CPF", "CEP", "Telefone"})
        Me.cboPesquisaFunc.Location = New System.Drawing.Point(121, 316)
        Me.cboPesquisaFunc.Name = "cboPesquisaFunc"
        Me.cboPesquisaFunc.Size = New System.Drawing.Size(170, 21)
        Me.cboPesquisaFunc.TabIndex = 17
        '
        'cboUFfunc
        '
        Me.cboUFfunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUFfunc.FormattingEnabled = True
        Me.cboUFfunc.Items.AddRange(New Object() {"AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.cboUFfunc.Location = New System.Drawing.Point(382, 139)
        Me.cboUFfunc.Name = "cboUFfunc"
        Me.cboUFfunc.Size = New System.Drawing.Size(67, 21)
        Me.cboUFfunc.TabIndex = 14
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.Transparent
        Me.btnHelp.Cursor = System.Windows.Forms.Cursors.Help
        Me.btnHelp.Location = New System.Drawing.Point(572, 10)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(24, 20)
        Me.btnHelp.TabIndex = 112
        Me.btnHelp.TabStop = False
        '
        'btnEND
        '
        Me.btnEND.BackColor = System.Drawing.Color.Transparent
        Me.btnEND.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEND.Location = New System.Drawing.Point(599, 10)
        Me.btnEND.Name = "btnEND"
        Me.btnEND.Size = New System.Drawing.Size(24, 20)
        Me.btnEND.TabIndex = 111
        Me.btnEND.TabStop = False
        '
        'rdbMascFunc
        '
        Me.rdbMascFunc.AutoSize = True
        Me.rdbMascFunc.BackColor = System.Drawing.Color.Transparent
        Me.rdbMascFunc.Font = New System.Drawing.Font("Maiandra GD", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMascFunc.Location = New System.Drawing.Point(150, 87)
        Me.rdbMascFunc.Name = "rdbMascFunc"
        Me.rdbMascFunc.Size = New System.Drawing.Size(35, 18)
        Me.rdbMascFunc.TabIndex = 3
        Me.rdbMascFunc.TabStop = True
        Me.rdbMascFunc.Text = "M"
        Me.rdbMascFunc.UseVisualStyleBackColor = False
        '
        'rdbFemFunc
        '
        Me.rdbFemFunc.AutoSize = True
        Me.rdbFemFunc.BackColor = System.Drawing.Color.Transparent
        Me.rdbFemFunc.Font = New System.Drawing.Font("Maiandra GD", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbFemFunc.Location = New System.Drawing.Point(114, 87)
        Me.rdbFemFunc.Name = "rdbFemFunc"
        Me.rdbFemFunc.Size = New System.Drawing.Size(31, 18)
        Me.rdbFemFunc.TabIndex = 2
        Me.rdbFemFunc.TabStop = True
        Me.rdbFemFunc.Text = "F"
        Me.rdbFemFunc.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(297, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 23)
        Me.Label4.TabIndex = 118
        Me.Label4.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(191, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 23)
        Me.Label3.TabIndex = 117
        Me.Label3.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(297, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 23)
        Me.Label2.TabIndex = 116
        Me.Label2.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(298, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 23)
        Me.Label7.TabIndex = 120
        Me.Label7.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(297, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(20, 23)
        Me.Label8.TabIndex = 119
        Me.Label8.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(588, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 23)
        Me.Label1.TabIndex = 124
        Me.Label1.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(587, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 23)
        Me.Label5.TabIndex = 123
        Me.Label5.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(586, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 23)
        Me.Label6.TabIndex = 122
        Me.Label6.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(586, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(20, 23)
        Me.Label9.TabIndex = 121
        Me.Label9.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(580, 188)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(20, 23)
        Me.Label11.TabIndex = 127
        Me.Label11.Text = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(580, 163)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(20, 23)
        Me.Label12.TabIndex = 126
        Me.Label12.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(455, 141)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(20, 23)
        Me.Label13.TabIndex = 125
        Me.Label13.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(38, 256)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(216, 23)
        Me.Label10.TabIndex = 128
        Me.Label10.Text = "(*) Campos obrigatórios!"
        '
        'Funcionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(666, 503)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rdbFemFunc)
        Me.Controls.Add(Me.rdbMascFunc)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnEND)
        Me.Controls.Add(Me.cboUFfunc)
        Me.Controls.Add(Me.cboPesquisaFunc)
        Me.Controls.Add(Me.pbxPesquisar)
        Me.Controls.Add(Me.pbxExclui)
        Me.Controls.Add(Me.pbxAlter)
        Me.Controls.Add(Me.pbxNovo)
        Me.Controls.Add(Me.pbxCadastrar)
        Me.Controls.Add(Me.txtIDfunc)
        Me.Controls.Add(Me.btnExcluiFunc)
        Me.Controls.Add(Me.btnAlterFunc)
        Me.Controls.Add(Me.btnCadastraFunc)
        Me.Controls.Add(Me.btnNovoFunc)
        Me.Controls.Add(Me.btnPesquisaFunc)
        Me.Controls.Add(Me.txtPesquisaFunc)
        Me.Controls.Add(Me.dtgFuncionario)
        Me.Controls.Add(Me.mskSalario)
        Me.Controls.Add(Me.ID_Func)
        Me.Controls.Add(Me.txtCargoFunc)
        Me.Controls.Add(Me.txtNomeFunc)
        Me.Controls.Add(Me.txtCidadeFunc)
        Me.Controls.Add(Me.txtBairroFunc)
        Me.Controls.Add(Me.txtEmailFunc)
        Me.Controls.Add(Me.mskCelFunc)
        Me.Controls.Add(Me.txtCompleFunc)
        Me.Controls.Add(Me.txtRGFunc)
        Me.Controls.Add(Me.mskCEPfunc)
        Me.Controls.Add(Me.txtEnderFunc)
        Me.Controls.Add(Me.mskCPFfunc)
        Me.Controls.Add(Me.mskTelFunc)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Funcionario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Funcionario"
        Me.TopMost = True
        CType(Me.dtgFuncionario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPesquisaFunc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExcluiFunc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAlterFunc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCadastraFunc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNovoFunc, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents mskSalario As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ID_Func As System.Windows.Forms.ComboBox
    Friend WithEvents txtCargoFunc As System.Windows.Forms.TextBox
    Friend WithEvents txtCidadeFunc As System.Windows.Forms.TextBox
    Friend WithEvents txtBairroFunc As System.Windows.Forms.TextBox
    Friend WithEvents txtEmailFunc As System.Windows.Forms.TextBox
    Friend WithEvents mskCelFunc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCompleFunc As System.Windows.Forms.TextBox
    Friend WithEvents mskCEPfunc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskCPFfunc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskTelFunc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtEnderFunc As System.Windows.Forms.TextBox
    Friend WithEvents txtRGFunc As System.Windows.Forms.TextBox
    Friend WithEvents txtNomeFunc As System.Windows.Forms.TextBox
    Friend WithEvents txtPesquisaFunc As System.Windows.Forms.TextBox
    Friend WithEvents dtgFuncionario As System.Windows.Forms.DataGridView
    Friend WithEvents btnPesquisaFunc As System.Windows.Forms.PictureBox
    Friend WithEvents btnExcluiFunc As System.Windows.Forms.PictureBox
    Friend WithEvents btnAlterFunc As System.Windows.Forms.PictureBox
    Friend WithEvents btnCadastraFunc As System.Windows.Forms.PictureBox
    Friend WithEvents btnNovoFunc As System.Windows.Forms.PictureBox
    Friend WithEvents txtIDfunc As System.Windows.Forms.TextBox
    Friend WithEvents pbxExclui As System.Windows.Forms.PictureBox
    Friend WithEvents pbxAlter As System.Windows.Forms.PictureBox
    Friend WithEvents pbxNovo As System.Windows.Forms.PictureBox
    Friend WithEvents pbxCadastrar As System.Windows.Forms.PictureBox
    Friend WithEvents pbxPesquisar As System.Windows.Forms.PictureBox
    Friend WithEvents cboPesquisaFunc As System.Windows.Forms.ComboBox
    Friend WithEvents cboUFfunc As System.Windows.Forms.ComboBox
    Friend WithEvents btnHelp As System.Windows.Forms.PictureBox
    Friend WithEvents btnEND As System.Windows.Forms.PictureBox
    Friend WithEvents rdbMascFunc As System.Windows.Forms.RadioButton
    Friend WithEvents rdbFemFunc As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
