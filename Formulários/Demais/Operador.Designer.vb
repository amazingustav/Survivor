<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Operador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Operador))
        Me.cboFuncOp = New System.Windows.Forms.ComboBox()
        Me.ID_OP = New System.Windows.Forms.ComboBox()
        Me.txtConfSenhaOp = New System.Windows.Forms.TextBox()
        Me.txtSenhaOp = New System.Windows.Forms.TextBox()
        Me.txtNomeOp = New System.Windows.Forms.TextBox()
        Me.txtPesquisaOp = New System.Windows.Forms.TextBox()
        Me.dtgOperador = New System.Windows.Forms.DataGridView()
        Me.btnExcluiOp = New System.Windows.Forms.PictureBox()
        Me.btnAlterOp = New System.Windows.Forms.PictureBox()
        Me.btnCadastraOp = New System.Windows.Forms.PictureBox()
        Me.btnNovoOp = New System.Windows.Forms.PictureBox()
        Me.btnPesquisaOp = New System.Windows.Forms.PictureBox()
        Me.pbxExclui = New System.Windows.Forms.PictureBox()
        Me.pbxAlter = New System.Windows.Forms.PictureBox()
        Me.pbxNovo = New System.Windows.Forms.PictureBox()
        Me.pbxCadastrar = New System.Windows.Forms.PictureBox()
        Me.pbxPesquisar = New System.Windows.Forms.PictureBox()
        Me.cboPesquisaOp = New System.Windows.Forms.ComboBox()
        Me.btnHelp = New System.Windows.Forms.PictureBox()
        Me.btnEND = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblStatusSenha = New System.Windows.Forms.Label()
        Me.cboNivelOp = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dtgOperador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExcluiOp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAlterOp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCadastraOp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNovoOp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPesquisaOp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxExclui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxAlter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxNovo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxCadastrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxPesquisar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEND, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboFuncOp
        '
        Me.cboFuncOp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFuncOp.FormattingEnabled = True
        Me.cboFuncOp.Location = New System.Drawing.Point(178, 45)
        Me.cboFuncOp.Name = "cboFuncOp"
        Me.cboFuncOp.Size = New System.Drawing.Size(170, 21)
        Me.cboFuncOp.TabIndex = 1
        '
        'ID_OP
        '
        Me.ID_OP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ID_OP.Enabled = False
        Me.ID_OP.FormattingEnabled = True
        Me.ID_OP.Location = New System.Drawing.Point(556, 184)
        Me.ID_OP.Name = "ID_OP"
        Me.ID_OP.Size = New System.Drawing.Size(77, 24)
        Me.ID_OP.TabIndex = 85
        Me.ID_OP.Visible = False
        '
        'txtConfSenhaOp
        '
        Me.txtConfSenhaOp.BackColor = System.Drawing.Color.White
        Me.txtConfSenhaOp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtConfSenhaOp.Location = New System.Drawing.Point(159, 190)
        Me.txtConfSenhaOp.Name = "txtConfSenhaOp"
        Me.txtConfSenhaOp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtConfSenhaOp.Size = New System.Drawing.Size(184, 13)
        Me.txtConfSenhaOp.TabIndex = 5
        Me.txtConfSenhaOp.UseSystemPasswordChar = True
        '
        'txtSenhaOp
        '
        Me.txtSenhaOp.BackColor = System.Drawing.Color.White
        Me.txtSenhaOp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSenhaOp.Location = New System.Drawing.Point(97, 157)
        Me.txtSenhaOp.Name = "txtSenhaOp"
        Me.txtSenhaOp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtSenhaOp.Size = New System.Drawing.Size(246, 13)
        Me.txtSenhaOp.TabIndex = 4
        Me.txtSenhaOp.UseSystemPasswordChar = True
        '
        'txtNomeOp
        '
        Me.txtNomeOp.BackColor = System.Drawing.Color.White
        Me.txtNomeOp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNomeOp.Location = New System.Drawing.Point(97, 88)
        Me.txtNomeOp.Name = "txtNomeOp"
        Me.txtNomeOp.Size = New System.Drawing.Size(246, 13)
        Me.txtNomeOp.TabIndex = 2
        '
        'txtPesquisaOp
        '
        Me.txtPesquisaOp.BackColor = System.Drawing.Color.White
        Me.txtPesquisaOp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPesquisaOp.Location = New System.Drawing.Point(318, 327)
        Me.txtPesquisaOp.Name = "txtPesquisaOp"
        Me.txtPesquisaOp.Size = New System.Drawing.Size(215, 13)
        Me.txtPesquisaOp.TabIndex = 7
        '
        'dtgOperador
        '
        Me.dtgOperador.AllowUserToAddRows = False
        Me.dtgOperador.AllowUserToDeleteRows = False
        Me.dtgOperador.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dtgOperador.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgOperador.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dtgOperador.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgOperador.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgOperador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgOperador.Cursor = System.Windows.Forms.Cursors.Default
        Me.dtgOperador.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtgOperador.Location = New System.Drawing.Point(35, 355)
        Me.dtgOperador.Name = "dtgOperador"
        Me.dtgOperador.ReadOnly = True
        Me.dtgOperador.Size = New System.Drawing.Size(596, 120)
        Me.dtgOperador.TabIndex = 87
        '
        'btnExcluiOp
        '
        Me.btnExcluiOp.BackColor = System.Drawing.Color.Transparent
        Me.btnExcluiOp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluiOp.Location = New System.Drawing.Point(461, 212)
        Me.btnExcluiOp.Name = "btnExcluiOp"
        Me.btnExcluiOp.Size = New System.Drawing.Size(51, 54)
        Me.btnExcluiOp.TabIndex = 94
        Me.btnExcluiOp.TabStop = False
        '
        'btnAlterOp
        '
        Me.btnAlterOp.BackColor = System.Drawing.Color.Transparent
        Me.btnAlterOp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAlterOp.Location = New System.Drawing.Point(404, 211)
        Me.btnAlterOp.Name = "btnAlterOp"
        Me.btnAlterOp.Size = New System.Drawing.Size(51, 54)
        Me.btnAlterOp.TabIndex = 93
        Me.btnAlterOp.TabStop = False
        '
        'btnCadastraOp
        '
        Me.btnCadastraOp.BackColor = System.Drawing.Color.Transparent
        Me.btnCadastraOp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCadastraOp.Location = New System.Drawing.Point(343, 214)
        Me.btnCadastraOp.Name = "btnCadastraOp"
        Me.btnCadastraOp.Size = New System.Drawing.Size(51, 54)
        Me.btnCadastraOp.TabIndex = 92
        Me.btnCadastraOp.TabStop = False
        '
        'btnNovoOp
        '
        Me.btnNovoOp.BackColor = System.Drawing.Color.Transparent
        Me.btnNovoOp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNovoOp.Location = New System.Drawing.Point(280, 214)
        Me.btnNovoOp.Name = "btnNovoOp"
        Me.btnNovoOp.Size = New System.Drawing.Size(51, 54)
        Me.btnNovoOp.TabIndex = 91
        Me.btnNovoOp.TabStop = False
        '
        'btnPesquisaOp
        '
        Me.btnPesquisaOp.BackColor = System.Drawing.Color.Transparent
        Me.btnPesquisaOp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPesquisaOp.Location = New System.Drawing.Point(539, 305)
        Me.btnPesquisaOp.Name = "btnPesquisaOp"
        Me.btnPesquisaOp.Size = New System.Drawing.Size(51, 40)
        Me.btnPesquisaOp.TabIndex = 95
        Me.btnPesquisaOp.TabStop = False
        '
        'pbxExclui
        '
        Me.pbxExclui.AccessibleDescription = " "
        Me.pbxExclui.BackColor = System.Drawing.Color.Transparent
        Me.pbxExclui.Enabled = False
        Me.pbxExclui.Image = CType(resources.GetObject("pbxExclui.Image"), System.Drawing.Image)
        Me.pbxExclui.Location = New System.Drawing.Point(449, 254)
        Me.pbxExclui.Name = "pbxExclui"
        Me.pbxExclui.Size = New System.Drawing.Size(63, 44)
        Me.pbxExclui.TabIndex = 101
        Me.pbxExclui.TabStop = False
        Me.pbxExclui.Visible = False
        '
        'pbxAlter
        '
        Me.pbxAlter.AccessibleDescription = " "
        Me.pbxAlter.BackColor = System.Drawing.Color.Transparent
        Me.pbxAlter.Enabled = False
        Me.pbxAlter.Image = CType(resources.GetObject("pbxAlter.Image"), System.Drawing.Image)
        Me.pbxAlter.Location = New System.Drawing.Point(384, 254)
        Me.pbxAlter.Name = "pbxAlter"
        Me.pbxAlter.Size = New System.Drawing.Size(71, 44)
        Me.pbxAlter.TabIndex = 100
        Me.pbxAlter.TabStop = False
        Me.pbxAlter.Visible = False
        '
        'pbxNovo
        '
        Me.pbxNovo.AccessibleDescription = " "
        Me.pbxNovo.BackColor = System.Drawing.Color.Transparent
        Me.pbxNovo.Enabled = False
        Me.pbxNovo.Image = CType(resources.GetObject("pbxNovo.Image"), System.Drawing.Image)
        Me.pbxNovo.Location = New System.Drawing.Point(271, 254)
        Me.pbxNovo.Name = "pbxNovo"
        Me.pbxNovo.Size = New System.Drawing.Size(66, 44)
        Me.pbxNovo.TabIndex = 99
        Me.pbxNovo.TabStop = False
        Me.pbxNovo.Visible = False
        '
        'pbxCadastrar
        '
        Me.pbxCadastrar.AccessibleDescription = " "
        Me.pbxCadastrar.BackColor = System.Drawing.Color.Transparent
        Me.pbxCadastrar.Enabled = False
        Me.pbxCadastrar.Image = CType(resources.GetObject("pbxCadastrar.Image"), System.Drawing.Image)
        Me.pbxCadastrar.Location = New System.Drawing.Point(318, 254)
        Me.pbxCadastrar.Name = "pbxCadastrar"
        Me.pbxCadastrar.Size = New System.Drawing.Size(86, 44)
        Me.pbxCadastrar.TabIndex = 98
        Me.pbxCadastrar.TabStop = False
        Me.pbxCadastrar.Visible = False
        '
        'pbxPesquisar
        '
        Me.pbxPesquisar.AccessibleDescription = " "
        Me.pbxPesquisar.BackColor = System.Drawing.Color.Transparent
        Me.pbxPesquisar.Enabled = False
        Me.pbxPesquisar.Image = CType(resources.GetObject("pbxPesquisar.Image"), System.Drawing.Image)
        Me.pbxPesquisar.Location = New System.Drawing.Point(518, 275)
        Me.pbxPesquisar.Name = "pbxPesquisar"
        Me.pbxPesquisar.Size = New System.Drawing.Size(113, 44)
        Me.pbxPesquisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxPesquisar.TabIndex = 102
        Me.pbxPesquisar.TabStop = False
        Me.pbxPesquisar.Visible = False
        '
        'cboPesquisaOp
        '
        Me.cboPesquisaOp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPesquisaOp.FormattingEnabled = True
        Me.cboPesquisaOp.Items.AddRange(New Object() {"ID", "Nome", "Nível", "Usuário"})
        Me.cboPesquisaOp.Location = New System.Drawing.Point(108, 321)
        Me.cboPesquisaOp.Name = "cboPesquisaOp"
        Me.cboPesquisaOp.Size = New System.Drawing.Size(180, 21)
        Me.cboPesquisaOp.TabIndex = 6
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.Transparent
        Me.btnHelp.Cursor = System.Windows.Forms.Cursors.Help
        Me.btnHelp.Location = New System.Drawing.Point(596, 11)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(24, 20)
        Me.btnHelp.TabIndex = 138
        Me.btnHelp.TabStop = False
        '
        'btnEND
        '
        Me.btnEND.BackColor = System.Drawing.Color.Transparent
        Me.btnEND.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEND.Location = New System.Drawing.Point(621, 12)
        Me.btnEND.Name = "btnEND"
        Me.btnEND.Size = New System.Drawing.Size(24, 20)
        Me.btnEND.TabIndex = 137
        Me.btnEND.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(8, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 23)
        Me.Label4.TabIndex = 142
        Me.Label4.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(8, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 23)
        Me.Label3.TabIndex = 141
        Me.Label3.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(8, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 23)
        Me.Label2.TabIndex = 140
        Me.Label2.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(8, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 23)
        Me.Label1.TabIndex = 139
        Me.Label1.Text = "*"
        '
        'lblStatusSenha
        '
        Me.lblStatusSenha.AutoSize = True
        Me.lblStatusSenha.BackColor = System.Drawing.Color.Transparent
        Me.lblStatusSenha.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatusSenha.Location = New System.Drawing.Point(80, 214)
        Me.lblStatusSenha.Name = "lblStatusSenha"
        Me.lblStatusSenha.Size = New System.Drawing.Size(55, 19)
        Me.lblStatusSenha.TabIndex = 143
        Me.lblStatusSenha.Text = "Label5"
        Me.lblStatusSenha.Visible = False
        '
        'cboNivelOp
        '
        Me.cboNivelOp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNivelOp.FormattingEnabled = True
        Me.cboNivelOp.Items.AddRange(New Object() {"Administrador", "Vendedor", "Caixa"})
        Me.cboNivelOp.Location = New System.Drawing.Point(94, 116)
        Me.cboNivelOp.Name = "cboNivelOp"
        Me.cboNivelOp.Size = New System.Drawing.Size(254, 21)
        Me.cboNivelOp.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(8, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 23)
        Me.Label5.TabIndex = 144
        Me.Label5.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(24, 254)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(216, 23)
        Me.Label6.TabIndex = 145
        Me.Label6.Text = "(*) Campos obrigatórios!"
        '
        'Operador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(666, 503)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboNivelOp)
        Me.Controls.Add(Me.lblStatusSenha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnEND)
        Me.Controls.Add(Me.cboPesquisaOp)
        Me.Controls.Add(Me.pbxPesquisar)
        Me.Controls.Add(Me.pbxExclui)
        Me.Controls.Add(Me.pbxAlter)
        Me.Controls.Add(Me.pbxNovo)
        Me.Controls.Add(Me.pbxCadastrar)
        Me.Controls.Add(Me.btnPesquisaOp)
        Me.Controls.Add(Me.btnExcluiOp)
        Me.Controls.Add(Me.btnAlterOp)
        Me.Controls.Add(Me.btnCadastraOp)
        Me.Controls.Add(Me.btnNovoOp)
        Me.Controls.Add(Me.txtPesquisaOp)
        Me.Controls.Add(Me.dtgOperador)
        Me.Controls.Add(Me.cboFuncOp)
        Me.Controls.Add(Me.ID_OP)
        Me.Controls.Add(Me.txtNomeOp)
        Me.Controls.Add(Me.txtSenhaOp)
        Me.Controls.Add(Me.txtConfSenhaOp)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Operador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Operador/Login"
        Me.TopMost = True
        CType(Me.dtgOperador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExcluiOp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAlterOp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCadastraOp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNovoOp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPesquisaOp, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents cboFuncOp As System.Windows.Forms.ComboBox
    Friend WithEvents ID_OP As System.Windows.Forms.ComboBox
    Friend WithEvents txtConfSenhaOp As System.Windows.Forms.TextBox
    Friend WithEvents txtSenhaOp As System.Windows.Forms.TextBox
    Friend WithEvents txtNomeOp As System.Windows.Forms.TextBox
    Friend WithEvents txtPesquisaOp As System.Windows.Forms.TextBox
    Friend WithEvents dtgOperador As System.Windows.Forms.DataGridView
    Friend WithEvents btnExcluiOp As System.Windows.Forms.PictureBox
    Friend WithEvents btnAlterOp As System.Windows.Forms.PictureBox
    Friend WithEvents btnCadastraOp As System.Windows.Forms.PictureBox
    Friend WithEvents btnNovoOp As System.Windows.Forms.PictureBox
    Friend WithEvents btnPesquisaOp As System.Windows.Forms.PictureBox
    Friend WithEvents pbxExclui As System.Windows.Forms.PictureBox
    Friend WithEvents pbxAlter As System.Windows.Forms.PictureBox
    Friend WithEvents pbxNovo As System.Windows.Forms.PictureBox
    Friend WithEvents pbxCadastrar As System.Windows.Forms.PictureBox
    Friend WithEvents pbxPesquisar As System.Windows.Forms.PictureBox
    Friend WithEvents cboPesquisaOp As System.Windows.Forms.ComboBox
    Friend WithEvents btnHelp As System.Windows.Forms.PictureBox
    Friend WithEvents btnEND As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblStatusSenha As System.Windows.Forms.Label
    Friend WithEvents cboNivelOp As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
