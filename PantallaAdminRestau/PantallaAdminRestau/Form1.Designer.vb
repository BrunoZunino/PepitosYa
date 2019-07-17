<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Restaurante
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Restaurante))
        Me.TBcorreo = New System.Windows.Forms.TextBox()
        Me.TBcontra = New System.Windows.Forms.TextBox()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.Lblcontra = New System.Windows.Forms.Label()
        Me.lblBienvenido = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btregistro = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TBcorreo
        '
        Me.TBcorreo.Location = New System.Drawing.Point(152, 173)
        Me.TBcorreo.Name = "TBcorreo"
        Me.TBcorreo.Size = New System.Drawing.Size(197, 20)
        Me.TBcorreo.TabIndex = 0
        '
        'TBcontra
        '
        Me.TBcontra.Location = New System.Drawing.Point(152, 234)
        Me.TBcontra.Name = "TBcontra"
        Me.TBcontra.Size = New System.Drawing.Size(197, 20)
        Me.TBcontra.TabIndex = 1
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Location = New System.Drawing.Point(72, 173)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(41, 13)
        Me.lblCorreo.TabIndex = 2
        Me.lblCorreo.Text = "Correo:"
        '
        'Lblcontra
        '
        Me.Lblcontra.AutoSize = True
        Me.Lblcontra.Location = New System.Drawing.Point(49, 238)
        Me.Lblcontra.Name = "Lblcontra"
        Me.Lblcontra.Size = New System.Drawing.Size(64, 13)
        Me.Lblcontra.TabIndex = 3
        Me.Lblcontra.Text = "Contraseña:"
        '
        'lblBienvenido
        '
        Me.lblBienvenido.AutoSize = True
        Me.lblBienvenido.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBienvenido.ForeColor = System.Drawing.Color.Teal
        Me.lblBienvenido.Location = New System.Drawing.Point(163, 88)
        Me.lblBienvenido.Name = "lblBienvenido"
        Me.lblBienvenido.Size = New System.Drawing.Size(172, 33)
        Me.lblBienvenido.TabIndex = 4
        Me.lblBienvenido.Text = "Bienvenid@"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Teal
        Me.Button1.Location = New System.Drawing.Point(181, 314)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 28)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Iniciar sesion"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btregistro
        '
        Me.btregistro.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btregistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btregistro.ForeColor = System.Drawing.Color.Teal
        Me.btregistro.Location = New System.Drawing.Point(181, 371)
        Me.btregistro.Name = "btregistro"
        Me.btregistro.Size = New System.Drawing.Size(124, 28)
        Me.btregistro.TabIndex = 6
        Me.btregistro.Text = "Registrarse"
        Me.btregistro.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(237, 349)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "o"
        '
        'Restaurante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(485, 439)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btregistro)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblBienvenido)
        Me.Controls.Add(Me.Lblcontra)
        Me.Controls.Add(Me.lblCorreo)
        Me.Controls.Add(Me.TBcontra)
        Me.Controls.Add(Me.TBcorreo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Restaurante"
        Me.Text = "Restaurante"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBcorreo As TextBox
    Friend WithEvents TBcontra As TextBox
    Friend WithEvents lblCorreo As Label
    Friend WithEvents Lblcontra As Label
    Friend WithEvents lblBienvenido As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btregistro As Button
    Friend WithEvents Label1 As Label
End Class
