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
        Me.Txtnumero = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btnnuevo = New System.Windows.Forms.Button()
        Me.Btncalcular = New System.Windows.Forms.Button()
        Me.Btnsalir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Cbosuma = New System.Windows.Forms.ComboBox()
        Me.cboresta = New System.Windows.Forms.ComboBox()
        Me.cbomultiplicacion = New System.Windows.Forms.ComboBox()
        Me.cbodivision = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Txtnumero
        '
        Me.Txtnumero.Location = New System.Drawing.Point(321, 74)
        Me.Txtnumero.Name = "Txtnumero"
        Me.Txtnumero.Size = New System.Drawing.Size(100, 20)
        Me.Txtnumero.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(242, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Numero:"
        '
        'Btnnuevo
        '
        Me.Btnnuevo.Location = New System.Drawing.Point(171, 160)
        Me.Btnnuevo.Name = "Btnnuevo"
        Me.Btnnuevo.Size = New System.Drawing.Size(75, 23)
        Me.Btnnuevo.TabIndex = 2
        Me.Btnnuevo.Text = "Nuevo"
        Me.Btnnuevo.UseVisualStyleBackColor = True
        '
        'Btncalcular
        '
        Me.Btncalcular.Location = New System.Drawing.Point(279, 160)
        Me.Btncalcular.Name = "Btncalcular"
        Me.Btncalcular.Size = New System.Drawing.Size(75, 23)
        Me.Btncalcular.TabIndex = 3
        Me.Btncalcular.Text = "Calcular"
        Me.Btncalcular.UseVisualStyleBackColor = True
        '
        'Btnsalir
        '
        Me.Btnsalir.Location = New System.Drawing.Point(385, 160)
        Me.Btnsalir.Name = "Btnsalir"
        Me.Btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.Btnsalir.TabIndex = 5
        Me.Btnsalir.Text = "Salir"
        Me.Btnsalir.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 279)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Suma"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(184, 279)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Resta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(331, 279)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Multiplicacion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(474, 279)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Division"
        '
        'Cbosuma
        '
        Me.Cbosuma.FormattingEnabled = True
        Me.Cbosuma.Location = New System.Drawing.Point(46, 305)
        Me.Cbosuma.Name = "Cbosuma"
        Me.Cbosuma.Size = New System.Drawing.Size(121, 21)
        Me.Cbosuma.TabIndex = 10
        '
        'cboresta
        '
        Me.cboresta.FormattingEnabled = True
        Me.cboresta.Location = New System.Drawing.Point(187, 305)
        Me.cboresta.Name = "cboresta"
        Me.cboresta.Size = New System.Drawing.Size(121, 21)
        Me.cboresta.TabIndex = 11
        '
        'cbomultiplicacion
        '
        Me.cbomultiplicacion.FormattingEnabled = True
        Me.cbomultiplicacion.Location = New System.Drawing.Point(334, 305)
        Me.cbomultiplicacion.Name = "cbomultiplicacion"
        Me.cbomultiplicacion.Size = New System.Drawing.Size(121, 21)
        Me.cbomultiplicacion.TabIndex = 12
        '
        'cbodivision
        '
        Me.cbodivision.FormattingEnabled = True
        Me.cbodivision.Location = New System.Drawing.Point(477, 305)
        Me.cbodivision.Name = "cbodivision"
        Me.cbodivision.Size = New System.Drawing.Size(121, 21)
        Me.cbodivision.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 352)
        Me.Controls.Add(Me.cbodivision)
        Me.Controls.Add(Me.cbomultiplicacion)
        Me.Controls.Add(Me.cboresta)
        Me.Controls.Add(Me.Cbosuma)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Btnsalir)
        Me.Controls.Add(Me.Btncalcular)
        Me.Controls.Add(Me.Btnnuevo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txtnumero)
        Me.Name = "Form1"
        Me.Text = ".:. Estructura For .:."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txtnumero As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Btnnuevo As Button
    Friend WithEvents Btncalcular As Button
    Friend WithEvents Btnsalir As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Cbosuma As ComboBox
    Friend WithEvents cboresta As ComboBox
    Friend WithEvents cbomultiplicacion As ComboBox
    Friend WithEvents cbodivision As ComboBox
End Class
