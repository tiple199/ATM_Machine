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
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }
        databaseDataContext db = new databaseDataContext();
        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string txtMachine_id = txtMachineNo.Text;
            var checkmachine = db.AtmMachines.FirstOrDefault(machine => machine.MachineID == txtMachine_id);

            if (checkmachine != null)
            {
                Machine.n500000 = Convert.ToInt32(checkmachine.n500000);
                Machine.n200000 = Convert.ToInt32(checkmachine.n200000);
                Machine.n100000 = Convert.ToInt32(checkmachine.n100000);
                Machine.n50000 = Convert.ToInt32(checkmachine.n50000);
                Machine.totalPrice = Convert.ToInt32(checkmachine.TotalCash);
                Machine.MachineID = txtMachine_id;

                Landing_Page l = new Landing_Page();
                l.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Mã cây chưa đúng!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StartScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
