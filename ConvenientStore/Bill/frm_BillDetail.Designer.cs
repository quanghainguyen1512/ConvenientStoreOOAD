namespace ConvenientStore
{
    partial class frm_BillDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BillDetail));
            this.dgvListBillDetails = new System.Windows.Forms.DataGridView();
            this.columnIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnProduceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBillCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCreateDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBillDetails)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListBillDetails
            // 
            this.dgvListBillDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvListBillDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListBillDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnIndex,
            this.columnProductCode,
            this.columnProduceName,
            this.columnPrice,
            this.columnQuantity,
            this.columnUnit,
            this.columnSale,
            this.columnTotal});
            this.dgvListBillDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListBillDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvListBillDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvListBillDetails.MultiSelect = false;
            this.dgvListBillDetails.Name = "dgvListBillDetails";
            this.dgvListBillDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListBillDetails.Size = new System.Drawing.Size(980, 300);
            this.dgvListBillDetails.TabIndex = 25;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExportExcel.Location = new System.Drawing.Point(790, 29);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(194, 40);
            this.btnExportExcel.TabIndex = 26;
            this.btnExportExcel.Text = "Xuất Excel";
            this.btnExportExcel.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(790, 75);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(194, 40);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Trở về";
            this.btnCancel.UseVisualStyleBackColor = false;
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
            // columnProductCode
            // 
            this.columnProductCode.HeaderText = "Mã sản phẩm";
            this.columnProductCode.Name = "columnProductCode";
            // 
            // columnProduceName
            // 
            this.columnProduceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnProduceName.HeaderText = "Tên sản phẩm";
            this.columnProduceName.Name = "columnProduceName";
            this.columnProduceName.ReadOnly = true;
            this.columnProduceName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // columnPrice
            // 
            this.columnPrice.HeaderText = "Đơn giá (VNĐ)";
            this.columnPrice.Name = "columnPrice";
            this.columnPrice.ReadOnly = true;
            this.columnPrice.Width = 150;
            // 
            // columnUnit
            // 
            this.columnUnit.HeaderText = "Đơn vị tính";
            this.columnUnit.Name = "columnUnit";
            this.columnUnit.ReadOnly = true;
            this.columnUnit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // columnSale
            // 
            this.columnSale.HeaderText = "Giảm giá (%)";
            this.columnSale.Name = "columnSale";
            this.columnSale.ReadOnly = true;
            this.columnSale.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // columnTotal
            // 
            this.columnTotal.HeaderText = "Thành tiền (VNĐ)";
            this.columnTotal.Name = "columnTotal";
            this.columnTotal.ReadOnly = true;
            this.columnTotal.Width = 150;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportExcel.FlatAppearance.BorderSize = 0;
            this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportExcel.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportExcel.Image")));
            this.btnExportExcel.Location = new System.Drawing.Point(0, 0);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(275, 70);
            this.btnExportExcel.TabIndex = 26;
            this.btnExportExcel.Text = "   Xuất Excel";
            this.btnExportExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportExcel.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(953, 13);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(30, 30);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.label10.Location = new System.Drawing.Point(70, 45);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 20);
            this.label10.TabIndex = 28;
            this.label10.Text = "Mã hóa đơn";
            // 
            // txtBillCode
            // 
            this.txtBillCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillCode.Location = new System.Drawing.Point(238, 43);
            this.txtBillCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBillCode.Name = "txtBillCode";
            this.txtBillCode.Size = new System.Drawing.Size(219, 26);
            this.txtBillCode.TabIndex = 29;
            this.txtBillCode.Text = "15520027";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.label1.Location = new System.Drawing.Point(70, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Tên khách hàng";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(238, 99);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(219, 26);
            this.txtCustomerName.TabIndex = 31;
            this.txtCustomerName.Text = "15520027";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.label2.Location = new System.Drawing.Point(491, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Ngày tạo";
            // 
            // txtCreateDate
            // 
            this.txtCreateDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreateDate.Location = new System.Drawing.Point(456, 31);
            this.txtCreateDate.Name = "txtCreateDate";
            this.txtCreateDate.Size = new System.Drawing.Size(165, 22);
            this.txtCreateDate.TabIndex = 33;
            this.txtCreateDate.Text = "15520027";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.label3.Location = new System.Drawing.Point(491, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Tổng cộng:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbTotal.Location = new System.Drawing.Point(734, 89);
            this.lbTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbTotal.Size = new System.Drawing.Size(114, 36);
            this.lbTotal.TabIndex = 35;
            this.lbTotal.Text = "20,000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.label5.Location = new System.Drawing.Point(862, 102);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "VNĐ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 10);
            this.panel1.TabIndex = 37;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.panel2.Controls.Add(this.btnExportExcel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 480);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 70);
            this.panel2.TabIndex = 38;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 10);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 470);
            this.panel6.TabIndex = 39;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 470);
            this.panel3.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(990, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 470);
            this.panel4.TabIndex = 40;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvListBillDetails);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(10, 180);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(980, 300);
            this.panel5.TabIndex = 41;
            // 
            // frm_BillDetail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCreateDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBillCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_BillDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin hóa đơn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_BillDetail_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBillDetails)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListBillDetails;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBillCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCreateDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnProduceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}