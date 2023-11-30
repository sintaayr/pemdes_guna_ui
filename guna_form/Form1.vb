Public Class FormDashboard
    Private Sub btnReservation_Click(sender As Object, e As EventArgs) Handles btnReservation.Click
        transisi.HideSync(PanelLocation)
        transisi.ShowSync(PanelReservation)
    End Sub

    Private Sub btnLocation_Click(sender As Object, e As EventArgs) Handles btnLocation.Click
        transisi.HideSync(PanelReservation)
        transisi.ShowSync(PanelLocation)
    End Sub

    Private Sub linkLogout_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkLogout.LinkClicked
        Me.Hide()
        FormLogin.Show()
        FormLogin.panelLogin.Visible = True
    End Sub
End Class



