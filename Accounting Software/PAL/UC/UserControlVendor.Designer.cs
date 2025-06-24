namespace Accounting_Software.PAL.UC
{
    partial class UserControlVendor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tcVendor = new System.Windows.Forms.TabControl();
            this.tpAddVendor = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpManageVendor = new System.Windows.Forms.TabPage();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.dgvVendors = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tpUpdateAndDeleteVendor = new System.Windows.Forms.TabPage();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhone1 = new System.Windows.Forms.TextBox();
            this.txtName1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.tcVendor.SuspendLayout();
            this.tpAddVendor.SuspendLayout();
            this.tpManageVendor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendors)).BeginInit();
            this.tpUpdateAndDeleteVendor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.Red;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(129, 343);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(145, 38);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddress.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtAddress.Location = new System.Drawing.Point(129, 216);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(689, 85);
            this.txtAddress.TabIndex = 3;
            this.txtAddress.UseSystemPasswordChar = true;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(126, 196);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 32);
            this.label13.TabIndex = 0;
            this.label13.Text = "Address:";
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhone.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtPhone.Location = new System.Drawing.Point(129, 160);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(343, 40);
            this.txtPhone.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtName.Location = new System.Drawing.Point(129, 104);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(689, 40);
            this.txtName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(126, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phone #:";
            // 
            // tcVendor
            // 
            this.tcVendor.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tcVendor.Controls.Add(this.tpAddVendor);
            this.tcVendor.Controls.Add(this.tpManageVendor);
            this.tcVendor.Controls.Add(this.tpUpdateAndDeleteVendor);
            this.tcVendor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcVendor.Location = new System.Drawing.Point(0, 0);
            this.tcVendor.Name = "tcVendor";
            this.tcVendor.SelectedIndex = 0;
            this.tcVendor.Size = new System.Drawing.Size(942, 601);
            this.tcVendor.TabIndex = 0;
            // 
            // tpAddVendor
            // 
            this.tpAddVendor.BackColor = System.Drawing.Color.Black;
            this.tpAddVendor.Controls.Add(this.btnAdd);
            this.tpAddVendor.Controls.Add(this.txtAddress);
            this.tpAddVendor.Controls.Add(this.label13);
            this.tpAddVendor.Controls.Add(this.txtPhone);
            this.tpAddVendor.Controls.Add(this.txtName);
            this.tpAddVendor.Controls.Add(this.label3);
            this.tpAddVendor.Controls.Add(this.label2);
            this.tpAddVendor.Controls.Add(this.label1);
            this.tpAddVendor.Location = new System.Drawing.Point(8, 8);
            this.tpAddVendor.Name = "tpAddVendor";
            this.tpAddVendor.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddVendor.Size = new System.Drawing.Size(926, 547);
            this.tpAddVendor.TabIndex = 0;
            this.tpAddVendor.Text = "Add Vendor";
            this.tpAddVendor.Enter += new System.EventHandler(this.tpAddVendor_Enter);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(126, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "../Add Vendor";
            // 
            // tpManageVendor
            // 
            this.tpManageVendor.BackColor = System.Drawing.Color.Black;
            this.tpManageVendor.Controls.Add(this.txtSearchName);
            this.tpManageVendor.Controls.Add(this.dgvVendors);
            this.tpManageVendor.Controls.Add(this.label8);
            this.tpManageVendor.Controls.Add(this.lblTotal);
            this.tpManageVendor.Controls.Add(this.label6);
            this.tpManageVendor.Controls.Add(this.label7);
            this.tpManageVendor.Controls.Add(this.picSearch);
            this.tpManageVendor.Location = new System.Drawing.Point(8, 8);
            this.tpManageVendor.Name = "tpManageVendor";
            this.tpManageVendor.Padding = new System.Windows.Forms.Padding(3);
            this.tpManageVendor.Size = new System.Drawing.Size(926, 547);
            this.tpManageVendor.TabIndex = 1;
            this.tpManageVendor.Text = "Manage Vendor";
            this.tpManageVendor.Click += new System.EventHandler(this.tpManageVendor_Click);
            this.tpManageVendor.Enter += new System.EventHandler(this.tpManageVendor_Enter);
            // 
            // txtSearchName
            // 
            this.txtSearchName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearchName.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtSearchName.Location = new System.Drawing.Point(261, 142);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(393, 40);
            this.txtSearchName.TabIndex = 1;
            this.txtSearchName.TextChanged += new System.EventHandler(this.txtSearchName_TextChanged);
            // 
            // dgvVendors
            // 
            this.dgvVendors.AllowUserToAddRows = false;
            this.dgvVendors.AllowUserToDeleteRows = false;
            this.dgvVendors.AllowUserToResizeColumns = false;
            this.dgvVendors.AllowUserToResizeRows = false;
            this.dgvVendors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVendors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVendors.BackgroundColor = System.Drawing.Color.White;
            this.dgvVendors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvVendors.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVendors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVendors.ColumnHeadersHeight = 45;
            this.dgvVendors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVendors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVendors.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVendors.EnableHeadersVisualStyles = false;
            this.dgvVendors.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvVendors.Location = new System.Drawing.Point(7, 209);
            this.dgvVendors.MultiSelect = false;
            this.dgvVendors.Name = "dgvVendors";
            this.dgvVendors.ReadOnly = true;
            this.dgvVendors.RowHeadersVisible = false;
            this.dgvVendors.RowHeadersWidth = 82;
            this.dgvVendors.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvVendors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVendors.ShowCellErrors = false;
            this.dgvVendors.ShowEditingIcon = false;
            this.dgvVendors.ShowRowErrors = false;
            this.dgvVendors.Size = new System.Drawing.Size(919, 313);
            this.dgvVendors.TabIndex = 0;
            this.dgvVendors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVendors_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Vendor_Id";
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Vendor_Name";
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Vendor_Phone";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column3.HeaderText = "Phone #";
            this.Column3.MinimumWidth = 10;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Vendor_Address";
            this.Column4.HeaderText = "Address";
            this.Column4.MinimumWidth = 10;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(266, 34);
            this.label8.TabIndex = 0;
            this.label8.Text = "../Manage Vendor";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.IndianRed;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotal.Location = new System.Drawing.Point(51, 525);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(39, 32);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "{?}";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.IndianRed;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(3, 525);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(257, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 31);
            this.label7.TabIndex = 0;
            this.label7.Text = "Name:";
            // 
            // tpUpdateAndDeleteVendor
            // 
            this.tpUpdateAndDeleteVendor.BackColor = System.Drawing.Color.Black;
            this.tpUpdateAndDeleteVendor.Controls.Add(this.txtAddress1);
            this.tpUpdateAndDeleteVendor.Controls.Add(this.label4);
            this.tpUpdateAndDeleteVendor.Controls.Add(this.txtPhone1);
            this.tpUpdateAndDeleteVendor.Controls.Add(this.txtName1);
            this.tpUpdateAndDeleteVendor.Controls.Add(this.label10);
            this.tpUpdateAndDeleteVendor.Controls.Add(this.label11);
            this.tpUpdateAndDeleteVendor.Controls.Add(this.label9);
            this.tpUpdateAndDeleteVendor.Controls.Add(this.btnDelete);
            this.tpUpdateAndDeleteVendor.Controls.Add(this.btnUpdate);
            this.tpUpdateAndDeleteVendor.Location = new System.Drawing.Point(8, 8);
            this.tpUpdateAndDeleteVendor.Name = "tpUpdateAndDeleteVendor";
            this.tpUpdateAndDeleteVendor.Padding = new System.Windows.Forms.Padding(3);
            this.tpUpdateAndDeleteVendor.Size = new System.Drawing.Size(926, 547);
            this.tpUpdateAndDeleteVendor.TabIndex = 2;
            this.tpUpdateAndDeleteVendor.Text = "Update and Delete Vendor";
            this.tpUpdateAndDeleteVendor.Enter += new System.EventHandler(this.tpEditAndDeleteVendor_Enter);
            this.tpUpdateAndDeleteVendor.Leave += new System.EventHandler(this.tpEditAndDeleteVendor_Leave);
            // 
            // txtAddress1
            // 
            this.txtAddress1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddress1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtAddress1.Location = new System.Drawing.Point(129, 232);
            this.txtAddress1.Multiline = true;
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(689, 85);
            this.txtAddress1.TabIndex = 3;
            this.txtAddress1.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(126, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Address:";
            // 
            // txtPhone1
            // 
            this.txtPhone1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhone1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtPhone1.Location = new System.Drawing.Point(129, 176);
            this.txtPhone1.Name = "txtPhone1";
            this.txtPhone1.Size = new System.Drawing.Size(343, 40);
            this.txtPhone1.TabIndex = 2;
            // 
            // txtName1
            // 
            this.txtName1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtName1.Location = new System.Drawing.Point(129, 120);
            this.txtName1.Name = "txtName1";
            this.txtName1.Size = new System.Drawing.Size(689, 40);
            this.txtName1.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(126, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 32);
            this.label10.TabIndex = 0;
            this.label10.Text = "Phone #:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(126, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 32);
            this.label11.TabIndex = 0;
            this.label11.Text = "Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(3, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(408, 34);
            this.label9.TabIndex = 0;
            this.label9.Text = "../Update and Delete Vendor";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(88)))), ((int)(((byte)(96)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(325, 359);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(145, 38);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.BackColor = System.Drawing.Color.Red;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(129, 359);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(145, 38);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // picSearch
            // 
            this.picSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.picSearch.Image = global::Accounting_Software.Properties.Resources.SearchBar;
            this.picSearch.Location = new System.Drawing.Point(653, 142);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(26, 24);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSearch.TabIndex = 17;
            this.picSearch.TabStop = false;
            this.picSearch.MouseHover += new System.EventHandler(this.picSearch_MouseHover);
            // 
            // UserControlVendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tcVendor);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlVendor";
            this.Size = new System.Drawing.Size(942, 601);
            this.tcVendor.ResumeLayout(false);
            this.tpAddVendor.ResumeLayout(false);
            this.tpAddVendor.PerformLayout();
            this.tpManageVendor.ResumeLayout(false);
            this.tpManageVendor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendors)).EndInit();
            this.tpUpdateAndDeleteVendor.ResumeLayout(false);
            this.tpUpdateAndDeleteVendor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tcVendor;
        private System.Windows.Forms.TabPage tpAddVendor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpManageVendor;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.DataGridView dgvVendors;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.TabPage tpUpdateAndDeleteVendor;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhone1;
        private System.Windows.Forms.TextBox txtName1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
