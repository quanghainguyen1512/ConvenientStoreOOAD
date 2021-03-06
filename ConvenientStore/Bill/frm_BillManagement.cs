﻿using ConvenientStore.BUS;
using ConvenientStore.DTO;
using ConvenientStore.ExportFile;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ConvenientStore
{
    public partial class frm_BillManagement : Form
    {
        private BillManagementBus bus;
        private List<BillManagementDto> billManagementDtos;

        private List<BillManagementDto> tempBillList;

        public frm_BillManagement()
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

            this.billManagementDtos = this.bus.GetAllBill();

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

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            if ("".Equals(txtCustomerName.Text.Trim()))
                return;

            txtBillCode.Text = "";
        }

        private void txtBillCode_TextChanged(object sender, EventArgs e)
        {
            if ("".Equals(txtBillCode.Text.Trim()))
                return;

            txtCustomerName.Text = "";
        }

        private void txtBillCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.tempBillList = this.billManagementDtos.Where(dto => dto.Code().Contains(txtBillCode.Text)).ToList();
                this.reloadDataGridView(this.tempBillList);
            }
        }

        private void txtCustomerName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.tempBillList = this.billManagementDtos.Where(dto => dto.CustomerName.Contains(txtCustomerName.Text)).ToList();
                this.reloadDataGridView(this.tempBillList);
            }
        }

        private void dgvListBills_DoubleClick(object sender, EventArgs e)
        {
            if (this.billManagementDtos.Count <= 0)
                return;

            if (this.dgvListBills.SelectedRows.Count == 0)
                return;

            string index = this.dgvListBills.SelectedRows[0].Cells[0].Value.ToString();

            BillManagementDto billDto = this.billManagementDtos[Convert.ToInt32(index) - 1];

            frm_BillDetail form = new frm_BillDetail(billDto);

            form.Show();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            ExportExcel export = new ExportExcel(this.dgvListBills, "Danh sách hóa đơn");
        }
    }
}
