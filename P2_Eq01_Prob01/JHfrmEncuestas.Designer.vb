<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class JHfrmEncuestas
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.JHtxtFecha = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.JHtxtSupervisor = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.JHtxtLocalidad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.JHcbxGenero = New System.Windows.Forms.ComboBox()
        Me.JHbtnAgregar = New System.Windows.Forms.Button()
        Me.JHdgvEncuestas = New System.Windows.Forms.DataGridView()
        Me.ColumnFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnSupervisor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnLocalidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnNumCenso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnGenero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnEdad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.JHbtnModificar = New System.Windows.Forms.Button()
        Me.JHbtnEliminar = New System.Windows.Forms.Button()
        Me.JHbtnResultados = New System.Windows.Forms.Button()
        Me.JHbtnSalir = New System.Windows.Forms.Button()
        Me.ErrorProviderValidar = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.JHcbxEstado = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.JHtxtNumCenso = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.JHtxtEdad = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.JHtxtNombre = New System.Windows.Forms.TextBox()
        Me.JHbtnPresentacion = New System.Windows.Forms.Button()
        Me.JHtime = New System.Windows.Forms.Timer(Me.components)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.JHbtnLimpiar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.JHdgvEncuestas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderValidar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha"
        '
        'JHtxtFecha
        '
        Me.JHtxtFecha.Enabled = False
        Me.JHtxtFecha.Location = New System.Drawing.Point(106, 33)
        Me.JHtxtFecha.Name = "JHtxtFecha"
        Me.JHtxtFecha.ReadOnly = True
        Me.JHtxtFecha.Size = New System.Drawing.Size(333, 23)
        Me.JHtxtFecha.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.JHtxtSupervisor)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.JHtxtLocalidad)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.JHtxtFecha)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 94)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(463, 190)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Generales"
        '
        'JHtxtSupervisor
        '
        Me.JHtxtSupervisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.JHtxtSupervisor.FormattingEnabled = True
        Me.JHtxtSupervisor.Items.AddRange(New Object() {"Jeymar Herrera", "Adrian Albaez", "Anna Araba"})
        Me.JHtxtSupervisor.Location = New System.Drawing.Point(106, 62)
        Me.JHtxtSupervisor.Name = "JHtxtSupervisor"
        Me.JHtxtSupervisor.Size = New System.Drawing.Size(333, 23)
        Me.JHtxtSupervisor.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Localidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Supervisor"
        '
        'JHtxtLocalidad
        '
        Me.JHtxtLocalidad.Location = New System.Drawing.Point(106, 91)
        Me.JHtxtLocalidad.Name = "JHtxtLocalidad"
        Me.JHtxtLocalidad.Size = New System.Drawing.Size(333, 23)
        Me.JHtxtLocalidad.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Genero"
        '
        'JHcbxGenero
        '
        Me.JHcbxGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.JHcbxGenero.FormattingEnabled = True
        Me.JHcbxGenero.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.JHcbxGenero.Location = New System.Drawing.Point(103, 89)
        Me.JHcbxGenero.Name = "JHcbxGenero"
        Me.JHcbxGenero.Size = New System.Drawing.Size(333, 23)
        Me.JHcbxGenero.TabIndex = 2
        '
        'JHbtnAgregar
        '
        Me.JHbtnAgregar.Location = New System.Drawing.Point(280, 301)
        Me.JHbtnAgregar.Name = "JHbtnAgregar"
        Me.JHbtnAgregar.Size = New System.Drawing.Size(95, 23)
        Me.JHbtnAgregar.TabIndex = 3
        Me.JHbtnAgregar.Text = "Agregar"
        Me.JHbtnAgregar.UseVisualStyleBackColor = True
        '
        'JHdgvEncuestas
        '
        Me.JHdgvEncuestas.AllowUserToAddRows = False
        Me.JHdgvEncuestas.AllowUserToDeleteRows = False
        Me.JHdgvEncuestas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.JHdgvEncuestas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.JHdgvEncuestas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.JHdgvEncuestas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnFecha, Me.ColumnSupervisor, Me.ColumnLocalidad, Me.ColumnNumCenso, Me.ColumnNombre, Me.ColumnGenero, Me.ColumnEdad, Me.ColumnEstado})
        Me.JHdgvEncuestas.Location = New System.Drawing.Point(48, 383)
        Me.JHdgvEncuestas.Name = "JHdgvEncuestas"
        Me.JHdgvEncuestas.ReadOnly = True
        Me.JHdgvEncuestas.RowHeadersWidth = 62
        Me.JHdgvEncuestas.RowTemplate.Height = 25
        Me.JHdgvEncuestas.Size = New System.Drawing.Size(911, 245)
        Me.JHdgvEncuestas.TabIndex = 4
        '
        'ColumnFecha
        '
        Me.ColumnFecha.HeaderText = "Fecha"
        Me.ColumnFecha.MinimumWidth = 8
        Me.ColumnFecha.Name = "ColumnFecha"
        Me.ColumnFecha.ReadOnly = True
        '
        'ColumnSupervisor
        '
        Me.ColumnSupervisor.HeaderText = "Supervisor"
        Me.ColumnSupervisor.MinimumWidth = 8
        Me.ColumnSupervisor.Name = "ColumnSupervisor"
        Me.ColumnSupervisor.ReadOnly = True
        '
        'ColumnLocalidad
        '
        Me.ColumnLocalidad.HeaderText = "Localidad"
        Me.ColumnLocalidad.MinimumWidth = 8
        Me.ColumnLocalidad.Name = "ColumnLocalidad"
        Me.ColumnLocalidad.ReadOnly = True
        '
        'ColumnNumCenso
        '
        Me.ColumnNumCenso.HeaderText = "Numero de Censo"
        Me.ColumnNumCenso.MinimumWidth = 8
        Me.ColumnNumCenso.Name = "ColumnNumCenso"
        Me.ColumnNumCenso.ReadOnly = True
        '
        'ColumnNombre
        '
        Me.ColumnNombre.HeaderText = "Nombre"
        Me.ColumnNombre.MinimumWidth = 8
        Me.ColumnNombre.Name = "ColumnNombre"
        Me.ColumnNombre.ReadOnly = True
        '
        'ColumnGenero
        '
        Me.ColumnGenero.HeaderText = "Genero"
        Me.ColumnGenero.MinimumWidth = 8
        Me.ColumnGenero.Name = "ColumnGenero"
        Me.ColumnGenero.ReadOnly = True
        '
        'ColumnEdad
        '
        Me.ColumnEdad.HeaderText = "Edad"
        Me.ColumnEdad.MinimumWidth = 8
        Me.ColumnEdad.Name = "ColumnEdad"
        Me.ColumnEdad.ReadOnly = True
        '
        'ColumnEstado
        '
        Me.ColumnEstado.HeaderText = "Estado Civil"
        Me.ColumnEstado.MinimumWidth = 8
        Me.ColumnEstado.Name = "ColumnEstado"
        Me.ColumnEstado.ReadOnly = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(424, 350)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Lista de Encuestados"
        '
        'JHbtnModificar
        '
        Me.JHbtnModificar.Enabled = False
        Me.JHbtnModificar.Location = New System.Drawing.Point(398, 301)
        Me.JHbtnModificar.Name = "JHbtnModificar"
        Me.JHbtnModificar.Size = New System.Drawing.Size(95, 23)
        Me.JHbtnModificar.TabIndex = 11
        Me.JHbtnModificar.Text = "Modificar"
        Me.JHbtnModificar.UseVisualStyleBackColor = True
        '
        'JHbtnEliminar
        '
        Me.JHbtnEliminar.Enabled = False
        Me.JHbtnEliminar.Location = New System.Drawing.Point(512, 301)
        Me.JHbtnEliminar.Name = "JHbtnEliminar"
        Me.JHbtnEliminar.Size = New System.Drawing.Size(95, 23)
        Me.JHbtnEliminar.TabIndex = 12
        Me.JHbtnEliminar.Text = "Eliminar"
        Me.JHbtnEliminar.UseVisualStyleBackColor = True
        '
        'JHbtnResultados
        '
        Me.JHbtnResultados.Location = New System.Drawing.Point(315, 647)
        Me.JHbtnResultados.Name = "JHbtnResultados"
        Me.JHbtnResultados.Size = New System.Drawing.Size(95, 23)
        Me.JHbtnResultados.TabIndex = 13
        Me.JHbtnResultados.Text = "Resultados"
        Me.JHbtnResultados.UseVisualStyleBackColor = True
        '
        'JHbtnSalir
        '
        Me.JHbtnSalir.Location = New System.Drawing.Point(547, 647)
        Me.JHbtnSalir.Name = "JHbtnSalir"
        Me.JHbtnSalir.Size = New System.Drawing.Size(95, 23)
        Me.JHbtnSalir.TabIndex = 14
        Me.JHbtnSalir.Text = "Salir"
        Me.JHbtnSalir.UseVisualStyleBackColor = True
        '
        'ErrorProviderValidar
        '
        Me.ErrorProviderValidar.ContainerControl = Me
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.JHcbxEstado)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.JHtxtNumCenso)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.JHtxtEdad)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.JHtxtNombre)
        Me.GroupBox2.Controls.Add(Me.JHcbxGenero)
        Me.GroupBox2.Location = New System.Drawing.Point(512, 94)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(465, 190)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Encuestado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 15)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Estado Civil"
        '
        'JHcbxEstado
        '
        Me.JHcbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.JHcbxEstado.FormattingEnabled = True
        Me.JHcbxEstado.Items.AddRange(New Object() {"Soltero(a)", "Casado(a)", "Viudo(a)", "Divorciado(a)"})
        Me.JHcbxEstado.Location = New System.Drawing.Point(103, 146)
        Me.JHcbxEstado.Name = "JHcbxEstado"
        Me.JHcbxEstado.Size = New System.Drawing.Size(333, 23)
        Me.JHcbxEstado.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(30, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 30)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Numero " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Censo"
        '
        'JHtxtNumCenso
        '
        Me.JHtxtNumCenso.Location = New System.Drawing.Point(103, 31)
        Me.JHtxtNumCenso.Name = "JHtxtNumCenso"
        Me.JHtxtNumCenso.Size = New System.Drawing.Size(333, 23)
        Me.JHtxtNumCenso.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(50, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 15)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Edad"
        '
        'JHtxtEdad
        '
        Me.JHtxtEdad.Location = New System.Drawing.Point(103, 117)
        Me.JHtxtEdad.Name = "JHtxtEdad"
        Me.JHtxtEdad.Size = New System.Drawing.Size(333, 23)
        Me.JHtxtEdad.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 15)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Nombre"
        '
        'JHtxtNombre
        '
        Me.JHtxtNombre.Location = New System.Drawing.Point(103, 60)
        Me.JHtxtNombre.Name = "JHtxtNombre"
        Me.JHtxtNombre.Size = New System.Drawing.Size(333, 23)
        Me.JHtxtNombre.TabIndex = 10
        '
        'JHbtnPresentacion
        '
        Me.JHbtnPresentacion.Location = New System.Drawing.Point(434, 647)
        Me.JHbtnPresentacion.Name = "JHbtnPresentacion"
        Me.JHbtnPresentacion.Size = New System.Drawing.Size(95, 23)
        Me.JHbtnPresentacion.TabIndex = 16
        Me.JHbtnPresentacion.Text = "Presentacion"
        Me.JHbtnPresentacion.UseVisualStyleBackColor = True
        '
        'JHtime
        '
        Me.JHtime.Interval = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(332, 51)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(310, 21)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Censo de Población: Provincia de Panamá"
        '
        'JHbtnLimpiar
        '
        Me.JHbtnLimpiar.Location = New System.Drawing.Point(623, 301)
        Me.JHbtnLimpiar.Name = "JHbtnLimpiar"
        Me.JHbtnLimpiar.Size = New System.Drawing.Size(95, 23)
        Me.JHbtnLimpiar.TabIndex = 18
        Me.JHbtnLimpiar.Text = "Limpiar"
        Me.JHbtnLimpiar.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(379, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(228, 21)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "CENSO TRIBUNAL ELECTORAL"
        '
        'JHfrmEncuestas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(989, 682)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.JHbtnLimpiar)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.JHbtnPresentacion)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.JHbtnSalir)
        Me.Controls.Add(Me.JHbtnResultados)
        Me.Controls.Add(Me.JHbtnEliminar)
        Me.Controls.Add(Me.JHbtnModificar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.JHdgvEncuestas)
        Me.Controls.Add(Me.JHbtnAgregar)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "JHfrmEncuestas"
        Me.Text = "Sistema de Encuestas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.JHdgvEncuestas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderValidar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents JHtxtFecha As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents JHtxtLocalidad As TextBox
    Friend WithEvents JHcbxGenero As ComboBox
    Friend WithEvents JHbtnAgregar As Button
    Friend WithEvents JHdgvEncuestas As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents JHbtnModificar As Button
    Friend WithEvents JHbtnEliminar As Button
    Friend WithEvents JHbtnResultados As Button
    Friend WithEvents JHbtnSalir As Button
    Friend WithEvents ErrorProviderValidar As ErrorProvider
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents JHtxtEdad As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents JHtxtNombre As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label9 As Label
    Friend WithEvents JHtxtNumCenso As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents JHcbxEstado As ComboBox
    Friend WithEvents ColumnFecha As DataGridViewTextBoxColumn
    Friend WithEvents ColumnSupervisor As DataGridViewTextBoxColumn
    Friend WithEvents ColumnLocalidad As DataGridViewTextBoxColumn
    Friend WithEvents ColumnNumCenso As DataGridViewTextBoxColumn
    Friend WithEvents ColumnNombre As DataGridViewTextBoxColumn
    Friend WithEvents ColumnGenero As DataGridViewTextBoxColumn
    Friend WithEvents ColumnEdad As DataGridViewTextBoxColumn
    Friend WithEvents ColumnEstado As DataGridViewTextBoxColumn
    Friend WithEvents JHbtnPresentacion As Button
    Friend WithEvents JHtime As Timer
    Friend WithEvents JHtxtSupervisor As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents JHbtnLimpiar As Button
    Friend WithEvents Label11 As Label
End Class
