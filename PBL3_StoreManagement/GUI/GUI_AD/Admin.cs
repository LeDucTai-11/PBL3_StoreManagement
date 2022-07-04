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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            
        }

        private void TongQuantoolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelTongQuan.Visible = true;
            panelHoaDon.Visible = false;
            panelDSNhanvien.Visible = false;
            panelDanhsachHH.Visible = false;
            paneIThongtinKH.Visible = false;
            panelHoadonNhaphang.Visible = false;
            panelAccountNV.Visible = false;

            cbbTQCuahang.SelectedIndex = 0;
            ThongKeToDay();
            listMatHangHOT.Visible = true;
            setRecentBill();
            setListBanChay();
            setChart();

        }
        
        private void Admin_Load(object sender, EventArgs e)
        {
            panelTongQuan.Visible = true;
            panelHoaDon.Visible = false;
            panelDSNhanvien.Visible = false;
            panelDanhsachHH.Visible = false;
            paneIThongtinKH.Visible = false;
            panelHoadonNhaphang.Visible = false;
            panelAccountNV.Visible = false;

            cbbTQCuahang.SelectedIndex = 0;
            ThongKeToDay();
            listMatHangHOT.Visible = true;
            setRecentBill();
            setListBanChay();
            setChart();

        }
        private void setListBanChay()
        {
            if (listMatHangHOT.Items.Count > 0) listMatHangHOT.Items.Clear();
            listMatHangHOT.Items.AddRange(BLL_TongQuan.Instance.setListBanchay().Distinct().Take(10).ToArray());
        }
        private void setRecentBill()
        {
            if(listDonGanDay.Items.Count > 0) listDonGanDay.Items.Clear();
            listDonGanDay.Items.AddRange(BLL_TongQuan.Instance.getListRecentBill().ToArray());
        }
        public void setChart()
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            foreach (int i in BLL_TongQuan.Instance.weekOfChart())
            {
                chart1.Series["Doanh thu"].Points.AddXY("", i);
            }
        }
        private void ThongKeToDay()
        {
            lbNumSDH_TongQuan.Text = BLL_HoaDon.Instance.SoDonHangToday() + "";
            lbDoanhThu_TongQuan.Text = Tool.Instance.Tranf_Money(BLL_HoaDon.Instance.DoanhThuToday()) + " VND";
            lblSoDonNhapHang.Text = BLL_HoaDon.Instance.HoaDonNhapHangToday() + "";
        }
        private void ThongKeTheoThang()
        {
            lbNumSDH_TongQuan.Text = BLL_HoaDon.Instance.SoDonHangMonth() + "";
            lbDoanhThu_TongQuan.Text = Tool.Instance.Tranf_Money(BLL_HoaDon.Instance.DoanhThuMonth()) + " VND";
            lblSoDonNhapHang.Text = BLL_HoaDon.Instance.HoaDonNhapHangMonth() + "";
        }
        private void cbbTQCuahang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbTQCuahang.SelectedIndex == 0)
            {
                ThongKeToDay();
            }else if(cbbTQCuahang.SelectedIndex == 1)
            {
                ThongKeTheoThang();
            }
        }
        private void HangHoatoolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelTongQuan.Visible = false;
            panelHoaDon.Visible = false;
            panelDSNhanvien.Visible = false;
            panelDanhsachHH.Visible = true;
            paneIThongtinKH.Visible = false;
            panelHoadonNhaphang.Visible = false;
            panelAccountNV.Visible = false;
            setCBBLoaiHang();
            cbbLoaiHang_DSHH.SelectedIndex = 0;
        }
        private void KhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelTongQuan.Visible = false;
            panelHoaDon.Visible = false;
            panelDSNhanvien.Visible = false;
            panelDanhsachHH.Visible = false;
            paneIThongtinKH.Visible = true;
            panelHoadonNhaphang.Visible = false;
            panelAccountNV.Visible = false;
            ShowAllKhachHang("");
        }
        private void HoaDonNhapHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelTongQuan.Visible = false;
            panelHoaDon.Visible = false;
            panelDSNhanvien.Visible = false;
            panelDanhsachHH.Visible = false;
            paneIThongtinKH.Visible = false;
            panelHoadonNhaphang.Visible = true;
            panelAccountNV.Visible = false;
            setCBBNSX_NhapHang();
            cbbNSX_NhapHang.SelectedIndex = 0;
        }
        private void HoaDonBanHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelTongQuan.Visible = false;
            panelHoaDon.Visible = true;
            panelDSNhanvien.Visible = false;
            panelDanhsachHH.Visible = false;
            paneIThongtinKH.Visible = false;
            panelHoadonNhaphang.Visible = false;
            panelAccountNV.Visible = false;
            SetHoaDonBanHang();
            cbbNhanVien_HoaDonBanHang.SelectedIndex = 0;
        }
        private void danhSachNVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelTongQuan.Visible = false;
            panelHoaDon.Visible = false;
            panelDSNhanvien.Visible = true;
            panelDanhsachHH.Visible = false;
            paneIThongtinKH.Visible = false;
            panelHoadonNhaphang.Visible = false;
            panelAccountNV.Visible = false;
            setCBBCaLamViec();
            cbbCaLamViec_DSNhanVien.SelectedIndex = 0;
        }
        private void accountNVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelTongQuan.Visible = false;
            panelHoaDon.Visible = false;
            panelDSNhanvien.Visible = false;
            panelDanhsachHH.Visible = false;
            paneIThongtinKH.Visible = false;
            panelHoadonNhaphang.Visible = false;
            panelAccountNV.Visible = true;
            ShowAllAccountNV();
        }
        private void DangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void DoiMatKhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword f = new ChangePassword(1);
            f.ShowDialog();
            if (ChangePassword.checkLogin == true)
            {
                MessageBox.Show("Thay đổi mật khẩu thành công !! Vui lòng đăng nhập lại", "Thành công !!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
        }

        // -------------------------BEGIN : Quản lý Hàng Hóa------------------------------ 
        private void setCBBLoaiHang()
        {
            if(cbbLoaiHang_DSHH.Items.Count > 0)
            {
                cbbLoaiHang_DSHH.Items.Clear();
            }
            cbbLoaiHang_DSHH.Items.Add(new CBBItemLoaiHang
            {
                Value = 0,Text = "All"
            });
            foreach(CBBItemLoaiHang i in BLL_HangHoa.Instance.getCBBItemLoaiHangs())
            {
                cbbLoaiHang_DSHH.Items.Add(i);
            }
        }
        private void cbbLoaiHang_DSHH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbNSX_DSHH.Items.Count > 0) cbbNSX_DSHH.Items.Clear();
            cbbNSX_DSHH.Items.Add(new CBBItemNhaSanxuat { Value = 0, Text = "All" });
            if (cbbLoaiHang_DSHH.SelectedIndex > 0)
            {
                cbbNSX_DSHH.Items.AddRange(BLL_HangHoa.Instance.getAllNSXByLoaiHang(((CBBItemLoaiHang)cbbLoaiHang_DSHH.SelectedItem).Value).ToArray());
            }else
            {
                cbbNSX_DSHH.Items.AddRange(BLL_HangHoa.Instance.getAllNSXs().ToArray());
            }
            ShowAllHangDGV(((CBBItemLoaiHang)cbbLoaiHang_DSHH.SelectedItem).Value, 0, "");
            cbbNSX_DSHH.SelectedIndex = 0;
        }
        private void cbbNSX_DSHH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbNSX_DSHH.SelectedIndex != -1)
            {
                ShowAllHangDGV(((CBBItemLoaiHang)cbbLoaiHang_DSHH.SelectedItem).Value,
                    ((CBBItemNhaSanxuat)cbbNSX_DSHH.SelectedItem).Value, "");
            }
        }
        private void setWidthDGVHangHoa()
        {
            dgvDSHH_DSHH.Columns[0].Width = (int)(dgvDSHH_DSHH.Width * 0.05);
            dgvDSHH_DSHH.Columns[1].Width = (int)(dgvDSHH_DSHH.Width * 0.25);
            dgvDSHH_DSHH.Columns[2].Width = (int)(dgvDSHH_DSHH.Width * 0.2);
            dgvDSHH_DSHH.Columns[3].Width = (int)(dgvDSHH_DSHH.Width * 0.15);
            dgvDSHH_DSHH.Columns[4].Width = (int)(dgvDSHH_DSHH.Width * 0.075);
            dgvDSHH_DSHH.Columns[5].Width = (int)(dgvDSHH_DSHH.Width * 0.125);
            dgvDSHH_DSHH.Columns[6].Width = (int)(dgvDSHH_DSHH.Width * 0.1);
        }
        private void ShowAllHangDGV(int id_LH,int id_NSX,string msg)
        {
            dgvDSHH_DSHH.DataSource = BLL_HangHoa.Instance.getAllHangView(id_LH,id_NSX,msg);
            dgvDSHH_DSHH.ClearSelection();
            setDgvHangColHeaderText();
            setWidthDGVHangHoa();
        }
        private void setDgvHangColHeaderText()
        {
            dgvDSHH_DSHH.Columns[0].HeaderText = "ID";
            dgvDSHH_DSHH.Columns[1].HeaderText = "Tên mặt hàng";
            dgvDSHH_DSHH.Columns[2].HeaderText = "Loại hàng";
            dgvDSHH_DSHH.Columns[3].HeaderText = "Nhà sản xuất";
            dgvDSHH_DSHH.Columns[4].HeaderText = "Giá bán";
            dgvDSHH_DSHH.Columns[5].HeaderText = "Hạn sử dụng";
            dgvDSHH_DSHH.Columns[6].HeaderText = "Số lượng";
        }
        private void btnSearch_DSHH_Click(object sender, EventArgs e)
        {
            if(cbbLoaiHang_DSHH.SelectedIndex != -1)
            {
                ShowAllHangDGV(((CBBItemLoaiHang)cbbLoaiHang_DSHH.SelectedItem).Value,
                    ((CBBItemNhaSanxuat)cbbNSX_DSHH.SelectedItem).Value, txtSearchTen_DSHH.Text);
            }
        }

        private void btnAdd_DSHH_Click(object sender, EventArgs e)
        {
            GoodDetail f = new GoodDetail(0);
            f.ShowDialog();
            setCBBLoaiHang();
            cbbLoaiHang_DSHH.SelectedIndex = 0;
            ShowAllHangDGV(0,0,"");
        }

        private void btnEdit_DSHH_Click(object sender, EventArgs e)
        {
            if(dgvDSHH_DSHH.SelectedRows.Count == 1)
            {
                GoodDetail f = new GoodDetail(Convert.ToInt32(dgvDSHH_DSHH.SelectedRows[0].Cells["ID"].Value.ToString()));
                f.ShowDialog();
                setCBBLoaiHang();
                cbbLoaiHang_DSHH.SelectedIndex = 0;
                ShowAllHangDGV(0,0,"");
            }
        }

        private void btnDelete_DSHH_Click(object sender, EventArgs e)
        {
            if(dgvDSHH_DSHH.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow i in dgvDSHH_DSHH.SelectedRows)
                    {
                        BLL_HangHoa.Instance.
                            Delete(Convert.ToInt32(i.Cells["ID"].Value.ToString()));
                    }
                }
                ShowAllHangDGV(0,0,"");
            }
        }

        private void btnSort_DSHH_Click(object sender, EventArgs e)
        {
            if(cbbSort_DSHH.SelectedIndex != -1)
            {
                dgvDSHH_DSHH.DataSource = BLL_HangHoa.Instance.SortHang(cbbSort_DSHH.Text);
            }
        }
        private void dgvDSHH_DSHH_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            contextNhapHang.Show(this.PointToClient(MousePosition));
        }
        private void NhapHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDSHH_DSHH.SelectedRows.Count == 1)
            {
                NhapHang f = new NhapHang(Convert.ToInt32(dgvDSHH_DSHH.SelectedRows[0].Cells["ID"].Value.ToString()));
                f.ShowDialog();
                ShowAllHangDGV(0, 0, "");
            }
        }

        // ----------------------------END :Quản Lý Hàng Hóa----------------------------------- 


        // ----------------------------BEGIN :Quản Lý Nhân Viên----------------------------------- 
        private void setCBBCaLamViec()
        {
            if(cbbCaLamViec_DSNhanVien.Items.Count > 0)
            {
                cbbCaLamViec_DSNhanVien.Items.Clear();
            }
            cbbCaLamViec_DSNhanVien.Items.Add(new CBBItemCaLamViec
            {
                Value = 0,Text = "All"
            });
            foreach(CBBItemCaLamViec i in BLL_QLNhanVien.Instance.GetCBBItemCaLamViecs())
            {
                cbbCaLamViec_DSNhanVien.Items.Add(i);
            }
        }
        private void setWidthDGVNhanVien()
        {
            dgvdsNhanVien_DSNhanVien.Columns[0].Width = (int)(dgvdsNhanVien_DSNhanVien.Width * 0.05);
            dgvdsNhanVien_DSNhanVien.Columns[1].Width = (int)(dgvdsNhanVien_DSNhanVien.Width * 0.2);
            dgvdsNhanVien_DSNhanVien.Columns[2].Width = (int)(dgvdsNhanVien_DSNhanVien.Width * 0.1);
            dgvdsNhanVien_DSNhanVien.Columns[3].Width = (int)(dgvdsNhanVien_DSNhanVien.Width * 0.15);
            dgvdsNhanVien_DSNhanVien.Columns[4].Width = (int)(dgvdsNhanVien_DSNhanVien.Width * 0.1);
            dgvdsNhanVien_DSNhanVien.Columns[5].Width = (int)(dgvdsNhanVien_DSNhanVien.Width * 0.15);
            dgvdsNhanVien_DSNhanVien.Columns[6].Width = (int)(dgvdsNhanVien_DSNhanVien.Width * 0.1);
            dgvdsNhanVien_DSNhanVien.Columns[7].Width = (int)(dgvdsNhanVien_DSNhanVien.Width * 0.115);
        }
        public void ShowAllNhanVienDGV(int id,string txt)
        {
            dgvdsNhanVien_DSNhanVien.DataSource = BLL_QLNhanVien.Instance.getAllNhanVien(id, txt);
            dgvdsNhanVien_DSNhanVien.ClearSelection();
            setDgvNhanvienColHeaderText();
            setWidthDGVNhanVien();
        }
        private void setDgvNhanvienColHeaderText()
        {
            dgvdsNhanVien_DSNhanVien.Columns[0].HeaderText = "ID";
            dgvdsNhanVien_DSNhanVien.Columns[1].HeaderText = "Tên nhân viên";
            dgvdsNhanVien_DSNhanVien.Columns[2].HeaderText = "Giới tính";
            dgvdsNhanVien_DSNhanVien.Columns[3].HeaderText = "Số điện thoại";
            dgvdsNhanVien_DSNhanVien.Columns[4].HeaderText = "Địa chỉ";
            dgvdsNhanVien_DSNhanVien.Columns[5].HeaderText = "Username";
            dgvdsNhanVien_DSNhanVien.Columns[6].HeaderText = "Password";
            dgvdsNhanVien_DSNhanVien.Columns[7].HeaderText = "Ca làm việc";
        }
        private void cbbCaLamViec_DSNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbCaLamViec_DSNhanVien.SelectedIndex != -1)
            {
                ShowAllNhanVienDGV(((CBBItemCaLamViec)cbbCaLamViec_DSNhanVien.SelectedItem).Value,"");
            }
        }
        private void btnSearch_DSNhanVien_Click(object sender, EventArgs e)
        {
            if(cbbCaLamViec_DSNhanVien.SelectedIndex != -1)
            {
                ShowAllNhanVienDGV(((CBBItemCaLamViec)cbbCaLamViec_DSNhanVien.SelectedItem).Value,
                    txtSearch_DSNhanVien.Text);
            }
        }

        private void btnAdd_DSNhanVien_Click(object sender, EventArgs e)
        {
            GUI_AD.AccountDetail f = new AccountDetail(0);
            f.ShowDialog();
            cbbCaLamViec_DSNhanVien.SelectedIndex = 0;
            ShowAllNhanVienDGV(0, "");
        }

        private void btnEdit_DSNhanVien_Click(object sender, EventArgs e)
        {
            if(dgvdsNhanVien_DSNhanVien.SelectedRows.Count == 1)
            {
                GUI_AD.CashierDetail f = new CashierDetail(Convert.ToInt32(dgvdsNhanVien_DSNhanVien.SelectedRows[0].Cells["ID"].Value.ToString()));
                f.ShowDialog();
                cbbCaLamViec_DSNhanVien.SelectedIndex = 0;
                ShowAllNhanVienDGV(0, "");
            }
            
        }

        private void btnDelete_DSNhanVien_Click(object sender, EventArgs e)
        {
            if(dgvdsNhanVien_DSNhanVien.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow i in dgvdsNhanVien_DSNhanVien.SelectedRows)
                    {
                        BLL_QLNhanVien.Instance.Delete(Convert.ToInt32(i.Cells["ID"].Value.ToString()));
                        BLL_Account.Instance.DeleteAccount(Convert.ToInt32(i.Cells["ID"].Value.ToString()));
                    }
                }
                ShowAllNhanVienDGV(0, "");
            }
        }

        private void btnSort_DSNhanVien_Click(object sender, EventArgs e)
        {
            if(cbbSapxep_DSNhanVien.SelectedIndex != -1)
            {
                dgvdsNhanVien_DSNhanVien.DataSource = BLL_QLNhanVien.Instance.Sort(cbbSapxep_DSNhanVien.Text);
            }
        }





        //---------------------------------------Quản lý Khách Hàng------------------
        private void ShowAllKhachHang(string msg)
        {
            dgvKhachHang_ThongtinKH.DataSource = BLL_KhachHang.Instance.getAllKH(msg);
            dgvKhachHang_ThongtinKH.ClearSelection();
            setDgvTTKhachhangColHeaderText();
            dgvKhachHang_ThongtinKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void setDgvTTKhachhangColHeaderText()
        {
            dgvKhachHang_ThongtinKH.Columns[0].HeaderText = "ID";
            dgvKhachHang_ThongtinKH.Columns[1].HeaderText = "Tên khách hàng";
            dgvKhachHang_ThongtinKH.Columns[2].HeaderText = "Số điện thoại";
            dgvKhachHang_ThongtinKH.Columns[3].HeaderText = "Số đơn hàng";
            dgvKhachHang_ThongtinKH.Columns[4].HeaderText = "Số tiền đã thanh toán";
        }
        private void btnSearch_KhachHang_Click(object sender, EventArgs e)
        {
            ShowAllKhachHang(txtSearch_KhachHang.Text);
        }

        private void btnAdd_KhachHang_Click(object sender, EventArgs e)
        {
            CustomerDetail f = new CustomerDetail(0);
            f.ShowDialog();
            ShowAllKhachHang("");
        }

        private void btnEdit_KhachHang_Click(object sender, EventArgs e)
        {
            if(dgvKhachHang_ThongtinKH.SelectedRows.Count == 1)
            {
                CustomerDetail f = new CustomerDetail(Convert.ToInt32(dgvKhachHang_ThongtinKH.SelectedRows[0].Cells["ID"].Value.ToString()));
                f.ShowDialog();
                ShowAllKhachHang("");
            }
        }

        private void btnDelete_KhachHang_Click(object sender, EventArgs e)
        {
            if(dgvKhachHang_ThongtinKH.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow i in dgvKhachHang_ThongtinKH.SelectedRows)
                    {
                        int id = Convert.ToInt32(i.Cells["ID"].Value.ToString());
                        BLL_KhachHang.Instance.Delete(id);
                    }
                }
                ShowAllKhachHang("");
            }
        }

        private void btnSort_KhachHang_Click(object sender, EventArgs e)
        {
            if(cbbSort_KhachHang.SelectedIndex != -1)
            {
                dgvKhachHang_ThongtinKH.DataSource = BLL_KhachHang.Instance.Sort(cbbSort_KhachHang.SelectedItem.ToString());
            }
        }




        //-----------------------------------------Hóa Đơn Nhập Hàng-------------------------
        private void setCBBNSX_NhapHang()
        {
            if(cbbNSX_NhapHang.Items.Count > 0)
            {
                cbbNSX_NhapHang.Items.Clear();
            }
            cbbNSX_NhapHang.Items.Add(new CBBItemNhaSanxuat { Value = 0, Text = "All" });
            foreach(CBBItemNhaSanxuat i in BLL_HangHoa.Instance.getAllNSXs())
            {
                cbbNSX_NhapHang.Items.Add(i);
            }
        }

        private void setWidthDGVHoaDonNhapHang()
        {
            dgvHoadonNhaphang.Columns[0].Width = (int)(dgvHoadonNhaphang.Width * 0.05);
            dgvHoadonNhaphang.Columns[1].Width = (int)(dgvHoadonNhaphang.Width * 0.3);
            dgvHoadonNhaphang.Columns[2].Width = (int)(dgvHoadonNhaphang.Width * 0.2);
            dgvHoadonNhaphang.Columns[3].Width = (int)(dgvHoadonNhaphang.Width * 0.15);
            dgvHoadonNhaphang.Columns[4].Width = (int)(dgvHoadonNhaphang.Width * 0.1);
            dgvHoadonNhaphang.Columns[5].Width = (int)(dgvHoadonNhaphang.Width * 0.15);
        }
        public void ShowAllHoaDonNhapHang(int id_NSX,string msg)
        {
            dgvHoadonNhaphang.DataSource = BLL_NhapHang.Instance.getAllHoaDonNhapHang(id_NSX,msg);
            dgvHoadonNhaphang.ClearSelection();
            setDGVNhaphangColHeaderText();
            setWidthDGVHoaDonNhapHang();
        }
        private void cbbNSX_NhapHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbNSX_NhapHang.SelectedIndex != -1)
            {
                ShowAllHoaDonNhapHang(((CBBItemNhaSanxuat)cbbNSX_NhapHang.SelectedItem).Value,"");
            }
        }
        private void btnHDNHSearch_Click(object sender, EventArgs e)
        {
            if(cbbNSX_NhapHang.SelectedIndex != -1)
            {
                ShowAllHoaDonNhapHang(((CBBItemNhaSanxuat)cbbNSX_NhapHang.SelectedItem).Value, txtTenMatHang_NhapHang.Text);
            }
        }
        private void setDGVNhaphangColHeaderText()
        {
            dgvHoadonNhaphang.Columns[0].HeaderText = "ID";
            dgvHoadonNhaphang.Columns[1].HeaderText = "Tên mặt hàng";
            dgvHoadonNhaphang.Columns[2].HeaderText = "Nhà sản xuất";
            dgvHoadonNhaphang.Columns[3].HeaderText = "Số lượng nhập";
            dgvHoadonNhaphang.Columns[4].HeaderText = "Giá nhập";
            dgvHoadonNhaphang.Columns[5].HeaderText = "Ngày nhập";
        }

        //============================ Quản lý Account Nhân Viên =====================
        private void ShowAllAccountNV()
        {
            dgvAccountNV.DataSource = BLL_Account.Instance.getAllAccNhanVien();
            dgvAccountNV.ClearSelection();
            setDgvAccountNVColHeaderText();
            dgvAccountNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnEdit_Acc_Click(object sender, EventArgs e)
        {
            if(dgvAccountNV.SelectedRows.Count == 1)
            {
                AccountDetail f = new AccountDetail(Convert.ToInt32(dgvAccountNV.SelectedRows[0].Cells["ID"].Value.ToString()));
                f.ShowDialog();
                ShowAllAccountNV();
            }
        }

        private void btnDel_Acc_Click(object sender, EventArgs e)
        {
            if(dgvAccountNV.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow i in dgvAccountNV.SelectedRows)
                    {
                        BLL_Account.Instance.DeleteAccount(Convert.ToInt32(i.Cells["ID"].Value.ToString()));
                        BLL_QLNhanVien.Instance.Delete(Convert.ToInt32(i.Cells["ID"].Value.ToString()));
                    }
                }
                ShowAllAccountNV();
            }
        }

        //----------------------- Hóa đơn bán hàng--------------------
        public void SetHoaDonBanHang()
        {
            if (cbbNhanVien_HoaDonBanHang.Items.Count > 0)
            {
                cbbNhanVien_HoaDonBanHang.Items.Clear();
            }
            if (cbbNgayTao_HoaDonBanHang.Items.Count > 0)
            { 
                cbbNgayTao_HoaDonBanHang.Items.Clear(); 
            }
            cbbNhanVien_HoaDonBanHang.Items.Add(new CBBItemNhanVien { Value = 0, Text = "All" });
            cbbNhanVien_HoaDonBanHang.Items.AddRange(BLL_QLNhanVien.Instance.GetCBBItemNhanVien().ToArray());
        }
        private void ShowAllHoaDonBanHang(int idCS,string date)
        {
            dgvHoadon_HoaDonBanHang.DataSource = BLL_HoaDon.Instance.getAllBill(idCS,date);
            dgvHoadon_HoaDonBanHang.ClearSelection();
            setDgvHoadonBanhangColHeaderText();
            dgvHoadon_HoaDonBanHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void cbbNhanVien_HoaDonBanHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbNgayTao_HoaDonBanHang.Items.Count > 0) cbbNgayTao_HoaDonBanHang.Items.Clear();
            cbbNgayTao_HoaDonBanHang.Items.Add(new CBBItemLoaiHang { Value = 0, Text = "All" });
            if(cbbNhanVien_HoaDonBanHang.SelectedIndex == 0)
            {
                foreach(DateTime i in BLL_HoaDon.Instance.getAllDateInHoaDon().Distinct())
                {
                    cbbNgayTao_HoaDonBanHang.Items.Add(i);
                }
            }else
            {
                foreach (DateTime i in BLL_HoaDon.Instance.GetNgayTaobyidCS(((CBBItemNhanVien)cbbNhanVien_HoaDonBanHang.SelectedItem).Value).Distinct())
                {
                    cbbNgayTao_HoaDonBanHang.Items.Add(i);
                }
            }
            cbbNgayTao_HoaDonBanHang.SelectedIndex = 0;
        }

        private void cbbNgayTao_HoaDonBanHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowAllHoaDonBanHang(((CBBItemNhanVien)cbbNhanVien_HoaDonBanHang.SelectedItem).Value, cbbNgayTao_HoaDonBanHang.SelectedItem.ToString());
        }

        

        private void dgvHoadon_HoaDonBanHang_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvHoadon_HoaDonBanHang.SelectedRows.Count == 1)
            {
                DetailBill frm = new DetailBill(Convert.ToInt32(dgvHoadon_HoaDonBanHang.SelectedRows[0].Cells[0].Value));
                frm.ShowDialog();
            }
        }
        //update
        private void setDgvHoadonBanhangColHeaderText()
        {
            dgvHoadon_HoaDonBanHang.Columns[0].HeaderText = "ID";
            dgvHoadon_HoaDonBanHang.Columns[1].HeaderText = "Tên nhân viên";
            dgvHoadon_HoaDonBanHang.Columns[2].HeaderText = "Thời gian";
            dgvHoadon_HoaDonBanHang.Columns[3].HeaderText = "Tổng tiền";
            dgvHoadon_HoaDonBanHang.Columns[4].HeaderText = "Tên Khách Hàng";
        }
        private void setDgvAccountNVColHeaderText()
        {
            dgvAccountNV.Columns[0].HeaderText = "ID";
            dgvAccountNV.Columns[1].HeaderText = "Tên nhân viên";
            dgvAccountNV.Columns[2].HeaderText = "Username";
            dgvAccountNV.Columns[3].HeaderText = "Password";
        }
    }
}
