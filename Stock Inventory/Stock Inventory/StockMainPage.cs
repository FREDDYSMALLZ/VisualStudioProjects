using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Inventory
{
    public partial class StockMainPage : Form
    {
       

        public StockMainPage()
        {
            InitializeComponent();
        }

        private void StockMainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock_Products_Table myProduct = new Stock_Products_Table();
            myProduct.MdiParent = this;
            myProduct.Show();
        }

        private void stockInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock_Inventory myStock_Inventory_DataBase = new Stock_Inventory();
            myStock_Inventory_DataBase.MdiParent = this;
            myStock_Inventory_DataBase.Show();

        }

        private void stockReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock_Reports_Table myStock_Reports = new Stock_Reports_Table();
            myStock_Reports.MdiParent = this;
            myStock_Reports.Show();
        }

        private void productsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Products_Receiving_Table myProducts_Table = new Products_Receiving_Table();
            myProducts_Table.MdiParent = this;
            myProducts_Table.Show();
        }

        private void stockInventoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Receiving_Stock_InventoryDataBaseTable myStock_InventoryDataBase = new Receiving_Stock_InventoryDataBaseTable();
            myStock_InventoryDataBase.MdiParent = this;
            myStock_InventoryDataBase.Show();
        }

        private void stockReportsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReceivingStock_Reports_Table myStock_Reports = new ReceivingStock_Reports_Table();
            myStock_Reports.MdiParent = this;
            myStock_Reports.Show();
        }

        private void stockInventoryToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ShippingStock_InventoryDataBase_Table myShipping_InventoryDataBase
                = new ShippingStock_InventoryDataBase_Table();
            myShipping_InventoryDataBase.MdiParent = this;
            myShipping_InventoryDataBase.Show();
        }

        private void productsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Shipping_Products_Table myProductsTable = new Shipping_Products_Table();
            myProductsTable.MdiParent = this;
            myProductsTable.Show();
        }

        private void stockReportsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Shipping_ReportsTable myReceivingReports = new Shipping_ReportsTable();
            myReceivingReports.MdiParent = this;
            myReceivingReports.Show();
        }

        private void stockInventoryToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Stock_QualityControlDataBase_Table myQC_DataBase = new Stock_QualityControlDataBase_Table();
            myQC_DataBase.MdiParent = this;
            myQC_DataBase.Show();
        }

        private void productsToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            QualityControl_Products_Table myQC_ProductTable = new QualityControl_Products_Table();
            myQC_ProductTable.MdiParent = this;
            myQC_ProductTable.Show();
        }

        private void stockReportsToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            QualityControl_ReportsTable myQC_ReportsTable = new QualityControl_ReportsTable();
            myQC_ReportsTable.MdiParent = this;
            myQC_ReportsTable.Show();
        }
    }
}
