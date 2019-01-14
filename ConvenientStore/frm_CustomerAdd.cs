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
            this.dtpDateOfBirth.Value = DateTime.Now;
            this.txtPhoneNumber.Text = "";
            this.txtEmail.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_CustomerAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Display a MsgBox asking the user to save changes or abort.
            if (MessageBox.Show("Do you want close ?", "Add Customer Form",
               MessageBoxButtons.YesNo) == DialogResult.No)
            {
                // Cancel the Closing event from closing the form.
                e.Cancel = true;
                // Can Call method to save file here...
            }
        }
    }
}
