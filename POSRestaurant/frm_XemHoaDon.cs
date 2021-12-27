using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace POSRestaurant
{
    public partial class frm_XemHoaDon : Form
    {
        public frm_XemHoaDon()
        {
            InitializeComponent();
        }

        private void frm_XemHoaDon_Load(object sender, EventArgs e)
        {
            string path = @"D:\DuLieuBanHang.txt";
            try
            {
            StreamReader read = new StreamReader(path);
                using (read)
                {
                    while (read.Peek() >= 0)
                    {
                        listHoaDon.Items.Add(read.ReadLine());
                    }
                }
            }
            catch 
            {

                MessageBox.Show("Không tìm thấy dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
