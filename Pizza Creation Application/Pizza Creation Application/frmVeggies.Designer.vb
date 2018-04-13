<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVeggies
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
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.grpVeggies = New System.Windows.Forms.GroupBox()
        Me.radDouble = New System.Windows.Forms.RadioButton()
        Me.radRegular = New System.Windows.Forms.RadioButton()
        Me.radNone = New System.Windows.Forms.RadioButton()
        Me.lblVeggies = New System.Windows.Forms.Label()
        Me.picPizza = New System.Windows.Forms.PictureBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.cboTopping1 = New System.Windows.Forms.ComboBox()
        Me.cboTopping2 = New System.Windows.Forms.ComboBox()
        Me.grpVeggies.SuspendLayout()
        CType(Me.picPizza, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPrev
        '
        Me.btnPrev.BackColor = System.Drawing.Color.PeachPuff
        Me.btnPrev.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrev.ForeColor = System.Drawing.Color.Firebrick
        Me.btnPrev.Location = New System.Drawing.Point(57, 363)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(75, 35)
        Me.btnPrev.TabIndex = 32
        Me.btnPrev.Text = "Prev"
        Me.btnPrev.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.PeachPuff
        Me.btnNext.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.Firebrick
        Me.btnNext.Location = New System.Drawing.Point(608, 363)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 35)
        Me.btnNext.TabIndex = 31
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'grpVeggies
        '
        Me.grpVeggies.Controls.Add(Me.radDouble)
        Me.grpVeggies.Controls.Add(Me.radRegular)
        Me.grpVeggies.Controls.Add(Me.radNone)
        Me.grpVeggies.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpVeggies.ForeColor = System.Drawing.Color.Firebrick
        Me.grpVeggies.Location = New System.Drawing.Point(580, 419)
        Me.grpVeggies.Name = "grpVeggies"
        Me.grpVeggies.Size = New System.Drawing.Size(135, 152)
        Me.grpVeggies.TabIndex = 30
        Me.grpVeggies.TabStop = False
        Me.grpVeggies.Text = "    Amount"
        '
        'radDouble
        '
        Me.radDouble.AutoSize = True
        Me.radDouble.Location = New System.Drawing.Point(18, 109)
        Me.radDouble.Name = "radDouble"
        Me.radDouble.Size = New System.Drawing.Size(87, 27)
        Me.radDouble.TabIndex = 3
        Me.radDouble.TabStop = True
        Me.radDouble.Text = "Double"
        Me.radDouble.UseVisualStyleBackColor = True
        '
        'radRegular
        '
        Me.radRegular.AutoSize = True
        Me.radRegular.Location = New System.Drawing.Point(18, 69)
        Me.radRegular.Name = "radRegular"
        Me.radRegular.Size = New System.Drawing.Size(93, 27)
        Me.radRegular.TabIndex = 2
        Me.radRegular.TabStop = True
        Me.radRegular.Text = "Regular"
        Me.radRegular.UseVisualStyleBackColor = True
        '
        'radNone
        '
        Me.radNone.AutoSize = True
        Me.radNone.Location = New System.Drawing.Point(18, 29)
        Me.radNone.Name = "radNone"
        Me.radNone.Size = New System.Drawing.Size(72, 27)
        Me.radNone.TabIndex = 0
        Me.radNone.TabStop = True
        Me.radNone.Text = "None"
        Me.radNone.UseVisualStyleBackColor = True
        '
        'lblVeggies
        '
        Me.lblVeggies.AutoSize = True
        Me.lblVeggies.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVeggies.ForeColor = System.Drawing.Color.Firebrick
        Me.lblVeggies.Location = New System.Drawing.Point(338, 367)
        Me.lblVeggies.Name = "lblVeggies"
        Me.lblVeggies.Size = New System.Drawing.Size(85, 25)
        Me.lblVeggies.TabIndex = 29
        Me.lblVeggies.Text = "Veggies"
        '
        'picPizza
        '
        Me.picPizza.Location = New System.Drawing.Point(233, 103)
        Me.picPizza.Name = "picPizza"
        Me.picPizza.Size = New System.Drawing.Size(285, 247)
        Me.picPizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPizza.TabIndex = 28
        Me.picPizza.TabStop = False
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.Firebrick
        Me.lblHeader.Location = New System.Drawing.Point(226, 22)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(292, 39)
        Me.lblHeader.TabIndex = 27
        Me.lblHeader.Text = "Johnny's Pizzaria"
        '
        'cboTopping1
        '
        Me.cboTopping1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTopping1.ForeColor = System.Drawing.Color.Firebrick
        Me.cboTopping1.FormattingEnabled = True
        Me.cboTopping1.Items.AddRange(New Object() {"None", "Onions", "Olives", "Mushrooms", "Spinach", "Jalapenos", "Pineapple"})
        Me.cboTopping1.Location = New System.Drawing.Point(57, 419)
        Me.cboTopping1.Name = "cboTopping1"
        Me.cboTopping1.Size = New System.Drawing.Size(166, 31)
        Me.cboTopping1.TabIndex = 39
        '
        'cboTopping2
        '
        Me.cboTopping2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTopping2.ForeColor = System.Drawing.Color.Firebrick
        Me.cboTopping2.FormattingEnabled = True
        Me.cboTopping2.Items.AddRange(New Object() {"None", "Onions", "Olives", "Mushrooms", "Spinach", "Jalapenos", "Pineapple"})
        Me.cboTopping2.Location = New System.Drawing.Point(288, 419)
        Me.cboTopping2.Name = "cboTopping2"
        Me.cboTopping2.Size = New System.Drawing.Size(166, 31)
        Me.cboTopping2.TabIndex = 40
        '
        'frmVeggies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(741, 583)
        Me.Controls.Add(Me.cboTopping2)
        Me.Controls.Add(Me.cboTopping1)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.grpVeggies)
        Me.Controls.Add(Me.lblVeggies)
        Me.Controls.Add(Me.picPizza)
        Me.Controls.Add(Me.lblHeader)
        Me.Name = "frmVeggies"
        Me.Text = "Pizza Creator"
        Me.grpVeggies.ResumeLayout(False)
        Me.grpVeggies.PerformLayout()
        CType(Me.picPizza, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPrev As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents grpVeggies As GroupBox
    Friend WithEvents radDouble As RadioButton
    Friend WithEvents radRegular As RadioButton
    Friend WithEvents radNone As RadioButton
    Friend WithEvents lblVeggies As Label
    Friend WithEvents picPizza As PictureBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents cboTopping1 As ComboBox
    Friend WithEvents cboTopping2 As ComboBox
End Class
