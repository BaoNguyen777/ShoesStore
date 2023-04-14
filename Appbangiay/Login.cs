using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Appbangiay;
using static Appbangiay.Object;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Appbangiay.UserControls;
using System.Collections;
using System.Windows.Markup;

namespace Appbangiay
{
    public partial class Login : Form
    {
        private SqlDataReader dr;
        public static clsNhanvien nvien;
        public Login()
        {
            InitializeComponent();
        }
        public void RestartForm()
        {
            txtAdmin.Text = "";
            txtAdminPass.Text = "";
            this.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        protected void button1_Click(object sender, EventArgs e)
        {
            nvien = null;
            if (txtAdmin.Text != string.Empty || txtAdminPass.Text != string.Empty)
            {
                using (SqlConnection conn = new SqlConnection(connectionString.con))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("select * from NHANVIEN where nvsdt ='" + txtAdmin.Text + "' and nvMatKhau='" + txtAdminPass.Text + "';", conn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        Nhanvien person = new Nhanvien();
                        person.SDT = dr.GetString(0);
                        person.Ten = dr.GetString(2);
                        person.Chucvu = dr.GetString(3);
                        dr.Close();
                        Home fr = new Home();
                        fr.NhanVienText = person.Ten;
                        fr.NhanVienChucvu = person.Chucvu;
                        fr.nhanviensdt = person.SDT;
                        nvien = new clsNhanvien(person.SDT);

                        this.Hide();
                        fr.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        dr.Close();
                        MessageBox.Show("Tai khoang khong hop le", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nhap day du thong tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}
