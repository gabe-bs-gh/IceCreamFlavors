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
        Me.lstFlavor = New System.Windows.Forms.ListBox()
        Me.picIceCream = New System.Windows.Forms.PictureBox()
        CType(Me.picIceCream, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstFlavor
        '
        Me.lstFlavor.FormattingEnabled = True
        Me.lstFlavor.Items.AddRange(New Object() {"Vanilla", "Chocolate", "Strawberry", "Blueberry", "Mint"})
        Me.lstFlavor.Location = New System.Drawing.Point(188, 67)
        Me.lstFlavor.Name = "lstFlavor"
        Me.lstFlavor.Size = New System.Drawing.Size(120, 95)
        Me.lstFlavor.TabIndex = 0
        '
        'picIceCream
        '
        Me.picIceCream.Image = Global.IceCreamFlavors.My.Resources.Resources.Chocolate_icecream
        Me.picIceCream.Location = New System.Drawing.Point(12, 12)
        Me.picIceCream.Name = "picIceCream"
        Me.picIceCream.Size = New System.Drawing.Size(152, 207)
        Me.picIceCream.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picIceCream.TabIndex = 1
        Me.picIceCream.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 241)
        Me.Controls.Add(Me.picIceCream)
        Me.Controls.Add(Me.lstFlavor)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picIceCream, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstFlavor As ListBox
    Friend WithEvents picIceCream As PictureBox
End Class
