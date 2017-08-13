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
            try
            {
                Application.Exit();

                MessageBox.Show("The Application Exited Successfully! Good Bye.");


            }
            catch (Exception)
            {

                MessageBox.Show("Please click the exit button to exit the Page");
            }
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Stock_Products_Table myProduct = new Stock_Products_Table();
                myProduct.MdiParent = this;
                myProduct.Show();


            }
            catch (Exception)
            {

                MessageBox.Show("An error occured while loading the products table." +
                    " Click the products tab to load the products table");
            }
        }

        private void stockInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Stock_Inventory myStock_Inventory_DataBase = new Stock_Inventory();
                myStock_Inventory_DataBase.MdiParent = this;
                myStock_Inventory_DataBase.Show();


            }
            catch (Exception)
            {

                MessageBox.Show("Error in loading the Inventory Database. Please click on the Inventory tab ");
            }

        }

        private void stockReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Stock_Reports_Table myStock_Reports = new Stock_Reports_Table();
                myStock_Reports.MdiParent = this;
                myStock_Reports.Show();


            }
            catch (Exception)
            {

                MessageBox.Show("Unexpexted error in showing the reports. Click the Report tab once.");
            }
        }

        private void productsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Products_Receiving_Table myProducts_Table = new Products_Receiving_Table();
                myProducts_Table.MdiParent = this;
                myProducts_Table.Show();


            }
            catch (Exception)
            {

                MessageBox.Show("Cannot load the products table. Click the Product tab button to load the table.");
            }
        }

        private void stockInventoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Receiving_Stock_InventoryDataBaseTable myStock_InventoryDataBase = new Receiving_Stock_InventoryDataBaseTable();
                myStock_InventoryDataBase.MdiParent = this;
                myStock_InventoryDataBase.Show();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void stockReportsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                ReceivingStock_Reports_Table myStock_Reports = new ReceivingStock_Reports_Table();
                myStock_Reports.MdiParent = this;
                myStock_Reports.Show();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void stockInventoryToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                ShippingStock_InventoryDataBase_Table myShipping_InventoryDataBase
                   = new ShippingStock_InventoryDataBase_Table();
                myShipping_InventoryDataBase.MdiParent = this;
                myShipping_InventoryDataBase.Show();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void productsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                Shipping_Products_Table myProductsTable = new Shipping_Products_Table();
                myProductsTable.MdiParent = this;
                myProductsTable.Show();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void stockReportsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                Shipping_ReportsTable myReceivingReports = new Shipping_ReportsTable();
                myReceivingReports.MdiParent = this;
                myReceivingReports.Show();


            }
            catch (Exception)
            {

                MessageBox.Show("Error in loading the reports. Please confirm button click.");
            }
        }

        private void stockInventoryToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                Stock_QualityControlDataBase_Table myQC_DataBase = new Stock_QualityControlDataBase_Table();
                myQC_DataBase.MdiParent = this;
                myQC_DataBase.Show();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void productsToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                QualityControl_Products_Table myQC_ProductTable = new QualityControl_Products_Table();
                myQC_ProductTable.MdiParent = this;
                myQC_ProductTable.Show();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void stockReportsToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                QualityControl_ReportsTable myQC_ReportsTable = new QualityControl_ReportsTable();
                myQC_ReportsTable.MdiParent = this;
                myQC_ReportsTable.Show();


            }
            catch (Exception)
            {

                MessageBox.Show("System cannot load the Reports table. Please click on the reports tab.");
            }
        }

        private void stockDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void StockMainPage_Load(object sender, EventArgs e)
        {

        }

        private void receivingDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void freightCarrierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Freight_Carriers myFreightCarrriers = new Freight_Carriers();
                myFreightCarrriers.MdiParent = this;
                myFreightCarrriers.Show();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
