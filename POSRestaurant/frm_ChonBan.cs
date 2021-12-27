using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace POSRestaurant
{
    public partial class frm_ChonBan : Form
    {
        public int soBan;
        public frm_ChonBan()
        {
            InitializeComponent();
        }
        
        private void container(object form)
        {
            if (pnl_containerMain.Controls.Count > 0) pnl_containerMain.Controls.Clear();

            Form fm = form as Form; //as la kieu ep doi tuong ve du lieu cua minh
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            pnl_containerMain.Controls.Add(fm);
            fm.Show();
        }
        private void bt_Ban1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Guna2Button b = (Guna2Button)sender;
                soBan = Int32.Parse(b.Text);
                frm_GoiMon fm = new frm_GoiMon(soBan);
                container(fm);
            }
        }
    }
}
