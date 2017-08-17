using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockReports
{
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }

        private void stock_ReportsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stock_ReportsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stock_InventoryDataSet);

        }

        private void Stock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stock_InventoryDataSet.Stock_Reports' table. You can move, or remove it, as needed.
            this.stock_ReportsTableAdapter.Fill(this.stock_InventoryDataSet.Stock_Reports);

        }
    }
}
