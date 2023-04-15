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
    public partial class DoanhThu : UserControl
    {
        public DoanhThu()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                clsDatabase.OpenConnection();
                SqlDataAdapter da = new SqlDataAdapter("SELECT NgayBan, hdID, Tong from HOADON", clsDatabase.con);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataDoanhThu.DataSource = dt;

                clsDatabase.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void dataDoanhThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /*private void CalculateRevenueByMonth()
        {
            int month = DateTime.Now.Month;
            decimal revenue = 0;

            foreach (DataGridViewRow row in dataDoanhThu.Rows)
            {
                DateTime date = Convert.ToDateTime(row.Cells[0].Value);
                if (date.Month == month)
                {
                    decimal amount = Convert.ToDecimal(row.Cells[3].Value);
                    revenue += amount;
                }
            }

            MessageBox.Show($"Revenue for month {month}: {revenue}");
        }*/

        /*private void ThuNhap_Click(object sender, EventArgs e)
        {
            int month = DateTime.Now.Month;
            decimal revenue = 0;

            foreach (DataGridViewRow row in dataDoanhThu.Rows)
            {
                DateTime date = Convert.ToDateTime(row.Cells[0].Value);
                if (date.Month == month)
                {
                    decimal amount = Convert.ToDecimal(row.Cells[3].Value);
                    revenue += amount;
                }
            }
            textBox1.Text = month.ToString();
            textBox2.Text = revenue.ToString();

        }*/
        private void ThuNhap_Click(object sender, EventArgs e)
        {
            
            int thang = int.Parse(thangTxtBox.Text);
            int nam = int.Parse(namTxtBox.Text);

            // Kết nối đến SQL Server
            clsDatabase.OpenConnection();

            // Thực thi hàm
            SqlCommand command = new SqlCommand("SELECT dbo.TongDoanhThuTheoThang(@thang, @nam)", clsDatabase.con);
            command.Parameters.AddWithValue("@thang", thang);
            command.Parameters.AddWithValue("@nam", nam);
            Decimal tongDoanhThu = (Decimal)command.ExecuteScalar();

            // Hiển thị kết quả trên TextBox
            ThuNhapTxtBox.Text = tongDoanhThu.ToString("N0");

            // Đóng kết nối
            clsDatabase.CloseConnection();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
