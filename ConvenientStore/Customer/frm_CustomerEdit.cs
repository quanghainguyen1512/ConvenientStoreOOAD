using ConvenientStore.BUS;
using ConvenientStore.DTO;
using ConvenientStore.Helpers.Message;
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
    

    public partial class frm_CustomerEdit : Form
    {
        private CustomEditBus bus;

        public CustomerManagementDto CustomerManagementDto { get; set; }

        public bool FlagChange { get; set; }

        public frm_CustomerEdit(CustomerManagementDto customerManagementDto)
        {
            InitializeComponent();

            this.CustomerManagementDto = customerManagementDto;

            this.FlagChange = false;
            if(this.CustomerManagementDto == null)
            {
                this.Close();
            }

            this.initForm();
        }

        private void initForm()
        {
            this.bus = new CustomEditBus();

            this.txtCustomerName.Text = this.CustomerManagementDto.fullName();

            this.txtEmail.Text = this.CustomerManagementDto.Email;
            this.txtGender.Text = this.CustomerManagementDto.Gender;
            this.txtPhoneNumber.Text = this.CustomerManagementDto.PhoneNumber;

            this.dtpDateOfBirth.Value = DateTime.Parse(this.CustomerManagementDto.DateOfBirth);
            this.lbPoint.Text = this.CustomerManagementDto.Point;

            this.txtCusType.Text = this.bus.GetCustomerTypeName(Convert.ToInt32(this.CustomerManagementDto.Id));
        }

        private void clickBtnCancel(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clickBtnSaveChange(object sender, EventArgs e)
        {
            string customerId = this.CustomerManagementDto.Id;
            string dateOfBirth = this.dtpDateOfBirth.Value.ToShortDateString();
            string customerName = this.txtCustomerName.Text;
            string phoneNumber = this.txtPhoneNumber.Text;
            string email = this.txtEmail.Text;

            if("".Equals(customerName.Trim()))
            {
                MessageBox.Show(String.Format(MessageContent.EMPTY_FIELD_ERROR, "Tên khách hàng"), MessageTitle.REQUIRE_INPUT_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if ("".Equals(email.Trim()))
            {
                MessageBox.Show(String.Format(MessageContent.EMPTY_FIELD_ERROR, "Email"), MessageTitle.REQUIRE_INPUT_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if ("".Equals(phoneNumber.Trim()))
            {
                MessageBox.Show(String.Format(MessageContent.EMPTY_FIELD_ERROR, "Số điện thoại"), MessageTitle.REQUIRE_INPUT_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> list = new List<string>();
            list.Add(customerId);
            list.Add(customerName);
            list.Add(dateOfBirth);
            list.Add(phoneNumber);
            list.Add(email);

            if("".Equals(this.bus.Update(list)))
            {
                MessageBox.Show(String.Format(MessageContent.UPDATE_INFOR_SUCCESSFULLY, customerName), MessageTitle.UPDATE_SUCCESSFULLY, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.FlagChange = true;
            } else
            {
                MessageBox.Show(String.Format(MessageContent.UPDATE_CUSTOMER_INFO_ERROR, customerName), MessageTitle.UPDATE_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_CustomerEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Display a MsgBox asking the user to save changes or abort.
            if (MessageBox.Show("Do you want close ?", "Edit Customer Form",
               MessageBoxButtons.YesNo) == DialogResult.No)
            {
                // Cancel the Closing event from closing the form.
                e.Cancel = true;
                // Can Call method to save file here...
            }
        }
    }
}
