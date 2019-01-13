namespace ConvenientStore.UserControls
{
    partial class UC_SaleDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_SaleDetails));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboSearch = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPageLeft = new System.Windows.Forms.Button();
            this.pnlPage = new System.Windows.Forms.Panel();
            this.lblPage = new System.Windows.Forms.Label();
            this.btnPageRight = new System.Windows.Forms.Button();
            this.btnAddSale = new System.Windows.Forms.Button();
            this.dgSaleDetails = new System.Windows.Forms.DataGridView();
            this.dgcol_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcol_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcol_Val = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcol_StartDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcol_EndDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcol_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEditSale = new System.Windows.Forms.Button();
            this.btnDeleteSale = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnlPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSaleDetails)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.panel1.Controls.Add(this.cboSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnPageLeft);
            this.panel1.Controls.Add(this.pnlPage);
            this.panel1.Controls.Add(this.btnPageRight);
            this.panel1.Controls.Add(this.btnAddSale);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 70);
            this.panel1.TabIndex = 0;
            // 
            // cboSearch
            // 
            this.cboSearch.BackColor = System.Drawing.Color.White;
            this.cboSearch.FormattingEnabled = true;
            this.cboSearch.Location = new System.Drawing.Point(377, 23);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Size = new System.Drawing.Size(138, 24);
            this.cboSearch.TabIndex = 6;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(517, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 22);
            this.txtSearch.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(290, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tìm kiếm:";
            // 
            // btnPageLeft
            // 
            this.btnPageLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPageLeft.FlatAppearance.BorderSize = 0;
            this.btnPageLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPageLeft.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPageLeft.ForeColor = System.Drawing.Color.White;
            this.btnPageLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnPageLeft.Image")));
            this.btnPageLeft.Location = new System.Drawing.Point(800, 0);
            this.btnPageLeft.Name = "btnPageLeft";
            this.btnPageLeft.Size = new System.Drawing.Size(50, 70);
            this.btnPageLeft.TabIndex = 3;
            this.btnPageLeft.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPageLeft.UseVisualStyleBackColor = true;
            // 
            // pnlPage
            // 
            this.pnlPage.Controls.Add(this.lblPage);
            this.pnlPage.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlPage.Location = new System.Drawing.Point(850, 0);
            this.pnlPage.Name = "pnlPage";
            this.pnlPage.Size = new System.Drawing.Size(100, 70);
            this.pnlPage.TabIndex = 2;
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage.ForeColor = System.Drawing.Color.White;
            this.lblPage.Location = new System.Drawing.Point(1, 27);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(93, 17);
            this.lblPage.TabIndex = 0;
            this.lblPage.Text = "Trang #/#";
            // 
            // btnPageRight
            // 
            this.btnPageRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPageRight.FlatAppearance.BorderSize = 0;
            this.btnPageRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPageRight.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPageRight.ForeColor = System.Drawing.Color.White;
            this.btnPageRight.Image = ((System.Drawing.Image)(resources.GetObject("btnPageRight.Image")));
            this.btnPageRight.Location = new System.Drawing.Point(950, 0);
            this.btnPageRight.Name = "btnPageRight";
            this.btnPageRight.Size = new System.Drawing.Size(50, 70);
            this.btnPageRight.TabIndex = 1;
            this.btnPageRight.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPageRight.UseVisualStyleBackColor = true;
            // 
            // btnAddSale
            // 
            this.btnAddSale.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddSale.FlatAppearance.BorderSize = 0;
            this.btnAddSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSale.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSale.ForeColor = System.Drawing.Color.White;
            this.btnAddSale.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSale.Image")));
            this.btnAddSale.Location = new System.Drawing.Point(0, 0);
            this.btnAddSale.Name = "btnAddSale";
            this.btnAddSale.Size = new System.Drawing.Size(250, 70);
            this.btnAddSale.TabIndex = 0;
            this.btnAddSale.Text = " Thêm Mới Khuyến Mãi";
            this.btnAddSale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddSale.UseVisualStyleBackColor = true;
            this.btnAddSale.Click += new System.EventHandler(this.btnAddSale_Click);
            // 
            // dgSaleDetails
            // 
            this.dgSaleDetails.AllowUserToAddRows = false;
            this.dgSaleDetails.AllowUserToDeleteRows = false;
            this.dgSaleDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgSaleDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSaleDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcol_Name,
            this.dgcol_ID,
            this.dgcol_Val,
            this.dgcol_StartDay,
            this.dgcol_EndDay,
            this.dgcol_Description});
            this.dgSaleDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSaleDetails.Location = new System.Drawing.Point(0, 0);
            this.dgSaleDetails.Name = "dgSaleDetails";
            this.dgSaleDetails.ReadOnly = true;
            this.dgSaleDetails.RowTemplate.Height = 24;
            this.dgSaleDetails.Size = new System.Drawing.Size(1000, 410);
            this.dgSaleDetails.TabIndex = 2;
            // 
            // dgcol_Name
            // 
            this.dgcol_Name.HeaderText = "TÊN";
            this.dgcol_Name.Name = "dgcol_Name";
            this.dgcol_Name.ReadOnly = true;
            this.dgcol_Name.Width = 155;
            // 
            // dgcol_ID
            // 
            this.dgcol_ID.HeaderText = "MÃ";
            this.dgcol_ID.Name = "dgcol_ID";
            this.dgcol_ID.ReadOnly = true;
            // 
            // dgcol_Val
            // 
            this.dgcol_Val.HeaderText = "GIÁ TRỊ";
            this.dgcol_Val.Name = "dgcol_Val";
            this.dgcol_Val.ReadOnly = true;
            // 
            // dgcol_StartDay
            // 
            this.dgcol_StartDay.HeaderText = "NGÀY BẮT ĐẦU";
            this.dgcol_StartDay.Name = "dgcol_StartDay";
            this.dgcol_StartDay.ReadOnly = true;
            this.dgcol_StartDay.Width = 150;
            // 
            // dgcol_EndDay
            // 
            this.dgcol_EndDay.HeaderText = "NGÀY KẾT THÚC";
            this.dgcol_EndDay.Name = "dgcol_EndDay";
            this.dgcol_EndDay.ReadOnly = true;
            this.dgcol_EndDay.Width = 150;
            // 
            // dgcol_Description
            // 
            this.dgcol_Description.HeaderText = "MÔ TẢ";
            this.dgcol_Description.Name = "dgcol_Description";
            this.dgcol_Description.ReadOnly = true;
            this.dgcol_Description.Width = 300;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btnEditSale);
            this.panel3.Controls.Add(this.btnDeleteSale);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 480);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1000, 70);
            this.panel3.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(460, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 70);
            this.button1.TabIndex = 3;
            this.button1.Text = "Điều kiện áp dụng";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnEditSale
            // 
            this.btnEditSale.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEditSale.FlatAppearance.BorderSize = 0;
            this.btnEditSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSale.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSale.ForeColor = System.Drawing.Color.White;
            this.btnEditSale.Image = ((System.Drawing.Image)(resources.GetObject("btnEditSale.Image")));
            this.btnEditSale.Location = new System.Drawing.Point(640, 0);
            this.btnEditSale.Name = "btnEditSale";
            this.btnEditSale.Size = new System.Drawing.Size(180, 70);
            this.btnEditSale.TabIndex = 2;
            this.btnEditSale.Text = " Sửa Khuyến Mãi";
            this.btnEditSale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditSale.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSale
            // 
            this.btnDeleteSale.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDeleteSale.FlatAppearance.BorderSize = 0;
            this.btnDeleteSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSale.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSale.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSale.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteSale.Image")));
            this.btnDeleteSale.Location = new System.Drawing.Point(820, 0);
            this.btnDeleteSale.Name = "btnDeleteSale";
            this.btnDeleteSale.Size = new System.Drawing.Size(180, 70);
            this.btnDeleteSale.TabIndex = 1;
            this.btnDeleteSale.Text = " Xóa Khuyến Mãi";
            this.btnDeleteSale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteSale.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgSaleDetails);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 70);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1000, 410);
            this.panel4.TabIndex = 4;
            // 
            // UC_SaleDetails
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "UC_SaleDetails";
            this.Size = new System.Drawing.Size(1000, 550);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlPage.ResumeLayout(false);
            this.pnlPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSaleDetails)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddSale;
        private System.Windows.Forms.ComboBox cboSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPageLeft;
        private System.Windows.Forms.Panel pnlPage;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Button btnPageRight;
        private System.Windows.Forms.DataGridView dgSaleDetails;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEditSale;
        private System.Windows.Forms.Button btnDeleteSale;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcol_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcol_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcol_Val;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcol_StartDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcol_EndDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcol_Description;
        private System.Windows.Forms.Button button1;
    }
}
