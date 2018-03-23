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
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            int addTotal = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text);
            label1.Text = Convert.ToString(addTotal);

        }
    }
}
