using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.btnComputer.Click += btnComputer_Click;
        }

        void btnComputer_Click(object sender, EventArgs e)
        {
            try
            {
                string strHeight = this.txtHeight.Text;
                int yourHeight = int.Parse(strHeight);
                string strWeight = this.txtWeight.Text;
                int yourWeight = int.Parse(strWeight);

                double BMI = (yourWeight / Math.Pow(yourHeight,2)*10000);
                this.txtBMI.Text = BMI.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show(" loaddd........");
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
