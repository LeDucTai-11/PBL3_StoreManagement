using PBL3_StoreManagement.BLL;
using PBL3_StoreManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_StoreManagement.GUI.GUI_AD
{
    public partial class CustomerDetail : Form
    {
        public int ID { get; set; }
        public CustomerDetail(int id)
        {
            InitializeComponent();
            ID = id;
            txtSoDonDaMua.Enabled = false;
            txtTongTien.Enabled = false;
            GUI();
        }
        private void GUI()
        {
            if(ID > 0)
            {
                txtID.Text = BLL_KhachHang.Instance.getKHByID(ID).ID+"";
                txtID.Enabled = false;
                txtName.Text = BLL_KhachHang.Instance.getKHByID(ID).TenKhachHang;
                txtSDT.Text = BLL_KhachHang.Instance.getKHByID(ID).SDT;
                txtSoDonDaMua.Text = BLL_KhachHang.Instance.getKHByID(ID).SoHoaDon + "";
                txtTongTien.Text = BLL_KhachHang.Instance.getKHByID(ID).SoTien + "";
            }else
            {
                lbID.Dispose();
                txtID.Dispose();
                lbSoDon.Dispose();
                txtSoDonDaMua.Dispose();
                lbTongTien.Dispose();
                txtTongTien.Dispose();
                lbVND.Dispose();
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            KHACH_HANG h = new KHACH_HANG();
            bool check = true;
            if(txtID.Text != "")
            {
                h.ID = Convert.ToInt32(txtID.Text);
            }
            if(txtName.Text == "")
            {
                check = false;
            }else
            {
                h.TenKhachHang = txtName.Text;
            }
            if (txtSDT.Text.Length != 10)
            {
                txtSDT.Text = "";
                check = false;
            }
            else
            {
                if (ID > 0)
                {
                    if (txtSDT.Text != BLL_KhachHang.Instance.getKHByID(ID).SDT)
                    {
                        if (Tool.Instance.CheckSDTKH(txtSDT.Text) == false)
                        {
                            MessageBox.Show("Số điện thoại đã bị trùng !",
                            "Lỗi !!!", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                            txtSDT.Text = "";
                            check = false;
                            return;
                        }
                    }
                }
                else
                {
                    if (Tool.Instance.CheckSDTKH(txtSDT.Text) == false)
                    {
                        MessageBox.Show("Số điện thoại đã bị trùng !",
                            "Lỗi !!!", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        txtSDT.Text = "";
                        check = false;
                        return;
                    }
                }
            }
            if (check)
            {
                h.trangThai = true;
                h.SDT = txtSDT.Text;
                BLL_KhachHang.Instance.AddEdit(h);
                this.Close();
            }else
            {
                MessageBox.Show("Vui lòng kiểm tra lại các dữ liệu !",
                            "Thông báo lỗi !!!", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
