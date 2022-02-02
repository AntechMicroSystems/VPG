using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace HMIShopLink 
{
	/// <summary>
	/// Summary description for AddUserPage.
	/// </summary>
	public class ForgotPasswordPage : System.Windows.Forms.Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RadioButton radioBtnUser;
		private System.Windows.Forms.RadioButton radioBtnAdmin;
		private System.Windows.Forms.Label lblLoginAs;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Label lblPwd;
		private System.Windows.Forms.TextBox txtusername;
		private System.Windows.Forms.Button btnOk;
		DataBaseAccess databaseObj = null;
		string _pwdType,_userName;
		private System.Windows.Forms.Button btnClose;
	
		public ForgotPasswordPage(string pwdType,string userName)
		{
			_pwdType = pwdType;
			_userName = userName;
			InitializeComponent();
			if(databaseObj==null)
				databaseObj = new DataBaseAccess();
		
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel2 = new System.Windows.Forms.Panel();
			this.lblPwd = new System.Windows.Forms.Label();
			this.btnOk = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtusername = new System.Windows.Forms.TextBox();
			this.radioBtnUser = new System.Windows.Forms.RadioButton();
			this.radioBtnAdmin = new System.Windows.Forms.RadioButton();
			this.lblLoginAs = new System.Windows.Forms.Label();
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.lblPwd);
			this.panel2.Controls.Add(this.btnOk);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.txtusername);
			this.panel2.Controls.Add(this.radioBtnUser);
			this.panel2.Controls.Add(this.radioBtnAdmin);
			this.panel2.Controls.Add(this.lblLoginAs);
			this.panel2.Controls.Add(this.btnLogin);
			this.panel2.Controls.Add(this.btnClose);
			this.panel2.Location = new System.Drawing.Point(8, 8);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(424, 184);
			this.panel2.TabIndex = 3;
			// 
			// lblPwd
			// 
			this.lblPwd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblPwd.ForeColor = System.Drawing.Color.Red;
			this.lblPwd.Location = new System.Drawing.Point(157, 96);
			this.lblPwd.Name = "lblPwd";
			this.lblPwd.Size = new System.Drawing.Size(240, 22);
			this.lblPwd.TabIndex = 11;
			// 
			// btnOk
			// 
			this.btnOk.BackColor = System.Drawing.Color.RoyalBlue;
			this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnOk.ForeColor = System.Drawing.Color.White;
			this.btnOk.Location = new System.Drawing.Point(205, 144);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(96, 32);
			this.btnOk.TabIndex = 10;
			this.btnOk.Tag = "4";
			this.btnOk.Text = "&OK";
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(37, 65);
			this.label2.Name = "label2";
			this.label2.TabIndex = 1;
			this.label2.Text = "User Name :";
			// 
			// txtusername
			// 
			this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtusername.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.txtusername.Location = new System.Drawing.Point(157, 62);
			this.txtusername.Name = "txtusername";
			this.txtusername.Size = new System.Drawing.Size(240, 22);
			this.txtusername.TabIndex = 3;
			this.txtusername.Tag = "2";
			this.txtusername.Text = "";
			// 
			// radioBtnUser
			// 
			this.radioBtnUser.Checked = true;
			this.radioBtnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioBtnUser.ForeColor = System.Drawing.Color.Blue;
			this.radioBtnUser.Location = new System.Drawing.Point(157, 17);
			this.radioBtnUser.Name = "radioBtnUser";
			this.radioBtnUser.TabIndex = 4;
			this.radioBtnUser.TabStop = true;
			this.radioBtnUser.Tag = "0";
			this.radioBtnUser.Text = "admin";
			this.radioBtnUser.Click += new System.EventHandler(this.radioBtnUser_Click);
			// 
			// radioBtnAdmin
			// 
			this.radioBtnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioBtnAdmin.ForeColor = System.Drawing.Color.Blue;
			this.radioBtnAdmin.Location = new System.Drawing.Point(285, 17);
			this.radioBtnAdmin.Name = "radioBtnAdmin";
			this.radioBtnAdmin.TabIndex = 5;
			this.radioBtnAdmin.Tag = "1";
			this.radioBtnAdmin.Text = "user";
			this.radioBtnAdmin.Click += new System.EventHandler(this.radioBtnUser_Click);
			// 
			// lblLoginAs
			// 
			this.lblLoginAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblLoginAs.ForeColor = System.Drawing.Color.Blue;
			this.lblLoginAs.Location = new System.Drawing.Point(37, 17);
			this.lblLoginAs.Name = "lblLoginAs";
			this.lblLoginAs.TabIndex = 6;
			this.lblLoginAs.Text = "Password Type";
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.Color.RoyalBlue;
			this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnLogin.ForeColor = System.Drawing.Color.White;
			this.btnLogin.Location = new System.Drawing.Point(205, 144);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(96, 32);
			this.btnLogin.TabIndex = 7;
			this.btnLogin.Text = "&Login";
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.RoyalBlue;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnClose.ForeColor = System.Drawing.Color.White;
			this.btnClose.Location = new System.Drawing.Point(309, 144);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(96, 32);
			this.btnClose.TabIndex = 8;
			this.btnClose.Text = "&Close";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// ForgotPasswordPage
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(440, 198);
			this.Controls.Add(this.panel2);
			this.Name = "ForgotPasswordPage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Forgot Password";
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion


		private void btnOk_Click(object sender, System.EventArgs e)
		{
			try
			{
			   string pwd = databaseObj.GetPassword(_pwdType,_userName);
			   if(pwd != string.Empty)
			   pwd = LoginForm.DecriptPWD(pwd);
			   lblPwd.Text = "Password is " + pwd;
//				if(txtUseId.TextLength>0 && txtPwd.TextLength>0)
//				{
//					object[] param = {txtUseId.Text,txtPwd.Text,LoginForm.LoginUser};
//					databaseObj.RunStoredProcedure("Usp_InsertLogin",param);
//				}
//				else
//				{
//					MessageBox.Show("Field can not be blank");
//				}
			}
			catch(Exception ex)
			{
				ex.ToString();
			}
			// if(IsValidEMailAddress(txtUseId.Text))
			// {
			// 	MessageBox.Show(txtUseId.Text ,"valid email add");
			// }
			// else
			// {
			// 	MessageBox.Show(txtUseId.Text ,"Invalid email add");
			// }
		}

		private void radioBtnUser_Click(object sender, System.EventArgs e)
		{
			RadioButton rb=(RadioButton)sender;
			if(rb.Checked)
			{
				_pwdType=rb.Text;
			}
		}

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		
		//		private bool IsValidEMailAddress(string emailAddress)
		//		{
		// return Regex.IsMatch(emailAddress, "^([\\w-]+\\.)*?[\\w-]+@[\\w-]+\\.([\\w-]+\\.)*?[\\w]+$");
		//		}

	}
}
