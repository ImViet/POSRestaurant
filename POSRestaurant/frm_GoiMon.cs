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
using System.IO;

namespace POSRestaurant
{
    public partial class frm_GoiMon : Form
    {
        public frm_GoiMon()
        {
            InitializeComponent();
        }
        //Truyền dữ liệu bằng contructor để lấy giá trị bàn 
        public frm_GoiMon(int giaTri): this()
        {
            soBan = giaTri;
            lb_Ban.Text = "Bàn: " + soBan;
        }
        //Biến toàn cục
        #region
        public static string caLamViec;
        public int soBan = 0;
        string ngayThang, thoiGian;
        string[] tenMon = { "Kimbap truyền thống", "BiBimBap", "Cơm Bulgogi", "Cơm Bokkum", "Cơm cà ri",
                            "Cơm Chachang", "Tokbokki phô mai", "Ramen Tokbokki", "Mì tương đen", "Tokbokki",
                            "Gà sốt cay", "Gà rán", "Gà phomai", "Lẩu kim chi", "Lẩu Tokbokki", 
                            "Kimbap chiên", "Mandu bạch tuộc", "Thịt nướng", "Mì lạnh", "Miến trộn"};

        double[] giaMon = { 35000, 40000, 32000, 42000, 50000, 
                            28000, 25000, 45000, 30000, 20000,
                            60000, 30000, 48000, 80000, 120000, 
                            38000, 30000, 28000, 40000, 50000};

        string[] tenDoUong = {"Soju truyền thống", "Soju nho", "Soju đào", "Soju táo", "Rượu Baekseju",
                              "Rượu Bokbunja","Sữa chuối", "Milkis", "Rượu gạo", "7Up",
                              "Pepsi", "Twister", "Trà vải", "Trà đào", "Trà dâu","Trà chanh"};

        double[] giaDoUong = {60000, 65000, 65000, 65000, 80000, 
                              100000, 20000, 25000, 50000, 10000,
                              10000, 10000, 20000, 20000, 20000, 15000};
        string path;
        #endregion

        private void LoadDataMonAn()
        {
            //Tạo ảnh món ăn
            path = Application.StartupPath + @"\AnhMon\";
            pic_MonAn1.Image=Image.FromFile(path + "mon1.jpg");
            pic_MonAn2.Image = Image.FromFile(path + "mon2.jpg");
            pic_MonAn3.Image = Image.FromFile(path + "mon3.jpg");
            pic_MonAn4.Image = Image.FromFile(path + "mon4.jpg");
            pic_MonAn5.Image = Image.FromFile(path + "mon5.jpg");
            pic_MonAn6.Image = Image.FromFile(path + "mon6.jpg");
            pic_MonAn7.Image = Image.FromFile(path + "mon7.jpg");
            pic_MonAn8.Image = Image.FromFile(path + "mon8.jpg");
            pic_MonAn9.Image = Image.FromFile(path + "mon9.jpg");
            pic_MonAn10.Image = Image.FromFile(path + "mon10.jpg");
            pic_MonAn11.Image = Image.FromFile(path + "mon11.jpg");
            pic_MonAn12.Image = Image.FromFile(path + "mon12.jpg");
            pic_MonAn13.Image = Image.FromFile(path + "mon13.jpg");
            pic_MonAn14.Image = Image.FromFile(path + "mon14.jpg");
            pic_MonAn15.Image = Image.FromFile(path + "mon15.jpg");
            pic_MonAn16.Image = Image.FromFile(path + "mon16.jpg");
            pic_MonAn17.Image = Image.FromFile(path + "mon17.jpg");
            pic_MonAn18.Image = Image.FromFile(path + "mon18.jpg");
            pic_MonAn19.Image = Image.FromFile(path + "mon19.jpg");
            pic_MonAn20.Image = Image.FromFile(path + "mon20.jpg");

            //Tạo tên món ăn 
            lb_TenMon1.Text = tenMon[0].ToString();
            lb_TenMon2.Text = tenMon[1].ToString();
            lb_TenMon3.Text = tenMon[2].ToString();
            lb_TenMon4.Text = tenMon[3].ToString();
            lb_TenMon5.Text = tenMon[4].ToString();
            lb_TenMon6.Text = tenMon[5].ToString();
            lb_TenMon7.Text = tenMon[6].ToString();
            lb_TenMon8.Text = tenMon[7].ToString();
            lb_TenMon9.Text = tenMon[8].ToString();
            lb_TenMon10.Text = tenMon[9].ToString();
            lb_TenMon11.Text = tenMon[10].ToString();
            lb_TenMon12.Text = tenMon[11].ToString();
            lb_TenMon13.Text = tenMon[12].ToString();
            lb_TenMon14.Text = tenMon[13].ToString();
            lb_TenMon15.Text = tenMon[14].ToString();
            lb_TenMon16.Text = tenMon[15].ToString();
            lb_TenMon17.Text = tenMon[16].ToString();
            lb_TenMon18.Text = tenMon[17].ToString();
            lb_TenMon19.Text = tenMon[18].ToString();
            lb_TenMon20.Text = tenMon[19].ToString();

            //Tạo giá món ăn
            lb_GiaMon1.Text = String.Format("{0:#,##0.##}", giaMon[0]) + "đ";
            lb_GiaMon2.Text = String.Format("{0:#,##0.##}", giaMon[1]) + "đ";
            lb_GiaMon3.Text = String.Format("{0:#,##0.##}", giaMon[2]) + "đ";
            lb_GiaMon4.Text = String.Format("{0:#,##0.##}", giaMon[3]) + "đ";
            lb_GiaMon5.Text = String.Format("{0:#,##0.##}", giaMon[4]) + "đ";
            lb_GiaMon6.Text = String.Format("{0:#,##0.##}", giaMon[5]) + "đ";
            lb_GiaMon7.Text = String.Format("{0:#,##0.##}", giaMon[6]) + "đ";
            lb_GiaMon8.Text = String.Format("{0:#,##0.##}", giaMon[7]) + "đ";
            lb_GiaMon9.Text = String.Format("{0:#,##0.##}", giaMon[8]) + "đ";
            lb_GiaMon10.Text = String.Format("{0:#,##0.##}", giaMon[9]) + "đ";
            lb_GiaMon11.Text = String.Format("{0:#,##0.##}", giaMon[10]) + "đ";
            lb_GiaMon12.Text = String.Format("{0:#,##0.##}", giaMon[11]) + "đ";
            lb_GiaMon13.Text = String.Format("{0:#,##0.##}", giaMon[12]) + "đ";
            lb_GiaMon14.Text = String.Format("{0:#,##0.##}", giaMon[13]) + "đ";
            lb_GiaMon15.Text = String.Format("{0:#,##0.##}", giaMon[14]) + "đ";
            lb_GiaMon16.Text = String.Format("{0:#,##0.##}", giaMon[15]) + "đ";
            lb_GiaMon17.Text = String.Format("{0:#,##0.##}", giaMon[16]) + "đ";
            lb_GiaMon18.Text = String.Format("{0:#,##0.##}", giaMon[17]) + "đ";
            lb_GiaMon19.Text = String.Format("{0:#,##0.##}", giaMon[18]) + "đ";
            lb_GiaMon20.Text = String.Format("{0:#,##0.##}", giaMon[19]) + "đ";
        }

        private void LoadDataDoUong()
        {
            //Tạo ảnh đồ uống
            path = Application.StartupPath + @"\DoUong\";
            pic_DoUong1.Image = Image.FromFile(path + "douong1.jpg");
            pic_DoUong2.Image = Image.FromFile(path + "douong2.jpg");
            pic_DoUong3.Image = Image.FromFile(path + "douong3.jpg");
            pic_DoUong4.Image = Image.FromFile(path + "douong4.jpg");
            pic_DoUong5.Image = Image.FromFile(path + "douong5.jpg");
            pic_DoUong6.Image = Image.FromFile(path + "douong6.jpg");
            pic_DoUong7.Image = Image.FromFile(path + "douong7.jpg");
            pic_DoUong8.Image = Image.FromFile(path + "douong8.jpg");
            pic_DoUong9.Image = Image.FromFile(path + "douong9.jpg");
            pic_DoUong10.Image = Image.FromFile(path + "douong10.jpg");
            pic_DoUong11.Image = Image.FromFile(path + "douong11.jpg");
            pic_DoUong12.Image = Image.FromFile(path + "douong12.jpg");
            pic_DoUong13.Image = Image.FromFile(path + "douong13.jpg");
            pic_DoUong14.Image = Image.FromFile(path + "douong14.jpg");
            pic_DoUong15.Image = Image.FromFile(path + "douong15.jpg");
            pic_DoUong16.Image = Image.FromFile(path + "douong16.jpg");

            //Tạo tên đồ uống
            lb_TenDoUong1.Text = tenDoUong[0].ToString();
            lb_TenDoUong2.Text = tenDoUong[1].ToString();
            lb_TenDoUong3.Text = tenDoUong[2].ToString();
            lb_TenDoUong4.Text = tenDoUong[3].ToString();
            lb_TenDoUong5.Text = tenDoUong[4].ToString();
            lb_TenDoUong6.Text = tenDoUong[5].ToString();
            lb_TenDoUong7.Text = tenDoUong[6].ToString();
            lb_TenDoUong8.Text = tenDoUong[7].ToString();
            lb_TenDoUong9.Text = tenDoUong[8].ToString();
            lb_TenDoUong10.Text = tenDoUong[9].ToString();
            lb_TenDoUong11.Text = tenDoUong[10].ToString();
            lb_TenDoUong12.Text = tenDoUong[11].ToString();
            lb_TenDoUong13.Text = tenDoUong[12].ToString();
            lb_TenDoUong14.Text = tenDoUong[13].ToString();
            lb_TenDoUong15.Text = tenDoUong[14].ToString();
            lb_TenDoUong16.Text = tenDoUong[15].ToString();

            //Tạo giá đồ uống
            lb_GiaDoUong1.Text= String.Format("{0:#,##0.##}", giaDoUong[0]) + "đ";
            lb_GiaDoUong2.Text = String.Format("{0:#,##0.##}", giaDoUong[1]) + "đ";
            lb_GiaDoUong3.Text = String.Format("{0:#,##0.##}", giaDoUong[2]) + "đ";
            lb_GiaDoUong4.Text = String.Format("{0:#,##0.##}", giaDoUong[3]) + "đ";
            lb_GiaDoUong5.Text = String.Format("{0:#,##0.##}", giaDoUong[4]) + "đ";
            lb_GiaDoUong6.Text = String.Format("{0:#,##0.##}", giaDoUong[5]) + "đ";
            lb_GiaDoUong7.Text = String.Format("{0:#,##0.##}", giaDoUong[6]) + "đ";
            lb_GiaDoUong8.Text = String.Format("{0:#,##0.##}", giaDoUong[7]) + "đ";
            lb_GiaDoUong9.Text = String.Format("{0:#,##0.##}", giaDoUong[8]) + "đ";
            lb_GiaDoUong10.Text = String.Format("{0:#,##0.##}", giaDoUong[9]) + "đ";
            lb_GiaDoUong11.Text = String.Format("{0:#,##0.##}", giaDoUong[10]) + "đ";
            lb_GiaDoUong12.Text = String.Format("{0:#,##0.##}", giaDoUong[11]) + "đ";
            lb_GiaDoUong13.Text = String.Format("{0:#,##0.##}", giaDoUong[12]) + "đ";
            lb_GiaDoUong14.Text = String.Format("{0:#,##0.##}", giaDoUong[13]) + "đ";
            lb_GiaDoUong15.Text = String.Format("{0:#,##0.##}", giaDoUong[14]) + "đ";
            lb_GiaDoUong16.Text = String.Format("{0:#,##0.##}", giaDoUong[15]) + "đ";
        }

        //Tính tiền theo số món trên hóa đơn
        public double TinhTienMon()
        {
            Double sum = 0;

            for(int i=0; i<dgv_HoaDon.Rows.Count; i++)
            {
                sum = sum + Convert.ToDouble(dgv_HoaDon.Rows[i].Cells[2].Value);
            }
            return sum;
        }

        //Tính tiền thuế VAT
        private void ChiPhiThue()
        {
            Double tienThue, tongTien, VAT=0.1;
            if(dgv_HoaDon.Rows.Count > 0)
            {
                tienThue = (TinhTienMon() * VAT);
                txt_Thue.Text = String.Format("{0:#,##0.##}", tienThue);
                txt_TienMon.Text = String.Format("{0:#,##0.##}", (TinhTienMon()));
                tongTien = (TinhTienMon() + tienThue);
                txt_TongTien.Text = String.Format("{0:#,##0.##}", tongTien);
            }
            else
            {
                txt_Thue.Text = "";
                txt_TienMon.Text = "";
                txt_TienNhan.Text = "";
                txt_TienTra.Text = "";
                txt_TongTien.Text = "";
            }
        }

        //Tính tiền trả lại cho khách
        private void TienTraLai()
        {
            Double tienThue, tongTien, VAT = 0.1, tienTra;
            if (dgv_HoaDon.Rows.Count > 0)
            {
                tienThue = (TinhTienMon() * VAT);
                tongTien = (TinhTienMon() + tienThue);
                tienTra = Int32.Parse(txt_TienNhan.Text) - tongTien;
                txt_TienTra.Text = String.Format("{0:#,##0.##}", tienTra);
                txt_TienNhan.Text = String.Format("{0:#,##0.##}", txt_TienNhan.Text);
            }
            else
            {
                txt_Thue.Text = "";
                txt_TienMon.Text = "";
                txt_TienNhan.Text = "";
                txt_TienTra.Text = "";
                txt_TongTien.Text = "";
            }
        }

        //Sự kiện form load
        private void frm_TrangChu_Load(object sender, EventArgs e)
        {
            LoadDataMonAn();
            LoadDataDoUong();

            //Tạo item cho combobox
            comb_PhuongThucTT.Items.Add("Tiền mặt");
            comb_PhuongThucTT.Items.Add("Momo");
            comb_PhuongThucTT.Items.Add("ZaloPay");
            comb_PhuongThucTT.Items.Add("Thẻ");

        }

        //Hàm reset
        private void Reset()
        {
            txt_TienNhan.Text = "";
            txt_TienTra.Text = "";
            txt_TienMon.Text = "";
            txt_Thue.Text = "";
            txt_TongTien.Text = "";
            dgv_HoaDon.Rows.Clear();
            dgv_HoaDon.Refresh();
            comb_PhuongThucTT.SelectedItem = null;
        }
        //Button Reset
        private void bt_Reset_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Reset();
            }
        }

        //Sự kiện không cho textbox là ký tự chữ
        private void txt_TienNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            //Cho phép xóa khi nhập sai số tiền 
            if(e.KeyChar == 8) // 8 là mã của phím Backspace
            {
                e.Handled = false;
            }
        }

        //Xóa món ăn đã chọn
        private void bt_Xoa_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                foreach (DataGridViewRow row in this.dgv_HoaDon.SelectedRows)
                {
                    dgv_HoaDon.Rows.Remove(row);
                }

                ChiPhiThue();

                if (comb_PhuongThucTT.Text == "Tiền mặt" && txt_TienNhan.Text != "")
                {
                    TienTraLai();
                }
                else
                {
                    txt_TienTra.Text = "";
                    txt_TienNhan.Text = "";
                }
            }
        }
        //Hàm thêm món vào dgv khi ấn button cộng
        private void ThemMon(int so)
        {
            int tam = 0;
            {
                for (int i = 0; i < dgv_HoaDon.Rows.Count; i++)  
                {
                    if (dgv_HoaDon.Rows[i].Cells[0].Value.ToString() == tenMon[so - 1]) 
                    {
                        tam++;
                        dgv_HoaDon.Rows[i].Cells[1].Value = Convert.ToInt32(dgv_HoaDon.Rows[i].Cells[1].Value) + 1;
                        dgv_HoaDon.Rows[i].Cells[2].Value = Convert.ToDouble(dgv_HoaDon.Rows[i].Cells[1].Value) * giaMon[so - 1];
                    }
                }

                if (tam == 0)
                    dgv_HoaDon.Rows.Add(tenMon[so - 1], "1", giaMon[so - 1]); // Thêm mới món ăn vào dgv 
                ChiPhiThue();
                //Cho dòng vừa chọn được select và scroll về cuối dgv 
                dgv_HoaDon.FirstDisplayedScrollingRowIndex = dgv_HoaDon.RowCount - 1;
                dgv_HoaDon.CurrentCell = dgv_HoaDon.Rows[dgv_HoaDon.Rows.Count - 1].Cells[0];
            }
        }

        //Hàm thêm đồ uống vào dgv khi ấn button cộng
        private void ThemDoUong(int so)
        {
            int tam = 0;
            for (int i = 0; i < dgv_HoaDon.Rows.Count; i++)
            {
                if (dgv_HoaDon.Rows[i].Cells[0].Value.ToString() == tenDoUong[so - 1])
                {
                    tam++;
                    dgv_HoaDon.Rows[i].Cells[1].Value = Convert.ToInt32(dgv_HoaDon.Rows[i].Cells[1].Value) + 1;
                    dgv_HoaDon.Rows[i].Cells[2].Value = Convert.ToDouble(dgv_HoaDon.Rows[i].Cells[1].Value) * giaDoUong[so - 1];
                }

            }

            if (tam == 0)
                dgv_HoaDon.Rows.Add(tenDoUong[so - 1], "1", giaDoUong[so - 1]);
            ChiPhiThue();
            //Cho dòng vừa chọn được select và scroll về cuối dgv 
            dgv_HoaDon.FirstDisplayedScrollingRowIndex = dgv_HoaDon.RowCount - 1;
            dgv_HoaDon.CurrentCell = dgv_HoaDon.Rows[dgv_HoaDon.Rows.Count - 1].Cells[0];
        }

        private void comb_PhuongThucTT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comb_PhuongThucTT.Text != "Tiền mặt")
            {
                txt_TienNhan.Enabled = false;
                txt_TienNhan.Text = "";
            }
            else
            {
                txt_TienNhan.Enabled = true;
            }
        }

        //Thời gian tạo hóa đơn
        private void timer1_Tick(object sender, EventArgs e)
        {
            thoiGian = DateTime.Now.ToLongTimeString();
            ngayThang = DateTime.Now.ToShortDateString();
        }

        //Thiết kế hóa đơn 
        private int doc = 0, tam = 210, viTri = 0;     
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("KOREAN Food Restaurant", new Font("Arial", 24, FontStyle.Bold), Brushes.Black, new Point(215, 10));
            e.Graphics.DrawString("371 Nguyễn Kiệm, Gò Vấp, TP Hồ Chí Minh", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(255, 50));
            e.Graphics.DrawString("---------------------------------------------------------------------------------------------",
                                    new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(140,70));
            e.Graphics.DrawString("HÓA ĐƠN THANH TOÁN", new Font("Time New Roman", 24, FontStyle.Bold), Brushes.Black, new Point(220, 90));
            e.Graphics.DrawString("Giờ tạo:", new Font("Time New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(150, 130));
            e.Graphics.DrawString(thoiGian, new Font("Time New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(230, 130));
            e.Graphics.DrawString("Ngày:", new Font("Time New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(520, 130));
            e.Graphics.DrawString(ngayThang, new Font("path + ", 14, FontStyle.Regular), Brushes.Black, new Point(580, 130));
            switch (caLamViec)
            {
                case "casang":
                     e.Graphics.DrawString("Ca làm việc: ", new Font("Time New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(150, 160));
                     e.Graphics.DrawString("Ca sáng ", new Font("Time New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(300, 160));
                    break;
                case "catoi":
                    e.Graphics.DrawString("Ca làm việc: ", new Font("Time New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(150, 160));
                    e.Graphics.DrawString("Ca tối ", new Font("Time New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(300, 160));
                    break;
                case "quanly":
                    e.Graphics.DrawString("Quản lý", new Font("Time New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(150, 160));
                    break;
            }
            if (soBan != 0)
            {
                e.Graphics.DrawString("Bàn: ", new Font("Time New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(520, 160));
                e.Graphics.DrawString(soBan.ToString(), new Font("Time New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(580, 160));
            }
            else
            {

                e.Graphics.DrawString("Bán mang về", new Font("Time New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(520, 160));
            }

            e.Graphics.DrawString("Món", new Font("Time New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(165, 185));
            e.Graphics.DrawString("Số lượng", new Font("Time New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(370, 185));
            e.Graphics.DrawString("Giá", new Font("Time New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(610, 185));
            for (int i=0; i<dgv_HoaDon.Rows.Count; i++)
            {
                e.Graphics.DrawString(dgv_HoaDon.Rows[i].Cells[0].Value.ToString(),
                    new Font("Time New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(140, tam + doc));
                e.Graphics.DrawString(dgv_HoaDon.Rows[i].Cells[1].Value.ToString(),
                    new Font("Time New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(400, tam + doc));
                e.Graphics.DrawString(String.Format("{0:#,##0.##}", dgv_HoaDon.Rows[i].Cells[2].Value) + "đ",
                    new Font("Time New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(600, tam + doc));
                viTri = tam + doc; 
                doc = doc + 20;
            }
            e.Graphics.DrawString("---------------------------------------------------------------------------------",
                new Font("Time New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(140, viTri + 30));
            e.Graphics.DrawString("Tổng tiền món:", new Font("Time New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(140, viTri + 50));
            e.Graphics.DrawString(String.Format("{0:#,##0.##}", txt_TienMon.Text) + "đ", new Font("Time New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(600, viTri + 50));
            e.Graphics.DrawString("Thuế VAT (10%)", new Font("Time New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(140, viTri + 70));
            e.Graphics.DrawString(String.Format("{0:#,##0.##}", txt_Thue.Text) + "đ", new Font("Time New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(600, viTri + 70));
            e.Graphics.DrawString("Tiền nhận từ khách:", new Font("Time New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(140, viTri + 90));
            e.Graphics.DrawString(String.Format("{0:#,##0.##}", txt_TienNhan.Text) + "đ", new Font("Time New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(600, viTri + 90));
            e.Graphics.DrawString("Tiền trả lại:", new Font("Time New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(140, viTri + 110));
            e.Graphics.DrawString(String.Format("{0:#,##0.##}", txt_TienTra.Text) + "đ", new Font("Time New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(600, viTri + 110));
            e.Graphics.DrawString("Phương thức thanh toán:", new Font("Time New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(140, viTri + 130));
            e.Graphics.DrawString(comb_PhuongThucTT.Text, new Font("Time New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(600, viTri + 130));
            e.Graphics.DrawString("---------------------------------------------------------------------------------",
               new Font("Time New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(140, viTri + 140));
            e.Graphics.DrawString("Tổng tiền phải trả:", new Font("Time New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(140, viTri + 170));
            e.Graphics.DrawString(txt_TongTien.Text + "đ", new Font("Time New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(600, viTri + 170));
            e.Graphics.DrawString("THANK YOU!", new Font("Time New Roman", 24, FontStyle.Bold), Brushes.Black, new Point(320, viTri + 200));
            tam = 210;
            viTri = 0;
            doc = 0;
        }
        // Hàm gọi in hóa đơn 
        private void InHoaDon()
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
        //Lưu dữ liệu xuống notepad
        private void LuuDuLieu()
        {
            StreamWriter streamWriter;
            string fileName = @"D:\DuLieuBanHang.txt";
            //Tien hanh luu 
            if (!File.Exists(fileName))
            {
                streamWriter = new StreamWriter(fileName);
                streamWriter.WriteLine(String.Format("{0, -10}", "Thời gian: ") + String.Format("{0, -5}", thoiGian));
                streamWriter.WriteLine(String.Format("{0, -10}", "Ngày: ") + String.Format("{0, -10}", ngayThang));

                switch (caLamViec)
                {
                    case "casang":
                        streamWriter.WriteLine(String.Format("{0, -10}", "Ca làm việc: ")+ String.Format("{0, -10}", "Ca sáng"));
                        break;
                    case "catoi":
                        streamWriter.WriteLine(String.Format("{0, -10}", "Ca làm việc: ") + String.Format("{0, -10}", "Ca tối"));
                        break;
                    case "quanly":
                        streamWriter.WriteLine(String.Format("{0, -10}", "Ca làm việc: ") + String.Format("{0, -10}", "Quản lý"));
                        break;

                }
                if (soBan != 0)
                    streamWriter.WriteLine(String.Format("{0, -10}", "Bàn: ") + String.Format("{0, -20}", soBan));
                else
                    streamWriter.WriteLine(String.Format("{0, -10}", "Bán mang về"));
                streamWriter.WriteLine(String.Format("{0, -10}", " "));
                streamWriter.WriteLine(String.Format("{0, -50}", dgv_HoaDon.Columns[0].HeaderText) +
                      String.Format("{0, -20}", dgv_HoaDon.Columns[1].HeaderText) +
                      String.Format("{0, -30}", dgv_HoaDon.Columns[2].HeaderText));
                for (int i = 0; i < dgv_HoaDon.Rows.Count; i++)
                {
                    streamWriter.WriteLine(String.Format("{0, -50}", dgv_HoaDon.Rows[i].Cells[0].Value) +
                     String.Format("{0, -20}", dgv_HoaDon.Rows[i].Cells[1].Value) +
                     String.Format("{0, -30}", dgv_HoaDon.Rows[i].Cells[2].Value));
                }
                streamWriter.WriteLine(String.Format("{0, -10}", " "));
                streamWriter.WriteLine(String.Format("{0, -10}", "Phương thức thanh toán: ") + String.Format("{0, -10}", comb_PhuongThucTT.Text));
                streamWriter.WriteLine(String.Format("{0, -10}", "Tiền nhận: ") + String.Format("{0, -10}", txt_TienNhan.Text));
                streamWriter.WriteLine(String.Format("{0, -10}", "Tiền trả: ") + String.Format("{0, -10}", txt_TienTra.Text));
                streamWriter.WriteLine(String.Format("{0, -10}", "Tiền món: ") + String.Format("{0, -10}", txt_TienMon.Text));
                streamWriter.WriteLine(String.Format("{0, -10}", "Tiền thuế: ") + String.Format("{0, -10}", txt_Thue.Text));
                streamWriter.WriteLine(String.Format("{0, -10}", "Tổng tiền: ") + String.Format("{0, -10}", txt_TongTien.Text));
                streamWriter.WriteLine(String.Format("{0, -10}", "------------------------------------------------------------------------------ "));
                streamWriter.Close();
            }
            else
            {
                streamWriter = File.AppendText(fileName);
                streamWriter.WriteLine(String.Format("{0, -10}", "Thời gian: ") + String.Format("{0, -5}", thoiGian));
                streamWriter.WriteLine(String.Format("{0, -10}", "Ngày: ") + String.Format("{0, -10}", ngayThang));

                switch (caLamViec)
                {
                    case "casang":
                        streamWriter.WriteLine(String.Format("{0, -10}", "Ca làm việc: ") + String.Format("{0, -10}", "Ca sáng"));
                        break;
                    case "catoi":
                        streamWriter.WriteLine(String.Format("{0, -10}", "Ca làm việc: ") + String.Format("{0, -10}", "Ca tối"));
                        break;
                    case "quanly":
                        streamWriter.WriteLine(String.Format("{0, -10}", "Ca làm việc: ") + String.Format("{0, -10}", "Quản lý"));
                        break;
                }
                if (soBan != 0)
                    streamWriter.WriteLine(String.Format("{0, -10}", "Bàn: ") + String.Format("{0, -20}", soBan));
                else
                    streamWriter.WriteLine(String.Format("{0, -10}", "Bán mang về"));
                streamWriter.WriteLine(String.Format("{0, -10}", " "));
                streamWriter.WriteLine(String.Format("{0, -50}", dgv_HoaDon.Columns[0].HeaderText) +
                      String.Format("{0, -20}", dgv_HoaDon.Columns[1].HeaderText) +
                      String.Format("{0, -30}", dgv_HoaDon.Columns[2].HeaderText));
                for (int i = 0; i < dgv_HoaDon.Rows.Count; i++)
                {
                    streamWriter.WriteLine(String.Format("{0, -50}", dgv_HoaDon.Rows[i].Cells[0].Value) +
                     String.Format("{0, -20}", dgv_HoaDon.Rows[i].Cells[1].Value) +
                     String.Format("{0, -30}", dgv_HoaDon.Rows[i].Cells[2].Value));
                }
                streamWriter.WriteLine(String.Format("{0, -10}", " "));
                streamWriter.WriteLine(String.Format("{0, -10}", "Phương thức thanh toán: ") + String.Format("{0, -10}", comb_PhuongThucTT.Text));
                streamWriter.WriteLine(String.Format("{0, -10}", "Tiền nhận: ") + String.Format("{0, -10}", txt_TienNhan.Text));
                streamWriter.WriteLine(String.Format("{0, -10}", "Tiền trả: ") + String.Format("{0, -10}", txt_TienTra.Text));
                streamWriter.WriteLine(String.Format("{0, -10}", "Tiền món: ") + String.Format("{0, -10}", txt_TienMon.Text));
                streamWriter.WriteLine(String.Format("{0, -10}", "Tiền thuế: ") + String.Format("{0, -10}", txt_Thue.Text));
                streamWriter.WriteLine(String.Format("{0, -10}", "Tổng tiền: ") + String.Format("{0, -10}", txt_TongTien.Text));
                streamWriter.WriteLine(String.Format("{0, -10}", "------------------------------------------------------------------------------"));
                streamWriter.Close();
            }
            MessageBox.Show("Đã lưu hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Thanh toán
        private void bt_ThanhToan_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                //Kiểm tra đã chọn món hay chưa
                if (txt_TongTien.Text == "")
                    MessageBox.Show("Vui lòng chọn món!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Kiểm tra phương thức thanh toán đã được chọn chưa
                else if (comb_PhuongThucTT.Text == "")
                    MessageBox.Show("Vui lòng chọn hình thức thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Tiến hành thanh toán
                else
                {
                    string choose = comb_PhuongThucTT.Text;
                    switch (choose)
                    {
                        case "Tiền mặt":
                            if (txt_TienNhan.Text == "")
                                MessageBox.Show("Vui lòng nhập vào số tiền khách đưa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            else if (double.Parse(txt_TienNhan.Text) < double.Parse(txt_TongTien.Text))
                            {
                                MessageBox.Show("Không đủ tiền thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txt_TienTra.Text = "";
                                txt_TienNhan.Text = "";
                            }
                            else
                            {
                                TienTraLai();
                                MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                InHoaDon();
                                LuuDuLieu();
                                Reset();
                            }
                            break;

                        case "Momo":
                        case "ZaloPay":
                        case "Thẻ":
                            MessageBox.Show("Thanh toán bằng " + comb_PhuongThucTT.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            InHoaDon();
                            LuuDuLieu();
                            Reset();
                            break;
                    }
                }
            }
        }

        //Thêm món
        private void bt_CongMon1_MouseClick(object sender, MouseEventArgs e)
        {
            int so;
            Guna2Button b = (Guna2Button)sender;
            so = Int32.Parse(b.Text);
            if(e.Button == MouseButtons.Left)
            {
                ThemMon(so);
            }
        }
        //Thêm đồ uống
        private void bt_CongDoUong1_MouseClick(object sender, MouseEventArgs e)
        {
            int so;
            Guna2Button b = (Guna2Button)sender;
            so = Int32.Parse(b.Text);
            if (e.Button == MouseButtons.Left)
            {
                if(e.Button==MouseButtons.Left)
                {
                    ThemDoUong(so);
                }
            }
        }    
    }
}
