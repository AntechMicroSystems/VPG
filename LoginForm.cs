using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace HMIShopLink
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class LoginForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.TextBox txtUseId;
		private System.Windows.Forms.Label lblUserId;
		private System.Windows.Forms.Label lblPwd;
		private System.Windows.Forms.TextBox txtPwd;
		private System.Windows.Forms.Button btnCancel;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		string user;
		private System.ComponentModel.Container components = null;
		public static string LoginUser;
		private System.Windows.Forms.Button btnAddUser;
		private DataBaseAccess DatabaseObj= null;
		//		public delegate void evennumberhandler(object 
		bool _visibleAddUser=false;
		bool isValidUserName = false;
		public static string LoginName;
		private System.Windows.Forms.LinkLabel linklblForgotPwd;
		private System.Windows.Forms.TextBox txConfirm;
		private System.Windows.Forms.Button btnOK;
		int _loginCount = 0 ;
//		public LoginForm()
//		{
//			InitializeComponent();
//			if(DatabaseObj == null)
//				DatabaseObj=new DataBaseAccess();
//		}
		public LoginForm(bool visibleAddUser)
		{
			InitializeComponent();
			_visibleAddUser = visibleAddUser;
			if(DatabaseObj == null)
				DatabaseObj=new DataBaseAccess();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnOK = new System.Windows.Forms.Button();
			this.txConfirm = new System.Windows.Forms.TextBox();
			this.linklblForgotPwd = new System.Windows.Forms.LinkLabel();
			this.lblPwd = new System.Windows.Forms.Label();
			this.lblUserId = new System.Windows.Forms.Label();
			this.txtPwd = new System.Windows.Forms.TextBox();
			this.txtUseId = new System.Windows.Forms.TextBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnAddUser = new System.Windows.Forms.Button();
			this.btnLogin = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.btnOK);
			this.panel1.Controls.Add(this.txConfirm);
			this.panel1.Controls.Add(this.linklblForgotPwd);
			this.panel1.Controls.Add(this.lblPwd);
			this.panel1.Controls.Add(this.lblUserId);
			this.panel1.Controls.Add(this.txtPwd);
			this.panel1.Controls.Add(this.txtUseId);
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.btnLogin);
			this.panel1.Location = new System.Drawing.Point(8, 8);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(456, 232);
			this.panel1.TabIndex = 1;
			// 
			// btnOK
			// 
			this.btnOK.BackColor = System.Drawing.Color.RoyalBlue;
			this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnOK.ForeColor = System.Drawing.Color.White;
			this.btnOK.Location = new System.Drawing.Point(200, 184);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(96, 32);
			this.btnOK.TabIndex = 14;
			this.btnOK.Tag = "4";
			this.btnOK.Text = "OK";
			this.btnOK.Visible = false;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// txConfirm
			// 
			this.txConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txConfirm.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.txConfirm.Location = new System.Drawing.Point(157, 144);
			this.txConfirm.Name = "txConfirm";
			this.txConfirm.PasswordChar = '*';
			this.txConfirm.Size = new System.Drawing.Size(240, 22);
			this.txConfirm.TabIndex = 13;
			this.txConfirm.Tag = "3";
			this.txConfirm.Text = "";
			this.txConfirm.Visible = false;
			// 
			// linklblForgotPwd
			// 
			this.linklblForgotPwd.Location = new System.Drawing.Point(0, 184);
			this.linklblForgotPwd.Name = "linklblForgotPwd";
			this.linklblForgotPwd.Size = new System.Drawing.Size(192, 23);
			this.linklblForgotPwd.TabIndex = 12;
			this.linklblForgotPwd.TabStop = true;
			this.linklblForgotPwd.Text = "Change Username/Password";
			this.linklblForgotPwd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblForgotPwd_LinkClicked);
			// 
			// lblPwd
			// 
			this.lblPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblPwd.ForeColor = System.Drawing.Color.Blue;
			this.lblPwd.Location = new System.Drawing.Point(37, 113);
			this.lblPwd.Name = "lblPwd";
			this.lblPwd.TabIndex = 0;
			this.lblPwd.Text = "Password :";
			// 
			// lblUserId
			// 
			this.lblUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblUserId.ForeColor = System.Drawing.Color.Blue;
			this.lblUserId.Location = new System.Drawing.Point(37, 65);
			this.lblUserId.Name = "lblUserId";
			this.lblUserId.TabIndex = 1;
			this.lblUserId.Text = "User Name :";
			// 
			// txtPwd
			// 
			this.txtPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtPwd.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.txtPwd.Location = new System.Drawing.Point(157, 105);
			this.txtPwd.Name = "txtPwd";
			this.txtPwd.PasswordChar = '*';
			this.txtPwd.Size = new System.Drawing.Size(240, 22);
			this.txtPwd.TabIndex = 2;
			this.txtPwd.Tag = "3";
			this.txtPwd.Text = "";
			// 
			// txtUseId
			// 
			this.txtUseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtUseId.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.txtUseId.Location = new System.Drawing.Point(157, 62);
			this.txtUseId.Name = "txtUseId";
			this.txtUseId.Size = new System.Drawing.Size(240, 22);
			this.txtUseId.TabIndex = 3;
			this.txtUseId.Tag = "2";
			this.txtUseId.Text = "";
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.RoyalBlue;
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnCancel.ForeColor = System.Drawing.Color.White;
			this.btnCancel.Location = new System.Drawing.Point(296, 184);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(96, 32);
			this.btnCancel.TabIndex = 8;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnAddUser
			// 
			this.btnAddUser.BackColor = System.Drawing.Color.RoyalBlue;
			this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnAddUser.ForeColor = System.Drawing.Color.White;
			this.btnAddUser.Location = new System.Drawing.Point(208, 192);
			this.btnAddUser.Name = "btnAddUser";
			this.btnAddUser.Size = new System.Drawing.Size(96, 32);
			this.btnAddUser.TabIndex = 10;
			this.btnAddUser.Tag = "4";
			this.btnAddUser.Text = "&Add User";
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.Color.RoyalBlue;
			this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnLogin.ForeColor = System.Drawing.Color.White;
			this.btnLogin.Location = new System.Drawing.Point(200, 184);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(96, 32);
			this.btnLogin.TabIndex = 7;
			this.btnLogin.Text = "&Login";
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// LoginForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(472, 254);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnAddUser);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login Page";
			this.Load += new System.EventHandler(this.LoginForm_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
				//Application.EnableVisualStyles();
				

				 Application.Run(new MachinStatusPage()/*new LoginForm()*/);
		
		}

		private void btnLogin_Click(object sender, System.EventArgs e)
		{
			try
			{
				
				if(txtUseId.Text.Length>0 || txtPwd.Text.Length>0)
				{
					string strEncript =txtPwd.Text;
					if(DatabaseObj.IsValidUser(txtUseId.Text,strEncript,LoginUser))
					{
						MessageBox.Show("Login Succesfully");
						isValidUserName = true;
						LoginName = txtUseId.Text;
						this.Close();
					}
					else
					{
						MessageBox.Show("Please Check the Login Id");
						isValidUserName = false;
						_loginCount++;
						if(_loginCount == 3)
						{
							MessageBox.Show("sorry ! u have exceeded the maximum try","Warning");
							Application.Exit();
						}
					}
				}
				else
				{
					MessageBox.Show("Field can not be blank","Error!");
					isValidUserName = false;

				}
			}
			catch(Exception ex)
			{
				ex.ToString();
			}
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			DialogResult =DialogResult.Cancel;
		}

		private void LoginForm_Load(object sender, System.EventArgs e)
		{
			LoginUser="admin";
			if(LoginUser == "admin")
				btnAddUser.Enabled = true;
			else
				btnAddUser.Enabled = false;

			if(_visibleAddUser)
			{
				btnAddUser.Visible = true;
				btnLogin.Visible = false;
				
			}
			else
			{
				btnAddUser.Visible = false;
			}
		}

		private void radioBtnAdmin_Click(object sender, System.EventArgs e)
		{
			RadioButton rb=(RadioButton)sender;
			if(rb.Checked)
			{
				LoginUser=rb.Text;
			}
		}

		public void btnAddUser_Click()
		{
			//			AddUserPage adduser = new AddUserPage();
			//			adduser.ShowDialog();
			
			{
				try
				{
					if(txtUseId.TextLength>0 && txtPwd.TextLength>0 && txConfirm.TextLength>0)
					{
						if (txtPwd.Text.ToString()==txConfirm.Text.ToString())
						{
							string strEncript =txtPwd.Text;
							object[] param = {txtUseId.Text,strEncript,LoginUser};
							DatabaseObj.RunStoredProcedure("Usp_InsertLogin",param);
							MessageBox.Show("User created successfully ");
							
							ClearAllText();
						}
						else
						{
							MessageBox.Show("Please Enter valid Password");
						}
					}
					else
					{
						MessageBox.Show("Field can not be blank");
					}
				}
				catch(Exception ex)
				{
					string exceptionMsg ="Violation of PRIMARY KEY constraint 'PK_Login'. Cannot insert duplicate key in object 'dbo.Login'.";
					if(ex.Message==exceptionMsg)
					{
						MessageBox.Show("User name already exist.");
						ClearAllText();
					}
				}
			}
			
			
		}
		private void ClearAllText()
		{
			txtUseId.Clear();
			txtPwd.Clear();
			txConfirm.Clear();
		
		}

		public static string EncriptPWD(string pwd)//abc
		{
			string strEncript=null;int c;
			for(int i =0;i<pwd.Length;i++)
			{
				c =pwd[i]+ 100;
				strEncript +=(char)c;
			}
			return strEncript;
		}

		public static string DecriptPWD(string pwd)//abc
		{
			int c;string strDecript=null;
			for(int i =0;i<pwd.Length;i++)
			{
				c =pwd[i]+(-100);
				strDecript +=(char)c;
			}
			return strDecript;

		}

		private void radioBtnUser_CheckedChanged(object sender, System.EventArgs e)
		{
		
		}

		private void linklblForgotPwd_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			
			
			try
			{
				
				if(txtUseId.Text.Length>0 || txtPwd.Text.Length>0)
				{
					string strEncript =txtPwd.Text;
					if(DatabaseObj.IsValidUser(txtUseId.Text,strEncript,LoginUser))
					{
						txConfirm.Visible=true;
						btnLogin.Visible=false;
					btnOK.Visible=true;
					user=txtUseId.Text.ToString();
						ClearAllText();

					}
					else
					{
						MessageBox.Show("Please Check the Login Id");
						isValidUserName = false;
						_loginCount++;
						if(_loginCount == 3)
						{
							MessageBox.Show("sorry ! u have exceeded the maximum try","Warning");
							Application.Exit();
						}
					}
				}
				else
				{
					MessageBox.Show("Field can not be blank","Error!");
					isValidUserName = false;

				}
			}
			catch(Exception ex)
			{
				ex.ToString();
			}
		}

		private void lbl_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			
		}

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			
			if (txtPwd.Text.ToString()==txConfirm.Text.ToString())
			{
				DataBaseAccess dbCon =new DataBaseAccess();
				SqlConnection Connection = new SqlConnection();
				string str="update login set username='"+txtUseId.Text.ToString()+"', password='"+txtPwd.Text.ToString()+"', userrole='"+LoginUser+"' where username='"+user+"'";
				SqlCommand com = new SqlCommand(str, dbCon.GetConnection());
				com.ExecuteNonQuery();
				MessageBox.Show("Username Password changed successfully");
				txtPwd.Visible=false;
				btnOK.Visible=false;
				btnLogin.Visible=true;
			}
			else
			{
				MessageBox.Show("Please Enter valid Password");
			}
			
		
		}

		private void radioBtnAdmin_CheckedChanged(object sender, System.EventArgs e)
		{
		
			RadioButton rb=(RadioButton)sender;
			if(rb.Checked)
			{
				LoginUser=rb.Text;
			}

		}

		private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			btnAddUser.Visible=true;
		

		}

		
		

	

	 
	}
}
