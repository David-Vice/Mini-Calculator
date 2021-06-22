using System;
using System.Windows.Forms;
namespace WinForm_app7
{
    public partial class Form1 : Form
    {
        double result;
        public Form1()
        {
            InitializeComponent();
        }
        private void num_Click(object sender, EventArgs e)
        {
            partial.Text += (sender as Button).Text.ToString();
        }
        private void elem_Click(object sender, EventArgs e)
        {
            if (full.Text.Length == 0)
            {
                full.Text += partial.Text;
                result = double.Parse(partial.Text);
            }
            else if (partial.Text.Length > 0 && symbol.Text.Length > 0 && full.Text.Length > 0)
            {
                if(symbol.Text != "=") full.Text += " " + symbol.Text + " " + partial.Text;
                if (symbol.Text == "+") result += double.Parse(partial.Text);
                else if (symbol.Text == "-") result -= double.Parse(partial.Text);
                else if (symbol.Text == "x") result *= double.Parse(partial.Text);
                else if (symbol.Text == "/") result /= double.Parse(partial.Text);
            }
            symbol.Text = (sender as Button).Text;
            if(symbol.Text == "=")
            {
                partial.Text = result.ToString();
                return;
            }
            partial.Text = "";
        }
        private void del_Click(object sender, EventArgs e)
        {
            if(partial.Text.Length>0)
            partial.Text = partial.Text.Remove(partial.Text.Length - 1);
        }
        private void c_Click(object sender, EventArgs e)
        {
            partial.Text = "";
            full.Text = "";
            symbol.Text = "";
        }
    }
}