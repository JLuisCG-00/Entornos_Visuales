<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formula_General
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formula_General))
        Me.Salir = New System.Windows.Forms.Button()
        Me.Menu_Prin = New System.Windows.Forms.Button()
        Me.TextBox_A = New System.Windows.Forms.TextBox()
        Me.TextBox_B = New System.Windows.Forms.TextBox()
        Me.TextBox_C = New System.Windows.Forms.TextBox()
        Me.TextBox_X1 = New System.Windows.Forms.TextBox()
        Me.TextBox_X2 = New System.Windows.Forms.TextBox()
        Me.errorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ButtonCalcular = New System.Windows.Forms.Button()
        Me.ButtonLimpiar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.errorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Salir
        '
        Me.Salir.BackColor = System.Drawing.Color.Red
        Me.Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salir.Location = New System.Drawing.Point(85, 191)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(75, 23)
        Me.Salir.TabIndex = 0
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = False
        '
        'Menu_Prin
        '
        Me.Menu_Prin.BackColor = System.Drawing.SystemColors.Highlight
        Me.Menu_Prin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Menu_Prin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu_Prin.Location = New System.Drawing.Point(64, 155)
        Me.Menu_Prin.Name = "Menu_Prin"
        Me.Menu_Prin.Size = New System.Drawing.Size(123, 23)
        Me.Menu_Prin.TabIndex = 1
        Me.Menu_Prin.Text = "Menu Principal"
        Me.Menu_Prin.UseVisualStyleBackColor = False
        '
        'TextBox_A
        '
        Me.TextBox_A.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_A.Location = New System.Drawing.Point(309, 12)
        Me.TextBox_A.Name = "TextBox_A"
        Me.TextBox_A.Size = New System.Drawing.Size(72, 22)
        Me.TextBox_A.TabIndex = 2
        '
        'TextBox_B
        '
        Me.TextBox_B.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_B.Location = New System.Drawing.Point(309, 43)
        Me.TextBox_B.Name = "TextBox_B"
        Me.TextBox_B.Size = New System.Drawing.Size(72, 22)
        Me.TextBox_B.TabIndex = 3
        '
        'TextBox_C
        '
        Me.TextBox_C.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_C.Location = New System.Drawing.Point(309, 74)
        Me.TextBox_C.Name = "TextBox_C"
        Me.TextBox_C.Size = New System.Drawing.Size(72, 22)
        Me.TextBox_C.TabIndex = 4
        '
        'TextBox_X1
        '
        Me.TextBox_X1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_X1.Location = New System.Drawing.Point(327, 161)
        Me.TextBox_X1.Name = "TextBox_X1"
        Me.TextBox_X1.Size = New System.Drawing.Size(83, 22)
        Me.TextBox_X1.TabIndex = 5
        '
        'TextBox_X2
        '
        Me.TextBox_X2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_X2.Location = New System.Drawing.Point(327, 189)
        Me.TextBox_X2.Name = "TextBox_X2"
        Me.TextBox_X2.Size = New System.Drawing.Size(83, 22)
        Me.TextBox_X2.TabIndex = 6
        '
        'errorValidacion
        '
        Me.errorValidacion.ContainerControl = Me
        '
        'ButtonCalcular
        '
        Me.ButtonCalcular.Location = New System.Drawing.Point(309, 117)
        Me.ButtonCalcular.Name = "ButtonCalcular"
        Me.ButtonCalcular.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCalcular.TabIndex = 7
        Me.ButtonCalcular.Text = "Calcular"
        Me.ButtonCalcular.UseVisualStyleBackColor = True
        '
        'ButtonLimpiar
        '
        Me.ButtonLimpiar.Location = New System.Drawing.Point(392, 43)
        Me.ButtonLimpiar.Name = "ButtonLimpiar"
        Me.ButtonLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonLimpiar.TabIndex = 8
        Me.ButtonLimpiar.Text = "Limpiar"
        Me.ButtonLimpiar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(233, 93)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Perpetua", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(255, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 31)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "a ="
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Perpetua", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(255, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 31)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "c ="
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Perpetua", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(255, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 31)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "b ="
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Perpetua", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(268, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 31)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "x1 ="
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Perpetua", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(268, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 31)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "x2 ="
        '
        'Formula_General
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(479, 235)
        Me.Controls.Add(Me.TextBox_X2)
        Me.Controls.Add(Me.TextBox_X1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonLimpiar)
        Me.Controls.Add(Me.ButtonCalcular)
        Me.Controls.Add(Me.TextBox_C)
        Me.Controls.Add(Me.TextBox_B)
        Me.Controls.Add(Me.TextBox_A)
        Me.Controls.Add(Me.Menu_Prin)
        Me.Controls.Add(Me.Salir)
        Me.Name = "Formula_General"
        Me.Text = "Formula General"
        CType(Me.errorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Salir As Button
    Friend WithEvents Menu_Prin As Button
    Friend WithEvents TextBox_A As TextBox
    Friend WithEvents TextBox_B As TextBox
    Friend WithEvents TextBox_C As TextBox
    Friend WithEvents TextBox_X1 As TextBox
    Friend WithEvents TextBox_X2 As TextBox
    Friend WithEvents errorValidacion As ErrorProvider
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents ButtonCalcular As Button
    Friend WithEvents ButtonLimpiar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
End Class
