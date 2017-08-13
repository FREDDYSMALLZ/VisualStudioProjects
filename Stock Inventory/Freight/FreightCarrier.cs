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
                this.freight_Carrier_TableBindingSource.AddNew();
             

            }
            catch (Exception )
            {
                MessageBox.Show("The column cannot be empty. Please enter the freight number to continue.");
               
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            freight_Carrier_TableBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            freight_Carrier_TableBindingSource.MoveNext();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
