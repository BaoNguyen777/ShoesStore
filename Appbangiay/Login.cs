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

namespace Appbangiay
{
    public partial class Login : Form
    {
        private SqlDataReader dr;

        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        protected void button1_Click(object sender, EventArgs e)
        {
            if (txtAdmin.Text != string.Empty || txtAdminPass.Text != string.Empty)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-Q056MBAS\SQLEXPRESS;Initial Catalog=QLShopGiay;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from NHANVIEN where nvsdt ='" + txtAdmin.Text + "' and nvMatKhau='" + txtAdminPass.Text + "';", conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Nhanvien person = new Nhanvien();
                    person.SDT = dr.GetString(0);
                    if (!dr.IsDBNull(2))
                    {
                        person.Ten = dr.GetString(2);
                    }
                    else
                    {
                        person.Ten = "Chu cua hang";
                    }
                    //person.Luong = dr.GetInt32(4).ToString();
                    dr.Close();
                    Home fr = new Home();
                    fr.NhanVienText = person.Ten;
                    this.Hide();
                    fr.ShowDialog();
                    this.Close();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
