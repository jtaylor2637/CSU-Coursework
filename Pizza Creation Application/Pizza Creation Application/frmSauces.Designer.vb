<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSauces
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
        Me.btnNext = New System.Windows.Forms.Button()
        Me.grpSauces = New System.Windows.Forms.GroupBox()
        Me.radJalapeno = New System.Windows.Forms.RadioButton()
        Me.radBarbeque = New System.Windows.Forms.RadioButton()
        Me.radBuffalo = New System.Windows.Forms.RadioButton()
        Me.radMarinara = New System.Windows.Forms.RadioButton()
        Me.lblSauces = New System.Windows.Forms.Label()
        Me.picPizza = New System.Windows.Forms.PictureBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.grpSauces.SuspendLayout()
        CType(Me.picPizza, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.PeachPuff
        Me.btnNext.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.Firebrick
        Me.btnNext.Location = New System.Drawing.Point(603, 480)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 35)
        Me.btnNext.TabIndex = 13
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'grpSauces
        '
        Me.grpSauces.Controls.Add(Me.radJalapeno)
        Me.grpSauces.Controls.Add(Me.radBarbeque)
        Me.grpSauces.Controls.Add(Me.radBuffalo)
        Me.grpSauces.Controls.Add(Me.radMarinara)
        Me.grpSauces.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSauces.ForeColor = System.Drawing.Color.Firebrick
        Me.grpSauces.Location = New System.Drawing.Point(179, 433)
        Me.grpSauces.Name = "grpSauces"
        Me.grpSauces.Size = New System.Drawing.Size(380, 117)
        Me.grpSauces.TabIndex = 11
        Me.grpSauces.TabStop = False
        '
        'radJalapeno
        '
        Me.radJalapeno.AutoSize = True
        Me.radJalapeno.Location = New System.Drawing.Point(193, 71)
        Me.radJalapeno.Name = "radJalapeno"
        Me.radJalapeno.Size = New System.Drawing.Size(168, 27)
        Me.radJalapeno.TabIndex = 3
        Me.radJalapeno.TabStop = True
        Me.radJalapeno.Text = "Jalapeno Xtreme"
        Me.radJalapeno.UseVisualStyleBackColor = True
        '
        'radBarbeque
        '
        Me.radBarbeque.AutoSize = True
        Me.radBarbeque.Location = New System.Drawing.Point(44, 71)
        Me.radBarbeque.Name = "radBarbeque"
        Me.radBarbeque.Size = New System.Drawing.Size(109, 27)
        Me.radBarbeque.TabIndex = 2
        Me.radBarbeque.TabStop = True
        Me.radBarbeque.Text = "Barbeque"
        Me.radBarbeque.UseVisualStyleBackColor = True
        '
        'radBuffalo
        '
        Me.radBuffalo.AutoSize = True
        Me.radBuffalo.Location = New System.Drawing.Point(193, 29)
        Me.radBuffalo.Name = "radBuffalo"
        Me.radBuffalo.Size = New System.Drawing.Size(86, 27)
        Me.radBuffalo.TabIndex = 1
        Me.radBuffalo.TabStop = True
        Me.radBuffalo.Text = "Buffalo"
        Me.radBuffalo.UseVisualStyleBackColor = True
        '
        'radMarinara
        '
        Me.radMarinara.AutoSize = True
        Me.radMarinara.Location = New System.Drawing.Point(44, 29)
        Me.radMarinara.Name = "radMarinara"
        Me.radMarinara.Size = New System.Drawing.Size(102, 27)
        Me.radMarinara.TabIndex = 0
        Me.radMarinara.TabStop = True
        Me.radMarinara.Text = "Marinara"
        Me.radMarinara.UseVisualStyleBackColor = True
        '
        'lblSauces
        '
        Me.lblSauces.AutoSize = True
        Me.lblSauces.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSauces.ForeColor = System.Drawing.Color.Firebrick
        Me.lblSauces.Location = New System.Drawing.Point(327, 394)
        Me.lblSauces.Name = "lblSauces"
        Me.lblSauces.Size = New System.Drawing.Size(77, 25)
        Me.lblSauces.TabIndex = 10
        Me.lblSauces.Text = "Sauces"
        '
        'picPizza
        '
        Me.picPizza.Location = New System.Drawing.Point(223, 115)
        Me.picPizza.Name = "picPizza"
        Me.picPizza.Size = New System.Drawing.Size(285, 247)
        Me.picPizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPizza.TabIndex = 8
        Me.picPizza.TabStop = False
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.Firebrick
        Me.lblHeader.Location = New System.Drawing.Point(216, 34)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(292, 39)
        Me.lblHeader.TabIndex = 7
        Me.lblHeader.Text = "Johnny's Pizzaria"
        '
        'btnPrev
        '
        Me.btnPrev.BackColor = System.Drawing.Color.PeachPuff
        Me.btnPrev.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrev.ForeColor = System.Drawing.Color.Firebrick
        Me.btnPrev.Location = New System.Drawing.Point(46, 480)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(75, 35)
        Me.btnPrev.TabIndex = 14
        Me.btnPrev.Text = "Prev"
        Me.btnPrev.UseVisualStyleBackColor = False
        '
        'frmSauces
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(741, 583)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.grpSauces)
        Me.Controls.Add(Me.lblSauces)
        Me.Controls.Add(Me.picPizza)
        Me.Controls.Add(Me.lblHeader)
        Me.Name = "frmSauces"
        Me.Text = "Pizza Creator"
        Me.grpSauces.ResumeLayout(False)
        Me.grpSauces.PerformLayout()
        CType(Me.picPizza, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNext As Button
    Friend WithEvents grpSauces As GroupBox
    Friend WithEvents radJalapeno As RadioButton
    Friend WithEvents radBarbeque As RadioButton
    Friend WithEvents radBuffalo As RadioButton
    Friend WithEvents radMarinara As RadioButton
    Friend WithEvents lblSauces As Label
    Friend WithEvents picPizza As PictureBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents btnPrev As Button
End Class
