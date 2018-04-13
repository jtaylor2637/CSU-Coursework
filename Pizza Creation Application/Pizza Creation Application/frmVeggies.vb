Public Class frmVeggies

    Dim strVeggieTopping1 As String

    Dim strVeggieTopping2 As String

    Dim blnNoVeggies As Boolean
    Dim blnExtraVeggies As Boolean
    Dim currentImage As Image
    Public Shared objPizza As Pizza

    Private Sub frmVeggies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboTopping1.SelectedIndex = 0
        cboTopping2.SelectedIndex = 0
        objPizza = frmMeats.objPizza
        currentImage = My.Resources.plaincheese

        blnNoVeggies = True
        blnExtraVeggies = False
        radNone.Checked = True
        picPizza.Image = currentImage
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        Dim frmThird As New frmMeats
        Hide()
        frmThird.ShowDialog()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        objPizza.SetVeggies(cboTopping1.SelectedItem.ToString(), cboTopping2.SelectedItem.ToString(), blnExtraVeggies)
        Dim frmFifth As New frmOther
        Hide()
        frmFifth.ShowDialog()
    End Sub

    Private Sub radNone_CheckedChanged(sender As Object, e As EventArgs) Handles radNone.CheckedChanged
        If radNone.Checked = True Then
            cboTopping1.SelectedIndex = 0
            cboTopping2.SelectedIndex = 0
        End If
        currentImage = My.Resources.plaincheese
        strVeggieTopping1 = "none"
        strVeggieTopping2 = "none"
        picPizza.Image = currentImage
    End Sub

    Private Sub radRegular_CheckedChanged(sender As Object, e As EventArgs) Handles radRegular.CheckedChanged
        blnExtraVeggies = False
        blnNoVeggies = False
    End Sub

    Private Sub radDouble_CheckedChanged(sender As Object, e As EventArgs) Handles radDouble.CheckedChanged
        blnNoVeggies = False
        blnExtraVeggies = True
    End Sub

    Private Sub cboVeggie1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTopping1.SelectedIndexChanged
        If cboTopping1.SelectedIndex = 0 And cboTopping2.SelectedIndex = 0 Then
            currentImage = My.Resources.plaincheese
            strVeggieTopping1 = "none"
            radNone.Checked = True
            picPizza.Image = currentImage

        ElseIf cboTopping1.SelectedIndex = 0 And cboTopping2.SelectedIndex <> 0 Then
            If cboTopping2.SelectedIndex = 1 Then
                strVeggieTopping2 = "onions"
                radRegular.Checked = True
                currentImage = My.Resources.onions
                picPizza.Image = currentImage
            ElseIf cboTopping2.SelectedIndex = 2
                strVeggieTopping2 = "olives"
                radRegular.Checked = True
                currentImage = My.Resources.olives
                picPizza.Image = currentImage
            ElseIf cboTopping2.SelectedIndex = 3
                strVeggieTopping2 = "mushrooms"
                radRegular.Checked = True
                currentImage = My.Resources.mushrooms
                picPizza.Image = currentImage
            ElseIf cboTopping2.SelectedIndex = 4
                strVeggieTopping2 = "spinach"
                radRegular.Checked = True
                currentImage = My.Resources.spinach
                picPizza.Image = currentImage
            ElseIf cboTopping2.SelectedIndex = 5
                strVeggieTopping2 = "jalapenos"
                radRegular.Checked = True
                currentImage = My.Resources.jalapenos
                picPizza.Image = currentImage
            ElseIf cboTopping2.SelectedIndex = 6
                strVeggieTopping2 = "pineapple"
                radRegular.Checked = True
                currentImage = My.Resources.pineapple
                picPizza.Image = currentImage
            Else
                currentImage = My.Resources.plaincheese
                picPizza.Image = currentImage
                radNone.Checked = True
                strVeggieTopping1 = "none"
                strVeggieTopping2 = "none"
                blnNoVeggies = True
            End If

        ElseIf cboTopping1.SelectedIndex = 1 Then

            radRegular.Checked = True
            strVeggieTopping1 = "onions"

            If (cboTopping2.SelectedIndex = 0 Or cboTopping2.SelectedIndex = 1) Then
                currentImage = My.Resources.onions
                picPizza.Image = currentImage
                If cboTopping2.SelectedIndex = 1 Then
                    radDouble.Checked = True
                    blnExtraVeggies = True
                End If
            ElseIf cboTopping2.SelectedIndex = 2
                currentImage = My.Resources.onionsolives
                picPizza.Image = currentImage
            ElseIf cboTopping2.SelectedIndex = 3
                currentImage = My.Resources.onionsmushrooms
                picPizza.Image = currentImage
            ElseIf cboTopping2.SelectedIndex = 4
                currentImage = My.Resources.onionsspinach
                picPizza.Image = currentImage
            ElseIf cboTopping2.SelectedIndex = 5
                currentImage = My.Resources.onionsjalapenos
                picPizza.Image = currentImage
            ElseIf cboTopping2.SelectedIndex = 6
                currentImage = My.Resources.onionspineapple
                picPizza.Image = currentImage
            Else
                currentImage = My.Resources.onions
                picPizza.Image = currentImage
            End If

        ElseIf cboTopping1.SelectedIndex = 2 Then

            radRegular.Checked = True
            strVeggieTopping1 = "olives"

            If (cboTopping2.SelectedIndex = 0 Or cboTopping2.SelectedIndex = 2) Then
                currentImage = My.Resources.olives
                picPizza.Image = currentImage
                If cboTopping2.SelectedIndex = 2 Then
                    radDouble.Checked = True
                    blnExtraVeggies = True
                End If
            ElseIf cboTopping2.SelectedIndex = 1
                currentImage = My.Resources.onionsolives
                picPizza.Image = currentImage
            ElseIf cboTopping2.SelectedIndex = 3
                currentImage = My.Resources.olivesmushroom
                picPizza.Image = currentImage
            ElseIf cboTopping2.SelectedIndex = 4
                currentImage = My.Resources.olivesspinach
                picPizza.Image = currentImage
            ElseIf cboTopping2.SelectedIndex = 5
                currentImage = My.Resources.olivesjalapeno
                picPizza.Image = currentImage
            ElseIf cboTopping2.SelectedIndex = 6
                currentImage = My.Resources.olivespineapple
                picPizza.Image = currentImage
            Else
                currentImage = My.Resources.olives
                picPizza.Image = currentImage
            End If

        ElseIf cboTopping1.SelectedIndex = 3 Then

            radRegular.Checked = True
            strVeggieTopping1 = "mushrooms"

            If (cboTopping2.SelectedIndex = 0 Or cboTopping2.SelectedIndex = 3) Then
                currentImage = My.Resources.mushrooms
                picPizza.Image = currentImage
                If cboTopping2.SelectedIndex = 3 Then
                    radDouble.Checked = True
                    blnExtraVeggies = True
                End If
            ElseIf cboTopping2.SelectedIndex = 2
                currentImage = My.Resources.olivesmushroom
                picPizza.Image = currentImage
            ElseIf cboTopping2.SelectedIndex = 1
                currentImage = My.Resources.onionsmushrooms
                picPizza.Image = currentImage
            ElseIf cboTopping2.SelectedIndex = 4
                currentImage = My.Resources.mushroomsspinach
                picPizza.Image = currentImage
            ElseIf cboTopping2.SelectedIndex = 5
                currentImage = My.Resources.mushroomjalapenos
                picPizza.Image = currentImage
            ElseIf cboTopping2.SelectedIndex = 5
                currentImage = My.Resources.mushroompineapple
                picPizza.Image = currentImage
            Else
                currentImage = My.Resources.mushrooms
                picPizza.Image = currentImage
            End If

        ElseIf cboTopping1.SelectedIndex = 4 Then

            radRegular.Checked = True
            strVeggieTopping1 = "spinach"

            If (cboTopping2.SelectedIndex = 0 Or cboTopping2.SelectedIndex = 4) Then
                currentImage = My.Resources.spinach
                picPizza.Image = currentImage
                If cboTopping2.SelectedIndex = 4 Then
                    radDouble.Checked = True
                    blnExtraVeggies = True
                End If
            ElseIf cboTopping2.SelectedIndex = 2
                currentImage = My.Resources.olivesspinach
                picPizza.Image = currentImage
            ElseIf cboTopping2.SelectedIndex = 3
                currentImage = My.Resources.mushroomsspinach
                picPizza.Image = currentImage
            ElseIf cboTopping2.SelectedIndex = 1
                currentImage = My.Resources.onionsspinach
                picPizza.Image = currentImage
            ElseIf cboTopping2.SelectedIndex = 5
                currentImage = My.Resources.spinachjalapenos
                picPizza.Image = currentImage
            ElseIf cboTopping2.SelectedIndex = 5
                currentImage = My.Resources.spinachpineapple
                picPizza.Image = currentImage
            Else
                currentImage = My.Resources.spinach
                picPizza.Image = currentImage
            End If

        ElseIf cboTopping1.SelectedIndex = 5 Then

            radRegular.Checked = True
            strVeggieTopping1 = "jalapenos"

            If (cboTopping2.SelectedIndex = 0 Or cboTopping2.SelectedIndex = 5) Then
                currentImage = My.Resources.jalapenos
                picPizza.Image = currentImage
                If cboTopping2.SelectedIndex = 5 Then
                    radDouble.Checked = True
                    blnExtraVeggies = True
                End If
            ElseIf cboTopping2.SelectedIndex = 2
                currentImage = My.Resources.olivesjalapeno
                picPizza.Image = currentImage
            ElseIf cboTopping2.SelectedIndex = 3
                currentImage = My.Resources.mushroomjalapenos
                picPizza.Image = currentImage
            ElseIf cboTopping2.SelectedIndex = 4
                currentImage = My.Resources.spinachjalapenos
                picPizza.Image = currentImage
            ElseIf cboTopping2.SelectedIndex = 1
                currentImage = My.Resources.onionsjalapenos
                picPizza.Image = currentImage
            ElseIf cboTopping2.SelectedIndex = 6
                currentImage = My.Resources.jalapenospineapple
                picPizza.Image = currentImage
            Else
                currentImage = My.Resources.jalapenos
                picPizza.Image = currentImage
            End If
        ElseIf cboTopping1.SelectedIndex = 6 Then

            radRegular.Checked = True
            strVeggieTopping1 = "pineapple"

            If (cboTopping2.SelectedIndex = 0 Or cboTopping2.SelectedIndex = 6) Then
                currentImage = My.Resources.pineapple
                picPizza.Image = currentImage
                If cboTopping2.SelectedIndex = 6 Then
                    radDouble.Checked = True
                    blnExtraVeggies = True
                End If
            ElseIf cboTopping2.SelectedIndex = 2
                currentImage = My.Resources.olivespineapple
                picPizza.Image = currentImage
            ElseIf cboTopping2.SelectedIndex = 3
                currentImage = My.Resources.mushroompineapple
                picPizza.Image = currentImage
            ElseIf cboTopping2.SelectedIndex = 4
                currentImage = My.Resources.spinachpineapple
                picPizza.Image = currentImage
            ElseIf cboTopping2.SelectedIndex = 1
                currentImage = My.Resources.onionspineapple
                picPizza.Image = currentImage
            ElseIf cboTopping2.SelectedIndex = 5
                currentImage = My.Resources.jalapenospineapple
                picPizza.Image = currentImage
            Else
                currentImage = My.Resources.pineapple
                picPizza.Image = currentImage
            End If
        Else
            currentImage = My.Resources.plaincheese
            picPizza.Image = currentImage
            radNone.Checked = True
            blnExtraVeggies = False
            blnNoVeggies = True
            strVeggieTopping1 = "none"
            strVeggieTopping2 = "none"
        End If
    End Sub

    Private Sub cboTopping2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTopping2.SelectedIndexChanged
        If cboTopping2.SelectedIndex = 0 And cboTopping1.SelectedIndex = 0 Then
            currentImage = My.Resources.plaincheese
            strVeggieTopping2 = "none"
            radNone.Checked = True
            picPizza.Image = currentImage
        ElseIf cboTopping2.SelectedIndex = 0 And cboTopping1.SelectedIndex <> 0 Then
            If cboTopping1.SelectedIndex = 1 Then
                strVeggieTopping1 = "onions"
                radRegular.Checked = True
                currentImage = My.Resources.onions
                picPizza.Image = currentImage
            ElseIf cboTopping1.SelectedIndex = 2
                strVeggieTopping1 = "olives"
                radRegular.Checked = True
                currentImage = My.Resources.olives
                picPizza.Image = currentImage
            ElseIf cboTopping1.SelectedIndex = 3
                strVeggieTopping1 = "mushrooms"
                radRegular.Checked = True
                currentImage = My.Resources.mushrooms
                picPizza.Image = currentImage
            ElseIf cboTopping1.SelectedIndex = 4
                strVeggieTopping1 = "spinach"
                radRegular.Checked = True
                currentImage = My.Resources.spinach
                picPizza.Image = currentImage
            ElseIf cboTopping1.SelectedIndex = 5
                strVeggieTopping1 = "jalapenos"
                radRegular.Checked = True
                currentImage = My.Resources.jalapenos
                picPizza.Image = currentImage
            ElseIf cboTopping1.SelectedIndex = 6
                strVeggieTopping1 = "pineapple"
                radRegular.Checked = True
                currentImage = My.Resources.pineapple
                picPizza.Image = currentImage
            End If

        ElseIf cboTopping2.SelectedIndex = 1 Then

            radRegular.Checked = True
            strVeggieTopping2 = "onions"

            If (cboTopping1.SelectedIndex = 0 Or cboTopping1.SelectedIndex = 1) Then
                currentImage = My.Resources.onions
                picPizza.Image = currentImage
                If cboTopping1.SelectedIndex = 1 Then
                    radDouble.Checked = True
                    blnExtraVeggies = True
                End If
            ElseIf cboTopping1.SelectedIndex = 2
                currentImage = My.Resources.onionsolives
                picPizza.Image = currentImage
            ElseIf cboTopping1.SelectedIndex = 3
                currentImage = My.Resources.onionsmushrooms
                picPizza.Image = currentImage
            ElseIf cboTopping1.SelectedIndex = 4
                currentImage = My.Resources.onionsspinach
                picPizza.Image = currentImage
            ElseIf cboTopping1.SelectedIndex = 5
                currentImage = My.Resources.onionsjalapenos
                picPizza.Image = currentImage
            ElseIf cboTopping1.SelectedIndex = 6
                currentImage = My.Resources.onionspineapple
                picPizza.Image = currentImage
            Else
                currentImage = My.Resources.onions
                picPizza.Image = currentImage
            End If

        ElseIf cboTopping2.SelectedIndex = 2 Then

            radRegular.Checked = True
            strVeggieTopping2 = "olives"

            If (cboTopping1.SelectedIndex = 0 Or cboTopping1.SelectedIndex = 2) Then
                currentImage = My.Resources.olives
                picPizza.Image = currentImage
                If cboTopping1.SelectedIndex = 2 Then
                    radDouble.Checked = True
                    blnExtraVeggies = True
                End If
            ElseIf cboTopping1.SelectedIndex = 1
                currentImage = My.Resources.onionsolives
                picPizza.Image = currentImage
            ElseIf cboTopping1.SelectedIndex = 3
                currentImage = My.Resources.olivesmushroom
                picPizza.Image = currentImage
            ElseIf cboTopping1.SelectedIndex = 4
                currentImage = My.Resources.olivesspinach
                picPizza.Image = currentImage
            ElseIf cboTopping1.SelectedIndex = 5
                currentImage = My.Resources.olivesjalapeno
                picPizza.Image = currentImage
            ElseIf cboTopping1.SelectedIndex = 5
                currentImage = My.Resources.olivespineapple
                picPizza.Image = currentImage
            Else
                currentImage = My.Resources.olives
                picPizza.Image = currentImage
            End If

        ElseIf cboTopping2.SelectedIndex = 3 Then

            radRegular.Checked = True
            strVeggieTopping2 = "mushrooms"

            If (cboTopping1.SelectedIndex = 0 Or cboTopping1.SelectedIndex = 3) Then
                currentImage = My.Resources.mushrooms
                picPizza.Image = currentImage
                If cboTopping1.SelectedIndex = 3 Then
                    radDouble.Checked = True
                    blnExtraVeggies = True
                End If
            ElseIf cboTopping1.SelectedIndex = 2
                currentImage = My.Resources.olivesmushroom
                picPizza.Image = currentImage
            ElseIf cboTopping1.SelectedIndex = 1
                currentImage = My.Resources.onionsmushrooms
                picPizza.Image = currentImage
            ElseIf cboTopping1.SelectedIndex = 4
                currentImage = My.Resources.mushroomsspinach
                picPizza.Image = currentImage
            ElseIf cboTopping1.SelectedIndex = 5
                currentImage = My.Resources.mushroomjalapenos
                picPizza.Image = currentImage
            ElseIf cboTopping1.SelectedIndex = 6
                currentImage = My.Resources.mushroompineapple
                picPizza.Image = currentImage
            Else
                currentImage = My.Resources.mushrooms
                picPizza.Image = currentImage
            End If

        ElseIf cboTopping2.SelectedIndex = 4 Then

            radRegular.Checked = True
            strVeggieTopping2 = "spinach"

            If (cboTopping1.SelectedIndex = 0 Or cboTopping1.SelectedIndex = 4) Then
                currentImage = My.Resources.spinach
                picPizza.Image = currentImage
                If cboTopping1.SelectedIndex = 4 Then
                    radDouble.Checked = True
                    blnExtraVeggies = True
                End If
            ElseIf cboTopping1.SelectedIndex = 2
                currentImage = My.Resources.olivesspinach
                picPizza.Image = currentImage
            ElseIf cboTopping1.SelectedIndex = 3
                currentImage = My.Resources.mushroomsspinach
                picPizza.Image = currentImage
            ElseIf cboTopping1.SelectedIndex = 1
                currentImage = My.Resources.onionsspinach
                picPizza.Image = currentImage
            ElseIf cboTopping1.SelectedIndex = 5
                currentImage = My.Resources.spinachjalapenos
                picPizza.Image = currentImage
            ElseIf cboTopping1.SelectedIndex = 6
                currentImage = My.Resources.spinachpineapple
                picPizza.Image = currentImage
            Else
                currentImage = My.Resources.spinach
                picPizza.Image = currentImage
            End If

        ElseIf cboTopping2.SelectedIndex = 5 Then

            radRegular.Checked = True
            strVeggieTopping2 = "jalapenos"

            If (cboTopping1.SelectedIndex = 0 Or cboTopping1.SelectedIndex = 5) Then
                currentImage = My.Resources.jalapenos
                picPizza.Image = currentImage
                If cboTopping1.SelectedIndex = 5 Then
                    radDouble.Checked = True
                    blnExtraVeggies = True
                End If
            ElseIf cboTopping1.SelectedIndex = 2
                currentImage = My.Resources.olivesjalapeno
                picPizza.Image = currentImage
            ElseIf cboTopping1.SelectedIndex = 3
                currentImage = My.Resources.mushroomjalapenos
                picPizza.Image = currentImage
            ElseIf cboTopping1.SelectedIndex = 4
                currentImage = My.Resources.spinachjalapenos
                picPizza.Image = currentImage
            ElseIf cboTopping1.SelectedIndex = 1
                currentImage = My.Resources.onionsjalapenos
                picPizza.Image = currentImage
            ElseIf cboTopping1.SelectedIndex = 6
                currentImage = My.Resources.jalapenospineapple
                picPizza.Image = currentImage
            Else
                currentImage = My.Resources.jalapenos
                picPizza.Image = currentImage
            End If

        ElseIf cboTopping2.SelectedIndex = 6 Then

            radRegular.Checked = True
            strVeggieTopping2 = "pineapple"

            If (cboTopping1.SelectedIndex = 0 Or cboTopping1.SelectedIndex = 6) Then
                currentImage = My.Resources.pineapple
                picPizza.Image = currentImage
                If cboTopping1.SelectedIndex = 6 Then
                    radDouble.Checked = True
                    blnExtraVeggies = True
                End If
            ElseIf cboTopping1.SelectedIndex = 2
                currentImage = My.Resources.olivespineapple
                picPizza.Image = currentImage
            ElseIf cboTopping1.SelectedIndex = 3
                currentImage = My.Resources.mushroompineapple
                picPizza.Image = currentImage
            ElseIf cboTopping1.SelectedIndex = 4
                currentImage = My.Resources.spinachpineapple
                picPizza.Image = currentImage
            ElseIf cboTopping1.SelectedIndex = 1
                currentImage = My.Resources.onionspineapple
                picPizza.Image = currentImage
            ElseIf cboTopping1.SelectedIndex = 5
                currentImage = My.Resources.jalapenospineapple
                picPizza.Image = currentImage
            Else
                currentImage = My.Resources.pineapple
                picPizza.Image = currentImage
            End If
        Else
            currentImage = My.Resources.plaincheese
            picPizza.Image = currentImage
            strVeggieTopping1 = "none"
            strVeggieTopping2 = "none"
            blnExtraVeggies = False
            blnNoVeggies = True
        End If

    End Sub
End Class