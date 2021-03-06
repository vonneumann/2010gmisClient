using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace SWDialogBox
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	internal class FLoginBox : System.Windows.Forms.Form
	{
		private String msUserName;
		private String msPassword;
		private String msServer;
		private String msDatabase;
		private Int32 mnTimeout;
		private Boolean	_useSecurity;
		private System.Windows.Forms.Label lblUserName;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label lblServer;
		private System.Windows.Forms.TextBox txtServer;
		private System.Windows.Forms.Label lblDatabase;
		private System.Windows.Forms.TextBox txtDatabase;
		private System.Windows.Forms.Label lblTimeout;
		private System.Windows.Forms.TextBox txtTimeout;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnAdvance;
		private System.Windows.Forms.CheckBox chkSecurity;
		private System.Windows.Forms.ComboBox txtUserName;
		private System.Windows.Forms.Button btnClear;

		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public String UserName
		{
			get
			{
				return msUserName;
			}
			set
			{
				msUserName = value != null ? value.Trim() : value;
			}
		}

		public String Password
		{
			get
			{
				return msPassword;
			}
			set
			{
				msPassword = value;
			}
		}

		public String Server
		{
			get
			{
				return msServer;
			}
			set
			{
				msServer = value;
			}
		}

		public String Database
		{
			get
			{
				return msDatabase;
			}
			set
			{
				msDatabase = value;
			}
		}

		public Int32 Timeout
		{
			get
			{
				return mnTimeout;
			}
			set
			{
				mnTimeout = value;
			}
		}

		public bool UseSecurity
		{
			get
			{
				return _useSecurity;
			}
			set
			{
				if(typeof(Object).Assembly.GetName().Version > new Version(1, 0, 3300, 0))
					_useSecurity = value;
			}
		}

		public void SetLogin(String UserName, String Password, String Server, String Database, Int32 Timeout, SWDialogBox.LoginResult loginResult)
		{
			msUserName = UserName == null ? UserName : UserName.Trim();
			msPassword = Password;
			msDatabase = Database;
			msServer = Server;
			mnTimeout = Timeout;

			this.SetResult(loginResult);
		}

		public void SetResult(SWDialogBox.LoginResult loginResult)
		{
			switch(loginResult)
			{
				case SWDialogBox.LoginResult.InvalidUserName:
					this.ActiveControl = this.txtUserName;
					break;
				case SWDialogBox.LoginResult.InvalidPassword:
					this.ActiveControl = this.txtPassword;
					break;
				case SWDialogBox.LoginResult.InvalidServer:
					this.ActiveControl = this.txtServer;
					break;
				case SWDialogBox.LoginResult.InvalidDatabase:
					this.ActiveControl = this.txtDatabase;
					break;
				case SWDialogBox.LoginResult.Timeout:
					this.ActiveControl = this.txtTimeout;
					break;
			}

			//设置当前登录窗体为高级状态
			if(loginResult == SWDialogBox.LoginResult.InvalidServer ||
				loginResult == SWDialogBox.LoginResult.InvalidDatabase ||
				loginResult == SWDialogBox.LoginResult.Timeout)
				this.SetState(true);
		}

		public void SetState(Boolean isAdvance)
		{
			System.Resources.ResourceManager rm = new System.Resources.ResourceManager("SWDialogBox.SWDialogBox", this.GetType().Assembly);

			if(isAdvance)
			{
				btnAdvance.Text = rm.GetString("General");

				if(!(Boolean)btnAdvance.Tag)
				{
					this.Height += 80;

					btnOK.Top += 80;
					btnCancel.Top += 80;
					btnAdvance.Top += 80;
				}
			}
			else
			{
				btnAdvance.Text = rm.GetString("Advance");

				if((Boolean)btnAdvance.Tag)
				{
					this.Height -= 80;

					btnOK.Top -= 80;
					btnCancel.Top -= 80;
					btnAdvance.Top -= 80;
				}
			}

			btnAdvance.Tag = isAdvance;
			lblServer.Visible = isAdvance;
			txtServer.Visible = isAdvance;
			lblTimeout.Visible = isAdvance;
			txtTimeout.Visible = isAdvance;
			lblDatabase.Visible = isAdvance;
			txtDatabase.Visible = isAdvance;

			//强制刷新界面，可激发Paint事件来画分隔线。
			this.Refresh();
		}

		public void SetSizeToBackground()
		{
			if(this.BackgroundImage == null)
				return;

			btnAdvance.PerformClick();
			btnAdvance.Hide();
			btnCancel.Left = btnAdvance.Left;
			this.ClientSize = this.BackgroundImage.Size;
		}

		public FLoginBox()
		{
			// Windows 窗体设计器支持所必需的
			InitializeComponent();

			System.Resources.ResourceManager rm = new System.Resources.ResourceManager("SWDialogBox.SWDialogBox", this.GetType().Assembly);

			this.Icon = (System.Drawing.Icon)rm.GetObject("ICON-App");
			this.Text = rm.GetString("LoginBoxTitle");
			lblUserName.Text = rm.GetString("UserName");
			lblPassword.Text = rm.GetString("Password");
			lblServer.Text = rm.GetString("Server");
			lblDatabase.Text = rm.GetString("Database");
			lblTimeout.Text = rm.GetString("Timeout");

			btnOK.Text = rm.GetString("OK");
			btnCancel.Text = rm.GetString("Cancel");
			btnAdvance.Text = rm.GetString("Advance");

//			chkSecurity.Visible = (typeof(Object).Assembly.GetName().Version > new Version(1, 0, 3300, 0));

			//设置登录窗体的默认启动状态（常规状态）
			this.SetState(true);
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FLoginBox));
			this.lblUserName = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.lblPassword = new System.Windows.Forms.Label();
			this.txtServer = new System.Windows.Forms.TextBox();
			this.lblServer = new System.Windows.Forms.Label();
			this.txtDatabase = new System.Windows.Forms.TextBox();
			this.lblDatabase = new System.Windows.Forms.Label();
			this.txtTimeout = new System.Windows.Forms.TextBox();
			this.lblTimeout = new System.Windows.Forms.Label();
			this.btnAdvance = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.chkSecurity = new System.Windows.Forms.CheckBox();
			this.txtUserName = new System.Windows.Forms.ComboBox();
			this.btnClear = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblUserName
			// 
			this.lblUserName.BackColor = System.Drawing.Color.Transparent;
			this.lblUserName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblUserName.Location = new System.Drawing.Point(16, 96);
			this.lblUserName.Name = "lblUserName";
			this.lblUserName.Size = new System.Drawing.Size(85, 14);
			this.lblUserName.TabIndex = 0;
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(104, 120);
			this.txtPassword.MaxLength = 255;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(288, 22);
			this.txtPassword.TabIndex = 3;
			this.txtPassword.Text = "";
			this.txtPassword.Enter += new System.EventHandler(this.Text_Enter);
			// 
			// lblPassword
			// 
			this.lblPassword.BackColor = System.Drawing.Color.Transparent;
			this.lblPassword.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblPassword.Location = new System.Drawing.Point(16, 128);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(85, 14);
			this.lblPassword.TabIndex = 2;
			// 
			// txtServer
			// 
			this.txtServer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtServer.Location = new System.Drawing.Point(104, 168);
			this.txtServer.MaxLength = 255;
			this.txtServer.Name = "txtServer";
			this.txtServer.Size = new System.Drawing.Size(288, 22);
			this.txtServer.TabIndex = 5;
			this.txtServer.Text = "";
			this.txtServer.Enter += new System.EventHandler(this.Text_Enter);
			// 
			// lblServer
			// 
			this.lblServer.BackColor = System.Drawing.Color.Transparent;
			this.lblServer.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblServer.Location = new System.Drawing.Point(16, 176);
			this.lblServer.Name = "lblServer";
			this.lblServer.Size = new System.Drawing.Size(85, 14);
			this.lblServer.TabIndex = 4;
			// 
			// txtDatabase
			// 
			this.txtDatabase.Enabled = false;
			this.txtDatabase.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtDatabase.Location = new System.Drawing.Point(104, 200);
			this.txtDatabase.MaxLength = 50;
			this.txtDatabase.Name = "txtDatabase";
			this.txtDatabase.Size = new System.Drawing.Size(112, 22);
			this.txtDatabase.TabIndex = 7;
			this.txtDatabase.Text = "";
			this.txtDatabase.Enter += new System.EventHandler(this.Text_Enter);
			// 
			// lblDatabase
			// 
			this.lblDatabase.BackColor = System.Drawing.Color.Transparent;
			this.lblDatabase.Enabled = false;
			this.lblDatabase.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblDatabase.Location = new System.Drawing.Point(16, 208);
			this.lblDatabase.Name = "lblDatabase";
			this.lblDatabase.Size = new System.Drawing.Size(85, 14);
			this.lblDatabase.TabIndex = 6;
			// 
			// txtTimeout
			// 
			this.txtTimeout.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtTimeout.Location = new System.Drawing.Point(336, 200);
			this.txtTimeout.MaxLength = 3;
			this.txtTimeout.Name = "txtTimeout";
			this.txtTimeout.Size = new System.Drawing.Size(56, 22);
			this.txtTimeout.TabIndex = 9;
			this.txtTimeout.Text = "";
			this.txtTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtTimeout.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimeout_KeyPress);
			this.txtTimeout.TextChanged += new System.EventHandler(this.txtTimeout_TextChanged);
			this.txtTimeout.Enter += new System.EventHandler(this.Text_Enter);
			// 
			// lblTimeout
			// 
			this.lblTimeout.BackColor = System.Drawing.Color.Transparent;
			this.lblTimeout.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblTimeout.Location = new System.Drawing.Point(248, 208);
			this.lblTimeout.Name = "lblTimeout";
			this.lblTimeout.Size = new System.Drawing.Size(85, 14);
			this.lblTimeout.TabIndex = 8;
			// 
			// btnAdvance
			// 
			this.btnAdvance.BackColor = System.Drawing.Color.Transparent;
			this.btnAdvance.Location = new System.Drawing.Point(264, 248);
			this.btnAdvance.Name = "btnAdvance";
			this.btnAdvance.Size = new System.Drawing.Size(80, 24);
			this.btnAdvance.TabIndex = 12;
			this.btnAdvance.Tag = true;
			this.btnAdvance.Click += new System.EventHandler(this.btnAdvance_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.Transparent;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(168, 248);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(80, 24);
			this.btnCancel.TabIndex = 11;
			// 
			// btnOK
			// 
			this.btnOK.BackColor = System.Drawing.Color.Transparent;
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(72, 248);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(80, 24);
			this.btnOK.TabIndex = 10;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// chkSecurity
			// 
			this.chkSecurity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.chkSecurity.BackColor = System.Drawing.Color.Transparent;
			this.chkSecurity.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.chkSecurity.Location = new System.Drawing.Point(16, 224);
			this.chkSecurity.Name = "chkSecurity";
			this.chkSecurity.Size = new System.Drawing.Size(376, 24);
			this.chkSecurity.TabIndex = 13;
			this.chkSecurity.Text = "使用加密安全通道(&C)";
			this.chkSecurity.Visible = false;
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(104, 89);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(216, 20);
			this.txtUserName.TabIndex = 14;
			this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
			// 
			// btnClear
			// 
			this.btnClear.BackColor = System.Drawing.Color.Transparent;
			this.btnClear.Location = new System.Drawing.Point(328, 88);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(64, 23);
			this.btnClear.TabIndex = 15;
			this.btnClear.Text = "清 除";
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// FLoginBox
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(410, 279);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.txtUserName);
			this.Controls.Add(this.chkSecurity);
			this.Controls.Add(this.btnAdvance);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.txtTimeout);
			this.Controls.Add(this.lblTimeout);
			this.Controls.Add(this.lblDatabase);
			this.Controls.Add(this.lblServer);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lblUserName);
			this.Controls.Add(this.txtDatabase);
			this.Controls.Add(this.txtServer);
			this.Controls.Add(this.txtPassword);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.HelpButton = true;
			this.MaximizeBox = false;
			this.Name = "FLoginBox";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.FLogin_Paint);
			this.ResumeLayout(false);

		}
		#endregion

		private void Form1_Load(object sender, System.EventArgs e)
		{
			readAppXML();
			txtUserName.Text = msUserName;
			txtPassword.Text = msPassword;
			txtDatabase.Text = msDatabase;
			txtServer.Text = msServer;
			txtTimeout.Text = mnTimeout.ToString();
			chkSecurity.Checked = _useSecurity;
			if (txtUserName.Text.Trim() ==string.Empty )
			{
				this.btnOK.Enabled =false;
			}

			//			this.SetSizeToBackground();
		}

		private void FLogin_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			if(txtServer.Visible)
			{
				int top = txtPassword.Top + txtPassword.Height + 12;
				int left = lblPassword.Left;
				int right = txtPassword.Left + txtPassword.Width;

				e.Graphics.DrawLine(new System.Drawing.Pen(System.Drawing.Color.DimGray), left, top, right, top);
				e.Graphics.DrawLine(new System.Drawing.Pen(System.Drawing.Color.White), left, top + 1, right, top + 1);
			}
		}

		private void btnAdvance_Click(object sender, System.EventArgs e)
		{
			this.SetState(!txtServer.Visible);
		}

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			if(txtUserName.Text.Trim() == String.Empty)
			{
				//txtUserName.Focus();
				
				//add by wwd 2006-08-22
				//解决因未输入用户名而引发的xd错误（用空用户名登入)
				//				System.Windows.Forms.MessageBox.Show("无效的系统帐户！","系统异常",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Warning   );
				//				this.DialogResult=DialogResult.Cancel ;
			}
				
			else
			{
				msUserName = txtUserName.Text.Trim();
				msPassword = txtPassword.Text;
				msServer = txtServer.Text;
				msDatabase = txtDatabase.Text;
				mnTimeout = txtTimeout.Text == String.Empty ? 0 : Convert.ToInt32(txtTimeout.Text);
				_useSecurity = chkSecurity.Checked;

				this.Close();
			}
		}

		private void txtTimeout_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if(!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
				e.Handled = true;
		}

		private void txtTimeout_TextChanged(object sender, System.EventArgs e)
		{
			for(int i=0; i<txtTimeout.Text.Length; i++)
				if(!Char.IsDigit(txtTimeout.Text, i))
					txtTimeout.Text = "30";
		}

		private void txtUserName_Leave(object sender, System.EventArgs e)
		{
			txtUserName.Text = txtUserName.Text.Trim();
		}

		private void Text_Enter(object sender, System.EventArgs e)
		{
			if(sender is System.Windows.Forms.TextBox)
			{
				System.Windows.Forms.TextBox txt = (System.Windows.Forms.TextBox)sender;
				txt.SelectAll();
			}
		}

		//add by qxd 2006-10-27
		//如果登录名为空,则不允许登录.
		private void txtUserName_TextChanged(object sender, System.EventArgs e)
		{
			if (this.txtUserName.Text.Trim()==string.Empty )
			{
				this.btnOK.Enabled =false;
			}
			else
			{
				this.btnOK.Enabled =true;
			}
		}
	

		//读取xml中的初始值
		private  void readAppXML()
		{
			this.txtUserName.Items.Clear(); 
			XmlDocument doc=new XmlDocument();
			XmlNodeList listNode;
			string strFilePath=Application.StartupPath ;
			strFilePath=strFilePath + "\\appConfig.xml";
			//如果文件不存在，则创建一个
			if (System.IO.File.Exists(strFilePath))
			{
				doc.Load(strFilePath );
				listNode=doc.DocumentElement.ChildNodes ;
				int i;
				int count;
				count=listNode.Count;

				for(i=0; i<count;i++)
				{
					if(string.Empty  !=listNode.Item(i).Attributes.GetNamedItem("value").InnerText.Trim() )
					{
						this.txtUserName.Items.Add(listNode.Item(i).Attributes.GetNamedItem("value").InnerText);
					}
				}
			}
		}
		//写入用户
		public void writeAppXML(string userName)
		{
			XmlDocument doc=new XmlDocument() ;
			XmlNodeList listNode;
			XmlNode node;
			string strFilePath=Application.StartupPath ;
			strFilePath=strFilePath + "\\appConfig.xml";
			if (!System.IO.File.Exists(strFilePath))
			{
				CreateAppConfigXML();
			}
			doc.Load(strFilePath );
			listNode=doc.DocumentElement.ChildNodes ;
			int i;
			int count;
			count=listNode.Count;
			for(i=0;i<count;i++)
			{
				//不允许插入空值
				if(userName.ToUpper() ==listNode.Item(i).Attributes.GetNamedItem("value").InnerText.ToUpper() )
				{
					return;
				}
				//如果其中一行的value值为空，则写入userName；否则Clone一个节点，并追加在后面
				if (string.Empty  ==listNode.Item(i).Attributes.GetNamedItem("value").InnerText.Trim())
				{
					listNode.Item(i).Attributes.GetNamedItem("value").InnerText=userName;
					doc.Save(strFilePath);	
					return;
				}						
			}	
			node=listNode.Item(count-1).CloneNode(true); 
			node.Attributes.GetNamedItem("key").InnerText="user" + count;
			node.Attributes.GetNamedItem("value").InnerText=userName;
			doc.DocumentElement.AppendChild(node);
			doc.Save(strFilePath);	
		}

		//清除xml中的初始值
		private  void DelAppXML()
		{
			this.txtUserName.Items.Clear() ;  
			XmlDocument doc=new XmlDocument();
			XmlNodeList listNode;
			string strFilePath=Application.StartupPath ;
			strFilePath=strFilePath + "\\appConfig.xml";
			if (System.IO.File.Exists(strFilePath))
			{
				doc.Load(strFilePath );
				listNode=doc.DocumentElement.ChildNodes ;
				int i;
				int count;
				count=listNode.Count;
				//删除所有节点（第一个节点除外）
				if (count>=1)
				{
					listNode.Item(0).Attributes.GetNamedItem("value").InnerText="";
				}
				//从后往前删除节点
				for(i=count-1; i>=1;i--)
				{
					doc.DocumentElement.RemoveChild (listNode.Item(i)) ;
				}
				doc.Save(strFilePath);
			}
		}
		//创建appConfig.xml
		private void CreateAppConfigXML()
		{
			StreamWriter sw = new StreamWriter("appConfig.xml",false );
			// Add some text to the file.
			sw.WriteLine("{0}","<?xml version=\"1.0\" encoding=\"utf-8\"?>");				
			sw.WriteLine("{0}","<AppInfo>");
			sw.WriteLine("{0}","<add key=\"user0\" value=\"\" />");								
			sw.WriteLine("{0}","</AppInfo>");
			sw.WriteLine("{0}","<!--注意：以上内容请勿作修改，谢谢！ 深圳市恒泰丰科技有限公司 Questy-->");
			sw.Close();								
		}
		//清除登录历史列表
		private void btnClear_Click(object sender, System.EventArgs e)
		{
			DelAppXML();
		}
	}
}
