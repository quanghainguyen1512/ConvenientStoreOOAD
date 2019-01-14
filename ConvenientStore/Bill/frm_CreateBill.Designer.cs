namespace ConvenientStore
{
    partial class frm_CreateBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CreateBill));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvListProduct = new System.Windows.Forms.DataGridView();
            this.columnIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSellDetail = new System.Windows.Forms.Button();
            this.cbbSellProgram = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBillCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.ptbImage = new System.Windows.Forms.PictureBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSell = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProduct)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbTotal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 480);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 70);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(313, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tổng tiền:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.Lime;
            this.lbTotal.Location = new System.Drawing.Point(437, 18);
            this.lbTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(121, 39);
            this.lbTotal.TabIndex = 3;
            this.lbTotal.Text = "20,000";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbTotal.Click += new System.EventHandler(this.lbTotal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(566, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "VNĐ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Image = global::ConvenientStore.Properties.Resources.close_white;
            this.btnCancel.Location = new System.Drawing.Point(691, -4);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 70);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "   Hủy ";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.clickBtnCancel);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Image = global::ConvenientStore.Properties.Resources.bill;
            this.button1.Location = new System.Drawing.Point(10, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "   Những hóa đơn đang chờ ...";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.clickBtnSubmit);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSubmit.Image = global::ConvenientStore.Properties.Resources.paycard;
            this.btnSubmit.Location = new System.Drawing.Point(821, 0);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(170, 70);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Thanh toán";
            this.btnSubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.clickBtnSubmit);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(10, 272);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "(*) Những thông tin bắt buộc nhập";
            // 
            // dgvListProduct
            // 
            this.dgvListProduct.AllowUserToOrderColumns = true;
            this.dgvListProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgvListProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnIndex,
            this.columnProductCode,
            this.columnProductName,
            this.columnQuantity,
            this.columnPrice,
            this.columnSell,
            this.columnUnit,
            this.columnTotal});
            this.dgvListProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListProduct.Location = new System.Drawing.Point(0, 0);
            this.dgvListProduct.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListProduct.MultiSelect = false;
            this.dgvListProduct.Name = "dgvListProduct";
            this.dgvListProduct.Size = new System.Drawing.Size(980, 180);
            this.dgvListProduct.TabIndex = 1;
            this.dgvListProduct.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.doubleClickRow);
            this.dgvListProduct.DoubleClick += new System.EventHandler(this.doubleClickRow);
            // 
            // columnIndex
            // 
            this.columnIndex.HeaderText = "STT";
            this.columnIndex.Name = "columnIndex";
            this.columnIndex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnIndex.Width = 50;
            // 
            // columnProductCode
            // 
            this.columnProductCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.columnProductCode.HeaderText = "Mã sản phẩm";
            this.columnProductCode.Name = "columnProductCode";
            this.columnProductCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnProductCode.Width = 150;
            // 
            // columnProductName
            // 
            this.columnProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnProductName.HeaderText = "Tên sản phẩm";
            this.columnProductName.Name = "columnProductName";
            this.columnProductName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // columnQuantity
            // 
            this.columnQuantity.HeaderText = "Số lượng";
            this.columnQuantity.Name = "columnQuantity";
            this.columnQuantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnQuantity.Width = 80;
            // 
            // columnPrice
            // 
            this.columnPrice.HeaderText = "Đơn giá";
            this.columnPrice.Name = "columnPrice";
            this.columnPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // columnSell
            // 
            this.columnSell.HeaderText = "Giảm giá (%)";
            this.columnSell.Name = "columnSell";
            this.columnSell.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnSell.Width = 90;
            // 
            // columnUnit
            // 
            this.columnUnit.HeaderText = "Đơn vị tính";
            this.columnUnit.Name = "columnUnit";
            this.columnUnit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnUnit.Width = 90;
            // 
            // columnTotal
            // 
            this.columnTotal.HeaderText = "Thành tiền";
            this.columnTotal.Name = "columnTotal";
            this.columnTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnTotal.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSellDetail);
            this.groupBox1.Controls.Add(this.cbbSellProgram);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtPhoneNumber);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtStaffName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtBillCode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(440, 240);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // btnSellDetail
            // 
            this.btnSellDetail.BackColor = System.Drawing.Color.White;
            this.btnSellDetail.FlatAppearance.BorderSize = 0;
            this.btnSellDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSellDetail.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.btnSellDetail.Image = global::ConvenientStore.Properties.Resources.pricetag_blue;
            this.btnSellDetail.Location = new System.Drawing.Point(246, 179);
            this.btnSellDetail.Margin = new System.Windows.Forms.Padding(4);
            this.btnSellDetail.Name = "btnSellDetail";
            this.btnSellDetail.Size = new System.Drawing.Size(150, 50);
            this.btnSellDetail.TabIndex = 12;
            this.btnSellDetail.Text = "   Thông tin khuyến mãi";
            this.btnSellDetail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSellDetail.UseVisualStyleBackColor = false;
            this.btnSellDetail.Click += new System.EventHandler(this.clickBtnSellDetail);
            // 
            // cbbSellProgram
            // 
            this.cbbSellProgram.FormattingEnabled = true;
            this.cbbSellProgram.Location = new System.Drawing.Point(246, 147);
            this.cbbSellProgram.Margin = new System.Windows.Forms.Padding(4);
            this.cbbSellProgram.Name = "cbbSellProgram";
            this.cbbSellProgram.Size = new System.Drawing.Size(150, 24);
            this.cbbSellProgram.TabIndex = 11;
            this.cbbSellProgram.ValueMemberChanged += new System.EventHandler(this.changeCbbSellProgram);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.label9.Location = new System.Drawing.Point(213, 121);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(199, 14);
            this.label9.TabIndex = 10;
            this.label9.Text = "Chương trình khuyến mãi (*)";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(246, 93);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(150, 26);
            this.txtCustomerName.TabIndex = 9;
            this.txtCustomerName.Text = "15520027";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.label8.Location = new System.Drawing.Point(213, 70);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 14);
            this.label8.TabIndex = 8;
            this.label8.Text = "Tên khách hàng";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(246, 41);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(150, 26);
            this.txtPhoneNumber.TabIndex = 7;
            this.txtPhoneNumber.Text = "15520027";
            this.txtPhoneNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterTxtPhoneNumber);
            this.txtPhoneNumber.Leave += new System.EventHandler(this.leaveTxtPhoneNumber);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.label7.Location = new System.Drawing.Point(213, 17);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 14);
            this.label7.TabIndex = 6;
            this.label7.Text = "Số điện thoại khách hàng (*)";
            // 
            // txtStaffName
            // 
            this.txtStaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffName.Location = new System.Drawing.Point(47, 145);
            this.txtStaffName.Margin = new System.Windows.Forms.Padding(4);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.ReadOnly = true;
            this.txtStaffName.Size = new System.Drawing.Size(150, 26);
            this.txtStaffName.TabIndex = 5;
            this.txtStaffName.Text = "15520027";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.label6.Location = new System.Drawing.Point(13, 121);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 14);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tên nhân viên";
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(47, 93);
            this.txtDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(150, 26);
            this.txtDate.TabIndex = 3;
            this.txtDate.Text = "15520027";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.label5.Location = new System.Drawing.Point(13, 70);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 14);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ngày bán";
            // 
            // txtBillCode
            // 
            this.txtBillCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillCode.Location = new System.Drawing.Point(47, 41);
            this.txtBillCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtBillCode.Name = "txtBillCode";
            this.txtBillCode.ReadOnly = true;
            this.txtBillCode.Size = new System.Drawing.Size(150, 26);
            this.txtBillCode.TabIndex = 1;
            this.txtBillCode.Text = "15520027";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.label2.Location = new System.Drawing.Point(13, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hóa đơn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.btnDeleteProduct);
            this.groupBox2.Controls.Add(this.btnAddProduct);
            this.groupBox2.Controls.Add(this.ptbImage);
            this.groupBox2.Controls.Add(this.txtQuantity);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtSell);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtProductName);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtProductCode);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(461, 27);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(526, 238);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sản phẩm";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(44, 197);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(150, 26);
            this.txtPrice.TabIndex = 24;
            this.txtPrice.Text = "15520027";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.label14.Location = new System.Drawing.Point(11, 174);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 14);
            this.label14.TabIndex = 23;
            this.label14.Text = "Đơn giá (VNĐ)";
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.White;
            this.btnDeleteProduct.FlatAppearance.BorderSize = 0;
            this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.btnDeleteProduct.Image = global::ConvenientStore.Properties.Resources.remove;
            this.btnDeleteProduct.Location = new System.Drawing.Point(202, 182);
            this.btnDeleteProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(150, 50);
            this.btnDeleteProduct.TabIndex = 22;
            this.btnDeleteProduct.Text = "  Xóa sản phẩm";
            this.btnDeleteProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.clickBtnDeleteProduct);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.White;
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.btnAddProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProduct.Image")));
            this.btnAddProduct.Location = new System.Drawing.Point(360, 182);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(150, 50);
            this.btnAddProduct.TabIndex = 13;
            this.btnAddProduct.Text = " Thêm sản phẩm";
            this.btnAddProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.clickBtnAddProduct);
            // 
            // ptbImage
            // 
            this.ptbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbImage.Location = new System.Drawing.Point(235, 74);
            this.ptbImage.Margin = new System.Windows.Forms.Padding(4);
            this.ptbImage.Name = "ptbImage";
            this.ptbImage.Size = new System.Drawing.Size(150, 100);
            this.ptbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImage.TabIndex = 21;
            this.ptbImage.TabStop = false;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(235, 40);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(150, 26);
            this.txtQuantity.TabIndex = 20;
            this.txtQuantity.Text = "15520027";
            this.txtQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterTxtQuantity);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.label13.Location = new System.Drawing.Point(202, 16);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 14);
            this.label13.TabIndex = 19;
            this.label13.Text = "Số lượng (*)";
            // 
            // txtSell
            // 
            this.txtSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSell.Location = new System.Drawing.Point(44, 146);
            this.txtSell.Margin = new System.Windows.Forms.Padding(4);
            this.txtSell.Name = "txtSell";
            this.txtSell.ReadOnly = true;
            this.txtSell.Size = new System.Drawing.Size(150, 26);
            this.txtSell.TabIndex = 18;
            this.txtSell.Text = "15520027";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.label12.Location = new System.Drawing.Point(11, 123);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 14);
            this.label12.TabIndex = 17;
            this.label12.Text = "Giảm giá (%)";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(44, 92);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(150, 26);
            this.txtProductName.TabIndex = 16;
            this.txtProductName.Text = "15520027";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.label11.Location = new System.Drawing.Point(11, 68);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 14);
            this.label11.TabIndex = 15;
            this.label11.Text = "Tên sản phẩm";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductCode.Location = new System.Drawing.Point(44, 40);
            this.txtProductCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(150, 26);
            this.txtProductCode.TabIndex = 14;
            this.txtProductCode.Text = "15520027";
            this.txtProductCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterTxtProductCode);
            this.txtProductCode.Leave += new System.EventHandler(this.leaveTxtProductCode);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.label10.Location = new System.Drawing.Point(11, 16);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 14);
            this.label10.TabIndex = 13;
            this.label10.Text = "Mã sản phẩm (*)";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 20);
            this.panel2.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 20);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 460);
            this.panel6.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 460);
            this.panel3.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(990, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 460);
            this.panel4.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvListProduct);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(10, 300);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(980, 180);
            this.panel5.TabIndex = 9;
            // 
            // frm_CreateBill
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_CreateBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LapHoaDonForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProduct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBillCode;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbSellProgram;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSellDetail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.PictureBox ptbImage;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSell;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSell;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTotal;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button1;
    }
}