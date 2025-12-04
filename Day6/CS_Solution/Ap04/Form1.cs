using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ap04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 開新檔案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtData.Clear();
        }

        private void 離開ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void 開啟舊檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                StreamReader rd = new StreamReader(dlgOpen.FileName);
                txtData.Text = rd.ReadToEnd();
                rd.Close();
            }
        }

        private void 另存新檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                StreamWriter wr = new StreamWriter(dlgSave.FileName);
                wr.Write(txtData.Text);
                wr.Close();
                MessageBox.Show("存檔成功", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void mnuForeColor_Click(object sender, EventArgs e)
        {
            if (dlgColor.ShowDialog() == DialogResult.OK)
                txtData.ForeColor = dlgColor.Color;
        }

        private void mnuBackColor_Click(object sender, EventArgs e)
        {
            if (dlgColor.ShowDialog() == DialogResult.OK)
                txtData.BackColor = dlgColor.Color;
        }

        private void mnuFont_Click(object sender, EventArgs e)
        {
            if (dlgFont.ShowDialog() == DialogResult.OK)
                txtData.Font = dlgFont.Font;
        }
    }
}
