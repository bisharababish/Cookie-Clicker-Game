Public Class Form1
    Private Sub btnUpgrades_Click(sender As Object, e As EventArgs) Handles btnUpgrades.Click
        Dim f2 As New Form2
        f2.Show()
    End Sub

    Private Sub Cookie_Click(sender As Object, e As EventArgs) Handles Cookie.Click
        coins += coin_click * coin_multy
        lblCoins.Text = Convert.ToString(coins)
    End Sub

    Private Sub UpdateTimer_Tick(sender As Object, e As EventArgs) Handles UpdateTimer.Tick
        lblCoins.Text = Convert.ToString(coins)
    End Sub
End Class
