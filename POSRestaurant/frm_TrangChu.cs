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
    public partial class frm_TrangChu : Form
    {
        //Khởi tạo biến để nhận giá trị từ form đăng nhập
        public static string caLamViec;
        public frm_TrangChu()
        {
            InitializeComponent();
        }

        //Tạo hàm gọi form vào panel
        private void container(object form)
        {
            if (pnl_container.Controls.Count > 0) pnl_container.Controls.Clear();

            Form fm = form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            pnl_container.Controls.Add(fm);
            fm.Show();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_ThoiGian.Text = DateTime.Now.ToLongTimeString();
            lb_Ngay.Text = DateTime.Now.ToShortDateString();
        }
        private void frm_TrangChu_Load(object sender, EventArgs e)
        {
            lb_ThoiGian.Text = DateTime.Now.ToLongTimeString();
            lb_Ngay.Text = DateTime.Now.ToShortDateString();
            guna2ShadowForm1.SetShadowForm(this);
            lb_HienThi.Text = "Phục vụ tại chỗ";
            pic_HienThi.Image = Properties.Resources.table;
            frm_ChonBan fm = new frm_ChonBan();
            container(fm);
            this.bt_TaiCho.FillColor = Color.FromArgb(94, 148, 255);
            this.bt_TaiCho.FillColor2 = Color.FromArgb(255, 77, 165);
            this.bt_TaiCho.ForeColor = Color.White;

            if (caLamViec == "casang")
            {
                lb_CaLV.Text = "Ca sáng";
                lb_ChucVu.Text = "Nhân viên";
            }
            else if (caLamViec == "catoi")
            {
                lb_CaLV.Text = "Ca tối";
                lb_ChucVu.Text = "Nhân viên";
            }
            else
            {
                lb_CaLV.Text = "Quản lý";
                lb_ChucVu.Text = "Chủ cửa hàng";
                bt_XemHD.Visible = true;
                
            }
            frm_GoiMon.caLamViec = caLamViec;
        }
        //Button tại chỗ 
        private void bt_TaiCho_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //Tạo background khi click chọn button
                this.bt_TaiCho.FillColor = Color.FromArgb(94, 148, 255);
                this.bt_TaiCho.FillColor2 = Color.FromArgb(255, 77, 165);
                this.bt_TaiCho.ForeColor = Color.White;
                bt_MangVe.FillColor = Color.Transparent;
                bt_MangVe.FillColor2 = Color.Transparent;
                bt_MangVe.ForeColor = Color.Black;
                bt_XemHD.FillColor = Color.Transparent;
                bt_XemHD.FillColor2 = Color.Transparent;
                bt_XemHD.ForeColor = Color.Black;


                lb_HienThi.Text = "Phục vụ tại chỗ";
                pic_HienThi.Image = Properties.Resources.table;
                frm_ChonBan fm = new frm_ChonBan();
                container(fm);
            }
        }
        //Button mang về 
        private void bt_MangVe_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            {
                //Tạo background khi click chọn button
                this.bt_MangVe.FillColor = Color.FromArgb(94, 148, 255);
                this.bt_MangVe.FillColor2 = Color.FromArgb(255, 77, 165);
                this.bt_MangVe.ForeColor = Color.White;
                bt_TaiCho.FillColor = Color.Transparent;
                bt_TaiCho.FillColor2 = Color.Transparent;
                bt_TaiCho.ForeColor = Color.Black;
                bt_XemHD.FillColor = Color.Transparent;
                bt_XemHD.FillColor2 = Color.Transparent;
                bt_XemHD.ForeColor = Color.Black;

                lb_HienThi.Text = "Bán mang về";
                pic_HienThi.Image = Properties.Resources.order_food;
                frm_GoiMon fm = new frm_GoiMon();
                container(fm);
            }
        }
        //Button xem hóa đơn 
        private void bt_XemHD_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.bt_XemHD.FillColor = Color.FromArgb(94, 148, 255);
                this.bt_XemHD.FillColor2 = Color.FromArgb(255, 77, 165);
                this.bt_XemHD.ForeColor = Color.White;
                bt_TaiCho.FillColor = Color.Transparent;
                bt_TaiCho.FillColor2 = Color.Transparent;
                bt_TaiCho.ForeColor = Color.Black;
                bt_MangVe.FillColor = Color.Transparent;
                bt_MangVe.FillColor2 = Color.Transparent;
                bt_MangVe.ForeColor = Color.Black;

                lb_HienThi.Text = "Xem hóa đơn";
                pic_HienThi.Image = Properties.Resources.searchbill;
                frm_XemHoaDon fm = new frm_XemHoaDon();
                container(fm);
            }
        }
        //Button trợ giúp 
        private void bt_TroGiup_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                frm_TroGiup fm = new frm_TroGiup();
                fm.ShowDialog();
            }
        }
        private void bt_DangXuat_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DialogResult result =
                MessageBox.Show("Bạn muốn đăng xuất ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.Hide();
                    frm_DangNhap fm = new frm_DangNhap();
                    fm.Show();
                }
            }
        }
        private void ctrl_Close_Click(object sender, EventArgs e)
        {
            DialogResult result =
            MessageBox.Show("Bạn muốn kết thúc chương trình ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK) Application.Exit();
        }
        private void frm_TrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
