using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Products_Table
{
    public partial class Products_Table : Form
    {
        public Products_Table()
        {
            InitializeComponent();
        }

        private void products_TableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.products_TableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stock_InventoryDataSet);

        }

        private void Products_Table_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stock_InventoryDataSet.Products_Table' table. You can move, or remove it, as needed.
            this.products_TableTableAdapter.Fill(this.stock_InventoryDataSet.Products_Table);

        }
    }
}
