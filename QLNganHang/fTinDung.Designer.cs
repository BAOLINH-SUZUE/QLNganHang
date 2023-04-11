namespace QLNganHang
{
    partial class fTinDung
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
            this.gvKhachHang = new System.Windows.Forms.DataGridView();
            this.gvTinDung = new System.Windows.Forms.DataGridView();
            this.txtCccd = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTinDung)).BeginInit();
            this.SuspendLayout();
            // 
            // gvKhachHang
            // 
            this.gvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvKhachHang.Location = new System.Drawing.Point(3, 288);
            this.gvKhachHang.Name = "gvKhachHang";
            this.gvKhachHang.RowHeadersWidth = 51;
            this.gvKhachHang.RowTemplate.Height = 24;
            this.gvKhachHang.Size = new System.Drawing.Size(350, 150);
            this.gvKhachHang.TabIndex = 0;
            // 
            // gvTinDung
            // 
            this.gvTinDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTinDung.Location = new System.Drawing.Point(359, 288);
            this.gvTinDung.Name = "gvTinDung";
            this.gvTinDung.RowHeadersWidth = 51;
            this.gvTinDung.RowTemplate.Height = 24;
            this.gvTinDung.Size = new System.Drawing.Size(333, 150);
            this.gvTinDung.TabIndex = 1;
            // 
            // txtCccd
            // 
            this.txtCccd.Location = new System.Drawing.Point(3, 243);
            this.txtCccd.Name = "txtCccd";
            this.txtCccd.Size = new System.Drawing.Size(325, 22);
            this.txtCccd.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(343, 239);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(106, 30);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tim kiem";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Khach hang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tin dung";
            // 
            // fTinDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 442);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtCccd);
            this.Controls.Add(this.gvTinDung);
            this.Controls.Add(this.gvKhachHang);
            this.Name = "fTinDung";
            this.Text = "fTinDung";
            ((System.ComponentModel.ISupportInitialize)(this.gvKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTinDung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvKhachHang;
        private System.Windows.Forms.DataGridView gvTinDung;
        private System.Windows.Forms.TextBox txtCccd;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}