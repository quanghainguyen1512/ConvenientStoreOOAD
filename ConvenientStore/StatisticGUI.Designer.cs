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
            this.btnReset = new System.Windows.Forms.Button();
            this.grpChooseDay = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtmChooseToDay = new System.Windows.Forms.DateTimePicker();
            this.grpChooseProduct = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvStatistic)).BeginInit();
            this.grpChooseDay.SuspendLayout();
            this.grpChooseProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(316, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "THỐNG KÊ DOANH THU";
            // 
            // dtmChooseFromDay
            // 
            this.dtmChooseFromDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmChooseFromDay.Location = new System.Drawing.Point(120, 33);
            this.dtmChooseFromDay.Name = "dtmChooseFromDay";
            this.dtmChooseFromDay.Size = new System.Drawing.Size(200, 31);
            this.dtmChooseFromDay.TabIndex = 2;
            // 
            // cboChooseProduct
            // 
            this.cboChooseProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChooseProduct.FormattingEnabled = true;
            this.cboChooseProduct.Location = new System.Drawing.Point(26, 33);
            this.cboChooseProduct.Name = "cboChooseProduct";
            this.cboChooseProduct.Size = new System.Drawing.Size(200, 33);
            this.cboChooseProduct.TabIndex = 3;
            this.cboChooseProduct.Text = "Chọn sản phẩm";
            // 
            // gvStatistic
            // 
            this.gvStatistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStatistic.Location = new System.Drawing.Point(13, 157);
            this.gvStatistic.Name = "gvStatistic";
            this.gvStatistic.RowTemplate.Height = 33;
            this.gvStatistic.Size = new System.Drawing.Size(949, 256);
            this.gvStatistic.TabIndex = 4;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(862, 427);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 40);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Đặt lại";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // grpChooseDay
            // 
            this.grpChooseDay.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grpChooseDay.Controls.Add(this.dtmChooseToDay);
            this.grpChooseDay.Controls.Add(this.label3);
            this.grpChooseDay.Controls.Add(this.label2);
            this.grpChooseDay.Controls.Add(this.dtmChooseFromDay);
            this.grpChooseDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChooseDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.grpChooseDay.Location = new System.Drawing.Point(49, 55);
            this.grpChooseDay.Name = "grpChooseDay";
            this.grpChooseDay.Size = new System.Drawing.Size(587, 84);
            this.grpChooseDay.TabIndex = 6;
            this.grpChooseDay.TabStop = false;
            this.grpChooseDay.Text = "Chọn ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(22, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Từ ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(325, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "đến";
            // 
            // dtmChooseToDay
            // 
            this.dtmChooseToDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmChooseToDay.Location = new System.Drawing.Point(381, 33);
            this.dtmChooseToDay.Name = "dtmChooseToDay";
            this.dtmChooseToDay.Size = new System.Drawing.Size(200, 31);
            this.dtmChooseToDay.TabIndex = 4;
            // 
            // grpChooseProduct
            // 
            this.grpChooseProduct.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grpChooseProduct.Controls.Add(this.cboChooseProduct);
            this.grpChooseProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChooseProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.grpChooseProduct.Location = new System.Drawing.Point(685, 55);
            this.grpChooseProduct.Name = "grpChooseProduct";
            this.grpChooseProduct.Size = new System.Drawing.Size(238, 84);
            this.grpChooseProduct.TabIndex = 7;
            this.grpChooseProduct.TabStop = false;
            this.grpChooseProduct.Text = "Chọn sản phẩm";
            // 
            // StatisticGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 479);
            this.Controls.Add(this.grpChooseProduct);
            this.Controls.Add(this.grpChooseDay);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.gvStatistic);
            this.Controls.Add(this.label1);
            this.Name = "StatisticGUI";
            this.Text = "THỐNG KÊ DOANH THU";
            ((System.ComponentModel.ISupportInitialize)(this.gvStatistic)).EndInit();
            this.grpChooseDay.ResumeLayout(false);
            this.grpChooseDay.PerformLayout();
            this.grpChooseProduct.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}