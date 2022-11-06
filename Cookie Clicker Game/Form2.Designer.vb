<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblExtraFingersPrice = New System.Windows.Forms.Label()
        Me.btnBuyExtraFingers = New System.Windows.Forms.Button()
        Me.lblExtraFingers = New System.Windows.Forms.Label()
        Me.lblGrandmaPrice = New System.Windows.Forms.Label()
        Me.lblGrandma = New System.Windows.Forms.Label()
        Me.btnBuyGrandma = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(192, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Upgrades"
        '
        'lblExtraFingersPrice
        '
        Me.lblExtraFingersPrice.AutoSize = True
        Me.lblExtraFingersPrice.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExtraFingersPrice.Location = New System.Drawing.Point(12, 55)
        Me.lblExtraFingersPrice.Name = "lblExtraFingersPrice"
        Me.lblExtraFingersPrice.Size = New System.Drawing.Size(148, 19)
        Me.lblExtraFingersPrice.TabIndex = 1
        Me.lblExtraFingersPrice.Text = "Extra Fingers: 20"
        '
        'btnBuyExtraFingers
        '
        Me.btnBuyExtraFingers.Location = New System.Drawing.Point(227, 55)
        Me.btnBuyExtraFingers.Name = "btnBuyExtraFingers"
        Me.btnBuyExtraFingers.Size = New System.Drawing.Size(75, 35)
        Me.btnBuyExtraFingers.TabIndex = 2
        Me.btnBuyExtraFingers.Text = "Buy"
        Me.btnBuyExtraFingers.UseVisualStyleBackColor = True
        '
        'lblExtraFingers
        '
        Me.lblExtraFingers.AutoSize = True
        Me.lblExtraFingers.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExtraFingers.Location = New System.Drawing.Point(13, 74)
        Me.lblExtraFingers.Name = "lblExtraFingers"
        Me.lblExtraFingers.Size = New System.Drawing.Size(202, 16)
        Me.lblExtraFingers.TabIndex = 3
        Me.lblExtraFingers.Text = "Adds one more cookie per click: 0"
        '
        'lblGrandmaPrice
        '
        Me.lblGrandmaPrice.AutoSize = True
        Me.lblGrandmaPrice.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrandmaPrice.Location = New System.Drawing.Point(308, 55)
        Me.lblGrandmaPrice.Name = "lblGrandmaPrice"
        Me.lblGrandmaPrice.Size = New System.Drawing.Size(122, 19)
        Me.lblGrandmaPrice.TabIndex = 5
        Me.lblGrandmaPrice.Text = "Grandmas: 15"
        '
        'lblGrandma
        '
        Me.lblGrandma.AutoSize = True
        Me.lblGrandma.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrandma.Location = New System.Drawing.Point(309, 74)
        Me.lblGrandma.Name = "lblGrandma"
        Me.lblGrandma.Size = New System.Drawing.Size(232, 16)
        Me.lblGrandma.TabIndex = 6
        Me.lblGrandma.Text = "Makes one cookie every ten seconds: 0"
        '
        'btnBuyGrandma
        '
        Me.btnBuyGrandma.Location = New System.Drawing.Point(552, 55)
        Me.btnBuyGrandma.Name = "btnBuyGrandma"
        Me.btnBuyGrandma.Size = New System.Drawing.Size(75, 35)
        Me.btnBuyGrandma.TabIndex = 7
        Me.btnBuyGrandma.Text = "Buy"
        Me.btnBuyGrandma.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(618, 356)
        Me.Controls.Add(Me.btnBuyGrandma)
        Me.Controls.Add(Me.lblGrandma)
        Me.Controls.Add(Me.lblGrandmaPrice)
        Me.Controls.Add(Me.lblExtraFingers)
        Me.Controls.Add(Me.btnBuyExtraFingers)
        Me.Controls.Add(Me.lblExtraFingersPrice)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Upgrades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblExtraFingersPrice As Label
    Friend WithEvents btnBuyExtraFingers As Button
    Friend WithEvents lblExtraFingers As Label
    Friend WithEvents lblGrandmaPrice As Label
    Friend WithEvents lblGrandma As Label
    Friend WithEvents btnBuyGrandma As Button
End Class
