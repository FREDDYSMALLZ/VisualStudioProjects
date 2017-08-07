using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_15_Exercise_12
{
    public partial class ElectronicBankingSystem : Form
    {
        public ElectronicBankingSystem()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void accountBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.accountBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.account1);

        }

        private void ElectronicBankingSystem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'account1.Account' table. You can move, or remove it, as needed.
            this.accountTableAdapter.Fill(this.account1.Account);

        }
    }
}
