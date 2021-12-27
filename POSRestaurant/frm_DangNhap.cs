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

    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
        }
        #region
        string taiKhoan1 = "casang", taiKhoan2 = "catoi", taiKhoan3 = "quanly",
               matKhau1 = "123", matKhau2 = "456", matKhau3 = "000";
        #endregion


        //Lấy dữ liệu đăng nhập
        private void LoadAcc()
        {
            if (Properties.Settings.Default.Remem == "yes")
            {
                txt_TaiKhoan.Text = Properties.Settings.Default.Username;
                txt_MatKhau.Text = Properties.Settings.Default.Password;
                tsw_Remember.Checked = true;
            }
            else
                txt_TaiKhoan.Text = Properties.Settings.Default.Username;
        }

        //Lưu tài khoản 
        private void SaveAcc()
        {
            if (tsw_Remember.Checked==true)
            {
                Properties.Settings.Default.Username = txt_TaiKhoan.Text;
                Properties.Settings.Default.Password = txt_MatKhau.Text;
                Properties.Settings.Default.Remem = "yes";
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Username = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Remem = "no";
                Properties.Settings.Default.Save();
            }
        }

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {
            //Làm bóng mờ cho form 
            guna2ShadowForm1.SetShadowForm(this);
            LoadAcc();
        }
        private void bt_DangNhap_MouseClick(object sender, MouseEventArgs e)
        {          
            if (e.Button == MouseButtons.Left)
            {
                if (txt_TaiKhoan.Text == taiKhoan1 && txt_MatKhau.Text == matKhau1 ||
                    txt_TaiKhoan.Text == taiKhoan2 && txt_MatKhau.Text == matKhau2 ||
                    txt_TaiKhoan.Text == taiKhoan3 && txt_MatKhau.Text == matKhau3)
                {

                    SaveAcc();
                    this.Hide();
                    frm_TrangChu.caLamViec = txt_TaiKhoan.Text;
                    frm_Loading fm = new frm_Loading();
                    fm.Show();
                }
                else
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!"); 
            }
        }
        private void bt_Thoat_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DialogResult result =
               MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK) Application.Exit();
            }
        }
        private void frm_DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
