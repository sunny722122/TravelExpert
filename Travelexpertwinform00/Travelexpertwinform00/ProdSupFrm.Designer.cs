namespace Travelexpertwinform00
{
    partial class ProdSupFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProdSupFrm));
            this.dgvProdSup = new System.Windows.Forms.DataGridView();
            this.btnMain = new System.Windows.Forms.Button();
            this.cbProducts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSuppliers = new System.Windows.Forms.ComboBox();
            this.bindingNavigatorPS = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProdSupID = new System.Windows.Forms.TextBox();
            this.lblProdErr = new System.Windows.Forms.Label();
            this.lblSupErr = new System.Windows.Forms.Label();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdSup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorPS)).BeginInit();
            this.bindingNavigatorPS.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProdSup
            // 
            this.dgvProdSup.AllowUserToAddRows = false;
            this.dgvProdSup.AllowUserToDeleteRows = false;
            this.dgvProdSup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdSup.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProdSup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdSup.Location = new System.Drawing.Point(24, 87);
            this.dgvProdSup.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvProdSup.Name = "dgvProdSup";
            this.dgvProdSup.ReadOnly = true;
            this.dgvProdSup.Size = new System.Drawing.Size(1063, 758);
            this.dgvProdSup.TabIndex = 1;
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(1222, 727);
            this.btnMain.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(150, 44);
            this.btnMain.TabIndex = 2;
            this.btnMain.Text = "Main";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.BtnMain_Click);
            // 
            // cbProducts
            // 
            this.cbProducts.FormattingEnabled = true;
            this.cbProducts.Location = new System.Drawing.Point(1134, 327);
            this.cbProducts.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbProducts.Name = "cbProducts";
            this.cbProducts.Size = new System.Drawing.Size(238, 33);
            this.cbProducts.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1146, 262);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Products";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1148, 477);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Suppliers";
            // 
            // cbSuppliers
            // 
            this.cbSuppliers.FormattingEnabled = true;
            this.cbSuppliers.Location = new System.Drawing.Point(1136, 542);
            this.cbSuppliers.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbSuppliers.Name = "cbSuppliers";
            this.cbSuppliers.Size = new System.Drawing.Size(238, 33);
            this.cbSuppliers.TabIndex = 5;
            // 
            // bindingNavigatorPS
            // 
            this.bindingNavigatorPS.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorPS.AutoSize = false;
            this.bindingNavigatorPS.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorPS.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigatorPS.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.bindingNavigatorPS.ImageScalingSize = new System.Drawing.Size(100, 100);
            this.bindingNavigatorPS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripButton1});
            this.bindingNavigatorPS.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorPS.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorPS.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorPS.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorPS.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorPS.Name = "bindingNavigatorPS";
            this.bindingNavigatorPS.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.bindingNavigatorPS.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorPS.Size = new System.Drawing.Size(1600, 80);
            this.bindingNavigatorPS.TabIndex = 8;
            this.bindingNavigatorPS.Text = "bindingNavigator1";
            this.bindingNavigatorPS.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.BindingNavigatorPS_ItemClicked);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(71, 77);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 80);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(96, 39);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 80);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 80);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1129, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Product Supplier ID";
            // 
            // txtProdSupID
            // 
            this.txtProdSupID.Location = new System.Drawing.Point(1125, 154);
            this.txtProdSupID.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtProdSupID.Name = "txtProdSupID";
            this.txtProdSupID.ReadOnly = true;
            this.txtProdSupID.Size = new System.Drawing.Size(196, 32);
            this.txtProdSupID.TabIndex = 10;
            // 
            // lblProdErr
            // 
            this.lblProdErr.AutoSize = true;
            this.lblProdErr.ForeColor = System.Drawing.Color.Red;
            this.lblProdErr.Location = new System.Drawing.Point(1134, 388);
            this.lblProdErr.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProdErr.Name = "lblProdErr";
            this.lblProdErr.Size = new System.Drawing.Size(0, 26);
            this.lblProdErr.TabIndex = 11;
            // 
            // lblSupErr
            // 
            this.lblSupErr.AutoSize = true;
            this.lblSupErr.ForeColor = System.Drawing.Color.Red;
            this.lblSupErr.Location = new System.Drawing.Point(1140, 615);
            this.lblSupErr.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSupErr.Name = "lblSupErr";
            this.lblSupErr.Size = new System.Drawing.Size(0, 26);
            this.lblSupErr.TabIndex = 12;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(104, 77);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.BindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(104, 77);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.BindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(104, 77);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.BindingNavigatorMoveFirstItem_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(104, 77);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.BindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(104, 77);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.BindingNavigatorMoveFirstItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(104, 77);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.BindingNavigatorMoveLastItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Travelexpertwinform00.Properties.Resources.Save;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(104, 77);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // ProdSupFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 919);
            this.Controls.Add(this.lblSupErr);
            this.Controls.Add(this.lblProdErr);
            this.Controls.Add(this.txtProdSupID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bindingNavigatorPS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSuppliers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbProducts);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.dgvProdSup);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ProdSupFrm";
            this.Text = "ProdSupFrm";
            this.Load += new System.EventHandler(this.ProdSupFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdSup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorPS)).EndInit();
            this.bindingNavigatorPS.ResumeLayout(false);
            this.bindingNavigatorPS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvProdSup;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.ComboBox cbProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSuppliers;
        private System.Windows.Forms.BindingNavigator bindingNavigatorPS;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProdSupID;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label lblProdErr;
        private System.Windows.Forms.Label lblSupErr;
    }
}