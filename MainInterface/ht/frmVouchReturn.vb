
'�ǼǷſ��ִ
Public Class frmVouchReturn
    Inherits MainInterface.frmSignVouchApplication

#Region " Windows ������������ɵĴ��� "

    Public Sub New()
        MyBase.New()

        '�õ����� Windows ���������������ġ�
        InitializeComponent()

        '�� InitializeComponent() ����֮������κγ�ʼ��

    End Sub

    '������д��������������б�
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows ����������������
    Private components As System.ComponentModel.IContainer

    'ע�⣺���¹����� Windows ����������������
    '����ʹ�� Windows ����������޸Ĵ˹��̡�
    '��Ҫʹ�ô���༭���޸�����
    Public WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Public WithEvents dtpVouchReturnEndDate As System.Windows.Forms.DateTimePicker
    Public WithEvents dtpVouchReturnStartDate As System.Windows.Forms.DateTimePicker
    Public WithEvents dtpVouchReturnSignDate As System.Windows.Forms.DateTimePicker
    Public WithEvents txtVouchReturnPerson As System.Windows.Forms.TextBox
    Friend WithEvents Label120 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmVouchReturn))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dtpVouchReturnEndDate = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtpVouchReturnStartDate = New System.Windows.Forms.DateTimePicker()
        Me.Label120 = New System.Windows.Forms.Label()
        Me.dtpVouchReturnSignDate = New System.Windows.Forms.DateTimePicker()
        Me.txtVouchReturnPerson = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grpLoanNotice.SuspendLayout()
        CType(Me.dgLoanNotice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgDatum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(8, 296)
        Me.GroupBox3.Size = New System.Drawing.Size(624, 72)
        Me.GroupBox3.Visible = True
        '
        'Label110
        '
        Me.Label110.Visible = True
        '
        'Label11
        '
        Me.Label11.Visible = True
        '
        'cmbSignVouchOpinion
        '
        Me.cmbSignVouchOpinion.DropDownWidth = 144
        Me.cmbSignVouchOpinion.ItemHeight = 12
        Me.cmbSignVouchOpinion.Visible = True
        '
        'dtpSignVouchDate
        '
        Me.dtpSignVouchDate.Visible = True
        '
        'Label10
        '
        Me.Label10.Visible = True
        '
        'txtSignVouchPeople
        '
        Me.txtSignVouchPeople.Visible = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(368, 72)
        Me.Label3.Size = New System.Drawing.Size(8, 16)
        '
        'btnViewAffirmContent
        '
        Me.btnViewAffirmContent.Location = New System.Drawing.Point(73, 496)
        Me.btnViewAffirmContent.Visible = True
        '
        'Label6
        '
        Me.Label6.Visible = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(8, 200)
        Me.GroupBox2.Size = New System.Drawing.Size(624, 96)
        Me.GroupBox2.Visible = True
        '
        'grpLoanNotice
        '
        Me.grpLoanNotice.Location = New System.Drawing.Point(8, 32)
        Me.grpLoanNotice.Size = New System.Drawing.Size(624, 168)
        Me.grpLoanNotice.Visible = True
        '
        'Label7
        '
        Me.Label7.Visible = True
        '
        'dgLoanNotice
        '
        Me.dgLoanNotice.Size = New System.Drawing.Size(618, 148)
        Me.dgLoanNotice.Visible = True
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Bitmap)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.ImageIndex = 10
        Me.btnSave.ImageList = Me.ImageListBasic
        Me.btnSave.Location = New System.Drawing.Point(248, 448)
        Me.btnSave.Size = New System.Drawing.Size(77, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.TabStop = True
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.Visible = True
        '
        'Label8
        '
        Me.Label8.Visible = True
        '
        'cmbVouchTerms
        '
        Me.cmbVouchTerms.Visible = True
        '
        'cmbVouchAccount
        '
        Me.cmbVouchAccount.Visible = True
        '
        'cmbRefundType
        '
        Me.cmbRefundType.DropDownWidth = 144
        Me.cmbRefundType.Visible = True
        '
        'cmbVouchBranchBank
        '
        Me.cmbVouchBranchBank.Visible = True
        '
        'cmbVouchBank
        '
        Me.cmbVouchBank.DropDownWidth = 144
        Me.cmbVouchBank.Visible = True
        '
        'dtpVouchDate
        '
        Me.dtpVouchDate.Location = New System.Drawing.Point(360, 72)
        '
        'Label5
        '
        Me.Label5.Visible = True
        '
        'Label4
        '
        Me.Label4.Visible = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(56, 56)
        Me.GroupBox1.Size = New System.Drawing.Size(416, 32)
        Me.GroupBox1.Visible = True
        '
        'btnUploadReport
        '
        Me.btnUploadReport.Image = CType(resources.GetObject("btnUploadReport.Image"), System.Drawing.Bitmap)
        Me.btnUploadReport.Location = New System.Drawing.Point(161, 496)
        Me.btnUploadReport.Visible = True
        '
        'dgDatum
        '
        Me.dgDatum.Size = New System.Drawing.Size(410, 12)
        Me.dgDatum.Visible = True
        '
        'btnConferenceTrial
        '
        Me.btnConferenceTrial.Image = CType(resources.GetObject("btnConferenceTrial.Image"), System.Drawing.Bitmap)
        Me.btnConferenceTrial.Location = New System.Drawing.Point(128, 448)
        Me.btnConferenceTrial.Visible = True
        '
        'btnCommit
        '
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Bitmap)
        Me.btnCommit.Location = New System.Drawing.Point(336, 448)
        Me.btnCommit.TabIndex = 2
        Me.btnCommit.Visible = True
        '
        'txtEnterpriseName
        '
        Me.txtEnterpriseName.Location = New System.Drawing.Point(272, 8)
        Me.txtEnterpriseName.Size = New System.Drawing.Size(360, 21)
        Me.txtEnterpriseName.Visible = True
        '
        'Label1
        '
        Me.Label1.Visible = True
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Visible = True
        '
        'Label2
        '
        Me.Label2.Visible = True
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(424, 448)
        Me.btnExit.Visible = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox4.Controls.AddRange(New System.Windows.Forms.Control() {Me.dtpVouchReturnEndDate, Me.Label15, Me.dtpVouchReturnStartDate, Me.Label120, Me.dtpVouchReturnSignDate, Me.txtVouchReturnPerson, Me.Label13, Me.Label14})
        Me.GroupBox4.Location = New System.Drawing.Point(8, 368)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(624, 72)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "�ǼǷſ��ִ"
        '
        'dtpVouchReturnEndDate
        '
        Me.dtpVouchReturnEndDate.Location = New System.Drawing.Point(424, 22)
        Me.dtpVouchReturnEndDate.Name = "dtpVouchReturnEndDate"
        Me.dtpVouchReturnEndDate.Size = New System.Drawing.Size(176, 21)
        Me.dtpVouchReturnEndDate.TabIndex = 18
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(320, 24)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 16)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "������ֹ"
        '
        'dtpVouchReturnStartDate
        '
        Me.dtpVouchReturnStartDate.Location = New System.Drawing.Point(112, 22)
        Me.dtpVouchReturnStartDate.Name = "dtpVouchReturnStartDate"
        Me.dtpVouchReturnStartDate.Size = New System.Drawing.Size(176, 21)
        Me.dtpVouchReturnStartDate.TabIndex = 16
        '
        'Label120
        '
        Me.Label120.Location = New System.Drawing.Point(24, 24)
        Me.Label120.Name = "Label120"
        Me.Label120.Size = New System.Drawing.Size(54, 16)
        Me.Label120.TabIndex = 15
        Me.Label120.Text = "��������"
        '
        'dtpVouchReturnSignDate
        '
        Me.dtpVouchReturnSignDate.Enabled = False
        Me.dtpVouchReturnSignDate.Location = New System.Drawing.Point(424, 40)
        Me.dtpVouchReturnSignDate.Name = "dtpVouchReturnSignDate"
        Me.dtpVouchReturnSignDate.Size = New System.Drawing.Size(8, 21)
        Me.dtpVouchReturnSignDate.TabIndex = 14
        Me.dtpVouchReturnSignDate.Visible = False
        '
        'txtVouchReturnPerson
        '
        Me.txtVouchReturnPerson.BackColor = System.Drawing.Color.Gainsboro
        Me.txtVouchReturnPerson.Location = New System.Drawing.Point(112, 46)
        Me.txtVouchReturnPerson.Name = "txtVouchReturnPerson"
        Me.txtVouchReturnPerson.ReadOnly = True
        Me.txtVouchReturnPerson.Size = New System.Drawing.Size(176, 21)
        Me.txtVouchReturnPerson.TabIndex = 13
        Me.txtVouchReturnPerson.Text = ""
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(24, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 16)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "�Ǽ���"
        '
        'Label14
        '
        Me.Label14.Enabled = False
        Me.Label14.Location = New System.Drawing.Point(400, 48)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(8, 16)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "�Ǽ�����"
        Me.Label14.Visible = False
        '
        'frmVouchReturn
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(642, 479)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnAdd, Me.btnViewAffirmContent, Me.btnSave, Me.grpLoanNotice, Me.btnConferenceTrial, Me.btnUploadReport, Me.GroupBox2, Me.btnCommit, Me.btnExit, Me.txtEnterpriseName, Me.txtProjectCode, Me.Label2, Me.Label1, Me.GroupBox1, Me.GroupBox3, Me.GroupBox4})
        Me.Name = "frmVouchReturn"
        Me.Text = "�ǼǷſ��ִ"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.grpLoanNotice.ResumeLayout(False)
        CType(Me.dgLoanNotice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgDatum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private ds As DataSet
    Private strUpdateResult As String
    Private bIsVouchReturnFormLoad As Boolean

    Private Sub frmVouchReturn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            'Me.GroupBox3.Enabled = False
            Me.bIsVouchReturnFormLoad = False
            Call Me.SignVouchApplicationLockContral()
            Call Me.GetVouchReturnData()
            Me.cmbVouchTerms.Enabled = False
            Me.bIsVouchReturnFormLoad = True
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub GetVouchReturnData()
        ds = gWs.GetLoanNoticeInfo("{project_code='" & Me.strProjectCode & "' order by create_date desc}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                If Not .Item("start_date") Is System.DBNull.Value Then
                    Me.dtpVouchReturnStartDate.Value = .Item("start_date")
                Else
                    Me.dtpVouchReturnStartDate.Value = gWs.GetSysTime()
                End If
                If Not .Item("end_date") Is System.DBNull.Value Then
                    Me.dtpVouchReturnEndDate.Value = .Item("end_date")
                Else
                    Me.dtpVouchReturnEndDate.Value = gWs.GetSysTime()
                End If
                If Not .Item("register_person") Is System.DBNull.Value Then
                    Me.txtVouchReturnPerson.Text = .Item("register_person")
                Else
                    Me.txtVouchReturnPerson.Text = Me.strUserID
                End If
                If Not .Item("register_date") Is System.DBNull.Value Then
                    Me.dtpVouchReturnSignDate.Value = .Item("register_date")
                Else
                    Me.dtpVouchReturnSignDate.Value = gWs.GetSysTime()
                End If
            End With
        End If
    End Sub

    Protected Overrides Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim strTemp As String
        If Me.isCommitConfirm = True Then
            'If MessageBox.Show("�Ƿ�ȷ���ύ��", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            If SWDialogBox.MessageBox.Show("?1000", "") = DialogResult.No Then
                Return
            End If
        End If
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            strTemp = Me.SaveData()
            If strTemp Is Nothing Then
                Return
            End If
            If strTemp <> "1" Then
                'MessageBox.Show("���ݱ���ʧ�ܣ�" + strTemp, "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                SWDialogBox.MessageBox.Show("*999", "frmVouchReturn.btnCommit_Click", strTemp, "Me.SaveData")
                Return
            Else
                Me.bIsVouchReturnFormLoad = False : Me.bIsTextChange = False
            End If
            Me.CommitWorkFlow("", Me)
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Protected Overrides Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim strTemp As String
        strTemp = Me.SaveData()
        If strTemp Is Nothing Then
            Return
        End If
        If strTemp <> "1" Then
            'MessageBox.Show("���ݱ���ʧ�ܣ�" + strTemp, "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SWDialogBox.MessageBox.Show("*999", "frmVouchReturn.btnCommit_Click", strTemp, "Me.SaveData")
            Return
        Else
            'MessageBox.Show("���ݱ���ɹ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            SWDialogBox.MessageBox.Show("$SaveSucceed")
            Me.bIsVouchReturnFormLoad = False : Me.bIsTextChange = False
        End If
    End Sub

    Private Function SaveData() As String
        If Me.dtpVouchReturnStartDate.Value.Date.CompareTo(Me.dtpVouchReturnEndDate.Value.Date) >= 0 Then
            'MessageBox.Show("�ſ���ʼ����ӦС�ڷſ��ֹ���ڡ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SWDialogBox.MessageBox.Show("$1008", "�ſ���ʼ����", "�ſ��ֹ����")
            Me.dtpVouchReturnStartDate.Focus()
            Return Nothing
        End If
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            ds = gWs.GetLoanNoticeInfo("{project_code='" & Me.strProjectCode & "' order by create_date desc}")
            If Not ds.Tables(0).Rows.Count = 0 Then
                With ds.Tables(0).Rows(0)
                    .Item("register_person") = Me.strUserID
                    .Item("register_date") = Me.dtpVouchReturnSignDate.Value
                    .Item("start_date") = Me.dtpVouchReturnStartDate.Value
                    .Item("end_date") = Me.dtpVouchReturnEndDate.Value
                End With
                Return gWs.UpdateLoanNotice(ds)
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
            Return ex.Message
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Function

    Private Sub dtpVouchReturnSignDate_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpVouchReturnSignDate.TextChanged
        If Me.bIsVouchReturnFormLoad Then Me.bIsTextChange = True
    End Sub

    Private Sub dtpVouchReturnStartDate_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpVouchReturnStartDate.TextChanged
        If bIsVouchReturnFormLoad = True Then
            Dim i As Integer
            i = Convert.ToInt16(Me.cmbVouchTerms.Text.Trim())
            Me.dtpVouchReturnEndDate.Value = Convert.ToDateTime(Me.dtpVouchReturnStartDate.Value.AddMonths(i))
            If Me.bIsVouchReturnFormLoad Then Me.bIsTextChange = True
        End If
    End Sub

    Private Sub dtpVouchReturnEndDate_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpVouchReturnEndDate.TextChanged
        If Me.bIsVouchReturnFormLoad Then Me.bIsTextChange = True
    End Sub
    '�˳���ť
    Protected Overrides Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim dlgResult As MsgBoxResult
        Dim strTemp As String

        If Me.bIsTextChange Then
            'dlgResult = MessageBox.Show("�Ƿ񱣴�����ݵ��޸ģ�", "��ʾ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            dlgResult = SWDialogBox.MessageBox.Show("?1003")
            If dlgResult = MsgBoxResult.Yes Then
                strTemp = Me.SaveData()
                If strTemp Is Nothing Then
                    Return
                End If
                If strTemp <> "1" Then
                    'MessageBox.Show("���ݱ���ʧ�ܣ�" + strTemp, "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    SWDialogBox.MessageBox.Show("*999", "frmVouchReturn.btnExit_Click", strTemp, "Me.SaveData")
                    Return
                Else
                    Me.Close()
                    Me.bIsVouchReturnFormLoad = False : Me.bIsTextChange = False
                End If
            ElseIf dlgResult = MsgBoxResult.No Then
                Me.Close()
                Me.bIsVouchReturnFormLoad = False : Me.bIsTextChange = False
            ElseIf dlgResult = MsgBoxResult.Cancel Then
                Return
            End If
        Else
            Me.Close()
            Me.bIsVouchReturnFormLoad = False : Me.bIsTextChange = False
        End If
    End Sub

    '���ѡ��datagrid�е����������Ŀؼ�
    Protected Overrides Sub dgLoanNotice_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim currentRow As Integer = Me.dgLoanNotice.CurrentRowIndex
        Me.dgLoanNotice.Select(currentRow)

        Me.cmbVouchBank.Text = Me.dgLoanNotice.Item(currentRow, 1)
        Me.cmbVouchBranchBank.Text = Me.dgLoanNotice.Item(currentRow, 2)
        Me.cmbVouchAccount.Text = Me.dgLoanNotice.Item(currentRow, 3)
        Me.cmbVouchTerms.Text = Me.dgLoanNotice.Item(currentRow, 4)

        If currentRow = Me.dsLoanNotice.Tables(0).Rows.Count - 1 Then
            Me.GroupBox2.Text = "��ǰ�ķſ���Ϣ"
        Else
            Me.GroupBox2.Text = "���еķſ���Ϣ"
        End If
    End Sub

    
End Class
