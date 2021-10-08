using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_420_CT2_AS
{
    public partial class Form0 : Form
    {
        public Form0()
        {
            InitializeComponent();
        }

        private void Form0_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString() == "OK")
            {
                Application.Exit();
            }
        }

        private void btnLottoMax_Click(object sender, EventArgs e)
        {
            var lottoMax = new Form1();
            lottoMax.Show();
        }

        private void btnLotto649_Click(object sender, EventArgs e)
        {
            var lotto649 = new Form2();
            lotto649.Show();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            var cal = new Form3();
            cal.Show();
        }

        private void btnMonEx_Click(object sender, EventArgs e)
        {
            var moneyEx = new Form4();
            moneyEx.Show();
        }

        private void btnTemCon_Click(object sender, EventArgs e)
        {
            var temCon = new Form5();
            temCon.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIPv4Val_Click(object sender, EventArgs e)
        {
            var ipv4Val = new Form6();
            ipv4Val.Show();
        }
    }
}
