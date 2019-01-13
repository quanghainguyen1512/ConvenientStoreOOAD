using ConvenientStore.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ConvenientStore
{
    public partial class frm_ProductManagement : Form
    {
        private List<ProductMangementDto> productManagementDtos;

        public frm_ProductManagement()
        {
            InitializeComponent();

            this.initForm();
            
        }
        
        private void initForm()
        {
            this.txtProductCode.Text = "";
            this.txtProductName.Text = "";
            this.dtpDateStart.Value = DateTime.Now;
            this.dtpDateEnd.Value = DateTime.Now;

            this.productManagementDtos = new List<ProductMangementDto>();
        }

        // Xử lý khi double clock [Danh sách sản phẩm]
        private void doubleClickRow(object sender, EventArgs e)
        {

        }

        // Xử lý nhấn enter trường [Mã sản phẩm]
        private void enterTxtProductCode(object sender, EventArgs e)
        {

        }

        // Xử lý khi thay đổi trường [Mã sản phẩm]
        private void changeTxtProductCode(object sender, EventArgs e)
        {
            this.txtProductName.Text = "";
        }

        // Xử lý khi enter trường [Tên sản phẩm]
        private void enterProductName(object sender, KeyEventArgs e)
        {

        }

        // Xử lý khi change trường [Tên sản phẩm]
        private void changeTxtProductName(object sender, EventArgs e)
        {
            this.txtProductCode.Text = "";
        }

        // Xử lý khi nhấn nút [Tìm kiếm theo ngày]
        private void clickBtnSubmitSearchByDate(object sender, EventArgs e)
        {

        }

        // Xử lý khi nhấn nút [Xuất excel]
        private void clickBtnExportExcel(object sender, EventArgs e)
        {

        }


        // Xử lý khi nhấn nút [Đặt hàng]
        private void clickBtnOrder(object sender, EventArgs e)
        {

        }
    }
}
