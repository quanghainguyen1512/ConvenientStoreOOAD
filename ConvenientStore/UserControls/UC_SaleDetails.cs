using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConvenientStore.Forms;

namespace ConvenientStore.UserControls
{
    public partial class UC_SaleDetails : UserControl
    {
        public UC_SaleDetails()
        {
            InitializeComponent();
        }

        private void btnAddSale_Click(object sender, EventArgs e)
        {
            using (frm_AddSale frmAddSale = new frm_AddSale())
            {
                frmAddSale.ShowDialog();
            }
        }
    }
}
