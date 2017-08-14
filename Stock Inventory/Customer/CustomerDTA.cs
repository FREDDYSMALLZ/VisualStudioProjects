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
            // TODO: This line of code loads data into the 'stock_InventoryDataSet.Customer_Table' table. You can move, or remove it, as needed.
            this.customer_TableTableAdapter.Fill(this.stock_InventoryDataSet.Customer_Table);

        }
    }
}
