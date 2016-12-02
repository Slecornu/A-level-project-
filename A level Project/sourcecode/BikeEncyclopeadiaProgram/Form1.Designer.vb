<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BalfeBikeInterface
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BalfeBikeInterface))
        Me.ProductName = New System.Windows.Forms.Label()
        Me.PriceRange = New System.Windows.Forms.Label()
        Me.RetailPriceRange = New System.Windows.Forms.Label()
        Me.ProductDescription = New System.Windows.Forms.RichTextBox()
        Me.label = New System.Windows.Forms.Label()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.ProductImage = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BikeDiagram = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HelpButton = New System.Windows.Forms.Button()
        CType(Me.ProductImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BikeDiagram, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductName
        '
        Me.ProductName.AutoSize = True
        Me.ProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductName.Location = New System.Drawing.Point(862, 456)
        Me.ProductName.Name = "ProductName"
        Me.ProductName.Size = New System.Drawing.Size(0, 25)
        Me.ProductName.TabIndex = 36
        '
        'PriceRange
        '
        Me.PriceRange.AutoSize = True
        Me.PriceRange.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceRange.Location = New System.Drawing.Point(1020, 669)
        Me.PriceRange.Name = "PriceRange"
        Me.PriceRange.Size = New System.Drawing.Size(0, 24)
        Me.PriceRange.TabIndex = 35
        '
        'RetailPriceRange
        '
        Me.RetailPriceRange.AutoSize = True
        Me.RetailPriceRange.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RetailPriceRange.Location = New System.Drawing.Point(858, 669)
        Me.RetailPriceRange.Name = "RetailPriceRange"
        Me.RetailPriceRange.Size = New System.Drawing.Size(0, 24)
        Me.RetailPriceRange.TabIndex = 34
        '
        'ProductDescription
        '
        Me.ProductDescription.BackColor = System.Drawing.Color.Red
        Me.ProductDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ProductDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductDescription.ForeColor = System.Drawing.Color.White
        Me.ProductDescription.Location = New System.Drawing.Point(862, 484)
        Me.ProductDescription.Name = "ProductDescription"
        Me.ProductDescription.ReadOnly = True
        Me.ProductDescription.Size = New System.Drawing.Size(482, 182)
        Me.ProductDescription.TabIndex = 33
        Me.ProductDescription.Text = ""
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.Location = New System.Drawing.Point(876, 409)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(0, 25)
        Me.label.TabIndex = 32
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.Color.Red
        Me.RichTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox2.ForeColor = System.Drawing.Color.White
        Me.RichTextBox2.Location = New System.Drawing.Point(287, 488)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.ReadOnly = True
        Me.RichTextBox2.Size = New System.Drawing.Size(565, 221)
        Me.RichTextBox2.TabIndex = 31
        Me.RichTextBox2.Text = resources.GetString("RichTextBox2.Text")
        '
        'Panel
        '
        Me.Panel.AutoScroll = True
        Me.Panel.Location = New System.Drawing.Point(18, 85)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(258, 633)
        Me.Panel.TabIndex = 30
        '
        'ProductImage
        '
        Me.ProductImage.Location = New System.Drawing.Point(862, 80)
        Me.ProductImage.Name = "ProductImage"
        Me.ProductImage.Size = New System.Drawing.Size(474, 373)
        Me.ProductImage.TabIndex = 29
        Me.ProductImage.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(282, 456)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(256, 25)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Welcome to Balfes Bikes!"
        '
        'BikeDiagram
        '
        Me.BikeDiagram.Image = CType(resources.GetObject("BikeDiagram.Image"), System.Drawing.Image)
        Me.BikeDiagram.Location = New System.Drawing.Point(287, 80)
        Me.BikeDiagram.Name = "BikeDiagram"
        Me.BikeDiagram.Size = New System.Drawing.Size(565, 374)
        Me.BikeDiagram.TabIndex = 27
        Me.BikeDiagram.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("SF Electrotome", 48.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(5, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(347, 67)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "BALFES BIKES"
        '
        'HelpButton
        '
        Me.HelpButton.BackColor = System.Drawing.Color.Red
        Me.HelpButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton.Location = New System.Drawing.Point(287, 678)
        Me.HelpButton.Name = "HelpButton"
        Me.HelpButton.Size = New System.Drawing.Size(103, 40)
        Me.HelpButton.TabIndex = 37
        Me.HelpButton.Text = "Help"
        Me.HelpButton.UseVisualStyleBackColor = False
        '
        'BalfeBikeInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(1284, 730)
        Me.Controls.Add(Me.HelpButton)
        Me.Controls.Add(Me.ProductName)
        Me.Controls.Add(Me.PriceRange)
        Me.Controls.Add(Me.RetailPriceRange)
        Me.Controls.Add(Me.ProductDescription)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.Panel)
        Me.Controls.Add(Me.ProductImage)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BikeDiagram)
        Me.Controls.Add(Me.Label1)
        Me.Name = "BalfeBikeInterface"
        Me.Text = "Welcome to the store's encyclopedia!"
        CType(Me.ProductImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BikeDiagram, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProductName As System.Windows.Forms.Label
    Friend WithEvents PriceRange As System.Windows.Forms.Label
    Friend WithEvents RetailPriceRange As System.Windows.Forms.Label
    Friend WithEvents ProductDescription As System.Windows.Forms.RichTextBox
    Friend WithEvents label As System.Windows.Forms.Label
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents Panel As System.Windows.Forms.Panel
    Friend WithEvents ProductImage As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BikeDiagram As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents HelpButton As System.Windows.Forms.Button

End Class
