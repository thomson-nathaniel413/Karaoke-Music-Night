<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKaraoke
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKaraoke))
        Me.pnlKaraoke = New System.Windows.Forms.Panel()
        Me.lblKaraoke = New System.Windows.Forms.Label()
        Me.lblPurchaseInputIndicator = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.txtPurchaseInput = New System.Windows.Forms.TextBox()
        Me.btnCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.cboPurchaseType = New System.Windows.Forms.ComboBox()
        Me.pnlKaraoke.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlKaraoke
        '
        Me.pnlKaraoke.BackColor = System.Drawing.SystemColors.WindowText
        Me.pnlKaraoke.Controls.Add(Me.cboPurchaseType)
        Me.pnlKaraoke.Controls.Add(Me.btnClear)
        Me.pnlKaraoke.Controls.Add(Me.btnCost)
        Me.pnlKaraoke.Controls.Add(Me.txtPurchaseInput)
        Me.pnlKaraoke.Controls.Add(Me.lblCost)
        Me.pnlKaraoke.Controls.Add(Me.lblPurchaseInputIndicator)
        Me.pnlKaraoke.Controls.Add(Me.lblKaraoke)
        Me.pnlKaraoke.Location = New System.Drawing.Point(285, -2)
        Me.pnlKaraoke.Name = "pnlKaraoke"
        Me.pnlKaraoke.Size = New System.Drawing.Size(497, 449)
        Me.pnlKaraoke.TabIndex = 0
        '
        'lblKaraoke
        '
        Me.lblKaraoke.AutoSize = True
        Me.lblKaraoke.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKaraoke.ForeColor = System.Drawing.SystemColors.Window
        Me.lblKaraoke.Location = New System.Drawing.Point(135, 60)
        Me.lblKaraoke.Name = "lblKaraoke"
        Me.lblKaraoke.Size = New System.Drawing.Size(218, 29)
        Me.lblKaraoke.TabIndex = 0
        Me.lblKaraoke.Text = "Karaoke Music Night"
        '
        'lblPurchaseInputIndicator
        '
        Me.lblPurchaseInputIndicator.AutoSize = True
        Me.lblPurchaseInputIndicator.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPurchaseInputIndicator.ForeColor = System.Drawing.SystemColors.Window
        Me.lblPurchaseInputIndicator.Location = New System.Drawing.Point(204, 205)
        Me.lblPurchaseInputIndicator.Name = "lblPurchaseInputIndicator"
        Me.lblPurchaseInputIndicator.Size = New System.Drawing.Size(90, 19)
        Me.lblPurchaseInputIndicator.TabIndex = 1
        Me.lblPurchaseInputIndicator.Text = "placeholder"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.ForeColor = System.Drawing.SystemColors.Window
        Me.lblCost.Location = New System.Drawing.Point(216, 379)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(74, 19)
        Me.lblCost.TabIndex = 2
        Me.lblCost.Text = "total cost"
        '
        'txtPurchaseInput
        '
        Me.txtPurchaseInput.Location = New System.Drawing.Point(220, 259)
        Me.txtPurchaseInput.Name = "txtPurchaseInput"
        Me.txtPurchaseInput.Size = New System.Drawing.Size(45, 26)
        Me.txtPurchaseInput.TabIndex = 3
        '
        'btnCost
        '
        Me.btnCost.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCost.Location = New System.Drawing.Point(84, 326)
        Me.btnCost.Name = "btnCost"
        Me.btnCost.Size = New System.Drawing.Size(100, 30)
        Me.btnCost.TabIndex = 4
        Me.btnCost.Text = "Total Cost"
        Me.btnCost.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(321, 326)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 30)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'cboPurchaseType
        '
        Me.cboPurchaseType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPurchaseType.FormattingEnabled = True
        Me.cboPurchaseType.Items.AddRange(New Object() {"Number of songs ($2.99 per song)", "Private karaoke room ($8.99 per hour)"})
        Me.cboPurchaseType.Location = New System.Drawing.Point(84, 123)
        Me.cboPurchaseType.Name = "cboPurchaseType"
        Me.cboPurchaseType.Size = New System.Drawing.Size(337, 28)
        Me.cboPurchaseType.TabIndex = 6
        Me.cboPurchaseType.Text = "Customize your night"
        '
        'frmKaraoke
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(778, 444)
        Me.Controls.Add(Me.pnlKaraoke)
        Me.Name = "frmKaraoke"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Karaoke Music Night"
        Me.pnlKaraoke.ResumeLayout(False)
        Me.pnlKaraoke.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlKaraoke As Panel
    Friend WithEvents lblKaraoke As Label
    Friend WithEvents lblPurchaseInputIndicator As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents txtPurchaseInput As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCost As Button
    Friend WithEvents cboPurchaseType As ComboBox
End Class
