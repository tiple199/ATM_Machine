using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProject
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnBalanceInquiry_Click(object sender, EventArgs e)
        {
            Balance balance = new Balance();
            balance.Show();
            this.Hide();
        }

        private void btnCashWithdraw_Click(object sender, EventArgs e)
        {
            Withdraw withdraw = new Withdraw();
            withdraw.Show();
            this.Hide();
        }

        private void btnTransferMoney_Click(object sender, EventArgs e)
        {
            Trans b = new Trans();
            b.Show();
            this.Hide();
        }

        private void btnMiniStatement_Click(object sender, EventArgs e)
        {
            Mini m = new Mini();
            m.Show();
            this.Hide();
        }
    }
}
