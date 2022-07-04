namespace PBL3_StoreManagement.GUI.GUI_AD
{
    partial class GoodDetail
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
            this.dateTimePickerHSD = new System.Windows.Forms.DateTimePicker();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtTenMatHang = new System.Windows.Forms.TextBox();
            this.soLuongLabel = new System.Windows.Forms.Label();
            this.HSDlabel = new System.Windows.Forms.Label();
            this.Gialabel = new System.Windows.Forms.Label();
            this.NSXlabel = new System.Windows.Forms.Label();
            this.loaiHanglabel = new System.Windows.Forms.Label();
            this.IDlabel = new System.Windows.Forms.Label();
            this.TenHangLabel = new System.Windows.Forms.Label();
            this.cbbNhaSanXuat = new System.Windows.Forms.ComboBox();
            this.cbbLoaiHang = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelThem = new System.Windows.Forms.Label();
            this.btnOk = new PBL3_StoreManagement.GUI.CustomButton();
            this.btnThoat = new PBL3_StoreManagement.GUI.CustomButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerHSD
            // 
            this.dateTimePickerHSD.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerHSD.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerHSD.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerHSD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerHSD.Location = new System.Drawing.Point(258, 344);
            this.dateTimePickerHSD.Name = "dateTimePickerHSD";
            this.dateTimePickerHSD.Size = new System.Drawing.Size(471, 36);
            this.dateTimePickerHSD.TabIndex = 3;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Segoe UI Semilight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(258, 397);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(471, 36);
            this.txtSoLuong.TabIndex = 2;
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Segoe UI Semilight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(258, 279);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(471, 36);
            this.txtGia.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Segoe UI Semilight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(258, 41);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(471, 36);
            this.txtID.TabIndex = 2;
            // 
            // txtTenMatHang
            // 
            this.txtTenMatHang.Font = new System.Drawing.Font("Segoe UI Semilight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMatHang.Location = new System.Drawing.Point(258, 97);
            this.txtTenMatHang.Name = "txtTenMatHang";
            this.txtTenMatHang.Size = new System.Drawing.Size(471, 36);
            this.txtTenMatHang.TabIndex = 2;
            // 
            // soLuongLabel
            // 
            this.soLuongLabel.AutoSize = true;
            this.soLuongLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soLuongLabel.Location = new System.Drawing.Point(38, 403);
            this.soLuongLabel.Name = "soLuongLabel";
            this.soLuongLabel.Size = new System.Drawing.Size(103, 30);
            this.soLuongLabel.TabIndex = 1;
            this.soLuongLabel.Text = "Số Lượng";
            // 
            // HSDlabel
            // 
            this.HSDlabel.AutoSize = true;
            this.HSDlabel.Font = new System.Drawing.Font("Segoe UI Semilight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HSDlabel.Location = new System.Drawing.Point(38, 344);
            this.HSDlabel.Name = "HSDlabel";
            this.HSDlabel.Size = new System.Drawing.Size(138, 30);
            this.HSDlabel.TabIndex = 1;
            this.HSDlabel.Text = "Hạn Sử Dụng";
            // 
            // Gialabel
            // 
            this.Gialabel.AutoSize = true;
            this.Gialabel.Font = new System.Drawing.Font("Segoe UI Semilight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gialabel.Location = new System.Drawing.Point(38, 285);
            this.Gialabel.Name = "Gialabel";
            this.Gialabel.Size = new System.Drawing.Size(44, 30);
            this.Gialabel.TabIndex = 1;
            this.Gialabel.Text = "Giá";
            // 
            // NSXlabel
            // 
            this.NSXlabel.AutoSize = true;
            this.NSXlabel.Font = new System.Drawing.Font("Segoe UI Semilight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NSXlabel.Location = new System.Drawing.Point(38, 222);
            this.NSXlabel.Name = "NSXlabel";
            this.NSXlabel.Size = new System.Drawing.Size(141, 30);
            this.NSXlabel.TabIndex = 1;
            this.NSXlabel.Text = "Nhà Sản Xuất";
            // 
            // loaiHanglabel
            // 
            this.loaiHanglabel.AutoSize = true;
            this.loaiHanglabel.Font = new System.Drawing.Font("Segoe UI Semilight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loaiHanglabel.Location = new System.Drawing.Point(38, 164);
            this.loaiHanglabel.Name = "loaiHanglabel";
            this.loaiHanglabel.Size = new System.Drawing.Size(109, 30);
            this.loaiHanglabel.TabIndex = 1;
            this.loaiHanglabel.Text = "Loại Hàng";
            // 
            // IDlabel
            // 
            this.IDlabel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.IDlabel.AutoSize = true;
            this.IDlabel.Font = new System.Drawing.Font("Segoe UI Semilight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDlabel.Location = new System.Drawing.Point(38, 47);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(33, 30);
            this.IDlabel.TabIndex = 1;
            this.IDlabel.Text = "ID";
            // 
            // TenHangLabel
            // 
            this.TenHangLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.TenHangLabel.AutoSize = true;
            this.TenHangLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenHangLabel.Location = new System.Drawing.Point(38, 103);
            this.TenHangLabel.Name = "TenHangLabel";
            this.TenHangLabel.Size = new System.Drawing.Size(145, 30);
            this.TenHangLabel.TabIndex = 1;
            this.TenHangLabel.Text = "Tên Mặt Hàng";
            // 
            // cbbNhaSanXuat
            // 
            this.cbbNhaSanXuat.Font = new System.Drawing.Font("Segoe UI Semilight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNhaSanXuat.FormattingEnabled = true;
            this.cbbNhaSanXuat.Location = new System.Drawing.Point(258, 214);
            this.cbbNhaSanXuat.Name = "cbbNhaSanXuat";
            this.cbbNhaSanXuat.Size = new System.Drawing.Size(471, 38);
            this.cbbNhaSanXuat.TabIndex = 0;
            // 
            // cbbLoaiHang
            // 
            this.cbbLoaiHang.Font = new System.Drawing.Font("Segoe UI Semilight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLoaiHang.FormattingEnabled = true;
            this.cbbLoaiHang.Location = new System.Drawing.Point(258, 156);
            this.cbbLoaiHang.Name = "cbbLoaiHang";
            this.cbbLoaiHang.Size = new System.Drawing.Size(471, 38);
            this.cbbLoaiHang.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelThem);
            this.panel1.Controls.Add(this.dateTimePickerHSD);
            this.panel1.Controls.Add(this.txtSoLuong);
            this.panel1.Controls.Add(this.txtGia);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.txtTenMatHang);
            this.panel1.Controls.Add(this.soLuongLabel);
            this.panel1.Controls.Add(this.HSDlabel);
            this.panel1.Controls.Add(this.Gialabel);
            this.panel1.Controls.Add(this.NSXlabel);
            this.panel1.Controls.Add(this.loaiHanglabel);
            this.panel1.Controls.Add(this.IDlabel);
            this.panel1.Controls.Add(this.TenHangLabel);
            this.panel1.Controls.Add(this.cbbNhaSanXuat);
            this.panel1.Controls.Add(this.cbbLoaiHang);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(48, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 499);
            this.panel1.TabIndex = 11;
            // 
            // labelThem
            // 
            this.labelThem.AutoSize = true;
            this.labelThem.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThem.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelThem.Location = new System.Drawing.Point(274, 19);
            this.labelThem.Name = "labelThem";
            this.labelThem.Size = new System.Drawing.Size(237, 35);
            this.labelThem.TabIndex = 4;
            this.labelThem.Text = "THÊM SẢN PHẨM";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.SeaGreen;
            this.btnOk.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.btnOk.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnOk.BorderRadius = 20;
            this.btnOk.BorderSize = 0;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(147, 580);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(222, 54);
            this.btnOk.TabIndex = 13;
            this.btnOk.Text = "Xác nhận";
            this.btnOk.TextColor = System.Drawing.Color.White;
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.SeaGreen;
            this.btnThoat.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.btnThoat.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnThoat.BorderRadius = 20;
            this.btnThoat.BorderSize = 0;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(542, 580);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(222, 54);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextColor = System.Drawing.Color.White;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // GoodDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 671);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.panel1);
            this.Name = "GoodDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GoodDetail";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerHSD;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtTenMatHang;
        private System.Windows.Forms.Label soLuongLabel;
        private System.Windows.Forms.Label HSDlabel;
        private System.Windows.Forms.Label Gialabel;
        private System.Windows.Forms.Label NSXlabel;
        private System.Windows.Forms.Label loaiHanglabel;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.Label TenHangLabel;
        private System.Windows.Forms.ComboBox cbbNhaSanXuat;
        private System.Windows.Forms.ComboBox cbbLoaiHang;
        private System.Windows.Forms.Panel panel1;
        private CustomButton btnThoat;
        private CustomButton btnOk;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label labelThem;
    }
}