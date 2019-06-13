<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarComida
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
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.LblTipo = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblTiempo = New System.Windows.Forms.Label()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.tbTipo = New System.Windows.Forms.TextBox()
        Me.tbPrecio = New System.Windows.Forms.TextBox()
        Me.tbTiempo = New System.Windows.Forms.TextBox()
        Me.BAgregar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(178, 130)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre:"
        '
        'LblTipo
        '
        Me.LblTipo.AutoSize = True
        Me.LblTipo.Location = New System.Drawing.Point(178, 176)
        Me.LblTipo.Name = "LblTipo"
        Me.LblTipo.Size = New System.Drawing.Size(31, 13)
        Me.LblTipo.TabIndex = 1
        Me.LblTipo.Text = "Tipo:"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(178, 223)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(40, 13)
        Me.lblPrecio.TabIndex = 2
        Me.lblPrecio.Text = "Precio:"
        '
        'lblTiempo
        '
        Me.lblTiempo.AutoSize = True
        Me.lblTiempo.Location = New System.Drawing.Point(119, 272)
        Me.lblTiempo.Name = "lblTiempo"
        Me.lblTiempo.Size = New System.Drawing.Size(119, 13)
        Me.lblTiempo.TabIndex = 3
        Me.lblTiempo.Text = "Tiempo de preparacion:"
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(244, 127)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(155, 20)
        Me.tbNombre.TabIndex = 4
        '
        'tbTipo
        '
        Me.tbTipo.Location = New System.Drawing.Point(244, 173)
        Me.tbTipo.Name = "tbTipo"
        Me.tbTipo.Size = New System.Drawing.Size(155, 20)
        Me.tbTipo.TabIndex = 5
        '
        'tbPrecio
        '
        Me.tbPrecio.Location = New System.Drawing.Point(244, 223)
        Me.tbPrecio.Name = "tbPrecio"
        Me.tbPrecio.Size = New System.Drawing.Size(155, 20)
        Me.tbPrecio.TabIndex = 6
        '
        'tbTiempo
        '
        Me.tbTiempo.Location = New System.Drawing.Point(244, 269)
        Me.tbTiempo.Name = "tbTiempo"
        Me.tbTiempo.Size = New System.Drawing.Size(155, 20)
        Me.tbTiempo.TabIndex = 7
        '
        'BAgregar
        '
        Me.BAgregar.BackColor = System.Drawing.Color.Snow
        Me.BAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAgregar.Location = New System.Drawing.Point(271, 332)
        Me.BAgregar.Name = "BAgregar"
        Me.BAgregar.Size = New System.Drawing.Size(103, 28)
        Me.BAgregar.TabIndex = 8
        Me.BAgregar.Text = "Agregar"
        Me.BAgregar.UseVisualStyleBackColor = False
        '
        'AgregarComida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(645, 450)
        Me.Controls.Add(Me.BAgregar)
        Me.Controls.Add(Me.tbTiempo)
        Me.Controls.Add(Me.tbPrecio)
        Me.Controls.Add(Me.tbTipo)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.lblTiempo)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.LblTipo)
        Me.Controls.Add(Me.lblNombre)
        Me.Name = "AgregarComida"
        Me.Text = "AgregarComida"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNombre As Label
    Friend WithEvents LblTipo As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents lblTiempo As Label
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents tbTipo As TextBox
    Friend WithEvents tbPrecio As TextBox
    Friend WithEvents tbTiempo As TextBox
    Friend WithEvents BAgregar As Button
End Class
