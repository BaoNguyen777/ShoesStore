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

namespace Appbangiay.UserControls
{
    public partial class admin : UserControl
    {
        public admin()
        {
            InitializeComponent();
            dataNV.DataSource = getAllNhanvien().Tables[0];
            //dataNV.DataMember = "nhanvien";
        }
        DataSet getAllNhanvien()
        {
            string query = "SELECT nvsdt, nvten, nvchucvu, nvluong from nhanvien;";
            DataSet data = new DataSet();
            using (SqlConnection conn = new SqlConnection(connectionString.con))
            {
                conn.Open();

                SqlDataAdapter adpter = new SqlDataAdapter(query, conn);
                adpter.Fill(data);
                conn.Close();
            }
            return data;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtChucvu.Text = "";
            txtLuong.Text = "";
            txtMatKhau.Text = "";
            txtTen.Text = "";
            txtSDT.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.RestartForm();
            this.ParentForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "Insert into nhanvien (nvsdt, nvmatkhau, nvten, nvchucvu, nvluong) values ('"+txtSDT.Text+"','"+txtMatKhau.Text+"','"+txtTen.Text+"','"+txtChucvu.Text+"',"+txtLuong.Text+");";
            using (SqlConnection conn = new SqlConnection(connectionString.con))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteReader();
                dataNV.DataSource = getAllNhanvien().Tables[0];
                conn.Close();

            }
        }
    }
}
