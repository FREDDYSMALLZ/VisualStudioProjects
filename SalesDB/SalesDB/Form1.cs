using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void customer_TableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customer_TableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.customerDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customerDataSet.Customer_Table' table. You can move, or remove it, as needed.
            this.customer_TableTableAdapter.Fill(this.customerDataSet.Customer_Table);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
