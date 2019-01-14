using ConvenientStore.BUS;
using ConvenientStore.DTO;
using ConvenientStore.ExportFile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvenientStore.Bill
{
    public partial class frm_DelayBill : Form
    {

        public BillManagementDto BillManagementDto { get; set; }

        private BillManagementBus bus;
        private List<BillManagementDto> billManagementDtos;

        private List<BillManagementDto> tempBillList;

        public frm_DelayBill()
        {
            InitializeComponent();
            this.initForm();
        }

        private void initForm()
        {
            txtCustomerName.Text = "";
            txtBillCode.Text = "";


            this.bus = new BillManagementBus();
            this.billManagementDtos = new List<BillManagementDto>();

            this.billManagementDtos = this.bus.GetAllDelayBill();

            this.reloadDataGridView(this.billManagementDtos);

            this.tempBillList = this.billManagementDtos;
        }

        private void reloadDataGridView(List<BillManagementDto> lists)
        {
            this.dgvListBills.Rows.Clear();

            for (int i = 0; i < lists.Count; i++)
            {
                this.billManagementDtos[i].Index = (i + 1).ToString();
                this.dgvListBills.Rows.Add(i + 1, lists[i].Code(), lists[i].CustomerName,
                    lists[i].CreateDate, lists[i].Total);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.BillManagementDto = null;
            this.Close();
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            if ("".Equals(txtCustomerName.Text.Trim()))
                return;

            txtBillCode.Text = "";
        }

        private void txtCustomerName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.tempBillList = this.billManagementDtos.Where(dto => dto.CustomerName.Contains(txtCustomerName.Text)).ToList();
                this.reloadDataGridView(this.tempBillList);
            }
        }

        private void txtBillCode_TextChanged(object sender, EventArgs e)
        {
            if ("".Equals(txtBillCode.Text.Trim()))
                return;

            txtCustomerName.Text = "";
        }

        private void txtBillCode_Enter(object sender, EventArgs e)
        {

        }

        private void dgvListBills_DoubleClick(object sender, EventArgs e)
        {
            if (this.billManagementDtos.Count <= 0)
                return;

            if (this.dgvListBills.SelectedRows.Count == 0)
                return;

            string index = this.dgvListBills.SelectedRows[0].Cells[0].Value.ToString();

            this.BillManagementDto = this.billManagementDtos[Convert.ToInt32(index) - 1];


            this.Close();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            ExportExcel excel = new ExportExcel(dgvListBills, "Danh sách hóa đơn bị hoãn");
        }

        private void txtBillCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.tempBillList = this.billManagementDtos.Where(dto => dto.Code().Contains(txtBillCode.Text)).ToList();
                this.reloadDataGridView(this.tempBillList);
            }
        }
    }
}
