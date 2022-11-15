
Public Class JHfrmEncuestas

#Region "Variables Globales"
    Dim f As Date
    Dim supervisor, localidad, numCenso, nombre, genero, edad, estadoCivil, fecha As String
    Dim validarCampos, validarNumCenso As Boolean
    Dim soltero, casado, viudo, divorciado As Integer
    Dim Fila, columna As String
    Dim TotalEncuestados As Integer = 0
    Dim promedio As Integer = 0
    Dim edades As Integer = 0
    Dim TotalMujeres As Integer = 0
    Dim MujeresSobrePromedio As Integer = 0
    Dim TotalHombres As Integer = 0
    Dim HombresCasados As Integer = 0
#End Region

    'FUNCIONES PRINCIPALES'
#Region "Boton Agregar"
    Private Sub JHbtnAgregar_Click(sender As Object, e As EventArgs) Handles JHbtnAgregar.Click
        fecha = JHtxtFecha.Text.ToString()
        supervisor = JHtxtSupervisor.Text
        localidad = JHtxtLocalidad.Text
        numCenso = JHtxtNumCenso.Text
        nombre = JHtxtNombre.Text
        genero = JHcbxGenero.Text
        edad = JHtxtEdad.Text
        estadoCivil = JHcbxEstado.Text



        validarCampos = ValidarDatos(fecha, supervisor, localidad, numCenso, nombre, genero, edad, estadoCivil)

        If validarCampos = True Then

            validarNumCenso = ValidarNumeroCenso(numCenso)
            If validarNumCenso = True Then
                JHdgvEncuestas.Rows.Add(fecha, supervisor, localidad, numCenso, nombre, genero, edad, estadoCivil)
                MsgBox("Contacto registrado exitosamente", MsgBoxStyle.Information, "Informacion")
                LimpiarCampos()
            End If
        End If
    End Sub
#End Region

#Region "Boton Modificar"
    'Boton Modificar'
    Private Sub JHbtnModificar_Click(sender As Object, e As EventArgs) Handles JHbtnModificar.Click
        fecha = JHtxtFecha.Text.ToString()
        supervisor = JHtxtSupervisor.Text
        localidad = JHtxtLocalidad.Text
        numCenso = JHtxtNumCenso.Text
        nombre = JHtxtNombre.Text
        genero = JHcbxGenero.Text
        edad = JHtxtEdad.Text
        estadoCivil = JHcbxEstado.Text
        validarCampos = ValidarDatos(fecha, supervisor, localidad, numCenso, nombre, genero, edad, estadoCivil)
        Fila = JHdgvEncuestas.CurrentRow.Index
        validarNumCenso = True
        If validarCampos = True Then
            If numCenso <> JHdgvEncuestas.Rows(Fila).Cells("ColumnNumCenso").Value Then
                validarNumCenso = ValidarNumeroCenso(numCenso)
            End If

            If validarNumCenso = True Then
                JHdgvEncuestas.Rows(Fila).Cells("ColumnFecha").Value = fecha
                JHdgvEncuestas.Rows(Fila).Cells("ColumnSupervisor").Value = supervisor
                JHdgvEncuestas.Rows(Fila).Cells("ColumnLocalidad").Value = localidad
                JHdgvEncuestas.Rows(Fila).Cells("ColumnNumCenso").Value = numCenso
                JHdgvEncuestas.Rows(Fila).Cells("ColumnNombre").Value = nombre
                JHdgvEncuestas.Rows(Fila).Cells("ColumnGenero").Value = genero
                JHdgvEncuestas.Rows(Fila).Cells("ColumnEdad").Value = edad
                JHdgvEncuestas.Rows(Fila).Cells("ColumnEstado").Value = estadoCivil

                MsgBox("Modificacion exitosa", MsgBoxStyle.Information, "Informacion")
                ActivarBotones()
                LimpiarCampos()
            Else

            End If
        End If
    End Sub

    'Seleccionar fila a modificar en el dgv'
    Private Sub JHdgvEncuestas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles JHdgvEncuestas.CellDoubleClick
        Fila = JHdgvEncuestas.CurrentRow.Index
        JHtxtFecha.Text = JHdgvEncuestas.Rows(Fila).Cells("ColumnFecha").Value
        JHtxtSupervisor.Text = JHdgvEncuestas.Rows(Fila).Cells("ColumnSupervisor").Value
        JHtxtLocalidad.Text = JHdgvEncuestas.Rows(Fila).Cells("ColumnLocalidad").Value
        JHtxtNumCenso.Text = JHdgvEncuestas.Rows(Fila).Cells("ColumnNumCenso").Value
        JHtxtNombre.Text = JHdgvEncuestas.Rows(Fila).Cells("ColumnNombre").Value
        JHcbxGenero.Text = JHdgvEncuestas.Rows(Fila).Cells("ColumnGenero").Value
        JHtxtEdad.Text = JHdgvEncuestas.Rows(Fila).Cells("ColumnEdad").Value
        JHcbxEstado.Text = JHdgvEncuestas.Rows(Fila).Cells("ColumnEstado").Value
        DesactivarBotones()
    End Sub
#End Region

#Region "Boton Eliminar"
    Private Sub JHbtnEliminar_Click(sender As Object, e As EventArgs) Handles JHbtnEliminar.Click
        Dim confirmacion As String
        confirmacion = MsgBox("Seguro que desea eliminar esta encuesta?", MsgBoxStyle.YesNo, "Informacion")
        If confirmacion = vbYes Then
            Fila = JHdgvEncuestas.CurrentRow.Index
            JHdgvEncuestas.Rows.Remove(JHdgvEncuestas.Rows(Fila))
            MsgBox("Eliminacion exitosa", MsgBoxStyle.Information, "Informacion")
            ActivarBotones()
            LimpiarCampos()
        End If
    End Sub
#End Region

#Region "Boton Guardar"
    Private Sub JHbtnResultados_Click(sender As Object, e As EventArgs) Handles JHbtnResultados.Click
        Dim genero As String
        Dim edad As Integer
        Dim nombre As String


        TotalEncuestados = JHdgvEncuestas.Rows.Count

        'Fila = JHdgvEncuestas.CurrentRow.Index
        For y = 0 To JHdgvEncuestas.RowCount - 1
            genero = JHdgvEncuestas.Rows(y).Cells("ColumnGenero").Value
            edad = JHdgvEncuestas.Rows(y).Cells("ColumnEdad").Value
            edades += edad
            promedio = edades / TotalEncuestados
            nombre = JHdgvEncuestas.Rows(y).Cells("ColumnNombre").Value
            estadoCivil = JHdgvEncuestas.Rows(y).Cells("ColumnEstado").Value

            If genero = "Masculino" Then
                TotalHombres = TotalHombres + 1

                If estadoCivil = "Casado(a)" And edad >= 20 And edad <= 35 Then
                    HombresCasados += 1
                    AAfrmResultados.AAdgvHombres.Rows.Add(nombre, edad)
                End If
            End If


            If estadoCivil = "Soltero(a)" Then
                soltero = soltero + 1
            ElseIf estadoCivil = "Viudo(a)" Then
                viudo = viudo + 1
            ElseIf estadoCivil = "Casado(a)" Then
                casado = casado + 1
            ElseIf estadoCivil = "Divorciado(a)" Then
                divorciado = divorciado + 1
            End If

        Next

        For y = 0 To JHdgvEncuestas.RowCount - 1
            genero = JHdgvEncuestas.Rows(y).Cells("ColumnGenero").Value
            nombre = JHdgvEncuestas.Rows(y).Cells("ColumnNombre").Value
            edad = JHdgvEncuestas.Rows(y).Cells("ColumnEdad").Value

            If genero = "Femenino" Then
                TotalMujeres = TotalMujeres + 1

                If edad > promedio Then
                    MujeresSobrePromedio = MujeresSobrePromedio + 1
                    AAfrmResultados.AADgvMujeresSobrePromedio.Rows.Add(nombre, edad)
                End If
            End If

        Next

        AAfrmResultados.JHDgvEstadoCivil.Rows.Add(soltero, casado, viudo, divorciado)
        AAfrmResultados.AADgvTotal.Rows.Add(TotalEncuestados, TotalMujeres, TotalHombres, promedio, MujeresSobrePromedio, HombresCasados)
        AAfrmResultados.Show()
    End Sub
#End Region

#Region "Boton Salir"
    Private Sub JHbtnSalir_Click(sender As Object, e As EventArgs) Handles JHbtnSalir.Click
        Dim confirmacion As String
        confirmacion = MsgBox("Seguro que desea salir?", MsgBoxStyle.YesNo, "Informacion")
        If confirmacion = vbYes Then
            'GuardarDatos()
        End If
        Me.Close()
        End
    End Sub

#End Region

    'FUNCIONES EXTRAS'

#Region "Validar Campos Vacios"
    Function ValidarDatos(fecha As String, supervisor As String, localidad As String, numeroCenso As String, nombre As String, genero As String, edad As String, estadoCivil As String) As Boolean
        If fecha = "" Then
            MsgBox("Ingrese la fecha, no puede ir vacio este campo", MsgBoxStyle.Critical, "Informacion")
            ErrorProviderValidar.SetError(JHtxtFecha, "Ingrese fecha")
            validarCampos = False
        ElseIf supervisor = "" Then
            MsgBox("Ingrese al supervisor encargado, no puede ir vacio este campo", MsgBoxStyle.Critical, "Informacion")
            ErrorProviderValidar.SetError(JHtxtSupervisor, "Ingrese supervisor")
            validarCampos = False
        ElseIf localidad = "" Then
            MsgBox("Ingrese la localidad, no puede ir vacio este campo", MsgBoxStyle.Critical, "Informacion")
            ErrorProviderValidar.SetError(JHtxtLocalidad, "Ingrese localidad")
            validarCampos = False
        ElseIf numeroCenso = "" Then
            MsgBox("Ingrese el numero de censo, no puede ir vacio este campo", MsgBoxStyle.Critical, "Informacion")
            ErrorProviderValidar.SetError(JHtxtNumCenso, "Ingrese numero de censo")
            validarCampos = False
        ElseIf nombre = "" Then
            MsgBox("Ingrese el nombre, no puede ir vacio este campo", MsgBoxStyle.Critical, "Informacion")
            ErrorProviderValidar.SetError(JHtxtNombre, "Ingrese nombre")
            validarCampos = False
        ElseIf genero = "" Then
            MsgBox("Seleccione el genero, no puede ir sin seleccion", MsgBoxStyle.Critical, "Informacion")
            ErrorProviderValidar.SetError(JHcbxGenero, "Seleccione genero")
            validarCampos = False
        ElseIf edad = "" Then
            MsgBox("Ingrese la edad, no puede ir vacio este campo", MsgBoxStyle.Critical, "Informacion")
            ErrorProviderValidar.SetError(JHtxtEdad, "Ingrese edad")
            validarCampos = False
        ElseIf edad > 120 Or edad < 0 Then
            MsgBox("Edad no valida, ingrese una edad correcta", MsgBoxStyle.Information, "Informacion")
            ErrorProviderValidar.SetError(JHtxtEdad, "Ingrese una edad correcta")
            validarCampos = False
        ElseIf estadoCivil = "" Then
            MsgBox("Seleccione el estado civil, no puede ir sin seleccion", MsgBoxStyle.Critical, "Informacion")
            ErrorProviderValidar.SetError(JHcbxEstado, "Seleccione estado civil")
            validarCampos = False
        Else
            validarCampos = True
            ErrorProviderValidar.SetError(JHtxtFecha, "")
            ErrorProviderValidar.SetError(JHtxtSupervisor, "")
            ErrorProviderValidar.SetError(JHtxtLocalidad, "")
            ErrorProviderValidar.SetError(JHtxtNumCenso, "")
            ErrorProviderValidar.SetError(JHtxtNombre, "")
            ErrorProviderValidar.SetError(JHcbxGenero, "")
            ErrorProviderValidar.SetError(JHtxtEdad, "")
            ErrorProviderValidar.SetError(JHcbxEstado, "")
        End If
        Return validarCampos
    End Function

#End Region

#Region "Limpiar Campos"
    Private Sub LimpiarCampos()
        JHtxtFecha.Text = ""
        JHtxtSupervisor.SelectedIndex = -1
        JHtxtLocalidad.Text = ""
        JHtxtNumCenso.Text = ""
        JHtxtNombre.Text = ""
        JHcbxGenero.SelectedIndex = -1
        JHtxtEdad.Text = ""
        JHcbxEstado.SelectedIndex = -1
    End Sub

    Private Sub JHbtnLimpiar_Click(sender As Object, e As EventArgs) Handles JHbtnLimpiar.Click
        LimpiarCampos()
    End Sub
#End Region

#Region "Activar y Desactivar botones"
    Private Sub ActivarBotones()
        JHbtnAgregar.Enabled = True
        JHbtnResultados.Enabled = True
        JHbtnModificar.Enabled = False
        JHbtnEliminar.Enabled = False
    End Sub

    Private Sub DesactivarBotones()
        JHbtnAgregar.Enabled = False
        JHbtnResultados.Enabled = False
        JHbtnModificar.Enabled = True
        JHbtnEliminar.Enabled = True
    End Sub
#End Region

#Region "Validar Numero de Censo"
    Function ValidarNumeroCenso(num As String) As Boolean
        validarNumCenso = True
        For y = 0 To JHdgvEncuestas.RowCount - 1
            If num = JHdgvEncuestas.Rows(y).Cells("ColumnNumCenso").Value Then
                MsgBox("Encuestado Existente", MsgBoxStyle.Critical, "Informacion")
                ErrorProviderValidar.SetError(JHtxtNumCenso, "Ingrese numero nuevo")
                validarNumCenso = False
                Exit For
            Else
                ErrorProviderValidar.SetError(JHtxtNumCenso, "")
                validarNumCenso = True
            End If
        Next
        Return validarNumCenso
    End Function
#End Region

#Region "Validar tipo de teclas"
    Private Sub JHtxtNumCenso_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles JHtxtNumCenso.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub JHtxtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles JHtxtNombre.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub JHtxtEdad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles JHtxtEdad.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
#End Region

#Region "Presentacion"
    Private Sub JHbtnPresentacion_Click(sender As Object, e As EventArgs) Handles JHbtnPresentacion.Click
        Me.Hide()
        JHfrmPresentacion.Show()
    End Sub
#End Region

#Region "Mostrar Fecha Actual"
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles JHtime.Tick
        JHtxtFecha.Text = DateTime.Now.ToShortDateString
    End Sub

    Private Sub JHfrmEncuestas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        JHtime.Enabled = True
    End Sub
#End Region

End Class
