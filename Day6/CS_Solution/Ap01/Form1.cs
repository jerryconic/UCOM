using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ap01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StreamWriter wr = new StreamWriter(@"C:\temp\test.txt");
            wr.Write(txtData.Text);
            wr.Close();
            MessageBox.Show("存檔成功", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            StreamReader rd = new StreamReader(@"C:\temp\test.txt");
            txtData.Text = rd.ReadToEnd();
            rd.Close();
        }
    }
}
