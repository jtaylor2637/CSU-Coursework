Public Class frmMeats
    Dim strMeatTopping1 As String

    Dim strMeatTopping2 As String

    Dim blnNoMeat As Boolean
    Dim blnExtraMeat As Boolean
    Dim currentImage As Image
    Public Shared objPizza As Pizza
    Private Sub frmMeats_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        objPizza = frmSauces.objPizza
        currentImage = My.Resources.plaincheese
        cboTopping1.SelectedIndex = 0
        cboTopping2.SelectedIndex = 0

        blnNoMeat = True
        blnExtraMeat = False
        radNone.Checked = True
        picPizza.Image = currentImage
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        Dim frmSecond As New frmSauces
        Hide()
        frmSecond.ShowDialog()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        objPizza.SetMeats(cboTopping1.SelectedItem.ToString(), cboTopping2.SelectedItem.ToString(), blnExtraMeat)
        Dim frmFourth As New frmVeggies
        Hide()
        frmFourth.ShowDialog()
    End Sub

    Private Sub radNone_CheckedChanged(sender As Object, e As EventArgs) Handles radNone.CheckedChanged
        If radNone.Checked = True Then
            cboTopping1.SelectedIndex = 0
            cboTopping2.SelectedIndex = 0
        End If
        currentImage = My.Resources.plaincheese
        strMeatTopping1 = "none"
        strMeatTopping2 = "none"
        picPizza.Image = currentImage
    End Sub

    Private Sub radRegular_CheckedChanged(sender As Object, e As EventArgs) Handles radRegular.CheckedChanged
        blnNoMeat = False
        blnExtraMeat = False
    End Sub

    Private Sub radDouble_CheckedChanged(sender As Object, e As EventArgs) Handles radDouble.CheckedChanged

        blnExtraMeat = True
        blnNoMeat = False
    End Sub

    Private Sub cboTopping1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTopping1.SelectedIndexChanged

        If cboTopping1.SelectedIndex = 0 And cboTopping2.SelectedIndex = 0 Then
            currentImage = My.Resources.plaincheese
            strMeatTopping1 = "none"
            radNone.Checked = True
            picPizza.Image = currentImage

        ElseIf cboTopping1.SelectedIndex = 0 And cboTopping2.SelectedIndex <> 0 Then
            If cboTopping2.SelectedIndex = 1 Then
                strMeatTopping2 = "pepperoni"
                radRegular.Checked = True
                currentImage = My.Resources.pepperoni
                picPizza.Image = currentImage
            ElseIf cboTopping2.SelectedIndex = 2
                strMeatTopping2 = "beef"
                radRegular.Checked = True
                currentImage = My.Resources.beef
                picPizza.Image = currentImage
            ElseIf cboTopping2.SelectedIndex = 3
                strMeatTopping2 = "chicken"
                radRegular.Checked = True
                currentImage = My.Resources.chicken
                picPizza.Image = currentImage
            ElseIf cboTopping2.SelectedIndex = 4
                strMeatTopping2 = "sausage"
                radRegular.Checked = True
                currentImage = My.Resources.sausage
                picPizza.Image = currentImage
            ElseIf cboTopping2.SelectedIndex = 5
                strMeatTopping2 = "pork"
                radRegular.Checked = True
                currentImage = My.Resources.pork
                picPizza.Image = currentImage
            Else
                currentImage = My.Resources.plaincheese
                picPizza.Image = currentImage
                radNone.Checked = True
                strMeatTopping1 = "none"
                strMeatTopping2 = "none"
                blnNoMeat = True
            End If

        ElseIf cboTopping1.SelectedIndex = 1 Then

            radRegular.Checked = True
            strMeatTopping1 = "pepperoni"

            If (cboTopping2.SelectedIndex = 0 Or cboTopping2.SelectedIndex = 1) Then
                currentImage = My.Resources.pepperoni
                picPizza.Image = currentImage
                If cboTopping2.SelectedIndex = 1 Then
                    radDouble.Checked = True
                    blnExtraMeat = True
                End If
            ElseIf cboTopping2.SelectedIndex = 2
                currentImage = My.Resources.pepperonibeef
                picPizza.Image = currentImage
            ElseIf cboTopping2.SelectedIndex = 3
                currentImage = My.Resources.pepperonichicken
                picPizza.Image = currentImage
            ElseIf cboTopping2.SelectedIndex = 4
                currentImage = My.Resources.pepperonisausage
                picPizza.Image = currentImage
            ElseIf cboTopping2.SelectedIndex = 5
                currentImage = My.Resources.pepperonipork
                picPizza.Image = currentImage
            Else
                currentImage = My.Resources.pepperoni
                picPizza.Image = currentImage
            End If

        ElseIf cboTopping1.SelectedIndex = 2 Then

            radRegular.Checked = True
            strMeatTopping1 = "beef"

            If (cboTopping2.SelectedIndex = 0 Or cboTopping2.SelectedIndex = 2) Then
                currentImage = My.Resources.beef
                picPizza.Image = currentImage
                If cboTopping2.SelectedIndex = 2 Then
                    radDouble.Checked = True
                    blnExtraMeat = True
                End If
            ElseIf cboTopping2.SelectedIndex = 1
                currentImage = My.Resources.pepperonibeef
                picPizza.Image = currentImage
            ElseIf cboTopping2.SelectedIndex = 3
                currentImage = My.Resources.chickenbeef
                picPizza.Image = currentImage
            ElseIf cboTopping2.SelectedIndex = 4
                currentImage = My.Resources.sausagebeef
                picPizza.Image = currentImage
            ElseIf cboTopping2.SelectedIndex = 5
                currentImage = My.Resources.beefpork
                picPizza.Image = currentImage
            Else
                currentImage = My.Resources.beef
                picPizza.Image = currentImage
            End If

        ElseIf cboTopping1.SelectedIndex = 3 Then

            radRegular.Checked = True
            strMeatTopping1 = "chicken"

            If (cboTopping2.SelectedIndex = 0 Or cboTopping2.SelectedIndex = 3) Then
                currentImage = My.Resources.chicken
                picPizza.Image = currentImage
                If cboTopping2.SelectedIndex = 3 Then
                    radDouble.Checked = True
                    blnExtraMeat = True
                End If
            ElseIf cboTopping2.SelectedIndex = 2
                currentImage = My.Resources.chickenbeef
                picPizza.Image = currentImage
            ElseIf cboTopping2.SelectedIndex = 1
                currentImage = My.Resources.pepperonichicken
                picPizza.Image = currentImage
            ElseIf cboTopping2.SelectedIndex = 4
                currentImage = My.Resources.sausagechicken
                picPizza.Image = currentImage
            ElseIf cboTopping2.SelectedIndex = 5
                currentImage = My.Resources.chickenpork
                picPizza.Image = currentImage
            Else
                currentImage = My.Resources.chicken
                picPizza.Image = currentImage
            End If

        ElseIf cboTopping1.SelectedIndex = 4 Then

            radRegular.Checked = True
            strMeatTopping1 = "sausage"

            If (cboTopping2.SelectedIndex = 0 Or cboTopping2.SelectedIndex = 4) Then
                currentImage = My.Resources.sausage
                picPizza.Image = currentImage
                If cboTopping2.SelectedIndex = 4 Then
                    radDouble.Checked = True
                    blnExtraMeat = True
                End If
            ElseIf cboTopping2.SelectedIndex = 2
                currentImage = My.Resources.sausagebeef
                picPizza.Image = currentImage
            ElseIf cboTopping2.SelectedIndex = 3
                currentImage = My.Resources.sausagechicken
                picPizza.Image = currentImage
            ElseIf cboTopping2.SelectedIndex = 1
                currentImage = My.Resources.pepperonisausage
                picPizza.Image = currentImage
            ElseIf cboTopping2.SelectedIndex = 5
                currentImage = My.Resources.sausagepork
                picPizza.Image = currentImage
            Else
                currentImage = My.Resources.sausage
                picPizza.Image = currentImage
            End If

        ElseIf cboTopping1.SelectedIndex = 5 Then

            radRegular.Checked = True
            strMeatTopping1 = "pork"

            If (cboTopping2.SelectedIndex = 0 Or cboTopping2.SelectedIndex = 5) Then
                currentImage = My.Resources.pork
                picPizza.Image = currentImage
                If cboTopping2.SelectedIndex = 5 Then
                    radDouble.Checked = True
                    blnExtraMeat = True
                End If
            ElseIf cboTopping2.SelectedIndex = 2
                currentImage = My.Resources.beefpork
                picPizza.Image = currentImage
            ElseIf cboTopping2.SelectedIndex = 3
                currentImage = My.Resources.chickenpork
                picPizza.Image = currentImage
            ElseIf cboTopping2.SelectedIndex = 4
                currentImage = My.Resources.sausagepork
                picPizza.Image = currentImage
            ElseIf cboTopping2.SelectedIndex = 1
                currentImage = My.Resources.pepperonipork
                picPizza.Image = currentImage
            Else
                currentImage = My.Resources.pork
                picPizza.Image = currentImage
            End If
        Else
            currentImage = My.Resources.plaincheese
            picPizza.Image = currentImage
            radNone.Checked = True
            blnExtraMeat = False
            blnNoMeat = True
            strMeatTopping1 = "none"
            strMeatTopping2 = "none"
        End If
    End Sub

    Private Sub cboTopping2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTopping2.SelectedIndexChanged
        If cboTopping2.SelectedIndex = 0 And cboTopping1.SelectedIndex = 0 Then
            currentImage = My.Resources.plaincheese
            strMeatTopping2 = "none"
            radNone.Checked = True
            picPizza.Image = currentImage
        ElseIf cboTopping2.SelectedIndex = 0 And cboTopping1.SelectedIndex <> 0 Then
            If cboTopping1.SelectedIndex = 1 Then
                strMeatTopping1 = "pepperoni"
                radRegular.Checked = True
                currentImage = My.Resources.pepperoni
                picPizza.Image = currentImage
            ElseIf cboTopping1.SelectedIndex = 2
                strMeatTopping1 = "beef"
                radRegular.Checked = True
                currentImage = My.Resources.beef
                picPizza.Image = currentImage
            ElseIf cboTopping1.SelectedIndex = 3
                strMeatTopping1 = "chicken"
                radRegular.Checked = True
                currentImage = My.Resources.chicken
                picPizza.Image = currentImage
            ElseIf cboTopping1.SelectedIndex = 4
                strMeatTopping1 = "sausage"
                radRegular.Checked = True
                currentImage = My.Resources.sausage
                picPizza.Image = currentImage
            ElseIf cboTopping1.SelectedIndex = 5
                strMeatTopping1 = "pork"
                radRegular.Checked = True
                currentImage = My.Resources.pork
                picPizza.Image = currentImage
            End If

        ElseIf cboTopping2.SelectedIndex = 1 Then

            radRegular.Checked = True
            strMeatTopping2 = "pepperoni"

            If (cboTopping1.SelectedIndex = 0 Or cboTopping1.SelectedIndex = 1) Then
                currentImage = My.Resources.pepperoni
                picPizza.Image = currentImage
                If cboTopping1.SelectedIndex = 1 Then
                    radDouble.Checked = True
                    blnExtraMeat = True
                End If
            ElseIf cboTopping1.SelectedIndex = 2
                currentImage = My.Resources.pepperonibeef
                picPizza.Image = currentImage
            ElseIf cboTopping1.SelectedIndex = 3
                currentImage = My.Resources.pepperonichicken
                picPizza.Image = currentImage
            ElseIf cboTopping1.SelectedIndex = 4
                currentImage = My.Resources.pepperonisausage
                picPizza.Image = currentImage
            ElseIf cboTopping1.SelectedIndex = 5
                currentImage = My.Resources.pepperonipork
                picPizza.Image = currentImage
            Else
                currentImage = My.Resources.pepperoni
                picPizza.Image = currentImage
            End If

        ElseIf cboTopping2.SelectedIndex = 2 Then

            radRegular.Checked = True
            strMeatTopping2 = "beef"

            If (cboTopping1.SelectedIndex = 0 Or cboTopping1.SelectedIndex = 2) Then
                currentImage = My.Resources.beef
                picPizza.Image = currentImage
                If cboTopping1.SelectedIndex = 2 Then
                    radDouble.Checked = True
                    blnExtraMeat = True
                End If
            ElseIf cboTopping1.SelectedIndex = 1
                currentImage = My.Resources.pepperonibeef
                picPizza.Image = currentImage
            ElseIf cboTopping1.SelectedIndex = 3
                currentImage = My.Resources.chickenbeef
                picPizza.Image = currentImage
            ElseIf cboTopping1.SelectedIndex = 4
                currentImage = My.Resources.sausagebeef
                picPizza.Image = currentImage
            ElseIf cboTopping1.SelectedIndex = 5
                currentImage = My.Resources.beefpork
                picPizza.Image = currentImage
            Else
                currentImage = My.Resources.beef
                picPizza.Image = currentImage
            End If

        ElseIf cboTopping2.SelectedIndex = 3 Then

            radRegular.Checked = True
            strMeatTopping2 = "chicken"

            If (cboTopping1.SelectedIndex = 0 Or cboTopping1.SelectedIndex = 3) Then
                currentImage = My.Resources.chicken
                picPizza.Image = currentImage
                If cboTopping1.SelectedIndex = 3 Then
                    radDouble.Checked = True
                    blnExtraMeat = True
                End If
            ElseIf cboTopping1.SelectedIndex = 2
                currentImage = My.Resources.chickenbeef
                picPizza.Image = currentImage
            ElseIf cboTopping1.SelectedIndex = 1
                currentImage = My.Resources.pepperonichicken
                picPizza.Image = currentImage
            ElseIf cboTopping1.SelectedIndex = 4
                currentImage = My.Resources.sausagechicken
                picPizza.Image = currentImage
            ElseIf cboTopping1.SelectedIndex = 5
                currentImage = My.Resources.chickenpork
                picPizza.Image = currentImage
            Else
                currentImage = My.Resources.chicken
                picPizza.Image = currentImage
            End If

        ElseIf cboTopping2.SelectedIndex = 4 Then

            radRegular.Checked = True
            strMeatTopping2 = "sausage"

            If (cboTopping1.SelectedIndex = 0 Or cboTopping1.SelectedIndex = 4) Then
                currentImage = My.Resources.sausage
                picPizza.Image = currentImage
                If cboTopping1.SelectedIndex = 4 Then
                    radDouble.Checked = True
                    blnExtraMeat = True
                End If
            ElseIf cboTopping1.SelectedIndex = 2
                currentImage = My.Resources.sausagebeef
                picPizza.Image = currentImage
            ElseIf cboTopping1.SelectedIndex = 3
                currentImage = My.Resources.sausagechicken
                picPizza.Image = currentImage
            ElseIf cboTopping1.SelectedIndex = 1
                currentImage = My.Resources.pepperonisausage
                picPizza.Image = currentImage
            ElseIf cboTopping1.SelectedIndex = 5
                currentImage = My.Resources.sausagepork
                picPizza.Image = currentImage
            Else
                currentImage = My.Resources.sausage
                picPizza.Image = currentImage
            End If

        ElseIf cboTopping2.SelectedIndex = 5 Then

            radRegular.Checked = True
            strMeatTopping2 = "pork"

            If (cboTopping1.SelectedIndex = 0 Or cboTopping1.SelectedIndex = 5) Then
                currentImage = My.Resources.pork
                picPizza.Image = currentImage
                If cboTopping1.SelectedIndex = 5 Then
                    radDouble.Checked = True
                    blnExtraMeat = True
                End If
            ElseIf cboTopping1.SelectedIndex = 2
                currentImage = My.Resources.beefpork
                picPizza.Image = currentImage
            ElseIf cboTopping1.SelectedIndex = 3
                currentImage = My.Resources.chickenpork
                picPizza.Image = currentImage
            ElseIf cboTopping1.SelectedIndex = 4
                currentImage = My.Resources.sausagepork
                picPizza.Image = currentImage
            ElseIf cboTopping1.SelectedIndex = 1
                currentImage = My.Resources.pepperonipork
                picPizza.Image = currentImage
            Else
                currentImage = My.Resources.pork
                picPizza.Image = currentImage
            End If
        Else
            currentImage = My.Resources.plaincheese
            picPizza.Image = currentImage
            strMeatTopping1 = "none"
            strMeatTopping2 = "none"
            blnExtraMeat = False
            blnNoMeat = True
        End If
    End Sub
End Class