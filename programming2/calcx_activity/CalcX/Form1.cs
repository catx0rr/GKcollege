using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcX
{
    public partial class calculator : Form
    {

        // Globals
        int numChar;
        double value = 0;
        string operation;
        bool isPressed = false;

        public calculator()
        {
            InitializeComponent();
            MaximizeBox = false;
            screenText.Enabled = false;
        }

        private void clearBtn_click(object sender, EventArgs e)
        {
            screenText.Text = "0";
            calculationLabel.Text = String.Empty;
            isPressed = false;
        }

        private void backSpaceBtn_click(object sender, EventArgs e)
        {
            if (screenText.TextLength == 0)
            {
                screenText.Text = "0";
            }
            numChar = screenText.Text.Length;
            screenText.Text = screenText.Text.Substring(0, numChar - 1);
        }

        private void numButton_click(object sender, EventArgs e)
        {
            // Check if 0 and operators is already pressed
            if ((screenText.Text == "0") || (screenText.Text == "00") || (isPressed))
            {
                screenText.Clear();
                isPressed = false;
            }

            // Show pressed button on textbox
            Button numButton = (Button)sender;
            screenText.Text = screenText.Text + numButton.Text;
        }
        private void opButton_click(object sender, EventArgs e)
        {
            Button opButton = (Button)sender;
            operation = opButton.Text;
            value = Double.Parse(screenText.Text);
            isPressed = true;
            calculationLabel.Text = value.ToString() + " " + operation;
        }

        private void equalsBtn_click(object sender, EventArgs e)
        {
            calculationLabel.Text = String.Empty;
            isPressed = false;
            
            // Check value of the operator
            switch (operation)
            {
                case "+":
                    screenText.Text = (value + Double.Parse(screenText.Text)).ToString();
                    break;
                case "-":
                    screenText.Text = (value - Double.Parse(screenText.Text)).ToString();
                    break;
                case "*":
                    screenText.Text = (value * Double.Parse(screenText.Text)).ToString();
                    break;
                case "/":
                    screenText.Text = (value / Double.Parse(screenText.Text)).ToString();
                    break;
                default:
                    break;
            }
            
        }
    }
}
