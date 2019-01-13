using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvenientStore.Forms
{
    public partial class frm_AddSale : Form
    {
        public frm_AddSale()
        {
            InitializeComponent();
            // Set the Format type and the CustomFormat string.
            dtmSaleBeginDay.Format = DateTimePickerFormat.Custom;
            dtmSaleBeginDay.CustomFormat = "dd/MM/yyyy";
            dtmSaleEndDay.Format = DateTimePickerFormat.Custom;
            dtmSaleEndDay.CustomFormat = "dd/MM/yyyy";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuestion_Click(object sender, EventArgs e)
        {
            String text = "This form help you add sale event.";
            // Show Dialog.
            MessageBox.Show(text, "Project OOAD", MessageBoxButtons.OK);
        }

        private void frm_AddSale_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Display a MsgBox asking the user to save changes or abort.
            if (MessageBox.Show("Do you want close ?", "Add Sale Form",
               MessageBoxButtons.YesNo) == DialogResult.No)
            {
                // Cancel the Closing event from closing the form.
                e.Cancel = true;
                // Can Call method to save file here...
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtSaleName.Text = "";
            txtSaleValue.Text = "";
            //cboSaleType.SelectedIndex = 0;
            txtMinCondition.Text = "";
            chkNewCustomer.Checked = false;
            chkGoldCustomer.Checked = false;
            chkDimondCustomer.Checked = false;
            dtmSaleBeginDay.Value = DateTime.Today;
            dtmSaleEndDay.Value = DateTime.Today;
            txtSaleDescription.Text = "";
        }

        private void txtMinCondition_Leave(object sender, EventArgs e)
        {
            Double value;
            if (Double.TryParse(txtMinCondition.Text, out value))
                txtMinCondition.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", value);
            else
                txtMinCondition.Text = String.Empty;
        }
    }
}
