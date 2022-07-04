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

namespace PBL3_StoreManagement.GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            ACCOUNT acc = BLL_Account.Instance.
                getAccountLogin(txtTenDangNhap_Login.Text,txtMatKhau_Login.Text);
            if (acc == null)
            {
                MessageBox.Show("Tài khoản không hợp lệ!","Lỗi đăng nhập", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }else
            {
                if (acc.Loai == 1)
                {
                    GUI_AD.Admin f = new GUI_AD.Admin();
                    f.ShowDialog();
                }
                else if(acc.Loai == 2)
                {
                    GUI_CS.Cashier f = new GUI_CS.Cashier(acc.ID);
                    f.ShowDialog();
                }
            }
                txtTenDangNhap_Login.Text = "";
                txtMatKhau_Login.Text = "";
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
