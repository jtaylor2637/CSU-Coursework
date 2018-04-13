<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOther
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblCurrentOrder = New System.Windows.Forms.Label()
        Me.lblPizza = New System.Windows.Forms.Label()
        Me.lblDrinks = New System.Windows.Forms.Label()
        Me.lblBrownie = New System.Windows.Forms.Label()
        Me.lblCheesyBread = New System.Windows.Forms.Label()
        Me.lblCookie = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.chkCheesyBread = New System.Windows.Forms.CheckBox()
        Me.chkBrownie = New System.Windows.Forms.CheckBox()
        Me.chkDrinks = New System.Windows.Forms.CheckBox()
        Me.chkCookie = New System.Windows.Forms.CheckBox()
        Me.lblCraving = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.lblPizzaDescription = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.Firebrick
        Me.lblHeader.Location = New System.Drawing.Point(224, 32)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(292, 39)
        Me.lblHeader.TabIndex = 28
        Me.lblHeader.Text = "Johnny's Pizzaria"
        '
        'lblCurrentOrder
        '
        Me.lblCurrentOrder.AutoSize = True
        Me.lblCurrentOrder.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentOrder.ForeColor = System.Drawing.Color.Firebrick
        Me.lblCurrentOrder.Location = New System.Drawing.Point(458, 294)
        Me.lblCurrentOrder.Name = "lblCurrentOrder"
        Me.lblCurrentOrder.Size = New System.Drawing.Size(151, 25)
        Me.lblCurrentOrder.TabIndex = 30
        Me.lblCurrentOrder.Text = "Current Order:"
        '
        'lblPizza
        '
        Me.lblPizza.AutoSize = True
        Me.lblPizza.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPizza.ForeColor = System.Drawing.Color.Firebrick
        Me.lblPizza.Location = New System.Drawing.Point(458, 330)
        Me.lblPizza.Name = "lblPizza"
        Me.lblPizza.Size = New System.Drawing.Size(141, 25)
        Me.lblPizza.TabIndex = 31
        Me.lblPizza.Text = "Pizza - $18.89"
        '
        'lblDrinks
        '
        Me.lblDrinks.AutoSize = True
        Me.lblDrinks.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrinks.ForeColor = System.Drawing.Color.Firebrick
        Me.lblDrinks.Location = New System.Drawing.Point(458, 366)
        Me.lblDrinks.Name = "lblDrinks"
        Me.lblDrinks.Size = New System.Drawing.Size(133, 25)
        Me.lblDrinks.TabIndex = 32
        Me.lblDrinks.Text = "Drink - $2.89"
        Me.lblDrinks.Visible = False
        '
        'lblBrownie
        '
        Me.lblBrownie.AutoSize = True
        Me.lblBrownie.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrownie.ForeColor = System.Drawing.Color.Firebrick
        Me.lblBrownie.Location = New System.Drawing.Point(458, 402)
        Me.lblBrownie.Name = "lblBrownie"
        Me.lblBrownie.Size = New System.Drawing.Size(160, 25)
        Me.lblBrownie.TabIndex = 33
        Me.lblBrownie.Text = "Brownie - $3.49"
        Me.lblBrownie.Visible = False
        '
        'lblCheesyBread
        '
        Me.lblCheesyBread.AutoSize = True
        Me.lblCheesyBread.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCheesyBread.ForeColor = System.Drawing.Color.Firebrick
        Me.lblCheesyBread.Location = New System.Drawing.Point(458, 437)
        Me.lblCheesyBread.Name = "lblCheesyBread"
        Me.lblCheesyBread.Size = New System.Drawing.Size(212, 25)
        Me.lblCheesyBread.TabIndex = 34
        Me.lblCheesyBread.Text = "Cheesy Bread - $3.89"
        Me.lblCheesyBread.Visible = False
        '
        'lblCookie
        '
        Me.lblCookie.AutoSize = True
        Me.lblCookie.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCookie.ForeColor = System.Drawing.Color.Firebrick
        Me.lblCookie.Location = New System.Drawing.Point(458, 471)
        Me.lblCookie.Name = "lblCookie"
        Me.lblCookie.Size = New System.Drawing.Size(145, 25)
        Me.lblCookie.TabIndex = 35
        Me.lblCookie.Text = "Cookie - $2.49"
        Me.lblCookie.Visible = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Firebrick
        Me.lblTotal.Location = New System.Drawing.Point(553, 516)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(73, 25)
        Me.lblTotal.TabIndex = 36
        Me.lblTotal.Text = "$27.89"
        '
        'chkCheesyBread
        '
        Me.chkCheesyBread.AutoSize = True
        Me.chkCheesyBread.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCheesyBread.ForeColor = System.Drawing.Color.Firebrick
        Me.chkCheesyBread.Location = New System.Drawing.Point(40, 417)
        Me.chkCheesyBread.Name = "chkCheesyBread"
        Me.chkCheesyBread.Size = New System.Drawing.Size(226, 33)
        Me.chkCheesyBread.TabIndex = 39
        Me.chkCheesyBread.Text = "Add Cheesy Bread"
        Me.chkCheesyBread.UseVisualStyleBackColor = True
        '
        'chkBrownie
        '
        Me.chkBrownie.AutoSize = True
        Me.chkBrownie.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBrownie.ForeColor = System.Drawing.Color.Firebrick
        Me.chkBrownie.Location = New System.Drawing.Point(40, 378)
        Me.chkBrownie.Name = "chkBrownie"
        Me.chkBrownie.Size = New System.Drawing.Size(186, 33)
        Me.chkBrownie.TabIndex = 38
        Me.chkBrownie.Text = "Add a Brownie"
        Me.chkBrownie.UseVisualStyleBackColor = True
        '
        'chkDrinks
        '
        Me.chkDrinks.AutoSize = True
        Me.chkDrinks.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDrinks.ForeColor = System.Drawing.Color.Firebrick
        Me.chkDrinks.Location = New System.Drawing.Point(40, 339)
        Me.chkDrinks.Name = "chkDrinks"
        Me.chkDrinks.Size = New System.Drawing.Size(156, 33)
        Me.chkDrinks.TabIndex = 37
        Me.chkDrinks.Text = "Add a Drink"
        Me.chkDrinks.UseVisualStyleBackColor = True
        '
        'chkCookie
        '
        Me.chkCookie.AutoSize = True
        Me.chkCookie.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCookie.ForeColor = System.Drawing.Color.Firebrick
        Me.chkCookie.Location = New System.Drawing.Point(40, 456)
        Me.chkCookie.Name = "chkCookie"
        Me.chkCookie.Size = New System.Drawing.Size(171, 33)
        Me.chkCookie.TabIndex = 40
        Me.chkCookie.Text = "Add a Cookie"
        Me.chkCookie.UseVisualStyleBackColor = True
        '
        'lblCraving
        '
        Me.lblCraving.AutoSize = True
        Me.lblCraving.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCraving.ForeColor = System.Drawing.Color.Firebrick
        Me.lblCraving.Location = New System.Drawing.Point(35, 290)
        Me.lblCraving.Name = "lblCraving"
        Me.lblCraving.Size = New System.Drawing.Size(254, 29)
        Me.lblCraving.TabIndex = 41
        Me.lblCraving.Text = "Craving Something?"
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.PeachPuff
        Me.btnNext.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.Firebrick
        Me.btnNext.Location = New System.Drawing.Point(267, 506)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 35)
        Me.btnNext.TabIndex = 43
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'lblPizzaDescription
        '
        Me.lblPizzaDescription.AutoSize = True
        Me.lblPizzaDescription.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPizzaDescription.ForeColor = System.Drawing.Color.Firebrick
        Me.lblPizzaDescription.Location = New System.Drawing.Point(12, 87)
        Me.lblPizzaDescription.Name = "lblPizzaDescription"
        Me.lblPizzaDescription.Size = New System.Drawing.Size(96, 32)
        Me.lblPizzaDescription.TabIndex = 44
        Me.lblPizzaDescription.Text = "XXXXXXXXXXX" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "XXXXXXXXXXX"
        Me.lblPizzaDescription.Visible = False
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.ForeColor = System.Drawing.Color.Firebrick
        Me.lblPrice.Location = New System.Drawing.Point(458, 516)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(65, 25)
        Me.lblPrice.TabIndex = 45
        Me.lblPrice.Text = "Total:"
        '
        'btnRestart
        '
        Me.btnRestart.BackColor = System.Drawing.Color.PeachPuff
        Me.btnRestart.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestart.ForeColor = System.Drawing.Color.Firebrick
        Me.btnRestart.Location = New System.Drawing.Point(40, 506)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(87, 35)
        Me.btnRestart.TabIndex = 46
        Me.btnRestart.Text = "Restart"
        Me.btnRestart.UseVisualStyleBackColor = False
        '
        'frmOther
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(741, 583)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblPizzaDescription)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblCraving)
        Me.Controls.Add(Me.chkCookie)
        Me.Controls.Add(Me.chkCheesyBread)
        Me.Controls.Add(Me.chkBrownie)
        Me.Controls.Add(Me.chkDrinks)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblCookie)
        Me.Controls.Add(Me.lblCheesyBread)
        Me.Controls.Add(Me.lblBrownie)
        Me.Controls.Add(Me.lblDrinks)
        Me.Controls.Add(Me.lblPizza)
        Me.Controls.Add(Me.lblCurrentOrder)
        Me.Controls.Add(Me.lblHeader)
        Me.Name = "frmOther"
        Me.Text = "Pizza Creator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents lblCurrentOrder As Label
    Friend WithEvents lblPizza As Label
    Friend WithEvents lblDrinks As Label
    Friend WithEvents lblBrownie As Label
    Friend WithEvents lblCheesyBread As Label
    Friend WithEvents lblCookie As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents chkCheesyBread As CheckBox
    Friend WithEvents chkBrownie As CheckBox
    Friend WithEvents chkDrinks As CheckBox
    Friend WithEvents chkCookie As CheckBox
    Friend WithEvents lblCraving As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents lblPizzaDescription As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents btnRestart As Button
End Class
