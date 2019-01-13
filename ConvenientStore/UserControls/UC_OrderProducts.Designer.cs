namespace ConvenientStore.UserControls
{
    partial class UC_OrderProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_OrderProducts));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboOrderReceiveDay = new System.Windows.Forms.ComboBox();
            this.cboOrderStatus = new System.Windows.Forms.ComboBox();
            this.cboOrderID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.dgOrders = new System.Windows.Forms.DataGridView();
            this.dgcol_STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcol_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcol_OrderDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcol_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboOrderReceiveDay);
            this.panel1.Controls.Add(this.cboOrderStatus);
            this.panel1.Controls.Add(this.cboOrderID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnAddOrder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 70);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(749, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngày giao";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(582, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tình trạng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(415, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã đơn đặt hàng";
            // 
            // cboOrderReceiveDay
            // 
            this.cboOrderReceiveDay.BackColor = System.Drawing.Color.White;
            this.cboOrderReceiveDay.FormattingEnabled = true;
            this.cboOrderReceiveDay.Location = new System.Drawing.Point(749, 23);
            this.cboOrderReceiveDay.Name = "cboOrderReceiveDay";
            this.cboOrderReceiveDay.Size = new System.Drawing.Size(150, 28);
            this.cboOrderReceiveDay.TabIndex = 6;
            // 
            // cboOrderStatus
            // 
            this.cboOrderStatus.BackColor = System.Drawing.Color.White;
            this.cboOrderStatus.FormattingEnabled = true;
            this.cboOrderStatus.Location = new System.Drawing.Point(582, 23);
            this.cboOrderStatus.Name = "cboOrderStatus";
            this.cboOrderStatus.Size = new System.Drawing.Size(150, 28);
            this.cboOrderStatus.TabIndex = 6;
            // 
            // cboOrderID
            // 
            this.cboOrderID.BackColor = System.Drawing.Color.White;
            this.cboOrderID.FormattingEnabled = true;
            this.cboOrderID.Location = new System.Drawing.Point(415, 23);
            this.cboOrderID.Name = "cboOrderID";
            this.cboOrderID.Size = new System.Drawing.Size(150, 28);
            this.cboOrderID.TabIndex = 6;
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
            // btnAddOrder
            // 
            this.btnAddOrder.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddOrder.FlatAppearance.BorderSize = 0;
            this.btnAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOrder.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrder.ForeColor = System.Drawing.Color.White;
            this.btnAddOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnAddOrder.Image")));
            this.btnAddOrder.Location = new System.Drawing.Point(0, 0);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(250, 70);
            this.btnAddOrder.TabIndex = 0;
            this.btnAddOrder.Text = "   Thêm đơn đặt hàng";
            this.btnAddOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.panel3.Controls.Add(this.btnExcel);
            this.panel3.Controls.Add(this.btnDeleteOrder);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 480);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1000, 70);
            this.panel3.TabIndex = 4;
            // 
            // btnExcel
            // 
            this.btnExcel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.ForeColor = System.Drawing.Color.White;
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.Location = new System.Drawing.Point(0, 0);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(180, 70);
            this.btnExcel.TabIndex = 3;
            this.btnExcel.Text = "   Xuất file Excel";
            this.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcel.UseVisualStyleBackColor = true;
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDeleteOrder.FlatAppearance.BorderSize = 0;
            this.btnDeleteOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteOrder.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteOrder.ForeColor = System.Drawing.Color.White;
            this.btnDeleteOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteOrder.Image")));
            this.btnDeleteOrder.Location = new System.Drawing.Point(820, 0);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(180, 70);
            this.btnDeleteOrder.TabIndex = 1;
            this.btnDeleteOrder.Text = " Xóa Khuyến Mãi";
            this.btnDeleteOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            // 
            // dgOrders
            // 
            this.dgOrders.AllowUserToAddRows = false;
            this.dgOrders.AllowUserToDeleteRows = false;
            this.dgOrders.BackgroundColor = System.Drawing.Color.White;
            this.dgOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcol_STT,
            this.dgcol_ID,
            this.dgcol_OrderDay,
            this.dgcol_Status});
            this.dgOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgOrders.Location = new System.Drawing.Point(0, 70);
            this.dgOrders.Name = "dgOrders";
            this.dgOrders.ReadOnly = true;
            this.dgOrders.RowTemplate.Height = 24;
            this.dgOrders.Size = new System.Drawing.Size(1000, 410);
            this.dgOrders.TabIndex = 5;
            // 
            // dgcol_STT
            // 
            this.dgcol_STT.HeaderText = "STT";
            this.dgcol_STT.Name = "dgcol_STT";
            this.dgcol_STT.ReadOnly = true;
            this.dgcol_STT.Width = 155;
            // 
            // dgcol_ID
            // 
            this.dgcol_ID.HeaderText = "MÃ";
            this.dgcol_ID.Name = "dgcol_ID";
            this.dgcol_ID.ReadOnly = true;
            this.dgcol_ID.Width = 200;
            // 
            // dgcol_OrderDay
            // 
            this.dgcol_OrderDay.HeaderText = "NGÀY ĐẶT";
            this.dgcol_OrderDay.Name = "dgcol_OrderDay";
            this.dgcol_OrderDay.ReadOnly = true;
            this.dgcol_OrderDay.Width = 250;
            // 
            // dgcol_Status
            // 
            this.dgcol_Status.HeaderText = "TÌNH TRẠNG";
            this.dgcol_Status.Name = "dgcol_Status";
            this.dgcol_Status.ReadOnly = true;
            this.dgcol_Status.Width = 350;
            // 
            // UC_OrderProducts
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgOrders);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_OrderProducts";
            this.Size = new System.Drawing.Size(1000, 550);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboOrderID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgOrders;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboOrderReceiveDay;
        private System.Windows.Forms.ComboBox cboOrderStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcol_STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcol_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcol_OrderDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcol_Status;
    }
}
