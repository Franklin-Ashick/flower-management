<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class flowers_type
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(flowers_type))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.type = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.color = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.bycolor = New System.Windows.Forms.Panel()
        Me.yellow = New Bunifu.Framework.UI.BunifuTileButton()
        Me.purple = New Bunifu.Framework.UI.BunifuTileButton()
        Me.mixedcolor = New Bunifu.Framework.UI.BunifuTileButton()
        Me.pink = New Bunifu.Framework.UI.BunifuTileButton()
        Me.white = New Bunifu.Framework.UI.BunifuTileButton()
        Me.red = New Bunifu.Framework.UI.BunifuTileButton()
        Me.Bytype = New System.Windows.Forms.Panel()
        Me.mixed = New Bunifu.Framework.UI.BunifuTileButton()
        Me.lily = New Bunifu.Framework.UI.BunifuTileButton()
        Me.orchids = New Bunifu.Framework.UI.BunifuTileButton()
        Me.rose = New Bunifu.Framework.UI.BunifuTileButton()
        Me.tulip = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BunifuCustomLabel11 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel1.SuspendLayout()
        Me.bycolor.SuspendLayout()
        Me.Bytype.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel11)
        Me.Panel1.Controls.Add(Me.type)
        Me.Panel1.Controls.Add(Me.color)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(171, 601)
        Me.Panel1.TabIndex = 5
        '
        'type
        '
        Me.type.ActiveBorderThickness = 1
        Me.type.ActiveCornerRadius = 20
        Me.type.ActiveFillColor = System.Drawing.Color.DarkGreen
        Me.type.ActiveForecolor = System.Drawing.Color.Transparent
        Me.type.ActiveLineColor = System.Drawing.Color.DarkGreen
        Me.type.BackColor = System.Drawing.Color.Transparent
        Me.type.BackgroundImage = CType(resources.GetObject("type.BackgroundImage"), System.Drawing.Image)
        Me.type.ButtonText = "By Type"
        Me.type.Cursor = System.Windows.Forms.Cursors.Hand
        Me.type.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.type.ForeColor = System.Drawing.Color.DarkGreen
        Me.type.IdleBorderThickness = 1
        Me.type.IdleCornerRadius = 30
        Me.type.IdleFillColor = System.Drawing.Color.Transparent
        Me.type.IdleForecolor = System.Drawing.Color.DarkGreen
        Me.type.IdleLineColor = System.Drawing.Color.DarkGreen
        Me.type.Location = New System.Drawing.Point(9, 276)
        Me.type.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.type.Name = "type"
        Me.type.Size = New System.Drawing.Size(153, 50)
        Me.type.TabIndex = 17
        Me.type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'color
        '
        Me.color.ActiveBorderThickness = 1
        Me.color.ActiveCornerRadius = 20
        Me.color.ActiveFillColor = System.Drawing.Color.DarkGreen
        Me.color.ActiveForecolor = System.Drawing.Color.Transparent
        Me.color.ActiveLineColor = System.Drawing.Color.DarkGreen
        Me.color.BackColor = System.Drawing.Color.Transparent
        Me.color.BackgroundImage = CType(resources.GetObject("color.BackgroundImage"), System.Drawing.Image)
        Me.color.ButtonText = "By Color"
        Me.color.Cursor = System.Windows.Forms.Cursors.Hand
        Me.color.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.color.ForeColor = System.Drawing.Color.DarkGreen
        Me.color.IdleBorderThickness = 1
        Me.color.IdleCornerRadius = 30
        Me.color.IdleFillColor = System.Drawing.Color.Transparent
        Me.color.IdleForecolor = System.Drawing.Color.DarkGreen
        Me.color.IdleLineColor = System.Drawing.Color.DarkGreen
        Me.color.Location = New System.Drawing.Point(9, 202)
        Me.color.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.color.Name = "color"
        Me.color.Size = New System.Drawing.Size(153, 50)
        Me.color.TabIndex = 16
        Me.color.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bycolor
        '
        Me.bycolor.BackColor = System.Drawing.Color.Transparent
        Me.bycolor.Controls.Add(Me.yellow)
        Me.bycolor.Controls.Add(Me.purple)
        Me.bycolor.Controls.Add(Me.mixedcolor)
        Me.bycolor.Controls.Add(Me.pink)
        Me.bycolor.Controls.Add(Me.white)
        Me.bycolor.Controls.Add(Me.red)
        Me.bycolor.Location = New System.Drawing.Point(179, 15)
        Me.bycolor.Margin = New System.Windows.Forms.Padding(4)
        Me.bycolor.Name = "bycolor"
        Me.bycolor.Size = New System.Drawing.Size(899, 571)
        Me.bycolor.TabIndex = 18
        '
        'yellow
        '
        Me.yellow.BackColor = System.Drawing.Color.Transparent
        Me.yellow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.yellow.color = System.Drawing.Color.Transparent
        Me.yellow.colorActive = System.Drawing.Color.AliceBlue
        Me.yellow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.yellow.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yellow.ForeColor = System.Drawing.Color.MidnightBlue
        Me.yellow.Image = CType(resources.GetObject("yellow.Image"), System.Drawing.Image)
        Me.yellow.ImagePosition = 20
        Me.yellow.ImageZoom = 55
        Me.yellow.LabelPosition = 35
        Me.yellow.LabelText = "Yellow"
        Me.yellow.Location = New System.Drawing.Point(320, 284)
        Me.yellow.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.yellow.Name = "yellow"
        Me.yellow.Size = New System.Drawing.Size(196, 181)
        Me.yellow.TabIndex = 16
        '
        'purple
        '
        Me.purple.BackColor = System.Drawing.Color.Transparent
        Me.purple.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.purple.color = System.Drawing.Color.Transparent
        Me.purple.colorActive = System.Drawing.Color.AliceBlue
        Me.purple.Cursor = System.Windows.Forms.Cursors.Hand
        Me.purple.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.purple.ForeColor = System.Drawing.Color.MidnightBlue
        Me.purple.Image = CType(resources.GetObject("purple.Image"), System.Drawing.Image)
        Me.purple.ImagePosition = 20
        Me.purple.ImageZoom = 55
        Me.purple.LabelPosition = 35
        Me.purple.LabelText = "Purple"
        Me.purple.Location = New System.Drawing.Point(51, 284)
        Me.purple.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.purple.Name = "purple"
        Me.purple.Size = New System.Drawing.Size(196, 181)
        Me.purple.TabIndex = 13
        '
        'mixedcolor
        '
        Me.mixedcolor.BackColor = System.Drawing.Color.Transparent
        Me.mixedcolor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.mixedcolor.color = System.Drawing.Color.Transparent
        Me.mixedcolor.colorActive = System.Drawing.Color.AliceBlue
        Me.mixedcolor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mixedcolor.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mixedcolor.ForeColor = System.Drawing.Color.MidnightBlue
        Me.mixedcolor.Image = CType(resources.GetObject("mixedcolor.Image"), System.Drawing.Image)
        Me.mixedcolor.ImagePosition = 20
        Me.mixedcolor.ImageZoom = 55
        Me.mixedcolor.LabelPosition = 35
        Me.mixedcolor.LabelText = "Mixed"
        Me.mixedcolor.Location = New System.Drawing.Point(597, 284)
        Me.mixedcolor.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.mixedcolor.Name = "mixedcolor"
        Me.mixedcolor.Size = New System.Drawing.Size(196, 181)
        Me.mixedcolor.TabIndex = 12
        '
        'pink
        '
        Me.pink.BackColor = System.Drawing.Color.Transparent
        Me.pink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pink.color = System.Drawing.Color.Transparent
        Me.pink.colorActive = System.Drawing.Color.AliceBlue
        Me.pink.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pink.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pink.ForeColor = System.Drawing.Color.MidnightBlue
        Me.pink.Image = CType(resources.GetObject("pink.Image"), System.Drawing.Image)
        Me.pink.ImagePosition = 20
        Me.pink.ImageZoom = 55
        Me.pink.LabelPosition = 35
        Me.pink.LabelText = "Pink"
        Me.pink.Location = New System.Drawing.Point(320, 37)
        Me.pink.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.pink.Name = "pink"
        Me.pink.Size = New System.Drawing.Size(196, 181)
        Me.pink.TabIndex = 11
        '
        'white
        '
        Me.white.BackColor = System.Drawing.Color.Transparent
        Me.white.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.white.color = System.Drawing.Color.Transparent
        Me.white.colorActive = System.Drawing.Color.AliceBlue
        Me.white.Cursor = System.Windows.Forms.Cursors.Hand
        Me.white.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.white.ForeColor = System.Drawing.Color.MidnightBlue
        Me.white.Image = CType(resources.GetObject("white.Image"), System.Drawing.Image)
        Me.white.ImagePosition = 20
        Me.white.ImageZoom = 55
        Me.white.LabelPosition = 35
        Me.white.LabelText = "White"
        Me.white.Location = New System.Drawing.Point(597, 37)
        Me.white.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.white.Name = "white"
        Me.white.Size = New System.Drawing.Size(196, 181)
        Me.white.TabIndex = 10
        '
        'red
        '
        Me.red.BackColor = System.Drawing.Color.Transparent
        Me.red.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.red.color = System.Drawing.Color.Transparent
        Me.red.colorActive = System.Drawing.Color.AliceBlue
        Me.red.Cursor = System.Windows.Forms.Cursors.Hand
        Me.red.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.red.ForeColor = System.Drawing.Color.MidnightBlue
        Me.red.Image = CType(resources.GetObject("red.Image"), System.Drawing.Image)
        Me.red.ImagePosition = 20
        Me.red.ImageZoom = 55
        Me.red.LabelPosition = 35
        Me.red.LabelText = "Red"
        Me.red.Location = New System.Drawing.Point(51, 37)
        Me.red.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.red.Name = "red"
        Me.red.Size = New System.Drawing.Size(196, 181)
        Me.red.TabIndex = 9
        '
        'Bytype
        '
        Me.Bytype.BackColor = System.Drawing.Color.Transparent
        Me.Bytype.Controls.Add(Me.mixed)
        Me.Bytype.Controls.Add(Me.lily)
        Me.Bytype.Controls.Add(Me.orchids)
        Me.Bytype.Controls.Add(Me.rose)
        Me.Bytype.Controls.Add(Me.tulip)
        Me.Bytype.Location = New System.Drawing.Point(179, 11)
        Me.Bytype.Margin = New System.Windows.Forms.Padding(4)
        Me.Bytype.Name = "Bytype"
        Me.Bytype.Size = New System.Drawing.Size(899, 571)
        Me.Bytype.TabIndex = 19
        '
        'mixed
        '
        Me.mixed.BackColor = System.Drawing.Color.Transparent
        Me.mixed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.mixed.color = System.Drawing.Color.Transparent
        Me.mixed.colorActive = System.Drawing.Color.AliceBlue
        Me.mixed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mixed.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mixed.ForeColor = System.Drawing.Color.MidnightBlue
        Me.mixed.Image = CType(resources.GetObject("mixed.Image"), System.Drawing.Image)
        Me.mixed.ImagePosition = 20
        Me.mixed.ImageZoom = 55
        Me.mixed.LabelPosition = 35
        Me.mixed.LabelText = "Mixed"
        Me.mixed.Location = New System.Drawing.Point(320, 284)
        Me.mixed.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.mixed.Name = "mixed"
        Me.mixed.Size = New System.Drawing.Size(196, 181)
        Me.mixed.TabIndex = 12
        '
        'lily
        '
        Me.lily.BackColor = System.Drawing.Color.Transparent
        Me.lily.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.lily.color = System.Drawing.Color.Transparent
        Me.lily.colorActive = System.Drawing.Color.AliceBlue
        Me.lily.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lily.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lily.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lily.Image = CType(resources.GetObject("lily.Image"), System.Drawing.Image)
        Me.lily.ImagePosition = 20
        Me.lily.ImageZoom = 55
        Me.lily.LabelPosition = 35
        Me.lily.LabelText = "Lily"
        Me.lily.Location = New System.Drawing.Point(320, 37)
        Me.lily.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.lily.Name = "lily"
        Me.lily.Size = New System.Drawing.Size(196, 181)
        Me.lily.TabIndex = 11
        '
        'orchids
        '
        Me.orchids.BackColor = System.Drawing.Color.Transparent
        Me.orchids.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.orchids.color = System.Drawing.Color.Transparent
        Me.orchids.colorActive = System.Drawing.Color.AliceBlue
        Me.orchids.Cursor = System.Windows.Forms.Cursors.Hand
        Me.orchids.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.orchids.ForeColor = System.Drawing.Color.MidnightBlue
        Me.orchids.Image = CType(resources.GetObject("orchids.Image"), System.Drawing.Image)
        Me.orchids.ImagePosition = 20
        Me.orchids.ImageZoom = 55
        Me.orchids.LabelPosition = 35
        Me.orchids.LabelText = "Orchids"
        Me.orchids.Location = New System.Drawing.Point(597, 37)
        Me.orchids.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.orchids.Name = "orchids"
        Me.orchids.Size = New System.Drawing.Size(196, 181)
        Me.orchids.TabIndex = 10
        '
        'rose
        '
        Me.rose.BackColor = System.Drawing.Color.Transparent
        Me.rose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.rose.color = System.Drawing.Color.Transparent
        Me.rose.colorActive = System.Drawing.Color.AliceBlue
        Me.rose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rose.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rose.ForeColor = System.Drawing.Color.MidnightBlue
        Me.rose.Image = CType(resources.GetObject("rose.Image"), System.Drawing.Image)
        Me.rose.ImagePosition = 20
        Me.rose.ImageZoom = 55
        Me.rose.LabelPosition = 35
        Me.rose.LabelText = "Rose"
        Me.rose.Location = New System.Drawing.Point(51, 37)
        Me.rose.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.rose.Name = "rose"
        Me.rose.Size = New System.Drawing.Size(196, 181)
        Me.rose.TabIndex = 9
        '
        'tulip
        '
        Me.tulip.BackColor = System.Drawing.Color.Transparent
        Me.tulip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tulip.color = System.Drawing.Color.Transparent
        Me.tulip.colorActive = System.Drawing.Color.AliceBlue
        Me.tulip.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tulip.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tulip.ForeColor = System.Drawing.Color.MidnightBlue
        Me.tulip.Image = CType(resources.GetObject("tulip.Image"), System.Drawing.Image)
        Me.tulip.ImagePosition = 20
        Me.tulip.ImageZoom = 55
        Me.tulip.LabelPosition = 35
        Me.tulip.LabelText = "Tulip"
        Me.tulip.Location = New System.Drawing.Point(51, 284)
        Me.tulip.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.tulip.Name = "tulip"
        Me.tulip.Size = New System.Drawing.Size(196, 181)
        Me.tulip.TabIndex = 13
        '
        'BunifuCustomLabel11
        '
        Me.BunifuCustomLabel11.AutoSize = True
        Me.BunifuCustomLabel11.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel11.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel11.Location = New System.Drawing.Point(4, 9)
        Me.BunifuCustomLabel11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BunifuCustomLabel11.Name = "BunifuCustomLabel11"
        Me.BunifuCustomLabel11.Size = New System.Drawing.Size(111, 39)
        Me.BunifuCustomLabel11.TabIndex = 24
        Me.BunifuCustomLabel11.Text = "BACK"
        '
        'flowers_type
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1091, 601)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Bytype)
        Me.Controls.Add(Me.bycolor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "flowers_type"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "bycolor"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.bycolor.ResumeLayout(False)
        Me.Bytype.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents type As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents color As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents bycolor As Panel
    Friend WithEvents yellow As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents purple As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents mixedcolor As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents pink As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents white As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents red As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents Bytype As Panel
    Friend WithEvents mixed As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents lily As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents orchids As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents rose As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents tulip As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BunifuCustomLabel11 As Bunifu.Framework.UI.BunifuCustomLabel
End Class
