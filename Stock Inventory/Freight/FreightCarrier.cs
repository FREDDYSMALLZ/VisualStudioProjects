using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Freight
{
    public partial class FreightCarrier : Form
    {
        public FreightCarrier()
        {
            InitializeComponent();
        }

        private void freight_Carrier_TableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.freight_Carrier_TableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stock_InventoryDataSet);

        }

        private void FreightCarrier_Load(object sender, EventArgs e)
        {
            
            this.freight_Carrier_TableTableAdapter.Fill(this.stock_InventoryDataSet.Freight_Carrier_Table);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.freight_Carrier_TableBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.stock_InventoryDataSet);
                MessageBox.Show("Are you sure you want to Add new data?",
                                    "Click OK to add new record, NO to discard", MessageBoxButtons.YesNo);
                this.freight_Carrier_TableBindingSource.AddNew();//Adds a new row to the record and saves data to the table.
                
             

            }
            catch (Exception )
            {
                MessageBox.Show("The column cannot be empty. Please enter the freight number to continue.");
               
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                freight_Carrier_TableBindingSource.MovePrevious();// Moves to the previous selected record in the table.

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
                freight_Carrier_TableBindingSource.MoveNext(); // Moves to the next record on the table.

            }
            catch (Exception)
            {

                MessageBox.Show("End of record. Please enter new record.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                freight_Carrier_TableBindingSource.RemoveCurrent();// Deletes the selected record from the table.
                MessageBox.Show("Are you sure you want to delete the record",
                    "Click Yes to delete, NO to continue", MessageBoxButtons.YesNo);
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
