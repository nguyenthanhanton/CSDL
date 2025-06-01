using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Lich_Thuc_Hanh_Phong_May.Resources
{
    public partial class GiangVien : Form
    {
        public GiangVien()
        {
            InitializeComponent();
            tabControl1.Visible = false;
        }

        private void btn_THONGTIN_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            tabControl1.SelectedTab = page_THONGTIN;
            panel_GiangVien.Visible = false;
            panel_NhanVien.Visible = false;
        }

        private void btn_LTH_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            tabControl1.SelectedTab = page_LTH;
        }

        private void btn_TAITRUC_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            tabControl1.SelectedTab = page_TAITRUC;
        }

        private void btn_THONGKE_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            tabControl1.SelectedTab = page_THONGKE;
        }

        private void btn_TT_GV_Click(object sender, EventArgs e)
        {
            panel_GiangVien.Visible = true;
            panel_NhanVien.Visible = false;
        }

        private void btn_TT_NV_Click(object sender, EventArgs e)
        {
            //panel_GiangVien.Visible = false;
            panel_NhanVien.Visible = true;
        }
    }
}
