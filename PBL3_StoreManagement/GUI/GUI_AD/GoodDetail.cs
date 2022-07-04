using PBL3_StoreManagement.BLL;
using PBL3_StoreManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_StoreManagement.GUI.GUI_AD
{
    public partial class GoodDetail : Form
    {
        public static int ID;
        public GoodDetail(int id)
        {
            InitializeComponent();
            ID = id;
            setCBBLoaiHang();
            setCBBNhaSanXuat();
            txtSoLuong.Enabled = false;
            GUI();
        }
        private void setCBBLoaiHang()
        {
            if(cbbLoaiHang.Items.Count > 0)
            {
                cbbLoaiHang.Items.Clear();
            }
            foreach(CBBItemLoaiHang i in BLL_HangHoa.Instance.getCBBItemLoaiHangs())
            {
                cbbLoaiHang.Items.Add(i);
            }
        }
        private void setCBBNhaSanXuat()
        {
            if (cbbNhaSanXuat.Items.Count > 0) cbbNhaSanXuat.Items.Clear();
            foreach(CBBItemNhaSanxuat i in BLL_HangHoa.Instance.getAllNSXs())
            {
                cbbNhaSanXuat.Items.Add(i);
            }
        }
        private void GUI()
        {
            if(ID > 0)
            {
                labelThem.Dispose();
                txtID.Text = BLL_HangHoa.Instance.getHangByIDHang(ID).ID+"";
                txtID.Enabled = false;
                txtTenMatHang.Text = BLL_HangHoa.Instance.getHangByIDHang(ID).TenMatHang;
                foreach(CBBItemLoaiHang i in cbbLoaiHang.Items)
                {
                    if(i.Value == BLL_HangHoa.Instance.getHangByIDHang(ID).IDLoaiHang)
                    {
                        cbbLoaiHang.SelectedItem = i;
                        break;
                    }
                }
                foreach(CBBItemNhaSanxuat i in cbbNhaSanXuat.Items)
                {
                    if(i.Value == BLL_HangHoa.Instance.getHangByIDHang(ID).IDNhaSX)
                    {
                        cbbNhaSanXuat.SelectedItem = i;
                        break;
                    }
                }
                txtGia.Text = BLL_HangHoa.Instance.getHangByIDHang(ID).Gia + "";
                dateTimePickerHSD.Value = BLL_HangHoa.Instance.getHangByIDHang(ID).HSD;
                txtSoLuong.Text = BLL_HangHoa.Instance.getHangByIDHang(ID).SoLuong + "";
            }else
            {
                IDlabel.Dispose();
                txtID.Dispose();
                txtSoLuong.Text = 0 + "";
                soLuongLabel.Dispose();
                txtSoLuong.Dispose();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            HANG h = new HANG();
            bool check = true;
            if (txtID.Text != "")
            {
                h.ID = Convert.ToInt32(txtID.Text.ToString());
            }
            if(txtTenMatHang.Text == "")
            {
                check = false; 
            }else
            {
                if (ID > 0)
                {
                    if (txtTenMatHang.Text != BLL_HangHoa.Instance.getHangByIDHang(ID).TenMatHang)
                    {
                        if (CheckTenHang(txtTenMatHang.Text) == false)
                        {
                            check = false;
                            MessageBox.Show("Tên mặt hàng đã bị trùng !",
                            "Lỗi !!", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                            txtTenMatHang.Text = "";
                            return;
                        }
                    }
                }
                else
                {
                    if (CheckTenHang(txtTenMatHang.Text) == false)
                    {
                        check = false;
                        MessageBox.Show("Tên mặt hàng đã bị trùng !",
                        "Lỗi !!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                        txtTenMatHang.Text = "";
                        return;
                    }
                }
            }
            
            if(cbbLoaiHang.Text == "" || cbbNhaSanXuat.Text == "" || txtGia.Text == "" || txtSoLuong.Text == "")
            {
                check = false;
            }
            
            if(DateTime.Parse(dateTimePickerHSD.Value.ToString()).Date <= DateTime.Now.Date)
            {
                errorProvider1.SetError(dateTimePickerHSD, "Hạn sử dụng không hợp lệ !");
                check = false;
            }else
            {
                errorProvider1.Dispose();
            }

            Regex regex = new Regex("^[0-9]+$");
            if (regex.IsMatch(txtGia.Text))
            {
                h.Gia = Convert.ToInt32(txtGia.Text.ToString());
            }else
            {
                txtGia.Text = "";
                check = false;
            }

            if(regex.IsMatch(txtSoLuong.Text)== false)
            {
                txtSoLuong.Text = "";
                check = false;
            }else
            {
                h.SoLuong = Convert.ToInt32(txtSoLuong.Text);
            }
            
            
            if (check)
            {
                h.TenMatHang = txtTenMatHang.Text;
                if (FindLoaiHang(cbbLoaiHang.Text) == -1)
                {
                    BLL_HangHoa.Instance.AddLoaiHang(new LOAI_HANG
                    {
                        TenLoaiHang = cbbLoaiHang.Text,
                    });
                    h.IDLoaiHang = BLL_HangHoa.Instance.getIDLoaiHangMax().ID;
                }else
                {
                    h.IDLoaiHang = FindLoaiHang(cbbLoaiHang.Text);
                }
                
                if (FindNhaSX(cbbNhaSanXuat.Text) == -1)
                {
                    BLL_HangHoa.Instance.AddNhaSX(new NHA_SAN_XUAT { TenNhaSX = cbbNhaSanXuat.Text });
                    h.IDNhaSX = BLL_HangHoa.Instance.getIDNSXMax().ID;
                }else
                {
                    h.IDNhaSX = FindNhaSX(cbbNhaSanXuat.Text);
                }
                h.HSD = DateTime.Parse(dateTimePickerHSD.Value.ToString()).Date;
                h.trangThai = true;
                BLL_HangHoa.Instance.AddEditHang(h);
                this.Close();
            }else
            {
                MessageBox.Show("Vui lòng kiểm tra các thông tin dữ liệu !",
                        "Thông báo lỗi", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }
        private bool CheckTenHang(string msg)
        {
            bool check = true;
            foreach(HangView i in BLL_HangHoa.Instance.getAllHangView())
            {
                if(i.TenMatHang == msg)
                {
                    check = false;
                    break;
                }
            }
            return check;
        }
        private int FindLoaiHang(string msg)
        {
            int check = -1;
            foreach (CBBItemLoaiHang i in cbbLoaiHang.Items)
            {
                if (i.Text == msg)
                {
                    check = i.Value;
                    break;
                }
            }
            return check;
        }
        private int FindNhaSX(string msg)
        {
            int check = -1;
            foreach (CBBItemNhaSanxuat i in cbbNhaSanXuat.Items)
            {
                if (i.Text == msg)
                {
                    check = i.Value;
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
