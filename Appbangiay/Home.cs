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
using static Appbangiay.Object;

namespace Appbangiay
{
    public partial class Home : Form
    {
        NavigationControl navigationControl;
        NavigationButtons navigationButtons;
        Color btnDefailtColor = Color.FromKnownColor(KnownColor.Navy);
        Color btnSelectColor = Color.FromKnownColor(KnownColor.OrangeRed);
        public Home()
        {
            InitializeComponent();
            InitializeNavigationControl();
            InitializeNavigationButton();
        }
        public string NhanVienText
        {
            get { return btnNhanVien.Text; }
            set { btnNhanVien.Text = value; }
        }
        private void InitializeNavigationControl()
        {
            List<UserControl> userControls = new List<UserControl>()
            {  new SanPham(), new UserControls.HoaDon(), new DoanhThu(), new NguoiDung()};

            navigationControl = new NavigationControl(userControls, panel1);
            navigationControl.Display(0);
        }

        private void InitializeNavigationButton()
        {
            List<Button> buttons = new List<Button>()
            { btnKho, btnHoaDon, btnDoanhThu, btnNhanVien};
            navigationButtons = new NavigationButtons(buttons, btnDefailtColor, btnSelectColor);
            navigationButtons.Highlight(btnKho);

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
            navigationButtons.Highlight(btnKho);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            navigationControl.Display(1);
            navigationButtons.Highlight(btnHoaDon);
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            navigationControl.Display(2);
            navigationButtons.Highlight(btnDoanhThu);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            navigationControl.Display(3);
            navigationButtons.Highlight(btnNhanVien);
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            navigationControl.Display(0);
            navigationButtons.Highlight(btnKho);
        }
    }
}
