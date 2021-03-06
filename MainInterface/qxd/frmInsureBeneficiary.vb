Public Class frmInsureBeneficiary
    Inherits frmBasic

    Private strWorkFlowID As String
    Private strProjectCode As String
    Private strCorporationName As String
    Private strTaskID As String
    Private strPerson As String
    Private strPhase As String

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
    Friend WithEvents btnConclusion As System.Windows.Forms.Button
    Friend WithEvents chbInsure As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    Public WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnConclusion = New System.Windows.Forms.Button()
        Me.chbInsure = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Location = New System.Drawing.Point(314, 144)
        Me.btnExit.Size = New System.Drawing.Size(80, 24)
        Me.btnExit.Text = "退 出(&X)"
        Me.btnExit.Visible = True
        '
        'btnConclusion
        '
        Me.btnConclusion.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnConclusion.Location = New System.Drawing.Point(112, 144)
        Me.btnConclusion.Name = "btnConclusion"
        Me.btnConclusion.Size = New System.Drawing.Size(104, 24)
        Me.btnConclusion.TabIndex = 7
        Me.btnConclusion.Text = "评审会结论(&R)"
        '
        'chbInsure
        '
        Me.chbInsure.Location = New System.Drawing.Point(216, 48)
        Me.chbInsure.Name = "chbInsure"
        Me.chbInsure.Size = New System.Drawing.Size(16, 24)
        Me.chbInsure.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(208, 23)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "保险已办妥并注明中心为第一收益人"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCommit.Location = New System.Drawing.Point(225, 144)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(80, 24)
        Me.btnCommit.TabIndex = 8
        Me.btnCommit.Text = "提 交(&C)"
        '
        'txtName
        '
        Me.txtName.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtName.Location = New System.Drawing.Point(272, 8)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(224, 21)
        Me.txtName.TabIndex = 15
        Me.txtName.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(216, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 23)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "企业名称"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(64, 8)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(128, 21)
        Me.txtCode.TabIndex = 13
        Me.txtCode.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 23)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "项目编码"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmInsureBeneficiary
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(506, 175)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtName, Me.Label2, Me.txtCode, Me.Label1, Me.btnConclusion, Me.chbInsure, Me.Label3, Me.btnCommit, Me.btnExit})
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInsureBeneficiary"
        Me.Text = "保险已办妥并注明中心为第一收益人"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmDelegateAffirm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.strProjectCode = Me.getProjectCode()
        Me.strCorporationName = Me.getCorporationName()
        Me.strWorkFlowID = Me.getWorkFlowID()
        Me.strTaskID = Me.getTaskID()
        Me.strPerson = Me.getUser()
        Me.strPhase = getPhase(strProjectCode)

        Me.txtCode.Text = Me.strProjectCode
        Me.txtName.Text = Me.strCorporationName
    End Sub

    Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        If isCommitConfirm Then
            'If MsgBoxResult.Yes = MsgBox("是否确认提交?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "提示") Then
            If MsgBoxResult.Yes = SWDialogBox.MessageBox.Show("?1000", "提交") Then
                commit()
            End If
        Else
            commit()
        End If
    End Sub
    '提交处理
    Private Sub commit()
        'If (Not isAddAffirmRecord(strProjectCode, "44", "008"))  Then
        '    MsgBox("请确认保险及授权已经完毕!", MsgBoxStyle.Exclamation, "提示")
        '    Exit Sub
        'End If
        If Me.chbInsure.Checked Then
            addAffirmRecord(strProjectCode, "44", "008")
        End If
        Dim strCommit As String
        Try
            strCommit = gWs.finishedTask(strWorkFlowID, strProjectCode, strTaskID, "", strPerson)
            If "1" = strCommit Then
                'MsgBox("提交成功!", MsgBoxStyle.Information, "提示")
                SWDialogBox.MessageBox.Show("$SubmitSucceed")
                raiseCommitSucceed()
                Me.Close()
            Else
                'MsgBox("提交失败!" & strCommit, MsgBoxStyle.Critical, "提示")
                SWDialogBox.MessageBox.Show("*999", "", strCommit, "")
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnConclusion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConclusion.Click
        Dim meet As New frmMeetRecordQuery(strProjectCode, strCorporationName)
        meet.ShowDialog()
    End Sub

    '
    '确认时,若记录已经存在,则修改确认记录;否则新增一条记录
    '保存在表project_document中
    '
    Private Function addAffirmRecord(ByVal projectCode As String, ByVal itemType As String, ByVal itemCode As String) As Boolean
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer
        Dim strResult As String
        Try
            ds = gWs.GetProjectDocumentByCondition("{project_code='" & projectCode & "' and item_type='" & itemType & "' and item_code='" & itemCode & "'}")
        Catch ex As Exception
            'MsgBox("获取project_document时出错!" & ex.Message, MsgBoxStyle.Critical, "提示")
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        If Not ds Is Nothing Then
            i = ds.Tables("TProjectDocument").Rows.Count
            If i = 1 Then
                dr = ds.Tables("TProjectDocument").Rows(0)
                With dr
                    .Item("phase") = strPhase
                    .Item("check_person") = strPerson
                    Try
                        .Item("check_date") = gWs.GetSysTime()
                    Catch ex As Exception
                        ExceptionHandler.ShowMessageBox(ex)
                    End Try
                End With
            ElseIf i = 0 Then
                dr = ds.Tables("TProjectDocument").NewRow
                With dr
                    .Item("project_code") = strProjectCode
                    .Item("phase") = strPhase
                    .Item("item_type") = itemType
                    .Item("item_code") = itemCode
                    .Item("doc_name") = Me.Text
                    .Item("check_person") = strPerson
                    Try
                        .Item("check_date") = gWs.GetSysTime()
                    Catch ex As Exception
                        ExceptionHandler.ShowMessageBox(ex)
                    End Try
                    .Item("create_person") = strPerson
                    Try
                        .Item("create_date") = gWs.GetSysTime()
                    Catch ex As Exception
                        ExceptionHandler.ShowMessageBox(ex)
                    End Try
                End With
                ds.Tables("TProjectDocument").Rows.Add(dr)
            End If
            strResult = gWs.UpdateProjectDocument(ds)
            If strResult = "1" Then
                Return True
            Else
                Return False
            End If
        End If
    End Function
    '判断是否已向project_document表插入一条记录
    Private Function isAddAffirmRecord(ByVal projectCode As String, ByVal itemType As String, ByVal itemCode As String)
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer
        Dim strResult As String
        Try
            ds = gWs.GetProjectDocumentByCondition("{project_code='" & projectCode & "' and item_type='" & itemType & "' and item_code='" & itemCode & "'}")
        Catch ex As Exception
            'MsgBox("获取project_document时出错!" & ex.Message, MsgBoxStyle.Critical, "提示")
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        If Not ds Is Nothing Then
            i = ds.Tables("TProjectDocument").Rows.Count
            If i >= 1 Then
                Return True
            Else
                Return False
            End If
        End If
    End Function
End Class
