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
        Me.cboPesquisaFunc = New System.Windows.Forms.TextBox()
        Me.txtIDfunc = New System.Windows.Forms.TextBox()
        Me.cboUFfunc = New System.Windows.Forms.TextBox()
        Me.pbxExclui = New System.Windows.Forms.PictureBox()
        Me.pbxAlter = New System.Windows.Forms.PictureBox()
        Me.pbxNovo = New System.Windows.Forms.PictureBox()
        Me.pbxCadastrar = New System.Windows.Forms.PictureBox()
        Me.pbxPesquisar = New System.Windows.Forms.PictureBox()
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
        Me.SuspendLayout()
        '
        'mskSalario
        '
        Me.mskSalario.BackColor = System.Drawing.Color.Silver
        Me.mskSalario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mskSalario.ForeColor = System.Drawing.Color.Black
        Me.mskSalario.Location = New System.Drawing.Point(473, 208)
        Me.mskSalario.Mask = "9999,99"
        Me.mskSalario.Name = "mskSalario"
        Me.mskSalario.Size = New System.Drawing.Size(55, 13)
        Me.mskSalario.TabIndex = 14
        Me.mskSalario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ID_Func
        '
        Me.ID_Func.BackColor = System.Drawing.Color.PowderBlue
        Me.ID_Func.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ID_Func.Enabled = False
        Me.ID_Func.FormattingEnabled = True
        Me.ID_Func.Location = New System.Drawing.Point(332, 238)
        Me.ID_Func.Name = "ID_Func"
        Me.ID_Func.Size = New System.Drawing.Size(77, 24)
        Me.ID_Func.TabIndex = 90
        Me.ID_Func.Visible = False
        '
        'txtCargoFunc
        '
        Me.txtCargoFunc.BackColor = System.Drawing.Color.Silver
        Me.txtCargoFunc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCargoFunc.ForeColor = System.Drawing.Color.Black
        Me.txtCargoFunc.Location = New System.Drawing.Point(450, 182)
        Me.txtCargoFunc.Name = "txtCargoFunc"
        Me.txtCargoFunc.Size = New System.Drawing.Size(123, 13)
        Me.txtCargoFunc.TabIndex = 13
        '
        'txtCidadeFunc
        '
        Me.txtCidadeFunc.BackColor = System.Drawing.Color.Silver
        Me.txtCidadeFunc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCidadeFunc.ForeColor = System.Drawing.Color.Black
        Me.txtCidadeFunc.Location = New System.Drawing.Point(450, 25)
        Me.txtCidadeFunc.Name = "txtCidadeFunc"
        Me.txtCidadeFunc.Size = New System.Drawing.Size(124, 13)
        Me.txtCidadeFunc.TabIndex = 7
        '
        'txtBairroFunc
        '
        Me.txtBairroFunc.BackColor = System.Drawing.Color.Silver
        Me.txtBairroFunc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBairroFunc.ForeColor = System.Drawing.Color.Black
        Me.txtBairroFunc.Location = New System.Drawing.Point(149, 182)
        Me.txtBairroFunc.Name = "txtBairroFunc"
        Me.txtBairroFunc.Size = New System.Drawing.Size(127, 13)
        Me.txtBairroFunc.TabIndex = 6
        '
        'txtEmailFunc
        '
        Me.txtEmailFunc.BackColor = System.Drawing.Color.Silver
        Me.txtEmailFunc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmailFunc.ForeColor = System.Drawing.Color.Black
        Me.txtEmailFunc.Location = New System.Drawing.Point(450, 156)
        Me.txtEmailFunc.Name = "txtEmailFunc"
        Me.txtEmailFunc.Size = New System.Drawing.Size(123, 13)
        Me.txtEmailFunc.TabIndex = 12
        '
        'mskCelFunc
        '
        Me.mskCelFunc.BackColor = System.Drawing.Color.Silver
        Me.mskCelFunc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mskCelFunc.ForeColor = System.Drawing.Color.Black
        Me.mskCelFunc.Location = New System.Drawing.Point(450, 128)
        Me.mskCelFunc.Mask = "(99) 0000-0000"
        Me.mskCelFunc.Name = "mskCelFunc"
        Me.mskCelFunc.Size = New System.Drawing.Size(86, 13)
        Me.mskCelFunc.TabIndex = 11
        '
        'txtCompleFunc
        '
        Me.txtCompleFunc.BackColor = System.Drawing.Color.Silver
        Me.txtCompleFunc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCompleFunc.ForeColor = System.Drawing.Color.Black
        Me.txtCompleFunc.Location = New System.Drawing.Point(149, 155)
        Me.txtCompleFunc.Name = "txtCompleFunc"
        Me.txtCompleFunc.Size = New System.Drawing.Size(127, 13)
        Me.txtCompleFunc.TabIndex = 5
        '
        'mskCEPfunc
        '
        Me.mskCEPfunc.BackColor = System.Drawing.Color.Silver
        Me.mskCEPfunc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mskCEPfunc.ForeColor = System.Drawing.Color.Black
        Me.mskCEPfunc.Location = New System.Drawing.Point(450, 52)
        Me.mskCEPfunc.Mask = "00000-999"
        Me.mskCEPfunc.Name = "mskCEPfunc"
        Me.mskCEPfunc.Size = New System.Drawing.Size(65, 13)
        Me.mskCEPfunc.TabIndex = 8
        '
        'mskCPFfunc
        '
        Me.mskCPFfunc.BackColor = System.Drawing.Color.Silver
        Me.mskCPFfunc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mskCPFfunc.ForeColor = System.Drawing.Color.Black
        Me.mskCPFfunc.Location = New System.Drawing.Point(149, 105)
        Me.mskCPFfunc.Mask = "000.000.000-99"
        Me.mskCPFfunc.Name = "mskCPFfunc"
        Me.mskCPFfunc.Size = New System.Drawing.Size(78, 13)
        Me.mskCPFfunc.TabIndex = 3
        '
        'mskTelFunc
        '
        Me.mskTelFunc.BackColor = System.Drawing.Color.Silver
        Me.mskTelFunc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mskTelFunc.ForeColor = System.Drawing.Color.Black
        Me.mskTelFunc.Location = New System.Drawing.Point(450, 103)
        Me.mskTelFunc.Mask = "(99) 0000-0000"
        Me.mskTelFunc.Name = "mskTelFunc"
        Me.mskTelFunc.Size = New System.Drawing.Size(86, 13)
        Me.mskTelFunc.TabIndex = 10
        '
        'txtEnderFunc
        '
        Me.txtEnderFunc.BackColor = System.Drawing.Color.Silver
        Me.txtEnderFunc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEnderFunc.ForeColor = System.Drawing.Color.Black
        Me.txtEnderFunc.Location = New System.Drawing.Point(149, 130)
        Me.txtEnderFunc.Name = "txtEnderFunc"
        Me.txtEnderFunc.Size = New System.Drawing.Size(127, 13)
        Me.txtEnderFunc.TabIndex = 4
        '
        'txtRGFunc
        '
        Me.txtRGFunc.BackColor = System.Drawing.Color.Silver
        Me.txtRGFunc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRGFunc.ForeColor = System.Drawing.Color.Black
        Me.txtRGFunc.Location = New System.Drawing.Point(148, 80)
        Me.txtRGFunc.Name = "txtRGFunc"
        Me.txtRGFunc.Size = New System.Drawing.Size(127, 13)
        Me.txtRGFunc.TabIndex = 2
        '
        'txtNomeFunc
        '
        Me.txtNomeFunc.BackColor = System.Drawing.Color.Silver
        Me.txtNomeFunc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNomeFunc.ForeColor = System.Drawing.Color.Black
        Me.txtNomeFunc.Location = New System.Drawing.Point(148, 54)
        Me.txtNomeFunc.Name = "txtNomeFunc"
        Me.txtNomeFunc.Size = New System.Drawing.Size(127, 13)
        Me.txtNomeFunc.TabIndex = 1
        '
        'txtPesquisaFunc
        '
        Me.txtPesquisaFunc.BackColor = System.Drawing.Color.Silver
        Me.txtPesquisaFunc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPesquisaFunc.ForeColor = System.Drawing.Color.Black
        Me.txtPesquisaFunc.Location = New System.Drawing.Point(284, 314)
        Me.txtPesquisaFunc.Name = "txtPesquisaFunc"
        Me.txtPesquisaFunc.Size = New System.Drawing.Size(217, 13)
        Me.txtPesquisaFunc.TabIndex = 16
        '
        'dtgFuncionario
        '
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
        Me.dtgFuncionario.Cursor = System.Windows.Forms.Cursors.Cross
        Me.dtgFuncionario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtgFuncionario.Location = New System.Drawing.Point(43, 343)
        Me.dtgFuncionario.Name = "dtgFuncionario"
        Me.dtgFuncionario.Size = New System.Drawing.Size(569, 123)
        Me.dtgFuncionario.TabIndex = 92
        '
        'btnPesquisaFunc
        '
        Me.btnPesquisaFunc.BackColor = System.Drawing.Color.Transparent
        Me.btnPesquisaFunc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPesquisaFunc.Location = New System.Drawing.Point(530, 297)
        Me.btnPesquisaFunc.Name = "btnPesquisaFunc"
        Me.btnPesquisaFunc.Size = New System.Drawing.Size(45, 37)
        Me.btnPesquisaFunc.TabIndex = 96
        Me.btnPesquisaFunc.TabStop = False
        '
        'btnExcluiFunc
        '
        Me.btnExcluiFunc.BackColor = System.Drawing.Color.Transparent
        Me.btnExcluiFunc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluiFunc.Location = New System.Drawing.Point(257, 206)
        Me.btnExcluiFunc.Name = "btnExcluiFunc"
        Me.btnExcluiFunc.Size = New System.Drawing.Size(51, 54)
        Me.btnExcluiFunc.TabIndex = 100
        Me.btnExcluiFunc.TabStop = False
        '
        'btnAlterFunc
        '
        Me.btnAlterFunc.BackColor = System.Drawing.Color.Transparent
        Me.btnAlterFunc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAlterFunc.Location = New System.Drawing.Point(202, 207)
        Me.btnAlterFunc.Name = "btnAlterFunc"
        Me.btnAlterFunc.Size = New System.Drawing.Size(51, 54)
        Me.btnAlterFunc.TabIndex = 99
        Me.btnAlterFunc.TabStop = False
        '
        'btnCadastraFunc
        '
        Me.btnCadastraFunc.BackColor = System.Drawing.Color.Transparent
        Me.btnCadastraFunc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCadastraFunc.Location = New System.Drawing.Point(144, 208)
        Me.btnCadastraFunc.Name = "btnCadastraFunc"
        Me.btnCadastraFunc.Size = New System.Drawing.Size(51, 54)
        Me.btnCadastraFunc.TabIndex = 98
        Me.btnCadastraFunc.TabStop = False
        '
        'btnNovoFunc
        '
        Me.btnNovoFunc.BackColor = System.Drawing.Color.Transparent
        Me.btnNovoFunc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNovoFunc.Location = New System.Drawing.Point(85, 208)
        Me.btnNovoFunc.Name = "btnNovoFunc"
        Me.btnNovoFunc.Size = New System.Drawing.Size(51, 54)
        Me.btnNovoFunc.TabIndex = 97
        Me.btnNovoFunc.TabStop = False
        '
        'cboPesquisaFunc
        '
        Me.cboPesquisaFunc.AutoCompleteCustomSource.AddRange(New String() {"Código", "Nome", "Email", "RG", "CPF", "CEP", "Bairro", "Cidade", "Endereço", "Telefone", "Celular"})
        Me.cboPesquisaFunc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboPesquisaFunc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cboPesquisaFunc.BackColor = System.Drawing.Color.Silver
        Me.cboPesquisaFunc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cboPesquisaFunc.ForeColor = System.Drawing.Color.Black
        Me.cboPesquisaFunc.Location = New System.Drawing.Point(104, 314)
        Me.cboPesquisaFunc.Name = "cboPesquisaFunc"
        Me.cboPesquisaFunc.Size = New System.Drawing.Size(133, 13)
        Me.cboPesquisaFunc.TabIndex = 15
        '
        'txtIDfunc
        '
        Me.txtIDfunc.BackColor = System.Drawing.Color.PowderBlue
        Me.txtIDfunc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIDfunc.Enabled = False
        Me.txtIDfunc.Location = New System.Drawing.Point(150, 26)
        Me.txtIDfunc.Name = "txtIDfunc"
        Me.txtIDfunc.Size = New System.Drawing.Size(70, 13)
        Me.txtIDfunc.TabIndex = 102
        '
        'cboUFfunc
        '
        Me.cboUFfunc.AutoCompleteCustomSource.AddRange(New String() {"AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.cboUFfunc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboUFfunc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cboUFfunc.BackColor = System.Drawing.Color.Silver
        Me.cboUFfunc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cboUFfunc.ForeColor = System.Drawing.Color.Black
        Me.cboUFfunc.Location = New System.Drawing.Point(451, 78)
        Me.cboUFfunc.Name = "cboUFfunc"
        Me.cboUFfunc.Size = New System.Drawing.Size(33, 13)
        Me.cboUFfunc.TabIndex = 9
        '
        'pbxExclui
        '
        Me.pbxExclui.AccessibleDescription = " "
        Me.pbxExclui.BackColor = System.Drawing.Color.Transparent
        Me.pbxExclui.Enabled = False
        Me.pbxExclui.Image = CType(resources.GetObject("pbxExclui.Image"), System.Drawing.Image)
        Me.pbxExclui.Location = New System.Drawing.Point(253, 254)
        Me.pbxExclui.Name = "pbxExclui"
        Me.pbxExclui.Size = New System.Drawing.Size(67, 44)
        Me.pbxExclui.TabIndex = 107
        Me.pbxExclui.TabStop = False
        Me.pbxExclui.Visible = False
        '
        'pbxAlter
        '
        Me.pbxAlter.AccessibleDescription = " "
        Me.pbxAlter.BackColor = System.Drawing.Color.Transparent
        Me.pbxAlter.Enabled = False
        Me.pbxAlter.Image = CType(resources.GetObject("pbxAlter.Image"), System.Drawing.Image)
        Me.pbxAlter.Location = New System.Drawing.Point(192, 251)
        Me.pbxAlter.Name = "pbxAlter"
        Me.pbxAlter.Size = New System.Drawing.Size(71, 44)
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
        Me.pbxNovo.Location = New System.Drawing.Point(76, 252)
        Me.pbxNovo.Name = "pbxNovo"
        Me.pbxNovo.Size = New System.Drawing.Size(66, 44)
        Me.pbxNovo.TabIndex = 105
        Me.pbxNovo.TabStop = False
        Me.pbxNovo.Visible = False
        '
        'pbxCadastrar
        '
        Me.pbxCadastrar.AccessibleDescription = " "
        Me.pbxCadastrar.BackColor = System.Drawing.Color.Transparent
        Me.pbxCadastrar.Enabled = False
        Me.pbxCadastrar.Image = CType(resources.GetObject("pbxCadastrar.Image"), System.Drawing.Image)
        Me.pbxCadastrar.Location = New System.Drawing.Point(124, 251)
        Me.pbxCadastrar.Name = "pbxCadastrar"
        Me.pbxCadastrar.Size = New System.Drawing.Size(86, 44)
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
        Me.pbxPesquisar.Location = New System.Drawing.Point(530, 302)
        Me.pbxPesquisar.Name = "pbxPesquisar"
        Me.pbxPesquisar.Size = New System.Drawing.Size(113, 44)
        Me.pbxPesquisar.TabIndex = 108
        Me.pbxPesquisar.TabStop = False
        Me.pbxPesquisar.Visible = False
        '
        'Funcionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(650, 489)
        Me.Controls.Add(Me.pbxPesquisar)
        Me.Controls.Add(Me.pbxExclui)
        Me.Controls.Add(Me.pbxAlter)
        Me.Controls.Add(Me.pbxNovo)
        Me.Controls.Add(Me.pbxCadastrar)
        Me.Controls.Add(Me.cboUFfunc)
        Me.Controls.Add(Me.txtIDfunc)
        Me.Controls.Add(Me.cboPesquisaFunc)
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
    Friend WithEvents cboPesquisaFunc As System.Windows.Forms.TextBox
    Friend WithEvents txtIDfunc As System.Windows.Forms.TextBox
    Friend WithEvents cboUFfunc As System.Windows.Forms.TextBox
    Friend WithEvents pbxExclui As System.Windows.Forms.PictureBox
    Friend WithEvents pbxAlter As System.Windows.Forms.PictureBox
    Friend WithEvents pbxNovo As System.Windows.Forms.PictureBox
    Friend WithEvents pbxCadastrar As System.Windows.Forms.PictureBox
    Friend WithEvents pbxPesquisar As System.Windows.Forms.PictureBox
End Class
