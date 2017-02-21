using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathServiceTestApp1.MathService1;

namespace MathServiceTestApp1
{
    public partial class Frm1 : Form
    {
        public Frm1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            MathServiceClient msClient = new MathServiceClient();

            Int32 msNum1 = Convert.ToInt32(txtNum1.Text.Trim());
            Int32 msNum2 = Convert.ToInt32(txtNum2.Text.Trim());
            if (cboOperation.Text == "Add")
            {
                txtResult.Text = msClient.Add(msNum1, msNum2).ToString();
            }
            else if (cboOperation.Text == "Subtract")
            {
                txtResult.Text = msClient.Subtract(msNum1, msNum2).ToString();
            }
            else if (cboOperation.Text == "Multiply")
            {
                txtResult.Text = msClient.Multiply(msNum1, msNum2).ToString();
            }

            else if (cboOperation.Text == "Sin")
            {
                txtResult.Text = msClient.Sin(msNum1, msNum2).ToString();
            }

            else
            {
                txtResult.Text = msClient.Divide(msNum1, msNum2).ToString();
            }
            


        }
    }
}
