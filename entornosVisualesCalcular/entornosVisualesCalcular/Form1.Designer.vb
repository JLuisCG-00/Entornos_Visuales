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
        Dim BtnCalcular As System.Windows.Forms.Button
        Me.Lbl1 = New System.Windows.Forms.Label()
        Me.Lbl2 = New System.Windows.Forms.Label()
        Me.Lbl3 = New System.Windows.Forms.Label()
        Me.Txt2 = New System.Windows.Forms.TextBox()
        Me.Txt1 = New System.Windows.Forms.TextBox()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Lbl4 = New System.Windows.Forms.Label()
        Me.Lbl5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtResta = New System.Windows.Forms.TextBox()
        Me.TxtDiv = New System.Windows.Forms.TextBox()
        Me.TxtMult = New System.Windows.Forms.TextBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        BtnCalcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnCalcular
        '
        BtnCalcular.BackColor = System.Drawing.Color.Lime
        BtnCalcular.Cursor = System.Windows.Forms.Cursors.Hand
        BtnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        BtnCalcular.Location = New System.Drawing.Point(211, 120)
        BtnCalcular.Name = "BtnCalcular"
        BtnCalcular.Size = New System.Drawing.Size(75, 23)
        BtnCalcular.TabIndex = 0
        BtnCalcular.Text = "Calcular"
        BtnCalcular.UseVisualStyleBackColor = False
        AddHandler BtnCalcular.Click, AddressOf Me.BtnCalcular_Click
        '
        'Lbl1
        '
        Me.Lbl1.AutoSize = True
        Me.Lbl1.Location = New System.Drawing.Point(143, 64)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(40, 13)
        Me.Lbl1.TabIndex = 1
        Me.Lbl1.Text = "Valor 1"
        '
        'Lbl2
        '
        Me.Lbl2.AutoSize = True
        Me.Lbl2.Location = New System.Drawing.Point(312, 64)
        Me.Lbl2.Name = "Lbl2"
        Me.Lbl2.Size = New System.Drawing.Size(40, 13)
        Me.Lbl2.TabIndex = 2
        Me.Lbl2.Text = "Valor 2"
        '
        'Lbl3
        '
        Me.Lbl3.AutoSize = True
        Me.Lbl3.Location = New System.Drawing.Point(33, 222)
        Me.Lbl3.Name = "Lbl3"
        Me.Lbl3.Size = New System.Drawing.Size(61, 13)
        Me.Lbl3.TabIndex = 3
        Me.Lbl3.Text = "Total Suma"
        '
        'Txt2
        '
        Me.Txt2.Location = New System.Drawing.Point(284, 80)
        Me.Txt2.Name = "Txt2"
        Me.Txt2.Size = New System.Drawing.Size(100, 20)
        Me.Txt2.TabIndex = 4
        '
        'Txt1
        '
        Me.Txt1.Location = New System.Drawing.Point(114, 80)
        Me.Txt1.Name = "Txt1"
        Me.Txt1.Size = New System.Drawing.Size(100, 20)
        Me.Txt1.TabIndex = 5
        '
        'TxtTotal
        '
        Me.TxtTotal.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TxtTotal.Location = New System.Drawing.Point(12, 238)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(100, 20)
        Me.TxtTotal.TabIndex = 6
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.Red
        Me.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnSalir.Location = New System.Drawing.Point(156, 315)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 7
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'Lbl4
        '
        Me.Lbl4.AutoSize = True
        Me.Lbl4.Location = New System.Drawing.Point(152, 222)
        Me.Lbl4.Name = "Lbl4"
        Me.Lbl4.Size = New System.Drawing.Size(62, 13)
        Me.Lbl4.TabIndex = 8
        Me.Lbl4.Text = "Total Resta"
        '
        'Lbl5
        '
        Me.Lbl5.AutoSize = True
        Me.Lbl5.Location = New System.Drawing.Point(250, 222)
        Me.Lbl5.Name = "Lbl5"
        Me.Lbl5.Size = New System.Drawing.Size(98, 13)
        Me.Lbl5.TabIndex = 9
        Me.Lbl5.Text = "Total Multiplicacion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(378, 222)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Total Division"
        '
        'TxtResta
        '
        Me.TxtResta.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TxtResta.Location = New System.Drawing.Point(131, 238)
        Me.TxtResta.Name = "TxtResta"
        Me.TxtResta.Size = New System.Drawing.Size(100, 20)
        Me.TxtResta.TabIndex = 11
        '
        'TxtDiv
        '
        Me.TxtDiv.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TxtDiv.Location = New System.Drawing.Point(365, 238)
        Me.TxtDiv.Name = "TxtDiv"
        Me.TxtDiv.Size = New System.Drawing.Size(100, 20)
        Me.TxtDiv.TabIndex = 12
        '
        'TxtMult
        '
        Me.TxtMult.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TxtMult.Location = New System.Drawing.Point(248, 238)
        Me.TxtMult.Name = "TxtMult"
        Me.TxtMult.Size = New System.Drawing.Size(100, 20)
        Me.TxtMult.TabIndex = 13
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(248, 315)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.BtnLimpiar.TabIndex = 14
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 375)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.TxtMult)
        Me.Controls.Add(Me.TxtDiv)
        Me.Controls.Add(Me.TxtResta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Lbl5)
        Me.Controls.Add(Me.Lbl4)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.Txt1)
        Me.Controls.Add(Me.Txt2)
        Me.Controls.Add(Me.Lbl3)
        Me.Controls.Add(Me.Lbl2)
        Me.Controls.Add(Me.Lbl1)
        Me.Controls.Add(BtnCalcular)
        Me.Name = "Form1"
        Me.Text = "Mi primer app"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl1 As Label
    Friend WithEvents Lbl2 As Label
    Friend WithEvents Lbl3 As Label
    Friend WithEvents Txt2 As TextBox
    Friend WithEvents Txt1 As TextBox
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents BtnSalir As Button
    Friend WithEvents Lbl4 As Label
    Friend WithEvents Lbl5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtResta As TextBox
    Friend WithEvents TxtDiv As TextBox
    Friend WithEvents TxtMult As TextBox
    Friend WithEvents BtnLimpiar As Button
End Class
