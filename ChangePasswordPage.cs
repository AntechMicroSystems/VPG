using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace HMIShopLink
{
	/// <summary>
	/// Summary description for ChangePasswordPage.
	/// </summary>
	public class ChangePasswordPage : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Label lblPwd;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblUserId;
		private System.Windows.Forms.TextBox txtCurrPwd;
		private System.Windows.Forms.TextBox txtConPwd;
		private System.Windows.Forms.TextBox txtNewPwd;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private DataBaseAccess DatabaseObj= null;
		private System.Windows.Forms.RadioButton radioBtnUser;
		private System.Windows.Forms.RadioButton radioBtnAdmin;
		private System.Windows.Forms.Label lblLoginAs; 
		private System.Windows.Forms.Panel PwdPanel;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.Label label2;

		string strloginType;
		
		public ChangePasswordPage()
		{
			InitializeComponent();
			if( DatabaseObj== null )
				DatabaseObj = new DataBaseAccess();
 
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
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.PwdPanel = new System.Windows.Forms.Panel();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.radioBtnUser = new System.Windows.Forms.RadioButton();
			this.radioBtnAdmin = new System.Windows.Forms.RadioButton();
			this.lblLoginAs = new System.Windows.Forms.Label();
			this.txtCurrPwd = new System.Windows.Forms.TextBox();
			this.lblUserId = new System.Windows.Forms.Label();
			this.txtConPwd = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblPwd = new System.Windows.Forms.Label();
			this.txtNewPwd = new System.Windows.Forms.TextBox();
			this.PwdPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnOk
			// 
			this.btnOk.BackColor = System.Drawing.Color.RoyalBlue;
			this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnOk.ForeColor = System.Drawing.Color.White;
			this.btnOk.Location = new System.Drawing.Point(128, 192);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(96, 32);
			this.btnOk.TabIndex = 13;
			this.btnOk.Tag = "3";
			this.btnOk.Text = "&Ok";
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.RoyalBlue;
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnCancel.ForeColor = System.Drawing.Color.White;
			this.btnCancel.Location = new System.Drawing.Point(232, 192);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(96, 32);
			this.btnCancel.TabIndex = 14;
			this.btnCancel.Tag = "4";
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// PwdPanel
			// 
			this.PwdPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PwdPanel.Controls.Add(this.txtUserName);
			this.PwdPanel.Controls.Add(this.label2);
			this.PwdPanel.Controls.Add(this.radioBtnUser);
			this.PwdPanel.Controls.Add(this.radioBtnAdmin);
			this.PwdPanel.Controls.Add(this.lblLoginAs);
			this.PwdPanel.Controls.Add(this.txtCurrPwd);
			this.PwdPanel.Controls.Add(this.lblUserId);
			this.PwdPanel.Controls.Add(this.txtConPwd);
			this.PwdPanel.Controls.Add(this.label1);
			this.PwdPanel.Controls.Add(this.lblPwd);
			this.PwdPanel.Controls.Add(this.txtNewPwd);
			this.PwdPanel.Controls.Add(this.btnOk);
			this.PwdPanel.Controls.Add(this.btnCancel);
			this.PwdPanel.Location = new System.Drawing.Point(8, 8);
			this.PwdPanel.Name = "PwdPanel";
			this.PwdPanel.Size = new System.Drawing.Size(416, 240);
			this.PwdPanel.TabIndex = 17;
			// 
			// txtUserName
			// 
			this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtUserName.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.txtUserName.Location = new System.Drawing.Point(160, 48);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(160, 22);
			this.txtUserName.TabIndex = 33;
			this.txtUserName.Tag = "0";
			this.txtUserName.Text = "";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(24, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 23);
			this.label2.TabIndex = 32;
			this.label2.Text = "User Name :";
			// 
			// radioBtnUser
			// 
			this.radioBtnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioBtnUser.ForeColor = System.Drawing.Color.Blue;
			this.radioBtnUser.Location = new System.Drawing.Point(232, 16);
			this.radioBtnUser.Name = "radioBtnUser";
			this.radioBtnUser.Size = new System.Drawing.Size(64, 24);
			this.radioBtnUser.TabIndex = 29;
			this.radioBtnUser.Tag = "0";
			this.radioBtnUser.Text = "user";
			this.radioBtnUser.Click += new System.EventHandler(this.radioBtnUser_Click);
			// 
			// radioBtnAdmin
			// 
			this.radioBtnAdmin.Checked = true;
			this.radioBtnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioBtnAdmin.ForeColor = System.Drawing.Color.Blue;
			this.radioBtnAdmin.Location = new System.Drawing.Point(160, 16);
			this.radioBtnAdmin.Name = "radioBtnAdmin";
			this.radioBtnAdmin.Size = new System.Drawing.Size(64, 24);
			this.radioBtnAdmin.TabIndex = 30;
			this.radioBtnAdmin.TabStop = true;
			this.radioBtnAdmin.Tag = "1";
			this.radioBtnAdmin.Text = "admin";
			this.radioBtnAdmin.Click += new System.EventHandler(this.radioBtnUser_Click);
			// 
			// lblLoginAs
			// 
			this.lblLoginAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblLoginAs.ForeColor = System.Drawing.Color.Blue;
			this.lblLoginAs.Location = new System.Drawing.Point(24, 16);
			this.lblLoginAs.Name = "lblLoginAs";
			this.lblLoginAs.Size = new System.Drawing.Size(136, 23);
			this.lblLoginAs.TabIndex = 31;
			this.lblLoginAs.Text = "Change Password:";
			// 
			// txtCurrPwd
			// 
			this.txtCurrPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtCurrPwd.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.txtCurrPwd.Location = new System.Drawing.Point(160, 80);
			this.txtCurrPwd.Name = "txtCurrPwd";
			this.txtCurrPwd.PasswordChar = '*';
			this.txtCurrPwd.Size = new System.Drawing.Size(160, 22);
			this.txtCurrPwd.TabIndex = 28;
			this.txtCurrPwd.Tag = "0";
			this.txtCurrPwd.Text = "";
			// 
			// lblUserId
			// 
			this.lblUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblUserId.ForeColor = System.Drawing.Color.Blue;
			this.lblUserId.Location = new System.Drawing.Point(24, 80);
			this.lblUserId.Name = "lblUserId";
			this.lblUserId.Size = new System.Drawing.Size(120, 23);
			this.lblUserId.TabIndex = 27;
			this.lblUserId.Text = "Current Password:";
			// 
			// txtConPwd
			// 
			this.txtConPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtConPwd.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.txtConPwd.Location = new System.Drawing.Point(160, 144);
			this.txtConPwd.Name = "txtConPwd";
			this.txtConPwd.PasswordChar = '*';
			this.txtConPwd.Size = new System.Drawing.Size(160, 22);
			this.txtConPwd.TabIndex = 26;
			this.txtConPwd.Tag = "2";
			this.txtConPwd.Text = "";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(24, 144);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 23);
			this.label1.TabIndex = 25;
			this.label1.Text = "Confirm Password :";
			// 
			// lblPwd
			// 
			this.lblPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblPwd.ForeColor = System.Drawing.Color.Blue;
			this.lblPwd.Location = new System.Drawing.Point(24, 112);
			this.lblPwd.Name = "lblPwd";
			this.lblPwd.Size = new System.Drawing.Size(104, 23);
			this.lblPwd.TabIndex = 23;
			this.lblPwd.Text = "New Password :";
			// 
			// txtNewPwd
			// 
			this.txtNewPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtNewPwd.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.txtNewPwd.Location = new System.Drawing.Point(160, 112);
			this.txtNewPwd.Name = "txtNewPwd";
			this.txtNewPwd.PasswordChar = '*';
			this.txtNewPwd.Size = new System.Drawing.Size(160, 22);
			this.txtNewPwd.TabIndex = 24;
			this.txtNewPwd.Tag = "1";
			this.txtNewPwd.Text = "";
			// 
			// ChangePasswordPage
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(432, 254);
			this.Controls.Add(this.PwdPanel);
			this.Name = "ChangePasswordPage";
			this.Text = "ChangePasswordPage";
			this.PwdPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			DialogResult=DialogResult.Cancel;
		}

		private void btnOk_Click(object sender, System.EventArgs e)
		{
 
			//if(LoginForm.LoginUser=="admin")
			{
				
				string strEncript = LoginForm.EncriptPWD(txtCurrPwd.Text);
				bool valid=DatabaseObj.IsValidUser(txtUserName.Text,strEncript,strloginType);
				if(valid)
				{
					if(txtNewPwd.Text==txtConPwd.Text)
					{
						strEncript = LoginForm.EncriptPWD(txtNewPwd.Text);
						DatabaseObj.ChangePassword(txtUserName.Text,strEncript);
						MessageBox.Show("Password Changed Successfully");
						ClearAll();
					}
					else
					{
						MessageBox.Show("password mismatch!");
					}
				}
				else
				{
					MessageBox.Show("Please Enter correct password!");
				}
			}
			//else
			{
				// 	PwdPanel.Visible=false;
				// 	MessageBox.Show("Sorry you don’t have sufficient privilege to change the password","Warning");
			}
 	
			//this.Close();	

		}

		private void radioBtnUser_Click(object sender, System.EventArgs e)
		{
			RadioButton rb=(RadioButton)sender;
			if(rb.Checked)
			{
				strloginType=rb.Text;
				
 
			}
		}
		private void ClearAll()
		{
			txtUserName.Clear();
			txtCurrPwd.Clear();
			txtNewPwd.Clear();
			txtConPwd.Clear();
		}
		
	}
}
