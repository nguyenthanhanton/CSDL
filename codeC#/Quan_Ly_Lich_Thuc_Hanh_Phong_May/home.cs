using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Lich_Thuc_Hanh_Phong_May
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
            
            //tabControl1.RightToLeft = RightToLeft.Yes;
           // tabControl1.RightToLeftLayout = true;
            this.Size = new Size(1278, 700);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = page_THONGTIN;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = page_LTH;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = page_TAITRUC;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = page_THONGKE;
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void page_THONGTIN_Click(object sender, EventArgs e)
        {

        }

        private void txt_TT_DCGV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_TT_SDTGV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_TT_EMAILGV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_TT_MAGV_TextChanged(object sender, EventArgs e)
        {

        }

        private void rabtn_GVNU_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rabtn_GVNAM_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lbl_TT_GTGV_Click(object sender, EventArgs e)
        {

        }

        private void lbl_TT_NSGV_Click(object sender, EventArgs e)
        {

        }

        private void lbl_TT_DCGV_Click(object sender, EventArgs e)
        {

        }

        private void lbl_TT_SDTGV_Click(object sender, EventArgs e)
        {

        }

        private void lbl_TT_EMAILGV_Click(object sender, EventArgs e)
        {

        }

        private void lbl_TT_TENGV_Click(object sender, EventArgs e)
        {

        }

        private void lbl_TT_MAGV_Click(object sender, EventArgs e)
        {

        }

        private void dt_NSGV_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_TT_TENGV_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_TT_TK_Click(object sender, EventArgs e)
        {

        }

        private void btn_TT_XOA_Click(object sender, EventArgs e)
        {

        }

        private void btn_TT_SUA_Click(object sender, EventArgs e)
        {

        }

        private void btn_TT_THEM_Click(object sender, EventArgs e)
        {

        }

        private void dgv_TT_GV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_TT_PM_Click(object sender, EventArgs e)
        {

        }

        private void btn_TT_CV_Click(object sender, EventArgs e)
        {

        }

        private void btn_TT_MH_Click(object sender, EventArgs e)
        {

        }

        private void btn_TT_LH_Click(object sender, EventArgs e)
        {

        }

        private void btn_TT_NV_Click(object sender, EventArgs e)
        {

        }

        private void btn_TT_GV_Click(object sender, EventArgs e)
        {

        }

        private void page_LTH_Click(object sender, EventArgs e)
        {

        }

        private void lbl_LTH_NDK_Click(object sender, EventArgs e)
        {

        }

        private void dt_LTH_NDK_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_LTH_NH_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_LTH_HK_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_LTH_ML_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_LTH_HK_Click(object sender, EventArgs e)
        {

        }

        private void lbl_LTH_NH_Click(object sender, EventArgs e)
        {

        }

        private void lbl_LTH_SB_Click(object sender, EventArgs e)
        {

        }

        private void lbl_LTH_ML_Click(object sender, EventArgs e)
        {

        }

        private void txt_LTH_SB_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtg_LTH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel_LTH_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_LTH_XOA_Click(object sender, EventArgs e)
        {

        }

        private void btn_LTH_TK_Click(object sender, EventArgs e)
        {

        }

        private void btn_LTH_CHINHSUA_Click(object sender, EventArgs e)
        {

        }

        private void btn_LTH_DK_Click(object sender, EventArgs e)
        {

        }

        private void btn_LTH_XEM_Click(object sender, EventArgs e)
        {

        }

        private void page_TAITRUC_Click(object sender, EventArgs e)
        {

        }

        private void cb_TTRUC_LOAIGIOTRUC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_TTRUC_HESOTT_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_TTRUC_HESOTT_Click(object sender, EventArgs e)
        {

        }

        private void txt_TTRUC_SOGIO_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_TTRUC_SOGIO_Click(object sender, EventArgs e)
        {

        }

        private void txt_TTRUC_GIOKT_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_TTRUC_GIOKT_Click(object sender, EventArgs e)
        {

        }

        private void lbl_TTRUC_NGAYTH_Click(object sender, EventArgs e)
        {

        }

        private void dt_TTRUC_NGAYTH_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_TTRUC_GIOBD_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_TTRUC_NDTH_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_TTRUC_MASOPHIEU_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_TTRUC_GIOBD_Click(object sender, EventArgs e)
        {

        }

        private void lbl_TTRUC_NDTH_Click(object sender, EventArgs e)
        {

        }

        private void lbl_TTRUC_LOAIGIOTRUC_Click(object sender, EventArgs e)
        {

        }

        private void lbl_TTRUC_MASOPHIEU_Click(object sender, EventArgs e)
        {

        }

        private void dtg_TTRUC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel_TTRUC_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_TTRUC_XOA_Click(object sender, EventArgs e)
        {

        }

        private void btn_TTRUC_TK_Click(object sender, EventArgs e)
        {

        }

        private void btn_TTRUC_CSUA_Click(object sender, EventArgs e)
        {

        }

        private void btn_TTRUC_XEM_Click(object sender, EventArgs e)
        {

        }

        private void page_THONGKE_Click(object sender, EventArgs e)
        {

        }

        private void panel_THONGKE_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_TKE_XUATEX_Click(object sender, EventArgs e)
        {

        }

        private void btn_TKE_TIMKIEM_Click(object sender, EventArgs e)
        {

        }

        private void btn_TKE_XEM_Click(object sender, EventArgs e)
        {

        }

        private void bg_QLLTHPM_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void panel_QLLTHPM_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_QL_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pb_QLTHPM_Click(object sender, EventArgs e)
        {

        }

        private void pb_LOGIN_Click(object sender, EventArgs e)
        {

        }
    }
}
