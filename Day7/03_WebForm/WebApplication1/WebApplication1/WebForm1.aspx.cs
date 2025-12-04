using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            decimal a, b;
            decimal.TryParse(txtA.Text, out a);
            decimal.TryParse(txtB.Text, out b);
            txtAns.Text = (a + b).ToString();
        }

        protected void btnSub_Click(object sender, EventArgs e)
        {
            decimal a, b;
            decimal.TryParse(txtA.Text, out a);
            decimal.TryParse(txtB.Text, out b);
            txtAns.Text = (a - b).ToString();

        }

        protected void btnMul_Click(object sender, EventArgs e)
        {
            decimal a, b;
            decimal.TryParse(txtA.Text, out a);
            decimal.TryParse(txtB.Text, out b);
            txtAns.Text = (a * b).ToString();

        }

        protected void btnDiv_Click(object sender, EventArgs e)
        {
            decimal a, b;
            decimal.TryParse(txtA.Text, out a);
            decimal.TryParse(txtB.Text, out b);
            txtAns.Text = (a / b).ToString();

        }
    }
}