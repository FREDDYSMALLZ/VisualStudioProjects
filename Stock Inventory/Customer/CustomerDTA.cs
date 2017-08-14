using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer
{
    public partial class CustomerDTA : Form
    {
        public CustomerDTA()
        {
            InitializeComponent();
        }

        private void customer_TableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customer_TableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stock_InventoryDataSet);

        }

        private void CustomerDTA_Load(object sender, EventArgs e)
        {
            this.customer_TableTableAdapter.Fill(this.stock_InventoryDataSet.Customer_Table);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.customer_TableBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.stock_InventoryDataSet);
                MessageBox.Show("Are you sure you want to add new Data?", "Click OK to add new record, NO to discard"
                    , MessageBoxButtons.YesNo);
                this.customer_TableBindingSource.AddNew();// Adds new record data to the table
                MessageBox.Show("New Data is saved Successfully. Click OK. to continue.");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                customer_TableBindingSource.MovePrevious(); //Moves the cusror to the previous record for selection

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                customer_TableBindingSource.RemoveCurrent(); // Deletes the entire record from the table
                MessageBox.Show("Are you sure you want to delete the record",
                    "Click Yes to delete, NO to continue", MessageBoxButtons.YesNo);


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
                customer_TableBindingSource.MoveNext(); //Highlights the next recoerd in the table

            }
            catch (Exception)
            {

                MessageBox.Show("End of record. Please enter new record or " +
                    "click the previous button to view the previous record.");
            }
        }
    }
}
