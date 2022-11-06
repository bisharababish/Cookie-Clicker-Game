<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Cookie = New System.Windows.Forms.PictureBox()
        Me.btnUpgrades = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCoins = New System.Windows.Forms.Label()
        Me.UpdateTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Cookie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cookie
        '
        Me.Cookie.BackColor = System.Drawing.Color.Transparent
        Me.Cookie.Image = Global.Cookie_Clicker_Game.My.Resources.Resources.Cookie
        Me.Cookie.Location = New System.Drawing.Point(54, 161)
        Me.Cookie.Name = "Cookie"
        Me.Cookie.Size = New System.Drawing.Size(163, 157)
        Me.Cookie.TabIndex = 0
        Me.Cookie.TabStop = False
        '
        'btnUpgrades
        '
        Me.btnUpgrades.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpgrades.Location = New System.Drawing.Point(183, 324)
        Me.btnUpgrades.Name = "btnUpgrades"
        Me.btnUpgrades.Size = New System.Drawing.Size(87, 27)
        Me.btnUpgrades.TabIndex = 1
        Me.btnUpgrades.Text = "Upgrades"
        Me.btnUpgrades.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Coins: "
        '
        'lblCoins
        '
        Me.lblCoins.AutoSize = True
        Me.lblCoins.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoins.Location = New System.Drawing.Point(79, 9)
        Me.lblCoins.Name = "lblCoins"
        Me.lblCoins.Size = New System.Drawing.Size(22, 23)
        Me.lblCoins.TabIndex = 3
        Me.lblCoins.Text = "0"
        '
        'UpdateTimer
        '
        Me.UpdateTimer.Enabled = True
        Me.UpdateTimer.Interval = 500
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(282, 356)
        Me.Controls.Add(Me.lblCoins)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnUpgrades)
        Me.Controls.Add(Me.Cookie)
        Me.Name = "Form1"
        Me.Text = "Cookie Clicker"
        CType(Me.Cookie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cookie As PictureBox
    Friend WithEvents btnUpgrades As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCoins As Label
    Friend WithEvents UpdateTimer As Timer
End Class
