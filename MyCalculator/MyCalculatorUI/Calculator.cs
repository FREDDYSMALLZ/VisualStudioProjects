using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculatorUI
{
    public partial class Calculator : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isTheOperationPerformed = false;
        public Calculator()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBoxResult.Text == "0")||(isTheOperationPerformed))
                textBoxResult.Clear();

            isTheOperationPerformed = false;
            Button myButton = (Button)sender;
            textBoxResult.Text = textBoxResult.Text + myButton.Text; 
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button myButton = (Button)sender;
            operationPerformed = myButton.Text;
            resultValue = Double.Parse(textBoxResult.Text);
            isTheOperationPerformed = true;
        }

        private void Clear_Entry_Button_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
            resultValue = 0;
        }

        private void Equal_Button_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBoxResult.Text = (resultValue + Double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "-":
                    textBoxResult.Text = (resultValue - Double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "*":
                    textBoxResult.Text = (resultValue * Double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "/":
                    textBoxResult.Text = (resultValue / Double.Parse(textBoxResult.Text)).ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
