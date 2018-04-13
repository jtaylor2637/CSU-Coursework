<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrder
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
        Me.lblOrderNum = New System.Windows.Forms.Label()
        Me.lblOrderTotal = New System.Windows.Forms.Label()
        Me.lblDeliver = New System.Windows.Forms.Label()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnComplete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.Firebrick
        Me.lblHeader.Location = New System.Drawing.Point(115, 26)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(491, 78)
        Me.lblHeader.TabIndex = 29
        Me.lblHeader.Text = "Thank You For Ordering From" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "            Johnny's Pizzaria" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblOrderNum
        '
        Me.lblOrderNum.AutoSize = True
        Me.lblOrderNum.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderNum.ForeColor = System.Drawing.Color.Firebrick
        Me.lblOrderNum.Location = New System.Drawing.Point(82, 198)
        Me.lblOrderNum.Name = "lblOrderNum"
        Me.lblOrderNum.Size = New System.Drawing.Size(192, 29)
        Me.lblOrderNum.TabIndex = 31
        Me.lblOrderNum.Text = "Order Number:"
        '
        'lblOrderTotal
        '
        Me.lblOrderTotal.AutoSize = True
        Me.lblOrderTotal.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderTotal.ForeColor = System.Drawing.Color.Firebrick
        Me.lblOrderTotal.Location = New System.Drawing.Point(82, 274)
        Me.lblOrderTotal.Name = "lblOrderTotal"
        Me.lblOrderTotal.Size = New System.Drawing.Size(157, 29)
        Me.lblOrderTotal.TabIndex = 32
        Me.lblOrderTotal.Text = "Order Total:"
        '
        'lblDeliver
        '
        Me.lblDeliver.AutoSize = True
        Me.lblDeliver.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeliver.ForeColor = System.Drawing.Color.Firebrick
        Me.lblDeliver.Location = New System.Drawing.Point(82, 358)
        Me.lblDeliver.Name = "lblDeliver"
        Me.lblDeliver.Size = New System.Drawing.Size(143, 29)
        Me.lblDeliver.TabIndex = 33
        Me.lblDeliver.Text = "Deliver To:"
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber.ForeColor = System.Drawing.Color.Firebrick
        Me.lblNumber.Location = New System.Drawing.Point(305, 198)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(105, 29)
        Me.lblNumber.TabIndex = 34
        Me.lblNumber.Text = "1X375B"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.ForeColor = System.Drawing.Color.Firebrick
        Me.lblCost.Location = New System.Drawing.Point(305, 274)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(96, 29)
        Me.lblCost.TabIndex = 35
        Me.lblCost.Text = "$22.89"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Firebrick
        Me.TextBox1.Location = New System.Drawing.Point(310, 358)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(392, 33)
        Me.TextBox1.TabIndex = 36
        '
        'btnComplete
        '
        Me.btnComplete.BackColor = System.Drawing.Color.PeachPuff
        Me.btnComplete.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComplete.ForeColor = System.Drawing.Color.Firebrick
        Me.btnComplete.Location = New System.Drawing.Point(225, 513)
        Me.btnComplete.Name = "btnComplete"
        Me.btnComplete.Size = New System.Drawing.Size(290, 35)
        Me.btnComplete.TabIndex = 44
        Me.btnComplete.Text = "Complete Order"
        Me.btnComplete.UseVisualStyleBackColor = False
        '
        'frmOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(741, 583)
        Me.Controls.Add(Me.btnComplete)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.lblDeliver)
        Me.Controls.Add(Me.lblOrderTotal)
        Me.Controls.Add(Me.lblOrderNum)
        Me.Controls.Add(Me.lblHeader)
        Me.Name = "frmOrder"
        Me.Text = "Pizza Creator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents lblOrderNum As Label
    Friend WithEvents lblOrderTotal As Label
    Friend WithEvents lblDeliver As Label
    Friend WithEvents lblNumber As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnComplete As Button
End Class
