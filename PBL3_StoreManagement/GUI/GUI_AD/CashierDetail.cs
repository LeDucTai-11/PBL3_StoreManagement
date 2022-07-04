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
    public partial class CashierDetail : Form
    {
        int ID;
        public ACCOUNT acc { get; set; }
        public CashierDetail(int id)
        {
            InitializeComponent();
            ID = id;
            acc = new ACCOUNT();
            setCBBCaLamViec();
            GUI();
        }
        private void setCBBCaLamViec()
        {
            foreach(CBBItemCaLamViec i in BLL_QLNhanVien.Instance.GetCBBItemCaLamViecs())
            {
                cbbCaLamViec.Items.Add(i);
            }
        }
        private void GUI()
        {
            if(ID > 0)
            {
                txtID.Text = BLL_QLNhanVien.Instance.getNhanVienByID(ID).ID+"";
                txtID.Enabled = false;
                txtHovaTen.Text = BLL_QLNhanVien.Instance.getNhanVienByID(ID).HoVaTen;
                if(BLL_QLNhanVien.Instance.getNhanVienByID(ID).GioiTinh == true)
                {
                    rdbNam.Checked = true;
                }else
                {
                    rdbNu.Checked = true;
                }
                txtSDT.Text = BLL_QLNhanVien.Instance.getNhanVienByID(ID).SDT;
                txtAddress.Text = BLL_QLNhanVien.Instance.getNhanVienByID(ID).DiaChi;
                acc = BLL_Account.Instance.getAccountByID(ID);
                txtUserName.Text = BLL_Account.Instance.getAccountByID(ID).UserName;
                txtPW.Text = BLL_Account.Instance.getAccountByID(ID).PW;
                foreach(CBBItemCaLamViec i in cbbCaLamViec.Items)
                {
                    if(i.Value == BLL_QLNhanVien.Instance.getNhanVienByID(ID).IDShift)
                    {
                        cbbCaLamViec.SelectedItem = i;
                        break;
                    }
                }
            }else
            {
                IDlabel.Dispose();
                txtID.Dispose();
                txtUserName.Text = BLL_Account.Instance.getAccountByIDMax().UserName;
                txtPW.Text = BLL_Account.Instance.getAccountByIDMax().PW;
                txtUserName.Enabled = false;
                txtPW.Enabled = false;
                acc = null;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            bool check = true;
            CASHIER c = new CASHIER();
            if(txtID.Text != "")
            {
                c.ID = Convert.ToInt32(txtID.Text.ToString());
            }

            if(txtHovaTen.Text == "" || rdbNam.Checked == false&&rdbNu.Checked==false ||txtAddress.Text==""
                || cbbCaLamViec.Text == "" || txtUserName.Text == ""||txtPW.Text == "")
            {
                check = false;
            }

            if(rdbNam.Checked)
            {
                c.GioiTinh = true;
            }else
            {
                c.GioiTinh = false;
            }

            if(txtSDT.Text.Length != 10)
            {
                txtSDT.Text = "";
                check = false;
            }
            else
            {
                if(ID > 0)
                {
                    if(txtSDT.Text != BLL_QLNhanVien.Instance.getNhanVienByID(ID).SDT)
                    {
                        if (Tool.Instance.CheckSDTNV(txtSDT.Text) == false)
                        {
                            MessageBox.Show("Số điện thoại đã bị trùng !",
                            "Lỗi !!!", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                            txtSDT.Text = "";
                            check = false;
                            return;
                        }
                    }
                }else
                {
                    if(Tool.Instance.CheckSDTNV(txtSDT.Text) == false)
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

            if (acc == null)
            {
                c.ID = BLL_Account.Instance.getAccountByIDMax().ID;   
            }else
            {
                c.ID = Convert.ToInt32(txtID.Text.ToString());
                if (txtUserName.Text != acc.UserName)
                {
                    if (Tool.Instance.CheckUserName(txtUserName.Text) == false)
                    {
                        MessageBox.Show("UserName đã bị trùng !",
                        "Lỗi !!!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                        txtUserName.Text = "";
                        return;
                    }
                }
            }
            if(check)
            {
                if(acc != null)
                {
                    acc.UserName = txtUserName.Text;
                    acc.PW = txtPW.Text;
                    acc.trangThai = true;
                    BLL_Account.Instance.EditAccount(acc);
                }
                c.HoVaTen = txtHovaTen.Text;
                c.SDT = txtSDT.Text;
                c.DiaChi = txtAddress.Text;
                c.IDShift = ((CBBItemCaLamViec)cbbCaLamViec.SelectedItem).Value;
                c.TrangThai = true;
                BLL_QLNhanVien.Instance.AddEdit(c);
                this.Dispose();
            }else
            {
                MessageBox.Show("Vui lòng kiểm tra lại các dữ liệu!",
                        "Thông báo lỗi !!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }
        
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(ID == 0)
            {
                BLL_Account.Instance.DeleteAccount(BLL_Account.Instance.getAccountByIDMax().ID);
            }
            this.Dispose();
        }
    }
}
