using ConvenientStore.BUS;
using ConvenientStore.DTO;
using ConvenientStore.ExportFile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvenientStore
{
    public partial class frm_ProductManagementDetail : Form
    {
        public ProductMangementDto ProductMangementDto { get; set; }
        private List<ProductManagementDetailDto> productManagementDetailDtos;
        private ProductManagementDetailBus bus;

        public frm_ProductManagementDetail(ProductMangementDto productDetalDto)
        {
            InitializeComponent();

            this.ProductMangementDto = productDetalDto;

            this.initForm();
        }

        private void initForm()
        {
            byte[] bytes = Convert.FromBase64String(this.ProductMangementDto.ImageUrl);

            using (var ms = new MemoryStream(bytes, 0, bytes.Length))
            {
                this.ptbPicture.Image = Image.FromStream(ms, true);
                this.ptbPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            this.txtProductCode.Text = this.ProductMangementDto.Barcode;
            this.txtProductName.Text = this.ProductMangementDto.ProductName;

            this.bus = new ProductManagementDetailBus();
            this.productManagementDetailDtos = new List<ProductManagementDetailDto>();
            this.productManagementDetailDtos = this.bus.GetProductDetailByProduct(Convert.ToInt32(this.ProductMangementDto.Id));

            this.reloadDataGridView();
        }

        private void reloadDataGridView()
        {
            this.dgv.Rows.Clear();

            List<ProductManagementDetailDto> list = this.productManagementDetailDtos;

            for (int i = 0; i < list.Count; i++)
            {
                this.dgv.Rows.Add(i + 1, list[i].GeneratedCode, list[i].Quantity,
                    list[i].Price, this.ProductMangementDto.Unit, list[i].ExpirationDate);
            }
        }

        // Xử lý khi nhấn nút [Đặt hàng]
        private void clickBtnOrder(object sender, EventArgs e)
        {

        }

        // Xử lý khi nhấn nút [Xuất Excel]
        private void clickBtnExportExcell(object sender, EventArgs e)
        {
            ExportExcel excel = new ExportExcel(dgv, "Thông tin sản phẩm");
        }

        // Xử lý khi nhấn nút [Trở lại]
        private void clickBtnCancel(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_ProductManagementDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Display a MsgBox asking the user to save changes or abort.
            if (MessageBox.Show("Bạn muốn đóng form?", "Xác nhận",
               MessageBoxButtons.YesNo) == DialogResult.No)
            {
                // Cancel the Closing event from closing the form.
                e.Cancel = true;
                // Can Call method to save file here...
            }
        }
    }
}
