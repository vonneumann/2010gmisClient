'项目资信分析
Public Class FProjectCredit
    Inherits System.Windows.Forms.Form

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub

    '窗体重写处置以清理组件列表。
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意：以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改此过程。
    '不要使用代码编辑器修改它。
    Friend WithEvents tabCreditQuality As System.Windows.Forms.TabPage
    Friend WithEvents tabCreditQuantity As System.Windows.Forms.TabPage
    Friend WithEvents tabCredit As System.Windows.Forms.TabPage
    Friend WithEvents tabTable As System.Windows.Forms.TabControl
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents grdQuality As System.Windows.Forms.DataGrid
    Friend WithEvents lblProjectNo As System.Windows.Forms.Label
    Friend WithEvents lblPhase As System.Windows.Forms.Label
    Friend WithEvents lblMonth As System.Windows.Forms.Label
    Friend WithEvents grdQuantity As System.Windows.Forms.DataGrid
    Friend WithEvents tsQuality As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents csProjectNo As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csPhase As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csIndexValue As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csScore As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csRemark As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csIndexName As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents grdCredit As System.Windows.Forms.DataGrid
    Friend WithEvents tsCredit As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents tsQuantity As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csCreditProjectNo As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csCreditPhase As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csCreditMonth As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csCreditMonthLast As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csCreditQualityValue As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csCreditQuantityValue As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csCreditTotal As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csCreditRemark As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents lblQuality As System.Windows.Forms.Label
    Friend WithEvents cboQuality As System.Windows.Forms.ComboBox
    Friend WithEvents txtQuality As System.Windows.Forms.TextBox
    Friend WithEvents cboPhase As System.Windows.Forms.ComboBox
    Friend WithEvents cboCorporationNo As System.Windows.Forms.ComboBox
    Friend WithEvents lblQuantityTotal As System.Windows.Forms.Label
    Friend WithEvents txtQuantityTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblQualityTotal As System.Windows.Forms.Label
    Friend WithEvents txtQualityTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtCreditTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblCreditTotal As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents txtProjectNo As System.Windows.Forms.TextBox
    Friend WithEvents cboMonth As System.Windows.Forms.ComboBox
    Friend WithEvents cboLastMonth As System.Windows.Forms.ComboBox
    Friend WithEvents csMonth As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FProjectCredit))
        Me.tabTable = New System.Windows.Forms.TabControl
        Me.tabCreditQuantity = New System.Windows.Forms.TabPage
        Me.txtCreditTotal = New System.Windows.Forms.TextBox
        Me.txtQualityTotal = New System.Windows.Forms.TextBox
        Me.txtQuantityTotal = New System.Windows.Forms.TextBox
        Me.lblCreditTotal = New System.Windows.Forms.Label
        Me.lblQualityTotal = New System.Windows.Forms.Label
        Me.lblQuantityTotal = New System.Windows.Forms.Label
        Me.grdQuantity = New System.Windows.Forms.DataGrid
        Me.tsQuantity = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.tabCreditQuality = New System.Windows.Forms.TabPage
        Me.txtQuality = New System.Windows.Forms.TextBox
        Me.cboQuality = New System.Windows.Forms.ComboBox
        Me.lblQuality = New System.Windows.Forms.Label
        Me.grdQuality = New System.Windows.Forms.DataGrid
        Me.tsQuality = New System.Windows.Forms.DataGridTableStyle
        Me.csProjectNo = New System.Windows.Forms.DataGridTextBoxColumn
        Me.csPhase = New System.Windows.Forms.DataGridTextBoxColumn
        Me.csIndexName = New System.Windows.Forms.DataGridTextBoxColumn
        Me.csIndexValue = New System.Windows.Forms.DataGridTextBoxColumn
        Me.csScore = New System.Windows.Forms.DataGridTextBoxColumn
        Me.csRemark = New System.Windows.Forms.DataGridTextBoxColumn
        Me.tabCredit = New System.Windows.Forms.TabPage
        Me.grdCredit = New System.Windows.Forms.DataGrid
        Me.tsCredit = New System.Windows.Forms.DataGridTableStyle
        Me.csCreditProjectNo = New System.Windows.Forms.DataGridTextBoxColumn
        Me.csCreditPhase = New System.Windows.Forms.DataGridTextBoxColumn
        Me.csCreditMonthLast = New System.Windows.Forms.DataGridTextBoxColumn
        Me.csCreditMonth = New System.Windows.Forms.DataGridTextBoxColumn
        Me.csCreditQuantityValue = New System.Windows.Forms.DataGridTextBoxColumn
        Me.csCreditQualityValue = New System.Windows.Forms.DataGridTextBoxColumn
        Me.csCreditTotal = New System.Windows.Forms.DataGridTextBoxColumn
        Me.csCreditRemark = New System.Windows.Forms.DataGridTextBoxColumn
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.btnCreate = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.lblProjectNo = New System.Windows.Forms.Label
        Me.lblPhase = New System.Windows.Forms.Label
        Me.lblMonth = New System.Windows.Forms.Label
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.cboPhase = New System.Windows.Forms.ComboBox
        Me.cboCorporationNo = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblTitle = New System.Windows.Forms.Label
        Me.cboMonth = New System.Windows.Forms.ComboBox
        Me.cboLastMonth = New System.Windows.Forms.ComboBox
        Me.txtProjectNo = New System.Windows.Forms.TextBox
        Me.csMonth = New System.Windows.Forms.DataGridTextBoxColumn
        Me.tabTable.SuspendLayout()
        Me.tabCreditQuantity.SuspendLayout()
        CType(Me.grdQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCreditQuality.SuspendLayout()
        CType(Me.grdQuality, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCredit.SuspendLayout()
        CType(Me.grdCredit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabTable
        '
        Me.tabTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabTable.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabTable.Controls.Add(Me.tabCreditQuantity)
        Me.tabTable.Controls.Add(Me.tabCreditQuality)
        Me.tabTable.Controls.Add(Me.tabCredit)
        Me.tabTable.ItemSize = New System.Drawing.Size(120, 22)
        Me.tabTable.Location = New System.Drawing.Point(8, 80)
        Me.tabTable.Name = "tabTable"
        Me.tabTable.SelectedIndex = 0
        Me.tabTable.Size = New System.Drawing.Size(620, 296)
        Me.tabTable.TabIndex = 10
        '
        'tabCreditQuantity
        '
        Me.tabCreditQuantity.Controls.Add(Me.txtCreditTotal)
        Me.tabCreditQuantity.Controls.Add(Me.txtQualityTotal)
        Me.tabCreditQuantity.Controls.Add(Me.txtQuantityTotal)
        Me.tabCreditQuantity.Controls.Add(Me.lblCreditTotal)
        Me.tabCreditQuantity.Controls.Add(Me.lblQualityTotal)
        Me.tabCreditQuantity.Controls.Add(Me.lblQuantityTotal)
        Me.tabCreditQuantity.Controls.Add(Me.grdQuantity)
        Me.tabCreditQuantity.DockPadding.Bottom = 40
        Me.tabCreditQuantity.Location = New System.Drawing.Point(4, 26)
        Me.tabCreditQuantity.Name = "tabCreditQuantity"
        Me.tabCreditQuantity.Size = New System.Drawing.Size(612, 266)
        Me.tabCreditQuantity.TabIndex = 1
        Me.tabCreditQuantity.Text = "定量分析"
        '
        'txtCreditTotal
        '
        Me.txtCreditTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCreditTotal.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCreditTotal.Location = New System.Drawing.Point(492, 240)
        Me.txtCreditTotal.Name = "txtCreditTotal"
        Me.txtCreditTotal.ReadOnly = True
        Me.txtCreditTotal.Size = New System.Drawing.Size(120, 22)
        Me.txtCreditTotal.TabIndex = 17
        Me.txtCreditTotal.Text = ""
        '
        'txtQualityTotal
        '
        Me.txtQualityTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtQualityTotal.BackColor = System.Drawing.Color.Gainsboro
        Me.txtQualityTotal.Location = New System.Drawing.Point(224, 240)
        Me.txtQualityTotal.Name = "txtQualityTotal"
        Me.txtQualityTotal.ReadOnly = True
        Me.txtQualityTotal.Size = New System.Drawing.Size(120, 22)
        Me.txtQualityTotal.TabIndex = 15
        Me.txtQualityTotal.Text = ""
        '
        'txtQuantityTotal
        '
        Me.txtQuantityTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtQuantityTotal.BackColor = System.Drawing.Color.Gainsboro
        Me.txtQuantityTotal.Location = New System.Drawing.Point(40, 240)
        Me.txtQuantityTotal.Name = "txtQuantityTotal"
        Me.txtQuantityTotal.ReadOnly = True
        Me.txtQuantityTotal.Size = New System.Drawing.Size(120, 22)
        Me.txtQuantityTotal.TabIndex = 13
        Me.txtQuantityTotal.Text = ""
        '
        'lblCreditTotal
        '
        Me.lblCreditTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCreditTotal.Location = New System.Drawing.Point(428, 246)
        Me.lblCreditTotal.Name = "lblCreditTotal"
        Me.lblCreditTotal.Size = New System.Drawing.Size(60, 16)
        Me.lblCreditTotal.TabIndex = 16
        Me.lblCreditTotal.Text = "总量总分"
        '
        'lblQualityTotal
        '
        Me.lblQualityTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblQualityTotal.Location = New System.Drawing.Point(184, 246)
        Me.lblQualityTotal.Name = "lblQualityTotal"
        Me.lblQualityTotal.Size = New System.Drawing.Size(40, 16)
        Me.lblQualityTotal.TabIndex = 14
        Me.lblQualityTotal.Text = "定性"
        '
        'lblQuantityTotal
        '
        Me.lblQuantityTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblQuantityTotal.Location = New System.Drawing.Point(0, 246)
        Me.lblQuantityTotal.Name = "lblQuantityTotal"
        Me.lblQuantityTotal.Size = New System.Drawing.Size(40, 16)
        Me.lblQuantityTotal.TabIndex = 12
        Me.lblQuantityTotal.Text = "定量"
        '
        'grdQuantity
        '
        Me.grdQuantity.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdQuantity.CaptionVisible = False
        Me.grdQuantity.DataMember = ""
        Me.grdQuantity.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdQuantity.Location = New System.Drawing.Point(0, 0)
        Me.grdQuantity.Name = "grdQuantity"
        Me.grdQuantity.Size = New System.Drawing.Size(612, 232)
        Me.grdQuantity.TabIndex = 11
        Me.grdQuantity.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.tsQuantity})
        '
        'tsQuantity
        '
        Me.tsQuantity.DataGrid = Me.grdQuantity
        Me.tsQuantity.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13})
        Me.tsQuantity.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.tsQuantity.MappingName = "TProjectCreditQuantity"
        Me.tsQuantity.ReadOnly = True
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "项目编号"
        Me.DataGridTextBoxColumn2.MappingName = "project_code"
        Me.DataGridTextBoxColumn2.Width = 80
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "项目阶段"
        Me.DataGridTextBoxColumn3.MappingName = "phase"
        Me.DataGridTextBoxColumn3.Width = 60
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "起始年月"
        Me.DataGridTextBoxColumn4.MappingName = "month_last"
        Me.DataGridTextBoxColumn4.Width = 0
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "评分年月"
        Me.DataGridTextBoxColumn5.MappingName = "month"
        Me.DataGridTextBoxColumn5.Width = 60
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "科目名称"
        Me.DataGridTextBoxColumn9.MappingName = "index_name"
        Me.DataGridTextBoxColumn9.Width = 108
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn10.Format = "N"
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "取 值"
        Me.DataGridTextBoxColumn10.MappingName = "index_value"
        Me.DataGridTextBoxColumn10.Width = 80
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "评 分"
        Me.DataGridTextBoxColumn11.MappingName = "score"
        Me.DataGridTextBoxColumn11.Width = 60
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "最终评分"
        Me.DataGridTextBoxColumn12.MappingName = "score_final"
        Me.DataGridTextBoxColumn12.Width = 60
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "备  注"
        Me.DataGridTextBoxColumn13.MappingName = "remark"
        Me.DataGridTextBoxColumn13.Width = 200
        '
        'tabCreditQuality
        '
        Me.tabCreditQuality.Controls.Add(Me.txtQuality)
        Me.tabCreditQuality.Controls.Add(Me.cboQuality)
        Me.tabCreditQuality.Controls.Add(Me.lblQuality)
        Me.tabCreditQuality.Controls.Add(Me.grdQuality)
        Me.tabCreditQuality.Location = New System.Drawing.Point(4, 26)
        Me.tabCreditQuality.Name = "tabCreditQuality"
        Me.tabCreditQuality.Size = New System.Drawing.Size(612, 266)
        Me.tabCreditQuality.TabIndex = 0
        Me.tabCreditQuality.Text = "定性分析"
        '
        'txtQuality
        '
        Me.txtQuality.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuality.Location = New System.Drawing.Point(304, 216)
        Me.txtQuality.Name = "txtQuality"
        Me.txtQuality.ReadOnly = True
        Me.txtQuality.Size = New System.Drawing.Size(308, 22)
        Me.txtQuality.TabIndex = 15
        Me.txtQuality.Text = ""
        '
        'cboQuality
        '
        Me.cboQuality.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboQuality.DisplayMember = "condition"
        Me.cboQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboQuality.Location = New System.Drawing.Point(40, 216)
        Me.cboQuality.Name = "cboQuality"
        Me.cboQuality.Size = New System.Drawing.Size(256, 22)
        Me.cboQuality.TabIndex = 14
        '
        'lblQuality
        '
        Me.lblQuality.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblQuality.AutoSize = True
        Me.lblQuality.Location = New System.Drawing.Point(0, 224)
        Me.lblQuality.Name = "lblQuality"
        Me.lblQuality.Size = New System.Drawing.Size(45, 18)
        Me.lblQuality.TabIndex = 13
        Me.lblQuality.Text = "评价："
        '
        'grdQuality
        '
        Me.grdQuality.AllowNavigation = False
        Me.grdQuality.AllowSorting = False
        Me.grdQuality.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdQuality.CaptionVisible = False
        Me.grdQuality.DataMember = ""
        Me.grdQuality.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdQuality.Location = New System.Drawing.Point(0, 0)
        Me.grdQuality.Name = "grdQuality"
        Me.grdQuality.Size = New System.Drawing.Size(612, 208)
        Me.grdQuality.TabIndex = 12
        Me.grdQuality.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.tsQuality})
        '
        'tsQuality
        '
        Me.tsQuality.AllowSorting = False
        Me.tsQuality.DataGrid = Me.grdQuality
        Me.tsQuality.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csProjectNo, Me.csPhase, Me.csMonth, Me.csIndexName, Me.csIndexValue, Me.csScore, Me.csRemark})
        Me.tsQuality.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.tsQuality.MappingName = "TProjectCreditQuality"
        '
        'csProjectNo
        '
        Me.csProjectNo.Format = ""
        Me.csProjectNo.FormatInfo = Nothing
        Me.csProjectNo.HeaderText = "项目编号"
        Me.csProjectNo.MappingName = "project_code"
        Me.csProjectNo.NullText = ""
        Me.csProjectNo.ReadOnly = True
        Me.csProjectNo.Width = 80
        '
        'csPhase
        '
        Me.csPhase.Format = ""
        Me.csPhase.FormatInfo = Nothing
        Me.csPhase.HeaderText = "项目阶段"
        Me.csPhase.MappingName = "phase"
        Me.csPhase.ReadOnly = True
        Me.csPhase.Width = 60
        '
        'csIndexName
        '
        Me.csIndexName.Format = ""
        Me.csIndexName.FormatInfo = Nothing
        Me.csIndexName.HeaderText = "指 标"
        Me.csIndexName.MappingName = "index_name"
        Me.csIndexName.ReadOnly = True
        Me.csIndexName.Width = 150
        '
        'csIndexValue
        '
        Me.csIndexValue.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.csIndexValue.Format = ""
        Me.csIndexValue.FormatInfo = Nothing
        Me.csIndexValue.HeaderText = "评 价"
        Me.csIndexValue.MappingName = "index_value"
        Me.csIndexValue.ReadOnly = True
        Me.csIndexValue.Width = 80
        '
        'csScore
        '
        Me.csScore.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.csScore.Format = ""
        Me.csScore.FormatInfo = Nothing
        Me.csScore.HeaderText = "得 分"
        Me.csScore.MappingName = "score"
        Me.csScore.ReadOnly = True
        Me.csScore.Width = 50
        '
        'csRemark
        '
        Me.csRemark.Format = ""
        Me.csRemark.FormatInfo = Nothing
        Me.csRemark.HeaderText = "备  注"
        Me.csRemark.MappingName = "remark"
        Me.csRemark.Width = 120
        '
        'tabCredit
        '
        Me.tabCredit.Controls.Add(Me.grdCredit)
        Me.tabCredit.Location = New System.Drawing.Point(4, 26)
        Me.tabCredit.Name = "tabCredit"
        Me.tabCredit.Size = New System.Drawing.Size(612, 266)
        Me.tabCredit.TabIndex = 2
        Me.tabCredit.Text = "总量分析"
        '
        'grdCredit
        '
        Me.grdCredit.CaptionVisible = False
        Me.grdCredit.DataMember = ""
        Me.grdCredit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdCredit.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdCredit.Location = New System.Drawing.Point(0, 0)
        Me.grdCredit.Name = "grdCredit"
        Me.grdCredit.ReadOnly = True
        Me.grdCredit.Size = New System.Drawing.Size(612, 266)
        Me.grdCredit.TabIndex = 16
        Me.grdCredit.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.tsCredit})
        '
        'tsCredit
        '
        Me.tsCredit.DataGrid = Me.grdCredit
        Me.tsCredit.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csCreditProjectNo, Me.csCreditPhase, Me.csCreditMonthLast, Me.csCreditMonth, Me.csCreditQuantityValue, Me.csCreditQualityValue, Me.csCreditTotal, Me.csCreditRemark})
        Me.tsCredit.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.tsCredit.MappingName = "TProjectCredit"
        Me.tsCredit.ReadOnly = True
        '
        'csCreditProjectNo
        '
        Me.csCreditProjectNo.Format = ""
        Me.csCreditProjectNo.FormatInfo = Nothing
        Me.csCreditProjectNo.HeaderText = "项目编号"
        Me.csCreditProjectNo.MappingName = "project_code"
        Me.csCreditProjectNo.Width = 80
        '
        'csCreditPhase
        '
        Me.csCreditPhase.Format = ""
        Me.csCreditPhase.FormatInfo = Nothing
        Me.csCreditPhase.HeaderText = "阶 段"
        Me.csCreditPhase.MappingName = "phase"
        Me.csCreditPhase.Width = 60
        '
        'csCreditMonthLast
        '
        Me.csCreditMonthLast.Format = ""
        Me.csCreditMonthLast.FormatInfo = Nothing
        Me.csCreditMonthLast.HeaderText = "起始年月"
        Me.csCreditMonthLast.MappingName = "month_last"
        Me.csCreditMonthLast.Width = 0
        '
        'csCreditMonth
        '
        Me.csCreditMonth.Format = ""
        Me.csCreditMonth.FormatInfo = Nothing
        Me.csCreditMonth.HeaderText = "评分年月"
        Me.csCreditMonth.MappingName = "month"
        Me.csCreditMonth.Width = 60
        '
        'csCreditQuantityValue
        '
        Me.csCreditQuantityValue.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.csCreditQuantityValue.Format = ""
        Me.csCreditQuantityValue.FormatInfo = Nothing
        Me.csCreditQuantityValue.HeaderText = "定量总分"
        Me.csCreditQuantityValue.MappingName = "quantity_score"
        Me.csCreditQuantityValue.Width = 60
        '
        'csCreditQualityValue
        '
        Me.csCreditQualityValue.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.csCreditQualityValue.Format = ""
        Me.csCreditQualityValue.FormatInfo = Nothing
        Me.csCreditQualityValue.HeaderText = "定性总分"
        Me.csCreditQualityValue.MappingName = "quality_score"
        Me.csCreditQualityValue.Width = 60
        '
        'csCreditTotal
        '
        Me.csCreditTotal.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.csCreditTotal.Format = ""
        Me.csCreditTotal.FormatInfo = Nothing
        Me.csCreditTotal.HeaderText = "总  分"
        Me.csCreditTotal.MappingName = "total_score"
        Me.csCreditTotal.Width = 60
        '
        'csCreditRemark
        '
        Me.csCreditRemark.Format = ""
        Me.csCreditRemark.FormatInfo = Nothing
        Me.csCreditRemark.HeaderText = "注 释"
        Me.csCreditRemark.MappingName = "remark"
        Me.csCreditRemark.Width = 120
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnRefresh.Location = New System.Drawing.Point(188, 384)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(80, 24)
        Me.btnRefresh.TabIndex = 11
        Me.btnRefresh.Text = "查 询(&F)"
        '
        'btnCreate
        '
        Me.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCreate.Location = New System.Drawing.Point(276, 384)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(80, 24)
        Me.btnCreate.TabIndex = 12
        Me.btnCreate.Text = "计 算(&C)"
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Location = New System.Drawing.Point(364, 384)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 24)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "退 出(&X)"
        '
        'lblProjectNo
        '
        Me.lblProjectNo.AutoSize = True
        Me.lblProjectNo.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjectNo.Location = New System.Drawing.Point(16, 35)
        Me.lblProjectNo.Name = "lblProjectNo"
        Me.lblProjectNo.Size = New System.Drawing.Size(72, 17)
        Me.lblProjectNo.TabIndex = 1
        Me.lblProjectNo.Text = "项目编号(&N)"
        '
        'lblPhase
        '
        Me.lblPhase.AutoSize = True
        Me.lblPhase.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhase.Location = New System.Drawing.Point(16, 59)
        Me.lblPhase.Name = "lblPhase"
        Me.lblPhase.Size = New System.Drawing.Size(72, 17)
        Me.lblPhase.TabIndex = 4
        Me.lblPhase.Text = "项目阶段(&P)"
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonth.Location = New System.Drawing.Point(224, 59)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(72, 17)
        Me.lblMonth.TabIndex = 6
        Me.lblMonth.Text = "评分年月(M)"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "最终评分"
        Me.DataGridTextBoxColumn1.MappingName = "score_final"
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "系统编号"
        Me.DataGridTextBoxColumn6.MappingName = "system_id"
        Me.DataGridTextBoxColumn6.Width = 75
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "科目类型"
        Me.DataGridTextBoxColumn7.MappingName = "index_type"
        Me.DataGridTextBoxColumn7.Width = 75
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "科目编号"
        Me.DataGridTextBoxColumn8.MappingName = "index_id"
        Me.DataGridTextBoxColumn8.Width = 75
        '
        'cboPhase
        '
        Me.cboPhase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPhase.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPhase.ItemHeight = 12
        Me.cboPhase.Location = New System.Drawing.Point(88, 56)
        Me.cboPhase.Name = "cboPhase"
        Me.cboPhase.Size = New System.Drawing.Size(120, 20)
        Me.cboPhase.TabIndex = 5
        '
        'cboCorporationNo
        '
        Me.cboCorporationNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCorporationNo.DisplayMember = "corporation_name"
        Me.cboCorporationNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCorporationNo.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCorporationNo.Location = New System.Drawing.Point(296, 32)
        Me.cboCorporationNo.Name = "cboCorporationNo"
        Me.cboCorporationNo.Size = New System.Drawing.Size(328, 20)
        Me.cboCorporationNo.TabIndex = 3
        Me.cboCorporationNo.ValueMember = "corporation_code"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(224, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 17)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "企业名称(&C)"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(80, 8)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(144, 18)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = " 项目资信分析条件设置"
        '
        'cboMonth
        '
        Me.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonth.DropDownWidth = 72
        Me.cboMonth.Location = New System.Drawing.Point(296, 55)
        Me.cboMonth.MaxLength = 6
        Me.cboMonth.Name = "cboMonth"
        Me.cboMonth.Size = New System.Drawing.Size(96, 22)
        Me.cboMonth.TabIndex = 32
        '
        'cboLastMonth
        '
        Me.cboLastMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLastMonth.DropDownWidth = 72
        Me.cboLastMonth.Location = New System.Drawing.Point(344, 55)
        Me.cboLastMonth.MaxLength = 6
        Me.cboLastMonth.Name = "cboLastMonth"
        Me.cboLastMonth.Size = New System.Drawing.Size(96, 22)
        Me.cboLastMonth.TabIndex = 31
        Me.cboLastMonth.Visible = False
        '
        'txtProjectNo
        '
        Me.txtProjectNo.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProjectNo.Location = New System.Drawing.Point(88, 32)
        Me.txtProjectNo.Name = "txtProjectNo"
        Me.txtProjectNo.Size = New System.Drawing.Size(120, 21)
        Me.txtProjectNo.TabIndex = 33
        Me.txtProjectNo.Text = ""
        '
        'csMonth
        '
        Me.csMonth.Format = ""
        Me.csMonth.FormatInfo = Nothing
        Me.csMonth.HeaderText = "评分年月"
        Me.csMonth.MappingName = "month"
        Me.csMonth.ReadOnly = True
        Me.csMonth.Width = 75
        '
        'FProjectCredit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(632, 413)
        Me.Controls.Add(Me.txtProjectNo)
        Me.Controls.Add(Me.cboMonth)
        Me.Controls.Add(Me.cboLastMonth)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPhase)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblProjectNo)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.cboCorporationNo)
        Me.Controls.Add(Me.cboPhase)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.tabTable)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(600, 400)
        Me.Name = "FProjectCredit"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "项目资信分析"
        Me.tabTable.ResumeLayout(False)
        Me.tabCreditQuantity.ResumeLayout(False)
        CType(Me.grdQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCreditQuality.ResumeLayout(False)
        CType(Me.grdQuality, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCredit.ResumeLayout(False)
        CType(Me.grdCredit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Const MaxProjectCodeLength As Integer = 9  '项目编码最大长度
    Public bCanEdit As Boolean = True        '数据是否可以修改

    '设置控件状态
    Public Sub SetEditState(ByVal Enabled As Boolean)
        txtProjectNo.Enabled = Enabled
        cboCorporationNo.Enabled = Enabled
        cboPhase.Enabled = True
    End Sub

    Public Overloads Function ShowDialog(ByVal ProjectNo As String, ByVal CorporationNo As String, ByVal Phase As String) As DialogResult
        MyBase.Show()
        Me.txtProjectNo.Text = ProjectNo
        Me.cboCorporationNo.SelectedValue = CorporationNo
        Me.cboPhase.Text = Phase

        '2008-2-22 yjf delete 防止重新走formLoad事件，导致重新绑定阶段下拉框
        'Me.Hide()
        'MyBase.ShowDialog()
    End Function
    '利用Graphics对象划直线
    Private Sub FProjectCredit_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        Dim linePen As Drawing.Pen = New Drawing.Pen(Color.Gray)

        e.Graphics.DrawLine(linePen, 8, lblTitle.Top + (lblTitle.Height \ 2), Me.ClientSize.Width - 16, lblTitle.Top + (lblTitle.Height \ 2))
        linePen.Color = Color.White
        e.Graphics.DrawLine(linePen, 8, lblTitle.Top + (lblTitle.Height \ 2) + 1, Me.ClientSize.Width - 16, lblTitle.Top + (lblTitle.Height \ 2) + 1)
    End Sub

    Private Sub FProjectCredit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboPhase.DataSource = gWs.GetPhase("%").Tables(0)
        cboPhase.DisplayMember = "phase_name"
        cboPhase.ValueMember = "phase_name"
    End Sub

    '查询　note:只有在定性评分的时候才可以用
    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Dim dsResult, dsResult1 As DataSet

        Try
            Me.Cursor = Cursors.WaitCursor

            If Not Me.CheckData() Then
                Return
            End If

            '定量分析
            'If tabTable.SelectedTab Is tabCreditQuantity Then
            Dim strMonth, strLastMonth As String
            Me.GetMonth(strMonth, strLastMonth)

            dsResult = gWs.FetchProjectCreditQuantity(txtProjectNo.Text.Trim(), cboCorporationNo.SelectedValue, cboPhase.Text, _
                 strMonth, strLastMonth)

            Dim cm As CurrencyManager = CType(Me.BindingContext(dsResult, "TProjectCreditQuantity"), CurrencyManager)
            Dim dv As DataView = CType(cm.List, DataView)
            dv.AllowNew = False
            dv.AllowDelete = False
            dv.RowFilter = "flag = 1"

            If dsResult.Tables.Count > 0 Then
                grdQuantity.SetDataBinding(dsResult, "TProjectCreditQuantity")
            End If
            'End If

            '定性分析
            'If tabTable.SelectedTab Is tabCreditQuality Then
            Dim tmpSystemID As Int32 = gWs.GetSystemID(txtProjectNo.Text.Trim(), cboCorporationNo.SelectedValue, cboPhase.Text)
            Dim strSql As String = "{dbo.project_credit_quality_score.project_code LIKE '" + txtProjectNo.Text.Trim() + "' AND " + _
           " dbo.project_credit_quality_score.corporation_code LIKE '" + cboCorporationNo.SelectedValue + "' AND " + _
           " dbo.project_credit_quality_score.phase LIKE '" + cboPhase.Text + "' AND " + _
           " dbo.project_credit_quality_score.system_id = " + tmpSystemID.ToString + " AND " + _
           " dbo.project_credit_quality_score.[month]='" + cboMonth.Text + "'}"

            dsResult1 = gWs.FetchProjectCreditQuality( strSql)
            '如果返回的表没有记录则创建它
            'If dsResult1.Tables(0).Rows.Count = 0 Then
            '    grdQuality.SetDataBinding(dsResult1, "TProjectCreditQuality")
            '    Return
            '    ''创建定性分析表
            '    'Me.CreateCredit()

            '    ''重新获取定性分析的数据
            '    'dsResult = gWs.FetchProjectCreditQuality(txtProjectNo.Text.Trim(), cboCorporationNo.SelectedValue, cboPhase.Text)
            'End If

            '获取定性分析的标准
            Dim dsCreditQualityStandard As DataSet
            Dim systemID = gWs.GetSystemID(txtProjectNo.Text.Trim(), cboCorporationNo.SelectedValue, cboPhase.Text)
            dsCreditQualityStandard = gWs.FetchCreditQualityStandard(systemID, "%", "%")
            dsResult1.Merge(dsCreditQualityStandard)

            If dsResult1.Tables.Count > 0 Then
                grdQuality.SetDataBinding(dsResult1, "TProjectCreditQuality")
            End If

            Dim cm1 As CurrencyManager = CType(Me.BindingContext(dsResult1, "TProjectCreditQuality"), CurrencyManager)
            Dim dv1 As DataView = CType(cm1.List, DataView)
            dv1.AllowNew = False
            dv1.AllowDelete = False

            'Dim parentColumns(2) As DataColumn
            'Dim childColumns(2) As DataColumn

            'parentColumns(0) = dsResult.Tables("TProjectCreditQuality").Columns("system_id")
            'parentColumns(1) = dsResult.Tables("TProjectCreditQuality").Columns("index_type")
            'parentColumns(2) = dsResult.Tables("TProjectCreditQuality").Columns("index_id")
            'childColumns(0) = dsResult.Tables("TCreditQualityStandard").Columns("system_id")
            'childColumns(1) = dsResult.Tables("TCreditQualityStandard").Columns("index_type")
            'childColumns(2) = dsResult.Tables("TCreditQualityStandard").Columns("index_id")

            'dsResult.Relations.Add("TProjectCreditQuality_TCreditQualityStandard", parentColumns, childColumns)
            grdQuality_CurrentCellChanged(grdQuality, EventArgs.Empty)
            'End If

            Me.CreateCredit()
        Catch ex As System.ArgumentException
            Return
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    '计算按钮
    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            If Not Me.CheckData() Then
                Return
            End If

            'If tabTable.SelectedTab Is tabCreditQuality Then
            If Not grdQuality.DataSource Is Nothing Then
                gWs.UpdateProjectCreditQuality(CType(grdQuality.DataSource, DataSet).GetChanges(DataRowState.Modified))
            End If

            Me.CreateCreditQuality()
            '定量分析表或者总量表
            'ElseIf Me.tabTable.SelectedTab Is Me.tabCreditQuantity Or Me.tabTable.SelectedTab Is Me.tabCredit Then
            Me.grdQuantity.DataSource = Nothing

            Me.CreateCreditQuantity()
            'End If
            Me.CreateCredit()
        Catch ex As System.Exception
            '统一错误处理
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    '退出按钮
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    '数据校验
    Private Function CheckData() As Boolean
        If txtProjectNo.Text.Trim = "" Then
            SWDialogBox.MessageBox.Show("项目编号不能为空，请输入一个存在的项目编号！", "系统提示", "", SWDialogBox.MessageBoxButton.OK, SWDialogBox.MessageBoxIcon.Information)
            txtProjectNo.Focus()
            txtProjectNo.SelectAll()
            Return False
        End If

        If Me.cboCorporationNo.Text = "" Or Me.cboPhase.Text = "" Then
            SWDialogBox.MessageBox.Show("企业编码与阶段不能为空，请查看项目编号输入是否有误！", "系统提示", "", SWDialogBox.MessageBoxButton.OK, SWDialogBox.MessageBoxIcon.Information)
            Return False
        End If

        If (cboMonth.Enabled And cboMonth.Text.Trim().Length <> 6) Then
            SWDialogBox.MessageBox.Show("无效的年月数据，请选取一个合法的年月（YYYYMM）！", "系统提示", "", SWDialogBox.MessageBoxButton.OK, SWDialogBox.MessageBoxIcon.Information)
            Return False
        End If

        Dim systemID As Integer = gWs.GetSystemID(txtProjectNo.Text.Trim(), cboCorporationNo.SelectedValue, cboPhase.Text.Trim())
        If systemID < 1 Then
            SWDialogBox.MessageBox.Show("无法获取当前的评分体系，请确认是否指定了该项目企业所属的行业！", "系统提示", "", SWDialogBox.MessageBoxButton.OK, SWDialogBox.MessageBoxIcon.Information)
            Return False
        End If

        Return True
    End Function
    '获取正确的年月
    Private Sub GetMonth(ByRef strMonth As String, ByRef strLastMonth As String)
        strMonth = Me.cboMonth.Text
        'Dim count As Integer = Me.cboMonth.SelectedIndex
        'If count > 0 Then
        '    Me.cboLastMonth.SelectedIndex = 0
        'Else
        '    Me.cboLastMonth.SelectedIndex = count + 1
        '    strLastMonth = Me.cboLastMonth.Text
        'End If
        'strLastMonth = Me.cboLastMonth.Text

        'If Me.cboMonth.Text < Me.cboLastMonth.Text Then
        '    strMonth = Me.cboLastMonth.Text
        '    strLastMonth = Me.cboMonth.Text
        'End If
        strLastMonth = strMonth.Substring(0, 4) - 1 & "12"
    End Sub
    '定量分析
    Private Sub CreateCreditQuantity()
        '删除定量分析数据
        gWs.DeleteProjectCreditQuantity(txtProjectNo.Text, cboCorporationNo.SelectedValue, cboPhase.Text, "%")

        Dim strMonth, strLastMonth As String
        Me.GetMonth(strMonth, strLastMonth)

        gWs.CreateProjectCreditQuantity(txtProjectNo.Text, cboCorporationNo.SelectedValue, cboPhase.Text, strMonth, strLastMonth)
        '重新创建总量分析表
        gWs.CreateProjectCredit(txtProjectNo.Text, cboCorporationNo.SelectedValue, cboPhase.Text, strMonth, strLastMonth)

        Dim dsResult As DataSet = gWs.FetchProjectCredit(txtProjectNo.Text.Trim(), cboCorporationNo.SelectedValue, cboPhase.Text, _
            strMonth, strLastMonth)

        If dsResult.Tables("TProjectCredit").Rows.Count > 0 Then
            txtQuantityTotal.Text = dsResult.Tables("TProjectCredit").Rows(0)("quantity_score").ToString()
            txtQualityTotal.Text = dsResult.Tables("TProjectCredit").Rows(0)("quality_score").ToString()
            txtCreditTotal.Text = dsResult.Tables("TProjectCredit").Rows(0)("total_score").ToString()
        End If

        dsResult = gWs.FetchProjectCreditQuantity(txtProjectNo.Text.Trim(), cboCorporationNo.SelectedValue, cboPhase.Text, _
             strMonth, strLastMonth)

        Dim cm As CurrencyManager = CType(Me.BindingContext(dsResult, "TProjectCreditQuantity"), CurrencyManager)
        Dim dv As DataView = CType(cm.List, DataView)
        dv.AllowNew = False
        dv.AllowDelete = False
        dv.RowFilter = "flag = 1"

        If dsResult.Tables.Count > 0 Then
            grdQuantity.SetDataBinding(dsResult, "TProjectCreditQuantity")
        End If
    End Sub


    '定性分析

    Private Sub CreateCreditQuality()
        Dim tmpSystemID As Int32 = gWs.GetSystemID(txtProjectNo.Text.Trim(), cboCorporationNo.SelectedValue, cboPhase.Text)
        Dim strSql As String = "{dbo.project_credit_quality_score.project_code LIKE '" + txtProjectNo.Text.Trim() + "' AND " + _
                                " dbo.project_credit_quality_score.corporation_code LIKE '" + cboCorporationNo.SelectedValue + "' AND " + _
                                " dbo.project_credit_quality_score.phase LIKE '" + cboPhase.Text + "' AND " + _
                                " dbo.project_credit_quality_score.system_id = " + tmpSystemID.ToString + " AND " + _
                                " dbo.project_credit_quality_score.[month]='" + cboMonth.Text + "'}"

        Dim dsResult As DataSet = gWs.FetchProjectCreditQuality(strSql)

        '如果返回的表没有记录则创建它
        If dsResult.Tables(0).Rows.Count = 0 Then
            '创建定性分析表
            gWs.CreateProjectCreditQuality(txtProjectNo.Text.Trim(), cboCorporationNo.SelectedValue, cboPhase.Text, cboMonth.Text)

            '重新获取定性分析的数据
            dsResult = gWs.FetchProjectCreditQuality( strSql)
        End If

        '创建定量分析表
        Me.CreateCreditQuantity()

        Dim systemID = gWs.GetSystemID(txtProjectNo.Text, cboCorporationNo.SelectedValue, cboPhase.Text)

        '获取定性分析的标准
        Dim dsCreditQualityStandard As DataSet
        dsCreditQualityStandard = gWs.FetchCreditQualityStandard(systemID, "%", "%")
        dsResult.Merge(dsCreditQualityStandard)

        If dsResult.Tables.Count > 0 Then
            grdQuality.SetDataBinding(dsResult, "TProjectCreditQuality")
        End If

        Dim cm As CurrencyManager = CType(Me.BindingContext(dsResult, "TProjectCreditQuality"), CurrencyManager)
        Dim dv As DataView = CType(cm.List, DataView)
        dv.AllowNew = False
        dv.AllowDelete = False

        Dim parentColumns(2) As DataColumn
        Dim childColumns(2) As DataColumn

        parentColumns(0) = dsResult.Tables("TProjectCreditQuality").Columns("system_id")
        parentColumns(1) = dsResult.Tables("TProjectCreditQuality").Columns("index_type")
        parentColumns(2) = dsResult.Tables("TProjectCreditQuality").Columns("index_id")
        childColumns(0) = dsResult.Tables("TCreditQualityStandard").Columns("system_id")
        childColumns(1) = dsResult.Tables("TCreditQualityStandard").Columns("index_type")
        childColumns(2) = dsResult.Tables("TCreditQualityStandard").Columns("index_id")

        'dsResult.Relations.Add("TProjectCreditQuality_TCreditQualityStandard", parentColumns, childColumns)
        grdQuality_CurrentCellChanged(grdQuality, EventArgs.Empty)
    End Sub
    '显示总量分析
    Private Sub CreateCredit()
        Dim strMonth, strLastMonth As String
        Me.GetMonth(strMonth, strLastMonth)

        Dim dsResult As DataSet = gWs.FetchProjectCredit(txtProjectNo.Text.Trim(), cboCorporationNo.SelectedValue, cboPhase.Text, strMonth, strLastMonth)

        If dsResult.Tables("TProjectCredit").Rows.Count > 0 Then
            txtQuantityTotal.Text = dsResult.Tables("TProjectCredit").Rows(0)("quantity_score").ToString()
            txtQualityTotal.Text = dsResult.Tables("TProjectCredit").Rows(0)("quality_score").ToString()
            txtCreditTotal.Text = dsResult.Tables("TProjectCredit").Rows(0)("total_score").ToString()
            grdCredit.SetDataBinding(dsResult, "TProjectCredit")
        Else
            txtQuantityTotal.Text = ""
            txtQualityTotal.Text = ""
            txtCreditTotal.Text = ""
        End If
    End Sub

    'tabcontrol index change ,controls state change
    Private Sub tabTable_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabTable.SelectedIndexChanged
        Select Case tabTable.SelectedIndex
            Case 0
                cboMonth.Enabled = True
                cboLastMonth.Enabled = True

                grdQuantity.Width = tabCreditQuantity.Width - 1

                tabCreditQuantity.Controls.AddRange(New Control() {lblQuantityTotal, txtQuantityTotal, lblQualityTotal, txtQualityTotal, lblCreditTotal, txtCreditTotal})
                lblQuantityTotal.SendToBack()
                lblQualityTotal.SendToBack()
                lblCreditTotal.SendToBack()
                Me.btnRefresh.Enabled = True
                Me.btnCreate.Enabled = True
            Case 1
                cboMonth.Enabled = True
                cboLastMonth.Enabled = False

                tabCreditQuality.Controls.AddRange(New Control() {lblQuantityTotal, txtQuantityTotal, lblQualityTotal, txtQualityTotal, lblCreditTotal, txtCreditTotal})
                lblQuantityTotal.SendToBack()
                lblQualityTotal.SendToBack()
                lblCreditTotal.SendToBack()
                Me.btnRefresh.Enabled = True

                If Not Me.bCanEdit Then
                    Me.btnCreate.Enabled = False
                End If
            Case 2
                cboMonth.Enabled = True
                cboLastMonth.Enabled = True
                Me.btnRefresh.Enabled = True
                Me.btnCreate.Enabled = True
        End Select

    End Sub

    '光标移动，cboQuality的数据源随之也变化
    Private Sub grdQuality_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdQuality.CurrentCellChanged
        Static lastRow As Int32 = -1

        cboQuality.DataBindings.Clear()

        If grdQuality.CurrentRowIndex < 0 Then
            Return
        End If

        If grdQuality.CurrentRowIndex <> lastRow Then
            Dim dsQuality As DataSet = grdQuality.DataSource

            If dsQuality.Tables(0).Rows(grdQuality.CurrentRowIndex).RowState <> DataRowState.Added And dsQuality.Tables(0).Rows(grdQuality.CurrentRowIndex).RowState <> DataRowState.Deleted Then
                txtQuality.Text = dsQuality.Tables(0).Rows(grdQuality.CurrentRowIndex)("index_name").ToString()

                Dim originalValue As String = dsQuality.Tables(0).Rows(grdQuality.CurrentRowIndex)("index_value").ToString()

                dsQuality.Tables("TCreditQualityStandard").DefaultView.RowFilter = "system_id = " + dsQuality.Tables(0).Rows(grdQuality.CurrentRowIndex)("system_id").ToString() + _
                  " AND index_type = '" + dsQuality.Tables(0).Rows(grdQuality.CurrentRowIndex)("index_type").ToString() + "' AND " + _
                  "index_id = '" + dsQuality.Tables(0).Rows(grdQuality.CurrentRowIndex)("index_id").ToString() + "'"       ' filterRows

                cboQuality.DataSource = dsQuality.Tables("TCreditQualityStandard")

                If dsQuality.Tables("TCreditQualityStandard").DefaultView.Count > 0 Then
                    cboQuality.SelectedIndex = cboQuality.FindString(originalValue)
                End If
            End If
        End If

        lastRow = grdQuality.CurrentRowIndex
    End Sub
    'cboQuality index change,quanlity table change
    Private Sub cboQuality_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboQuality.SelectedIndexChanged
        If grdQuality.DataSource Is Nothing Then
            Return
        End If

        Dim dsQuanlity As DataSet
        dsQuanlity = grdQuality.DataSource

        If Not cboQuality.SelectedItem Is Nothing Then
            dsQuanlity.Tables(0).Rows(grdQuality.CurrentRowIndex)("score") = CType(cboQuality.SelectedItem, DataRowView)("score")
            dsQuanlity.Tables(0).Rows(grdQuality.CurrentRowIndex)("index_value") = CType(cboQuality.SelectedItem, DataRowView)("condition")
        Else
            dsQuanlity.Tables(0).Rows(grdQuality.CurrentRowIndex)("score") = DBNull.Value
            dsQuanlity.Tables(0).Rows(grdQuality.CurrentRowIndex)("index_value") = DBNull.Value
        End If
    End Sub

    '项目编码文本框改变，载入当前企业数据
    Private Sub txtProjectNo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProjectNo.TextChanged
        If Me.txtProjectNo.Text.Trim().Length >= Me.MaxProjectCodeLength Then
            cboCorporationNo.DataSource = gWs.FetchCorporationAccountCreditEx(txtProjectNo.Text).Tables(0)
        End If
    End Sub
    '当前企业，当前阶段变化，载入财务数据年月
    Private Sub SetMonth(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCorporationNo.SelectedIndexChanged, cboPhase.SelectedIndexChanged
        If Me.cboCorporationNo.Text = "" Or Me.cboPhase.Text = "" Then
            Return
        End If

        'cboMonth.DataSource = gWs.FetchCorporationAccountMonth(txtProjectNo.Text, cboCorporationNo.SelectedValue, cboPhase.Text).Tables(0)
        'cboMonth.DisplayMember = "month"
        'cboMonth.ValueMember = "month"
        'cboLastMonth.DataSource = gWs.FetchCorporationAccountMonth(txtProjectNo.Text, cboCorporationNo.SelectedValue, cboPhase.Text).Tables(0)
        'cboLastMonth.DisplayMember = "month"
        'cboLastMonth.ValueMember = "month"
        Dim dtTempMonth As DataTable = gWs.GetCommonQueryInfo("select  distinct [month] from corporation_account where corporation_code='" & cboCorporationNo.SelectedValue & "' and project_code='" & txtProjectNo.Text & "' and substring([month],5,2)='12'").Tables(0)
        Dim iRow As Integer
        If dtTempMonth.Rows.Count > 0 Then
            iRow = dtTempMonth.Rows.Count - 1


            cboMonth.DataSource = gWs.GetCommonQueryInfo("select distinct top  " & iRow & " [month] from corporation_account where corporation_code='" & cboCorporationNo.SelectedValue & "' and project_code='" & txtProjectNo.Text & "' and substring([month],5,2)='12' order by [month] desc").Tables(0)
            cboMonth.DisplayMember = "month"
            cboMonth.ValueMember = "month"
            cboLastMonth.DataSource = gWs.GetCommonQueryInfo("select distinct top  " & iRow & " [month] from corporation_account where corporation_code='" & cboCorporationNo.SelectedValue & "' and project_code='" & txtProjectNo.Text & "' and substring([month],5,2)='12' order by [month] desc").Tables(0)
            cboLastMonth.DisplayMember = "month"
            cboLastMonth.ValueMember = "month"

            cboLastMonth.DataSource = CType(cboMonth.DataSource, DataTable).Copy()
        End If
    End Sub

 
End Class

