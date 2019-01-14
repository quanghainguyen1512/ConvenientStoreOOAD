using ConvenientStore.BUS;
using ConvenientStore.DTO;
using ConvenientStore.Helpers.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ConvenientStore
{
    public partial class frm_CustomerAdd : Form
    {

        private CustomerAddBus bus;

        public bool FlagAdd { get; set; }

        public frm_CustomerAdd()
        {
            InitializeComponent();


            this.initForm();
        }

        private void initForm()
        {
            this.txtCustomerName.Text = "";
            this.dtpDateOfBirth.Value = DateTime.Now;
            this.txtPhoneNumber.Text = "";
            this.txtEmail.Text = "";

            this.bus = new CustomerAddBus();

            this.fillCbbCusType();
            this.fillCbbGender();
        }

        private void fillCbbCusType()
        {
            List<CustomerTypeDto> list = this.bus.GetAllCustomerType();
            list = list.Skip(1).ToList();

            this.cbbCusType.DataSource = list;
            
            this.cbbCusType.DisplayMember = "Name";
            this.cbbCusType.ValueMember = "Id";
        }

        private void fillCbbGender()
        {
            List<String> temp = new List<String>();
            temp.Add("Nam");
            temp.Add("Nữ");
            this.cbbGender.DataSource = temp;
            this.cbbGender.SelectedIndex = 0;
        }

        private void clickBtnCancel(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clickBtnSubmit(object sender, EventArgs e)
        {
            List<string> lists = new List<string>();
            lists.Add(this.txtCustomerName.Text);
            lists.Add(this.dtpDateOfBirth.Value.ToShortDateString());
            lists.Add(this.txtPhoneNumber.Text);
            lists.Add(this.txtEmail.Text);
            lists.Add(this.cbbCusType.SelectedValue.ToString());
            lists.Add(this.cbbGender.SelectedValue.ToString());

            string message = this.bus.Submit(lists);

            if("".Equals(message))
            {
                DialogResult dr = MessageBox.Show(String.Format(MessageContent.ADD_CUSTOMER_SUCCESSFULLY, txtCustomerName.Text) + MessageContent.BREAK_LINE + MessageContent.CONFIRM_READD_CUSTOMER,
                    "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if(dr == DialogResult.Yes)
                {
                    this.initForm();
                } else
                {
                    this.Close();
                }
            }else
            {
                MessageBox.Show(message,
                    MessageTitle.SYSTEM_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
