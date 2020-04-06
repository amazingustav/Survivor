<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EstoqueHelp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EstoqueHelp))
        Me.txtNomeLivro = New System.Windows.Forms.TextBox()
        Me.mskData = New System.Windows.Forms.MaskedTextBox()
        Me.rdbAnual = New System.Windows.Forms.RadioButton()
        Me.rdbMensal = New System.Windows.Forms.RadioButton()
        Me.rdbDiario = New System.Windows.Forms.RadioButton()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.dtgEstoque = New System.Windows.Forms.DataGridView()
        Me.btnPesquisaLivro = New System.Windows.Forms.PictureBox()
        Me.btnPesquisaData = New System.Windows.Forms.PictureBox()
        Me.pbxPesquisar1 = New System.Windows.Forms.PictureBox()
        Me.cboMes = New System.Windows.Forms.ComboBox()
        Me.cboAno = New System.Windows.Forms.ComboBox()
        Me.btnHelp = New System.Windows.Forms.PictureBox()
        Me.btnEND = New System.Windows.Forms.PictureBox()
        Me.pbxpesquisar2 = New System.Windows.Forms.PictureBox()
        CType(Me.dtgEstoque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPesquisaLivro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPesquisaData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxPesquisar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEND, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxpesquisar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNomeLivro
        '
        Me.txtNomeLivro.BackColor = System.Drawing.Color.White
        Me.txtNomeLivro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNomeLivro.Location = New System.Drawing.Point(74, 162)
        Me.txtNomeLivro.Name = "txtNomeLivro"
        Me.txtNomeLivro.Size = New System.Drawing.Size(197, 13)
        Me.txtNomeLivro.TabIndex = 1
        '
        'mskData
        '
        Me.mskData.BackColor = System.Drawing.Color.White
        Me.mskData.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mskData.Location = New System.Drawing.Point(487, 140)
        Me.mskData.Mask = "00/00/0000"
        Me.mskData.Name = "mskData"
        Me.mskData.Size = New System.Drawing.Size(104, 13)
        Me.mskData.TabIndex = 3
        Me.mskData.ValidatingType = GetType(Date)
        '
        'rdbAnual
        '
        Me.rdbAnual.AutoSize = True
        Me.rdbAnual.Location = New System.Drawing.Point(361, 187)
        Me.rdbAnual.Name = "rdbAnual"
        Me.rdbAnual.Size = New System.Drawing.Size(14, 13)
        Me.rdbAnual.TabIndex = 6
        Me.rdbAnual.TabStop = True
        Me.rdbAnual.UseVisualStyleBackColor = True
        '
        'rdbMensal
        '
        Me.rdbMensal.AutoSize = True
        Me.rdbMensal.Location = New System.Drawing.Point(361, 163)
        Me.rdbMensal.Name = "rdbMensal"
        Me.rdbMensal.Size = New System.Drawing.Size(14, 13)
        Me.rdbMensal.TabIndex = 4
        Me.rdbMensal.TabStop = True
        Me.rdbMensal.UseVisualStyleBackColor = True
        '
        'rdbDiario
        '
        Me.rdbDiario.AutoSize = True
        Me.rdbDiario.Location = New System.Drawing.Point(361, 138)
        Me.rdbDiario.Name = "rdbDiario"
        Me.rdbDiario.Size = New System.Drawing.Size(14, 13)
        Me.rdbDiario.TabIndex = 2
        Me.rdbDiario.TabStop = True
        Me.rdbDiario.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblStatus.Location = New System.Drawing.Point(347, 49)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(46, 23)
        Me.lblStatus.TabIndex = 105
        Me.lblStatus.Text = "000"
        '
        'dtgEstoque
        '
        Me.dtgEstoque.AllowUserToAddRows = False
        Me.dtgEstoque.AllowUserToDeleteRows = False
        Me.dtgEstoque.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dtgEstoque.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgEstoque.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dtgEstoque.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgEstoque.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgEstoque.Cursor = System.Windows.Forms.Cursors.Default
        Me.dtgEstoque.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtgEstoque.Location = New System.Drawing.Point(29, 272)
        Me.dtgEstoque.Name = "dtgEstoque"
        Me.dtgEstoque.ReadOnly = True
        Me.dtgEstoque.Size = New System.Drawing.Size(575, 210)
        Me.dtgEstoque.TabIndex = 6
        '
        'btnPesquisaLivro
        '
        Me.btnPesquisaLivro.BackColor = System.Drawing.Color.Transparent
        Me.btnPesquisaLivro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPesquisaLivro.Location = New System.Drawing.Point(286, 139)
        Me.btnPesquisaLivro.Name = "btnPesquisaLivro"
        Me.btnPesquisaLivro.Size = New System.Drawing.Size(45, 50)
        Me.btnPesquisaLivro.TabIndex = 121
        Me.btnPesquisaLivro.TabStop = False
        '
        'btnPesquisaData
        '
        Me.btnPesquisaData.BackColor = System.Drawing.Color.Transparent
        Me.btnPesquisaData.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPesquisaData.Location = New System.Drawing.Point(601, 138)
        Me.btnPesquisaData.Name = "btnPesquisaData"
        Me.btnPesquisaData.Size = New System.Drawing.Size(42, 50)
        Me.btnPesquisaData.TabIndex = 122
        Me.btnPesquisaData.TabStop = False
        '
        'pbxPesquisar1
        '
        Me.pbxPesquisar1.AccessibleDescription = " "
        Me.pbxPesquisar1.BackColor = System.Drawing.Color.Transparent
        Me.pbxPesquisar1.Enabled = False
        Me.pbxPesquisar1.Image = CType(resources.GetObject("pbxPesquisar1.Image"), System.Drawing.Image)
        Me.pbxPesquisar1.Location = New System.Drawing.Point(260, 100)
        Me.pbxPesquisar1.Name = "pbxPesquisar1"
        Me.pbxPesquisar1.Size = New System.Drawing.Size(113, 44)
        Me.pbxPesquisar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxPesquisar1.TabIndex = 128
        Me.pbxPesquisar1.TabStop = False
        Me.pbxPesquisar1.Visible = False
        '
        'cboMes
        '
        Me.cboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMes.FormattingEnabled = True
        Me.cboMes.Items.AddRange(New Object() {"Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"})
        Me.cboMes.Location = New System.Drawing.Point(486, 159)
        Me.cboMes.Name = "cboMes"
        Me.cboMes.Size = New System.Drawing.Size(112, 21)
        Me.cboMes.TabIndex = 5
        '
        'cboAno
        '
        Me.cboAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAno.FormattingEnabled = True
        Me.cboAno.Items.AddRange(New Object() {"2014", "2013", "2012", "2011", "2010", "2009", "2008", "2007", "2006", "2005", "2004", "2003", "2002", "2001", "2000", "1999", "1998", "1997", "1996", "1995", "1994", "1993", "1992", "1991", "1990"})
        Me.cboAno.Location = New System.Drawing.Point(486, 184)
        Me.cboAno.MaxDropDownItems = 5
        Me.cboAno.Name = "cboAno"
        Me.cboAno.Size = New System.Drawing.Size(112, 21)
        Me.cboAno.TabIndex = 7
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.Transparent
        Me.btnHelp.Cursor = System.Windows.Forms.Cursors.Help
        Me.btnHelp.Location = New System.Drawing.Point(585, 13)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(24, 20)
        Me.btnHelp.TabIndex = 132
        Me.btnHelp.TabStop = False
        '
        'btnEND
        '
        Me.btnEND.BackColor = System.Drawing.Color.Transparent
        Me.btnEND.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEND.Location = New System.Drawing.Point(612, 13)
        Me.btnEND.Name = "btnEND"
        Me.btnEND.Size = New System.Drawing.Size(24, 20)
        Me.btnEND.TabIndex = 131
        Me.btnEND.TabStop = False
        '
        'pbxpesquisar2
        '
        Me.pbxpesquisar2.AccessibleDescription = " "
        Me.pbxpesquisar2.BackColor = System.Drawing.Color.Transparent
        Me.pbxpesquisar2.Enabled = False
        Me.pbxpesquisar2.Image = CType(resources.GetObject("pbxpesquisar2.Image"), System.Drawing.Image)
        Me.pbxpesquisar2.Location = New System.Drawing.Point(551, 102)
        Me.pbxpesquisar2.Name = "pbxpesquisar2"
        Me.pbxpesquisar2.Size = New System.Drawing.Size(113, 44)
        Me.pbxpesquisar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxpesquisar2.TabIndex = 133
        Me.pbxpesquisar2.TabStop = False
        Me.pbxpesquisar2.Visible = False
        '
        'EstoqueHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(666, 503)
        Me.Controls.Add(Me.pbxpesquisar2)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnEND)
        Me.Controls.Add(Me.cboAno)
        Me.Controls.Add(Me.cboMes)
        Me.Controls.Add(Me.pbxPesquisar1)
        Me.Controls.Add(Me.btnPesquisaData)
        Me.Controls.Add(Me.btnPesquisaLivro)
        Me.Controls.Add(Me.dtgEstoque)
        Me.Controls.Add(Me.txtNomeLivro)
        Me.Controls.Add(Me.mskData)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.rdbAnual)
        Me.Controls.Add(Me.rdbMensal)
        Me.Controls.Add(Me.rdbDiario)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EstoqueHelp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estoque"
        Me.TopMost = True
        CType(Me.dtgEstoque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPesquisaLivro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPesquisaData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxPesquisar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnHelp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEND, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxpesquisar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNomeLivro As System.Windows.Forms.TextBox
    Friend WithEvents mskData As System.Windows.Forms.MaskedTextBox
    Friend WithEvents rdbAnual As System.Windows.Forms.RadioButton
    Friend WithEvents rdbMensal As System.Windows.Forms.RadioButton
    Friend WithEvents rdbDiario As System.Windows.Forms.RadioButton
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents dtgEstoque As System.Windows.Forms.DataGridView
    Friend WithEvents btnPesquisaLivro As System.Windows.Forms.PictureBox
    Friend WithEvents btnPesquisaData As System.Windows.Forms.PictureBox
    Friend WithEvents pbxPesquisar1 As System.Windows.Forms.PictureBox
    Friend WithEvents cboMes As System.Windows.Forms.ComboBox
    Friend WithEvents cboAno As System.Windows.Forms.ComboBox
    Friend WithEvents btnHelp As System.Windows.Forms.PictureBox
    Friend WithEvents btnEND As System.Windows.Forms.PictureBox
    Friend WithEvents pbxpesquisar2 As System.Windows.Forms.PictureBox
End Class
