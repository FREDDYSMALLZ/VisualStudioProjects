using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Products
{
    public partial class ProductsTBL : Form
    {
        public ProductsTBL()
        {
            InitializeComponent();
        }

        private void customer_TableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customer_TableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stocInventoryDataSet);

        }

        private void ProductsTBL_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stocInventoryDataSet.Products_Table' table. You can move, or remove it, as needed.
            this.products_TableTableAdapter.Fill(this.stocInventoryDataSet.Products_Table);
            this.customer_TableTableAdapter.Fill(this.stocInventoryDataSet.Customer_Table);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.customer_TableBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.stocInventoryDataSet);
                MessageBox.Show("Are you sure you want to Add new data?",
                    "Click OK to add new record, NO to discard", MessageBoxButtons.YesNo);
                this.customer_TableBindingSource.AddNew(); // Adds new new data to the table and as well saves the data.

               

            }
            catch (Exception)
            {
                MessageBox.Show("The Customer Id cannot be null. Please enter the Customer Id.");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                customer_TableBindingSource.MoveNext(); // Moves to the table selcter to the next item on the table.

            }
            catch (Exception)
            {

                MessageBox.Show("End of record. Please click on previous button to view the last record.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                customer_TableBindingSource.MovePrevious();// Moves the table selector to the previous item on the list.

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
                customer_TableBindingSource.RemoveCurrent(); // Deletes the current selected data from the table.
                MessageBox.Show("Are you sure you want to delete the selected data from the table?",
                    "Click OK to delete,NO to continue",MessageBoxButtons.YesNo); 

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
