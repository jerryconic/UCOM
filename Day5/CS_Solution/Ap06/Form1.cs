using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ap06
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int total = 0;
            if (rdoNo1.Checked)
                total += 95;
            else if (rdoNo2.Checked)
                total += 105;
            else if (rdoNo3.Checked)
                total += 120;

            if (chkCream.Checked)
                total += 15;

            if (chkPie.Checked)
                total += 25;

            txtTotal.Text = total.ToString();
        }
    }
}
