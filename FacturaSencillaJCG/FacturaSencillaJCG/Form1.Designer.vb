<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.CBiva = New System.Windows.Forms.ComboBox()
        Me.CBDesc = New System.Windows.Forms.ComboBox()
        Me.ChekImp = New System.Windows.Forms.CheckBox()
        Me.ChekDesc = New System.Windows.Forms.CheckBox()
        Me.LblCantidad = New System.Windows.Forms.Label()
        Me.LblPrecioU = New System.Windows.Forms.Label()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblDR = New System.Windows.Forms.Label()
        Me.TxtPU = New System.Windows.Forms.TextBox()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.LblSubT = New System.Windows.Forms.Label()
        Me.LblDesc = New System.Windows.Forms.Label()
        Me.LblIVA = New System.Windows.Forms.Label()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.TxtSubtotal = New System.Windows.Forms.TextBox()
        Me.TxtDesc = New System.Windows.Forms.TextBox()
        Me.TxtImp = New System.Windows.Forms.TextBox()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.GBDetalleF = New System.Windows.Forms.GroupBox()
        Me.GBDetalleF.SuspendLayout()
        Me.SuspendLayout()
        '
        'CBiva
        '
        Me.CBiva.FormattingEnabled = True
        Me.CBiva.Location = New System.Drawing.Point(56, 336)
        Me.CBiva.Name = "CBiva"
        Me.CBiva.Size = New System.Drawing.Size(218, 21)
        Me.CBiva.TabIndex = 7
        '
        'CBDesc
        '
        Me.CBDesc.FormattingEnabled = True
        Me.CBDesc.Location = New System.Drawing.Point(56, 265)
        Me.CBDesc.Name = "CBDesc"
        Me.CBDesc.Size = New System.Drawing.Size(218, 21)
        Me.CBDesc.TabIndex = 6
        '
        'ChekImp
        '
        Me.ChekImp.AutoSize = True
        Me.ChekImp.BackColor = System.Drawing.Color.Transparent
        Me.ChekImp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChekImp.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ChekImp.Location = New System.Drawing.Point(56, 310)
        Me.ChekImp.Name = "ChekImp"
        Me.ChekImp.Size = New System.Drawing.Size(218, 20)
        Me.ChekImp.TabIndex = 5
        Me.ChekImp.Text = "Aplicar Impuesto 15% - 17%"
        Me.ChekImp.UseVisualStyleBackColor = False
        '
        'ChekDesc
        '
        Me.ChekDesc.AutoSize = True
        Me.ChekDesc.BackColor = System.Drawing.Color.Transparent
        Me.ChekDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChekDesc.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ChekDesc.Location = New System.Drawing.Point(56, 239)
        Me.ChekDesc.Name = "ChekDesc"
        Me.ChekDesc.Size = New System.Drawing.Size(152, 20)
        Me.ChekDesc.TabIndex = 4
        Me.ChekDesc.Text = "Aplicar descuento"
        Me.ChekDesc.UseVisualStyleBackColor = False
        '
        'LblCantidad
        '
        Me.LblCantidad.AutoSize = True
        Me.LblCantidad.BackColor = System.Drawing.Color.Transparent
        Me.LblCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCantidad.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblCantidad.Location = New System.Drawing.Point(91, 191)
        Me.LblCantidad.Name = "LblCantidad"
        Me.LblCantidad.Size = New System.Drawing.Size(81, 20)
        Me.LblCantidad.TabIndex = 1
        Me.LblCantidad.Text = "Cantidad"
        '
        'LblPrecioU
        '
        Me.LblPrecioU.AutoSize = True
        Me.LblPrecioU.BackColor = System.Drawing.Color.Transparent
        Me.LblPrecioU.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrecioU.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblPrecioU.Location = New System.Drawing.Point(45, 148)
        Me.LblPrecioU.Name = "LblPrecioU"
        Me.LblPrecioU.Size = New System.Drawing.Size(127, 20)
        Me.LblPrecioU.TabIndex = 0
        Me.LblPrecioU.Text = "Precio Unitario"
        '
        'BtnCalcular
        '
        Me.BtnCalcular.BackColor = System.Drawing.Color.Green
        Me.BtnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalcular.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnCalcular.Location = New System.Drawing.Point(383, 151)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.BtnCalcular.TabIndex = 8
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BtnNuevo.Enabled = False
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnNuevo.Location = New System.Drawing.Point(383, 214)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.BtnNuevo.TabIndex = 9
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.Red
        Me.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.Color.White
        Me.BtnSalir.Location = New System.Drawing.Point(383, 280)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 10
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(294, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(265, 39)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "&Factura Simple"
        '
        'LblDR
        '
        Me.LblDR.AutoSize = True
        Me.LblDR.BackColor = System.Drawing.Color.Transparent
        Me.LblDR.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDR.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblDR.Location = New System.Drawing.Point(84, 98)
        Me.LblDR.Name = "LblDR"
        Me.LblDR.Size = New System.Drawing.Size(176, 24)
        Me.LblDR.TabIndex = 12
        Me.LblDR.Text = "Datos Requeridos"
        '
        'TxtPU
        '
        Me.TxtPU.Location = New System.Drawing.Point(178, 148)
        Me.TxtPU.Name = "TxtPU"
        Me.TxtPU.Size = New System.Drawing.Size(100, 20)
        Me.TxtPU.TabIndex = 13
        Me.TxtPU.Text = "0"
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Location = New System.Drawing.Point(178, 191)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.TxtCantidad.TabIndex = 14
        Me.TxtCantidad.Text = "0"
        '
        'LblSubT
        '
        Me.LblSubT.AutoSize = True
        Me.LblSubT.Location = New System.Drawing.Point(32, 49)
        Me.LblSubT.Name = "LblSubT"
        Me.LblSubT.Size = New System.Drawing.Size(77, 20)
        Me.LblSubT.TabIndex = 0
        Me.LblSubT.Text = "Subtotal"
        '
        'LblDesc
        '
        Me.LblDesc.AutoSize = True
        Me.LblDesc.Location = New System.Drawing.Point(18, 107)
        Me.LblDesc.Name = "LblDesc"
        Me.LblDesc.Size = New System.Drawing.Size(96, 20)
        Me.LblDesc.TabIndex = 1
        Me.LblDesc.Text = "Descuento"
        '
        'LblIVA
        '
        Me.LblIVA.AutoSize = True
        Me.LblIVA.Location = New System.Drawing.Point(23, 164)
        Me.LblIVA.Name = "LblIVA"
        Me.LblIVA.Size = New System.Drawing.Size(84, 20)
        Me.LblIVA.TabIndex = 2
        Me.LblIVA.Text = "Impuesto"
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Location = New System.Drawing.Point(45, 224)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(49, 20)
        Me.LblTotal.TabIndex = 3
        Me.LblTotal.Text = "Total"
        '
        'TxtSubtotal
        '
        Me.TxtSubtotal.Enabled = False
        Me.TxtSubtotal.Location = New System.Drawing.Point(116, 46)
        Me.TxtSubtotal.Name = "TxtSubtotal"
        Me.TxtSubtotal.Size = New System.Drawing.Size(100, 26)
        Me.TxtSubtotal.TabIndex = 4
        '
        'TxtDesc
        '
        Me.TxtDesc.Enabled = False
        Me.TxtDesc.Location = New System.Drawing.Point(116, 104)
        Me.TxtDesc.Name = "TxtDesc"
        Me.TxtDesc.Size = New System.Drawing.Size(100, 26)
        Me.TxtDesc.TabIndex = 5
        '
        'TxtImp
        '
        Me.TxtImp.Enabled = False
        Me.TxtImp.Location = New System.Drawing.Point(116, 161)
        Me.TxtImp.Name = "TxtImp"
        Me.TxtImp.Size = New System.Drawing.Size(100, 26)
        Me.TxtImp.TabIndex = 6
        '
        'TxtTotal
        '
        Me.TxtTotal.Enabled = False
        Me.TxtTotal.Location = New System.Drawing.Point(116, 217)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(100, 26)
        Me.TxtTotal.TabIndex = 7
        '
        'GBDetalleF
        '
        Me.GBDetalleF.BackColor = System.Drawing.Color.Transparent
        Me.GBDetalleF.Controls.Add(Me.TxtTotal)
        Me.GBDetalleF.Controls.Add(Me.TxtImp)
        Me.GBDetalleF.Controls.Add(Me.TxtDesc)
        Me.GBDetalleF.Controls.Add(Me.TxtSubtotal)
        Me.GBDetalleF.Controls.Add(Me.LblTotal)
        Me.GBDetalleF.Controls.Add(Me.LblIVA)
        Me.GBDetalleF.Controls.Add(Me.LblDesc)
        Me.GBDetalleF.Controls.Add(Me.LblSubT)
        Me.GBDetalleF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBDetalleF.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GBDetalleF.Location = New System.Drawing.Point(552, 79)
        Me.GBDetalleF.Name = "GBDetalleF"
        Me.GBDetalleF.Size = New System.Drawing.Size(296, 289)
        Me.GBDetalleF.TabIndex = 8
        Me.GBDetalleF.TabStop = False
        Me.GBDetalleF.Text = "Detalles de Factura"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(893, 458)
        Me.Controls.Add(Me.TxtCantidad)
        Me.Controls.Add(Me.TxtPU)
        Me.Controls.Add(Me.LblDR)
        Me.Controls.Add(Me.CBiva)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CBDesc)
        Me.Controls.Add(Me.GBDetalleF)
        Me.Controls.Add(Me.ChekImp)
        Me.Controls.Add(Me.ChekDesc)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.LblCantidad)
        Me.Controls.Add(Me.LblPrecioU)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Factura"
        Me.GBDetalleF.ResumeLayout(False)
        Me.GBDetalleF.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CBiva As ComboBox
    Friend WithEvents CBDesc As ComboBox
    Friend WithEvents ChekImp As CheckBox
    Friend WithEvents ChekDesc As CheckBox
    Friend WithEvents LblCantidad As Label
    Friend WithEvents LblPrecioU As Label
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents LblDR As Label
    Friend WithEvents TxtPU As TextBox
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents LblSubT As Label
    Friend WithEvents LblDesc As Label
    Friend WithEvents LblIVA As Label
    Friend WithEvents LblTotal As Label
    Friend WithEvents TxtSubtotal As TextBox
    Friend WithEvents TxtDesc As TextBox
    Friend WithEvents TxtImp As TextBox
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents GBDetalleF As GroupBox
End Class
