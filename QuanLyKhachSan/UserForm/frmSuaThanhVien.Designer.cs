﻿namespace QuanLyKhachSan
{
    partial class frmSuaThanhVien
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDanhSachKhachHang = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbLoaiKhach = new System.Windows.Forms.ComboBox();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.tbCMND = new System.Windows.Forms.TextBox();
            this.tbMaPhong = new System.Windows.Forms.TextBox();
            this.tbMaPhieu = new System.Windows.Forms.TextBox();
            this.tbTenKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbSua = new System.Windows.Forms.Button();
            this.tbThoat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKhachHang)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 439);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDanhSachKhachHang);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(502, 439);
            this.panel2.TabIndex = 5;
            // 
            // dgvDanhSachKhachHang
            // 
            this.dgvDanhSachKhachHang.AllowUserToAddRows = false;
            this.dgvDanhSachKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachKhachHang.Location = new System.Drawing.Point(0, 100);
            this.dgvDanhSachKhachHang.Name = "dgvDanhSachKhachHang";
            this.dgvDanhSachKhachHang.RowHeadersWidth = 51;
            this.dgvDanhSachKhachHang.RowTemplate.Height = 24;
            this.dgvDanhSachKhachHang.Size = new System.Drawing.Size(502, 339);
            this.dgvDanhSachKhachHang.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(502, 100);
            this.panel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách khách hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbThoat);
            this.panel3.Controls.Add(this.tbSua);
            this.panel3.Controls.Add(this.cbLoaiKhach);
            this.panel3.Controls.Add(this.tbID);
            this.panel3.Controls.Add(this.tbDiaChi);
            this.panel3.Controls.Add(this.tbCMND);
            this.panel3.Controls.Add(this.tbMaPhong);
            this.panel3.Controls.Add(this.tbMaPhieu);
            this.panel3.Controls.Add(this.tbTenKH);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(502, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(353, 439);
            this.panel3.TabIndex = 4;
            // 
            // cbLoaiKhach
            // 
            this.cbLoaiKhach.FormattingEnabled = true;
            this.cbLoaiKhach.Location = new System.Drawing.Point(157, 211);
            this.cbLoaiKhach.Name = "cbLoaiKhach";
            this.cbLoaiKhach.Size = new System.Drawing.Size(170, 24);
            this.cbLoaiKhach.TabIndex = 2;
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Location = new System.Drawing.Point(157, 314);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(170, 22);
            this.tbDiaChi.TabIndex = 1;
            // 
            // tbCMND
            // 
            this.tbCMND.Location = new System.Drawing.Point(157, 265);
            this.tbCMND.Name = "tbCMND";
            this.tbCMND.Size = new System.Drawing.Size(170, 22);
            this.tbCMND.TabIndex = 1;
            // 
            // tbMaPhong
            // 
            this.tbMaPhong.Location = new System.Drawing.Point(33, 67);
            this.tbMaPhong.Name = "tbMaPhong";
            this.tbMaPhong.ReadOnly = true;
            this.tbMaPhong.Size = new System.Drawing.Size(99, 22);
            this.tbMaPhong.TabIndex = 1;
            // 
            // tbMaPhieu
            // 
            this.tbMaPhieu.Location = new System.Drawing.Point(242, 67);
            this.tbMaPhieu.Name = "tbMaPhieu";
            this.tbMaPhieu.ReadOnly = true;
            this.tbMaPhieu.Size = new System.Drawing.Size(99, 22);
            this.tbMaPhieu.TabIndex = 1;
            // 
            // tbTenKH
            // 
            this.tbTenKH.Location = new System.Drawing.Point(157, 160);
            this.tbTenKH.Name = "tbTenKH";
            this.tbTenKH.Size = new System.Drawing.Size(170, 22);
            this.tbTenKH.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "CMND:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Loại khách:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã phiếu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên khách hàng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "ID:";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(157, 114);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(170, 22);
            this.tbID.TabIndex = 1;
            // 
            // tbSua
            // 
            this.tbSua.Location = new System.Drawing.Point(65, 376);
            this.tbSua.Name = "tbSua";
            this.tbSua.Size = new System.Drawing.Size(75, 44);
            this.tbSua.TabIndex = 3;
            this.tbSua.Text = "Sửa";
            this.tbSua.UseVisualStyleBackColor = true;
            this.tbSua.Click += new System.EventHandler(this.tbSua_Click);
            // 
            // tbThoat
            // 
            this.tbThoat.Location = new System.Drawing.Point(219, 376);
            this.tbThoat.Name = "tbThoat";
            this.tbThoat.Size = new System.Drawing.Size(75, 44);
            this.tbThoat.TabIndex = 3;
            this.tbThoat.Text = "Thoát";
            this.tbThoat.UseVisualStyleBackColor = true;
            this.tbThoat.Click += new System.EventHandler(this.tbThoat_Click);
            // 
            // frmSuaThanhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 439);
            this.Controls.Add(this.panel1);
            this.Name = "frmSuaThanhVien";
            this.Text = "frmSuaThanhVien";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKhachHang)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDanhSachKhachHang;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbLoaiKhach;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.TextBox tbCMND;
        private System.Windows.Forms.TextBox tbTenKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMaPhieu;
        private System.Windows.Forms.TextBox tbMaPhong;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button tbThoat;
        private System.Windows.Forms.Button tbSua;
    }
}