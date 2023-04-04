using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appbangiay
{
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        private void DonHangTab_Click(object sender, EventArgs e)
        {
            Home fr = new Home();
            this.Hide();
            fr.ShowDialog();
            this.Close();
        }

        private void KhoHangTab_Click(object sender, EventArgs e)
        {
            KhoHang fr = new KhoHang();
            this.Hide();
            fr.ShowDialog();
            this.Close();
        }

        private void DoanhThuTab_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemNhanVien fr = new ThemNhanVien();
            this.Hide();
            fr.ShowDialog();
            this.Close();
        }
    }
}
