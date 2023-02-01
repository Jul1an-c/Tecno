<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Registros
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
        Me.txt_Nombre = New Guna.UI.WinForms.GunaTextBox()
        Me.txt_Apellido = New Guna.UI.WinForms.GunaTextBox()
        Me.txt_Usuario = New Guna.UI.WinForms.GunaTextBox()
        Me.txt_Contraseña = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.lbl_Contraseña = New Guna.UI.WinForms.GunaLabel()
        Me.btn_Registrar = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_TipoUsu = New Guna.UI.WinForms.GunaTextBox()
        Me.SuspendLayout()
        '
        'txt_Nombre
        '
        Me.txt_Nombre.BaseColor = System.Drawing.Color.White
        Me.txt_Nombre.BorderColor = System.Drawing.Color.Silver
        Me.txt_Nombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Nombre.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_Nombre.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Nombre.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_Nombre.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_Nombre.Location = New System.Drawing.Point(210, 63)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Nombre.Size = New System.Drawing.Size(160, 26)
        Me.txt_Nombre.TabIndex = 0
        Me.txt_Nombre.Text = "Ingrese Su Nombre"
        '
        'txt_Apellido
        '
        Me.txt_Apellido.BaseColor = System.Drawing.Color.White
        Me.txt_Apellido.BorderColor = System.Drawing.Color.Silver
        Me.txt_Apellido.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Apellido.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_Apellido.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Apellido.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_Apellido.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_Apellido.Location = New System.Drawing.Point(210, 130)
        Me.txt_Apellido.Name = "txt_Apellido"
        Me.txt_Apellido.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Apellido.Size = New System.Drawing.Size(160, 26)
        Me.txt_Apellido.TabIndex = 1
        Me.txt_Apellido.Text = "Ingrese Su Apellido"
        '
        'txt_Usuario
        '
        Me.txt_Usuario.BaseColor = System.Drawing.Color.White
        Me.txt_Usuario.BorderColor = System.Drawing.Color.Silver
        Me.txt_Usuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Usuario.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_Usuario.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Usuario.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_Usuario.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_Usuario.Location = New System.Drawing.Point(210, 194)
        Me.txt_Usuario.Name = "txt_Usuario"
        Me.txt_Usuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Usuario.Size = New System.Drawing.Size(160, 26)
        Me.txt_Usuario.TabIndex = 2
        Me.txt_Usuario.Text = "Ingrese Su Nombre_Usuario"
        '
        'txt_Contraseña
        '
        Me.txt_Contraseña.BaseColor = System.Drawing.Color.White
        Me.txt_Contraseña.BorderColor = System.Drawing.Color.Silver
        Me.txt_Contraseña.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Contraseña.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_Contraseña.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Contraseña.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_Contraseña.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_Contraseña.Location = New System.Drawing.Point(210, 263)
        Me.txt_Contraseña.Name = "txt_Contraseña"
        Me.txt_Contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Contraseña.Size = New System.Drawing.Size(160, 26)
        Me.txt_Contraseña.TabIndex = 3
        Me.txt_Contraseña.Text = "Ingrese Su Contraseña"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(259, 39)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(65, 20)
        Me.GunaLabel1.TabIndex = 4
        Me.GunaLabel1.Text = "Nombre"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(258, 107)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(65, 20)
        Me.GunaLabel2.TabIndex = 5
        Me.GunaLabel2.Text = "Apellido"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.Location = New System.Drawing.Point(259, 171)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(64, 20)
        Me.GunaLabel3.TabIndex = 6
        Me.GunaLabel3.Text = "Usuario"
        '
        'lbl_Contraseña
        '
        Me.lbl_Contraseña.AutoSize = True
        Me.lbl_Contraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Contraseña.Location = New System.Drawing.Point(244, 240)
        Me.lbl_Contraseña.Name = "lbl_Contraseña"
        Me.lbl_Contraseña.Size = New System.Drawing.Size(92, 20)
        Me.lbl_Contraseña.TabIndex = 7
        Me.lbl_Contraseña.Text = "Contraseña"
        '
        'btn_Registrar
        '
        Me.btn_Registrar.AnimationHoverSpeed = 0.07!
        Me.btn_Registrar.AnimationSpeed = 0.03!
        Me.btn_Registrar.BackColor = System.Drawing.Color.Transparent
        Me.btn_Registrar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Registrar.BorderColor = System.Drawing.Color.Black
        Me.btn_Registrar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_Registrar.FocusedColor = System.Drawing.Color.Empty
        Me.btn_Registrar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_Registrar.ForeColor = System.Drawing.Color.White
        Me.btn_Registrar.Image = Nothing
        Me.btn_Registrar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btn_Registrar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_Registrar.Location = New System.Drawing.Point(228, 391)
        Me.btn_Registrar.Name = "btn_Registrar"
        Me.btn_Registrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Registrar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_Registrar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_Registrar.OnHoverImage = Nothing
        Me.btn_Registrar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_Registrar.Radius = 10
        Me.btn_Registrar.Size = New System.Drawing.Size(121, 29)
        Me.btn_Registrar.TabIndex = 8
        Me.btn_Registrar.Text = "Registrarse"
        Me.btn_Registrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.Location = New System.Drawing.Point(231, 308)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(123, 20)
        Me.GunaLabel4.TabIndex = 11
        Me.GunaLabel4.Text = "Codigo_Usuario"
        '
        'txt_TipoUsu
        '
        Me.txt_TipoUsu.BaseColor = System.Drawing.Color.White
        Me.txt_TipoUsu.BorderColor = System.Drawing.Color.Silver
        Me.txt_TipoUsu.CausesValidation = False
        Me.txt_TipoUsu.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_TipoUsu.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_TipoUsu.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_TipoUsu.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_TipoUsu.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_TipoUsu.Location = New System.Drawing.Point(208, 328)
        Me.txt_TipoUsu.Name = "txt_TipoUsu"
        Me.txt_TipoUsu.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_TipoUsu.ReadOnly = True
        Me.txt_TipoUsu.Size = New System.Drawing.Size(160, 30)
        Me.txt_TipoUsu.TabIndex = 10
        Me.txt_TipoUsu.Text = "1"
        '
        'frm_Registros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 468)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.txt_TipoUsu)
        Me.Controls.Add(Me.btn_Registrar)
        Me.Controls.Add(Me.lbl_Contraseña)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.txt_Contraseña)
        Me.Controls.Add(Me.txt_Usuario)
        Me.Controls.Add(Me.txt_Apellido)
        Me.Controls.Add(Me.txt_Nombre)
        Me.Name = "frm_Registros"
        Me.Text = "frm_Registros"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_Nombre As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txt_Apellido As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txt_Usuario As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txt_Contraseña As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Contraseña As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btn_Registrar As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_TipoUsu As Guna.UI.WinForms.GunaTextBox
End Class
