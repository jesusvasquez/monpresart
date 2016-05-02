<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.groupCaptura = New System.Windows.Forms.GroupBox()
        Me.btnAyuda = New System.Windows.Forms.Button()
        Me.btnAcercade = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'groupCaptura
        '
        Me.groupCaptura.Location = New System.Drawing.Point(13, 13)
        Me.groupCaptura.Name = "groupCaptura"
        Me.groupCaptura.Size = New System.Drawing.Size(203, 100)
        Me.groupCaptura.TabIndex = 0
        Me.groupCaptura.TabStop = False
        Me.groupCaptura.Text = "Captura:"
        '
        'btnAyuda
        '
        Me.btnAyuda.Location = New System.Drawing.Point(13, 144)
        Me.btnAyuda.Name = "btnAyuda"
        Me.btnAyuda.Size = New System.Drawing.Size(75, 23)
        Me.btnAyuda.TabIndex = 1
        Me.btnAyuda.Text = "Ayuda"
        Me.btnAyuda.UseVisualStyleBackColor = True
        '
        'btnAcercade
        '
        Me.btnAcercade.Location = New System.Drawing.Point(13, 173)
        Me.btnAcercade.Name = "btnAcercade"
        Me.btnAcercade.Size = New System.Drawing.Size(75, 23)
        Me.btnAcercade.TabIndex = 2
        Me.btnAcercade.Text = "Acerca de"
        Me.btnAcercade.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(138, 144)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(138, 173)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(228, 206)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnAcercade)
        Me.Controls.Add(Me.btnAyuda)
        Me.Controls.Add(Me.groupCaptura)
        Me.Name = "frmMain"
        Me.Text = "Presión Arterial"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents groupCaptura As GroupBox
    Friend WithEvents btnAyuda As Button
    Friend WithEvents btnAcercade As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnSalir As Button
End Class
