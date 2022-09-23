using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_2__2nd__Attempt
{
    public partial class activity2Conversion : Form
    {
        public activity2Conversion()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            // Create variables
            double pounds;
            double ounces = 16;
            double total; 

            // Gather data from user
            pounds = double.Parse(userInputLbs.Text);

            // Perform conversion, lbs(16)
            total = pounds * ounces;

            // Display Result in totalOunces control
            totalOunces.Text = total.ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void userInputLbs_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
