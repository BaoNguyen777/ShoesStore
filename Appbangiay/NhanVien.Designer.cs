﻿namespace Appbangiay
{
    partial class NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVien));
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DoanhThuTab = new System.Windows.Forms.Button();
            this.NhanVienTab = new System.Windows.Forms.Button();
            this.KhoHangTab = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DonHangTab = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(182, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "(List sp show here)";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(250, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(551, 554);
            this.panel4.TabIndex = 6;
            // 
            // DoanhThuTab
            // 
            this.DoanhThuTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.DoanhThuTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoanhThuTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoanhThuTab.ForeColor = System.Drawing.Color.Black;
            this.DoanhThuTab.Image = ((System.Drawing.Image)(resources.GetObject("DoanhThuTab.Image")));
            this.DoanhThuTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DoanhThuTab.Location = new System.Drawing.Point(0, 370);
            this.DoanhThuTab.Name = "DoanhThuTab";
            this.DoanhThuTab.Size = new System.Drawing.Size(250, 90);
            this.DoanhThuTab.TabIndex = 3;
            this.DoanhThuTab.Text = "Doanh thu";
            this.DoanhThuTab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DoanhThuTab.UseVisualStyleBackColor = false;
            // 
            // NhanVienTab
            // 
            this.NhanVienTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NhanVienTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.NhanVienTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NhanVienTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhanVienTab.ForeColor = System.Drawing.Color.White;
            this.NhanVienTab.Image = ((System.Drawing.Image)(resources.GetObject("NhanVienTab.Image")));
            this.NhanVienTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NhanVienTab.Location = new System.Drawing.Point(0, 280);
            this.NhanVienTab.Name = "NhanVienTab";
            this.NhanVienTab.Size = new System.Drawing.Size(250, 90);
            this.NhanVienTab.TabIndex = 2;
            this.NhanVienTab.Text = "Nhân viên";
            this.NhanVienTab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NhanVienTab.UseVisualStyleBackColor = false;
            // 
            // KhoHangTab
            // 
            this.KhoHangTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.KhoHangTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KhoHangTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KhoHangTab.ForeColor = System.Drawing.Color.Black;
            this.KhoHangTab.Image = ((System.Drawing.Image)(resources.GetObject("KhoHangTab.Image")));
            this.KhoHangTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KhoHangTab.Location = new System.Drawing.Point(0, 190);
            this.KhoHangTab.Name = "KhoHangTab";
            this.KhoHangTab.Size = new System.Drawing.Size(250, 90);
            this.KhoHangTab.TabIndex = 1;
            this.KhoHangTab.Text = "Kho hàng";
            this.KhoHangTab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.KhoHangTab.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.DoanhThuTab);
            this.panel1.Controls.Add(this.NhanVienTab);
            this.panel1.Controls.Add(this.KhoHangTab);
            this.panel1.Controls.Add(this.DonHangTab);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 554);
            this.panel1.TabIndex = 4;
            // 
            // DonHangTab
            // 
            this.DonHangTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.DonHangTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DonHangTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonHangTab.ForeColor = System.Drawing.Color.Black;
            this.DonHangTab.Image = ((System.Drawing.Image)(resources.GetObject("DonHangTab.Image")));
            this.DonHangTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DonHangTab.Location = new System.Drawing.Point(0, 100);
            this.DonHangTab.Name = "DonHangTab";
            this.DonHangTab.Size = new System.Drawing.Size(250, 90);
            this.DonHangTab.TabIndex = 0;
            this.DonHangTab.Text = "Đơn hàng";
            this.DonHangTab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DonHangTab.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 100);
            this.panel2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 554);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Quản lí nhân viên";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button DoanhThuTab;
        private System.Windows.Forms.Button NhanVienTab;
        private System.Windows.Forms.Button KhoHangTab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DonHangTab;
        private System.Windows.Forms.Panel panel2;
    }
}