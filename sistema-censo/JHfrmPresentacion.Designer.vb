<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JHfrmPresentacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(JHfrmPresentacion))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.JHbtnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(28, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(448, 420)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = resources.GetString("Label1.Text")
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'JHbtnSalir
        '
        Me.JHbtnSalir.Location = New System.Drawing.Point(209, 466)
        Me.JHbtnSalir.Name = "JHbtnSalir"
        Me.JHbtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.JHbtnSalir.TabIndex = 1
        Me.JHbtnSalir.Text = "Salir"
        Me.JHbtnSalir.UseVisualStyleBackColor = True
        '
        'JHfrmPresentacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 501)
        Me.Controls.Add(Me.JHbtnSalir)
        Me.Controls.Add(Me.Label1)
        Me.Name = "JHfrmPresentacion"
        Me.Text = "JHfrmPresentacion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents JHbtnSalir As Button
End Class
