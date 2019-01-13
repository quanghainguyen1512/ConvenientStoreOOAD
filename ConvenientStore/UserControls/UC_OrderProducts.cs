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
    public partial class UC_OrderProducts : UserControl
    {
        public UC_OrderProducts()
        {
            InitializeComponent();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            using (frm_AddOrderProducts frm = new frm_AddOrderProducts())
            {
                frm.ShowDialog();
            }

            //using (frm_EditOrderProduct frm = new frm_EditOrderProduct())
            //{
            //    frm.ShowDialog();
            //}
        }
    }
}
