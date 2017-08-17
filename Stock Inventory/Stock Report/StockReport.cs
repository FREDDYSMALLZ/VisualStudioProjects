using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Report
{
    public partial class StockReport : Form
    {
        public StockReport()
        {
            InitializeComponent();
        }

        private void stock_ReportsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stock_ReportsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stock_InventoryDataSet);

        }

        private void StockReport_Load(object sender, EventArgs e)
        {
          //this.stock_ReportsTableAdapter.Fill(this.stock_InventoryDataSet.Stock_Reports);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.stock_ReportsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.stock_InventoryDataSet);
                MessageBox.Show("Are you sure you want to add new data to the table?");
                stock_ReportsBindingSource.AddNew(); // Adds new Record to the Data table 

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                stock_ReportsBindingSource.MoveNext(); // Moves the cursor to the next data on the line.
            }
            catch (Exception)
            {

                MessageBox.Show("Error in moving to the next data field. Please enter data to continue.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                stock_ReportsBindingSource.MovePrevious(); // Moves the cursor selector to the prevous data

            }
            catch (Exception)
            {

                MessageBox.Show("The Product number colum cannot be null. Please enter the Product number to contonue. ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Are you sure you want to delete the data from the table?");
                stock_ReportsBindingSource.RemoveCurrent(); //Deletes the current data that is saved on the table.

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
