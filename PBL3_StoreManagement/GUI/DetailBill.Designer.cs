namespace PBL3_StoreManagement.GUI
{
    partial class DetailBill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvBDTlistbill = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTongTienBaoCao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new PBL3_StoreManagement.GUI.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBDTlistbill)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBDTlistbill
            // 
            this.dgvBDTlistbill.AllowUserToResizeColumns = false;
            this.dgvBDTlistbill.AllowUserToResizeRows = false;
            this.dgvBDTlistbill.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBDTlistbill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBDTlistbill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBDTlistbill.ColumnHeadersHeight = 40;
            this.dgvBDTlistbill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBDTlistbill.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBDTlistbill.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvBDTlistbill.Location = new System.Drawing.Point(26, 58);
            this.dgvBDTlistbill.Name = "dgvBDTlistbill";
            this.dgvBDTlistbill.ReadOnly = true;
            this.dgvBDTlistbill.RowHeadersWidth = 51;
            this.dgvBDTlistbill.RowTemplate.Height = 35;
            this.dgvBDTlistbill.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBDTlistbill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBDTlistbill.Size = new System.Drawing.Size(1211, 400);
            this.dgvBDTlistbill.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Danh sách sản phẩm";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvBDTlistbill);
            this.panel2.Controls.Add(this.lbTongTienBaoCao);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(27, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1170, 534);
            this.panel2.TabIndex = 13;
            // 
            // lbTongTienBaoCao
            // 
            this.lbTongTienBaoCao.AutoSize = true;
            this.lbTongTienBaoCao.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTienBaoCao.ForeColor = System.Drawing.Color.IndianRed;
            this.lbTongTienBaoCao.Location = new System.Drawing.Point(1013, 480);
            this.lbTongTienBaoCao.Name = "lbTongTienBaoCao";
            this.lbTongTienBaoCao.Size = new System.Drawing.Size(131, 32);
            this.lbTongTienBaoCao.TabIndex = 1;
            this.lbTongTienBaoCao.Text = "Tổng tiền: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(876, 480);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tổng tiền: ";
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
            this.btnThoat.Location = new System.Drawing.Point(539, 596);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(222, 54);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextColor = System.Drawing.Color.White;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // DetailBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 678);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.panel2);
            this.Name = "DetailBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DetailBill";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBDTlistbill)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBDTlistbill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTongTienBaoCao;
        private System.Windows.Forms.Label label1;
        private CustomButton btnThoat;
    }
}