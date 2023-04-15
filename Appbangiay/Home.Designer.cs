namespace Appbangiay
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.qLGiayDataSet = new Appbangiay.QLGiayDataSet();
            this.qLGiayDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabNav = new System.Windows.Forms.Panel();
            this.btnDoanhThu = new System.Windows.Forms.Button();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnKho = new System.Windows.Forms.Button();
            this.tabAdminName = new System.Windows.Forms.Panel();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.tabLogo = new System.Windows.Forms.Panel();
            this.btnLogo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.qLGiayDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLGiayDataSetBindingSource)).BeginInit();
            this.tabNav.SuspendLayout();
            this.tabAdminName.SuspendLayout();
            this.tabLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // qLGiayDataSet
            // 
            this.qLGiayDataSet.DataSetName = "QLGiayDataSet";
            this.qLGiayDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLGiayDataSetBindingSource
            // 
            this.qLGiayDataSetBindingSource.DataSource = this.qLGiayDataSet;
            this.qLGiayDataSetBindingSource.Position = 0;
            // 
            // tabNav
            // 
            this.tabNav.BackColor = System.Drawing.Color.DarkBlue;
            this.tabNav.Controls.Add(this.btnDoanhThu);
            this.tabNav.Controls.Add(this.btnHoaDon);
            this.tabNav.Controls.Add(this.btnKho);
            this.tabNav.Controls.Add(this.tabAdminName);
            this.tabNav.Controls.Add(this.tabLogo);
            this.tabNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabNav.Location = new System.Drawing.Point(0, 0);
            this.tabNav.Name = "tabNav";
            this.tabNav.Size = new System.Drawing.Size(200, 711);
            this.tabNav.TabIndex = 0;
            // 
            // btnDoanhThu
            // 
            this.btnDoanhThu.BackColor = System.Drawing.Color.Navy;
            this.btnDoanhThu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoanhThu.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoanhThu.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDoanhThu.Image = global::Appbangiay.Properties.Resources.icons8_report_file_50;
            this.btnDoanhThu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoanhThu.Location = new System.Drawing.Point(0, 251);
            this.btnDoanhThu.Name = "btnDoanhThu";
            this.btnDoanhThu.Size = new System.Drawing.Size(200, 88);
            this.btnDoanhThu.TabIndex = 3;
            this.btnDoanhThu.Text = "Doanh Thu";
            this.btnDoanhThu.UseVisualStyleBackColor = false;
            this.btnDoanhThu.Click += new System.EventHandler(this.btnDoanhThu_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.BackColor = System.Drawing.Color.Navy;
            this.btnHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHoaDon.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDon.ForeColor = System.Drawing.SystemColors.Window;
            this.btnHoaDon.Image = global::Appbangiay.Properties.Resources.icons8_cheque_50;
            this.btnHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDon.Location = new System.Drawing.Point(0, 163);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(200, 88);
            this.btnHoaDon.TabIndex = 2;
            this.btnHoaDon.Text = "Hóa Đơn";
            this.btnHoaDon.UseVisualStyleBackColor = false;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnKho
            // 
            this.btnKho.BackColor = System.Drawing.Color.Navy;
            this.btnKho.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKho.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKho.ForeColor = System.Drawing.SystemColors.Window;
            this.btnKho.Image = global::Appbangiay.Properties.Resources.icons8_shop_501;
            this.btnKho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKho.Location = new System.Drawing.Point(0, 75);
            this.btnKho.Name = "btnKho";
            this.btnKho.Size = new System.Drawing.Size(200, 88);
            this.btnKho.TabIndex = 1;
            this.btnKho.Text = "Sản Phẩm";
            this.btnKho.UseVisualStyleBackColor = false;
            this.btnKho.Click += new System.EventHandler(this.btnKho_Click);
            // 
            // tabAdminName
            // 
            this.tabAdminName.Controls.Add(this.btnNhanVien);
            this.tabAdminName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabAdminName.Location = new System.Drawing.Point(0, 636);
            this.tabAdminName.Name = "tabAdminName";
            this.tabAdminName.Size = new System.Drawing.Size(200, 75);
            this.tabAdminName.TabIndex = 1;
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.Navy;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNhanVien.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNhanVien.Location = new System.Drawing.Point(3, 3);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(194, 72);
            this.btnNhanVien.TabIndex = 0;
            this.btnNhanVien.Text = "Người dùng";
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // tabLogo
            // 
            this.tabLogo.Controls.Add(this.btnLogo);
            this.tabLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabLogo.Location = new System.Drawing.Point(0, 0);
            this.tabLogo.Name = "tabLogo";
            this.tabLogo.Size = new System.Drawing.Size(200, 75);
            this.tabLogo.TabIndex = 0;
            // 
            // btnLogo
            // 
            this.btnLogo.BackColor = System.Drawing.Color.Navy;
            this.btnLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogo.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnLogo.Image = global::Appbangiay.Properties.Resources.icons8_shoes_50;
            this.btnLogo.Location = new System.Drawing.Point(0, 0);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(200, 72);
            this.btnLogo.TabIndex = 1;
            this.btnLogo.UseVisualStyleBackColor = false;
            this.btnLogo.Click += new System.EventHandler(this.btnLogo_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 711);
            this.panel1.TabIndex = 1;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 711);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabNav);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.qLGiayDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLGiayDataSetBindingSource)).EndInit();
            this.tabNav.ResumeLayout(false);
            this.tabAdminName.ResumeLayout(false);
            this.tabLogo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource qLGiayDataSetBindingSource;
        private QLGiayDataSet qLGiayDataSet;
        private System.Windows.Forms.Panel tabNav;
        private System.Windows.Forms.Button btnDoanhThu;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Button btnKho;
        private System.Windows.Forms.Panel tabAdminName;
        private System.Windows.Forms.Panel tabLogo;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnLogo;
        private System.Windows.Forms.Panel panel1;
    }
}