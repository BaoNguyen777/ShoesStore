using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appbangiay.UserControls
{
    public partial class SanPham : UserControl
    {
        public string sdt;
        public SanPham(string nvsdt)
        {
            InitializeComponent();
            this.sdt = nvsdt;
        }

        private void ThemBtn_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng SqlConnection
            using (SqlConnection conn = new SqlConnection(connectionString.con))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("ThemSanPham", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        Home hm = new Home();

                        cmd.Parameters.AddWithValue("@masp", MaSanPhamTxt.Text);
                        cmd.Parameters.AddWithValue("@nvsdt", Login.nvien.sdtnv);
                        cmd.Parameters.AddWithValue("@kichco", KichCoTxt.Text);
                        cmd.Parameters.AddWithValue("@soluongnhap", SoLuongTxt.Text);
                        cmd.Parameters.AddWithValue("@hieusp", ThuongHieuTxt.Text);
                        cmd.Parameters.AddWithValue("@dongia", DonGiaTxt.Text);
                        cmd.Parameters.AddWithValue("@mausp", MauSanPhamTxt.Text);

                        cmd.ExecuteNonQuery();
                    }

                    TbaoTxt.Text = "Thêm sản phẩm thành công!";
                }
                catch (Exception ex)
                {
                    TbaoTxt.Text = "Lỗi: " + ex.Message;
                }
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                clsDatabase.OpenConnection();
                SqlDataAdapter da = new SqlDataAdapter("SELECT HANGHOA.hhHieu, TONKHO.hhID, TONKHO.kcSo, TONKHO.tkSoLuong FROM HANGHOA INNER JOIN TONKHO ON HANGHOA.hhID = TONKHO.hhID", clsDatabase.con);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataSP.DataSource = dt;

                clsDatabase.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void dataSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataSP_SelectionChanged(object sender, EventArgs e)
        {
            /*clsDatabase.OpenConnection();
            using (SqlCommand cmd = new SqlCommand("Select hhID from HANGHOA INNER JOIN TONKHO ON HANGHOA.hhID = TONKHO.hhID where HANGHOA.hhID= '" + dataSP.CurrentRow.Cells[0].Value + "'  ", clsDatabase.con))
            {
                string mahh = (string)cmd.ExecuteScalar();
                textBox1.Text = mahh;
                textBox2.Text = dataSP.CurrentRow.Cells[1].Value.ToString();
                SqlCommand cmd1 = new SqlCommand("SELECT hhDonGia FROM HANGHOA INNER JOIN TONKHO ON HANGHOA.hhID = TONKHO.hhID where HANGHOA.hhID= '" + dataSP.CurrentRow.Cells[0].Value + "'", clsDatabase.con);
                string hhdongia = cmd1.ExecuteScalar().ToString();
                textBox3.Text = hhdongia;
                SqlCommand cmd2 = new SqlCommand("SELECT hhMauSac FROM HANGHOA INNER JOIN TONKHO ON HANGHOA.hhID = TONKHO.hhID where HANGHOA.hhID= '" + dataSP.CurrentRow.Cells[0].Value + "'", clsDatabase.con);
                string hhmausac = cmd2.ExecuteScalar().ToString();
                textBox4.Text = hhmausac;
            }
            clsDatabase.CloseConnection();*/
        }
    }
}
