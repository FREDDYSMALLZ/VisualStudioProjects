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
    public partial class Freight_Carriers : Form
    {
        public Freight_Carriers()
        {
            InitializeComponent();
        }

        private void Freight_Carriers_Load(object sender, EventArgs e)
        {
            
            this.freight_Carrier_TableTableAdapter.Fill(this.stock_InventoryDataSet.Freight_Carrier_Table);
            this.freight_Carrier_TableTableAdapter.Fill(this.stock_InventoryDataSet.Freight_Carrier_Table);

        }

        private void freight_Carrier_TableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.freight_Carrier_TableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stock_InventoryDataSet);

        }

        private void freight_Carrier_TableBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.freight_Carrier_TableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stock_InventoryDataSet);

        }
    }
}
