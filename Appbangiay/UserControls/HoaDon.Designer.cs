namespace Appbangiay.UserControls
{
    partial class HoaDon
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
            this.dtdxl = new System.Windows.Forms.DataGridView();
            this.btnCheck = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dtChuaxuly = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtdxl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtChuaxuly)).BeginInit();
            this.SuspendLayout();
            // 
            // dtdxl
            // 
            this.dtdxl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtdxl.Location = new System.Drawing.Point(14, 42);
            this.dtdxl.Name = "dtdxl";
            this.dtdxl.Size = new System.Drawing.Size(955, 216);
            this.dtdxl.TabIndex = 0;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(73, 312);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(128, 37);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Đã xử lý";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(406, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Không xử lý";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(777, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 37);
            this.button2.TabIndex = 3;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtChuaxuly
            // 
            this.dtChuaxuly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtChuaxuly.Location = new System.Drawing.Point(14, 416);
            this.dtChuaxuly.Name = "dtChuaxuly";
            this.dtChuaxuly.Size = new System.Drawing.Size(955, 216);
            this.dtChuaxuly.TabIndex = 4;
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtChuaxuly);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.dtdxl);
            this.Name = "HoaDon";
            this.Size = new System.Drawing.Size(992, 661);
            ((System.ComponentModel.ISupportInitialize)(this.dtdxl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtChuaxuly)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtdxl;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dtChuaxuly;
    }
}
