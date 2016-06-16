using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // Code runs at startup.

            // Initally selects the top radio box.
            op_plus.Select();

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

            // Function is called on pressing button 'Clear'.
            // Clears the window back to it's original state.

            // Resets the two text boxes to have nothing in.
            tb_n1.Text = "";
            tb_n2.Text = "";

            // Selects the top radio box.
            op_plus.Select();

        }

        private void btn_calc_Click(object sender, EventArgs e)
        {

            // Function is called on pressing button 'Calculate'.
            // Calculates the answer using the numbers given and radio box selected.

            // Copies the user's string input to string variables.
            string n1str = tb_n1.Text;
            string n2str = tb_n2.Text;

            // Creates two integer variables.
            int n1;
            int n2;

            // Tries to parse the first input as an integer.
            bool n1isnum = int.TryParse(n1str, out n1);
            if (n1isnum)
            {
                // Prints out to the console, this is a debug feature.
                Console.WriteLine("Parse Successful");
            }
            else
            {
                // Prints out to the console, this is a debug feature.
                Console.WriteLine("Parse Not Successful");
                MessageBox.Show("Error: First number is not a number.");
            }

            // Tries to parse the second input as an integer.
            bool n2isnum = int.TryParse(n2str, out n2);
            if (n2isnum)
            {
                // Prints out to the console, this is a debug feature.
                Console.WriteLine("Parse Successful");
            }
            else
            {
                // Prints out to the console, this is a debug feature.
                Console.WriteLine("Parse Not Successful");
                MessageBox.Show("Error: Second number is not a number.");
            }

            // Code is executed if the radio button for plus is selected.
            if (op_plus.Checked)
            {

                // Calculates the correct answer
                int ans = n1 + n2;

                // Displays the answer.
                MessageBox.Show("The answer is " + ans.ToString());
                txt_lastans.Text = "Last answer: " + ans.ToString();

            }

            // Code is executed if the radio button for minus is selected.
            if (op_minus.Checked)
            {

                // Calculates the correct answer
                int ans = n1 - n2;

                // Displays the answer.
                MessageBox.Show("The answer is " + ans.ToString());
                txt_lastans.Text = "Last answer: " + ans.ToString();

            }

            // Code is executed if the radio button for times is selected.
            if (op_times.Checked)
            {

                // Calculates the correct answer
                int ans = n1 * n2;

                // Displays the answer.
                MessageBox.Show("The answer is " + ans.ToString());
                txt_lastans.Text = "Last answer: " + ans.ToString();

            }

            // Code is executed if the radio button for divide is selected.
            if (op_divide.Checked)
            {

                // Calculates the correct answer
                int ans = n1 / n2;

                // Displays the answer.
                MessageBox.Show("The answer is " + ans.ToString());
                txt_lastans.Text = "Last answer: " + ans.ToString();

            }
        }
    }
}
