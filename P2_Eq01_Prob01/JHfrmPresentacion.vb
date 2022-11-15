Public Class JHfrmPresentacion
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
End Class