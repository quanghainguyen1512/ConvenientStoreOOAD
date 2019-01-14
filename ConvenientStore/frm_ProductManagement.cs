using ConvenientStore.BUS;
using ConvenientStore.DTO;
using ConvenientStore.ExportFile;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ConvenientStore
{
    public partial class frm_ProductManagement : Form
    {
        private List<ProductMangementDto> productManagementDtos;
        private List<ProductMangementDto> tempProductManagementDtos;

        private ProductManagementBus bus;

        public frm_ProductManagement()
        {
            InitializeComponent();

            this.initForm();
            
        }
        
        private void initForm()
        {
            this.txtProductCode.Text = "";
            this.txtProductName.Text = "";

            this.productManagementDtos = new List<ProductMangementDto>();
            this.tempProductManagementDtos = new List<ProductMangementDto>();

            this.bus = new ProductManagementBus();

            this.productManagementDtos = this.bus.GetAllProduct();

            this.tempProductManagementDtos = this.productManagementDtos;

            this.reloadDataGridView();
        }

        private void reloadDataGridView()
        {
            this.dgvListProduct.Rows.Clear();

            List<ProductMangementDto> list = this.tempProductManagementDtos;

            for (int i = 0; i < list.Count; i++)
            {
                this.dgvListProduct.Rows.Add(i + 1, list[i].Barcode, list[i].ProductName,
                    list[i].Quantity, list[i].Unit);
            }
        }

        // Xử lý khi double clock [Danh sách sản phẩm]
        private void doubleClickRow(object sender, EventArgs e)
        {
            if (this.tempProductManagementDtos.Count <= 0)
                return;

            if (this.dgvListProduct.SelectedRows.Count == 0)
                return;

            string index = this.dgvListProduct.SelectedRows[0].Cells[0].Value.ToString();

            ProductMangementDto tempDto = this.tempProductManagementDtos[Convert.ToInt32(index) - 1];

            frm_ProductManagementDetail form = new frm_ProductManagementDetail(tempDto);

            form.Show();
        }

        // Xử lý nhấn enter trường [Mã sản phẩm]
        private void enterTxtProductCode(object sender, EventArgs e)
        {

        }

        // Xử lý khi thay đổi trường [Mã sản phẩm]
        private void changeTxtProductCode(object sender, EventArgs e)
        {
            if("".Equals(this.txtProductCode.Text))
            {
                return;
            }

            this.txtProductName.Text = "";
        }

        // Xử lý khi enter trường [Tên sản phẩm]
        private void enterProductName(object sender, KeyEventArgs e)
        {

        }

        // Xử lý khi change trường [Tên sản phẩm]
        private void changeTxtProductName(object sender, EventArgs e)
        {
            if ("".Equals(this.txtProductName.Text))
            {
                return;
            }

            this.txtProductCode.Text = "";
        }


        // Xử lý khi nhấn nút [Xuất excel]
        private void clickBtnExportExcel(object sender, EventArgs e)
        {
            ExportExcel excel = new ExportExcel(dgvListProduct, "Danh sách các sản phẩm");
        }


        // Xử lý khi nhấn nút [Đặt hàng]
        private void clickBtnOrder(object sender, EventArgs e)
        {

        }
    }
}
