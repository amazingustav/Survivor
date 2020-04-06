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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Operador))
        Me.cboFuncOp = New System.Windows.Forms.ComboBox()
        Me.ID_OP = New System.Windows.Forms.ComboBox()
        Me.lblStatusSenha = New System.Windows.Forms.Label()
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
        Me.cboPesquisaOp = New System.Windows.Forms.TextBox()
        Me.cboNivelOp = New System.Windows.Forms.TextBox()
        Me.pbxExclui = New System.Windows.Forms.PictureBox()
        Me.pbxAlter = New System.Windows.Forms.PictureBox()
        Me.pbxNovo = New System.Windows.Forms.PictureBox()
        Me.pbxCadastrar = New System.Windows.Forms.PictureBox()
        Me.pbxPesquisar = New System.Windows.Forms.PictureBox()
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
        Me.SuspendLayout()
        '
        'cboFuncOp
        '
        Me.cboFuncOp.FormattingEnabled = True
        Me.cboFuncOp.Location = New System.Drawing.Point(183, 16)
        Me.cboFuncOp.Name = "cboFuncOp"
        Me.cboFuncOp.Size = New System.Drawing.Size(129, 21)
        Me.cboFuncOp.TabIndex = 1
        '
        'ID_OP
        '
        Me.ID_OP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ID_OP.Enabled = False
        Me.ID_OP.FormattingEnabled = True
        Me.ID_OP.Location = New System.Drawing.Point(24, 211)
        Me.ID_OP.Name = "ID_OP"
        Me.ID_OP.Size = New System.Drawing.Size(77, 24)
        Me.ID_OP.TabIndex = 85
        Me.ID_OP.Visible = False
        '
        'lblStatusSenha
        '
        Me.lblStatusSenha.AutoSize = True
        Me.lblStatusSenha.BackColor = System.Drawing.Color.Transparent
        Me.lblStatusSenha.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatusSenha.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblStatusSenha.Location = New System.Drawing.Point(21, 150)
        Me.lblStatusSenha.Name = "lblStatusSenha"
        Me.lblStatusSenha.Size = New System.Drawing.Size(56, 18)
        Me.lblStatusSenha.TabIndex = 84
        Me.lblStatusSenha.Text = "Status"
        Me.lblStatusSenha.Visible = False
        '
        'txtConfSenhaOp
        '
        Me.txtConfSenhaOp.BackColor = System.Drawing.Color.Silver
        Me.txtConfSenhaOp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtConfSenhaOp.Location = New System.Drawing.Point(183, 123)
        Me.txtConfSenhaOp.Name = "txtConfSenhaOp"
        Me.txtConfSenhaOp.Size = New System.Drawing.Size(127, 13)
        Me.txtConfSenhaOp.TabIndex = 5
        Me.txtConfSenhaOp.UseSystemPasswordChar = True
        '
        'txtSenhaOp
        '
        Me.txtSenhaOp.BackColor = System.Drawing.Color.Silver
        Me.txtSenhaOp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSenhaOp.Location = New System.Drawing.Point(183, 97)
        Me.txtSenhaOp.Name = "txtSenhaOp"
        Me.txtSenhaOp.Size = New System.Drawing.Size(127, 13)
        Me.txtSenhaOp.TabIndex = 4
        Me.txtSenhaOp.UseSystemPasswordChar = True
        '
        'txtNomeOp
        '
        Me.txtNomeOp.BackColor = System.Drawing.Color.Silver
        Me.txtNomeOp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNomeOp.Location = New System.Drawing.Point(183, 71)
        Me.txtNomeOp.Name = "txtNomeOp"
        Me.txtNomeOp.Size = New System.Drawing.Size(127, 13)
        Me.txtNomeOp.TabIndex = 3
        '
        'txtPesquisaOp
        '
        Me.txtPesquisaOp.BackColor = System.Drawing.Color.Silver
        Me.txtPesquisaOp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPesquisaOp.Location = New System.Drawing.Point(273, 312)
        Me.txtPesquisaOp.Name = "txtPesquisaOp"
        Me.txtPesquisaOp.Size = New System.Drawing.Size(230, 13)
        Me.txtPesquisaOp.TabIndex = 7
        '
        'dtgOperador
        '
        Me.dtgOperador.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dtgOperador.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgOperador.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dtgOperador.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgOperador.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgOperador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgOperador.Cursor = System.Windows.Forms.Cursors.Cross
        Me.dtgOperador.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtgOperador.Location = New System.Drawing.Point(38, 339)
        Me.dtgOperador.Name = "dtgOperador"
        Me.dtgOperador.Size = New System.Drawing.Size(573, 126)
        Me.dtgOperador.TabIndex = 87
        '
        'btnExcluiOp
        '
        Me.btnExcluiOp.BackColor = System.Drawing.Color.Transparent
        Me.btnExcluiOp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluiOp.Location = New System.Drawing.Point(453, 185)
        Me.btnExcluiOp.Name = "btnExcluiOp"
        Me.btnExcluiOp.Size = New System.Drawing.Size(51, 54)
        Me.btnExcluiOp.TabIndex = 94
        Me.btnExcluiOp.TabStop = False
        '
        'btnAlterOp
        '
        Me.btnAlterOp.BackColor = System.Drawing.Color.Transparent
        Me.btnAlterOp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAlterOp.Location = New System.Drawing.Point(348, 182)
        Me.btnAlterOp.Name = "btnAlterOp"
        Me.btnAlterOp.Size = New System.Drawing.Size(51, 54)
        Me.btnAlterOp.TabIndex = 93
        Me.btnAlterOp.TabStop = False
        '
        'btnCadastraOp
        '
        Me.btnCadastraOp.BackColor = System.Drawing.Color.Transparent
        Me.btnCadastraOp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCadastraOp.Location = New System.Drawing.Point(232, 182)
        Me.btnCadastraOp.Name = "btnCadastraOp"
        Me.btnCadastraOp.Size = New System.Drawing.Size(51, 54)
        Me.btnCadastraOp.TabIndex = 92
        Me.btnCadastraOp.TabStop = False
        '
        'btnNovoOp
        '
        Me.btnNovoOp.BackColor = System.Drawing.Color.Transparent
        Me.btnNovoOp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNovoOp.Location = New System.Drawing.Point(113, 181)
        Me.btnNovoOp.Name = "btnNovoOp"
        Me.btnNovoOp.Size = New System.Drawing.Size(51, 54)
        Me.btnNovoOp.TabIndex = 91
        Me.btnNovoOp.TabStop = False
        '
        'btnPesquisaOp
        '
        Me.btnPesquisaOp.BackColor = System.Drawing.Color.Transparent
        Me.btnPesquisaOp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPesquisaOp.Location = New System.Drawing.Point(518, 293)
        Me.btnPesquisaOp.Name = "btnPesquisaOp"
        Me.btnPesquisaOp.Size = New System.Drawing.Size(51, 40)
        Me.btnPesquisaOp.TabIndex = 95
        Me.btnPesquisaOp.TabStop = False
        '
        'cboPesquisaOp
        '
        Me.cboPesquisaOp.AutoCompleteCustomSource.AddRange(New String() {"Nível", "Nome"})
        Me.cboPesquisaOp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboPesquisaOp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cboPesquisaOp.BackColor = System.Drawing.Color.Silver
        Me.cboPesquisaOp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cboPesquisaOp.Location = New System.Drawing.Point(93, 313)
        Me.cboPesquisaOp.Name = "cboPesquisaOp"
        Me.cboPesquisaOp.Size = New System.Drawing.Size(133, 13)
        Me.cboPesquisaOp.TabIndex = 6
        '
        'cboNivelOp
        '
        Me.cboNivelOp.AutoCompleteCustomSource.AddRange(New String() {"Administrador", "Vendedor", "Caixa"})
        Me.cboNivelOp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboNivelOp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cboNivelOp.BackColor = System.Drawing.Color.Silver
        Me.cboNivelOp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cboNivelOp.Location = New System.Drawing.Point(182, 46)
        Me.cboNivelOp.Name = "cboNivelOp"
        Me.cboNivelOp.Size = New System.Drawing.Size(130, 13)
        Me.cboNivelOp.TabIndex = 2
        '
        'pbxExclui
        '
        Me.pbxExclui.AccessibleDescription = " "
        Me.pbxExclui.BackColor = System.Drawing.Color.Transparent
        Me.pbxExclui.Enabled = False
        Me.pbxExclui.Image = CType(resources.GetObject("pbxExclui.Image"), System.Drawing.Image)
        Me.pbxExclui.Location = New System.Drawing.Point(449, 229)
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
        Me.pbxAlter.Location = New System.Drawing.Point(337, 225)
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
        Me.pbxNovo.Location = New System.Drawing.Point(106, 224)
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
        Me.pbxCadastrar.Location = New System.Drawing.Point(212, 224)
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
        Me.pbxPesquisar.Location = New System.Drawing.Point(520, 303)
        Me.pbxPesquisar.Name = "pbxPesquisar"
        Me.pbxPesquisar.Size = New System.Drawing.Size(113, 44)
        Me.pbxPesquisar.TabIndex = 102
        Me.pbxPesquisar.TabStop = False
        Me.pbxPesquisar.Visible = False
        '
        'Operador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(642, 487)
        Me.Controls.Add(Me.pbxPesquisar)
        Me.Controls.Add(Me.pbxExclui)
        Me.Controls.Add(Me.pbxAlter)
        Me.Controls.Add(Me.pbxNovo)
        Me.Controls.Add(Me.pbxCadastrar)
        Me.Controls.Add(Me.cboNivelOp)
        Me.Controls.Add(Me.cboPesquisaOp)
        Me.Controls.Add(Me.btnPesquisaOp)
        Me.Controls.Add(Me.btnExcluiOp)
        Me.Controls.Add(Me.btnAlterOp)
        Me.Controls.Add(Me.btnCadastraOp)
        Me.Controls.Add(Me.btnNovoOp)
        Me.Controls.Add(Me.txtPesquisaOp)
        Me.Controls.Add(Me.dtgOperador)
        Me.Controls.Add(Me.cboFuncOp)
        Me.Controls.Add(Me.ID_OP)
        Me.Controls.Add(Me.lblStatusSenha)
        Me.Controls.Add(Me.txtNomeOp)
        Me.Controls.Add(Me.txtSenhaOp)
        Me.Controls.Add(Me.txtConfSenhaOp)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Operador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboFuncOp As System.Windows.Forms.ComboBox
    Friend WithEvents ID_OP As System.Windows.Forms.ComboBox
    Friend WithEvents lblStatusSenha As System.Windows.Forms.Label
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
    Friend WithEvents cboPesquisaOp As System.Windows.Forms.TextBox
    Friend WithEvents cboNivelOp As System.Windows.Forms.TextBox
    Friend WithEvents pbxExclui As System.Windows.Forms.PictureBox
    Friend WithEvents pbxAlter As System.Windows.Forms.PictureBox
    Friend WithEvents pbxNovo As System.Windows.Forms.PictureBox
    Friend WithEvents pbxCadastrar As System.Windows.Forms.PictureBox
    Friend WithEvents pbxPesquisar As System.Windows.Forms.PictureBox
End Class
