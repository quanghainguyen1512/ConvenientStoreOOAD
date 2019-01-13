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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            pnlHighlight.Height = btnBill.Height;
            pnlHighlight.Top = btnBill.Top;
            uc_SaleDetails.BringToFront();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            pnlHighlight.Height = btnBill.Height;
            pnlHighlight.Top = btnBill.Top;
            uc_BillDetails.BringToFront();
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            pnlHighlight.Height = btnStore.Height;
            pnlHighlight.Top = btnStore.Top;
            uc_StoreDetails.BringToFront();

        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            pnlHighlight.Height = btnSale.Height;
            pnlHighlight.Top = btnSale.Top;
            uc_SaleDetails.BringToFront();
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            pnlHighlight.Height = btnContact.Height;
            pnlHighlight.Top = btnContact.Top;
            uc_OrderProducts.BringToFront();

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            pnlHighlight.Height = btnCustomer.Height;
            pnlHighlight.Top = btnCustomer.Top;

        }

        private void btnRollback_Click(object sender, EventArgs e)
        {
            pnlHighlight.Height = btnRollback.Height;
            pnlHighlight.Top = btnRollback.Top;


        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            pnlHighlight.Height = btnChart.Height;
            pnlHighlight.Top = btnChart.Top;


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnQuestion_Click(object sender, EventArgs e)
        {
            String text = "Project make by:" +
                          "\n_ Nguyen Trung Hao - 15520199" +
                          "\n_ Nguyen Quang Hai - 15520187" +
                          "\n_ Bui Nguyen Hoang Anh - 15520012" +
                          "\n_ Phan The Anh - 15520027";
            // Show Dialog.
            MessageBox.Show(text, "Project OOAD", MessageBoxButtons.OK);

        }

        private void frmDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Display a MsgBox asking the user to save changes or abort.
            if (MessageBox.Show("Do you want close ?", "Convenient store application",
               MessageBoxButtons.YesNo) == DialogResult.No)
            {
                // Cancel the Closing event from closing the form.
                e.Cancel = true;
                // Can Call method to save file here...
            }
        }

    }
}
