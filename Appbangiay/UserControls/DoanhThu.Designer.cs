namespace Appbangiay.UserControls
{
    partial class DoanhThu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataDoanhThu = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qLShopGiayDataSet1 = new Appbangiay.QLShopGiayDataSet1();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.qLShopGiayDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thangTxtBox = new System.Windows.Forms.TextBox();
            this.ThuNhapTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.namTxtBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLShopGiayDataSet1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLShopGiayDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Doanh Thu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 56);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataDoanhThu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(845, 427);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // dataDoanhThu
            // 
            this.dataDoanhThu.AutoGenerateColumns = false;
            this.dataDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDoanhThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataDoanhThu.DataSource = this.qLShopGiayDataSet1;
            this.dataDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataDoanhThu.Location = new System.Drawing.Point(0, 0);
            this.dataDoanhThu.Name = "dataDoanhThu";
            this.dataDoanhThu.Size = new System.Drawing.Size(845, 427);
            this.dataDoanhThu.TabIndex = 0;
            this.dataDoanhThu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDoanhThu_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "NgayBan";
            this.Column1.HeaderText = "Ngày bán";
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "hdID";
            this.Column2.FillWeight = 200F;
            this.Column2.HeaderText = "hdID";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "Tong";
            this.Column3.HeaderText = "Tổng hóa đơn";
            this.Column3.Name = "Column3";
            // 
            // qLShopGiayDataSet1
            // 
            this.qLShopGiayDataSet1.DataSetName = "QLShopGiayDataSet1";
            this.qLShopGiayDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.namTxtBox);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.ThuNhapTxtBox);
            this.panel3.Controls.Add(this.thangTxtBox);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 483);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(845, 195);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(93, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thu nhập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ThuNhap_Click);
            // 
            // qLShopGiayDataSet1BindingSource
            // 
            this.qLShopGiayDataSet1BindingSource.DataSource = this.qLShopGiayDataSet1;
            this.qLShopGiayDataSet1BindingSource.Position = 0;
            // 
            // thangTxtBox
            // 
            this.thangTxtBox.Location = new System.Drawing.Point(280, 18);
            this.thangTxtBox.Name = "thangTxtBox";
            this.thangTxtBox.Size = new System.Drawing.Size(100, 20);
            this.thangTxtBox.TabIndex = 1;
            // 
            // ThuNhapTxtBox
            // 
            this.ThuNhapTxtBox.BackColor = System.Drawing.Color.AliceBlue;
            this.ThuNhapTxtBox.Location = new System.Drawing.Point(410, 58);
            this.ThuNhapTxtBox.Name = "ThuNhapTxtBox";
            this.ThuNhapTxtBox.Size = new System.Drawing.Size(229, 20);
            this.ThuNhapTxtBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(225, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tháng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(225, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tổng thu nhập trong tháng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(408, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Năm:";
            // 
            // namTxtBox
            // 
            this.namTxtBox.Location = new System.Drawing.Point(453, 18);
            this.namTxtBox.Name = "namTxtBox";
            this.namTxtBox.Size = new System.Drawing.Size(100, 20);
            this.namTxtBox.TabIndex = 5;
            // 
            // DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "DoanhThu";
            this.Size = new System.Drawing.Size(845, 678);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataDoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLShopGiayDataSet1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLShopGiayDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataDoanhThu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource qLShopGiayDataSet1BindingSource;
        private QLShopGiayDataSet1 qLShopGiayDataSet1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ThuNhapTxtBox;
        private System.Windows.Forms.TextBox thangTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox namTxtBox;
    }
}
