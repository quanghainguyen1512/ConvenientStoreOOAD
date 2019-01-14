namespace ConvenientStore
{
    partial class StatisticGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtmChooseFromDay = new System.Windows.Forms.DateTimePicker();
            this.cboChooseProduct = new System.Windows.Forms.ComboBox();
            this.gvStatistic = new System.Windows.Forms.DataGridView();
            this.grpChooseDay = new System.Windows.Forms.GroupBox();
            this.dtmChooseToDay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpChooseProduct = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvStatistic)).BeginInit();
            this.grpChooseDay.SuspendLayout();
            this.grpChooseProduct.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(364, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "THỐNG KÊ DOANH THU";
            // 
            // dtmChooseFromDay
            // 
            this.dtmChooseFromDay.CustomFormat = "dd/MM/yyyy";
            this.dtmChooseFromDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmChooseFromDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmChooseFromDay.Location = new System.Drawing.Point(92, 31);
            this.dtmChooseFromDay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtmChooseFromDay.Name = "dtmChooseFromDay";
            this.dtmChooseFromDay.Size = new System.Drawing.Size(200, 27);
            this.dtmChooseFromDay.TabIndex = 2;
            // 
            // cboChooseProduct
            // 
            this.cboChooseProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChooseProduct.FormattingEnabled = true;
            this.cboChooseProduct.Location = new System.Drawing.Point(15, 33);
            this.cboChooseProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboChooseProduct.Name = "cboChooseProduct";
            this.cboChooseProduct.Size = new System.Drawing.Size(200, 28);
            this.cboChooseProduct.TabIndex = 3;
            this.cboChooseProduct.Text = "Chọn sản phẩm";
            // 
            // gvStatistic
            // 
            this.gvStatistic.BackgroundColor = System.Drawing.Color.White;
            this.gvStatistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStatistic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvStatistic.GridColor = System.Drawing.Color.DarkGray;
            this.gvStatistic.Location = new System.Drawing.Point(0, 0);
            this.gvStatistic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gvStatistic.Name = "gvStatistic";
            this.gvStatistic.RowTemplate.Height = 33;
            this.gvStatistic.Size = new System.Drawing.Size(980, 316);
            this.gvStatistic.TabIndex = 4;
            // 
            // grpChooseDay
            // 
            this.grpChooseDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.grpChooseDay.Controls.Add(this.dtmChooseToDay);
            this.grpChooseDay.Controls.Add(this.label3);
            this.grpChooseDay.Controls.Add(this.label2);
            this.grpChooseDay.Controls.Add(this.dtmChooseFromDay);
            this.grpChooseDay.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChooseDay.ForeColor = System.Drawing.Color.White;
            this.grpChooseDay.Location = new System.Drawing.Point(24, 74);
            this.grpChooseDay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpChooseDay.Name = "grpChooseDay";
            this.grpChooseDay.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpChooseDay.Size = new System.Drawing.Size(552, 80);
            this.grpChooseDay.TabIndex = 6;
            this.grpChooseDay.TabStop = false;
            this.grpChooseDay.Text = "Chọn ngày";
            // 
            // dtmChooseToDay
            // 
            this.dtmChooseToDay.CustomFormat = "dd/MM/yyyy";
            this.dtmChooseToDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmChooseToDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmChooseToDay.Location = new System.Drawing.Point(344, 33);
            this.dtmChooseToDay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtmChooseToDay.Name = "dtmChooseToDay";
            this.dtmChooseToDay.Size = new System.Drawing.Size(200, 27);
            this.dtmChooseToDay.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(296, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "đến";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Từ ngày";
            // 
            // grpChooseProduct
            // 
            this.grpChooseProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.grpChooseProduct.Controls.Add(this.cboChooseProduct);
            this.grpChooseProduct.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChooseProduct.ForeColor = System.Drawing.Color.White;
            this.grpChooseProduct.Location = new System.Drawing.Point(585, 74);
            this.grpChooseProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpChooseProduct.Name = "grpChooseProduct";
            this.grpChooseProduct.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpChooseProduct.Size = new System.Drawing.Size(228, 80);
            this.grpChooseProduct.TabIndex = 7;
            this.grpChooseProduct.TabStop = false;
            this.grpChooseProduct.Text = "Chọn sản phẩm";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 50);
            this.panel1.TabIndex = 39;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 500);
            this.panel3.TabIndex = 40;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(990, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 500);
            this.panel2.TabIndex = 41;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.panel4.Controls.Add(this.btnExportExcel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(10, 480);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(980, 70);
            this.panel4.TabIndex = 42;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.gvStatistic);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(10, 164);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(980, 316);
            this.panel5.TabIndex = 43;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.btnReset.Image = global::ConvenientStore.Properties.Resources.remove;
            this.btnReset.Location = new System.Drawing.Point(815, 74);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(170, 78);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "  Đặt lại";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = false;
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
            this.btnExportExcel.Image = global::ConvenientStore.Properties.Resources.excel;
            this.btnExportExcel.Location = new System.Drawing.Point(353, 0);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(275, 70);
            this.btnExportExcel.TabIndex = 27;
            this.btnExportExcel.Text = "   Xuất Excel";
            this.btnExportExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportExcel.UseVisualStyleBackColor = false;
            // 
            // StatisticGUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpChooseProduct);
            this.Controls.Add(this.grpChooseDay);
            this.Controls.Add(this.btnReset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StatisticGUI";
            this.Text = "THỐNG KÊ DOANH THU";
            ((System.ComponentModel.ISupportInitialize)(this.gvStatistic)).EndInit();
            this.grpChooseDay.ResumeLayout(false);
            this.grpChooseDay.PerformLayout();
            this.grpChooseProduct.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtmChooseFromDay;
        private System.Windows.Forms.ComboBox cboChooseProduct;
        private System.Windows.Forms.DataGridView gvStatistic;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox grpChooseDay;
        private System.Windows.Forms.DateTimePicker dtmChooseToDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpChooseProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnExportExcel;
    }
}