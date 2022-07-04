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
    public partial class ChangePassword : Form
    {
        public int IDAcc { get; set; }  
        public static bool checkLogin { get; set; }
        public ChangePassword(int id)
        {
            InitializeComponent();
            IDAcc = id;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool check = true;
            ACCOUNT acc = BLL_Account.Instance.getAccountByID(IDAcc);
            if(txtOldPass.Text == "" ||txtOldPass.Text != BLL_Account.Instance.getAccountByID(IDAcc).PW
                ||txtNewPass.Text == "" || txtNewPass.Text == txtOldPass.Text || txtNewPass2.Text != txtNewPass.Text)
            {
                check = false;
            }
            if (check)
            {
                acc.PW = txtNewPass.Text;
                BLL_Account.Instance.EditAccount(acc);
                checkLogin = true;
                this.Dispose();
            }else
            {
                MessageBox.Show("Vui lòng kiểm tra lại các trường dữ liệu",
                    "Thông báo lỗi !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            checkLogin = false;
            this.Dispose();
        }
    }
}
