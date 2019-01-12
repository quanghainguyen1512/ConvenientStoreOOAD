using ConvenientStore.BUS;
using ConvenientStore.DAO;
using ConvenientStore.DTO;
using ConvenientStore.Services.Interfaces;
using ConvenientStore.Services.Repositories;
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
    public partial class XuLyHoaDonForm : Form
    {
        // Cờ dùng để nhận biết trường [Số điện thoại] có nhấn enter hay không
        private bool flagEnterPhoneNumberField;

        private XuLyHoaDonBus xuLyHoaDonService;

        public XuLyHoaDonForm()
        {
            InitializeComponent();

            this.xuLyHoaDonService = new XuLyHoaDonBus();

            this.resetForm();
        }

        // Cập nhật lại Form
        private void resetForm()
        {
            this.txtDate.Text = DateTime.UtcNow.ToString("dd/MM/yyyy");
            this.txtPhoneNumber.Text = "";
            this.txtCustomerName.Text = "";
            this.txtProductCode.Text = "";
            this.txtQuantity.Text = "";
            this.txtProductName.Text = "";
            this.txtSell.Text = "";
            this.txtPrice.Text = "";
            this.lbTotal.Text = "";

            this.flagEnterPhoneNumberField = false;

            this.setSellProgramForCombobox();
        }

        private void setSellProgramForCombobox()
        {
            List<String> temp = new List<String>();
            temp.Add("Tất cả");
            this.cbbSellProgram.DataSource = temp;

            //    comboBox1.DataSource = personList;
            //comboBox1.DisplayMember = "name";
            // cbb.DisplayValue="";
        }

        // Xửa lý khi enter sau khi nhập trường [Số điện thoại]
        private void enterTxtPhoneNumber(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.setCustomerInfo();
                this.flagEnterPhoneNumberField = true;
            }
        }

        // Xử lý khi leave trường [Số điện thoại]
        private void leaveTxtPhoneNumber(object sender, EventArgs e)
        {
            if(this.flagEnterPhoneNumberField)
            {
                this.flagEnterPhoneNumberField = false;
                return;
            }

            this.setCustomerInfo();
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
            this.setProductInfo();
        }

        // Xử lý khi nhấn enter trường [Mã sản phẩm]
        private void enterTxtProductCode(object sender, KeyEventArgs e)
        {
            this.setProductInfo();
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
            this.resetForm();
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

            foreach (DataGridViewCell cell in this.dgvListProduct.SelectedRows[0].Cells)
            {
                string value = cell.Value.ToString();
            }
        }

        // Lấy thông tin [Khách hàng]
        private void setCustomerInfo()
        {
            string phoneNumber = this.txtPhoneNumber.Text;

            CustomerBillDto dto = this.xuLyHoaDonService.GetCustomerByPhoneNumber(phoneNumber);

            if (!"".Equals(dto.Message.Trim()))
            {
                MessageBox.Show(dto.Message, "Lỗi hiển thị thông tin khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.txtCustomerName.Text = dto.FullName;

        }

        private void setProductInfo()
        {
            string productCode = this.txtProductCode.Text;

        }

    }
}
