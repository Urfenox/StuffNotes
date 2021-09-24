<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEnableDisableStuffNotes = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ToolTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(6, 24)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(337, 381)
        Me.ListBox1.TabIndex = 0
        Me.ToolTips.SetToolTip(Me.ListBox1, "Lista con todos los archivo/carpeta que tienen una nota asociada." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Doble clic en " &
        "el item para abrir la nota.")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(349, 437)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cosas con notas"
        '
        'Label1
        '
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Location = New System.Drawing.Point(6, 408)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(337, 26)
        Me.Label1.TabIndex = 1
        Me.ToolTips.SetToolTip(Me.Label1, "Muestra la ruta del archivo/carpeta que tiene la ruta asociada." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Doble clic para " &
        "abrir el archivo/carpeta.")
        '
        'btnEnableDisableStuffNotes
        '
        Me.btnEnableDisableStuffNotes.Location = New System.Drawing.Point(60, 55)
        Me.btnEnableDisableStuffNotes.Name = "btnEnableDisableStuffNotes"
        Me.btnEnableDisableStuffNotes.Size = New System.Drawing.Size(137, 38)
        Me.btnEnableDisableStuffNotes.TabIndex = 2
        Me.btnEnableDisableStuffNotes.Text = "Habilitar StuffNotes"
        Me.ToolTips.SetToolTip(Me.btnEnableDisableStuffNotes, "Habilitar: Se activara la opcion 'Stuff Notes' en el menu contextual de Windows a" &
        "l hacer clic derecho en una carpeta o archivo." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Deshabilitar: Se eliminara dicha" &
        " opcion del menu contextual de Windows.")
        Me.btnEnableDisableStuffNotes.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnEnableDisableStuffNotes)
        Me.GroupBox2.Location = New System.Drawing.Point(367, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(257, 148)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opciones"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 461)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stuff Notes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnEnableDisableStuffNotes As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolTips As ToolTip
End Class
