<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ingreso
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ingreso))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.TxtCargo2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtUActivo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CambiarUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TxtTipo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CbmDesc = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CbmImp = New System.Windows.Forms.ComboBox()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.TxtImp = New System.Windows.Forms.TextBox()
        Me.TxtDesc = New System.Windows.Forms.TextBox()
        Me.TxtSubtotal = New System.Windows.Forms.TextBox()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.LblIVA = New System.Windows.Forms.Label()
        Me.LblDesc = New System.Windows.Forms.Label()
        Me.LblSubT = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.AgregarProductosToolStripMenuItem, Me.InformacionToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(806, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CambiarUsuarioToolStripMenuItem})
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.InicioToolStripMenuItem.Text = "Cambiar usuario"
        '
        'AgregarProductosToolStripMenuItem
        '
        Me.AgregarProductosToolStripMenuItem.Enabled = False
        Me.AgregarProductosToolStripMenuItem.Name = "AgregarProductosToolStripMenuItem"
        Me.AgregarProductosToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.AgregarProductosToolStripMenuItem.Text = "Agregar | Vender"
        '
        'InformacionToolStripMenuItem
        '
        Me.InformacionToolStripMenuItem.Name = "InformacionToolStripMenuItem"
        Me.InformacionToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.InformacionToolStripMenuItem.Text = "Informacion"
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.Red
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.Color.White
        Me.BtnSalir.Location = New System.Drawing.Point(719, 508)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 12
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'TxtCargo2
        '
        Me.TxtCargo2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.TxtCargo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCargo2.Cursor = System.Windows.Forms.Cursors.No
        Me.TxtCargo2.Enabled = False
        Me.TxtCargo2.Location = New System.Drawing.Point(366, 511)
        Me.TxtCargo2.Name = "TxtCargo2"
        Me.TxtCargo2.Size = New System.Drawing.Size(139, 20)
        Me.TxtCargo2.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(301, 510)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 18)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Cargo:"
        '
        'TxtUActivo
        '
        Me.TxtUActivo.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.TxtUActivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtUActivo.Cursor = System.Windows.Forms.Cursors.No
        Me.TxtUActivo.Enabled = False
        Me.TxtUActivo.Location = New System.Drawing.Point(127, 511)
        Me.TxtUActivo.Name = "TxtUActivo"
        Me.TxtUActivo.Size = New System.Drawing.Size(142, 20)
        Me.TxtUActivo.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(-1, 510)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 18)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Usuario activo:"
        '
        'CambiarUsuarioToolStripMenuItem
        '
        Me.CambiarUsuarioToolStripMenuItem.Name = "CambiarUsuarioToolStripMenuItem"
        Me.CambiarUsuarioToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.CambiarUsuarioToolStripMenuItem.Text = "Cambiar Usuario"
        '
        'TxtTipo
        '
        Me.TxtTipo.Location = New System.Drawing.Point(148, 83)
        Me.TxtTipo.Name = "TxtTipo"
        Me.TxtTipo.Size = New System.Drawing.Size(190, 26)
        Me.TxtTipo.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 18)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Tipo de producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(85, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 18)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Precio"
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Location = New System.Drawing.Point(148, 127)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(104, 26)
        Me.TxtPrecio.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(49, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 18)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Id producto"
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(148, 44)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(104, 26)
        Me.TxtId.TabIndex = 25
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackColor = System.Drawing.Color.Lime
        Me.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.Location = New System.Drawing.Point(33, 354)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(81, 31)
        Me.BtnAgregar.TabIndex = 26
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.Yellow
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Location = New System.Drawing.Point(199, 354)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(150, 31)
        Me.BtnCancelar.TabIndex = 27
        Me.BtnCancelar.Text = "Cancelar y limpiar"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(68, 168)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 18)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Cantidad"
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Location = New System.Drawing.Point(148, 166)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(104, 26)
        Me.TxtCantidad.TabIndex = 29
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CbmImp)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.CbmDesc)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtCantidad)
        Me.GroupBox1.Controls.Add(Me.TxtTipo)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BtnCancelar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.BtnAgregar)
        Me.GroupBox1.Controls.Add(Me.TxtPrecio)
        Me.GroupBox1.Controls.Add(Me.TxtId)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(394, 413)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de producto"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.TxtTotal)
        Me.GroupBox2.Controls.Add(Me.TxtImp)
        Me.GroupBox2.Controls.Add(Me.TxtDesc)
        Me.GroupBox2.Controls.Add(Me.TxtSubtotal)
        Me.GroupBox2.Controls.Add(Me.LblTotal)
        Me.GroupBox2.Controls.Add(Me.LblIVA)
        Me.GroupBox2.Controls.Add(Me.LblDesc)
        Me.GroupBox2.Controls.Add(Me.LblSubT)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(430, 59)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(356, 413)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle Factura"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(53, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 18)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Descuento"
        '
        'CbmDesc
        '
        Me.CbmDesc.FormattingEnabled = True
        Me.CbmDesc.Location = New System.Drawing.Point(148, 210)
        Me.CbmDesc.Name = "CbmDesc"
        Me.CbmDesc.Size = New System.Drawing.Size(121, 28)
        Me.CbmDesc.TabIndex = 36
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(53, 264)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 18)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Impuesto"
        '
        'CbmImp
        '
        Me.CbmImp.FormattingEnabled = True
        Me.CbmImp.Location = New System.Drawing.Point(148, 260)
        Me.CbmImp.Name = "CbmImp"
        Me.CbmImp.Size = New System.Drawing.Size(121, 28)
        Me.CbmImp.TabIndex = 38
        '
        'TxtTotal
        '
        Me.TxtTotal.Enabled = False
        Me.TxtTotal.Location = New System.Drawing.Point(181, 265)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(100, 26)
        Me.TxtTotal.TabIndex = 15
        '
        'TxtImp
        '
        Me.TxtImp.Enabled = False
        Me.TxtImp.Location = New System.Drawing.Point(181, 209)
        Me.TxtImp.Name = "TxtImp"
        Me.TxtImp.Size = New System.Drawing.Size(100, 26)
        Me.TxtImp.TabIndex = 14
        '
        'TxtDesc
        '
        Me.TxtDesc.Enabled = False
        Me.TxtDesc.Location = New System.Drawing.Point(181, 152)
        Me.TxtDesc.Name = "TxtDesc"
        Me.TxtDesc.Size = New System.Drawing.Size(100, 26)
        Me.TxtDesc.TabIndex = 13
        '
        'TxtSubtotal
        '
        Me.TxtSubtotal.Enabled = False
        Me.TxtSubtotal.Location = New System.Drawing.Point(181, 94)
        Me.TxtSubtotal.Name = "TxtSubtotal"
        Me.TxtSubtotal.Size = New System.Drawing.Size(100, 26)
        Me.TxtSubtotal.TabIndex = 12
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Location = New System.Drawing.Point(110, 272)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(44, 20)
        Me.LblTotal.TabIndex = 11
        Me.LblTotal.Text = "Total"
        '
        'LblIVA
        '
        Me.LblIVA.AutoSize = True
        Me.LblIVA.Location = New System.Drawing.Point(88, 212)
        Me.LblIVA.Name = "LblIVA"
        Me.LblIVA.Size = New System.Drawing.Size(76, 20)
        Me.LblIVA.TabIndex = 10
        Me.LblIVA.Text = "Impuesto"
        '
        'LblDesc
        '
        Me.LblDesc.AutoSize = True
        Me.LblDesc.Location = New System.Drawing.Point(83, 155)
        Me.LblDesc.Name = "LblDesc"
        Me.LblDesc.Size = New System.Drawing.Size(87, 20)
        Me.LblDesc.TabIndex = 9
        Me.LblDesc.Text = "Descuento"
        '
        'LblSubT
        '
        Me.LblSubT.AutoSize = True
        Me.LblSubT.Location = New System.Drawing.Point(97, 97)
        Me.LblSubT.Name = "LblSubT"
        Me.LblSubT.Size = New System.Drawing.Size(69, 20)
        Me.LblSubT.TabIndex = 8
        Me.LblSubT.Text = "Subtotal"
        '
        'Ingreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(806, 543)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtCargo2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtUActivo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Ingreso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnSalir As Button
    Friend WithEvents TxtCargo2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtUActivo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CambiarUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TxtTipo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtId As TextBox
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CbmImp As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents CbmDesc As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents TxtImp As TextBox
    Friend WithEvents TxtDesc As TextBox
    Friend WithEvents TxtSubtotal As TextBox
    Friend WithEvents LblTotal As Label
    Friend WithEvents LblIVA As Label
    Friend WithEvents LblDesc As Label
    Friend WithEvents LblSubT As Label
End Class
