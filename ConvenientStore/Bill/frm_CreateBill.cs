using ConvenientStore.BUS;
using ConvenientStore.DAO;
using ConvenientStore.DTO;
using ConvenientStore.Helpers.Message;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvenientStore
{
    public partial class frm_CreateBill : Form
    {
        // Cờ dùng để nhận biết trường [Số điện thoại] có nhấn enter hay không
        private bool flagEnterPhoneNumberField;
        private bool flagEnterProductCodeField;
        private ProductBillDto productBillDto;
        private CustomerBillDto customerBillDto;
        private List<ProductBillDto> productBillDtos;
        private EditBillDetailForm editBillDetailForm;

        private XuLyHoaDonBus xuLyHoaDonService;

        public frm_CreateBill()
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
            this.txtQuantity.Text = "0";
            this.txtProductName.Text = "";
            this.txtSell.Text = "";
            this.txtPrice.Text = "";
            this.lbTotal.Text = "0";

            this.flagEnterPhoneNumberField = false;
            this.flagEnterProductCodeField = false;

            this.productBillDto = null;
            this.customerBillDto = null;
            this.editBillDetailForm = null;
            this.productBillDtos = new List<ProductBillDto>();

            this.setSellProgramForCombobox();
            this.dgvListProduct.Rows.Clear();

            try
            {
                this.txtBillCode.Text = this.xuLyHoaDonService.GenerateBillCode();
            }
            catch
            {
                MessageBox.Show(MessageContent.SYSTEM_ERROR, MessageTitle.SYSTEM_ERROR,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


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
            if(this.flagEnterProductCodeField)
            {
                this.flagEnterProductCodeField = false;
                return;
            }
            this.setProductInfo();
        }

        // Xử lý khi nhấn enter trường [Số lượng]
        private void enterTxtQuantity(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.addProduct();
            }
        }

        // Xử lý khi nhấn enter trường [Mã sản phẩm]
        private void enterTxtProductCode(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.flagEnterProductCodeField = true;
                this.setProductInfo();
            }
        }

        // Xử lý khi click vào button [Xóa sản phẩm]
        private void clickBtnDeleteProduct(object sender, EventArgs e)
        {
            this.deleteProduct();
        }

        // Xử lý khi click vào button [Thêm sản phẩm]
        private void clickBtnAddProduct(object sender, EventArgs e)
        {
            this.addProduct();
        }

        // Xử lý khi click vào button [Hủy hóa đơn]
        private void clickBtnCancel(object sender, EventArgs e)
        {
            this.resetForm();
        }

        // Xử lý click vào button [Thanh toán]
        private void clickBtnSubmit(object sender, EventArgs e)
        {
            submitBill();
        }

        // Xử lý khi double click vào row của [Danh sách các sản phẩm]
        private void doubleClickRow(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
        }

        private void doubleClickRow(object sender, EventArgs e)
        {
            if (this.productBillDtos.Count <= 0)
                return;

            if (this.dgvListProduct.SelectedRows.Count == 0)
                return;

            string index = this.dgvListProduct.SelectedRows[0].Cells[0].Value.ToString();

            ProductBillDto tempProductBillDto = this.productBillDtos[Convert.ToInt32(index) - 1];

            this.editBillDetailForm = new EditBillDetailForm(tempProductBillDto);
            this.editBillDetailForm.FormClosing += new FormClosingEventHandler(formClosing);
            this.editBillDetailForm.Show();
           
        }

        private void formClosing(object sender, FormClosingEventArgs e)
        {
            ProductBillDto tempProductBillDto = this.editBillDetailForm.ProductBillDto;

            if(this.editBillDetailForm.FlagDelete)
            {
                this.productBillDtos.Remove(tempProductBillDto);
            }
            else
            {
                this.productBillDtos[Convert.ToInt32(tempProductBillDto.Index) - 1] = tempProductBillDto;
            }

            this.reloadDataGridView();

            this.editBillDetailForm = null;
        }


        // Lấy thông tin [Khách hàng]
        private void setCustomerInfo()
        {
            string phoneNumber = this.txtPhoneNumber.Text;

            if ("".Equals(phoneNumber.Trim()))
            {
                return;
            }

            this.customerBillDto = this.xuLyHoaDonService.GetCustomerByPhoneNumber(phoneNumber);

            if (!"".Equals(this.customerBillDto.Message.Trim()))
            {
                MessageBox.Show(this.customerBillDto.Message, MessageTitle.GET_CUSTOMER_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.customerBillDto = null;
                return;
            }

            this.txtCustomerName.Text = this.customerBillDto.FullName;
            this.txtProductCode.Focus();

        }

        // Lấy thông tin sản phẩm
        private void setProductInfo()
        {
            string productCode = this.txtProductCode.Text.Trim();

            if ("".Equals(productCode))
            {
                return;
            }

            this.productBillDto = this.xuLyHoaDonService.GetProductByGeneratedCode(productCode);

            if (!"".Equals(this.productBillDto.Message.Trim()))
            {
                MessageBox.Show(this.productBillDto.Message, MessageTitle.GET_PRODUCT_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.productBillDto = null;
                return;
            }

            this.txtProductName.Text = this.productBillDto.ProductName;
            this.txtSell.Text = this.productBillDto.SellRate;
            this.txtPrice.Text = this.productBillDto.Price;

            byte[] bytes = Convert.FromBase64String(this.productBillDto.ImageUrl);

            using(var ms = new MemoryStream(bytes, 0, bytes.Length))
            {
                this.ptbImage.Image = Image.FromStream(ms, true);
                this.ptbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            this.txtQuantity.Focus();

        }

        // Xóa thông tin sản phẩm vừa tìm kiếm
        private void deleteProduct()
        {
            this.txtProductCode.Text = "";
            this.txtProductName.Text = "";
            this.txtSell.Text = "";
            this.txtPrice.Text = "";
            this.txtQuantity.Text = "0";

            this.txtProductCode.Focus();
        }

        // Thêm sản phẩm vừa chọn
        private void addProduct()
        {
            if("".Equals(this.txtProductCode.Text.Trim()))
            {
                MessageBox.Show(MessageContent.PRODUCT_CODE_IS_EMPTY, MessageTitle.ADD_PRODUCT_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if("".Equals(this.txtQuantity.Text.Trim()))
            {
                MessageBox.Show(MessageContent.PRODUCT_QUANTITY_IS_EMPTY, MessageTitle.ADD_PRODUCT_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.productBillDto.Quantity = this.txtQuantity.Text;
            this.productBillDto.Index = (this.productBillDtos.Count() + 1).ToString();
            this.productBillDtos.Add(this.productBillDto);
            
            this.dgvListProduct.Rows.Add(this.productBillDto.Index, this.productBillDto.Barcode, this.productBillDto.ProductName,
                this.productBillDto.Quantity, this.productBillDto.Price, this.productBillDto.SellRate, this.productBillDto.Unit,
                this.productBillDto.Total());

            //Console.WriteLine();
            int total = Convert.ToInt32(System.Text.RegularExpressions.Regex.Replace(this.productBillDto.Total(), "[^.0-9]", ""));
    
            this.lbTotal.Text = (Convert.ToInt32(System.Text.RegularExpressions.Regex.Replace(this.lbTotal.Text, "[^.0-9]", "")) + total)
                .ToString("#,#", CultureInfo.InvariantCulture);

            this.productBillDto = null;

            this.deleteProduct();
    
        }

        private void reloadDataGridView()
        {
            this.dgvListProduct.Rows.Clear();
            for(int i = 0; i<this.productBillDtos.Count(); i++)
            {
                this.dgvListProduct.Rows.Add(this.productBillDtos[i].Index, this.productBillDtos[i].Barcode, this.productBillDtos[i].ProductName,
                this.productBillDtos[i].Quantity, this.productBillDtos[i].Price, this.productBillDtos[i].SellRate, this.productBillDtos[i].Unit,
                this.productBillDtos[i].Total());
            }
        }

        // Thanh toán hóa đơn
        private void submitBill()
        {
            if (this.productBillDtos.Count() <= 0)
                return;

            if(this.customerBillDto != null)
            {
                this.customerBillDto.Point = (Convert.ToInt32(this.customerBillDto.Point)
                    + Convert.ToInt32(System.Text.RegularExpressions.Regex.Replace(this.lbTotal.Text, "[^.0-9]", "")) * 1 / 100).ToString();
            }
            

            string message = this.xuLyHoaDonService.SubmitBill(this.productBillDtos, this.customerBillDto, this.lbTotal.Text);
            
            if("".Equals(message))
            {
                this.xuLyHoaDonService.ExportPdf(this.productBillDtos, this.customerBillDto);
                
                StringBuilder stringBuilder = new StringBuilder();
                
                foreach (ProductBillDto dto in this.productBillDtos)
                {
                    stringBuilder.Append(dto.ProductName + "\r\n");
                    stringBuilder.Append("---- Đơn giá: " + Convert.ToInt32(dto.Price).ToString("#,#", CultureInfo.InvariantCulture) + "VNĐ\r\n");
                    stringBuilder.Append("---- Số lượng: " + dto.Quantity + "\r\n");
                    stringBuilder.Append("---- Thành tiền: " + dto.Total() + " VNĐ" + "\r\n\r\n");
                }
                stringBuilder.Append("\r\nTổng cộng: " + this.lbTotal.Text + " VNĐ" + "\r\n\r\n");
                
                if(this.customerBillDto != null)
                {
                    stringBuilder.Append("Khách hàng: " + this.customerBillDto.FullName + "\r\n");
                    stringBuilder.Append("---- Loại khách hàng: " + this.customerBillDto.CusType + "\r\n");
                    stringBuilder.Append("---- Điểm: " + this.customerBillDto.Point + "\r\n");
                }

                MessageBox.Show(stringBuilder.ToString(), MessageTitle.SUBMIT_BILL_SUCCESSFULLY, 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.resetForm();
            }
            else
            {
                MessageBox.Show(message, MessageTitle.SUBMIT_BILL_ERROR, 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
