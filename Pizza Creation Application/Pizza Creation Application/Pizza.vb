Option Strict On
Public Class Pizza
    Dim _strSize As String
    Dim _strCrust As String
    Dim _strSauce As String
    Dim _strMeatTopping1 As String
    Dim _strMeatTopping2 As String
    Dim _blnMeatExtra As Boolean
    Dim _blnNoMeat As Boolean
    Dim _strVeggieTopping1 As String
    Dim _strVeggieTopping2 As String
    Dim _blnVeggieExtra As Boolean
    Dim _blnNoVeggie As Boolean
    Dim _blnDrinks As Boolean
    Dim _blnCookie As Boolean
    Dim _blnCheesyBread As Boolean
    Dim _blnBrownie As Boolean
    Dim _currentImage As Image

    Dim objOrderFile As OrderFile

    Sub New(ByVal strSize As String, ByVal strCrust As String)
        _strSize = strSize
        _strCrust = strCrust

    End Sub

    Sub SetSauce(ByVal strSauce As String)
        _strSauce = strSauce

    End Sub

    Sub NoMeat(ByVal blnNoMeat As Boolean)
        _blnNoMeat = blnNoMeat
    End Sub



    Sub SetMeats(ByVal strMeatTopping1 As String, ByVal strMeatTopping2 As String, ByVal blnMeatExtra As Boolean)
        If strMeatTopping1 = "None" And strMeatTopping2 = "None" Then
            _blnNoMeat = True
        End If
        _strMeatTopping1 = strMeatTopping1
        _strMeatTopping2 = strMeatTopping2
        _blnMeatExtra = blnMeatExtra
    End Sub

    Sub NoVeggies(ByVal blnNoVeggie As Boolean)
        _blnNoVeggie = blnNoVeggie
    End Sub
    Sub SetVeggies(ByVal strVeggieTopping1 As String, ByVal strVeggieTopping2 As String, ByVal blnVeggieExtra As Boolean)
        If strVeggieTopping1 = "None" And strVeggieTopping2 = "None" Then
            _blnNoVeggie = True
        End If
        _strVeggieTopping1 = strVeggieTopping1
        _strVeggieTopping2 = strVeggieTopping2
        _blnVeggieExtra = blnVeggieExtra
    End Sub

    Function getNoMeat() As Boolean
        Return _blnNoMeat
    End Function

    Function getNoVeggies() As Boolean
        Return _blnNoVeggie
    End Function

    Function getMeat1() As String
        Return _strMeatTopping1
    End Function

    Function getMeat2() As String
        Return _strMeatTopping2
    End Function

    Function getCrust() As String
        Return _strCrust
    End Function

    Function getSauce() As String
        Return _strSauce
    End Function

    Function getSize() As String
        Return _strSize
    End Function

    Function getVeggie1() As String
        Return _strVeggieTopping1
    End Function

    Function getVeggie2() As String
        Return _strVeggieTopping2
    End Function

    Function getExtraMeat() As Boolean
        Return _blnMeatExtra
    End Function

    Function getExtraVeggies() As Boolean
        Return _blnVeggieExtra
    End Function

    Function AddDrinks() As Boolean
        _blnDrinks = True
        Return _blnDrinks
    End Function

    Function removeDrinks() As Boolean
        _blnDrinks = False
        Return _blnDrinks
    End Function

    Function AddCookie() As Boolean
        _blnCookie = True
        Return _blnCookie
    End Function

    Function removeCookies() As Boolean
        _blnCookie = False
        Return _blnDrinks
    End Function

    Function AddCheesyBread() As Boolean
        _blnCheesyBread = True
        Return _blnCheesyBread
    End Function

    Function removeCheesyBread() As Boolean
        _blnCheesyBread = False
        Return _blnCheesyBread
    End Function

    Function AddBrownie() As Boolean
        _blnBrownie = True
        Return _blnBrownie
    End Function

    Function removeBrownie() As Boolean
        _blnBrownie = False
        Return _blnBrownie
    End Function

    Function getDescription() As String
        Dim description As String = "One "

        If _blnNoVeggie = True And _blnNoMeat = True Then

            description += getSize() & "  " & getCrust() & " with " & getSauce() & " sauce, with " & "no toppings"
            Return description

        ElseIf _blnNoMeat = True And _blnNoVeggie = False

            If getVeggie1() = "None" Then
                description += getSize() & "  " & getCrust() & " pizza with " & getSauce() & " sauce, with " & " no meat toppings and " & getVeggie2()
            ElseIf getVeggie2() = "None"
                description += getSize() & "  " & getCrust() & " pizza with " & getSauce() & " sauce, with " & " no meat toppings and " & getVeggie1()
            Else
                If _blnVeggieExtra = True And String.Compare(getVeggie1(), getVeggie2) = 0 Then
                    description += getSize() & "  " & getCrust() & " pizza with " & getSauce() & " sauce, with " & "no meat toppings and double " & getVeggie1()
                Else
                    description += getSize() & "  " & getCrust() & " pizza with " & getSauce() & " sauce, with " & " no meat toppings and " & getVeggie1() & " and " & getVeggie2()
                End If

            End If


            Return description

        ElseIf _blnNoMeat = False And _blnNoVeggie = True

            If getMeat1() = "None" Then
                description += getSize() & "  " & getCrust() & " pizza with " & getSauce() & " sauce, with " & " and no veggie toppings "
            ElseIf getMeat2() = "None"
                description += getSize() & "  " & getCrust() & " pizza with " & getSauce() & " sauce, with " & " and no veggie toppings "
            Else
                If _blnMeatExtra = True And String.Compare(getMeat1(), getMeat2) = 0 Then
                    description += getSize() & "  " & getCrust() & " pizza with " & getSauce() & " sauce, with double " & getMeat1() & " and no veggie toppings "
                Else
                    description += getSize() & "  " & getCrust() & " pizza with " & getSauce() & " sauce, with " & " and " & getMeat2() & " and no veggie toppings "
                End If

            End If


            Return description

        ElseIf _blnMeatExtra = True And _blnVeggieExtra = True

            description += getSize() & "  " & getCrust() & " pizza with " & getSauce() & " sauce, with double " & " and " & getMeat2() & " and double " & " and " & getVeggie2()
            Return description

        ElseIf _blnMeatExtra = True And _blnVeggieExtra = False

            If getVeggie1() = "None" Then
                description += getSize() & "  " & getCrust() & " pizza with " & getSauce() & " sauce, with double " & " and " & getMeat2() & " and regular " & getVeggie2()
            ElseIf getVeggie2() = "None"
                description += getSize() & "  " & getCrust() & " pizza with " & getSauce() & " sauce, with double " & " and " & getMeat2() & " and regular " & getVeggie1()
            Else
                If _blnMeatExtra = True And String.Compare(getMeat1(), getMeat2) = 0 Then
                    description += getSize() & "  " & getCrust() & " pizza with " & getSauce() & " sauce, with double " & " and regular " & getVeggie1() & " and " & getVeggie2()
                Else
                    description += getSize() & "  " & getCrust() & " pizza with " & getSauce() & " sauce, with double " & " and " & getMeat2() & " and regular " & getVeggie1() & " and " & getVeggie2()
                End If

            End If
            Return description


        ElseIf _blnMeatExtra = False And _blnVeggieExtra = True
            If getMeat1() = "None" Then
                description += getSize() & "  " & getCrust() & " pizza with " & getSauce() & " sauce, with double " & " and " & getVeggie2() & " and regular " & getMeat2()
            ElseIf getMeat2() = "None"
                description += getSize() & "  " & getCrust() & " pizza with " & getSauce() & " sauce, with double " & " and " & getVeggie2() & " and regular " & getMeat1()
            Else
                If _blnVeggieExtra = True And String.Compare(getVeggie1(), getVeggie2) = 0 Then
                    description += getSize() & "  " & getCrust() & " pizza with " & getSauce() & " sauce, with regular " & " and " & getMeat2() & " double " & getVeggie1()
                Else
                    description += getSize() & "  " & getCrust() & " pizza with " & getSauce() & " sauce, with regular " & " and " & getMeat2() & " and double " & getVeggie1() & " and " & getVeggie2()
                End If

            End If
            Return description
        Else
            Return description
        End If
    End Function

End Class
