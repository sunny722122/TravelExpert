namespace Travelexpertwinform00
{
    partial class LoginFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsrID = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUserIdErr = new System.Windows.Forms.Label();
            this.btnAccNew = new System.Windows.Forms.Button();
            this.btnChangePwd = new System.Windows.Forms.Button();
            this.lblPwdErr = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserId";
            // 
            // txtUsrID
            // 
            this.txtUsrID.Location = new System.Drawing.Point(458, 81);
            this.txtUsrID.Name = "txtUsrID";
            this.txtUsrID.Size = new System.Drawing.Size(100, 20);
            this.txtUsrID.TabIndex = 1;
            this.txtUsrID.TextChanged += new System.EventHandler(this.TxtUsrID_TextChanged);
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(458, 127);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(100, 20);
            this.txtPwd.TabIndex = 3;
            this.txtPwd.TextChanged += new System.EventHandler(this.TxtPwd_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(404, 203);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // lblUserIdErr
            // 
            this.lblUserIdErr.AutoSize = true;
            this.lblUserIdErr.ForeColor = System.Drawing.Color.Red;
            this.lblUserIdErr.Location = new System.Drawing.Point(458, 108);
            this.lblUserIdErr.Name = "lblUserIdErr";
            this.lblUserIdErr.Size = new System.Drawing.Size(0, 13);
            this.lblUserIdErr.TabIndex = 5;
            // 
            // btnAccNew
            // 
            this.btnAccNew.Location = new System.Drawing.Point(509, 304);
            this.btnAccNew.Name = "btnAccNew";
            this.btnAccNew.Size = new System.Drawing.Size(149, 23);
            this.btnAccNew.TabIndex = 6;
            this.btnAccNew.Text = "Create Password Account";
            this.btnAccNew.UseVisualStyleBackColor = true;
            this.btnAccNew.Click += new System.EventHandler(this.BtnAccNew_Click);
            // 
            // btnChangePwd
            // 
            this.btnChangePwd.Location = new System.Drawing.Point(509, 203);
            this.btnChangePwd.Name = "btnChangePwd";
            this.btnChangePwd.Size = new System.Drawing.Size(149, 23);
            this.btnChangePwd.TabIndex = 7;
            this.btnChangePwd.Text = "Change Password";
            this.btnChangePwd.UseVisualStyleBackColor = true;
            // 
            // lblPwdErr
            // 
            this.lblPwdErr.AutoSize = true;
            this.lblPwdErr.ForeColor = System.Drawing.Color.Red;
            this.lblPwdErr.Location = new System.Drawing.Point(458, 154);
            this.lblPwdErr.Name = "lblPwdErr";
            this.lblPwdErr.Size = new System.Drawing.Size(0, 13);
            this.lblPwdErr.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Travelexpertwinform00.Properties.Resources.beachFull;
            this.pictureBox1.Location = new System.Drawing.Point(63, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // LoginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPwdErr);
            this.Controls.Add(this.btnChangePwd);
            this.Controls.Add(this.btnAccNew);
            this.Controls.Add(this.lblUserIdErr);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsrID);
            this.Controls.Add(this.label1);
            this.Name = "LoginFrm";
            this.Text = "LoginFrm";
            this.Activated += new System.EventHandler(this.LoginFrm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsrID;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUserIdErr;
        private System.Windows.Forms.Button btnAccNew;
        private System.Windows.Forms.Button btnChangePwd;
        private System.Windows.Forms.Label lblPwdErr;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}