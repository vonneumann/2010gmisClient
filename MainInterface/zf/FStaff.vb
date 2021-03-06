Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class FStaff
	Inherits FBaseData

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
	Friend WithEvents tsStaff As System.Windows.Forms.DataGridTableStyle
	Friend WithEvents csNo As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csName As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csBranch As DataGridComboBoxColumn
	Friend WithEvents csDepartment As DataGridTextBoxColumn
	Friend WithEvents csTeam As DataGridComboBoxColumn
	Friend WithEvents csType As DataGridComboBoxColumn
    Friend WithEvents csRights As DataGridTextBoxColumn
    Friend WithEvents csIsQuit As DataGridBoolColumn
    Friend WithEvents csDepartmentList As DataGridTextBoxColumn
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.tsStaff = New System.Windows.Forms.DataGridTableStyle()
		Me.csNo = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.csName = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.csBranch = New DataGridComboBoxColumn()
		Me.csDepartment = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.csTeam = New DataGridComboBoxColumn()
		Me.csType = New DataGridComboBoxColumn()
        Me.csRights = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csIsQuit = New System.Windows.Forms.DataGridBoolColumn
        Me.csDepartmentList = New System.Windows.Forms.DataGridTextBoxColumn
		Me.SuspendLayout()
		'
		'tsStaff
		'
		Me.tsStaff.DataGrid = Me.grdTable
        Me.tsStaff.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csNo, Me.csName, Me.csBranch, Me.csDepartment, Me.csTeam, Me.csType, Me.csIsQuit, Me.csRights, Me.csDepartmentList})
		Me.tsStaff.HeaderForeColor = System.Drawing.SystemColors.ControlText
		Me.tsStaff.MappingName = "TStaff"
		'
		'csNo
		'
		Me.csNo.Format = ""
		Me.csNo.FormatInfo = Nothing
		Me.csNo.HeaderText = "编  号"
		Me.csNo.MappingName = "staff_code"
		Me.csNo.Width = 80
		'
		'csName
		'
		Me.csName.Format = ""
		Me.csName.FormatInfo = Nothing
		Me.csName.HeaderText = "员工姓名"
		Me.csName.MappingName = "staff_name"
		Me.csName.Width = 80
		'
		'csBranch
		'
		Me.csBranch.Format = ""
		Me.csBranch.FormatInfo = Nothing
		Me.csBranch.HeaderText = "所属部门"
		Me.csBranch.MappingName = "dept_name"
		Me.csBranch.Width = 120
		'
		'csDepartment
		'
		Me.csDepartment.Format = ""
		Me.csDepartment.FormatInfo = Nothing
		Me.csDepartment.HeaderText = "机构名称"
		Me.csDepartment.MappingName = "branch_name"
		Me.csDepartment.Width = 120
		'
		'csTeam
		'
		Me.csTeam.Format = ""
		Me.csTeam.FormatInfo = Nothing
		Me.csTeam.HeaderText = "项目组"
		Me.csTeam.MappingName = "team_name"
		'
		'csType
		'
		Me.csType.Format = ""
		Me.csType.FormatInfo = Nothing
		Me.csType.HeaderText = "类  型"
		Me.csType.MappingName = "type"
        Me.csType.Width = 60
        '
        'csIsQuti
        '
        Me.csIsQuit.HeaderText = "是否离职"
        Me.csIsQuit.MappingName = "IsQuit"
        Me.csIsQuit.Width = 60
		'
		'csRights
		'
		Me.csRights.Alignment = System.Windows.Forms.HorizontalAlignment.Center
		Me.csRights.Format = ""
		Me.csRights.FormatInfo = Nothing
		Me.csRights.HeaderText = "权限定义"
		Me.csRights.MappingName = "read_logs_right"
        Me.csRights.Width = 60

        '
        'csDepartmentList
        '
        Me.csDepartmentList.Format = ""
        Me.csDepartmentList.FormatInfo = Nothing
        Me.csDepartmentList.HeaderText = "权限定义"
        Me.csDepartmentList.MappingName = "logs_department_list"
        Me.csDepartmentList.Width = 200
		'
		'FStaff
		'
		Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
		Me.ClientSize = New System.Drawing.Size(512, 333)
		Me.Name = "FStaff"
		Me.Text = "员工设置"
		Me.ResumeLayout(False)

	End Sub

#End Region

	Public Overloads Overrides Sub Refresh()
		Try
			Me.Cursor = Cursors.WaitCursor

			Dim dsResult As DataSet

			dsResult = gWs.GetStaff("%")
			grdTable.SetDataBinding(dsResult, "TStaff")
			AddHandler dsResult.Tables(0).ColumnChanged, AddressOf ColumnChanged
		Catch ex As System.Exception
			'统一错误处理
			ExceptionHandler.ShowMessageBox(ex)
		Finally
			Me.Cursor = Cursors.Default
		End Try
	End Sub

	Public Overrides Function Update() As Boolean
		Try
			Me.Cursor = Cursors.WaitCursor

            Dim dsCommit As DataSet = CType(grdTable.DataSource, DataSet)
            If Not dsCommit.HasChanges() Then
                Return False
            End If

            Dim result As String = gWs.UpdateStaff(dsCommit.GetChanges())

            If result = "1" Then
                '接受所有更改
                dsCommit.AcceptChanges()

                Return True
            Else
                '显示服务器的返回错误信息
                SWDialogBox.MessageBox.Show("*999", Me.Name + ".Update", result, "")
            End If
        Catch ex As System.Exception
			'统一错误处理
			ExceptionHandler.ShowMessageBox(ex)
		Finally
			Me.Cursor = Cursors.Default
		End Try

		Return False
	End Function

	Private Sub FStaff_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Dim dsResult As DataSet = gWs.GetBranch("%")
		Dim dtType As DataTable = New DataTable("TType")

		csBranch.ColumnComboBox.DataSource = dsResult.Tables("TBranch").DefaultView
		csBranch.ColumnComboBox.DisplayMember = "branch_name"
		csBranch.ColumnComboBox.ValueMember = "branch_name"

		csTeam.ColumnComboBox.DataSource = gWs.GetTeam("%").Tables(0).DefaultView
		csTeam.ColumnComboBox.ValueMember = "team_name"
		csTeam.ColumnComboBox.DisplayMember = "team_name"

		dtType.Columns.Add("Name", GetType(String))
		Dim row As DataRow

		row = dtType.NewRow()
		row("Name") = "专职"
		dtType.Rows.Add(row)

		row = dtType.NewRow()
		row("Name") = "兼职"
		dtType.Rows.Add(row)

		csType.ColumnComboBox.DataSource = dtType.DefaultView
		csType.ColumnComboBox.ValueMember = "Name"
		csType.ColumnComboBox.DisplayMember = "Name"

		grdTable.TableStyles.Add(Me.tsStaff)
	End Sub

	Private Sub ColumnChanged(ByVal sender As Object, ByVal e As DataColumnChangeEventArgs)
		If e.Column.ColumnName = "" Then

		End If
	End Sub
End Class
