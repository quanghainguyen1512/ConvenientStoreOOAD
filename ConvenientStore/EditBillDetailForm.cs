using ConvenientStore.DTO;
using ConvenientStore.Helpers.Message;
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
    public partial class EditBillDetailForm : Form
    {
        public ProductBillDto ProductBillDto { get; set; }
        public bool FlagDelete { get; set; }

        public EditBillDetailForm(ProductBillDto productBillDto)
        {
            InitializeComponent();

            this.ProductBillDto = productBillDto;

            this.initForm();
        }

        // Khởi tạo thông tin form [Chỉnh sửa thông tin sản phẩm]
        private void initForm()
        {
            if(this.ProductBillDto == null)
            {
                this.Close();
            }

            this.txtProductCode.Text = this.ProductBillDto.Barcode;
            this.txtProductName.Text = this.ProductBillDto.ProductName;
            this.txtPrice.Text = this.ProductBillDto.Price;
            this.txtQuantity.Text = this.ProductBillDto.Quantity;

            byte[] bytes = Convert.FromBase64String(this.ProductBillDto.ImageUrl);

            using (var ms = new MemoryStream(bytes, 0, bytes.Length))
            {
                this.ptbPicture.Image = Image.FromStream(ms, true);
                this.ptbPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            this.FlagDelete = false;
            this.txtQuantity.Focus();
        }

        // Xử lý khi nhấn nút [Xóa]
        private void clickBtnDelete(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show(MessageContent.CONFIRM_DELETE_PRODUCT_BILL_DETAIL,
                MessageTitle.CONFIRM_INFORMATION, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dr == DialogResult.Yes)
            {
                this.FlagDelete = true;
                this.Close();
            }

            
        }

        // Xử lý khi nhấn nút [Lưu thay đổi]
        private void clickBtnSaveChange(object sender, EventArgs e)
        {
            this.submitChange();
        }

        // Xử lý khi nhấn enter trường [Số lượng]
        private void enterTxtQuantity(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (!this.checkQuantityFormat())
                    return;

                this.submitChange();
            }
        }

        private void submitChange()
        {
            if ("".Equals(txtQuantity.Text.Trim()))
            {
                MessageBox.Show(MessageContent.REQUIRE_INPUT_QUANTITY_FIELD, MessageTitle.REQUIRE_INPUT_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtQuantity.Focus();
                return;
            }

            this.ProductBillDto.Quantity = this.txtQuantity.Text;
            this.Close();
        }

        // Xử lý khi leave trường [Số lượng]
        private void leaveTxtQuantity(object sender, EventArgs e)
        {
            this.checkQuantityFormat();
        }

        private bool checkQuantityFormat()
        {
            try
            {
                int Quantity = Convert.ToInt32(this.txtQuantity.Text);
                return true;
            }
            catch
            {
                MessageBox.Show(MessageContent.QUANTITY_FIELD_FORMAT_ERROR, MessageTitle.FORMAT_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtQuantity.Focus();
                return false;
            }
        }

        private void EditBillDetailForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Display a MsgBox asking the user to save changes or abort.
            if (MessageBox.Show("Do you want close ?", "EditBill Form",
               MessageBoxButtons.YesNo) == DialogResult.No)
            {
                // Cancel the Closing event from closing the form.
                e.Cancel = true;
                // Can Call method to save file here...
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
