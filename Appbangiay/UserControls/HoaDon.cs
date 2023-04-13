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
    public partial class HoaDon : UserControl
    {
        public HoaDon()
        {
            InitializeComponent();
            dtdxl.DataSource = getHoaDondaxuly().Tables[0];
            //dataNV.DataMember = "nhanvien";
            dtdxl.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtChuaxuly.DataSource = getAllHoaDon().Tables[0];
            dtChuaxuly.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        DataSet getAllHoaDon()
        {
            string query = "SELECT * from hoadon where tinhtrang ='Chua xu ly';";
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
        DataSet getHoaDondaxuly()
        {
            string query = "SELECT * from hoadon where tinhtrang ='Da xu ly';";
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

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //string query = "DELETE FROM nhanvien WHERE nvsdt = '" + txtSDT.Text + "';";
           /* using (SqlConnection conn = new SqlConnection(connectionString.con))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteReader();
                conn.Close();*/

            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // string query = "DELETE FROM nhanvien WHERE nvsdt = '" + txtSDT.Text + "';";
            /*using (SqlConnection conn = new SqlConnection(connectionString.con))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteReader();
                conn.Close();*/

           // }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string query = "DELETE FROM nhanvien WHERE nvsdt = '" + txtSDT.Text + "';";
            /*using (SqlConnection conn = new SqlConnection(connectionString.con))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteReader();
                conn.Close();*/

           // }
        }
    }
}
