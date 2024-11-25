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
    public partial class Trans : Form
    {
        public Trans()
        {
            InitializeComponent();
        }
        databaseDataContext db = new databaseDataContext();
        private void label1_Click(object sender, EventArgs e)
        {
            Landing_Page l = new Landing_Page();
            l.Show();
            this.Hide();
        }

        private void Trans_Load(object sender, EventArgs e)
        {
            txtcurrentbalance.Text = Accounts.balance.ToString();
        }

        private void tbAccNo_MouseClick(object sender, MouseEventArgs e)
        {
            txtAccNo.Text = "";
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAmount_MouseClick(object sender, MouseEventArgs e)
        {
            txtAmount.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
            this.Hide();
        }

        private void pbReturnCard_Click(object sender, EventArgs e)
        {
            Landing_Page l = new Landing_Page();
            l.Show();
            this.Hide();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            try
            {
                string txtaccno = txtAccNo.Text;
                int amount = Convert.ToInt32(txtAmount.Text);
                var checkAccNo = db.Accounts.FirstOrDefault(o => o.AccNo == txtaccno);
                if (checkAccNo != null)
                {
                    if (amount < Accounts.balance && amount > 0)
                    {
                        // Chèn dữ liệu vào trấnction
                        Transaction trans = new Transaction();
                        trans.Type = "TRANSFER_MONEY";
                        trans.Amount = amount;
                        trans.aFrom = Accounts.AccNo;
                        trans.bTo = txtaccno;
                        trans.Date = DateTime.Now.ToString().Split(' ')[0];
                        trans.Time = DateTime.Now.ToString().Split(' ')[1];
                        trans.MachineID = Machine.MachineID;
                        db.Transactions.InsertOnSubmit(trans);

                        // Xử lý đối phương nhận được tiền
                        checkAccNo.Balance += amount;
                        // Xử lý mình giảm tiền
                        Accounts.balance -= amount;
                        var thisAccount = db.Accounts.FirstOrDefault(o => o.AccNo == Accounts.AccNo);
                        thisAccount.Balance = Accounts.balance;
                        db.SubmitChanges();
                        //Xử lý khi giao dịch xong 
                        DialogResult result = MessageBox.Show("Giao dịch thành công!, Bạn có muốn tiếp tục không?", "Thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == DialogResult.No)
                        {
                            new Dashboard().Show();
                            this.Hide();
                        }
                        else
                        {
                            txtAccNo.Text = "";
                            txtAmount.Text = "";
                            Trans t = new Trans();
                            t.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Số dư tài khoản của bạn không đủ!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Không tồn tại số tài khoản này!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Giá trị nhập vào không hợp lệ", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
