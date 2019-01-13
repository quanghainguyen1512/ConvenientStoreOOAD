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
    public partial class frm_CustomerAdd : Form
    {

        public bool FlagAdd { get; set; }

        public frm_CustomerAdd()
        {
            InitializeComponent();


            this.initForm();
        }

        private void initForm()
        {
            this.txtCustomerName.Text = "";
            this.dtpDateOfBirth.Value = DateTime.Now();
            this.txtPhoneNumber.Text = "";
            this.txtEmail.Text = "";
        }
    }
}
