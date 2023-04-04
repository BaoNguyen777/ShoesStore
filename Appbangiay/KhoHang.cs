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
    public partial class KhoHang : Form
    {
        public KhoHang()
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

        private void NhanVienTab_Click(object sender, EventArgs e)
        {
            NhanVien fr = new NhanVien();
            this.Hide();
            fr.ShowDialog();
            this.Close();
        }
    }
}
