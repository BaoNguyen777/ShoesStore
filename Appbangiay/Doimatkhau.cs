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
    public partial class Doimatkhau : Form
    {
        private string sdt;
        private SqlDataReader dr;
        public Doimatkhau(string SDT)
        {
            InitializeComponent();
            sdt = SDT;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Server=LAPTOP-Q056MBAS\\SQLEXPRESS;Database=QLShopGiay;integrated security=true"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM NHANVIEN WHERE nvsdt = @SDT AND nvMatKhau = @MatKhau", conn))
                {
                    cmd.Parameters.AddWithValue("@SDT", sdt);
                    cmd.Parameters.AddWithValue("@MatKhau", textBox1.Text);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            if (textBox3.Text == textBox2.Text)
                            {
                                SqlCommand upd = new SqlCommand("UPDATE NHANVIEN SET nvMatKhau = @newPassword WHERE nvsdt = @sdt", conn);
                                upd.Parameters.AddWithValue("@newPassword", textBox2.Text);
                                upd.Parameters.AddWithValue("@sdt", sdt);
                                upd.ExecuteNonQuery();
                            }
                            else
                            {
                                MessageBox.Show("Mat khau nhap lai sai", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }
    }
}