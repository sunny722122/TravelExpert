namespace Travelexpertwinform00
{
    partial class PackageFrm
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
            System.Windows.Forms.Label packageIdLabel;
            System.Windows.Forms.Label pkgNameLabel;
            System.Windows.Forms.Label pkgStartDateLabel;
            System.Windows.Forms.Label pkgEndDateLabel;
            System.Windows.Forms.Label pkgDescLabel;
            System.Windows.Forms.Label pkgBasePriceLabel;
            System.Windows.Forms.Label pkgAgencyCommissionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PackageFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSupsErr = new System.Windows.Forms.Label();
            this.lblProdsErr = new System.Windows.Forms.Label();
            this.btnAddProdSup = new System.Windows.Forms.Button();
            this.cbSups = new System.Windows.Forms.ComboBox();
            this.cbProducts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSupErr = new System.Windows.Forms.Label();
            this.lblProductErr = new System.Windows.Forms.Label();
            this.lblPkgAgentComErr = new System.Windows.Forms.Label();
            this.lblPkgBasePriceErr = new System.Windows.Forms.Label();
            this.lblPkgEndDateErr = new System.Windows.Forms.Label();
            this.lblPkgstDateErr = new System.Windows.Forms.Label();
            this.lblPkgnameErr = new System.Windows.Forms.Label();
            this.btnDeductProdfromPkg = new System.Windows.Forms.Button();
            this.dgvPkgProd = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.packageIdTextBox = new System.Windows.Forms.TextBox();
            this.pkgNameTextBox = new System.Windows.Forms.TextBox();
            this.pkgStartDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pkgEndDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pkgDescTextBox = new System.Windows.Forms.TextBox();
            this.pkgBasePriceTextBox = new System.Windows.Forms.TextBox();
            this.pkgAgencyCommissionTextBox = new System.Windows.Forms.TextBox();
            this.lblPkg = new System.Windows.Forms.Label();
            this.PackagesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSave = new System.Windows.Forms.ToolStripButton();
            this.lblAddDelMsg = new System.Windows.Forms.Label();
            packageIdLabel = new System.Windows.Forms.Label();
            pkgNameLabel = new System.Windows.Forms.Label();
            pkgStartDateLabel = new System.Windows.Forms.Label();
            pkgEndDateLabel = new System.Windows.Forms.Label();
            pkgDescLabel = new System.Windows.Forms.Label();
            pkgBasePriceLabel = new System.Windows.Forms.Label();
            pkgAgencyCommissionLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPkgProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PackagesBindingNavigator)).BeginInit();
            this.PackagesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // packageIdLabel
            // 
            packageIdLabel.AutoSize = true;
            packageIdLabel.Location = new System.Drawing.Point(24, 108);
            packageIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            packageIdLabel.Name = "packageIdLabel";
            packageIdLabel.Size = new System.Drawing.Size(116, 25);
            packageIdLabel.TabIndex = 20;
            packageIdLabel.Text = "Package Id:";
            // 
            // pkgNameLabel
            // 
            pkgNameLabel.AutoSize = true;
            pkgNameLabel.Location = new System.Drawing.Point(24, 192);
            pkgNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pkgNameLabel.Name = "pkgNameLabel";
            pkgNameLabel.Size = new System.Drawing.Size(109, 25);
            pkgNameLabel.TabIndex = 22;
            pkgNameLabel.Text = "Pkg Name:";
            // 
            // pkgStartDateLabel
            // 
            pkgStartDateLabel.AutoSize = true;
            pkgStartDateLabel.Location = new System.Drawing.Point(24, 277);
            pkgStartDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pkgStartDateLabel.Name = "pkgStartDateLabel";
            pkgStartDateLabel.Size = new System.Drawing.Size(144, 25);
            pkgStartDateLabel.TabIndex = 24;
            pkgStartDateLabel.Text = "Pkg Start Date:";
            // 
            // pkgEndDateLabel
            // 
            pkgEndDateLabel.AutoSize = true;
            pkgEndDateLabel.Location = new System.Drawing.Point(24, 361);
            pkgEndDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pkgEndDateLabel.Name = "pkgEndDateLabel";
            pkgEndDateLabel.Size = new System.Drawing.Size(138, 25);
            pkgEndDateLabel.TabIndex = 26;
            pkgEndDateLabel.Text = "Pkg End Date:";
            // 
            // pkgDescLabel
            // 
            pkgDescLabel.AutoSize = true;
            pkgDescLabel.Location = new System.Drawing.Point(24, 446);
            pkgDescLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pkgDescLabel.Name = "pkgDescLabel";
            pkgDescLabel.Size = new System.Drawing.Size(102, 25);
            pkgDescLabel.TabIndex = 28;
            pkgDescLabel.Text = "Pkg Desc:";
            // 
            // pkgBasePriceLabel
            // 
            pkgBasePriceLabel.AutoSize = true;
            pkgBasePriceLabel.Location = new System.Drawing.Point(24, 529);
            pkgBasePriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pkgBasePriceLabel.Name = "pkgBasePriceLabel";
            pkgBasePriceLabel.Size = new System.Drawing.Size(151, 25);
            pkgBasePriceLabel.TabIndex = 30;
            pkgBasePriceLabel.Text = "Pkg Base Price:";
            // 
            // pkgAgencyCommissionLabel
            // 
            pkgAgencyCommissionLabel.AutoSize = true;
            pkgAgencyCommissionLabel.Location = new System.Drawing.Point(24, 614);
            pkgAgencyCommissionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pkgAgencyCommissionLabel.Name = "pkgAgencyCommissionLabel";
            pkgAgencyCommissionLabel.Size = new System.Drawing.Size(237, 25);
            pkgAgencyCommissionLabel.TabIndex = 32;
            pkgAgencyCommissionLabel.Text = "Pkg Agency Commission:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblAddDelMsg);
            this.panel1.Controls.Add(this.btnRet);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblSupsErr);
            this.panel1.Controls.Add(this.lblProdsErr);
            this.panel1.Controls.Add(this.btnAddProdSup);
            this.panel1.Controls.Add(this.cbSups);
            this.panel1.Controls.Add(this.cbProducts);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblSupErr);
            this.panel1.Controls.Add(this.lblProductErr);
            this.panel1.Controls.Add(this.lblPkgAgentComErr);
            this.panel1.Controls.Add(this.lblPkgBasePriceErr);
            this.panel1.Controls.Add(this.lblPkgEndDateErr);
            this.panel1.Controls.Add(this.lblPkgstDateErr);
            this.panel1.Controls.Add(this.lblPkgnameErr);
            this.panel1.Controls.Add(this.btnDeductProdfromPkg);
            this.panel1.Controls.Add(this.dgvPkgProd);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(packageIdLabel);
            this.panel1.Controls.Add(this.packageIdTextBox);
            this.panel1.Controls.Add(pkgNameLabel);
            this.panel1.Controls.Add(this.pkgNameTextBox);
            this.panel1.Controls.Add(pkgStartDateLabel);
            this.panel1.Controls.Add(this.pkgStartDateDateTimePicker);
            this.panel1.Controls.Add(pkgEndDateLabel);
            this.panel1.Controls.Add(this.pkgEndDateDateTimePicker);
            this.panel1.Controls.Add(pkgDescLabel);
            this.panel1.Controls.Add(this.pkgDescTextBox);
            this.panel1.Controls.Add(pkgBasePriceLabel);
            this.panel1.Controls.Add(this.pkgBasePriceTextBox);
            this.panel1.Controls.Add(pkgAgencyCommissionLabel);
            this.panel1.Controls.Add(this.pkgAgencyCommissionTextBox);
            this.panel1.Controls.Add(this.lblPkg);
            this.panel1.Location = new System.Drawing.Point(26, 183);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1480, 660);
            this.panel1.TabIndex = 0;
            // 
            // btnRet
            // 
            this.btnRet.Location = new System.Drawing.Point(1159, 603);
            this.btnRet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRet.Name = "btnRet";
            this.btnRet.Size = new System.Drawing.Size(112, 36);
            this.btnRet.TabIndex = 60;
            this.btnRet.Text = "Main";
            this.btnRet.UseVisualStyleBackColor = true;
            this.btnRet.Click += new System.EventHandler(this.BtnRet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(640, 446);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 25);
            this.label2.TabIndex = 59;
            this.label2.Text = "Press the arrow to select row";
            // 
            // lblSupsErr
            // 
            this.lblSupsErr.AutoSize = true;
            this.lblSupsErr.ForeColor = System.Drawing.Color.Red;
            this.lblSupsErr.Location = new System.Drawing.Point(1262, 73);
            this.lblSupsErr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupsErr.Name = "lblSupsErr";
            this.lblSupsErr.Size = new System.Drawing.Size(0, 25);
            this.lblSupsErr.TabIndex = 58;
            // 
            // lblProdsErr
            // 
            this.lblProdsErr.AutoSize = true;
            this.lblProdsErr.ForeColor = System.Drawing.Color.Red;
            this.lblProdsErr.Location = new System.Drawing.Point(1050, 73);
            this.lblProdsErr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProdsErr.Name = "lblProdsErr";
            this.lblProdsErr.Size = new System.Drawing.Size(0, 25);
            this.lblProdsErr.TabIndex = 57;
            // 
            // btnAddProdSup
            // 
            this.btnAddProdSup.Location = new System.Drawing.Point(963, 153);
            this.btnAddProdSup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddProdSup.Name = "btnAddProdSup";
            this.btnAddProdSup.Size = new System.Drawing.Size(58, 36);
            this.btnAddProdSup.TabIndex = 56;
            this.btnAddProdSup.Text = "<<";
            this.btnAddProdSup.UseVisualStyleBackColor = true;
            this.btnAddProdSup.Click += new System.EventHandler(this.BtnAddProdSup_Click);
            // 
            // cbSups
            // 
            this.cbSups.FormattingEnabled = true;
            this.cbSups.Location = new System.Drawing.Point(1262, 125);
            this.cbSups.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSups.Name = "cbSups";
            this.cbSups.Size = new System.Drawing.Size(180, 33);
            this.cbSups.TabIndex = 54;
            // 
            // cbProducts
            // 
            this.cbProducts.FormattingEnabled = true;
            this.cbProducts.Location = new System.Drawing.Point(1050, 125);
            this.cbProducts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbProducts.Name = "cbProducts";
            this.cbProducts.Size = new System.Drawing.Size(180, 33);
            this.cbProducts.TabIndex = 53;
            this.cbProducts.SelectedIndexChanged += new System.EventHandler(this.CbProducts_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1046, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 51;
            this.label1.Text = "Products";
            // 
            // lblSupErr
            // 
            this.lblSupErr.AutoSize = true;
            this.lblSupErr.ForeColor = System.Drawing.Color.Red;
            this.lblSupErr.Location = new System.Drawing.Point(1443, 73);
            this.lblSupErr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupErr.Name = "lblSupErr";
            this.lblSupErr.Size = new System.Drawing.Size(0, 25);
            this.lblSupErr.TabIndex = 50;
            // 
            // lblProductErr
            // 
            this.lblProductErr.AutoSize = true;
            this.lblProductErr.ForeColor = System.Drawing.Color.Red;
            this.lblProductErr.Location = new System.Drawing.Point(640, 73);
            this.lblProductErr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductErr.Name = "lblProductErr";
            this.lblProductErr.Size = new System.Drawing.Size(0, 25);
            this.lblProductErr.TabIndex = 49;
            // 
            // lblPkgAgentComErr
            // 
            this.lblPkgAgentComErr.AutoSize = true;
            this.lblPkgAgentComErr.ForeColor = System.Drawing.Color.Red;
            this.lblPkgAgentComErr.Location = new System.Drawing.Point(282, 578);
            this.lblPkgAgentComErr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPkgAgentComErr.Name = "lblPkgAgentComErr";
            this.lblPkgAgentComErr.Size = new System.Drawing.Size(0, 25);
            this.lblPkgAgentComErr.TabIndex = 48;
            // 
            // lblPkgBasePriceErr
            // 
            this.lblPkgBasePriceErr.AutoSize = true;
            this.lblPkgBasePriceErr.ForeColor = System.Drawing.Color.Red;
            this.lblPkgBasePriceErr.Location = new System.Drawing.Point(282, 492);
            this.lblPkgBasePriceErr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPkgBasePriceErr.Name = "lblPkgBasePriceErr";
            this.lblPkgBasePriceErr.Size = new System.Drawing.Size(0, 25);
            this.lblPkgBasePriceErr.TabIndex = 47;
            // 
            // lblPkgEndDateErr
            // 
            this.lblPkgEndDateErr.AutoSize = true;
            this.lblPkgEndDateErr.ForeColor = System.Drawing.Color.Red;
            this.lblPkgEndDateErr.Location = new System.Drawing.Point(282, 323);
            this.lblPkgEndDateErr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPkgEndDateErr.Name = "lblPkgEndDateErr";
            this.lblPkgEndDateErr.Size = new System.Drawing.Size(0, 25);
            this.lblPkgEndDateErr.TabIndex = 46;
            // 
            // lblPkgstDateErr
            // 
            this.lblPkgstDateErr.AutoSize = true;
            this.lblPkgstDateErr.ForeColor = System.Drawing.Color.Red;
            this.lblPkgstDateErr.Location = new System.Drawing.Point(282, 241);
            this.lblPkgstDateErr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPkgstDateErr.Name = "lblPkgstDateErr";
            this.lblPkgstDateErr.Size = new System.Drawing.Size(0, 25);
            this.lblPkgstDateErr.TabIndex = 45;
            // 
            // lblPkgnameErr
            // 
            this.lblPkgnameErr.AutoSize = true;
            this.lblPkgnameErr.ForeColor = System.Drawing.Color.Red;
            this.lblPkgnameErr.Location = new System.Drawing.Point(282, 153);
            this.lblPkgnameErr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPkgnameErr.Name = "lblPkgnameErr";
            this.lblPkgnameErr.Size = new System.Drawing.Size(0, 25);
            this.lblPkgnameErr.TabIndex = 44;
            // 
            // btnDeductProdfromPkg
            // 
            this.btnDeductProdfromPkg.Location = new System.Drawing.Point(963, 241);
            this.btnDeductProdfromPkg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeductProdfromPkg.Name = "btnDeductProdfromPkg";
            this.btnDeductProdfromPkg.Size = new System.Drawing.Size(58, 36);
            this.btnDeductProdfromPkg.TabIndex = 40;
            this.btnDeductProdfromPkg.Text = ">>";
            this.btnDeductProdfromPkg.UseVisualStyleBackColor = true;
            this.btnDeductProdfromPkg.Click += new System.EventHandler(this.BtnDeductProdfromPkg_Click);
            // 
            // dgvPkgProd
            // 
            this.dgvPkgProd.AllowUserToAddRows = false;
            this.dgvPkgProd.AllowUserToDeleteRows = false;
            this.dgvPkgProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPkgProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPkgProd.Location = new System.Drawing.Point(640, 108);
            this.dgvPkgProd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPkgProd.Name = "dgvPkgProd";
            this.dgvPkgProd.ReadOnly = true;
            this.dgvPkgProd.Size = new System.Drawing.Size(314, 308);
            this.dgvPkgProd.TabIndex = 38;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1257, 41);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 25);
            this.label13.TabIndex = 35;
            this.label13.Text = "Suppliers";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(636, 41);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(199, 25);
            this.label12.TabIndex = 34;
            this.label12.Text = "Product_Supplier Info";
            // 
            // packageIdTextBox
            // 
            this.packageIdTextBox.Location = new System.Drawing.Point(282, 108);
            this.packageIdTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.packageIdTextBox.Name = "packageIdTextBox";
            this.packageIdTextBox.ReadOnly = true;
            this.packageIdTextBox.Size = new System.Drawing.Size(298, 30);
            this.packageIdTextBox.TabIndex = 21;
            // 
            // pkgNameTextBox
            // 
            this.pkgNameTextBox.Location = new System.Drawing.Point(282, 192);
            this.pkgNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pkgNameTextBox.Name = "pkgNameTextBox";
            this.pkgNameTextBox.Size = new System.Drawing.Size(298, 30);
            this.pkgNameTextBox.TabIndex = 23;
            this.pkgNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PkgNameTextBox_KeyPress);
            // 
            // pkgStartDateDateTimePicker
            // 
            this.pkgStartDateDateTimePicker.Location = new System.Drawing.Point(282, 277);
            this.pkgStartDateDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pkgStartDateDateTimePicker.Name = "pkgStartDateDateTimePicker";
            this.pkgStartDateDateTimePicker.Size = new System.Drawing.Size(298, 30);
            this.pkgStartDateDateTimePicker.TabIndex = 25;
            this.pkgStartDateDateTimePicker.ValueChanged += new System.EventHandler(this.PkgStartDateDateTimePicker_ValueChanged);
            this.pkgStartDateDateTimePicker.Leave += new System.EventHandler(this.PkgStartDateDateTimePicker_Leave);
            // 
            // pkgEndDateDateTimePicker
            // 
            this.pkgEndDateDateTimePicker.Location = new System.Drawing.Point(282, 361);
            this.pkgEndDateDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pkgEndDateDateTimePicker.Name = "pkgEndDateDateTimePicker";
            this.pkgEndDateDateTimePicker.Size = new System.Drawing.Size(298, 30);
            this.pkgEndDateDateTimePicker.TabIndex = 27;
            this.pkgEndDateDateTimePicker.ValueChanged += new System.EventHandler(this.PkgEndDateDateTimePicker_ValueChanged);
            // 
            // pkgDescTextBox
            // 
            this.pkgDescTextBox.Location = new System.Drawing.Point(282, 446);
            this.pkgDescTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pkgDescTextBox.Name = "pkgDescTextBox";
            this.pkgDescTextBox.Size = new System.Drawing.Size(298, 30);
            this.pkgDescTextBox.TabIndex = 29;
            this.pkgDescTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PkgDescTextBox_KeyPress);
            // 
            // pkgBasePriceTextBox
            // 
            this.pkgBasePriceTextBox.Location = new System.Drawing.Point(282, 529);
            this.pkgBasePriceTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pkgBasePriceTextBox.Name = "pkgBasePriceTextBox";
            this.pkgBasePriceTextBox.Size = new System.Drawing.Size(298, 30);
            this.pkgBasePriceTextBox.TabIndex = 31;
            this.pkgBasePriceTextBox.TextChanged += new System.EventHandler(this.PkgBasePriceTextBox_TextChanged);
            this.pkgBasePriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PkgBasePriceTextBox_KeyPress);
            // 
            // pkgAgencyCommissionTextBox
            // 
            this.pkgAgencyCommissionTextBox.Location = new System.Drawing.Point(282, 614);
            this.pkgAgencyCommissionTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pkgAgencyCommissionTextBox.Name = "pkgAgencyCommissionTextBox";
            this.pkgAgencyCommissionTextBox.Size = new System.Drawing.Size(298, 30);
            this.pkgAgencyCommissionTextBox.TabIndex = 33;
            this.pkgAgencyCommissionTextBox.TextChanged += new System.EventHandler(this.PkgAgencyCommissionTextBox_TextChanged);
            this.pkgAgencyCommissionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PkgAgencyCommissionTextBox_KeyPress);
            // 
            // lblPkg
            // 
            this.lblPkg.AutoSize = true;
            this.lblPkg.Location = new System.Drawing.Point(27, 41);
            this.lblPkg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPkg.Name = "lblPkg";
            this.lblPkg.Size = new System.Drawing.Size(126, 25);
            this.lblPkg.TabIndex = 19;
            this.lblPkg.Text = "Package Info";
            // 
            // PackagesBindingNavigator
            // 
            this.PackagesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.PackagesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.PackagesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.PackagesBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PackagesBindingNavigator.ImageScalingSize = new System.Drawing.Size(100, 100);
            this.PackagesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.toolStripBtnSave});
            this.PackagesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.PackagesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.PackagesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.PackagesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.PackagesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.PackagesBindingNavigator.Name = "PackagesBindingNavigator";
            this.PackagesBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.PackagesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.PackagesBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.PackagesBindingNavigator.Size = new System.Drawing.Size(1534, 107);
            this.PackagesBindingNavigator.TabIndex = 1;
            this.PackagesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(71, 104);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 107);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(73, 39);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 107);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 107);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(104, 104);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.BindingNavigatorAddNewItem_Click_1);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(104, 104);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.BindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(104, 104);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.BindingNavigatorMoveFirstItem_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(104, 104);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.BindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(104, 104);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.BindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(104, 104);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.BindingNavigatorMoveLastItem_Click);
            // 
            // toolStripBtnSave
            // 
            this.toolStripBtnSave.AutoSize = false;
            this.toolStripBtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnSave.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.toolStripBtnSave.Image = global::Travelexpertwinform00.Properties.Resources.Save;
            this.toolStripBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSave.Name = "toolStripBtnSave";
            this.toolStripBtnSave.Size = new System.Drawing.Size(100, 80);
            this.toolStripBtnSave.Text = "Save";
            this.toolStripBtnSave.Click += new System.EventHandler(this.ToolStripBtnSave_Click);
            // 
            // lblAddDelMsg
            // 
            this.lblAddDelMsg.AutoSize = true;
            this.lblAddDelMsg.ForeColor = System.Drawing.Color.Red;
            this.lblAddDelMsg.Location = new System.Drawing.Point(1094, 292);
            this.lblAddDelMsg.Name = "lblAddDelMsg";
            this.lblAddDelMsg.Size = new System.Drawing.Size(0, 25);
            this.lblAddDelMsg.TabIndex = 61;
            // 
            // PackageFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1534, 863);
            this.Controls.Add(this.PackagesBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "PackageFrm";
            this.Text = "Packages";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPkgProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PackagesBindingNavigator)).EndInit();
            this.PackagesBindingNavigator.ResumeLayout(false);
            this.PackagesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox packageIdTextBox;
        private System.Windows.Forms.TextBox pkgNameTextBox;
        private System.Windows.Forms.DateTimePicker pkgStartDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker pkgEndDateDateTimePicker;
        private System.Windows.Forms.TextBox pkgDescTextBox;
        private System.Windows.Forms.TextBox pkgBasePriceTextBox;
        private System.Windows.Forms.TextBox pkgAgencyCommissionTextBox;
        private System.Windows.Forms.Label lblPkg;
        private System.Windows.Forms.Button btnDeductProdfromPkg;
        private System.Windows.Forms.DataGridView dgvPkgProd;
        private System.Windows.Forms.Label lblPkgnameErr;
        private System.Windows.Forms.Label lblPkgstDateErr;
        private System.Windows.Forms.Label lblPkgEndDateErr;
        private System.Windows.Forms.Label lblPkgBasePriceErr;
        private System.Windows.Forms.Label lblPkgAgentComErr;
        private System.Windows.Forms.Label lblProductErr;
        private System.Windows.Forms.Label lblSupErr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingNavigator PackagesBindingNavigator;
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
        private System.Windows.Forms.ComboBox cbSups;
        private System.Windows.Forms.ComboBox cbProducts;
        private System.Windows.Forms.Button btnAddProdSup;
        private System.Windows.Forms.Label lblSupsErr;
        private System.Windows.Forms.Label lblProdsErr;
        private System.Windows.Forms.ToolStripButton toolStripBtnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRet;
        private System.Windows.Forms.Label lblAddDelMsg;
    }
}

