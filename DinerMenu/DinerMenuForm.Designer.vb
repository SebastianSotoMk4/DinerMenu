<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DinerMenuForm
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
        Me.LateNightButton = New System.Windows.Forms.Button()
        Me.TheVisualBasicButton = New System.Windows.Forms.Button()
        Me.CompileTunaButton = New System.Windows.Forms.Button()
        Me.VBLTButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.menuLabel = New System.Windows.Forms.Label()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LateNightButton
        '
        Me.LateNightButton.Location = New System.Drawing.Point(12, 378)
        Me.LateNightButton.Name = "LateNightButton"
        Me.LateNightButton.Size = New System.Drawing.Size(116, 60)
        Me.LateNightButton.TabIndex = 0
        Me.LateNightButton.Text = "Late Night Club"
        Me.LateNightButton.UseVisualStyleBackColor = True
        '
        'TheVisualBasicButton
        '
        Me.TheVisualBasicButton.Location = New System.Drawing.Point(134, 378)
        Me.TheVisualBasicButton.Name = "TheVisualBasicButton"
        Me.TheVisualBasicButton.Size = New System.Drawing.Size(116, 60)
        Me.TheVisualBasicButton.TabIndex = 1
        Me.TheVisualBasicButton.Text = "The Visual Basic"
        Me.TheVisualBasicButton.UseVisualStyleBackColor = True
        '
        'CompileTunaButton
        '
        Me.CompileTunaButton.Location = New System.Drawing.Point(256, 378)
        Me.CompileTunaButton.Name = "CompileTunaButton"
        Me.CompileTunaButton.Size = New System.Drawing.Size(116, 60)
        Me.CompileTunaButton.TabIndex = 2
        Me.CompileTunaButton.Text = "Compile Tuna"
        Me.CompileTunaButton.UseVisualStyleBackColor = True
        '
        'VBLTButton
        '
        Me.VBLTButton.Location = New System.Drawing.Point(378, 378)
        Me.VBLTButton.Name = "VBLTButton"
        Me.VBLTButton.Size = New System.Drawing.Size(116, 60)
        Me.VBLTButton.TabIndex = 3
        Me.VBLTButton.Text = "V.B.L.T"
        Me.VBLTButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Audi Type", 48.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(228, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(323, 78)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "VB's Subs"
        '
        'menuLabel
        '
        Me.menuLabel.Font = New System.Drawing.Font("Audi Type", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuLabel.Location = New System.Drawing.Point(157, 135)
        Me.menuLabel.Name = "menuLabel"
        Me.menuLabel.Size = New System.Drawing.Size(508, 185)
        Me.menuLabel.TabIndex = 6
        Me.menuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(713, 378)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 60)
        Me.exitButton.TabIndex = 7
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'DinerMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.VBLTButton)
        Me.Controls.Add(Me.menuLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CompileTunaButton)
        Me.Controls.Add(Me.TheVisualBasicButton)
        Me.Controls.Add(Me.LateNightButton)
        Me.Name = "DinerMenuForm"
        Me.Text = "VB's Subs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LateNightButton As Button
    Friend WithEvents TheVisualBasicButton As Button
    Friend WithEvents CompileTunaButton As Button
    Friend WithEvents VBLTButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents menuLabel As Label
    Friend WithEvents exitButton As Button
End Class
