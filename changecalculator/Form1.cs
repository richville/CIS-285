using System;
using System.Windows.Forms;

namespace changecalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Event handler for the "Calculate" button
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Get the amount of change from the user input (textBox1)
            int changeAmount = int.Parse(textBox1.Text);

            // Calculate the number of quarters, dimes, nickels, and pennies
            int quarters = changeAmount / 25;
            changeAmount = changeAmount % 25;

            int dimes = changeAmount / 10;
            changeAmount = changeAmount % 10;

            int nickels = changeAmount / 5;
            changeAmount = changeAmount % 5;

            int pennies = changeAmount;

            // Display the result in the appropriate text boxes
            textBox2.Text = quarters.ToString();
            textBox3.Text = dimes.ToString();
            textBox4.Text = nickels.ToString();
            textBox5.Text = pennies.ToString();
        }

        // Event handler for the "Exit" button
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
