' Program: Pizza Creator
' Author: Jacob Taylor
' Date: 4/8/16
' Purpose: This project provides an interface for ordering pizza delivery through an application
Option Strict On
Public Class frmCrusts
    Dim strSize As String
    Dim strCrust As String
    Dim currentImage As Image

    Public Shared objPizza As Pizza
    Private Sub frmCrusts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        strSize = "small"
        strCrust = "pan"
        currentImage = My.Resources.smallpan
        picPizza.Image = currentImage
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        objPizza = New Pizza(strSize, strCrust)

        Dim frmSecond As New frmSauces

        Hide()
        frmSecond.ShowDialog()
    End Sub

    Private Sub radDeepDish_CheckedChanged(sender As Object, e As EventArgs) Handles radDeepDish.CheckedChanged
        strCrust = "deep dish"

        If radMed.Checked Then
            currentImage = My.Resources.deepdish
            strSize = "medium"
        ElseIf radLarge.Checked Then
            currentImage = My.Resources.deepdish
            strSize = "large"
        Else
            currentImage = My.Resources.deepdish
            strSize = "extra large"

        End If
        picPizza.Image = currentImage

    End Sub

    Private Sub radPan_CheckedChanged(sender As Object, e As EventArgs) Handles radPan.CheckedChanged
        strCrust = "pan"
        If radSmall.Checked Then
            currentImage = My.Resources.smallpan
        ElseIf radMed.Checked Then
            currentImage = My.Resources.mediumpan
            strSize = "medium"
        ElseIf radLarge.Checked Then
            currentImage = My.Resources.mediumpan
            strSize = "large"
        Else
            currentImage = My.Resources.mediumpan
            strSize = "extra large"
        End If
        picPizza.Image = currentImage

    End Sub

    Private Sub radHandTossed_CheckedChanged(sender As Object, e As EventArgs) Handles radHandTossed.CheckedChanged
        strCrust = "hand tossed"

        If radMed.Checked Then
            currentImage = My.Resources.handtossed
            strSize = "medium"
        ElseIf radLarge.Checked Then
            currentImage = My.Resources.handtossed
            strSize = "large"
        Else
            currentImage = My.Resources.handtossed
            strSize = "extra large"
        End If

        picPizza.Image = currentImage

    End Sub

    Private Sub radThin_CheckedChanged(sender As Object, e As EventArgs) Handles radThin.CheckedChanged
        strCrust = "thin crust"

        If radMed.Checked Then
            currentImage = My.Resources.thincrust
            strSize = "medium"
        ElseIf radLarge.Checked Then
            currentImage = My.Resources.thincrust
            strSize = "large"
        Else
            currentImage = My.Resources.thincrust
            strSize = "extra large"
        End If
        picPizza.Image = currentImage

    End Sub

    Private Sub radSmall_CheckedChanged(sender As Object, e As EventArgs) Handles radSmall.CheckedChanged
        strSize = "small"
        currentImage = My.Resources.smallpan
        picPizza.Image = currentImage
        radDeepDish.Visible = False
        radHandTossed.Visible = False
        radThin.Visible = False
    End Sub

    Private Sub radMed_CheckedChanged(sender As Object, e As EventArgs) Handles radMed.CheckedChanged

        radDeepDish.Visible = True
        radHandTossed.Visible = True
        radThin.Visible = True

        strSize = "medium"
        If radDeepDish.Checked Then
            currentImage = My.Resources.deepdish
            strCrust = "deep dish"
        ElseIf radHandTossed.Checked Then
            currentImage = My.Resources.handtossed
            strCrust = "hand tossed"
        ElseIf radThin.Checked Then
            currentImage = My.Resources.thincrust
            strCrust = "thin crust"
        Else
            currentImage = My.Resources.mediumpan
            strCrust = "pan"
        End If
        picPizza.Image = currentImage

    End Sub

    Private Sub radLarge_CheckedChanged(sender As Object, e As EventArgs) Handles radLarge.CheckedChanged

        radDeepDish.Visible = True
        radHandTossed.Visible = True
        radThin.Visible = True

        strSize = "large"
        If radDeepDish.Checked Then
            currentImage = My.Resources.deepdish
            strCrust = "deep dish"
        ElseIf radHandTossed.Checked Then
            currentImage = My.Resources.handtossed
            strCrust = "hand tossed"
        ElseIf radThin.Checked Then
            currentImage = My.Resources.thincrust
            strCrust = "thin crust"
        Else
            currentImage = My.Resources.mediumpan
            strCrust = "pan"
        End If
        picPizza.Image = currentImage

    End Sub

    Private Sub radXlarge_CheckedChanged(sender As Object, e As EventArgs) Handles radXlarge.CheckedChanged

        radDeepDish.Visible = True
        radHandTossed.Visible = True
        radThin.Visible = True

        strSize = "extra large"
        If radDeepDish.Checked Then
            currentImage = My.Resources.deepdish
            strCrust = "deep dish"
        ElseIf radHandTossed.Checked Then
            currentImage = My.Resources.handtossed
            strCrust = "hand tossed"
        ElseIf radThin.Checked Then
            currentImage = My.Resources.thincrust
            strCrust = "thin crust"
        Else
            currentImage = My.Resources.mediumpan
            strCrust = "pan"
        End If
        picPizza.Image = currentImage

    End Sub


End Class
