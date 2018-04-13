' Program: Pizza Creator
' Author: Jacob Taylor
' Date: 4/8/16
' Purpose: This project provides an interface for ordering pizza delivery through an application
Option Strict On
Public Class frmSauces
    Dim strSauce As String
    Dim currentImage As Image
    Public Shared objPizza As Pizza
    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        Dim frmFirst As New frmCrusts
        Hide()
        frmFirst.ShowDialog()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        objPizza.SetSauce(strSauce)
        Dim frmThird As New frmMeats
        objPizza.SetSauce(strSauce)
        Hide()
        frmThird.ShowDialog()
    End Sub

    Private Sub frmSauces_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objPizza = frmCrusts.objPizza
        strSauce = "marinara"
        currentImage = My.Resources.marinara
        picPizza.Image = currentImage
    End Sub

    Private Sub radMarinara_CheckedChanged(sender As Object, e As EventArgs) Handles radMarinara.CheckedChanged
        strSauce = "marinara"
        currentImage = My.Resources.marinara
        picPizza.Image = currentImage
    End Sub

    Private Sub radBarbeque_CheckedChanged(sender As Object, e As EventArgs) Handles radBarbeque.CheckedChanged
        strSauce = "barbeque"
        currentImage = My.Resources.barbeque
        picPizza.Image = currentImage
    End Sub

    Private Sub radBuffalo_CheckedChanged(sender As Object, e As EventArgs) Handles radBuffalo.CheckedChanged
        strSauce = "buffalo"
        currentImage = My.Resources.buffalo
        picPizza.Image = currentImage
    End Sub

    Private Sub radJalapeno_CheckedChanged(sender As Object, e As EventArgs) Handles radJalapeno.CheckedChanged
        strSauce = "jalapeno extreme"
        currentImage = My.Resources.jalapenoextreme
        picPizza.Image = currentImage
    End Sub
End Class