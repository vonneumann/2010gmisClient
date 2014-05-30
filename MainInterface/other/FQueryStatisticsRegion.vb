

Public Class FQueryStatisticsRegion
    Inherits MainInterface.FQueryBase
    '合作区情况统计
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbStartYear As System.Windows.Forms.ComboBox
    Friend WithEvents cmbEndYear As System.Windows.Forms.ComboBox
    Friend WithEvents cmbEndMonth As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboChartStyle As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkChart As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbStartYear = New System.Windows.Forms.ComboBox()
        Me.cmbEndYear = New System.Windows.Forms.ComboBox()
        Me.cmbEndMonth = New System.Windows.Forms.ComboBox()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboChartStyle = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkChart = New System.Windows.Forms.CheckBox()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCondition.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRefresh
        '
        Me.btnRefresh.Visible = True
        '
        'btnClear
        '
        Me.btnClear.Visible = True
        '
        'grdTable
        '
        Me.grdTable.AccessibleName = "DataGrid"
        Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdTable.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.grdTable.Visible = True
        '
        'grpCondition
        '
        Me.grpCondition.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmbEndMonth, Me.cmbEndYear, Me.cmbStartYear, Me.Label2, Me.Label1})
        Me.grpCondition.Size = New System.Drawing.Size(392, 96)
        Me.grpCondition.Visible = True
        '
        'btnExport
        '
        Me.btnExport.Visible = True
        '
        'btnPrint
        '
        Me.btnPrint.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Visible = True
        '
        'chkVisible
        '
        Me.chkVisible.Visible = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "起始年份"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(144, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "截止年月"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbStartYear
        '
        Me.cmbStartYear.Location = New System.Drawing.Point(72, 41)
        Me.cmbStartYear.MaxLength = 4
        Me.cmbStartYear.Name = "cmbStartYear"
        Me.cmbStartYear.Size = New System.Drawing.Size(64, 20)
        Me.cmbStartYear.TabIndex = 2
        '
        'cmbEndYear
        '
        Me.cmbEndYear.Location = New System.Drawing.Point(200, 41)
        Me.cmbEndYear.MaxLength = 4
        Me.cmbEndYear.Name = "cmbEndYear"
        Me.cmbEndYear.Size = New System.Drawing.Size(64, 20)
        Me.cmbEndYear.TabIndex = 3
        '
        'cmbEndMonth
        '
        Me.cmbEndMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEndMonth.Location = New System.Drawing.Point(264, 41)
        Me.cmbEndMonth.Name = "cmbEndMonth"
        Me.cmbEndMonth.Size = New System.Drawing.Size(44, 20)
        Me.cmbEndMonth.TabIndex = 4
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.grdTable
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Table"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "合作区局"
        Me.DataGridTextBoxColumn1.MappingName = "Partner"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 150
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "推荐单数"
        Me.DataGridTextBoxColumn2.MappingName = "RecordCount"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 90
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn3.Format = "n"
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "推荐金额(万元)"
        Me.DataGridTextBoxColumn3.MappingName = "RecSum"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 150
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "评审通过单数"
        Me.DataGridTextBoxColumn4.MappingName = "GuaranteeCount"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 90
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn5.Format = "n"
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "评审通过金额(万元)"
        Me.DataGridTextBoxColumn5.MappingName = "GuaranteeSum"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 150
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "签约单数"
        Me.DataGridTextBoxColumn8.MappingName = "SigCount"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.Width = 75
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn9.Format = "n"
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "签约金额(万元)"
        Me.DataGridTextBoxColumn9.MappingName = "SigSum"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.Width = 150
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "正式承保单数"
        Me.DataGridTextBoxColumn6.MappingName = "LoanCount"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 90
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn7.Format = "n"
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "正式承保金额(万元)"
        Me.DataGridTextBoxColumn7.MappingName = "LoanSum"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 150
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.cboChartStyle, Me.Label4, Me.chkChart})
        Me.GroupBox1.Location = New System.Drawing.Point(408, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(296, 96)
        Me.GroupBox1.TabIndex = 109
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "图表样式"
        '
        'cboChartStyle
        '
        Me.cboChartStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboChartStyle.Items.AddRange(New Object() {"饼图", "三维饼图"})
        Me.cboChartStyle.Location = New System.Drawing.Point(144, 56)
        Me.cboChartStyle.Name = "cboChartStyle"
        Me.cboChartStyle.Size = New System.Drawing.Size(121, 20)
        Me.cboChartStyle.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 23)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "请选择一种图表样式："
        '
        'chkChart
        '
        Me.chkChart.Checked = True
        Me.chkChart.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkChart.Location = New System.Drawing.Point(16, 24)
        Me.chkChart.Name = "chkChart"
        Me.chkChart.TabIndex = 8
        Me.chkChart.Text = "生成图表"
        '
        'FQueryStatisticsRegion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(712, 493)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExport, Me.btnClear, Me.grdTable, Me.btnPrint, Me.btnExit, Me.btnRefresh, Me.chkVisible, Me.grpCondition, Me.GroupBox1})
        Me.Name = "FQueryStatisticsRegion"
        Me.Text = "合作区情况统计表"
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCondition.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FQueryStatisticsRegion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setYear()
        setMonth()

        ' Added by Andy on 2/10/2004
        cboChartStyle.SelectedIndex = 0
        MyBase.chkVisible.Visible = False
        MyBase.btnClear.Visible = False
        ' Ended by Andy

        MyBase.ReportFile = Application.StartupPath & "\Reports\QueryStatisticsRegion.rpt"
        MyBase.ReportTitle = "合作区情况统计表"
    End Sub
    '设置(起始,截止)年份的初始值
    Private Sub setYear()
        Dim i As Integer
        For i = 1950 To 2050
            Me.cmbStartYear.Items.Add(i)
            Me.cmbEndYear.Items.Add(i)
        Next
        Me.cmbStartYear.SelectedItem = Date.Now.Year
        Me.cmbEndYear.SelectedItem = Date.Now.Year
    End Sub
    '设置月份的初始值
    Private Sub setMonth()
        Dim i As Integer
        For i = 1 To 12
            Me.cmbEndMonth.Items.Add(i)
        Next
        Me.cmbEndMonth.SelectedItem = Date.Now.Month
    End Sub
    '获得查询条件
    Private Overloads Sub GetCondition(ByRef startYear As String, ByRef endYear As String, ByRef endMonth As String)
        startYear = Me.cmbStartYear.Text.Trim
        endYear = Me.cmbEndYear.Text.Trim
        endMonth = Me.cmbEndMonth.Text.Trim
    End Sub
    '查询
    Protected Overloads Overrides Sub Refresh(ByVal condition As String)
        Dim startYear, endYear, endMonth As String
        GetCondition(startYear, endYear, endMonth)
        If startYear.Trim = "" Then
            'MsgBox("日期不能为空!", MsgBoxStyle.Exclamation, "提示")
            SWDialogBox.MessageBox.Show("$1001", "年份")
            Me.cmbStartYear.Focus()
            Exit Sub
        End If
        If endYear.Trim = "" Then
            'MsgBox("日期不能为空!", MsgBoxStyle.Exclamation, "提示")
            SWDialogBox.MessageBox.Show("$1001", "年份")
            Me.cmbEndYear.Focus()
            Exit Sub
        End If
        If determineDate(startYear, endYear) Then
            Exit Sub
        End If
        Dim dsResult As DataSet
        Dim recordCount As Integer
        dsResult = gWs.FQueryStatisticsRegion(startYear, endYear + endMonth, UserName)
        If Not dsResult Is Nothing Then

            Dim rowCount As Integer
            Dim i As Integer
            Dim recCount, guaranteeCount, loanCount, sigCount As Integer
            Dim recSum, guaranteeSum, loanSum, sigSum As Double
            Dim dr As DataRow

            rowCount = dsResult.Tables(0).Rows.Count
            Try
                If rowCount > 0 Then
                    For i = 0 To rowCount - 1
                        dr = dsResult.Tables(0).Rows(i)
                        With dr

                            recCount = recCount + CInt(.Item("RecordCount") + "0")
                            guaranteeCount = guaranteeCount + CInt(.Item("GuaranteeCount") + "0")
                            loanCount = loanCount + CInt(.Item("LoanCount") + "0")
                            sigCount = sigCount + CInt(.Item("SigCount") + "0")

                            recSum = recSum + CDbl(.Item("RecSum") + "0.0")
                            guaranteeSum = guaranteeSum + CDbl(.Item("GuaranteeSum") + "0.0")
                            loanSum = loanSum + CDbl(.Item("LoanSum") + "0.0")
                            sigSum = sigSum + CDbl(.Item("SigSum") + "0.0")
                        End With
                    Next
                    dr = dsResult.Tables(0).NewRow
                    With dr
                        .Item("Partner") = "合计"
                        .Item("RecordCount") = recCount
                        .Item("RecSum") = recSum
                        .Item("GuaranteeCount") = guaranteeCount
                        .Item("GuaranteeSum") = guaranteeSum
                        .Item("LoanCount") = loanCount
                        .Item("LoanSum") = loanSum
                        .Item("SigCount") = sigCount
                        .Item("SigSum") = sigSum
                    End With
                    dsResult.Tables(0).Rows.Add(dr)
                End If
            Catch ex As Exception
                ExceptionHandler.ShowMessageBox(ex)
            End Try
            MyBase.DataSource = dsResult.Tables(0)
            Me.grdTable.DataSource = dsResult.Tables(0)
            recordCount = dsResult.Tables(0).Rows.Count
            Me.Text = "合作区情况统计表" & "(" & recordCount & ")"
        End If

    End Sub
    '覆盖Clear()方法
    Protected Overrides Sub Clear()
        Dim control As Control

        For Each control In grpCondition.Controls
            If control.GetType() Is GetType(ComboBox) Then
                CType(control, ComboBox).SelectedItem = Date.Now.Year
                CType(control, ComboBox).SelectedItem = Date.Now.Month
            End If
        Next
    End Sub
    '判断起始年份和截止年份的大小
    '判断起始和截止日期
    Private Function determineDate(ByVal dateStart As String, ByVal dateEnd As String)
        If dateStart > dateEnd Then
            'MsgBox("截止年份必须大于或等于起始年份", MsgBoxStyle.Exclamation, "提示")
            SWDialogBox.MessageBox.Show("$1008", "起始年份", "截止年份")
            Me.cmbStartYear.Text = dateEnd
        End If
    End Function

    ' Modified by Andy on 2/10/2004
    Protected Overrides Sub Export()

        Dim strFlag As String
        Select Case Trim(cboChartStyle.Text)
            Case "柱状图"
                strFlag = "0"
            Case "折线图"
                strFlag = "1"
            Case "饼图"
                strFlag = "2"
            Case "三维柱形图"
                strFlag = "3"
            Case "三维折线图"
                strFlag = "4"
            Case "三维饼图"
                strFlag = "5"
            Case Else
                strFlag = "0"
        End Select

        If Me.chkChart.Checked Then
            Dim arrChart1 As New ArrayList()
            Dim arrChart2 As New ArrayList()
            Dim arrChart3 As New ArrayList()
            Dim arrChart4 As New ArrayList()
            Dim arrChartList As New ArrayList()

            arrChart1.Add(strFlag)
            arrChart1.Add("合作区局")
            arrChart1.Add("推荐金额(万元)")

            arrChart2.Add(strFlag)
            arrChart2.Add("合作区局")
            arrChart2.Add("评审通过金额(万元)")
            'arrChart1.Add("签约金额(万元)")
            'arrChart1.Add("正式承保金额(万元)")

            arrChart3.Add(strFlag)
            arrChart3.Add("合作区局")
            arrChart3.Add("推荐单数")

            arrChart4.Add(strFlag)
            arrChart4.Add("合作区局")
            arrChart4.Add("评审通过单数")
            'arrChart2.Add("签约单数")
            'arrChart2.Add("正式承保单数")

            arrChartList.Add(arrChart1)
            arrChartList.Add(arrChart2)
            arrChartList.Add(arrChart3)
            arrChartList.Add(arrChart4)

            ReportToExcel.ToExcel(grdTable, ReportTitle, ReportTitle, arrChartList)
        Else
            ReportToExcel.ToExcel(grdTable, ReportTitle, ReportTitle)
        End If
    End Sub
    ' Ended by Andy

    Private Sub chkChart_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkChart.CheckedChanged
        ' IIf(chkChart.Checked, cboChartStyle.Enabled = True, cboChartStyle.Enabled = False)
        If chkChart.Checked Then
            cboChartStyle.Enabled = True
        Else
            cboChartStyle.Enabled = False
        End If
    End Sub

End Class
