namespace ConvenientStore
{
    partial class frm_ProductManagementDetail
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
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.ptbPicture = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.columnIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnExpiration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOrder
            // 
            this.btnOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOrder.Location = new System.Drawing.Point(236, 36);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(140, 40);
            this.btnOrder.TabIndex = 20;
            this.btnOrder.Text = "Đặt hàng";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.clickBtnOrder);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExportExcel.Location = new System.Drawing.Point(389, 36);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(140, 40);
            this.btnExportExcel.TabIndex = 19;
            this.btnExportExcel.Text = "Xuất Excel";
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.Click += new System.EventHandler(this.clickBtnExportExcell);
            // 
            // ptbPicture
            // 
            this.ptbPicture.Location = new System.Drawing.Point(25, 12);
            this.ptbPicture.Name = "ptbPicture";
            this.ptbPicture.Size = new System.Drawing.Size(167, 95);
            this.ptbPicture.TabIndex = 21;
            this.ptbPicture.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label10.Location = new System.Drawing.Point(22, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Mã sản phẩm";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductCode.Location = new System.Drawing.Point(51, 195);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.ReadOnly = true;
            this.txtProductCode.Size = new System.Drawing.Size(180, 22);
            this.txtProductCode.TabIndex = 23;
            this.txtProductCode.Text = "15520027";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(282, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tên sản phẩm";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(349, 195);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(180, 22);
            this.txtProductName.TabIndex = 25;
            this.txtProductName.Text = "15520027";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(389, 398);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 40);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Trở lại";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.clickBtnCancel);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnIndex,
            this.columnQuantity,
            this.columnPrice,
            this.columnUnit,
            this.columnExpiration});
            this.dataGridView1.Location = new System.Drawing.Point(3, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(529, 128);
            this.dataGridView1.TabIndex = 27;
            // 
            // columnIndex
            // 
            this.columnIndex.HeaderText = "STT";
            this.columnIndex.Name = "columnIndex";
            this.columnIndex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnIndex.Width = 50;
            // 
            // columnQuantity
            // 
            this.columnQuantity.HeaderText = "Số lượng";
            this.columnQuantity.Name = "columnQuantity";
            this.columnQuantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnQuantity.Width = 90;
            // 
            // columnPrice
            // 
            this.columnPrice.HeaderText = "Đơn giá";
            this.columnPrice.Name = "columnPrice";
            this.columnPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnPrice.Width = 90;
            // 
            // columnUnit
            // 
            this.columnUnit.HeaderText = "Đơn vị tính";
            this.columnUnit.Name = "columnUnit";
            this.columnUnit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // columnExpiration
            // 
            this.columnExpiration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnExpiration.HeaderText = "Ngày hết hạn";
            this.columnExpiration.Name = "columnExpiration";
            this.columnExpiration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(21, 131);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(115, 20);
            this.lbTitle.TabIndex = 28;
            this.lbTitle.Text = "Ngày hết hạn";
            // 
            // frm_ProductManagementDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 450);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.ptbPicture);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnExportExcel);
            this.Name = "frm_ProductManagementDetail";
            this.Text = "Thông tin chi tiết sản phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.ptbPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.PictureBox ptbPicture;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnExpiration;
        private System.Windows.Forms.Label lbTitle;
    }
}