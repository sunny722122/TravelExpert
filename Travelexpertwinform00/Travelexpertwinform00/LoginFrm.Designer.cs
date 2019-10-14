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
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(802, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserId";
            // 
            // txtUsrID
            // 
            this.txtUsrID.Location = new System.Drawing.Point(916, 107);
            this.txtUsrID.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtUsrID.Name = "txtUsrID";
            this.txtUsrID.Size = new System.Drawing.Size(196, 32);
            this.txtUsrID.TabIndex = 1;
            this.txtUsrID.TextChanged += new System.EventHandler(this.TxtUsrID_TextChanged);
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(916, 195);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(196, 32);
            this.txtPwd.TabIndex = 3;
            this.txtPwd.TextChanged += new System.EventHandler(this.TxtPwd_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(802, 211);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(808, 341);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 44);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // lblUserIdErr
            // 
            this.lblUserIdErr.AutoSize = true;
            this.lblUserIdErr.ForeColor = System.Drawing.Color.Red;
            this.lblUserIdErr.Location = new System.Drawing.Point(916, 159);
            this.lblUserIdErr.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUserIdErr.Name = "lblUserIdErr";
            this.lblUserIdErr.Size = new System.Drawing.Size(0, 26);
            this.lblUserIdErr.TabIndex = 5;
            // 
            // btnAccNew
            // 
            this.btnAccNew.Location = new System.Drawing.Point(1018, 455);
            this.btnAccNew.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAccNew.Name = "btnAccNew";
            this.btnAccNew.Size = new System.Drawing.Size(298, 44);
            this.btnAccNew.TabIndex = 6;
            this.btnAccNew.Text = "Create Password Account";
            this.btnAccNew.UseVisualStyleBackColor = true;
            this.btnAccNew.Click += new System.EventHandler(this.BtnAccNew_Click);
            // 
            // btnChangePwd
            // 
            this.btnChangePwd.Location = new System.Drawing.Point(1018, 341);
            this.btnChangePwd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnChangePwd.Name = "btnChangePwd";
            this.btnChangePwd.Size = new System.Drawing.Size(298, 44);
            this.btnChangePwd.TabIndex = 7;
            this.btnChangePwd.Text = "Change Password";
            this.btnChangePwd.UseVisualStyleBackColor = true;
            this.btnChangePwd.Click += new System.EventHandler(this.BtnChangePwd_Click);
            // 
            // lblPwdErr
            // 
            this.lblPwdErr.AutoSize = true;
            this.lblPwdErr.ForeColor = System.Drawing.Color.Red;
            this.lblPwdErr.Location = new System.Drawing.Point(916, 247);
            this.lblPwdErr.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPwdErr.Name = "lblPwdErr";
            this.lblPwdErr.Size = new System.Drawing.Size(0, 26);
            this.lblPwdErr.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Travelexpertwinform00.Properties.Resources.beachFull;
            this.pictureBox1.Location = new System.Drawing.Point(126, 88);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(560, 421);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Harlow Solid Italic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(291, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(821, 51);
            this.label3.TabIndex = 10;
            this.label3.Text = "Travel Expert Agent Products Management Tool";
            // 
            // LoginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 548);
            this.Controls.Add(this.label3);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
        private System.Windows.Forms.Label label3;
    }
}