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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void DonHangTab_Click(object sender, EventArgs e)
        {

        }

        private void KhoHangTab_Click(object sender, EventArgs e)
        {
            KhoHang fr = new KhoHang();
            this.Hide();
            fr.ShowDialog();
            this.Close();
        }

        private void NhanVienTab_Click(object sender, EventArgs e)
        {
            NhanVien fr = new NhanVien();
            this.Hide();
            fr.ShowDialog();
            this.Close();
        }
    }
}
