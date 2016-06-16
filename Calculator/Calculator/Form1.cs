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

        private void btn_clear_Click(object sender, EventArgs e)
        {

            // Function is called on pressing button 'Clear'.
            // Clears the window back to it's original state.
            tb_n1.Text = "";
            tb_n2.Text = "";
            op_plus.Select();

        }
    }
}
