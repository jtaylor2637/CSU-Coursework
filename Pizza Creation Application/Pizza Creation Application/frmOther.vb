Public Class frmOther

    Dim decCrustPrice As Decimal
    Dim decTotalValue As Decimal
    Dim decExtraToppings As Decimal
    Dim strPizzaDescription As String
    Dim decSizePrice As Decimal
    Dim blnExtraMeat As Boolean
    Dim blnExtraVeggies As Boolean
    Dim decPizzaPrice As Decimal
    Public Shared objPizza As Pizza
    Dim decDrinkPrice As Decimal = 2.89
    Dim decBrowniePrice As Decimal = 3.49
    Dim decCheesyPrice As Decimal = 3.89
    Dim decCookiePrice As Decimal = 2.49

    Private Sub frmOther_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objPizza = frmVeggies.objPizza
        If objPizza.getSize() = "small" Then
            decSizePrice = 4.89
        ElseIf objPizza.getSize() = "medium"
            decSizePrice = 5.89
        ElseIf objPizza.getSize() = "large"
            decSizePrice = 6.89
        ElseIf objPizza.getSize() = "extra large"
            decSizePrice = 7.89
        End If

        If objPizza.getExtraMeat() = True Then
            blnExtraMeat = True
            decExtraToppings += 1.0
        End If

        If objPizza.getExtraVeggies() = True Then
            blnExtraVeggies = True
            decExtraToppings += 1.0
        End If

        If objPizza.getCrust() = "pan" Then
            decCrustPrice += 0.8
        ElseIf objPizza.getCrust() = "thin crust"
            decCrustPrice += 0.75
        ElseIf objPizza.getCrust() = "deep dish"
            decCrustPrice += 1.0
        ElseIf objPizza.getCrust() = "hand tossed"
            decCrustPrice += 1.25
        End If


        decPizzaPrice = decSizePrice + decExtraToppings + decCrustPrice
        decTotalValue = decPizzaPrice
        lblPizza.Text = "Pizza - " & (decPizzaPrice.ToString("C2"))
        lblTotal.Text = (decTotalValue.ToString("C2"))
        lblPizzaDescription.Visible = True
        lblPizzaDescription.Text = objPizza.getDescription()
    End Sub

    Private Sub chkDrinks_CheckedChanged(sender As Object, e As EventArgs) Handles chkDrinks.CheckedChanged
        If chkDrinks.Checked = True Then
            lblDrinks.Visible = True
            objPizza.AddDrinks()
            decTotalValue += decDrinkPrice
            lblTotal.Text = (decTotalValue.ToString("C2"))
        Else
            lblDrinks.Visible = False
            objPizza.removeDrinks()
            decTotalValue -= decDrinkPrice
            lblTotal.Text = (decTotalValue.ToString("C2"))
        End If


    End Sub

    Private Sub chkBrownie_CheckedChanged(sender As Object, e As EventArgs) Handles chkBrownie.CheckedChanged
        If chkBrownie.Checked = True Then
            lblBrownie.Visible = True
            objPizza.AddBrownie()
            decTotalValue += decBrowniePrice
            lblTotal.Text = (decTotalValue.ToString("C2"))
        Else
            lblBrownie.Visible = False
            objPizza.removeBrownie()
            decTotalValue -= decBrowniePrice
            lblTotal.Text = (decTotalValue.ToString("C2"))
        End If
    End Sub

    Private Sub chkCheesyBread_CheckedChanged(sender As Object, e As EventArgs) Handles chkCheesyBread.CheckedChanged
        If chkCheesyBread.Checked = True Then
            lblCheesyBread.Visible = True
            objPizza.AddCheesyBread()
            decTotalValue += decCheesyPrice
            lblTotal.Text = (decTotalValue.ToString("C2"))
        Else
            lblCheesyBread.Visible = False
            objPizza.removeCheesyBread()
            decTotalValue -= decCheesyPrice
            lblTotal.Text = (decTotalValue.ToString("C2"))
        End If
    End Sub

    Private Sub chkCookie_CheckedChanged(sender As Object, e As EventArgs) Handles chkCookie.CheckedChanged
        If chkCookie.Checked = True Then
            lblCookie.Visible = True
            objPizza.AddCookie()
            decTotalValue += decCookiePrice
            lblTotal.Text = (decTotalValue.ToString("C2"))
        Else
            lblCookie.Visible = False
            objPizza.removeCookies()
            decTotalValue -= decCookiePrice
            lblTotal.Text = (decTotalValue.ToString("C2"))
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim frmSixth As New frmOrder
        Hide()
        frmSixth.ShowDialog()
    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        Application.Restart()
    End Sub
End Class