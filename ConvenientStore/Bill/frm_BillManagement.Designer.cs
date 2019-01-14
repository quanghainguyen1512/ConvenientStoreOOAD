namespace ConvenientStore
{
    partial class frm_BillManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BillManagement));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBillCode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.dgvListBills = new System.Windows.Forms.DataGridView();
            this.columnIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnBillCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbTotal = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbCreateDate = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBills)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.label1.Location = new System.Drawing.Point(501, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mã hóa đơn";
            // 
            // txtBillCode
            // 
            this.txtBillCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillCode.Location = new System.Drawing.Point(628, 36);
            this.txtBillCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtBillCode.Name = "txtBillCode";
            this.txtBillCode.Size = new System.Drawing.Size(219, 26);
            this.txtBillCode.TabIndex = 18;
            this.txtBillCode.Text = "15520027";
            this.txtBillCode.TextChanged += new System.EventHandler(this.txtBillCode_TextChanged);
            this.txtBillCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBillCode_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.label10.Location = new System.Drawing.Point(8, 36);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Tên khách hàng";
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportExcel.FlatAppearance.BorderSize = 0;
            this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportExcel.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExportExcel.Image = global::ConvenientStore.Properties.Resources.excel;
            this.btnExportExcel.Location = new System.Drawing.Point(364, 0);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(250, 70);
            this.btnExportExcel.TabIndex = 23;
            this.btnExportExcel.Text = "   Xuất Excel";
            this.btnExportExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportExcel.UseVisualStyleBackColor = false;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(175, 34);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(219, 26);
            this.txtCustomerName.TabIndex = 16;
            this.txtCustomerName.Text = "15520027";
            this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            this.txtCustomerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustomerName_KeyDown);
            // 
            // dgvListBills
            // 
            this.dgvListBills.BackgroundColor = System.Drawing.Color.White;
            this.dgvListBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListBills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnIndex,
            this.columnBillCode,
            this.columnCustomerName,
            this.columnCreateDate,
            this.columnTotal});
            this.dgvListBills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListBills.Location = new System.Drawing.Point(0, 0);
            this.dgvListBills.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListBills.MultiSelect = false;
            this.dgvListBills.Name = "dgvListBills";
            this.dgvListBills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListBills.Size = new System.Drawing.Size(980, 226);
            this.dgvListBills.TabIndex = 24;
            this.dgvListBills.DoubleClick += new System.EventHandler(this.dgvListBills_DoubleClick);
            // 
            // columnIndex
            // 
            this.columnIndex.Frozen = true;
            this.columnIndex.HeaderText = "STT";
            this.columnIndex.Name = "columnIndex";
            this.columnIndex.ReadOnly = true;
            this.columnIndex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnIndex.Width = 50;
            // 
            // columnBillCode
            // 
            this.columnBillCode.HeaderText = "Mã hóa đơn";
            this.columnBillCode.Name = "columnBillCode";
            this.columnBillCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // columnCustomerName
            // 
            this.columnCustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnCustomerName.HeaderText = "Khách hàng";
            this.columnCustomerName.Name = "columnCustomerName";
            this.columnCustomerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // columnCreateDate
            // 
            this.columnCreateDate.HeaderText = "Ngày tạo";
            this.columnCreateDate.Name = "columnCreateDate";
            this.columnCreateDate.ReadOnly = true;
            this.columnCreateDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnCreateDate.Width = 150;
            // 
            // columnTotal
            // 
            this.columnTotal.HeaderText = "Thành tiền (VNĐ)";
            this.columnTotal.Name = "columnTotal";
            this.columnTotal.ReadOnly = true;
            this.columnTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnTotal.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBillCode);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 69);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(950, 80);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.label4.Location = new System.Drawing.Point(8, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Sắp xếp (theo giá trị hóa đơn)";
            // 
            // cbbTotal
            // 
            this.cbbTotal.FormattingEnabled = true;
            this.cbbTotal.Location = new System.Drawing.Point(313, 37);
            this.cbbTotal.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTotal.Name = "cbbTotal";
            this.cbbTotal.Size = new System.Drawing.Size(180, 24);
            this.cbbTotal.TabIndex = 26;
            this.cbbTotal.SelectedIndexChanged += new System.EventHandler(this.cbbTotal_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.label5.Location = new System.Drawing.Point(501, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Sắp xếp (theo ngày tạo)";
            // 
            // cbbCreateDate
            // 
            this.cbbCreateDate.FormattingEnabled = true;
            this.cbbCreateDate.Location = new System.Drawing.Point(743, 37);
            this.cbbCreateDate.Margin = new System.Windows.Forms.Padding(4);
            this.cbbCreateDate.Name = "cbbCreateDate";
            this.cbbCreateDate.Size = new System.Drawing.Size(199, 24);
            this.cbbCreateDate.TabIndex = 28;
            this.cbbCreateDate.SelectedIndexChanged += new System.EventHandler(this.cbbCreateDate_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbbCreateDate);
            this.groupBox2.Controls.Add(this.cbbTotal);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(17, 157);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(950, 80);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sắp xếp";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 20);
            this.panel1.TabIndex = 30;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 20);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 530);
            this.panel6.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(990, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 530);
            this.panel2.TabIndex = 32;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.panel5.Controls.Add(this.btnExportExcel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(10, 480);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(980, 70);
            this.panel5.TabIndex = 33;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvListBills);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(10, 254);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(980, 226);
            this.panel3.TabIndex = 34;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(954, 26);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 35;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frm_BillManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_BillManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý hóa đơn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_BillManagement_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBills)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBillCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.DataGridView dgvListBills;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnBillCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbCreateDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClose;
    }
}