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

        // Xửa lý khi enter sau khi nhập trường [Mã khách hàng]
        private void enterTxtCustomerCode(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {

            }
        }

        // Xử lý khi leave trường [Mã khách hàng]
        private void leaveTxtCustomerCode(object sender, EventArgs e)
        {

        }

        // Xử lý khi thay đổi [Chương trình khuyến mãi]
        private void changeCbbSellProgram(object sender, EventArgs e)
        {

        }

        // Xử lý khi click vào button [Thông tin khuyến mãi]
        private void clickBtnSellDetail(object sender, EventArgs e)
        {

        }

        // Xử lý khi leave trường [Mã sản phẩm]
        private void leaveTxtProductCode(object sender, EventArgs e)
        {

        }

        // Xử lý khi nhấn enter trường [Mã sản phẩm]
        private void enterTxtProductCode(object sender, KeyEventArgs e)
        {

        }

        // Xử lý khi click vào button [Xóa sản phẩm]
        private void clickBtnDeleteProduct(object sender, EventArgs e)
        {

        }

        // Xử lý khi click vào button [Thêm sản phẩm]
        private void clickBtnAddProduct(object sender, EventArgs e)
        {

        }

        // Xử lý khi click vào button [Hủy hóa đơn]
        private void clickBtnCancel(object sender, EventArgs e)
        {

        }

        // Xử lý click vào button [Thanh toán]
        private void clickBtnSubmit(object sender, EventArgs e)
        {

        }

        // Xử lý khi double click vào row của [Danh sách các sản phẩm]
        private void doubleClickRow(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
        }

        private void doubleClickRow(object sender, EventArgs e)
        {
            if (this.dgvListProduct.SelectedRows.Count == 0)
                return;

            foreach(DataGridViewCell cell in this.dgvListProduct.SelectedRows[0].Cells)
            {
                string value = cell.Value.ToString();
            }
        }
    }
}
