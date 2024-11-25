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
    public partial class Withdraw : Form
    {
        public Withdraw()
        {
            InitializeComponent();
        }
        databaseDataContext db = new databaseDataContext();
        private void btn100000_Click(object sender, EventArgs e)
        {
            txtAmount.Text = btn100000.Text;
            txtAmount.ForeColor = Color.Black;
        }

        private void btn200000_Click(object sender, EventArgs e)
        {
            txtAmount.Text = btn200000.Text;
            txtAmount.ForeColor = Color.Black;
        }

        private void btn500000_Click(object sender, EventArgs e)
        {
            txtAmount.Text = btn500000.Text;
            txtAmount.ForeColor = Color.Black;
        }

        private void btn1000000_Click(object sender, EventArgs e)
        {
            txtAmount.Text = btn1000000.Text;
            txtAmount.ForeColor = Color.Black;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAmount.Text == "" || txtAmount.Text == "0000.00")
                {
                    MessageBox.Show("Bạn cần nhập số tiền trước khi rút!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int Amount = Convert.ToInt32(txtAmount.Text);
                    if (Amount <= Accounts.balance && Amount <= Machine.totalPrice && Amount % 50000 == 0 && Amount >= 100000)
                    {
                        int[] value_cash = { 500000, 200000, 100000, 50000 };
                        int[] count = { 0, 0, 0, 0 };
                        int[] machine_cash = { Machine.n500000, Machine.n200000, Machine.n100000, Machine.n50000 };
                        int remaining = Amount;
                        for (int i = 0; i < value_cash.Length; i++)
                        {
                            if (Amount < value_cash[i])
                            {
                                continue;
                            }
                            else
                            {
                                count[i] = Math.Min(remaining / value_cash[i], machine_cash[i]);
                                remaining -= count[i] * value_cash[i];
                            }

                        }
                        if (remaining == 0)
                        {
                            var atmMachine = db.AtmMachines.FirstOrDefault(x => x.MachineID == Machine.MachineID);
                            atmMachine.n500000 -= count[0];
                            atmMachine.n200000 -= count[1];
                            atmMachine.n100000 -= count[2];
                            atmMachine.n50000 -= count[3];
                            atmMachine.TotalCash -= Amount;


                            Machine.n500000 = Convert.ToInt32(atmMachine.n500000);
                            Machine.n200000 = Convert.ToInt32(atmMachine.n200000);
                            Machine.n100000 = Convert.ToInt32(atmMachine.n100000);
                            Machine.n50000 = Convert.ToInt32(atmMachine.n50000);
                            Machine.totalPrice = Convert.ToInt32(atmMachine.TotalCash);


                            // Xử lý chèn vào Transaction
                            Transaction tran = new Transaction();
                            tran.aFrom = Accounts.AccNo;
                            tran.Amount = Amount;
                            tran.Type = "WITHDRAW";
                            tran.bTo = String.Empty;
                            tran.Date = DateTime.Now.ToString().Split(' ')[0];
                            tran.Time = DateTime.Now.ToString().Split(' ')[1];
                            tran.MachineID = Machine.MachineID;

                            db.Transactions.InsertOnSubmit(tran);
                            // Xử lý cập nhật tiền

                            var balance = db.Accounts.FirstOrDefault(o => o.AccNo == Accounts.AccNo);
                            if (balance != null)
                            {
                                balance.Balance -= Amount;
                                Accounts.balance = Convert.ToInt32(balance.Balance);
                                db.SubmitChanges();
                                MessageBox.Show($"Rút tiền thành công!\nSố tiền: {Amount}\n500000: {count[0]} tờ\n200000: {count[1]} tờ\n100000: {count[2]} tờ\n50000: {count[3]} tờ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {

                            MessageBox.Show("Mấy không có đủ mệnh giá phù hợp");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Giá trị nhập không đúng hoặc máy ATM không đủ tiền", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Giá trị nhập vào bị lỗi", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Withdraw_Load(object sender, EventArgs e)
        {

        }

        private void pbReturnCard_Click(object sender, EventArgs e)
        {
            Landing_Page l = new Landing_Page();
            l.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Landing_Page l = new Landing_Page();
            l.Show();
            this.Hide();
        }
    }
}
