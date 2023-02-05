<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Flower_Cart
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Flower_Cart))
        Me.amount = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.quality = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.DataGridView1 = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.CartIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CartBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FlowersDataSet7 = New Flower_management.flowersDataSet7()
        Me.CartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FlowersDataSet1 = New Flower_management.flowersDataSet1()
        Me.CartTableAdapter = New Flower_management.flowersDataSet1TableAdapters.cartTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.add_btt = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.delete_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.update_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.purchase_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Textbox1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Textbox3 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Textbox2 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Textbox4 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel2 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel3 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel4 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel5 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel6 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel7 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel8 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuCustomLabel11 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.CartTableAdapter1 = New Flower_management.flowersDataSet7TableAdapters.cartTableAdapter()
        Me.BunifuLabel10 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel11 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.Textbox5 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.CART = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CartBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlowersDataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlowersDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'amount
        '
        Me.amount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.amount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.amount.BackColor = System.Drawing.Color.Gainsboro
        Me.amount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.amount.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.amount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.amount.Enabled = False
        Me.amount.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amount.ForeColor = System.Drawing.Color.Black
        Me.amount.HintForeColor = System.Drawing.Color.Empty
        Me.amount.HintText = ""
        Me.amount.isPassword = False
        Me.amount.LineFocusedColor = System.Drawing.Color.DimGray
        Me.amount.LineIdleColor = System.Drawing.Color.Gray
        Me.amount.LineMouseHoverColor = System.Drawing.Color.Black
        Me.amount.LineThickness = 3
        Me.amount.Location = New System.Drawing.Point(363, 14)
        Me.amount.Margin = New System.Windows.Forms.Padding(5)
        Me.amount.MaxLength = 32767
        Me.amount.Name = "amount"
        Me.amount.Size = New System.Drawing.Size(167, 43)
        Me.amount.TabIndex = 9
        Me.amount.Text = "Amount"
        Me.amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'quality
        '
        Me.quality.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.quality.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.quality.BackColor = System.Drawing.Color.Gainsboro
        Me.quality.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.quality.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.quality.Enabled = False
        Me.quality.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quality.ForeColor = System.Drawing.Color.Black
        Me.quality.HintForeColor = System.Drawing.Color.Black
        Me.quality.HintText = ""
        Me.quality.isPassword = False
        Me.quality.LineFocusedColor = System.Drawing.Color.DimGray
        Me.quality.LineIdleColor = System.Drawing.Color.Gray
        Me.quality.LineMouseHoverColor = System.Drawing.Color.Black
        Me.quality.LineThickness = 3
        Me.quality.Location = New System.Drawing.Point(161, 14)
        Me.quality.Margin = New System.Windows.Forms.Padding(5)
        Me.quality.MaxLength = 32767
        Me.quality.Name = "quality"
        Me.quality.Size = New System.Drawing.Size(160, 43)
        Me.quality.TabIndex = 8
        Me.quality.Text = "Quantity"
        Me.quality.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowCustomTheming = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView1.ColumnHeadersHeight = 40
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CartIdDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.ProductDataGridViewTextBoxColumn, Me.AmtDataGridViewTextBoxColumn, Me.price})
        Me.DataGridView1.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.DataGridView1.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.DataGridView1.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.DataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.DataGridView1.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.DataGridView1.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.DataGridView1.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.DataGridView1.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.DataGridView1.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView1.CurrentTheme.Name = Nothing
        Me.DataGridView1.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.DataGridView1.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.DataGridView1.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.DataGridView1.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.DataSource = Me.CartBindingSource1
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.DataGridView1.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.DataGridView1.HeaderBgColor = System.Drawing.Color.Empty
        Me.DataGridView1.HeaderForeColor = System.Drawing.Color.White
        Me.DataGridView1.Location = New System.Drawing.Point(506, 1)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 40
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(606, 523)
        Me.DataGridView1.TabIndex = 10
        Me.DataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark
        '
        'CartIdDataGridViewTextBoxColumn
        '
        Me.CartIdDataGridViewTextBoxColumn.DataPropertyName = "cart_Id"
        Me.CartIdDataGridViewTextBoxColumn.HeaderText = "cart_Id"
        Me.CartIdDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CartIdDataGridViewTextBoxColumn.Name = "CartIdDataGridViewTextBoxColumn"
        Me.CartIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "quantity"
        Me.QuantityDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        '
        'ProductDataGridViewTextBoxColumn
        '
        Me.ProductDataGridViewTextBoxColumn.DataPropertyName = "product"
        Me.ProductDataGridViewTextBoxColumn.HeaderText = "product"
        Me.ProductDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ProductDataGridViewTextBoxColumn.Name = "ProductDataGridViewTextBoxColumn"
        '
        'AmtDataGridViewTextBoxColumn
        '
        Me.AmtDataGridViewTextBoxColumn.DataPropertyName = "amt"
        Me.AmtDataGridViewTextBoxColumn.HeaderText = "amt"
        Me.AmtDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AmtDataGridViewTextBoxColumn.Name = "AmtDataGridViewTextBoxColumn"
        '
        'price
        '
        Me.price.DataPropertyName = "price"
        Me.price.HeaderText = "price"
        Me.price.MinimumWidth = 6
        Me.price.Name = "price"
        '
        'CartBindingSource1
        '
        Me.CartBindingSource1.DataMember = "cart"
        Me.CartBindingSource1.DataSource = Me.FlowersDataSet7
        '
        'FlowersDataSet7
        '
        Me.FlowersDataSet7.DataSetName = "flowersDataSet7"
        Me.FlowersDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CartBindingSource
        '
        Me.CartBindingSource.DataMember = "cart"
        Me.CartBindingSource.DataSource = Me.FlowersDataSet1
        '
        'FlowersDataSet1
        '
        Me.FlowersDataSet1.DataSetName = "flowersDataSet1"
        Me.FlowersDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CartTableAdapter
        '
        Me.CartTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.BunifuThinButton21)
        Me.Panel1.Controls.Add(Me.quality)
        Me.Panel1.Controls.Add(Me.amount)
        Me.Panel1.Location = New System.Drawing.Point(540, 545)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(535, 70)
        Me.Panel1.TabIndex = 11
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 20
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuThinButton21.BackColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "Total"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.LightGray
        Me.BunifuThinButton21.Location = New System.Drawing.Point(7, 6)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(143, 50)
        Me.BunifuThinButton21.TabIndex = 0
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'add_btt
        '
        Me.add_btt.ActiveBorderThickness = 1
        Me.add_btt.ActiveCornerRadius = 20
        Me.add_btt.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.add_btt.ActiveForecolor = System.Drawing.Color.White
        Me.add_btt.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.add_btt.BackColor = System.Drawing.Color.Transparent
        Me.add_btt.BackgroundImage = CType(resources.GetObject("add_btt.BackgroundImage"), System.Drawing.Image)
        Me.add_btt.ButtonText = "Add"
        Me.add_btt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.add_btt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_btt.ForeColor = System.Drawing.Color.White
        Me.add_btt.IdleBorderThickness = 1
        Me.add_btt.IdleCornerRadius = 20
        Me.add_btt.IdleFillColor = System.Drawing.Color.Transparent
        Me.add_btt.IdleForecolor = System.Drawing.Color.WhiteSmoke
        Me.add_btt.IdleLineColor = System.Drawing.Color.LightGray
        Me.add_btt.Location = New System.Drawing.Point(41, 20)
        Me.add_btt.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.add_btt.Name = "add_btt"
        Me.add_btt.Size = New System.Drawing.Size(143, 50)
        Me.add_btt.TabIndex = 12
        Me.add_btt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.delete_btn)
        Me.Panel2.Controls.Add(Me.update_btn)
        Me.Panel2.Controls.Add(Me.purchase_btn)
        Me.Panel2.Controls.Add(Me.add_btt)
        Me.Panel2.Location = New System.Drawing.Point(33, 476)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(465, 139)
        Me.Panel2.TabIndex = 13
        '
        'delete_btn
        '
        Me.delete_btn.ActiveBorderThickness = 1
        Me.delete_btn.ActiveCornerRadius = 20
        Me.delete_btn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.delete_btn.ActiveForecolor = System.Drawing.Color.White
        Me.delete_btn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.delete_btn.BackColor = System.Drawing.Color.Transparent
        Me.delete_btn.BackgroundImage = CType(resources.GetObject("delete_btn.BackgroundImage"), System.Drawing.Image)
        Me.delete_btn.ButtonText = "Delete"
        Me.delete_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.delete_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete_btn.ForeColor = System.Drawing.Color.White
        Me.delete_btn.IdleBorderThickness = 1
        Me.delete_btn.IdleCornerRadius = 20
        Me.delete_btn.IdleFillColor = System.Drawing.Color.Transparent
        Me.delete_btn.IdleForecolor = System.Drawing.Color.WhiteSmoke
        Me.delete_btn.IdleLineColor = System.Drawing.Color.LightGray
        Me.delete_btn.Location = New System.Drawing.Point(41, 78)
        Me.delete_btn.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.delete_btn.Name = "delete_btn"
        Me.delete_btn.Size = New System.Drawing.Size(143, 50)
        Me.delete_btn.TabIndex = 15
        Me.delete_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'update_btn
        '
        Me.update_btn.ActiveBorderThickness = 1
        Me.update_btn.ActiveCornerRadius = 20
        Me.update_btn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.update_btn.ActiveForecolor = System.Drawing.Color.White
        Me.update_btn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.update_btn.BackColor = System.Drawing.Color.Transparent
        Me.update_btn.BackgroundImage = CType(resources.GetObject("update_btn.BackgroundImage"), System.Drawing.Image)
        Me.update_btn.ButtonText = "Update"
        Me.update_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.update_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update_btn.ForeColor = System.Drawing.Color.White
        Me.update_btn.IdleBorderThickness = 1
        Me.update_btn.IdleCornerRadius = 20
        Me.update_btn.IdleFillColor = System.Drawing.Color.Transparent
        Me.update_btn.IdleForecolor = System.Drawing.Color.WhiteSmoke
        Me.update_btn.IdleLineColor = System.Drawing.Color.LightGray
        Me.update_btn.Location = New System.Drawing.Point(272, 20)
        Me.update_btn.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.update_btn.Name = "update_btn"
        Me.update_btn.Size = New System.Drawing.Size(143, 50)
        Me.update_btn.TabIndex = 14
        Me.update_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'purchase_btn
        '
        Me.purchase_btn.ActiveBorderThickness = 1
        Me.purchase_btn.ActiveCornerRadius = 20
        Me.purchase_btn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.purchase_btn.ActiveForecolor = System.Drawing.Color.White
        Me.purchase_btn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.purchase_btn.BackColor = System.Drawing.Color.Transparent
        Me.purchase_btn.BackgroundImage = CType(resources.GetObject("purchase_btn.BackgroundImage"), System.Drawing.Image)
        Me.purchase_btn.ButtonText = "Purchase"
        Me.purchase_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.purchase_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.purchase_btn.ForeColor = System.Drawing.Color.White
        Me.purchase_btn.IdleBorderThickness = 1
        Me.purchase_btn.IdleCornerRadius = 20
        Me.purchase_btn.IdleFillColor = System.Drawing.Color.Transparent
        Me.purchase_btn.IdleForecolor = System.Drawing.Color.WhiteSmoke
        Me.purchase_btn.IdleLineColor = System.Drawing.Color.LightGray
        Me.purchase_btn.Location = New System.Drawing.Point(272, 78)
        Me.purchase_btn.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.purchase_btn.Name = "purchase_btn"
        Me.purchase_btn.Size = New System.Drawing.Size(143, 50)
        Me.purchase_btn.TabIndex = 13
        Me.purchase_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Textbox1
        '
        Me.Textbox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.Textbox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.Textbox1.BackColor = System.Drawing.Color.Gainsboro
        Me.Textbox1.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Textbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Textbox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CartBindingSource, "cart_Id", True))
        Me.Textbox1.Enabled = False
        Me.Textbox1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textbox1.ForeColor = System.Drawing.Color.Black
        Me.Textbox1.HintForeColor = System.Drawing.Color.Black
        Me.Textbox1.HintText = ""
        Me.Textbox1.isPassword = False
        Me.Textbox1.LineFocusedColor = System.Drawing.Color.DimGray
        Me.Textbox1.LineIdleColor = System.Drawing.Color.Gray
        Me.Textbox1.LineMouseHoverColor = System.Drawing.Color.Black
        Me.Textbox1.LineThickness = 3
        Me.Textbox1.Location = New System.Drawing.Point(279, 108)
        Me.Textbox1.Margin = New System.Windows.Forms.Padding(5)
        Me.Textbox1.MaxLength = 32767
        Me.Textbox1.Name = "Textbox1"
        Me.Textbox1.Size = New System.Drawing.Size(160, 43)
        Me.Textbox1.TabIndex = 10
        Me.Textbox1.Text = "Cart ID"
        Me.Textbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Textbox3
        '
        Me.Textbox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.Textbox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.Textbox3.BackColor = System.Drawing.Color.Gainsboro
        Me.Textbox3.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Textbox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Textbox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CartBindingSource, "product", True))
        Me.Textbox3.Enabled = False
        Me.Textbox3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textbox3.ForeColor = System.Drawing.Color.Black
        Me.Textbox3.HintForeColor = System.Drawing.Color.Black
        Me.Textbox3.HintText = ""
        Me.Textbox3.isPassword = False
        Me.Textbox3.LineFocusedColor = System.Drawing.Color.DimGray
        Me.Textbox3.LineIdleColor = System.Drawing.Color.Gray
        Me.Textbox3.LineMouseHoverColor = System.Drawing.Color.Black
        Me.Textbox3.LineThickness = 3
        Me.Textbox3.Location = New System.Drawing.Point(279, 241)
        Me.Textbox3.Margin = New System.Windows.Forms.Padding(5)
        Me.Textbox3.MaxLength = 32767
        Me.Textbox3.Name = "Textbox3"
        Me.Textbox3.Size = New System.Drawing.Size(160, 43)
        Me.Textbox3.TabIndex = 14
        Me.Textbox3.Text = "Product"
        Me.Textbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Textbox2
        '
        Me.Textbox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.Textbox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.Textbox2.BackColor = System.Drawing.Color.Gainsboro
        Me.Textbox2.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Textbox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Textbox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CartBindingSource, "quantity", True))
        Me.Textbox2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textbox2.ForeColor = System.Drawing.Color.Black
        Me.Textbox2.HintForeColor = System.Drawing.Color.Black
        Me.Textbox2.HintText = ""
        Me.Textbox2.isPassword = False
        Me.Textbox2.LineFocusedColor = System.Drawing.Color.DimGray
        Me.Textbox2.LineIdleColor = System.Drawing.Color.Gray
        Me.Textbox2.LineMouseHoverColor = System.Drawing.Color.Black
        Me.Textbox2.LineThickness = 3
        Me.Textbox2.Location = New System.Drawing.Point(279, 174)
        Me.Textbox2.Margin = New System.Windows.Forms.Padding(5)
        Me.Textbox2.MaxLength = 32767
        Me.Textbox2.Name = "Textbox2"
        Me.Textbox2.Size = New System.Drawing.Size(160, 43)
        Me.Textbox2.TabIndex = 15
        Me.Textbox2.Text = "Quantity"
        Me.Textbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Textbox4
        '
        Me.Textbox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.Textbox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.Textbox4.BackColor = System.Drawing.Color.Gainsboro
        Me.Textbox4.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Textbox4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Textbox4.Enabled = False
        Me.Textbox4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textbox4.ForeColor = System.Drawing.Color.Black
        Me.Textbox4.HintForeColor = System.Drawing.Color.Black
        Me.Textbox4.HintText = ""
        Me.Textbox4.isPassword = False
        Me.Textbox4.LineFocusedColor = System.Drawing.Color.DimGray
        Me.Textbox4.LineIdleColor = System.Drawing.Color.Gray
        Me.Textbox4.LineMouseHoverColor = System.Drawing.Color.Black
        Me.Textbox4.LineThickness = 3
        Me.Textbox4.Location = New System.Drawing.Point(278, 380)
        Me.Textbox4.Margin = New System.Windows.Forms.Padding(5)
        Me.Textbox4.MaxLength = 32767
        Me.Textbox4.Name = "Textbox4"
        Me.Textbox4.Size = New System.Drawing.Size(160, 43)
        Me.Textbox4.TabIndex = 16
        Me.Textbox4.Text = "Amount"
        Me.Textbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AllowParentOverrides = False
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.Font = New System.Drawing.Font("MV Boli", 15.75!)
        Me.BunifuLabel1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BunifuLabel1.Location = New System.Drawing.Point(63, 116)
        Me.BunifuLabel1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(26, 33)
        Me.BunifuLabel1.TabIndex = 17
        Me.BunifuLabel1.Text = "ID"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel2
        '
        Me.BunifuLabel2.AllowParentOverrides = False
        Me.BunifuLabel2.AutoEllipsis = False
        Me.BunifuLabel2.CursorType = Nothing
        Me.BunifuLabel2.Font = New System.Drawing.Font("MV Boli", 15.75!)
        Me.BunifuLabel2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BunifuLabel2.Location = New System.Drawing.Point(63, 183)
        Me.BunifuLabel2.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuLabel2.Name = "BunifuLabel2"
        Me.BunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel2.Size = New System.Drawing.Size(108, 33)
        Me.BunifuLabel2.TabIndex = 18
        Me.BunifuLabel2.Text = "Quantity"
        Me.BunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel3
        '
        Me.BunifuLabel3.AllowParentOverrides = False
        Me.BunifuLabel3.AutoEllipsis = False
        Me.BunifuLabel3.CursorType = Nothing
        Me.BunifuLabel3.Font = New System.Drawing.Font("MV Boli", 15.75!)
        Me.BunifuLabel3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BunifuLabel3.Location = New System.Drawing.Point(63, 249)
        Me.BunifuLabel3.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuLabel3.Name = "BunifuLabel3"
        Me.BunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel3.Size = New System.Drawing.Size(95, 33)
        Me.BunifuLabel3.TabIndex = 19
        Me.BunifuLabel3.Text = "Product"
        Me.BunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel4
        '
        Me.BunifuLabel4.AllowParentOverrides = False
        Me.BunifuLabel4.AutoEllipsis = False
        Me.BunifuLabel4.CursorType = Nothing
        Me.BunifuLabel4.Font = New System.Drawing.Font("MV Boli", 15.75!)
        Me.BunifuLabel4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BunifuLabel4.Location = New System.Drawing.Point(62, 389)
        Me.BunifuLabel4.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuLabel4.Name = "BunifuLabel4"
        Me.BunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel4.Size = New System.Drawing.Size(96, 33)
        Me.BunifuLabel4.TabIndex = 20
        Me.BunifuLabel4.Text = "Amount"
        Me.BunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel5
        '
        Me.BunifuLabel5.AllowParentOverrides = False
        Me.BunifuLabel5.AutoEllipsis = False
        Me.BunifuLabel5.CursorType = Nothing
        Me.BunifuLabel5.Font = New System.Drawing.Font("MV Boli", 15.75!)
        Me.BunifuLabel5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BunifuLabel5.Location = New System.Drawing.Point(212, 249)
        Me.BunifuLabel5.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuLabel5.Name = "BunifuLabel5"
        Me.BunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel5.Size = New System.Drawing.Size(9, 33)
        Me.BunifuLabel5.TabIndex = 21
        Me.BunifuLabel5.Text = ":"
        Me.BunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel6
        '
        Me.BunifuLabel6.AllowParentOverrides = False
        Me.BunifuLabel6.AutoEllipsis = False
        Me.BunifuLabel6.CursorType = Nothing
        Me.BunifuLabel6.Font = New System.Drawing.Font("MV Boli", 15.75!)
        Me.BunifuLabel6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BunifuLabel6.Location = New System.Drawing.Point(212, 183)
        Me.BunifuLabel6.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuLabel6.Name = "BunifuLabel6"
        Me.BunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel6.Size = New System.Drawing.Size(9, 33)
        Me.BunifuLabel6.TabIndex = 22
        Me.BunifuLabel6.Text = ":"
        Me.BunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel7
        '
        Me.BunifuLabel7.AllowParentOverrides = False
        Me.BunifuLabel7.AutoEllipsis = False
        Me.BunifuLabel7.CursorType = Nothing
        Me.BunifuLabel7.Font = New System.Drawing.Font("MV Boli", 15.75!)
        Me.BunifuLabel7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BunifuLabel7.Location = New System.Drawing.Point(211, 389)
        Me.BunifuLabel7.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuLabel7.Name = "BunifuLabel7"
        Me.BunifuLabel7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel7.Size = New System.Drawing.Size(9, 33)
        Me.BunifuLabel7.TabIndex = 23
        Me.BunifuLabel7.Text = ":"
        Me.BunifuLabel7.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel7.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel8
        '
        Me.BunifuLabel8.AllowParentOverrides = False
        Me.BunifuLabel8.AutoEllipsis = False
        Me.BunifuLabel8.CursorType = Nothing
        Me.BunifuLabel8.Font = New System.Drawing.Font("MV Boli", 15.75!)
        Me.BunifuLabel8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BunifuLabel8.Location = New System.Drawing.Point(212, 116)
        Me.BunifuLabel8.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuLabel8.Name = "BunifuLabel8"
        Me.BunifuLabel8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel8.Size = New System.Drawing.Size(9, 33)
        Me.BunifuLabel8.TabIndex = 24
        Me.BunifuLabel8.Text = ":"
        Me.BunifuLabel8.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel8.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuCustomLabel11
        '
        Me.BunifuCustomLabel11.AutoSize = True
        Me.BunifuCustomLabel11.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel11.ForeColor = System.Drawing.SystemColors.Control
        Me.BunifuCustomLabel11.Location = New System.Drawing.Point(3, 1)
        Me.BunifuCustomLabel11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BunifuCustomLabel11.Name = "BunifuCustomLabel11"
        Me.BunifuCustomLabel11.Size = New System.Drawing.Size(77, 29)
        Me.BunifuCustomLabel11.TabIndex = 26
        Me.BunifuCustomLabel11.Text = "BACK"
        '
        'CartTableAdapter1
        '
        Me.CartTableAdapter1.ClearBeforeFill = True
        '
        'BunifuLabel10
        '
        Me.BunifuLabel10.AllowParentOverrides = False
        Me.BunifuLabel10.AutoEllipsis = False
        Me.BunifuLabel10.CursorType = Nothing
        Me.BunifuLabel10.Font = New System.Drawing.Font("MV Boli", 15.75!)
        Me.BunifuLabel10.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BunifuLabel10.Location = New System.Drawing.Point(212, 316)
        Me.BunifuLabel10.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuLabel10.Name = "BunifuLabel10"
        Me.BunifuLabel10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel10.Size = New System.Drawing.Size(9, 33)
        Me.BunifuLabel10.TabIndex = 29
        Me.BunifuLabel10.Text = ":"
        Me.BunifuLabel10.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel10.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel11
        '
        Me.BunifuLabel11.AllowParentOverrides = False
        Me.BunifuLabel11.AutoEllipsis = False
        Me.BunifuLabel11.CursorType = Nothing
        Me.BunifuLabel11.Font = New System.Drawing.Font("MV Boli", 15.75!)
        Me.BunifuLabel11.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BunifuLabel11.Location = New System.Drawing.Point(63, 316)
        Me.BunifuLabel11.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuLabel11.Name = "BunifuLabel11"
        Me.BunifuLabel11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel11.Size = New System.Drawing.Size(59, 33)
        Me.BunifuLabel11.TabIndex = 28
        Me.BunifuLabel11.Text = "Price"
        Me.BunifuLabel11.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel11.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'Textbox5
        '
        Me.Textbox5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.Textbox5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.Textbox5.BackColor = System.Drawing.Color.Gainsboro
        Me.Textbox5.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Textbox5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Textbox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CartBindingSource1, "price", True))
        Me.Textbox5.Enabled = False
        Me.Textbox5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textbox5.ForeColor = System.Drawing.Color.Black
        Me.Textbox5.HintForeColor = System.Drawing.Color.Black
        Me.Textbox5.HintText = ""
        Me.Textbox5.isPassword = False
        Me.Textbox5.LineFocusedColor = System.Drawing.Color.DimGray
        Me.Textbox5.LineIdleColor = System.Drawing.Color.Gray
        Me.Textbox5.LineMouseHoverColor = System.Drawing.Color.Black
        Me.Textbox5.LineThickness = 3
        Me.Textbox5.Location = New System.Drawing.Point(279, 307)
        Me.Textbox5.Margin = New System.Windows.Forms.Padding(5)
        Me.Textbox5.MaxLength = 32767
        Me.Textbox5.Name = "Textbox5"
        Me.Textbox5.Size = New System.Drawing.Size(160, 43)
        Me.Textbox5.TabIndex = 27
        Me.Textbox5.Text = "Price"
        Me.Textbox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'CART
        '
        Me.CART.AutoSize = True
        Me.CART.BackColor = System.Drawing.Color.Transparent
        Me.CART.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Italic)
        Me.CART.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.CART.Location = New System.Drawing.Point(168, 34)
        Me.CART.Name = "CART"
        Me.CART.Size = New System.Drawing.Size(120, 42)
        Me.CART.TabIndex = 30
        Me.CART.Text = "CART"
        '
        'Flower_Cart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1108, 630)
        Me.Controls.Add(Me.CART)
        Me.Controls.Add(Me.BunifuLabel10)
        Me.Controls.Add(Me.BunifuLabel11)
        Me.Controls.Add(Me.Textbox5)
        Me.Controls.Add(Me.BunifuCustomLabel11)
        Me.Controls.Add(Me.BunifuLabel8)
        Me.Controls.Add(Me.BunifuLabel7)
        Me.Controls.Add(Me.BunifuLabel6)
        Me.Controls.Add(Me.BunifuLabel5)
        Me.Controls.Add(Me.BunifuLabel4)
        Me.Controls.Add(Me.BunifuLabel3)
        Me.Controls.Add(Me.BunifuLabel2)
        Me.Controls.Add(Me.BunifuLabel1)
        Me.Controls.Add(Me.Textbox4)
        Me.Controls.Add(Me.Textbox2)
        Me.Controls.Add(Me.Textbox3)
        Me.Controls.Add(Me.Textbox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Flower_Cart"
        Me.Text = "Flower_Cart"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CartBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlowersDataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlowersDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents amount As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents quality As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents DataGridView1 As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents FlowersDataSet1 As flowersDataSet1
    Friend WithEvents CartBindingSource As BindingSource
    Friend WithEvents CartTableAdapter As flowersDataSet1TableAdapters.cartTableAdapter
    Friend WithEvents CartIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents add_btt As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Panel2 As Panel
    Friend WithEvents delete_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents update_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents purchase_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Textbox1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Textbox3 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Textbox2 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Textbox4 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel2 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel3 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel4 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel5 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel6 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel7 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel8 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuCustomLabel11 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents FlowersDataSet7 As flowersDataSet7
    Friend WithEvents CartBindingSource1 As BindingSource
    Friend WithEvents CartTableAdapter1 As flowersDataSet7TableAdapters.cartTableAdapter
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents BunifuLabel10 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel11 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents Textbox5 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents CART As Label
End Class
