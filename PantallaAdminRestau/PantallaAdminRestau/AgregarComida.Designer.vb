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
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.tbPrecio = New System.Windows.Forms.TextBox()
        Me.BAgregar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.TBingre = New System.Windows.Forms.TextBox()
        Me.lblIngre = New System.Windows.Forms.Label()
        Me.btnAddingre = New System.Windows.Forms.Button()
        Me.ListIngre = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(102, 145)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre:"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(102, 196)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(40, 13)
        Me.lblPrecio.TabIndex = 2
        Me.lblPrecio.Text = "Precio:"
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(168, 142)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(155, 20)
        Me.tbNombre.TabIndex = 4
        '
        'tbPrecio
        '
        Me.tbPrecio.Location = New System.Drawing.Point(168, 196)
        Me.tbPrecio.Name = "tbPrecio"
        Me.tbPrecio.Size = New System.Drawing.Size(155, 20)
        Me.tbPrecio.TabIndex = 6
        '
        'BAgregar
        '
        Me.BAgregar.BackColor = System.Drawing.Color.Snow
        Me.BAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAgregar.Location = New System.Drawing.Point(203, 334)
        Me.BAgregar.Name = "BAgregar"
        Me.BAgregar.Size = New System.Drawing.Size(103, 28)
        Me.BAgregar.TabIndex = 8
        Me.BAgregar.Text = "Agregar"
        Me.BAgregar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.RoyalBlue
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnEliminar.Location = New System.Drawing.Point(258, 334)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(84, 28)
        Me.BtnEliminar.TabIndex = 9
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnActualizar.Location = New System.Drawing.Point(128, 334)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(102, 28)
        Me.btnActualizar.TabIndex = 10
        Me.btnActualizar.Text = "Actualizar datos"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'TBingre
        '
        Me.TBingre.Location = New System.Drawing.Point(168, 249)
        Me.TBingre.Name = "TBingre"
        Me.TBingre.Size = New System.Drawing.Size(155, 20)
        Me.TBingre.TabIndex = 11
        '
        'lblIngre
        '
        Me.lblIngre.AutoSize = True
        Me.lblIngre.Location = New System.Drawing.Point(81, 254)
        Me.lblIngre.Name = "lblIngre"
        Me.lblIngre.Size = New System.Drawing.Size(68, 13)
        Me.lblIngre.TabIndex = 12
        Me.lblIngre.Text = "Ingredientes:"
        '
        'btnAddingre
        '
        Me.btnAddingre.Location = New System.Drawing.Point(340, 249)
        Me.btnAddingre.Name = "btnAddingre"
        Me.btnAddingre.Size = New System.Drawing.Size(26, 23)
        Me.btnAddingre.TabIndex = 13
        Me.btnAddingre.Text = "+"
        Me.btnAddingre.UseVisualStyleBackColor = True
        '
        'ListIngre
        '
        Me.ListIngre.FormattingEnabled = True
        Me.ListIngre.Location = New System.Drawing.Point(434, 96)
        Me.ListIngre.Name = "ListIngre"
        Me.ListIngre.Size = New System.Drawing.Size(224, 212)
        Me.ListIngre.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(431, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Ingredientes:"
        '
        'AgregarComida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(708, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListIngre)
        Me.Controls.Add(Me.btnAddingre)
        Me.Controls.Add(Me.lblIngre)
        Me.Controls.Add(Me.TBingre)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BAgregar)
        Me.Controls.Add(Me.tbPrecio)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.lblNombre)
        Me.Name = "AgregarComida"
        Me.Text = "AgregarComida"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNombre As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents tbPrecio As TextBox
    Friend WithEvents BAgregar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents TBingre As TextBox
    Friend WithEvents lblIngre As Label
    Friend WithEvents btnAddingre As Button
    Friend WithEvents ListIngre As ListBox
    Friend WithEvents Label1 As Label
End Class
