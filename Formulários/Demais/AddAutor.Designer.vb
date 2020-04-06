<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddAutor
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: O procedimento a seguir é exigido pelo Windows Form Designer
    'Ele pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddAutor))
        Me.txtAddAutor = New System.Windows.Forms.TextBox()
        Me.btnEND = New System.Windows.Forms.PictureBox()
        Me.btnAddAutor = New System.Windows.Forms.PictureBox()
        CType(Me.btnEND, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAddAutor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtAddAutor
        '
        Me.txtAddAutor.BackColor = System.Drawing.Color.White
        Me.txtAddAutor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAddAutor.ForeColor = System.Drawing.Color.Black
        Me.txtAddAutor.Location = New System.Drawing.Point(127, 67)
        Me.txtAddAutor.Name = "txtAddAutor"
        Me.txtAddAutor.Size = New System.Drawing.Size(107, 13)
        Me.txtAddAutor.TabIndex = 7
        '
        'btnEND
        '
        Me.btnEND.BackColor = System.Drawing.Color.Transparent
        Me.btnEND.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEND.Location = New System.Drawing.Point(204, 8)
        Me.btnEND.Name = "btnEND"
        Me.btnEND.Size = New System.Drawing.Size(24, 20)
        Me.btnEND.TabIndex = 136
        Me.btnEND.TabStop = False
        '
        'btnAddAutor
        '
        Me.btnAddAutor.BackColor = System.Drawing.Color.Transparent
        Me.btnAddAutor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddAutor.Location = New System.Drawing.Point(71, 134)
        Me.btnAddAutor.Name = "btnAddAutor"
        Me.btnAddAutor.Size = New System.Drawing.Size(97, 21)
        Me.btnAddAutor.TabIndex = 137
        Me.btnAddAutor.TabStop = False
        '
        'AddAutor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(246, 197)
        Me.Controls.Add(Me.btnAddAutor)
        Me.Controls.Add(Me.btnEND)
        Me.Controls.Add(Me.txtAddAutor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddAutor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddAutor"
        Me.TopMost = True
        CType(Me.btnEND, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAddAutor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAddAutor As System.Windows.Forms.TextBox
    Friend WithEvents btnEND As System.Windows.Forms.PictureBox
    Friend WithEvents btnAddAutor As System.Windows.Forms.PictureBox
End Class
