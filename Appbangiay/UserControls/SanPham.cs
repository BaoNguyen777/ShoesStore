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
        
        public SanPham()
        {
            InitializeComponent();            
        }
        
        

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                clsDatabase.OpenConnection();
                SqlDataAdapter da = new SqlDataAdapter("Select hhID, hhHieu from HANGHOA", clsDatabase.con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataSP.DataSource = dt;
                clsDatabase.CloseConnection();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ThemBtn_Click(object sender, EventArgs e)
        {
           /* string connectionString = "Server=DESKTOP-98P71O3;Database=QLShopGiay;integrated security=true";

            // Tạo đối tượng SqlConnection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Lấy thông tin đăng nhập của người dùng
                    Object.Nhanvien nv=new Object.Nhanvien();

                    // Gọi thủ tục lưu trữ để lưu trữ lịch sử nhập hàng với thông tin đăng nhập của người dùng
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("ThemSanPham", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            Home hm = new Home();
                            cmd.Parameters.AddWithValue("@masp", MaSanPhamTxt.Text);
                            cmd.Parameters.AddWithValue("@nvten", get_sdt);
                            cmd.Parameters.AddWithValue("@kichco", KichCoTxt.Text);
                            cmd.Parameters.AddWithValue("@soluongnhap", SoLuongTxt.Text);
                            cmd.Parameters.AddWithValue("@hieusp", ThuongHieuTxt.Text);
                            cmd.Parameters.AddWithValue("@dongia", DonGiaTxt.Text);
                            cmd.Parameters.AddWithValue("@mausp", DonGiaTxt.Text);

                            cmd.ExecuteNonQuery();
                        }
                    }


                    TbaoTxt.Text = "Thêm sản phẩm thành công!";
                }
                catch (Exception ex)
                {
                    TbaoTxt.Text = "Lỗi: " + ex.Message;
                }
            }*/
        }
    }
}
