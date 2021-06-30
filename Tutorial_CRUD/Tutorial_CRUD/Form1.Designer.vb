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
        Me.BtnConexion = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnLeer = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.TxtNombres = New System.Windows.Forms.TextBox()
        Me.TxtApellidos = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DGTabla = New System.Windows.Forms.DataGridView()
        CType(Me.DGTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnConexion
        '
        Me.BtnConexion.Location = New System.Drawing.Point(223, 12)
        Me.BtnConexion.Name = "BtnConexion"
        Me.BtnConexion.Size = New System.Drawing.Size(75, 23)
        Me.BtnConexion.TabIndex = 0
        Me.BtnConexion.Text = "Conexión"
        Me.BtnConexion.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(223, 70)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgregar.TabIndex = 1
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Location = New System.Drawing.Point(223, 99)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.BtnActualizar.TabIndex = 2
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'BtnLeer
        '
        Me.BtnLeer.Location = New System.Drawing.Point(223, 41)
        Me.BtnLeer.Name = "BtnLeer"
        Me.BtnLeer.Size = New System.Drawing.Size(75, 23)
        Me.BtnLeer.TabIndex = 3
        Me.BtnLeer.Text = "Leer"
        Me.BtnLeer.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(223, 128)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 4
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(30, 29)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(100, 20)
        Me.TxtId.TabIndex = 5
        '
        'TxtNombres
        '
        Me.TxtNombres.Location = New System.Drawing.Point(30, 73)
        Me.TxtNombres.Name = "TxtNombres"
        Me.TxtNombres.Size = New System.Drawing.Size(100, 20)
        Me.TxtNombres.TabIndex = 6
        '
        'TxtApellidos
        '
        Me.TxtApellidos.Location = New System.Drawing.Point(30, 115)
        Me.TxtApellidos.Name = "TxtApellidos"
        Me.TxtApellidos.Size = New System.Drawing.Size(100, 20)
        Me.TxtApellidos.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nombres"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Apellidos"
        '
        'DGTabla
        '
        Me.DGTabla.AllowUserToAddRows = False
        Me.DGTabla.AllowUserToDeleteRows = False
        Me.DGTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGTabla.Location = New System.Drawing.Point(12, 157)
        Me.DGTabla.Name = "DGTabla"
        Me.DGTabla.ReadOnly = True
        Me.DGTabla.Size = New System.Drawing.Size(306, 141)
        Me.DGTabla.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 310)
        Me.Controls.Add(Me.DGTabla)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtApellidos)
        Me.Controls.Add(Me.TxtNombres)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnLeer)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.BtnConexion)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tutorial CRUD"
        CType(Me.DGTabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnConexion As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnLeer As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents TxtId As TextBox
    Friend WithEvents TxtNombres As TextBox
    Friend WithEvents TxtApellidos As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DGTabla As DataGridView
End Class
