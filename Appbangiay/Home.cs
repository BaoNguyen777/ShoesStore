using Appbangiay.UserControls;
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
        NavigationControl navigationControl;
        public Home()
        {
            InitializeComponent();
            InitializeNavigationControl();
        }
        private void InitializeNavigationControl()
        {
            List<UserControl> userControls = new List<UserControl>()
            {  new SanPham(), new HoaDon(), new DoanhThu(), new NguoiDung()};

            navigationControl = new NavigationControl(userControls, panel1);
            navigationControl.Display(0);
        }
        private void DonHangTab_Click(object sender, EventArgs e)
        {

        }

        private void KhoHangTab_Click(object sender, EventArgs e)
        {

        }

        private void NhanVienTab_Click(object sender, EventArgs e)
        {

        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            navigationControl.Display(0);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            navigationControl.Display(1);
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            navigationControl.Display(2);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            navigationControl.Display(3);
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            navigationControl.Display(0);
        }
    }
}
