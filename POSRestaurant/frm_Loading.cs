using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSRestaurant
{
    public partial class frm_Loading : Form
    {
        public string tenDangNhap;
        public frm_Loading()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (guna2CircleProgressBar1.Value == 100)
            {
                timer1.Stop();
                this.Hide();
                frm_TrangChu fm = new frm_TrangChu();
                fm.Show();
            }
            else
            {
                guna2CircleProgressBar1.Value += 1;
                lb_So.Text = (Convert.ToInt32(lb_So.Text) + 1).ToString();
            }
        }

        private void frm_Loading_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            timer1.Start();
        }
    }
}
