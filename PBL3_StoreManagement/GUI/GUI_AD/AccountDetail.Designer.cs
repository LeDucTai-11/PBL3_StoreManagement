namespace PBL3_StoreManagement.GUI.GUI_AD
{
    partial class AccountDetail
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
            this.txtPW = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.loaiHanglabel = new System.Windows.Forms.Label();
            this.TenHangLabel = new System.Windows.Forms.Label();
            this.txtNameNhanVien = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.IDlabel = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelThem = new System.Windows.Forms.Label();
            this.btnThoat = new PBL3_StoreManagement.GUI.CustomButton();
            this.btnOk = new PBL3_StoreManagement.GUI.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPW
            // 
            this.txtPW.Font = new System.Drawing.Font("Segoe UI Semilight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPW.Location = new System.Drawing.Point(275, 243);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(471, 36);
            this.txtPW.TabIndex = 7;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI Semilight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(275, 176);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(471, 36);
            this.txtUserName.TabIndex = 8;
            // 
            // loaiHanglabel
            // 
            this.loaiHanglabel.AutoSize = true;
            this.loaiHanglabel.Font = new System.Drawing.Font("Segoe UI Semilight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loaiHanglabel.Location = new System.Drawing.Point(55, 243);
            this.loaiHanglabel.Name = "loaiHanglabel";
            this.loaiHanglabel.Size = new System.Drawing.Size(101, 30);
            this.loaiHanglabel.TabIndex = 3;
            this.loaiHanglabel.Text = "Password";
            // 
            // TenHangLabel
            // 
            this.TenHangLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.TenHangLabel.AutoSize = true;
            this.TenHangLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenHangLabel.Location = new System.Drawing.Point(55, 182);
            this.TenHangLabel.Name = "TenHangLabel";
            this.TenHangLabel.Size = new System.Drawing.Size(112, 30);
            this.TenHangLabel.TabIndex = 5;
            this.TenHangLabel.Text = "UserName";
            // 
            // txtNameNhanVien
            // 
            this.txtNameNhanVien.Font = new System.Drawing.Font("Segoe UI Semilight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameNhanVien.Location = new System.Drawing.Point(275, 113);
            this.txtNameNhanVien.Name = "txtNameNhanVien";
            this.txtNameNhanVien.Size = new System.Drawing.Size(471, 36);
            this.txtNameNhanVien.TabIndex = 20;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Segoe UI Semilight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(275, 46);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(471, 36);
            this.txtID.TabIndex = 21;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(55, 113);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(149, 30);
            this.NameLabel.TabIndex = 18;
            this.NameLabel.Text = "Tên Nhân Viên";
            // 
            // IDlabel
            // 
            this.IDlabel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.IDlabel.AutoSize = true;
            this.IDlabel.Font = new System.Drawing.Font("Segoe UI Semilight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDlabel.Location = new System.Drawing.Point(55, 52);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(33, 30);
            this.IDlabel.TabIndex = 19;
            this.IDlabel.Text = "ID";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // labelThem
            // 
            this.labelThem.AutoSize = true;
            this.labelThem.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThem.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelThem.Location = new System.Drawing.Point(287, 81);
            this.labelThem.Name = "labelThem";
            this.labelThem.Size = new System.Drawing.Size(222, 35);
            this.labelThem.TabIndex = 22;
            this.labelThem.Text = "THÊM ACCOUNT";
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
            this.btnThoat.Location = new System.Drawing.Point(500, 333);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(222, 54);
            this.btnThoat.TabIndex = 17;
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
            this.btnOk.Location = new System.Drawing.Point(118, 333);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(222, 54);
            this.btnOk.TabIndex = 16;
            this.btnOk.Text = "Xác nhận";
            this.btnOk.TextColor = System.Drawing.Color.White;
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // AccountDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelThem);
            this.Controls.Add(this.txtNameNhanVien);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.loaiHanglabel);
            this.Controls.Add(this.TenHangLabel);
            this.Name = "AccountDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountDetail";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label loaiHanglabel;
        private System.Windows.Forms.Label TenHangLabel;
        private CustomButton btnOk;
        private CustomButton btnThoat;
        private System.Windows.Forms.TextBox txtNameNhanVien;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label labelThem;
    }
}