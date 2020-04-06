<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sinopse
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sinopse))
        Me.txtSinopse = New System.Windows.Forms.TextBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.btnCadastrarSinopse = New System.Windows.Forms.PictureBox()
        Me.btnLimpar = New System.Windows.Forms.PictureBox()
        Me.btnCancelar = New System.Windows.Forms.PictureBox()
        Me.pbxCadastrar = New System.Windows.Forms.PictureBox()
        Me.pbxLimpar = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.btnCadastrarSinopse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnLimpar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxCadastrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLimpar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSinopse
        '
        Me.txtSinopse.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSinopse.BackColor = System.Drawing.Color.DarkGray
        Me.txtSinopse.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSinopse.Location = New System.Drawing.Point(42, 53)
        Me.txtSinopse.Multiline = True
        Me.txtSinopse.Name = "txtSinopse"
        Me.txtSinopse.Size = New System.Drawing.Size(554, 306)
        Me.txtSinopse.TabIndex = 0
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Sinopse - Survivor New Book"
        Me.NotifyIcon1.Visible = True
        '
        'btnCadastrarSinopse
        '
        Me.btnCadastrarSinopse.BackColor = System.Drawing.Color.Transparent
        Me.btnCadastrarSinopse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCadastrarSinopse.Location = New System.Drawing.Point(96, 400)
        Me.btnCadastrarSinopse.Name = "btnCadastrarSinopse"
        Me.btnCadastrarSinopse.Size = New System.Drawing.Size(65, 54)
        Me.btnCadastrarSinopse.TabIndex = 85
        Me.btnCadastrarSinopse.TabStop = False
        '
        'btnLimpar
        '
        Me.btnLimpar.BackColor = System.Drawing.Color.Transparent
        Me.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpar.Location = New System.Drawing.Point(299, 395)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(68, 66)
        Me.btnLimpar.TabIndex = 86
        Me.btnLimpar.TabStop = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Location = New System.Drawing.Point(475, 403)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(65, 54)
        Me.btnCancelar.TabIndex = 87
        Me.btnCancelar.TabStop = False
        '
        'pbxCadastrar
        '
        Me.pbxCadastrar.AccessibleDescription = " "
        Me.pbxCadastrar.BackColor = System.Drawing.Color.Transparent
        Me.pbxCadastrar.Enabled = False
        Me.pbxCadastrar.Image = CType(resources.GetObject("pbxCadastrar.Image"), System.Drawing.Image)
        Me.pbxCadastrar.Location = New System.Drawing.Point(75, 443)
        Me.pbxCadastrar.Name = "pbxCadastrar"
        Me.pbxCadastrar.Size = New System.Drawing.Size(86, 40)
        Me.pbxCadastrar.TabIndex = 102
        Me.pbxCadastrar.TabStop = False
        Me.pbxCadastrar.Visible = False
        '
        'pbxLimpar
        '
        Me.pbxLimpar.AccessibleDescription = " "
        Me.pbxLimpar.BackColor = System.Drawing.Color.Transparent
        Me.pbxLimpar.Enabled = False
        Me.pbxLimpar.Image = CType(resources.GetObject("pbxLimpar.Image"), System.Drawing.Image)
        Me.pbxLimpar.Location = New System.Drawing.Point(284, 443)
        Me.pbxLimpar.Name = "pbxLimpar"
        Me.pbxLimpar.Size = New System.Drawing.Size(69, 42)
        Me.pbxLimpar.TabIndex = 106
        Me.pbxLimpar.TabStop = False
        Me.pbxLimpar.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.AccessibleDescription = " "
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(453, 442)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(87, 42)
        Me.PictureBox1.TabIndex = 107
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'Sinopse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(652, 484)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pbxLimpar)
        Me.Controls.Add(Me.pbxCadastrar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.btnCadastrarSinopse)
        Me.Controls.Add(Me.txtSinopse)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Sinopse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sinopse"
        Me.TopMost = True
        CType(Me.btnCadastrarSinopse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnLimpar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxCadastrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxLimpar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSinopse As System.Windows.Forms.TextBox
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents btnCadastrarSinopse As System.Windows.Forms.PictureBox
    Friend WithEvents btnLimpar As System.Windows.Forms.PictureBox
    Friend WithEvents btnCancelar As System.Windows.Forms.PictureBox
    Friend WithEvents pbxCadastrar As System.Windows.Forms.PictureBox
    Friend WithEvents pbxLimpar As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
