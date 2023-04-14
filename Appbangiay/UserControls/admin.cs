﻿using System;
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
            dataNV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
            string query = "Insert into nhanvien (nvsdt, nvmatkhau, nvten, nvchucvu, nvluong) values ('" + txtSDT.Text + "','" + txtMatKhau.Text + "','" + txtTen.Text + "','" + txtChucvu.Text + "'," + txtLuong.Text + ");";
            using (SqlConnection conn = new SqlConnection(connectionString.con))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteReader();
                dataNV.DataSource = getAllNhanvien().Tables[0];
                conn.Close();

            }
        }
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow dr = dataNV.SelectedRows[0];
            txtSDT.Text = dr.Cells[0].Value.ToString();
            txtTen.Text = dr.Cells[1].Value.ToString();
            txtChucvu.Text = dr.Cells[2].Value.ToString();
            txtLuong.Text = dr.Cells[3].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM nhanvien WHERE nvsdt = '" + txtSDT.Text + "';";
            using (SqlConnection conn = new SqlConnection(connectionString.con))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteReader();
                dataNV.DataSource = getAllNhanvien().Tables[0];
                conn.Close();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string query = "UPDATE NHANVIEN SET nvLuong = nvLuong + " + textBox2.Text + " WHERE nvSdt = '" + textBox1.Text + "'; ";
            using (SqlConnection conn = new SqlConnection(connectionString.con))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteReader();
                dataNV.DataSource = getAllNhanvien().Tables[0];
                conn.Close();

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string query = "UPDATE NHANVIEN SET nvLuong = nvLuong - " + textBox2.Text + " WHERE nvSdt = '" + textBox1.Text + "';";
            using (SqlConnection conn = new SqlConnection(connectionString.con))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteReader();
                dataNV.DataSource = getAllNhanvien().Tables[0];
                conn.Close();

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string query = "UPDATE NHANVIEN SET  nvTen = '" + txtTen.Text + "', nvChucVu = '" + txtChucvu.Text + "', nvLuong = '" + txtLuong.Text + "' WHERE nvSdt = '" + txtSDT.Text + "';";
            using (SqlConnection conn = new SqlConnection(connectionString.con))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteReader();
                dataNV.DataSource = getAllNhanvien().Tables[0];
                conn.Close();

            }
        }

        private void dataNV_SelectionChanged(object sender, EventArgs e)
        {
            clsDatabase.OpenConnection();
            using (SqlCommand cmd = new SqlCommand("SELECT nvsdt, nvten, nvchucvu, nvluong from nhanvien where nvSdt= '" + dataNV.CurrentRow.Cells[0].Value + "'", clsDatabase.con))
            {
                //cmd.Parameters.AddWithValue("@mahh", dataSP.CurrentRow.Cells[0].Value);
                string sdt = (string)cmd.ExecuteScalar();
                txtSDT.Text = sdt;
                textBox1.Text = sdt;
                textBox3.Text = sdt;
                txtTen.Text = dataNV.CurrentRow.Cells[1].Value.ToString();
                txtChucvu.Text = dataNV.CurrentRow.Cells[2].Value.ToString();
                txtLuong.Text = dataNV.CurrentRow.Cells[3].Value.ToString();
            }
            clsDatabase.CloseConnection();
        }
    }
}