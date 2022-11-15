Public Class AAfrmResultados
    Private Sub AAfrmResultados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles AADgvTotal.CellContentClick

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles JHDgvEstadoCivil.CellContentClick

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles AAbtnVolver.Click
        Me.Hide()
        JHfrmEncuestas.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles AAbtnSalir.Click
        End
    End Sub

    Private Sub AADgvMujeresSobrePromedio_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles AADgvMujeresSobrePromedio.CellContentClick

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class