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
    public partial class NhapHang : Form
    {
        public int IDHang { get; set; }
        public NhapHang(int id)
        {
            InitializeComponent();
            IDHang = id;
            GUI();
        }
        private void GUI()
        {
            txtIDHang.Enabled = false;
            dtpNgayNhapHang.Enabled = false;
            txtIDHang.Text = BLL_HangHoa.Instance.getHangByIDHang(IDHang).ID.ToString(); 
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            bool checkNhap = true;
            HOA_DON_NHAP_HANG h = new HOA_DON_NHAP_HANG();
            h.IDHang = Convert.ToInt32(txtIDHang.Text);
            h.NgayNhapHang = DateTime.Parse(dtpNgayNhapHang.Value.ToString());

            Regex regex = new Regex("^[0-9]+$");
            if(regex.IsMatch(txtSoLuong.Text) == false || regex.IsMatch(txtGiaHoaDon.Text) == false)
            {
                checkNhap = false;
            }else
            {
                if (Convert.ToInt32(txtGiaHoaDon.Text) > Convert.ToInt32(txtSoLuong.Text) * BLL_HangHoa.Instance.getHangByIDHang(IDHang).Gia)
                {
                    MessageBox.Show("Giá nhập đang lớn hơn giá bán !",
                        "Thông báo !", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtGiaHoaDon.Text = "";
                    return;
                }
            }
            if(checkNhap)
            {
                h.SoLuong = Convert.ToInt32(txtSoLuong.Text);
                h.GiaHoaDon = Convert.ToInt32(txtGiaHoaDon.Text);
                BLL_NhapHang.Instance.Add(h);
                HANG i = BLL_HangHoa.Instance.getHangByIDHang(IDHang);
                i.SoLuong += Convert.ToInt32(txtSoLuong.Text);
                BLL_HangHoa.Instance.Edit(i);
                this.Close();
            }else
            {
                DialogResult rs = MessageBox.Show("Vui lòng kiểm tra lại các dữ liệu !",
                        "Thông báo !", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                if (rs == DialogResult.OK)
                {
                    txtGiaHoaDon.Text = "";
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
