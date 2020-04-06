<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cliente
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cliente))
        Me.IDcmo = New System.Windows.Forms.ComboBox()
        Me.txtCidadeCli = New System.Windows.Forms.TextBox()
        Me.txtEmailCli = New System.Windows.Forms.TextBox()
        Me.mskCelCli = New System.Windows.Forms.MaskedTextBox()
        Me.mskCEPcli = New System.Windows.Forms.MaskedTextBox()
        Me.mskTelCli = New System.Windows.Forms.MaskedTextBox()
        Me.rdbMascCli = New System.Windows.Forms.RadioButton()
        Me.rdbFemCli = New System.Windows.Forms.RadioButton()
        Me.txtPesquisaCli = New System.Windows.Forms.TextBox()
        Me.dtgCliente = New System.Windows.Forms.DataGridView()
        Me.btnNovoCli = New System.Windows.Forms.PictureBox()
        Me.btnCadastraCli = New System.Windows.Forms.PictureBox()
        Me.btnAlterCli = New System.Windows.Forms.PictureBox()
        Me.btnExcluiCli = New System.Windows.Forms.PictureBox()
        Me.cboPesquisaCli = New System.Windows.Forms.TextBox()
        Me.txtIDcli = New System.Windows.Forms.TextBox()
        Me.cboUFcli = New System.Windows.Forms.TextBox()
        Me.btnPesquisarCli = New System.Windows.Forms.PictureBox()
        Me.pbxCadastrar = New System.Windows.Forms.PictureBox()
        Me.pbxNovo = New System.Windows.Forms.PictureBox()
        Me.pbxAlter = New System.Windows.Forms.PictureBox()
        Me.pbxExclui = New System.Windows.Forms.PictureBox()
        Me.txtNomeCli = New System.Windows.Forms.TextBox()
        Me.txtRGcli = New System.Windows.Forms.TextBox()
        Me.mskCPFcli = New System.Windows.Forms.TextBox()
        Me.txtEnderCli = New System.Windows.Forms.TextBox()
        Me.txtCompleCli = New System.Windows.Forms.TextBox()
        Me.txtBairroCli = New System.Windows.Forms.TextBox()
        Me.pbxPesquisar = New System.Windows.Forms.PictureBox()
        CType(Me.dtgCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNovoCli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCadastraCli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAlterCli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExcluiCli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPesquisarCli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxCadastrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxNovo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxAlter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxExclui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxPesquisar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDcmo
        '
        Me.IDcmo.BackColor = System.Drawing.Color.LightBlue
        Me.IDcmo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.IDcmo.Enabled = False
        Me.IDcmo.FormattingEnabled = True
        Me.IDcmo.Location = New System.Drawing.Point(24, 211)
        Me.IDcmo.Name = "IDcmo"
        Me.IDcmo.Size = New System.Drawing.Size(77, 21)
        Me.IDcmo.TabIndex = 79
        Me.IDcmo.Visible = False
        '
        'txtCidadeCli
        '
        Me.txtCidadeCli.BackColor = System.Drawing.Color.Silver
        Me.txtCidadeCli.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCidadeCli.ForeColor = System.Drawing.Color.Black
        Me.txtCidadeCli.Location = New System.Drawing.Point(446, 24)
        Me.txtCidadeCli.Name = "txtCidadeCli"
        Me.txtCidadeCli.Size = New System.Drawing.Size(114, 13)
        Me.txtCidadeCli.TabIndex = 7
        '
        'txtEmailCli
        '
        Me.txtEmailCli.BackColor = System.Drawing.Color.Silver
        Me.txtEmailCli.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmailCli.ForeColor = System.Drawing.Color.Black
        Me.txtEmailCli.Location = New System.Drawing.Point(446, 155)
        Me.txtEmailCli.Name = "txtEmailCli"
        Me.txtEmailCli.Size = New System.Drawing.Size(115, 13)
        Me.txtEmailCli.TabIndex = 12
        '
        'mskCelCli
        '
        Me.mskCelCli.BackColor = System.Drawing.Color.Silver
        Me.mskCelCli.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mskCelCli.ForeColor = System.Drawing.Color.Black
        Me.mskCelCli.Location = New System.Drawing.Point(446, 129)
        Me.mskCelCli.Mask = "(99) 0000-0000"
        Me.mskCelCli.Name = "mskCelCli"
        Me.mskCelCli.Size = New System.Drawing.Size(115, 13)
        Me.mskCelCli.TabIndex = 11
        '
        'mskCEPcli
        '
        Me.mskCEPcli.BackColor = System.Drawing.Color.Silver
        Me.mskCEPcli.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mskCEPcli.ForeColor = System.Drawing.Color.Black
        Me.mskCEPcli.Location = New System.Drawing.Point(446, 51)
        Me.mskCEPcli.Mask = "00000-999"
        Me.mskCEPcli.Name = "mskCEPcli"
        Me.mskCEPcli.Size = New System.Drawing.Size(78, 13)
        Me.mskCEPcli.TabIndex = 8
        '
        'mskTelCli
        '
        Me.mskTelCli.BackColor = System.Drawing.Color.Silver
        Me.mskTelCli.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mskTelCli.ForeColor = System.Drawing.Color.Black
        Me.mskTelCli.Location = New System.Drawing.Point(446, 103)
        Me.mskTelCli.Mask = "(99) 0000-0000"
        Me.mskTelCli.Name = "mskTelCli"
        Me.mskTelCli.Size = New System.Drawing.Size(115, 13)
        Me.mskTelCli.TabIndex = 10
        '
        'rdbMascCli
        '
        Me.rdbMascCli.AutoSize = True
        Me.rdbMascCli.BackColor = System.Drawing.Color.Transparent
        Me.rdbMascCli.Location = New System.Drawing.Point(488, 179)
        Me.rdbMascCli.Name = "rdbMascCli"
        Me.rdbMascCli.Size = New System.Drawing.Size(34, 17)
        Me.rdbMascCli.TabIndex = 14
        Me.rdbMascCli.TabStop = True
        Me.rdbMascCli.Text = "M"
        Me.rdbMascCli.UseVisualStyleBackColor = False
        '
        'rdbFemCli
        '
        Me.rdbFemCli.AutoSize = True
        Me.rdbFemCli.BackColor = System.Drawing.Color.Transparent
        Me.rdbFemCli.Location = New System.Drawing.Point(448, 179)
        Me.rdbFemCli.Name = "rdbFemCli"
        Me.rdbFemCli.Size = New System.Drawing.Size(31, 17)
        Me.rdbFemCli.TabIndex = 13
        Me.rdbFemCli.TabStop = True
        Me.rdbFemCli.Text = "F"
        Me.rdbFemCli.UseVisualStyleBackColor = False
        '
        'txtPesquisaCli
        '
        Me.txtPesquisaCli.BackColor = System.Drawing.Color.Silver
        Me.txtPesquisaCli.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPesquisaCli.ForeColor = System.Drawing.Color.Black
        Me.txtPesquisaCli.Location = New System.Drawing.Point(275, 313)
        Me.txtPesquisaCli.Name = "txtPesquisaCli"
        Me.txtPesquisaCli.Size = New System.Drawing.Size(232, 13)
        Me.txtPesquisaCli.TabIndex = 16
        '
        'dtgCliente
        '
        Me.dtgCliente.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dtgCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dtgCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgCliente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgCliente.Cursor = System.Windows.Forms.Cursors.Cross
        Me.dtgCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtgCliente.Location = New System.Drawing.Point(40, 340)
        Me.dtgCliente.Name = "dtgCliente"
        Me.dtgCliente.Size = New System.Drawing.Size(569, 125)
        Me.dtgCliente.TabIndex = 80
        '
        'btnNovoCli
        '
        Me.btnNovoCli.BackColor = System.Drawing.Color.Transparent
        Me.btnNovoCli.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNovoCli.Location = New System.Drawing.Point(283, 211)
        Me.btnNovoCli.Name = "btnNovoCli"
        Me.btnNovoCli.Size = New System.Drawing.Size(51, 54)
        Me.btnNovoCli.TabIndex = 84
        Me.btnNovoCli.TabStop = False
        '
        'btnCadastraCli
        '
        Me.btnCadastraCli.BackColor = System.Drawing.Color.Transparent
        Me.btnCadastraCli.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCadastraCli.Location = New System.Drawing.Point(342, 211)
        Me.btnCadastraCli.Name = "btnCadastraCli"
        Me.btnCadastraCli.Size = New System.Drawing.Size(51, 54)
        Me.btnCadastraCli.TabIndex = 85
        Me.btnCadastraCli.TabStop = False
        '
        'btnAlterCli
        '
        Me.btnAlterCli.BackColor = System.Drawing.Color.Transparent
        Me.btnAlterCli.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAlterCli.Location = New System.Drawing.Point(401, 210)
        Me.btnAlterCli.Name = "btnAlterCli"
        Me.btnAlterCli.Size = New System.Drawing.Size(51, 54)
        Me.btnAlterCli.TabIndex = 86
        Me.btnAlterCli.TabStop = False
        '
        'btnExcluiCli
        '
        Me.btnExcluiCli.BackColor = System.Drawing.Color.Transparent
        Me.btnExcluiCli.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluiCli.Location = New System.Drawing.Point(455, 209)
        Me.btnExcluiCli.Name = "btnExcluiCli"
        Me.btnExcluiCli.Size = New System.Drawing.Size(51, 54)
        Me.btnExcluiCli.TabIndex = 87
        Me.btnExcluiCli.TabStop = False
        '
        'cboPesquisaCli
        '
        Me.cboPesquisaCli.AutoCompleteCustomSource.AddRange(New String() {"Nome", "RG", "CPF", "Endereço", "Cidade", "Telefone", "Celular"})
        Me.cboPesquisaCli.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboPesquisaCli.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cboPesquisaCli.BackColor = System.Drawing.Color.Silver
        Me.cboPesquisaCli.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cboPesquisaCli.ForeColor = System.Drawing.Color.Black
        Me.cboPesquisaCli.Location = New System.Drawing.Point(95, 313)
        Me.cboPesquisaCli.Name = "cboPesquisaCli"
        Me.cboPesquisaCli.Size = New System.Drawing.Size(133, 13)
        Me.cboPesquisaCli.TabIndex = 15
        '
        'txtIDcli
        '
        Me.txtIDcli.BackColor = System.Drawing.Color.LightBlue
        Me.txtIDcli.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIDcli.Enabled = False
        Me.txtIDcli.Location = New System.Drawing.Point(146, 24)
        Me.txtIDcli.Name = "txtIDcli"
        Me.txtIDcli.Size = New System.Drawing.Size(58, 13)
        Me.txtIDcli.TabIndex = 89
        '
        'cboUFcli
        '
        Me.cboUFcli.AutoCompleteCustomSource.AddRange(New String() {"AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.cboUFcli.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboUFcli.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cboUFcli.BackColor = System.Drawing.Color.Silver
        Me.cboUFcli.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cboUFcli.ForeColor = System.Drawing.Color.Black
        Me.cboUFcli.Location = New System.Drawing.Point(447, 77)
        Me.cboUFcli.Name = "cboUFcli"
        Me.cboUFcli.Size = New System.Drawing.Size(33, 13)
        Me.cboUFcli.TabIndex = 9
        '
        'btnPesquisarCli
        '
        Me.btnPesquisarCli.BackColor = System.Drawing.Color.Transparent
        Me.btnPesquisarCli.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPesquisarCli.Location = New System.Drawing.Point(524, 296)
        Me.btnPesquisarCli.Name = "btnPesquisarCli"
        Me.btnPesquisarCli.Size = New System.Drawing.Size(51, 37)
        Me.btnPesquisarCli.TabIndex = 91
        Me.btnPesquisarCli.TabStop = False
        '
        'pbxCadastrar
        '
        Me.pbxCadastrar.AccessibleDescription = " "
        Me.pbxCadastrar.BackColor = System.Drawing.Color.Transparent
        Me.pbxCadastrar.Enabled = False
        Me.pbxCadastrar.Image = CType(resources.GetObject("pbxCadastrar.Image"), System.Drawing.Image)
        Me.pbxCadastrar.Location = New System.Drawing.Point(322, 253)
        Me.pbxCadastrar.Name = "pbxCadastrar"
        Me.pbxCadastrar.Size = New System.Drawing.Size(86, 44)
        Me.pbxCadastrar.TabIndex = 92
        Me.pbxCadastrar.TabStop = False
        Me.pbxCadastrar.Visible = False
        '
        'pbxNovo
        '
        Me.pbxNovo.AccessibleDescription = " "
        Me.pbxNovo.BackColor = System.Drawing.Color.Transparent
        Me.pbxNovo.Enabled = False
        Me.pbxNovo.Image = CType(resources.GetObject("pbxNovo.Image"), System.Drawing.Image)
        Me.pbxNovo.Location = New System.Drawing.Point(274, 254)
        Me.pbxNovo.Name = "pbxNovo"
        Me.pbxNovo.Size = New System.Drawing.Size(62, 44)
        Me.pbxNovo.TabIndex = 93
        Me.pbxNovo.TabStop = False
        Me.pbxNovo.Visible = False
        '
        'pbxAlter
        '
        Me.pbxAlter.AccessibleDescription = " "
        Me.pbxAlter.BackColor = System.Drawing.Color.Transparent
        Me.pbxAlter.Enabled = False
        Me.pbxAlter.Image = CType(resources.GetObject("pbxAlter.Image"), System.Drawing.Image)
        Me.pbxAlter.Location = New System.Drawing.Point(390, 253)
        Me.pbxAlter.Name = "pbxAlter"
        Me.pbxAlter.Size = New System.Drawing.Size(71, 44)
        Me.pbxAlter.TabIndex = 94
        Me.pbxAlter.TabStop = False
        Me.pbxAlter.Visible = False
        '
        'pbxExclui
        '
        Me.pbxExclui.AccessibleDescription = " "
        Me.pbxExclui.BackColor = System.Drawing.Color.Transparent
        Me.pbxExclui.Enabled = False
        Me.pbxExclui.Image = CType(resources.GetObject("pbxExclui.Image"), System.Drawing.Image)
        Me.pbxExclui.Location = New System.Drawing.Point(451, 256)
        Me.pbxExclui.Name = "pbxExclui"
        Me.pbxExclui.Size = New System.Drawing.Size(67, 44)
        Me.pbxExclui.TabIndex = 95
        Me.pbxExclui.TabStop = False
        Me.pbxExclui.Visible = False
        '
        'txtNomeCli
        '
        Me.txtNomeCli.BackColor = System.Drawing.Color.Silver
        Me.txtNomeCli.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNomeCli.ForeColor = System.Drawing.Color.Black
        Me.txtNomeCli.Location = New System.Drawing.Point(145, 53)
        Me.txtNomeCli.Name = "txtNomeCli"
        Me.txtNomeCli.Size = New System.Drawing.Size(128, 13)
        Me.txtNomeCli.TabIndex = 1
        '
        'txtRGcli
        '
        Me.txtRGcli.BackColor = System.Drawing.Color.Silver
        Me.txtRGcli.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRGcli.ForeColor = System.Drawing.Color.Black
        Me.txtRGcli.Location = New System.Drawing.Point(146, 79)
        Me.txtRGcli.Name = "txtRGcli"
        Me.txtRGcli.Size = New System.Drawing.Size(128, 13)
        Me.txtRGcli.TabIndex = 2
        '
        'mskCPFcli
        '
        Me.mskCPFcli.BackColor = System.Drawing.Color.Silver
        Me.mskCPFcli.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mskCPFcli.ForeColor = System.Drawing.Color.Black
        Me.mskCPFcli.Location = New System.Drawing.Point(146, 105)
        Me.mskCPFcli.Name = "mskCPFcli"
        Me.mskCPFcli.Size = New System.Drawing.Size(128, 13)
        Me.mskCPFcli.TabIndex = 3
        '
        'txtEnderCli
        '
        Me.txtEnderCli.BackColor = System.Drawing.Color.Silver
        Me.txtEnderCli.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEnderCli.ForeColor = System.Drawing.Color.Black
        Me.txtEnderCli.Location = New System.Drawing.Point(146, 130)
        Me.txtEnderCli.Name = "txtEnderCli"
        Me.txtEnderCli.Size = New System.Drawing.Size(128, 13)
        Me.txtEnderCli.TabIndex = 3
        '
        'txtCompleCli
        '
        Me.txtCompleCli.BackColor = System.Drawing.Color.Silver
        Me.txtCompleCli.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCompleCli.ForeColor = System.Drawing.Color.Black
        Me.txtCompleCli.Location = New System.Drawing.Point(146, 156)
        Me.txtCompleCli.Name = "txtCompleCli"
        Me.txtCompleCli.Size = New System.Drawing.Size(128, 13)
        Me.txtCompleCli.TabIndex = 5
        '
        'txtBairroCli
        '
        Me.txtBairroCli.BackColor = System.Drawing.Color.Silver
        Me.txtBairroCli.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBairroCli.ForeColor = System.Drawing.Color.Black
        Me.txtBairroCli.Location = New System.Drawing.Point(146, 182)
        Me.txtBairroCli.Name = "txtBairroCli"
        Me.txtBairroCli.Size = New System.Drawing.Size(128, 13)
        Me.txtBairroCli.TabIndex = 6
        '
        'pbxPesquisar
        '
        Me.pbxPesquisar.AccessibleDescription = " "
        Me.pbxPesquisar.BackColor = System.Drawing.Color.Transparent
        Me.pbxPesquisar.Enabled = False
        Me.pbxPesquisar.Image = CType(resources.GetObject("pbxPesquisar.Image"), System.Drawing.Image)
        Me.pbxPesquisar.Location = New System.Drawing.Point(525, 303)
        Me.pbxPesquisar.Name = "pbxPesquisar"
        Me.pbxPesquisar.Size = New System.Drawing.Size(113, 44)
        Me.pbxPesquisar.TabIndex = 96
        Me.pbxPesquisar.TabStop = False
        Me.pbxPesquisar.Visible = False
        '
        'Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(641, 488)
        Me.Controls.Add(Me.pbxPesquisar)
        Me.Controls.Add(Me.txtBairroCli)
        Me.Controls.Add(Me.txtCompleCli)
        Me.Controls.Add(Me.txtEnderCli)
        Me.Controls.Add(Me.mskCPFcli)
        Me.Controls.Add(Me.txtRGcli)
        Me.Controls.Add(Me.txtNomeCli)
        Me.Controls.Add(Me.pbxExclui)
        Me.Controls.Add(Me.pbxAlter)
        Me.Controls.Add(Me.pbxNovo)
        Me.Controls.Add(Me.pbxCadastrar)
        Me.Controls.Add(Me.btnPesquisarCli)
        Me.Controls.Add(Me.cboUFcli)
        Me.Controls.Add(Me.txtIDcli)
        Me.Controls.Add(Me.cboPesquisaCli)
        Me.Controls.Add(Me.btnExcluiCli)
        Me.Controls.Add(Me.btnAlterCli)
        Me.Controls.Add(Me.btnCadastraCli)
        Me.Controls.Add(Me.btnNovoCli)
        Me.Controls.Add(Me.txtPesquisaCli)
        Me.Controls.Add(Me.dtgCliente)
        Me.Controls.Add(Me.txtCidadeCli)
        Me.Controls.Add(Me.txtEmailCli)
        Me.Controls.Add(Me.rdbFemCli)
        Me.Controls.Add(Me.mskCelCli)
        Me.Controls.Add(Me.rdbMascCli)
        Me.Controls.Add(Me.mskCEPcli)
        Me.Controls.Add(Me.mskTelCli)
        Me.Controls.Add(Me.IDcmo)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cliente"
        Me.TopMost = True
        CType(Me.dtgCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNovoCli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCadastraCli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAlterCli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExcluiCli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPesquisarCli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxCadastrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxNovo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxAlter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxExclui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxPesquisar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IDcmo As System.Windows.Forms.ComboBox
    Friend WithEvents txtCidadeCli As System.Windows.Forms.TextBox
    Friend WithEvents txtEmailCli As System.Windows.Forms.TextBox
    Friend WithEvents mskCelCli As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskCEPcli As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskTelCli As System.Windows.Forms.MaskedTextBox
    Friend WithEvents rdbMascCli As System.Windows.Forms.RadioButton
    Friend WithEvents rdbFemCli As System.Windows.Forms.RadioButton
    Friend WithEvents txtPesquisaCli As System.Windows.Forms.TextBox
    Friend WithEvents dtgCliente As System.Windows.Forms.DataGridView
    Friend WithEvents btnNovoCli As System.Windows.Forms.PictureBox
    Friend WithEvents btnCadastraCli As System.Windows.Forms.PictureBox
    Friend WithEvents btnAlterCli As System.Windows.Forms.PictureBox
    Friend WithEvents btnExcluiCli As System.Windows.Forms.PictureBox
    Friend WithEvents cboPesquisaCli As System.Windows.Forms.TextBox
    Friend WithEvents txtIDcli As System.Windows.Forms.TextBox
    Friend WithEvents cboUFcli As System.Windows.Forms.TextBox
    Friend WithEvents btnPesquisarCli As System.Windows.Forms.PictureBox
    Friend WithEvents pbxCadastrar As System.Windows.Forms.PictureBox
    Friend WithEvents pbxNovo As System.Windows.Forms.PictureBox
    Friend WithEvents pbxAlter As System.Windows.Forms.PictureBox
    Friend WithEvents pbxExclui As System.Windows.Forms.PictureBox
    Friend WithEvents txtRGcli As System.Windows.Forms.TextBox
    Friend WithEvents mskCPFcli As System.Windows.Forms.TextBox
    Friend WithEvents txtEnderCli As System.Windows.Forms.TextBox
    Friend WithEvents txtCompleCli As System.Windows.Forms.TextBox
    Friend WithEvents txtBairroCli As System.Windows.Forms.TextBox
    Friend WithEvents txtNomeCli As System.Windows.Forms.TextBox
    Friend WithEvents pbxPesquisar As System.Windows.Forms.PictureBox
End Class
