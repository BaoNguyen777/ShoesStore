using System;
using System.Data;
using System.Data.SqlClient;
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
            using (SqlConnection conn = new SqlConnection(connectionString.con))
            {
                /*conn.Open();
                using (SqlCommand cmd = new SqlCommand("showttsp", conn))
                {
                    cmd.Parameters.AddWithValue("@hhid", dataSP.CurrentRow.Cells[1].Value);
                    cmd.Parameters.AddWithValue("@kcso", dataSP.CurrentRow.Cells[2].Value);
                    string mahh = cmd.ExecuteScalar().ToString();
                    textBox1.Text = mahh;

                    string hieu = cmd.ExecuteScalar().ToString();
                    textBox2.Text = hieu;

                    string gia = cmd.ExecuteScalar().ToString();
                    textBox3.Text = gia;

                    string mau = cmd.ExecuteScalar().ToString();
                    textBox4.Text = mau;
                }*/

                clsDatabase.OpenConnection();

                /*
                                SqlCommand cmd1 = new SqlCommand("Select hhID from HANGHOA INNER JOIN TONKHO ON HANGHOA.hhID = TONKHO.hhID " +
                                "where HANGHOA.hhID= '" + dataSP.CurrentRow.Cells[1].Value + "' " +
                                "and TONKHO.kcSo= '" + dataSP.CurrentRow.Cells[2].Value + "' ", clsDatabase.con);
                                string mahh = cmd1.ExecuteScalar().ToString();
                                textBox1.Text = mahh;*/
                string query = "SELECT HANGHOA.hhID, HANGHOA.hhHieu, HANGHOA.hhDonGia, HANGHOA.hhMauSac FROM HANGHOA INNER JOIN TONKHO ON HANGHOA.hhID = TONKHO.hhID WHERE HANGHOA.hhID = @hhID AND TONKHO.kcSo = @kcSo";
                SqlCommand cmd = new SqlCommand(query, clsDatabase.con);
                cmd.Parameters.AddWithValue("@hhID", dataSP.CurrentRow.Cells[1].Value);
                cmd.Parameters.AddWithValue("@kcSo", dataSP.CurrentRow.Cells[2].Value);

                try
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textBox1.Text = reader["hhID"].ToString();
                            textBox2.Text = reader["hhHieu"].ToString();
                            textBox3.Text = reader["hhDonGia"].ToString();
                            textBox4.Text = reader["hhMauSac"].ToString();
                        }
                        else
                        {
                            // Handle case where no rows are returned
                        }
                    }
                }
                catch (Exception ex)
                {
                    textBox1.Text = "Lỗi:" + ex.Message;

                }



                clsDatabase.CloseConnection();
            }
        }

        private void UpdSPbtn_Click(object sender, EventArgs e)
        {

        }

        private void DelSPbtn_Click(object sender, EventArgs e)
        {
            string str1 = "DELETE FROM hanghoa WHERE hhID=@hhID";
            string str2 = "DELETE FROM tonkho WHERE hhID=@hhID";
            string str3 = "DELETE FROM lichsunhaphang WHERE hhID=@hhID";
            clsDatabase.OpenConnection();
            SqlCommand cmd = new SqlCommand(str1, clsDatabase.con);
            cmd.Parameters.AddWithValue("@hhID", textBox1.Text);
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand(str2, clsDatabase.con);
            cmd1.Parameters.AddWithValue("@hhID", textBox1.Text);
            cmd1.ExecuteNonQuery();
            SqlCommand cmd2 = new SqlCommand(str3, clsDatabase.con);
            cmd2.Parameters.AddWithValue("@hhID", textBox1.Text);
            cmd2.ExecuteNonQuery();
            clsDatabase.CloseConnection();
        }

    }
}
