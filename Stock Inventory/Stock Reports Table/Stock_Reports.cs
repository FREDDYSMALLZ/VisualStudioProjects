using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Reports_Table
{
    public partial class Stock_Reports : Form
    {
        public Stock_Reports()
        {
            InitializeComponent();
        }

        private void stock_ReportsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stock_ReportsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stock_InventoryDataSet);

        }
    }
}
