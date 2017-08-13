using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Stock_Inventory
{
    public partial class Login : Form
    {
        public Login()
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
            /* SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 
                   C:\Users\Fredrick O Ondieki\Desktop\LoginDB.mdf; Integrated Security = 
                      True; Connect Timeout = 30; User Instance=True;");
             SqlDataAdapter sqlAdapter = new SqlDataAdapter("Select Count (*) From Login where Username='"
                 + textBox1.Text + " ' and Password='" + textBox2.Text + "' ", connection);
             DataTable myDataTable = new DataTable();
             sqlAdapter.Fill(myDataTable);
             */
            /*if (myDataTable.Rows[0][0].ToString == "1")
            {
                 this.Hide();
                 StockMainPage main = new StockMainPage();
                 main.Show();
              }
             else
             {
           MessageBox.Show("Incorect Username and Password. Please Enter a Valid Log in Id.");
           */
            

            var Username = "BlueGroupCST117";
            var Password = "Welcome@123";

            if (Username== textBox1.Text && Password==textBox2.Text)
            {
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;

                MessageBox.Show("Welcome to Stock Inventory Management Systems. Please press the OK Button to continue.");

                this.Hide();
                StockMainPage main = new StockMainPage();
                main.Show();

            }
            else
            {
                MessageBox.Show("Incorrect Username and Password. Please Enter a Valid Log in Id.");
          }
            

        }
        }
    }

