using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Inventory_Management_system
{
    public partial class Log_in : Form
    {
        public Log_in()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Checks the username and password
            this.Hide(); //Hides the window after loging in
            StockMain main = new StockMain();
            main.Show();
        }

        private void Log_in_Load(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
