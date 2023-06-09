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
using static Appbangiay.Object;

namespace Appbangiay.UserControls
{
    public partial class NguoiDung : UserControl
    {
        public NguoiDung()
        {
            InitializeComponent();
        }
        public string get_sdt
        {
            get { return txtSDT.Text; }
            set { txtSDT.Text = value; }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.RestartForm();
            this.ParentForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Doimatkhau dmk = new Doimatkhau(txtSDT.Text);
            dmk.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Suathongtin stt = new Suathongtin(txtSDT.Text);
            stt.ShowDialog();
        }
    }
}
