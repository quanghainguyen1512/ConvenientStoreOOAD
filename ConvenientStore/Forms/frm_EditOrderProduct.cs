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
    public partial class frm_EditOrderProduct : Form
    {
        public frm_EditOrderProduct()
        {
            InitializeComponent();
        }

        private void frm_EditOrderProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Display a MsgBox asking the user to save changes or abort.
            if (MessageBox.Show("Do you want close ?", "Edit Order Form",
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

        private void btnQuestion_Click(object sender, EventArgs e)
        {
            String text = "This form help you edi order event.";
            // Show Dialog.
            MessageBox.Show(text, "Project OOAD", MessageBoxButtons.OK);
        }
    }
}
