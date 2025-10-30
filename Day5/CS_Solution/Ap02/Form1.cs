namespace Ap02;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        decimal a, b;
        decimal.TryParse(txtA.Text, out a);
        decimal.TryParse(txtB.Text, out b);
        txtAns.Text = (a + b).ToString();
    }

    private void btnSub_Click(object sender, EventArgs e)
    {
        decimal a, b;
        decimal.TryParse(txtA.Text, out a);
        decimal.TryParse(txtB.Text, out b);
        txtAns.Text = (a - b).ToString();
    }

    private void btnMul_Click(object sender, EventArgs e)
    {
        decimal a, b;
        decimal.TryParse(txtA.Text, out a);
        decimal.TryParse(txtB.Text, out b);
        txtAns.Text = (a * b).ToString();
    }

    private void btnDiv_Click(object sender, EventArgs e)
    {
        decimal a, b;
        decimal.TryParse(txtA.Text, out a);
        decimal.TryParse(txtB.Text, out b);
        txtAns.Text = (a / b).ToString();
    }
}
