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
    public partial class AccountDetail : Form
    {
        public int IDAcc { get; set; }
        public ACCOUNT acc { get; set; }
        public AccountDetail(int id)
        {
            InitializeComponent();
            IDAcc = id;
            acc = new ACCOUNT();
            txtID.Enabled = false;
            txtNameNhanVien.Enabled = false;
            GUI();
        }
        private void GUI()
        {
            if(IDAcc > 0)
            {
                acc = BLL_Account.Instance.getAccountByID(IDAcc);
                txtID.Text = acc.ID+"";
                txtNameNhanVien.Text = BLL_QLNhanVien.Instance.getNhanVienByID(IDAcc).HoVaTen;
                txtUserName.Text = acc.UserName;
                txtPW.Text = acc.PW;
                labelThem.Dispose();
            }
            else
            {
                IDlabel.Dispose();
                txtID.Dispose();
                NameLabel.Dispose();
                txtNameNhanVien.Dispose();
                acc = null;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            bool check = true;

            if (txtUserName.Text == "" || txtPW.Text == "")
            {
                check = false;
            }else
            {
                if (acc == null)
                {
                    if (CheckUserName(txtUserName.Text))
                    {
                        BLL_Account.Instance.AddAccount(new ACCOUNT
                        {
                            UserName = txtUserName.Text,
                            PW = txtPW.Text,
                            Loai = 2,
                            trangThai = true,
                        });
                        MessageBox.Show("Đã thêm thành công !");
                        GUI_AD.CashierDetail f = new CashierDetail(0);
                        f.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("UserName đã bị trùng !",
                            "Lỗi !!!", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        errorProvider1.SetError(txtUserName, "UserName không hợp lệ !!");
                        txtUserName.Text = "";
                        check = false;
                        return;
                    }
                }
                else
                {
                    if(txtUserName.Text != acc.UserName)
                    {
                        if (CheckUserName(txtUserName.Text) == false)
                        {
                            MessageBox.Show("UserName đã bị trùng !",
                            "Lỗi !!!", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                            errorProvider1.SetError(txtUserName, "UserName không hợp lệ !!");
                            txtUserName.Text = "";
                            check = false;
                            return;
                        }
                    }
                }
            }


            if(check)
            {
                if(acc != null)
                {
                    acc.UserName = txtUserName.Text;
                    acc.PW = txtPW.Text;
                    acc.Loai = 2;
                    acc.trangThai = true;
                    BLL_Account.Instance.EditAccount(acc);
                }
                this.Dispose();
            }else
            {
                MessageBox.Show("Vui lòng kiểm tra lại các dữ liệu !",
                        "Thông báo lỗi", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }
        private bool CheckUserName(string msg)
        {
            bool check = true;
            foreach (ACCOUNT i in BLL_Account.Instance.getAllACCOUNTs())
            {
                if (i.UserName == msg)
                {
                    check = false;
                    break;
                }
            }
            return check;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
