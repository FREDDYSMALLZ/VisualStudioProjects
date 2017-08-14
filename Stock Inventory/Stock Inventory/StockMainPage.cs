using Customer;
using Freight;
using Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Inventory
{
    public partial class StockMainPage : Form
    {
       

        public StockMainPage()
        {
            InitializeComponent();
        }

        private void StockMainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            MessageBox.Show("Please click the OK button to exit the application.");
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                ProductsTBL myProducts = new ProductsTBL();
                myProducts.MdiParent = this;
                MessageBox.Show("The product table was loaded Successfully. Press Ok. to Continue.");
                myProducts.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void stockInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ProductsTBL myProducts = new ProductsTBL();
                myProducts.MdiParent = this;
                MessageBox.Show("The product table was loaded Successfully. Press Ok. to Continue.");
                myProducts.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void stockReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void productsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                ProductsTBL myProducts = new ProductsTBL();
                myProducts.MdiParent = this;
                MessageBox.Show("The product table was loaded Successfully. Press Ok. to Continue.");
                myProducts.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void stockInventoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                ProductsTBL myProducts = new ProductsTBL();
                myProducts.MdiParent = this;
                MessageBox.Show("The product table was loaded Successfully. Press Ok. to Continue.");
                myProducts.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void stockReportsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
           
        }

        private void stockInventoryToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                ProductsTBL myProducts = new ProductsTBL();
                myProducts.MdiParent = this;
                MessageBox.Show("The product table was loaded Successfully. Press Ok. to Continue.");
                myProducts.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void productsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                ProductsTBL myProducts = new ProductsTBL();
                myProducts.MdiParent = this;
                MessageBox.Show("The product table was loaded Successfully. Press Ok. to Continue.");
                myProducts.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void stockReportsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
        }

        private void stockInventoryToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                ProductsTBL myProducts = new ProductsTBL();
                myProducts.MdiParent = this;
                MessageBox.Show("The product table was loaded Successfully. Press Ok. to Continue.");
                myProducts.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void productsToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                ProductsTBL myProducts = new ProductsTBL();
                myProducts.MdiParent = this;
                MessageBox.Show("The product table was loaded Successfully. Press Ok. to Continue.");
                myProducts.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void stockReportsToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            
           
        }

        private void freightCarriersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FreightCarrier myCarrier = new FreightCarrier();
                myCarrier.MdiParent = this;
                MessageBox.Show("The Freight Carrier Data was loaded successfully. Please press OK. to continue.");
                myCarrier.Show();

            }
            catch (Exception)
            {

                MessageBox.Show("Error Occured while loading the fright table. Please click the freight tab once.");

            }
        }

        private void freightCarrierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FreightCarrier myCarrier = new FreightCarrier();
                myCarrier.MdiParent = this;
                MessageBox.Show("The Freight Carrier Data was loaded successfully. Please press OK. to continue.");
                myCarrier.Show();

            }
            catch (Exception)
            {

                MessageBox.Show("Error Occured while loading the fright table. Please click the freight tab once.");

            }
        }

        private void freightCarrierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                FreightCarrier myCarrier = new FreightCarrier();
                myCarrier.MdiParent = this;
                MessageBox.Show("The Freight Carrier Data was loaded successfully. Please press OK. to continue.");
                myCarrier.Show();

            }
            catch (Exception)
            {

                MessageBox.Show("Error Occured while loading the fright table. Please click the freight tab once.");

            }
        }

        private void freightCarrierToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                FreightCarrier myCarrier = new FreightCarrier();
                MessageBox.Show("The Freight Carrier Data was loaded successfully. Please press OK. to continue.");
                myCarrier.MdiParent = this;
                myCarrier.Show();

            }
            catch (Exception)
            {

                MessageBox.Show("Error Occured while loading the fright table. Please click the freight tab once.");

            }
        }

        private void customerDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerDTA myCustomer = new CustomerDTA();
                myCustomer.MdiParent = this;

                MessageBox.Show("The Customer Data was Loaded successfully. Press Ok. to view Data.");
                myCustomer.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void customerDataToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerDTA myCustomer = new CustomerDTA();
                myCustomer.MdiParent = this;

                MessageBox.Show("The Customer Data was Loaded successfully. Press Ok. to view Data.");
                myCustomer.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void customerDataToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerDTA myCustomer = new CustomerDTA();
                myCustomer.MdiParent = this;

                MessageBox.Show("The Customer Data was Loaded successfully. Press Ok. to view Data.");
                myCustomer.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void customerDataToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerDTA myCustomer = new CustomerDTA();
                myCustomer.MdiParent = this;

                MessageBox.Show("The Customer Data was Loaded successfully. Press Ok. to view Data.");
                myCustomer.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
