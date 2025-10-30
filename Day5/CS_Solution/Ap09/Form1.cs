using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ap09
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //boxing => unboxing
        //sender: 事件發送者
        //e: 事件參數
        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            MessageBox.Show($"You clicked {btn.Text}!");
        }
    }
}
