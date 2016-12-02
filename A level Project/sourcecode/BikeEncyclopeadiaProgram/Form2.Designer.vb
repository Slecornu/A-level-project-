<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HelpInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HelpInformation))
        Me.HelpInformationLabel = New System.Windows.Forms.Label()
        Me.GoBackButton = New System.Windows.Forms.Button()
        Me.Information = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'HelpInformationLabel
        '
        Me.HelpInformationLabel.AutoSize = True
        Me.HelpInformationLabel.Font = New System.Drawing.Font("SF Electrotome", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpInformationLabel.ForeColor = System.Drawing.Color.White
        Me.HelpInformationLabel.Location = New System.Drawing.Point(13, 13)
        Me.HelpInformationLabel.Name = "HelpInformationLabel"
        Me.HelpInformationLabel.Size = New System.Drawing.Size(412, 67)
        Me.HelpInformationLabel.TabIndex = 0
        Me.HelpInformationLabel.Text = "Help Informaiton"
        '
        'GoBackButton
        '
        Me.GoBackButton.BackColor = System.Drawing.Color.Red
        Me.GoBackButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GoBackButton.Location = New System.Drawing.Point(12, 678)
        Me.GoBackButton.Name = "GoBackButton"
        Me.GoBackButton.Size = New System.Drawing.Size(103, 40)
        Me.GoBackButton.TabIndex = 38
        Me.GoBackButton.Text = "Go Back"
        Me.GoBackButton.UseVisualStyleBackColor = False
        '
        'Information
        '
        Me.Information.BackColor = System.Drawing.Color.Red
        Me.Information.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Information.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Information.ForeColor = System.Drawing.Color.Transparent
        Me.Information.Location = New System.Drawing.Point(15, 98)
        Me.Information.Name = "Information"
        Me.Information.Size = New System.Drawing.Size(1247, 561)
        Me.Information.TabIndex = 39
        Me.Information.Text = resources.GetString("Information.Text")
        '
        'HelpInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(1284, 730)
        Me.Controls.Add(Me.Information)
        Me.Controls.Add(Me.GoBackButton)
        Me.Controls.Add(Me.HelpInformationLabel)
        Me.Name = "HelpInformation"
        Me.Text = "Welcome to the store's encyclopedia!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HelpInformationLabel As System.Windows.Forms.Label
    Friend WithEvents GoBackButton As System.Windows.Forms.Button
    Friend WithEvents Information As System.Windows.Forms.RichTextBox
End Class
