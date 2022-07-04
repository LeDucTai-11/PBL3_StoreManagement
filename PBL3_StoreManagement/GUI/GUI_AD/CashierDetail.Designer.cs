namespace PBL3_StoreManagement.GUI.GUI_AD
{
    partial class CashierDetail
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
            this.btnThoat = new PBL3_StoreManagement.GUI.CustomButton();
            this.btnOk = new PBL3_StoreManagement.GUI.CustomButton();
            this.TenHangLabel = new System.Windows.Forms.Label();
            this.IDlabel = new System.Windows.Forms.Label();
            this.loaiHanglabel = new System.Windows.Forms.Label();
            this.NSXlabel = new System.Windows.Forms.Label();
            this.giamgialabel = new System.Windows.Forms.Label();
            this.Gialabel = new System.Windows.Forms.Label();
            this.HSDlabel = new System.Windows.Forms.Label();
            this.soLuongLabel = new System.Windows.Forms.Label();
            this.txtHovaTen = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.cbbCaLamViec = new System.Windows.Forms.ComboBox();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            this.btnThoat.Location = new System.Drawing.Point(514, 671);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(222, 54);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextColor = System.Drawing.Color.White;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
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
            this.btnOk.Location = new System.Drawing.Point(183, 671);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(222, 54);
            this.btnOk.TabIndex = 15;
            this.btnOk.Text = "Xác nhận";
            this.btnOk.TextColor = System.Drawing.Color.White;
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // TenHangLabel
            // 
            this.TenHangLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.TenHangLabel.AutoSize = true;
            this.TenHangLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenHangLabel.Location = new System.Drawing.Point(38, 103);
            this.TenHangLabel.Name = "TenHangLabel";
            this.TenHangLabel.Size = new System.Drawing.Size(106, 30);
            this.TenHangLabel.TabIndex = 1;
            this.TenHangLabel.Text = "Họ và Tên";
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
            // loaiHanglabel
            // 
            this.loaiHanglabel.AutoSize = true;
            this.loaiHanglabel.Font = new System.Drawing.Font("Segoe UI Semilight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loaiHanglabel.Location = new System.Drawing.Point(38, 164);
            this.loaiHanglabel.Name = "loaiHanglabel";
            this.loaiHanglabel.Size = new System.Drawing.Size(93, 30);
            this.loaiHanglabel.TabIndex = 1;
            this.loaiHanglabel.Text = "Giới tính";
            // 
            // NSXlabel
            // 
            this.NSXlabel.AutoSize = true;
            this.NSXlabel.Font = new System.Drawing.Font("Segoe UI Semilight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NSXlabel.Location = new System.Drawing.Point(38, 222);
            this.NSXlabel.Name = "NSXlabel";
            this.NSXlabel.Size = new System.Drawing.Size(138, 30);
            this.NSXlabel.TabIndex = 1;
            this.NSXlabel.Text = "Số điện thoại";
            // 
            // giamgialabel
            // 
            this.giamgialabel.AutoSize = true;
            this.giamgialabel.Font = new System.Drawing.Font("Segoe UI Semilight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giamgialabel.Location = new System.Drawing.Point(38, 278);
            this.giamgialabel.Name = "giamgialabel";
            this.giamgialabel.Size = new System.Drawing.Size(83, 30);
            this.giamgialabel.TabIndex = 1;
            this.giamgialabel.Text = "Địa chỉ ";
            // 
            // Gialabel
            // 
            this.Gialabel.AutoSize = true;
            this.Gialabel.Font = new System.Drawing.Font("Segoe UI Semilight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gialabel.Location = new System.Drawing.Point(38, 333);
            this.Gialabel.Name = "Gialabel";
            this.Gialabel.Size = new System.Drawing.Size(112, 30);
            this.Gialabel.TabIndex = 1;
            this.Gialabel.Text = "UserName";
            // 
            // HSDlabel
            // 
            this.HSDlabel.AutoSize = true;
            this.HSDlabel.Font = new System.Drawing.Font("Segoe UI Semilight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HSDlabel.Location = new System.Drawing.Point(38, 392);
            this.HSDlabel.Name = "HSDlabel";
            this.HSDlabel.Size = new System.Drawing.Size(101, 30);
            this.HSDlabel.TabIndex = 1;
            this.HSDlabel.Text = "Password";
            // 
            // soLuongLabel
            // 
            this.soLuongLabel.AutoSize = true;
            this.soLuongLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soLuongLabel.Location = new System.Drawing.Point(38, 451);
            this.soLuongLabel.Name = "soLuongLabel";
            this.soLuongLabel.Size = new System.Drawing.Size(127, 30);
            this.soLuongLabel.TabIndex = 1;
            this.soLuongLabel.Text = "Ca làm việc ";
            // 
            // txtHovaTen
            // 
            this.txtHovaTen.Font = new System.Drawing.Font("Segoe UI Semilight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHovaTen.Location = new System.Drawing.Point(258, 97);
            this.txtHovaTen.Name = "txtHovaTen";
            this.txtHovaTen.Size = new System.Drawing.Size(471, 36);
            this.txtHovaTen.TabIndex = 2;
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI Semilight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(258, 222);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(471, 36);
            this.txtSDT.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI Semilight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(258, 278);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(471, 36);
            this.txtAddress.TabIndex = 2;
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
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI Semilight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(258, 327);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(471, 36);
            this.txtUserName.TabIndex = 2;
            // 
            // txtPW
            // 
            this.txtPW.Font = new System.Drawing.Font("Segoe UI Semilight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPW.Location = new System.Drawing.Point(258, 392);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(471, 36);
            this.txtPW.TabIndex = 2;
            // 
            // cbbCaLamViec
            // 
            this.cbbCaLamViec.FormattingEnabled = true;
            this.cbbCaLamViec.Location = new System.Drawing.Point(258, 456);
            this.cbbCaLamViec.Name = "cbbCaLamViec";
            this.cbbCaLamViec.Size = new System.Drawing.Size(471, 36);
            this.cbbCaLamViec.TabIndex = 3;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Location = new System.Drawing.Point(354, 164);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(75, 32);
            this.rdbNam.TabIndex = 4;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(548, 164);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(60, 32);
            this.rdbNu.TabIndex = 5;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbNu);
            this.panel1.Controls.Add(this.rdbNam);
            this.panel1.Controls.Add(this.cbbCaLamViec);
            this.panel1.Controls.Add(this.txtPW);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Controls.Add(this.txtHovaTen);
            this.panel1.Controls.Add(this.soLuongLabel);
            this.panel1.Controls.Add(this.HSDlabel);
            this.panel1.Controls.Add(this.Gialabel);
            this.panel1.Controls.Add(this.giamgialabel);
            this.panel1.Controls.Add(this.NSXlabel);
            this.panel1.Controls.Add(this.loaiHanglabel);
            this.panel1.Controls.Add(this.IDlabel);
            this.panel1.Controls.Add(this.TenHangLabel);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(48, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 554);
            this.panel1.TabIndex = 12;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CashierDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 746);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.panel1);
            this.Name = "CashierDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashierDetail";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CustomButton btnThoat;
        private CustomButton btnOk;
        private System.Windows.Forms.Label TenHangLabel;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.Label loaiHanglabel;
        private System.Windows.Forms.Label NSXlabel;
        private System.Windows.Forms.Label giamgialabel;
        private System.Windows.Forms.Label Gialabel;
        private System.Windows.Forms.Label HSDlabel;
        private System.Windows.Forms.Label soLuongLabel;
        private System.Windows.Forms.TextBox txtHovaTen;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.ComboBox cbbCaLamViec;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}