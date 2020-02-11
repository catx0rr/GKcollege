using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using zodiac;

namespace zodiac
{
    public partial class zodiacForm : Form
    {

        // Globals

        string fullName;
        string dateTimeValues;

        // Regular expression
        Regex alpha = new Regex("^[a-zA-Z \f\n\r\t\v]*$");

        public zodiacForm()
        {
            InitializeComponent();

            Car c = new Car("Honda");
            c.drive();


            string x = Car.FormatNumber("1000");
            
            Console.WriteLine(x);
        }

        private void zodiacForm_Load(object sender, EventArgs e)
        {
            // Initialize
            fullNameText.ForeColor = Color.Gray;
            fullNameText.Text = "Enter your name..";
        }

        private void dateTimePickerSelect_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerText.Text = Convert.ToString(dateTimePickerSelect.Value);
        }
    }
}
