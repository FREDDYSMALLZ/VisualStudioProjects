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
            this.customer_TableTableAdapter.Fill(this.stocInventoryDataSet.Customer_Table);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.customer_TableBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.stocInventoryDataSet);
                this.customer_TableBindingSource.AddNew();

            }
            catch (Exception)
            {
                MessageBox.Show("The Customer Id cannot be null. Please enter the Customer Id.");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            customer_TableBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            customer_TableBindingSource.MovePrevious();
        }
    }
}
