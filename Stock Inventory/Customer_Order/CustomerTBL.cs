using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer_Order
{
    public partial class CustomerTBL : Form
    {
        public CustomerTBL()
        {
            InitializeComponent();
        }

        private void customer_OrdersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customer_OrdersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stock_InventoryDataSet);

        }

        private void CustomerTBL_Load(object sender, EventArgs e)
        {
            
           //this.customer_OrdersTableAdapter.Fill(this.stock_InventoryDataSet.Customer_Orders);

        }
    }
}
