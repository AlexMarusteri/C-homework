using System;
using System.Data;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                string expression = txtExpression.Text;
                var result = new DataTable().Compute(expression, null);
                lblResult.Text = "Result: " + result.ToString();
            }
            catch
            {
                lblResult.Text = "Invalid expression!";
            }
        }
    }
}