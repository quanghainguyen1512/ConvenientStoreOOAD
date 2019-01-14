using ConvenientStore.BUS;
using ConvenientStore.DTO;
using ConvenientStore.Helpers.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ConvenientStore
{
    public partial class frm_CustomerManagement : Form
    {
        private CustomerManagementBus customerManagementBus;
        private List<CustomerManagementDto> customerManagementDtos;
        private frm_CustomerEdit customerEditForm;

        public frm_CustomerManagement()
        {
            InitializeComponent();
            this.customerManagementBus = new CustomerManagementBus();

            this.initForm();
        }

        private void initForm()
        {
            this.txtCustomerName.Text = "";
            this.txtPhoneNumber.Text = "";

            this.customerEditForm = null;

            this.customerManagementDtos = new List<CustomerManagementDto>();

            this.customerManagementDtos = this.customerManagementBus.GetAllCustomer();

            if(this.customerManagementDtos.Count <= 0)
            {
                MessageBox.Show(MessageContent.GET_CUSTOMER_ERROR, MessageTitle.GET_CUSTOMER_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.reloadDataGridView();

        }

        // Xử lý khi double click trường [Dánh sách khách hàng]
        private void doubleClickRow(object sender, EventArgs e)
        {
            if (this.customerManagementDtos.Count <= 0)
                return;

            if (this.dgvListCustomer.SelectedRows.Count == 0)
                return;

            string index = this.dgvListCustomer.SelectedRows[0].Cells[0].Value.ToString();

            CustomerManagementDto tempDto = this.customerManagementDtos[Convert.ToInt32(index) - 1];

            this.customerEditForm = new frm_CustomerEdit(tempDto);
            this.customerEditForm.FormClosing += new FormClosingEventHandler(formClosing);
            this.customerEditForm.Show();
        }

        private void formClosing(object sender, FormClosingEventArgs e)
        {
            if (this.customerEditForm.FlagChange)
            {

                this.initForm();
            }
        }

        // Xử lý khi click nút [Tìm kiếm theo ngày sinh]
        private void clickBtnSearchByDate(object sender, EventArgs e)
        {

        }

        // Xử lý khi click nút [Xuất Excel]
        private void clickBtnExportExcel(object sender, EventArgs e)
        {

        }

        // Xử lý khi click nút [Thêm khách hàng]
        private void clickBtnAddCustomer(object sender, EventArgs e)
        {
            frm_CustomerAdd form = new frm_CustomerAdd();
            form.FormClosing += new FormClosingEventHandler((sender1, e1)=>this.initForm());
            form.Show();
            
        }

            // Xử lý khi nhấn enter trường [Số điện thoại]
            private void enterTxtPhoneNumber(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {

                if ("".Equals(this.txtPhoneNumber.Text.Trim()))
                    return;

                CustomerManagementDto dto =  this.customerManagementBus.GetCustomerByPhone(this.txtPhoneNumber.Text.Trim());

                if (!"".Equals(dto.Message.Trim()))
                {
                    MessageBox.Show(dto.Message, MessageTitle.GET_CUSTOMER_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                this.customerManagementDtos.Clear();
                this.customerManagementDtos.Add(dto);
                this.reloadDataGridView();
            }
        }

        // Xử lý khi thay đổi giá trị trường [Số điện thoại]
        private void changeTxtPhoneNumber(object sender, EventArgs e)
        {
            if ("".Equals(txtPhoneNumber.Text.Trim()))
                return;

            this.txtCustomerName.Text = "";
        }

        // Xử lý khi enter trường [Tên khách hàng]
        // TODO: Chưa xử lý đc
        private void enterTxtCustomerName(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if ("".Equals(txtCustomerName.Text.Trim()))
                    return;

                this.customerManagementDtos = this.customerManagementBus.GetCustomerByName(txtCustomerName.Text.Trim());

                if (this.customerManagementDtos.Count <= 0)
                {
                    MessageBox.Show(MessageContent.GET_CUSTOMER_ERROR, MessageTitle.GET_CUSTOMER_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                this.reloadDataGridView();
            }
        }

        // Xử lý khi thay đổi giá trị [Tên khách hàng]
        private void changeTxtCustomerName(object sender, EventArgs e)
        {
            if ("".Equals(txtCustomerName.Text.Trim()))
                return;

            this.txtPhoneNumber.Text = "";
        }

        private void reloadDataGridView()
        {
            this.dgvListCustomer.Rows.Clear();
            for (int i = 0; i < this.customerManagementDtos.Count(); i++)
            {

                this.customerManagementDtos[i].Index = (i + 1).ToString();

                this.dgvListCustomer.Rows.Add(i + 1, this.customerManagementDtos[i].fullName(), this.customerManagementDtos[i].PhoneNumber,
                    this.customerManagementDtos[i].DateOfBirth, this.customerManagementDtos[i].Point);
            }

        }


    }
}
