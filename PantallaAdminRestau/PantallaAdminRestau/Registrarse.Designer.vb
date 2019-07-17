<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrarse
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
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.lbcontra = New System.Windows.Forms.Label()
        Me.lbcorreo = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btregistrarse = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(210, 188)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(187, 20)
        Me.TextBox3.TabIndex = 3
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(210, 149)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(187, 20)
        Me.TextBox4.TabIndex = 2
        '
        'lbcontra
        '
        Me.lbcontra.AutoSize = True
        Me.lbcontra.Location = New System.Drawing.Point(125, 188)
        Me.lbcontra.Name = "lbcontra"
        Me.lbcontra.Size = New System.Drawing.Size(61, 13)
        Me.lbcontra.TabIndex = 8
        Me.lbcontra.Text = "Contraseña"
        '
        'lbcorreo
        '
        Me.lbcorreo.AutoSize = True
        Me.lbcorreo.Location = New System.Drawing.Point(125, 152)
        Me.lbcorreo.Name = "lbcorreo"
        Me.lbcorreo.Size = New System.Drawing.Size(41, 13)
        Me.lbcorreo.TabIndex = 7
        Me.lbcorreo.Text = "Correo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(121, 296)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 10
        '
        'btregistrarse
        '
        Me.btregistrarse.Location = New System.Drawing.Point(266, 242)
        Me.btregistrarse.Name = "btregistrarse"
        Me.btregistrarse.Size = New System.Drawing.Size(75, 23)
        Me.btregistrarse.TabIndex = 11
        Me.btregistrarse.Text = "Registrarse"
        Me.btregistrarse.UseVisualStyleBackColor = True
        '
        'Registrarse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 410)
        Me.Controls.Add(Me.btregistrarse)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbcontra)
        Me.Controls.Add(Me.lbcorreo)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox4)
        Me.Name = "Registrarse"
        Me.Text = "Registrarse"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents lbcontra As Label
    Friend WithEvents lbcorreo As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btregistrarse As Button
End Class
