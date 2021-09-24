<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nota
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Nota))
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.btnSaveNote = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarcomoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeshacerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RehacerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CortarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PegarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SeleccionartodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonalizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HoraYFechaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NoHelpLmaoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 27)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(775, 389)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'btnSaveNote
        '
        Me.btnSaveNote.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSaveNote.Location = New System.Drawing.Point(330, 422)
        Me.btnSaveNote.Name = "btnSaveNote"
        Me.btnSaveNote.Size = New System.Drawing.Size(138, 27)
        Me.btnSaveNote.TabIndex = 1
        Me.btnSaveNote.Text = "Guardar Nota"
        Me.btnSaveNote.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.EditarToolStripMenuItem, Me.HerramientasToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(799, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.toolStripSeparator, Me.GuardarToolStripMenuItem, Me.GuardarcomoToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.toolStripSeparator2, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "&Archivo"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Image = CType(resources.GetObject("NuevoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NuevoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.NuevoToolStripMenuItem.Text = "&Nuevo"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(210, 6)
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Image = CType(resources.GetObject("GuardarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GuardarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.GuardarToolStripMenuItem.Text = "&Guardar"
        '
        'GuardarcomoToolStripMenuItem
        '
        Me.GuardarcomoToolStripMenuItem.Name = "GuardarcomoToolStripMenuItem"
        Me.GuardarcomoToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.GuardarcomoToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.GuardarcomoToolStripMenuItem.Text = "G&uardar como"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(210, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeshacerToolStripMenuItem, Me.RehacerToolStripMenuItem, Me.toolStripSeparator3, Me.CortarToolStripMenuItem, Me.CopiarToolStripMenuItem, Me.PegarToolStripMenuItem, Me.toolStripSeparator4, Me.SeleccionartodoToolStripMenuItem})
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.EditarToolStripMenuItem.Text = "&Editar"
        Me.EditarToolStripMenuItem.Visible = False
        '
        'DeshacerToolStripMenuItem
        '
        Me.DeshacerToolStripMenuItem.Name = "DeshacerToolStripMenuItem"
        Me.DeshacerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.DeshacerToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.DeshacerToolStripMenuItem.Text = "&Deshacer"
        '
        'RehacerToolStripMenuItem
        '
        Me.RehacerToolStripMenuItem.Name = "RehacerToolStripMenuItem"
        Me.RehacerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.RehacerToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.RehacerToolStripMenuItem.Text = "&Rehacer"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(201, 6)
        '
        'CortarToolStripMenuItem
        '
        Me.CortarToolStripMenuItem.Image = CType(resources.GetObject("CortarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CortarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CortarToolStripMenuItem.Name = "CortarToolStripMenuItem"
        Me.CortarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CortarToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.CortarToolStripMenuItem.Text = "Cor&tar"
        '
        'CopiarToolStripMenuItem
        '
        Me.CopiarToolStripMenuItem.Image = CType(resources.GetObject("CopiarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopiarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        Me.CopiarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopiarToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.CopiarToolStripMenuItem.Text = "&Copiar"
        '
        'PegarToolStripMenuItem
        '
        Me.PegarToolStripMenuItem.Image = CType(resources.GetObject("PegarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PegarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PegarToolStripMenuItem.Name = "PegarToolStripMenuItem"
        Me.PegarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PegarToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.PegarToolStripMenuItem.Text = "&Pegar"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(201, 6)
        '
        'SeleccionartodoToolStripMenuItem
        '
        Me.SeleccionartodoToolStripMenuItem.Name = "SeleccionartodoToolStripMenuItem"
        Me.SeleccionartodoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.SeleccionartodoToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.SeleccionartodoToolStripMenuItem.Text = "&Seleccionar todo"
        '
        'HerramientasToolStripMenuItem
        '
        Me.HerramientasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PersonalizarToolStripMenuItem, Me.HoraYFechaToolStripMenuItem})
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.HerramientasToolStripMenuItem.Text = "F&ormato"
        '
        'PersonalizarToolStripMenuItem
        '
        Me.PersonalizarToolStripMenuItem.Name = "PersonalizarToolStripMenuItem"
        Me.PersonalizarToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.PersonalizarToolStripMenuItem.Text = "&Fuente"
        '
        'HoraYFechaToolStripMenuItem
        '
        Me.HoraYFechaToolStripMenuItem.Name = "HoraYFechaToolStripMenuItem"
        Me.HoraYFechaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.HoraYFechaToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.HoraYFechaToolStripMenuItem.Text = "Hora y fecha"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NoHelpLmaoToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ay&uda"
        '
        'NoHelpLmaoToolStripMenuItem
        '
        Me.NoHelpLmaoToolStripMenuItem.Name = "NoHelpLmaoToolStripMenuItem"
        Me.NoHelpLmaoToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.NoHelpLmaoToolStripMenuItem.Text = "no help lmao"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'Nota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 461)
        Me.Controls.Add(Me.btnSaveNote)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Nota"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrador de Nota"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents btnSaveNote As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarcomoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeshacerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RehacerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As ToolStripSeparator
    Friend WithEvents CortarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PegarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator4 As ToolStripSeparator
    Friend WithEvents SeleccionartodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HerramientasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PersonalizarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NoHelpLmaoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HoraYFechaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
End Class
