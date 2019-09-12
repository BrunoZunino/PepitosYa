<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Listar_comidas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Listar_comidas))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tipo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.precio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tiempo_preparacion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ingredientes = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.imagen = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Agregar = New System.Windows.Forms.Button()
        Me.cerrarsesion = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id, Me.nombre, Me.tipo, Me.precio, Me.tiempo_preparacion, Me.ingredientes, Me.imagen})
        Me.ListView1.Location = New System.Drawing.Point(12, 91)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(579, 290)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'id
        '
        Me.id.Text = "ID"
        '
        'nombre
        '
        Me.nombre.Text = "Nombre"
        Me.nombre.Width = 144
        '
        'tipo
        '
        Me.tipo.Text = "Tipo"
        Me.tipo.Width = 118
        '
        'precio
        '
        Me.precio.Text = "Precio"
        Me.precio.Width = 94
        '
        'tiempo_preparacion
        '
        Me.tiempo_preparacion.Text = "Tiempo preparación"
        Me.tiempo_preparacion.Width = 139
        '
        'ingredientes
        '
        Me.ingredientes.Text = "Ingredientes"
        Me.ingredientes.Width = 203
        '
        'imagen
        '
        Me.imagen.Text = "Imgen"
        Me.imagen.Width = 169
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Window
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Button2.Location = New System.Drawing.Point(549, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(42, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Atras"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(274, 24)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Lista de comidas agregadas"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(237, 398)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(154, 44)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'Agregar
        '
        Me.Agregar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Agregar.ForeColor = System.Drawing.Color.Honeydew
        Me.Agregar.Location = New System.Drawing.Point(16, 46)
        Me.Agregar.Name = "Agregar"
        Me.Agregar.Size = New System.Drawing.Size(105, 23)
        Me.Agregar.TabIndex = 12
        Me.Agregar.Text = "Agregar Comida"
        Me.Agregar.UseVisualStyleBackColor = False
        '
        'cerrarsesion
        '
        Me.cerrarsesion.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cerrarsesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cerrarsesion.ForeColor = System.Drawing.Color.DarkRed
        Me.cerrarsesion.Location = New System.Drawing.Point(16, 415)
        Me.cerrarsesion.Name = "cerrarsesion"
        Me.cerrarsesion.Size = New System.Drawing.Size(105, 23)
        Me.cerrarsesion.TabIndex = 13
        Me.cerrarsesion.Text = "Cerrar sesión"
        Me.cerrarsesion.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(170, 46)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Listar_comidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(603, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cerrarsesion)
        Me.Controls.Add(Me.Agregar)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ListView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Listar_comidas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Picante Comidas"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Agregar As Button
    Friend WithEvents id As ColumnHeader
    Friend WithEvents nombre As ColumnHeader
    Friend WithEvents tipo As ColumnHeader
    Friend WithEvents precio As ColumnHeader
    Friend WithEvents tiempo_preparacion As ColumnHeader
    Friend WithEvents cerrarsesion As Button
    Friend WithEvents ingredientes As ColumnHeader
    Friend WithEvents imagen As ColumnHeader
    Friend WithEvents Button1 As Button
End Class
