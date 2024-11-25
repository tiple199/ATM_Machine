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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        databaseDataContext db = new databaseDataContext();
        private void txtCardNo_MouseClick(object sender, MouseEventArgs e)
        {
            txtCardNo.Text = "";
        }

        private void txtPin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPin_MouseClick(object sender, MouseEventArgs e)
        {
            txtPin.Text = "";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string cardNo = txtCardNo.Text;
            string Pin = txtPin.Text;
            var checkCardNo = db.Accounts.FirstOrDefault(Card => Card.AccNo == cardNo);

            if (checkCardNo != null)
            {

                if (checkCardNo.PIN == Pin)
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Accounts.AccNo = cardNo;
                    Accounts.balance = Convert.ToInt32(checkCardNo.Balance);
                    Accounts.AtmStatus = checkCardNo.AtmStatus;
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Mã PIN không chính xác!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ID thẻ không tồn tại!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
