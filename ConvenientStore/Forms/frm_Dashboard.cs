using ConvenientStore.Helpers.Message;
using ConvenientStore.UserControls;
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



            frm_CreateBill form = new frm_CreateBill();
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.AutoScroll = true;
            this.pnForm.Controls.Add(form);
            form.Show();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            pnlHighlight.Height = btnBill.Height;
            pnlHighlight.Top = btnBill.Top;
            this.pnForm.Controls.Clear();

            frm_CreateBill form = new frm_CreateBill();
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.AutoScroll = true;
            this.pnForm.Controls.Add(form);
            form.Show();
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            pnlHighlight.Height = btnStore.Height;
            pnlHighlight.Top = btnStore.Top;
            this.pnForm.Controls.Clear();

            frm_ProductManagement form = new frm_ProductManagement();
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.AutoScroll = true;
            this.pnForm.Controls.Add(form);
            form.Show();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            pnlHighlight.Height = btnSale.Height;
            pnlHighlight.Top = btnSale.Top;
            this.pnForm.Controls.Clear();

            UC_SaleDetails uc = new UC_SaleDetails();
            uc.AutoScroll = true;
            this.pnForm.Controls.Add(uc);
        }

        private void btnContact_Click(object sender, EventArgs e)
        {


        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            pnlHighlight.Height = btnCustomer.Height;
            pnlHighlight.Top = btnCustomer.Top;
            this.pnForm.Controls.Clear();

            frm_CustomerManagement form = new frm_CustomerManagement();
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.AutoScroll = true;
            this.pnForm.Controls.Add(form);
            form.Show();

        }

        private void btnRollback_Click(object sender, EventArgs e)
        {



        }

        private void btnChart_Click(object sender, EventArgs e)
        {



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
            if (MessageBox.Show(MessageContent.CONFIRM_CLOSE_DASHBOARD, MessageTitle.APPLICATION_NAME,
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnEditBill_Click(object sender, EventArgs e)
        {
                
        }
    }
}
