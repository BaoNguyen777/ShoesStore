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
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-Q056MBAS\SQLEXPRESS;Initial Catalog=QLGiay;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from Login where USERNAME ='" + txtAdmin.Text + "' and password='" + txtAdminPass.Text + "';", conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("Login successful ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //Nua thay doan nay thanh mo trang chu nhe Chi Bao :3
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
