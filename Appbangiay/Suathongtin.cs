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
    public partial class Suathongtin : Form
    {
        private string sdt;
        private SqlDataReader dr;
        public Suathongtin(string SDT)
        {
            InitializeComponent();
        }
    }
}
