<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PesquisarLivros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PesquisarLivros))
        Me.dtgLivro = New System.Windows.Forms.DataGridView()
        Me.txtPesquisar = New System.Windows.Forms.TextBox()
        Me.btnPesquisar = New System.Windows.Forms.PictureBox()
        Me.pbxPesquisar = New System.Windows.Forms.PictureBox()
        Me.cboPesquisa = New System.Windows.Forms.ComboBox()
        Me.btnHelp = New System.Windows.Forms.PictureBox()
        Me.btnEND = New System.Windows.Forms.PictureBox()
        CType(Me.dtgLivro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPesquisar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxPesquisar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEND, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgLivro
        '
        Me.dtgLivro.AllowUserToAddRows = False
        Me.dtgLivro.AllowUserToDeleteRows = False
        Me.dtgLivro.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dtgLivro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgLivro.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dtgLivro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgLivro.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgLivro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgLivro.Cursor = System.Windows.Forms.Cursors.Default
        Me.dtgLivro.GridColor = System.Drawing.SystemColors.Desktop
        Me.dtgLivro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtgLivro.Location = New System.Drawing.Point(32, 101)
        Me.dtgLivro.Name = "dtgLivro"
        Me.dtgLivro.ReadOnly = True
        Me.dtgLivro.Size = New System.Drawing.Size(594, 139)
        Me.dtgLivro.TabIndex = 12
        '
        'txtPesquisar
        '
        Me.txtPesquisar.BackColor = System.Drawing.Color.White
        Me.txtPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPesquisar.Location = New System.Drawing.Point(314, 72)
        Me.txtPesquisar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPesquisar.Name = "txtPesquisar"
        Me.txtPesquisar.Size = New System.Drawing.Size(206, 13)
        Me.txtPesquisar.TabIndex = 2
        '
        'btnPesquisar
        '
        Me.btnPesquisar.BackColor = System.Drawing.Color.Transparent
        Me.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPesquisar.Location = New System.Drawing.Point(535, 58)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(47, 37)
        Me.btnPesquisar.TabIndex = 92
        Me.btnPesquisar.TabStop = False
        '
        'pbxPesquisar
        '
        Me.pbxPesquisar.AccessibleDescription = " "
        Me.pbxPesquisar.BackColor = System.Drawing.Color.Transparent
        Me.pbxPesquisar.Enabled = False
        Me.pbxPesquisar.Image = CType(resources.GetObject("pbxPesquisar.Image"), System.Drawing.Image)
        Me.pbxPesquisar.Location = New System.Drawing.Point(507, 23)
        Me.pbxPesquisar.Name = "pbxPesquisar"
        Me.pbxPesquisar.Size = New System.Drawing.Size(99, 44)
        Me.pbxPesquisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxPesquisar.TabIndex = 97
        Me.pbxPesquisar.TabStop = False
        Me.pbxPesquisar.Visible = False
        '
        'cboPesquisa
        '
        Me.cboPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPesquisa.FormattingEnabled = True
        Me.cboPesquisa.Items.AddRange(New Object() {"ID", "Título", "ISBN", "Autor", "Editora", "Gênero"})
        Me.cboPesquisa.Location = New System.Drawing.Point(105, 64)
        Me.cboPesquisa.Name = "cboPesquisa"
        Me.cboPesquisa.Size = New System.Drawing.Size(174, 21)
        Me.cboPesquisa.TabIndex = 117
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.Transparent
        Me.btnHelp.Cursor = System.Windows.Forms.Cursors.Help
        Me.btnHelp.Location = New System.Drawing.Point(586, 11)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(24, 20)
        Me.btnHelp.TabIndex = 138
        Me.btnHelp.TabStop = False
        '
        'btnEND
        '
        Me.btnEND.BackColor = System.Drawing.Color.Transparent
        Me.btnEND.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEND.Location = New System.Drawing.Point(611, 12)
        Me.btnEND.Name = "btnEND"
        Me.btnEND.Size = New System.Drawing.Size(24, 20)
        Me.btnEND.TabIndex = 137
        Me.btnEND.TabStop = False
        '
        'PesquisarLivros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(666, 508)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnEND)
        Me.Controls.Add(Me.cboPesquisa)
        Me.Controls.Add(Me.pbxPesquisar)
        Me.Controls.Add(Me.btnPesquisar)
        Me.Controls.Add(Me.txtPesquisar)
        Me.Controls.Add(Me.dtgLivro)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PesquisarLivros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pesquisa de Livros"
        Me.TopMost = True
        CType(Me.dtgLivro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPesquisar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxPesquisar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnHelp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEND, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtgLivro As System.Windows.Forms.DataGridView
    Friend WithEvents txtPesquisar As System.Windows.Forms.TextBox
    Friend WithEvents btnPesquisar As System.Windows.Forms.PictureBox
    Friend WithEvents pbxPesquisar As System.Windows.Forms.PictureBox
    Friend WithEvents cboPesquisa As System.Windows.Forms.ComboBox
    Friend WithEvents btnHelp As System.Windows.Forms.PictureBox
    Friend WithEvents btnEND As System.Windows.Forms.PictureBox
End Class
