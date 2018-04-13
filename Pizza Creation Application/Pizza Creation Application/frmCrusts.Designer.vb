<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCrusts
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
        Me.picPizza = New System.Windows.Forms.PictureBox()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.lblCrusts = New System.Windows.Forms.Label()
        Me.grpCrusts = New System.Windows.Forms.GroupBox()
        Me.radThin = New System.Windows.Forms.RadioButton()
        Me.radPan = New System.Windows.Forms.RadioButton()
        Me.radHandTossed = New System.Windows.Forms.RadioButton()
        Me.radDeepDish = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radXlarge = New System.Windows.Forms.RadioButton()
        Me.radLarge = New System.Windows.Forms.RadioButton()
        Me.radMed = New System.Windows.Forms.RadioButton()
        Me.radSmall = New System.Windows.Forms.RadioButton()
        Me.btnNext = New System.Windows.Forms.Button()
        CType(Me.picPizza, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCrusts.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.Firebrick
        Me.lblHeader.Location = New System.Drawing.Point(224, 28)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(292, 39)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Johnny's Pizzaria"
        '
        'picPizza
        '
        Me.picPizza.Location = New System.Drawing.Point(231, 109)
        Me.picPizza.Name = "picPizza"
        Me.picPizza.Size = New System.Drawing.Size(285, 247)
        Me.picPizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPizza.TabIndex = 1
        Me.picPizza.TabStop = False
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSize.ForeColor = System.Drawing.Color.Firebrick
        Me.lblSize.Location = New System.Drawing.Point(606, 109)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(49, 25)
        Me.lblSize.TabIndex = 2
        Me.lblSize.Text = "Size"
        '
        'lblCrusts
        '
        Me.lblCrusts.AutoSize = True
        Me.lblCrusts.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrusts.ForeColor = System.Drawing.Color.Firebrick
        Me.lblCrusts.Location = New System.Drawing.Point(335, 388)
        Me.lblCrusts.Name = "lblCrusts"
        Me.lblCrusts.Size = New System.Drawing.Size(70, 25)
        Me.lblCrusts.TabIndex = 3
        Me.lblCrusts.Text = "Crusts"
        '
        'grpCrusts
        '
        Me.grpCrusts.Controls.Add(Me.radThin)
        Me.grpCrusts.Controls.Add(Me.radPan)
        Me.grpCrusts.Controls.Add(Me.radHandTossed)
        Me.grpCrusts.Controls.Add(Me.radDeepDish)
        Me.grpCrusts.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCrusts.ForeColor = System.Drawing.Color.Firebrick
        Me.grpCrusts.Location = New System.Drawing.Point(187, 427)
        Me.grpCrusts.Name = "grpCrusts"
        Me.grpCrusts.Size = New System.Drawing.Size(380, 117)
        Me.grpCrusts.TabIndex = 4
        Me.grpCrusts.TabStop = False
        '
        'radThin
        '
        Me.radThin.AutoSize = True
        Me.radThin.Location = New System.Drawing.Point(225, 71)
        Me.radThin.Name = "radThin"
        Me.radThin.Size = New System.Drawing.Size(114, 27)
        Me.radThin.TabIndex = 3
        Me.radThin.Text = "Thin Crust"
        Me.radThin.UseVisualStyleBackColor = True
        Me.radThin.Visible = False
        '
        'radPan
        '
        Me.radPan.AutoSize = True
        Me.radPan.Checked = True
        Me.radPan.Location = New System.Drawing.Point(18, 71)
        Me.radPan.Name = "radPan"
        Me.radPan.Size = New System.Drawing.Size(105, 27)
        Me.radPan.TabIndex = 2
        Me.radPan.TabStop = True
        Me.radPan.Text = "Pan Pizza"
        Me.radPan.UseVisualStyleBackColor = True
        '
        'radHandTossed
        '
        Me.radHandTossed.AutoSize = True
        Me.radHandTossed.Location = New System.Drawing.Point(225, 29)
        Me.radHandTossed.Name = "radHandTossed"
        Me.radHandTossed.Size = New System.Drawing.Size(137, 27)
        Me.radHandTossed.TabIndex = 1
        Me.radHandTossed.Text = "Hand Tossed"
        Me.radHandTossed.UseVisualStyleBackColor = True
        Me.radHandTossed.Visible = False
        '
        'radDeepDish
        '
        Me.radDeepDish.AutoSize = True
        Me.radDeepDish.Location = New System.Drawing.Point(18, 29)
        Me.radDeepDish.Name = "radDeepDish"
        Me.radDeepDish.Size = New System.Drawing.Size(114, 27)
        Me.radDeepDish.TabIndex = 0
        Me.radDeepDish.Text = "Deep Dish"
        Me.radDeepDish.UseVisualStyleBackColor = True
        Me.radDeepDish.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radXlarge)
        Me.GroupBox1.Controls.Add(Me.radLarge)
        Me.GroupBox1.Controls.Add(Me.radMed)
        Me.GroupBox1.Controls.Add(Me.radSmall)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Firebrick
        Me.GroupBox1.Location = New System.Drawing.Point(550, 147)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(179, 209)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'radXlarge
        '
        Me.radXlarge.AutoSize = True
        Me.radXlarge.Location = New System.Drawing.Point(7, 165)
        Me.radXlarge.Name = "radXlarge"
        Me.radXlarge.Size = New System.Drawing.Size(158, 27)
        Me.radXlarge.TabIndex = 3
        Me.radXlarge.Text = "X-Large - $7.89"
        Me.radXlarge.UseVisualStyleBackColor = True
        '
        'radLarge
        '
        Me.radLarge.AutoSize = True
        Me.radLarge.Location = New System.Drawing.Point(7, 120)
        Me.radLarge.Name = "radLarge"
        Me.radLarge.Size = New System.Drawing.Size(140, 27)
        Me.radLarge.TabIndex = 2
        Me.radLarge.Text = "Large - $6.89"
        Me.radLarge.UseVisualStyleBackColor = True
        '
        'radMed
        '
        Me.radMed.AutoSize = True
        Me.radMed.Location = New System.Drawing.Point(7, 75)
        Me.radMed.Name = "radMed"
        Me.radMed.Size = New System.Drawing.Size(160, 27)
        Me.radMed.TabIndex = 1
        Me.radMed.Text = "Medium - $5.89"
        Me.radMed.UseVisualStyleBackColor = True
        '
        'radSmall
        '
        Me.radSmall.AutoSize = True
        Me.radSmall.Checked = True
        Me.radSmall.Location = New System.Drawing.Point(7, 30)
        Me.radSmall.Name = "radSmall"
        Me.radSmall.Size = New System.Drawing.Size(138, 27)
        Me.radSmall.TabIndex = 0
        Me.radSmall.TabStop = True
        Me.radSmall.Text = "Small - $4.89"
        Me.radSmall.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.PeachPuff
        Me.btnNext.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.Firebrick
        Me.btnNext.Location = New System.Drawing.Point(611, 474)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 35)
        Me.btnNext.TabIndex = 6
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'frmCrusts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(741, 583)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpCrusts)
        Me.Controls.Add(Me.lblCrusts)
        Me.Controls.Add(Me.lblSize)
        Me.Controls.Add(Me.picPizza)
        Me.Controls.Add(Me.lblHeader)
        Me.Name = "frmCrusts"
        Me.Text = "Pizza Creator"
        CType(Me.picPizza, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCrusts.ResumeLayout(False)
        Me.grpCrusts.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents picPizza As PictureBox
    Friend WithEvents lblSize As Label
    Friend WithEvents lblCrusts As Label
    Friend WithEvents grpCrusts As GroupBox
    Friend WithEvents radThin As RadioButton
    Friend WithEvents radPan As RadioButton
    Friend WithEvents radHandTossed As RadioButton
    Friend WithEvents radDeepDish As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radXlarge As RadioButton
    Friend WithEvents radLarge As RadioButton
    Friend WithEvents radMed As RadioButton
    Friend WithEvents radSmall As RadioButton
    Friend WithEvents btnNext As Button
End Class
