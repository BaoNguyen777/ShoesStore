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
    public partial class ThemNhanVien : Form
    {
        public ThemNhanVien()
        {
            InitializeComponent();
        }

        private void DonHangTab_Click(object sender, EventArgs e)
        {
            Home fr = new Home();
            fr.Size = new Size(1000, 800);
            fr.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            fr.ShowDialog();
            this.Close();
        }

        private void KhoHangTab_Click(object sender, EventArgs e)
        {
            KhoHang fr = new KhoHang();
            fr.Size = new Size(1000, 800);
            fr.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            fr.ShowDialog();
            this.Close();
        }

        private void NhanVienTab_Click(object sender, EventArgs e)
        {
            NhanVien fr = new NhanVien();
            fr.Size = new Size(1000, 800);
            fr.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            fr.ShowDialog();
            this.Close();
        }
    }
}
