<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AAfrmResultados
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.AADgvTotal = New System.Windows.Forms.DataGridView()
        Me.ColumnTotalEncuestados = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnMujeres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnHombres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnPromedioEdada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumSobrePromedio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnHombresCasados = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JHDgvEstadoCivil = New System.Windows.Forms.DataGridView()
        Me.ColumnSoltero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnCasado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnViudo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnDivorciado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AADgvMujeresSobrePromedio = New System.Windows.Forms.DataGridView()
        Me.ColumnNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnEdad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AAbtnVolver = New System.Windows.Forms.Button()
        Me.AAbtnSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AAdgvHombres = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.AADgvTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JHDgvEstadoCivil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AADgvMujeresSobrePromedio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AAdgvHombres, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AADgvTotal
        '
        Me.AADgvTotal.AllowUserToAddRows = False
        Me.AADgvTotal.AllowUserToDeleteRows = False
        Me.AADgvTotal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.AADgvTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AADgvTotal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnTotalEncuestados, Me.ColumnMujeres, Me.ColumnHombres, Me.ColumnPromedioEdada, Me.ColumSobrePromedio, Me.ColumnHombresCasados})
        Me.AADgvTotal.Location = New System.Drawing.Point(32, 61)
        Me.AADgvTotal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AADgvTotal.Name = "AADgvTotal"
        Me.AADgvTotal.ReadOnly = True
        Me.AADgvTotal.RowHeadersWidth = 62
        Me.AADgvTotal.RowTemplate.Height = 33
        Me.AADgvTotal.Size = New System.Drawing.Size(701, 132)
        Me.AADgvTotal.TabIndex = 0
        '
        'ColumnTotalEncuestados
        '
        Me.ColumnTotalEncuestados.HeaderText = "Total de encuestados"
        Me.ColumnTotalEncuestados.MinimumWidth = 8
        Me.ColumnTotalEncuestados.Name = "ColumnTotalEncuestados"
        Me.ColumnTotalEncuestados.ReadOnly = True
        '
        'ColumnMujeres
        '
        Me.ColumnMujeres.HeaderText = "Mujeres"
        Me.ColumnMujeres.MinimumWidth = 8
        Me.ColumnMujeres.Name = "ColumnMujeres"
        Me.ColumnMujeres.ReadOnly = True
        '
        'ColumnHombres
        '
        Me.ColumnHombres.HeaderText = "Hombres"
        Me.ColumnHombres.MinimumWidth = 8
        Me.ColumnHombres.Name = "ColumnHombres"
        Me.ColumnHombres.ReadOnly = True
        '
        'ColumnPromedioEdada
        '
        Me.ColumnPromedioEdada.HeaderText = "Promedio de edades"
        Me.ColumnPromedioEdada.MinimumWidth = 8
        Me.ColumnPromedioEdada.Name = "ColumnPromedioEdada"
        Me.ColumnPromedioEdada.ReadOnly = True
        '
        'ColumSobrePromedio
        '
        Me.ColumSobrePromedio.HeaderText = "Cantidad de mujeres sobre el promedio"
        Me.ColumSobrePromedio.MinimumWidth = 8
        Me.ColumSobrePromedio.Name = "ColumSobrePromedio"
        Me.ColumSobrePromedio.ReadOnly = True
        '
        'ColumnHombresCasados
        '
        Me.ColumnHombresCasados.HeaderText = "Hombres casados entre 20 y 35 años"
        Me.ColumnHombresCasados.MinimumWidth = 8
        Me.ColumnHombresCasados.Name = "ColumnHombresCasados"
        Me.ColumnHombresCasados.ReadOnly = True
        '
        'JHDgvEstadoCivil
        '
        Me.JHDgvEstadoCivil.AllowUserToAddRows = False
        Me.JHDgvEstadoCivil.AllowUserToDeleteRows = False
        Me.JHDgvEstadoCivil.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.JHDgvEstadoCivil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.JHDgvEstadoCivil.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnSoltero, Me.ColumnCasado, Me.ColumnViudo, Me.ColumnDivorciado})
        Me.JHDgvEstadoCivil.Location = New System.Drawing.Point(32, 360)
        Me.JHDgvEstadoCivil.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.JHDgvEstadoCivil.Name = "JHDgvEstadoCivil"
        Me.JHDgvEstadoCivil.ReadOnly = True
        Me.JHDgvEstadoCivil.RowHeadersWidth = 62
        Me.JHDgvEstadoCivil.RowTemplate.Height = 33
        Me.JHDgvEstadoCivil.Size = New System.Drawing.Size(701, 93)
        Me.JHDgvEstadoCivil.TabIndex = 1
        '
        'ColumnSoltero
        '
        Me.ColumnSoltero.HeaderText = "Soltero"
        Me.ColumnSoltero.MinimumWidth = 8
        Me.ColumnSoltero.Name = "ColumnSoltero"
        Me.ColumnSoltero.ReadOnly = True
        '
        'ColumnCasado
        '
        Me.ColumnCasado.HeaderText = "Casado"
        Me.ColumnCasado.MinimumWidth = 8
        Me.ColumnCasado.Name = "ColumnCasado"
        Me.ColumnCasado.ReadOnly = True
        '
        'ColumnViudo
        '
        Me.ColumnViudo.HeaderText = "Viudo(a)"
        Me.ColumnViudo.MinimumWidth = 8
        Me.ColumnViudo.Name = "ColumnViudo"
        Me.ColumnViudo.ReadOnly = True
        '
        'ColumnDivorciado
        '
        Me.ColumnDivorciado.HeaderText = "Divorciado(a)"
        Me.ColumnDivorciado.MinimumWidth = 8
        Me.ColumnDivorciado.Name = "ColumnDivorciado"
        Me.ColumnDivorciado.ReadOnly = True
        '
        'AADgvMujeresSobrePromedio
        '
        Me.AADgvMujeresSobrePromedio.AllowUserToAddRows = False
        Me.AADgvMujeresSobrePromedio.AllowUserToDeleteRows = False
        Me.AADgvMujeresSobrePromedio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.AADgvMujeresSobrePromedio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AADgvMujeresSobrePromedio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnNombre, Me.ColumnEdad})
        Me.AADgvMujeresSobrePromedio.Location = New System.Drawing.Point(32, 235)
        Me.AADgvMujeresSobrePromedio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AADgvMujeresSobrePromedio.Name = "AADgvMujeresSobrePromedio"
        Me.AADgvMujeresSobrePromedio.ReadOnly = True
        Me.AADgvMujeresSobrePromedio.RowHeadersWidth = 62
        Me.AADgvMujeresSobrePromedio.RowTemplate.Height = 33
        Me.AADgvMujeresSobrePromedio.Size = New System.Drawing.Size(332, 84)
        Me.AADgvMujeresSobrePromedio.TabIndex = 2
        '
        'ColumnNombre
        '
        Me.ColumnNombre.HeaderText = "Nombre"
        Me.ColumnNombre.MinimumWidth = 8
        Me.ColumnNombre.Name = "ColumnNombre"
        Me.ColumnNombre.ReadOnly = True
        '
        'ColumnEdad
        '
        Me.ColumnEdad.HeaderText = "Edad"
        Me.ColumnEdad.MinimumWidth = 8
        Me.ColumnEdad.Name = "ColumnEdad"
        Me.ColumnEdad.ReadOnly = True
        '
        'AAbtnVolver
        '
        Me.AAbtnVolver.Location = New System.Drawing.Point(316, 471)
        Me.AAbtnVolver.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AAbtnVolver.Name = "AAbtnVolver"
        Me.AAbtnVolver.Size = New System.Drawing.Size(78, 26)
        Me.AAbtnVolver.TabIndex = 3
        Me.AAbtnVolver.Text = "Volver"
        Me.AAbtnVolver.UseVisualStyleBackColor = True
        '
        'AAbtnSalir
        '
        Me.AAbtnSalir.Location = New System.Drawing.Point(411, 471)
        Me.AAbtnSalir.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AAbtnSalir.Name = "AAbtnSalir"
        Me.AAbtnSalir.Size = New System.Drawing.Size(78, 26)
        Me.AAbtnSalir.TabIndex = 4
        Me.AAbtnSalir.Text = "Salir"
        Me.AAbtnSalir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(54, 206)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Mujeres con edad mayor que el promedio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(271, 334)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(293, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Cantidad de personas según su estado civil"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(498, 206)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Hombre entre 20 y 35 años"
        '
        'AAdgvHombres
        '
        Me.AAdgvHombres.AllowUserToAddRows = False
        Me.AAdgvHombres.AllowUserToDeleteRows = False
        Me.AAdgvHombres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.AAdgvHombres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AAdgvHombres.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.AAdgvHombres.Location = New System.Drawing.Point(421, 235)
        Me.AAdgvHombres.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AAdgvHombres.Name = "AAdgvHombres"
        Me.AAdgvHombres.ReadOnly = True
        Me.AAdgvHombres.RowHeadersWidth = 62
        Me.AAdgvHombres.RowTemplate.Height = 33
        Me.AAdgvHombres.Size = New System.Drawing.Size(312, 84)
        Me.AAdgvHombres.TabIndex = 8
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Edad"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(306, 21)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(204, 21)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "RESULTADOS OBTENIDOS"
        '
        'AAfrmResultados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(780, 508)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.AAdgvHombres)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AAbtnSalir)
        Me.Controls.Add(Me.AAbtnVolver)
        Me.Controls.Add(Me.AADgvMujeresSobrePromedio)
        Me.Controls.Add(Me.JHDgvEstadoCivil)
        Me.Controls.Add(Me.AADgvTotal)
        Me.Name = "AAfrmResultados"
        Me.Text = "AAfrmResultados"
        CType(Me.AADgvTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JHDgvEstadoCivil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AADgvMujeresSobrePromedio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AAdgvHombres, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AADgvTotal As DataGridView
    Friend WithEvents JHDgvEstadoCivil As DataGridView
    Friend WithEvents ColumnSoltero As DataGridViewTextBoxColumn
    Friend WithEvents ColumnCasado As DataGridViewTextBoxColumn
    Friend WithEvents ColumnViudo As DataGridViewTextBoxColumn
    Friend WithEvents ColumnDivorciado As DataGridViewTextBoxColumn
    Friend WithEvents AADgvMujeresSobrePromedio As DataGridView
    Friend WithEvents ColumnNombre As DataGridViewTextBoxColumn
    Friend WithEvents ColumnEdad As DataGridViewTextBoxColumn
    Friend WithEvents AAbtnVolver As Button
    Friend WithEvents AAbtnSalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents AAdgvHombres As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents ColumnTotalEncuestados As DataGridViewTextBoxColumn
    Friend WithEvents ColumnMujeres As DataGridViewTextBoxColumn
    Friend WithEvents ColumnHombres As DataGridViewTextBoxColumn
    Friend WithEvents ColumnPromedioEdada As DataGridViewTextBoxColumn
    Friend WithEvents ColumSobrePromedio As DataGridViewTextBoxColumn
    Friend WithEvents ColumnHombresCasados As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
End Class
