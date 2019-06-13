<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Restaurante
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Restaurante))
        Me.Comidas = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ComidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaComidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarComidasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarComidasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EdiarComidasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ComidaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarComidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ComidasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Comidas
        '
        Me.Comidas.Name = "Comidas"
        Me.Comidas.Size = New System.Drawing.Size(61, 4)
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComidaToolStripMenuItem, Me.AltaComidaToolStripMenuItem, Me.ListarComidasToolStripMenuItem, Me.EliminarComidasToolStripMenuItem, Me.EdiarComidasToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(168, 114)
        '
        'ComidaToolStripMenuItem
        '
        Me.ComidaToolStripMenuItem.Name = "ComidaToolStripMenuItem"
        Me.ComidaToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.ComidaToolStripMenuItem.Text = "Comida"
        '
        'AltaComidaToolStripMenuItem
        '
        Me.AltaComidaToolStripMenuItem.Name = "AltaComidaToolStripMenuItem"
        Me.AltaComidaToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.AltaComidaToolStripMenuItem.Text = "Alta Comida"
        '
        'ListarComidasToolStripMenuItem
        '
        Me.ListarComidasToolStripMenuItem.Name = "ListarComidasToolStripMenuItem"
        Me.ListarComidasToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.ListarComidasToolStripMenuItem.Text = "Listar Comidas"
        '
        'EliminarComidasToolStripMenuItem
        '
        Me.EliminarComidasToolStripMenuItem.Name = "EliminarComidasToolStripMenuItem"
        Me.EliminarComidasToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.EliminarComidasToolStripMenuItem.Text = "Eliminar Comidas"
        '
        'EdiarComidasToolStripMenuItem
        '
        Me.EdiarComidasToolStripMenuItem.Name = "EdiarComidasToolStripMenuItem"
        Me.EdiarComidasToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.EdiarComidasToolStripMenuItem.Text = "Ediar Comidas"
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComidaToolStripMenuItem1, Me.AgregarComidaToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(160, 48)
        '
        'ComidaToolStripMenuItem1
        '
        Me.ComidaToolStripMenuItem1.Name = "ComidaToolStripMenuItem1"
        Me.ComidaToolStripMenuItem1.Size = New System.Drawing.Size(159, 22)
        Me.ComidaToolStripMenuItem1.Text = "Comida"
        '
        'AgregarComidaToolStripMenuItem
        '
        Me.AgregarComidaToolStripMenuItem.Name = "AgregarComidaToolStripMenuItem"
        Me.AgregarComidaToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.AgregarComidaToolStripMenuItem.Text = "Agregar comida"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComidasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(646, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ComidasToolStripMenuItem
        '
        Me.ComidasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem, Me.ListarToolStripMenuItem, Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.ComidasToolStripMenuItem.Name = "ComidasToolStripMenuItem"
        Me.ComidasToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ComidasToolStripMenuItem.Text = "Comidas"
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AgregarToolStripMenuItem.Text = "Agregar "
        '
        'ListarToolStripMenuItem
        '
        Me.ListarToolStripMenuItem.Name = "ListarToolStripMenuItem"
        Me.ListarToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.ListarToolStripMenuItem.Text = "Listar"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Black
        Me.ImageList1.Images.SetKeyName(0, "picante.png")
        Me.ImageList1.Images.SetKeyName(1, "WhatsApp Image 2019-03-19 at 09.16.24.jpeg")
        '
        'Restaurante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(646, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Restaurante"
        Me.Text = "Restaurante"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Comidas As ContextMenuStrip
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ComidaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaComidaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarComidasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarComidasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EdiarComidasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents ComidaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AgregarComidaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ComidasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImageList1 As ImageList
End Class
