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
    }
}
