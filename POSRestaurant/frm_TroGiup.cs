using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace POSRestaurant
{
    public partial class frm_TroGiup : Form
    {
        public frm_TroGiup()
        {
            InitializeComponent();
        }

        private void linklb_FB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linklb_FB.LinkVisited = true;
            Process.Start("https://www.facebook.com/qviet.dinh/");
        }

        private void frm_TroGiup_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }
    }
}
