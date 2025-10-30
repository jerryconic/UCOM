using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ap13
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            int n = e.KeyChar;
            txtASCII.Text = n.ToString();
        }

        private void txtB_KeyDown(object sender, KeyEventArgs e)
        {
            txtCode.Text = e.KeyCode.ToString();
        }

        private void txtUpper_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void txtLower_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToLower(e.KeyChar);
        }

        private void txtDigit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\x08') return;
            if (!char.IsDigit(e.KeyChar))
                e.KeyChar = '\0';
        }

        private void txtLetter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\x08') return;
            if (!char.IsLetter(e.KeyChar))
                e.KeyChar = '\0';
        }
    }
}
