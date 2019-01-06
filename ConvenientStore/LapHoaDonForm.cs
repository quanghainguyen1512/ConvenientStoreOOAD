using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvenientStore
{
    public partial class LapHoaDonForm : Form
    {
        public LapHoaDonForm()
        {
            InitializeComponent();
        }

        // Xử lý load thông tin khách hàng khi rời khỏi trường [Mã khách hàng]
        private void leaveCustomerCodeField(object sender, EventArgs e)
        {
            if("".Equals(this.txtCustomerCode.Text.Trim()))
            {
                return;
            }
        }

        // Xử lý load thông tin khách hàng khi nhấn enter trường [Mã khách hàng]
        private void enterCustomerCodeField(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {

            }
        }

        // Xử lý load thông tin sản phẩm khi rời khỏi trường [Mã sản phẩm]
        private void leaveProductCode(object sender, EventArgs e)
        {
            if ("".Equals(this.txtProductCode.Text.Trim()))
            {
                return;
            }
        }

        // Xử lý load thông tin sản phẩm khi nhấn enter trường [Mã sản phẩm]
        private void enterProductCode(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

            }
        }
    }
}
