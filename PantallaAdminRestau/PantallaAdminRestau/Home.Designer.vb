<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Nombre"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Precio")
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Ingredientes"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.listComida = New System.Windows.Forms.ListView()
        Me.lblComidas = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAgregar.ForeColor = System.Drawing.Color.Teal
        Me.btnAgregar.Location = New System.Drawing.Point(12, 12)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(121, 23)
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.Text = "Agregar Comida"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'listComida
        '
        Me.listComida.ForeColor = System.Drawing.SystemColors.MenuText
        Me.listComida.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem4, ListViewItem5, ListViewItem6})
        Me.listComida.Location = New System.Drawing.Point(61, 108)
        Me.listComida.Name = "listComida"
        Me.listComida.Size = New System.Drawing.Size(388, 291)
        Me.listComida.TabIndex = 1
        Me.listComida.UseCompatibleStateImageBehavior = False
        '
        'lblComidas
        '
        Me.lblComidas.AutoSize = True
        Me.lblComidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComidas.ForeColor = System.Drawing.Color.Teal
        Me.lblComidas.Location = New System.Drawing.Point(57, 59)
        Me.lblComidas.Name = "lblComidas"
        Me.lblComidas.Size = New System.Drawing.Size(128, 20)
        Me.lblComidas.TabIndex = 2
        Me.lblComidas.Text = "Lista de comidas"
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(486, 450)
        Me.Controls.Add(Me.lblComidas)
        Me.Controls.Add(Me.listComida)
        Me.Controls.Add(Me.btnAgregar)
        Me.Name = "Home"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAgregar As Button
    Friend WithEvents listComida As ListView
    Friend WithEvents lblComidas As Label
End Class
