Public Class Form2
    Dim up_extra_fingers_price As Integer = 20
    Dim up_grandma_price As Integer = 15

    Private Sub btnBuyExtraFingers_Click(sender As Object, e As EventArgs) Handles btnBuyExtraFingers.Click
        If coins >= up_extra_fingers_price Then
            up_extra_fingers += 1
            coin_click += up_extra_fingers
            coins -= up_extra_fingers_price
            up_extra_fingers_price *= 1.8
            lblExtraFingers.Text = "Adds one more cookie per click: " & Convert.ToString(up_extra_fingers)
            lblExtraFingersPrice.Text = "Extra Fingers: " & Convert.ToString(up_extra_fingers_price)
        End If
        If up_extra_fingers >= 10 Then
            btnBuyExtraFingers.Enabled = False
        End If
    End Sub

    Private Sub btnBuyGrandma_Click(sender As Object, e As EventArgs) Handles btnBuyGrandma.Click
        If coins >= up_grandma_price Then
            up_grandma += 1
            coins -= up_grandma_price
            up_grandma_price *= 1.7
            lblExtraFingers.Text = "Makes one cookie every ten seconds: " & Convert.ToString(up_extra_fingers)
            lblExtraFingersPrice.Text = "Grandmas: " & Convert.ToString(up_extra_fingers_price)
        End If
        If up_grandma >= 50 Then
            btnBuyGrandma.Enabled = False
        End If
    End Sub
End Class