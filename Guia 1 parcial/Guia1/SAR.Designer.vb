<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SAR
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CheckBox_Deduccion = New System.Windows.Forms.CheckBox()
        Me.Button_Calcular = New System.Windows.Forms.Button()
        Me.TextBox_Sueldo = New System.Windows.Forms.TextBox()
        Me.CheckBox_Excento = New System.Windows.Forms.CheckBox()
        Me.TextBox_SueldoNeto = New System.Windows.Forms.TextBox()
        Me.TextBox_Deduccion = New System.Windows.Forms.TextBox()
        Me.TextBox_ImpResultado = New System.Windows.Forms.TextBox()
        Me.Button_Limpiar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(318, 240)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(309, 211)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Menu Principal"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CheckBox_Deduccion
        '
        Me.CheckBox_Deduccion.AutoSize = True
        Me.CheckBox_Deduccion.Location = New System.Drawing.Point(17, 23)
        Me.CheckBox_Deduccion.Name = "CheckBox_Deduccion"
        Me.CheckBox_Deduccion.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox_Deduccion.TabIndex = 2
        Me.CheckBox_Deduccion.Text = "Deducción"
        Me.CheckBox_Deduccion.UseVisualStyleBackColor = True
        '
        'Button_Calcular
        '
        Me.Button_Calcular.Location = New System.Drawing.Point(19, 55)
        Me.Button_Calcular.Name = "Button_Calcular"
        Me.Button_Calcular.Size = New System.Drawing.Size(75, 23)
        Me.Button_Calcular.TabIndex = 3
        Me.Button_Calcular.Text = "Calcular"
        Me.Button_Calcular.UseVisualStyleBackColor = True
        '
        'TextBox_Sueldo
        '
        Me.TextBox_Sueldo.Location = New System.Drawing.Point(9, 29)
        Me.TextBox_Sueldo.Name = "TextBox_Sueldo"
        Me.TextBox_Sueldo.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Sueldo.TabIndex = 4
        '
        'CheckBox_Excento
        '
        Me.CheckBox_Excento.AutoSize = True
        Me.CheckBox_Excento.Location = New System.Drawing.Point(17, 46)
        Me.CheckBox_Excento.Name = "CheckBox_Excento"
        Me.CheckBox_Excento.Size = New System.Drawing.Size(72, 17)
        Me.CheckBox_Excento.TabIndex = 5
        Me.CheckBox_Excento.Text = "Excento"
        Me.CheckBox_Excento.UseVisualStyleBackColor = True
        '
        'TextBox_SueldoNeto
        '
        Me.TextBox_SueldoNeto.Location = New System.Drawing.Point(11, 19)
        Me.TextBox_SueldoNeto.Name = "TextBox_SueldoNeto"
        Me.TextBox_SueldoNeto.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_SueldoNeto.TabIndex = 6
        Me.TextBox_SueldoNeto.Text = "Sueldo Neto"
        '
        'TextBox_Deduccion
        '
        Me.TextBox_Deduccion.Location = New System.Drawing.Point(31, 171)
        Me.TextBox_Deduccion.Name = "TextBox_Deduccion"
        Me.TextBox_Deduccion.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Deduccion.TabIndex = 7
        Me.TextBox_Deduccion.Text = "Deduccion"
        '
        'TextBox_ImpResultado
        '
        Me.TextBox_ImpResultado.Location = New System.Drawing.Point(152, 213)
        Me.TextBox_ImpResultado.Name = "TextBox_ImpResultado"
        Me.TextBox_ImpResultado.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_ImpResultado.TabIndex = 8
        Me.TextBox_ImpResultado.Text = "Impuesto Resultado"
        '
        'Button_Limpiar
        '
        Me.Button_Limpiar.Location = New System.Drawing.Point(42, 211)
        Me.Button_Limpiar.Name = "Button_Limpiar"
        Me.Button_Limpiar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Limpiar.TabIndex = 9
        Me.Button_Limpiar.Text = "Limpiar"
        Me.Button_Limpiar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button_Calcular)
        Me.GroupBox1.Controls.Add(Me.TextBox_Sueldo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(118, 91)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingresar Sueldo"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox_SueldoNeto)
        Me.GroupBox2.Location = New System.Drawing.Point(31, 266)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(268, 100)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultado"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CheckBox_Deduccion)
        Me.GroupBox3.Controls.Add(Me.CheckBox_Excento)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(152, 13)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(117, 84)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Aplicar"
        '
        'SAR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 403)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button_Limpiar)
        Me.Controls.Add(Me.TextBox_ImpResultado)
        Me.Controls.Add(Me.TextBox_Deduccion)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "SAR"
        Me.Text = "SAR"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents CheckBox_Deduccion As CheckBox
    Friend WithEvents Button_Calcular As Button
    Friend WithEvents TextBox_Sueldo As TextBox
    Friend WithEvents CheckBox_Excento As CheckBox
    Friend WithEvents TextBox_SueldoNeto As TextBox
    Friend WithEvents TextBox_Deduccion As TextBox
    Friend WithEvents TextBox_ImpResultado As TextBox
    Friend WithEvents Button_Limpiar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
End Class
