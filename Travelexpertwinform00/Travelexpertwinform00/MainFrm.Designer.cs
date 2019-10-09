namespace Travelexpertwinform00
{
    partial class MainFrm
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
            this.btnPackage = new System.Windows.Forms.Button();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnProdSup = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnSup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPackage
            // 
            this.btnPackage.Location = new System.Drawing.Point(55, 69);
            this.btnPackage.Name = "btnPackage";
            this.btnPackage.Size = new System.Drawing.Size(153, 23);
            this.btnPackage.TabIndex = 0;
            this.btnPackage.Text = "Packages";
            this.btnPackage.UseVisualStyleBackColor = true;
            this.btnPackage.Click += new System.EventHandler(this.BtnPackage_Click);
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.ForeColor = System.Drawing.Color.Blue;
            this.lblGreeting.Location = new System.Drawing.Point(12, 23);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(0, 26);
            this.lblGreeting.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(320, 33);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // btnProdSup
            // 
            this.btnProdSup.Location = new System.Drawing.Point(55, 115);
            this.btnProdSup.Name = "btnProdSup";
            this.btnProdSup.Size = new System.Drawing.Size(153, 23);
            this.btnProdSup.TabIndex = 3;
            this.btnProdSup.Text = "Product Supplier";
            this.btnProdSup.UseVisualStyleBackColor = true;
            this.btnProdSup.Click += new System.EventHandler(this.BtnProdSup_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(55, 163);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(153, 23);
            this.btnProducts.TabIndex = 4;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.BtnProducts_Click);
            // 
            // btnSup
            // 
            this.btnSup.Location = new System.Drawing.Point(55, 215);
            this.btnSup.Name = "btnSup";
            this.btnSup.Size = new System.Drawing.Size(153, 23);
            this.btnSup.TabIndex = 5;
            this.btnSup.Text = "Suppliers";
            this.btnSup.UseVisualStyleBackColor = true;
            this.btnSup.Click += new System.EventHandler(this.BtnSup_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSup);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnProdSup);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.btnPackage);
            this.Name = "MainFrm";
            this.Text = "MainFrm";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPackage;
        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnProdSup;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnSup;
    }
}