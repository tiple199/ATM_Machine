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
    public partial class Mini : Form
    {
        public Mini()
        {
            InitializeComponent();
        }
        databaseDataContext db = new databaseDataContext();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Mini_Load(object sender, EventArgs e)
        {
            var data_statement = db.Transactions.Where((o => o.aFrom == Accounts.AccNo));
            if (data_statement.Any()) { 
                dataGridView1.DataSource = data_statement.ToList();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void pbReturnCard_Click(object sender, EventArgs e)
        {
            Landing_Page page = new Landing_Page();
            page.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Landing_Page page = new Landing_Page();
            page.Show();
            this.Hide();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (Accounts.balance > 5000)
                {
                    Transaction trans = new Transaction();
                    trans.Type = "DEDUCTION";
                    trans.Amount = 10;
                    trans.aFrom = Accounts.AccNo;
                    trans.bTo = String.Empty;
                    trans.Date = DateTime.Now.ToString().Split(' ')[0];
                    trans.Time = DateTime.Now.ToString().Split(' ')[1];
                    trans.MachineID = Machine.MachineID;
                    db.Transactions.InsertOnSubmit(trans);
                    db.SubmitChanges();


                    var balance = db.Accounts.FirstOrDefault(o => o.AccNo == Accounts.AccNo);
                    if (balance != null)
                    {
                        balance.Balance -= 5000;
                        Accounts.balance = Convert.ToInt32(balance.Balance.ToString());
                        db.SubmitChanges();
                        MessageBox.Show("Recipt Issued:)");
                    }

                }
                else
                {
                    MessageBox.Show("Tài khoản bạn cần phải có trên 5000 mới được in hóa đơn");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
