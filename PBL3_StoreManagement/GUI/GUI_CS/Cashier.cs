
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;
using PBL3_StoreManagement.DTO;
using PBL3_StoreManagement.GUI;
using PBL3_StoreManagement.BLL;
using System.IO;

namespace PBL3_StoreManagement.GUI.GUI_CS
{
    public partial class Cashier : Form
    {
        public int IdCashier { get; set; }
        public Cashier(int IdCS)
        {
            InitializeComponent();
            IdCashier = IdCS;
        }
        private void Cashier_Load(object sender, EventArgs e)
        {
            panelDatHang.Visible = false;
            panelBaocao.Visible = false;
            panelDSKhachhang.Visible = false;
            panelTongQuan.Visible = true;
            SetpanelTongQuan();
        }
        private void TongQuanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelDatHang.Visible = false;
            panelBaocao.Visible = false;
            panelDSKhachhang.Visible = false;
            panelTongQuan.Visible = true;
            SetpanelTongQuan();
        }
        private void DatHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelDatHang.Visible = true;
            panelBaocao.Visible = false;
            panelDSKhachhang.Visible = false;
            panelTongQuan.Visible = false;
            SetDathang();
        }
        private void BaoCaoKhoHangToolStripMenuItem_Click(object sender, EventArgs e)
        {

            panelBaocao.Visible = true;
            panelDSKhachhang.Visible = false;
            panelDatHang.Visible = false;
            panelTongQuan.Visible = false;
            SetBaoCao();

        }
        private void DanhSachKHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelBaocao.Visible = false;
            panelDSKhachhang.Visible = true;
            panelDatHang.Visible = false;
            panelTongQuan.Visible = false;
            ShowAllDGVKhachHang("");
            txtIDKH.Enabled = false;
            ResetGUIKH();
        }
        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            ChangePassword f = new ChangePassword(IdCashier);
            f.ShowDialog();
            if(ChangePassword.checkLogin == true)
            {
                MessageBox.Show("Thay đổi mật khẩu thành công !! Vui lòng đăng nhập lại", "Thành công !!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
        }
        private void DangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void Cashier_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (BLL_HoaDon.IDBILLNOW != -1)
            {
                BLL_HoaDon.Instance.DeleteALLBill();
                ResetGUITaoHoadon();
            }
        }
        //Tổng quan
        public void SetpanelTongQuan()
        {
            lbThuNgay.Text = DateTime.Now.ToString("'Hôm nay ngày ' dd 'tháng' MM 'năm ' yyyy',' ");
            //pictureBox1.Image = Image.FromFile(@"G:\Hoc C#\PBL3_StoreManagement\PBL3_StoreManagement\FileAnhPBL\picture" + IdCashier + ".jpg");
            if(File.Exists(@"G:\Hoc C#\PBL3_StoreManagement\PBL3_StoreManagement\FileAnhPBL\picture" + IdCashier + ".jpg"))
            {
                pictureBox1.Image = Image.FromFile(@"G:\Hoc C#\PBL3_StoreManagement\PBL3_StoreManagement\FileAnhPBL\picture" + IdCashier + ".jpg");
            }else
            {
                pictureBox1.Image = Image.FromFile(@"G:\Hoc C#\PBL3_StoreManagement\PBL3_StoreManagement\FileAnhPBL\1.jpg");
            }
            lbID.Text = BLL_QLNhanVien.Instance.getNhanVienByID(IdCashier).ID.ToString();
            lbHovaten.Text = BLL_QLNhanVien.Instance.getNhanVienByID(IdCashier).HoVaTen.ToString();
            lbDiaChi.Text = BLL_QLNhanVien.Instance.getNhanVienByID(IdCashier).DiaChi;
            lbGioiTinh.Text = (BLL_QLNhanVien.Instance.getNhanVienByID(IdCashier).GioiTinh == true) ? "Nam" : "Nữ";
            lbSDT.Text = BLL_QLNhanVien.Instance.getNhanVienByID(IdCashier).SDT;
            lbTQ_Calamviec.Text = BLL_QLNhanVien.Instance.getNhanVienByID(IdCashier).CA_LAM_VIEC.batDau.TimeOfDay.ToString() + " đến "
                + BLL_QLNhanVien.Instance.getNhanVienByID(IdCashier).CA_LAM_VIEC.ketThuc.TimeOfDay.ToString();
        }
        // Đặt hàng
        public void SetDathang()
        {
            if (cbbLoaiHang_TaoHoaDon.Items.Count > 0)
            {
                cbbLoaiHang_TaoHoaDon.Items.Clear();
            }
            if (cbbDHKhachHang.Items.Count > 0) {
                cbbDHKhachHang.Items.Clear(); 
            }
            cbbLoaiHang_TaoHoaDon.Items.Add(new CBBItemLoaiHang { Value = 0, Text= "ALL" });
            cbbLoaiHang_TaoHoaDon.Items.AddRange(BLL_HangHoa.Instance.getCBBItemLoaiHangs().ToArray());
            cbbDHKhachHang.Items.AddRange(BLL_KhachHang.Instance.getAllCBBKhachHang().ToArray());
            cbbLoaiHang_TaoHoaDon.SelectedIndex = 0;
            BLL_HoaDon.Instance.CreateNewBill(IdCashier);
            dgvBill.DataSource = null;
            ResetGUITaoHoadon();
        }
        public void ShowAllDGVHang(int id_LH,string msg)
        {
            dgvListHangHoa_TaoHoaDon.DataSource = BLL_HangHoa.Instance.getAllHangView(id_LH,0,msg);
            setDgvListHangColHeaderText();
        }
        private void cbbLoaiHang_TaoHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowAllDGVHang(((CBBItemLoaiHang)cbbLoaiHang_TaoHoaDon.SelectedItem).Value, "");
        }
        private void btnSearch_ToaHoaDon_Click(object sender, EventArgs e)
        {
            ShowAllDGVHang(((CBBItemLoaiHang)cbbLoaiHang_TaoHoaDon.SelectedItem).Value,txtSearch_TaoHoaDon.Text);
        }
        private void dgvDHbangMH_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(dgvListHangHoa_TaoHoaDon.SelectedRows.Count == 1)
            {
                BLL_HoaDon.Instance.OderHang(Convert.ToInt32(dgvListHangHoa_TaoHoaDon.SelectedRows[0].Cells["ID"].Value.ToString()));
                ShowBillDetail();
            }
        }
        private void ShowBillDetail()
        {
            dgvBill.DataSource = BLL_HoaDon.Instance.DisplayBill(BLL_HoaDon.IDBILLNOW);
            lbDHTongTien.Text = Tool.Instance.Tranf_Money((int)(BLL_HoaDon.Instance.Update_Bill(-1).TongTien));
            lbDHThanhtien.Text = Tool.Instance.Tranf_Money((int)(BLL_HoaDon.Instance.Update_Bill(-1).TongTien));
            ShowAllDGVHang(((CBBItemLoaiHang)cbbLoaiHang_TaoHoaDon.SelectedItem).Value, "");
            txtSearch_TaoHoaDon.Text = "";
            setDgvBill1ColHeaderText();
        }
        private void stcbxnhapsoluong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Regex regex = new Regex("^[0-9]+$");
                string s = ((ToolStripTextBox)sender).Text;
                if (regex.IsMatch(s))
                {
                    if (Convert.ToInt32(s) > 0)
                    {
                        BLL_HoaDon.Instance.Update_DetailBill(Convert.ToInt32(dgvBill.SelectedRows[0].Cells["ID"].Value), Convert.ToInt32(s));
                        tsnhapsoluong.Clear();
                        ctmsDHdathang.Close();
                        ShowBillDetail();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số lượng");
                    tsnhapsoluong.Clear();
                    ctmsDHdathang.Close();
                }
            }
        }
        private void btDHthanhToan_Click(object sender, EventArgs e)
        {
            if (txtTienKhachTra.Text.Length > 0 && BLL_HoaDon.Instance.DisplayBill(BLL_HoaDon.IDBILLNOW).Count > 0)
            {
                if (MessageBox.Show("Bạn có muốn in hóa đơn không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BLL_HoaDon.Instance.Print_Bill();
                }
                XacNhan();
            }
            else MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void tsmDHXoa_Click(object sender, EventArgs e)
        {
            BLL_HoaDon.Instance.DeleteDetailBill(Convert.ToInt32(dgvBill.SelectedRows[0].Cells["ID"].Value));
            ShowBillDetail();
        }
        private void btnHuyBill_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn hủy đơn hàng này không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BLL_HoaDon.Instance.DeleteALLBill();
                ResetGUITaoHoadon();
                XacNhan();
            }
        } 
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (BLL_HoaDon.IDBILLNOW != -1)
            {
                if (MessageBox.Show("Bạn có muốn tiếp tục?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    BLL_HoaDon.Instance.DeleteALLBill();
                    panelDatHang.Visible = false;
                }
                else
                {

                }

            }
        }
        private void dgvBill_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ctmsDHdathang.Show(this.PointToClient(MousePosition));
        }
        public void XacNhan()
        {
            if (MessageBox.Show("Bạn có muốn tiếp tục?", "Thành Công", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.DatHangToolStripMenuItem_Click(null, null);
            }
            else
            {
                panelDatHang.Visible = false;
                BLL_HoaDon.IDBILLNOW = -1;
            }
            ResetGUITaoHoadon();
        }
        private void ResetGUITaoHoadon()
        {
            dgvBill.DataSource = null;
            cbbDHKhachHang.Text = "";
            lbDHTongTien.Text = "";
            lbDHGiamgia.Text = "";
            lbDHThanhtien.Text = "";
            txtTienKhachTra.Text = "";
            txtTienThua.Text = "";
            txtSearch_TaoHoaDon.Text = "";
        }
        private void cbbDHKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            BLL_HoaDon.Instance.Update_Bill(((CBBItemKhachHang)cbbDHKhachHang.SelectedItem).Value);
        }
        private void tbDHkhachTra_KeyDown(object sender, KeyEventArgs e)
        {
            Regex regex = new Regex("^[0-9]+$");
            if (e.KeyCode == Keys.Enter)
            {
                if (regex.IsMatch(txtTienKhachTra.Text))
                {
                    int sum = Convert.ToInt32(txtTienKhachTra.Text) * 1000 - (BLL_HoaDon.Instance.Update_Bill(-1).TongTien);
                    txtTienKhachTra.Text = Tool.Instance.Tranf_Money(Convert.ToInt32(txtTienKhachTra.Text) * 1000);
                    if (sum < 0)
                    {
                        MessageBox.Show("Không đủ tiền", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (sum > 0)
                    {
                        txtTienThua.Text = Tool.Instance.Tranf_Money(sum);
                    }
                    else
                    {
                        txtTienThua.Text = "0";
                    }
                }else
                {
                    MessageBox.Show("Vui lòng nhập số !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }


        // Báo cáo

        public void SetBaoCao()
        {
            lbNameCS.Text = BLL_QLNhanVien.Instance.getNhanVienByID(IdCashier).HoVaTen.ToUpper();
            lbDateTimeNow.Text = DateTime.Now.Day.ToString()+"/"+ DateTime.Now.Month.ToString()+"/"+DateTime.Now.Year.ToString();
            dgvHoaDonBanHang.DataSource = BLL_QLNhanVien.Instance.GetListBillToday(IdCashier);
            setDgvBaocaoColHeaderText();
            dgvHoaDonBanHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvBCsoDH_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvHoaDonBanHang.SelectedRows.Count == 1)
            {
                GUI.DetailBill frm = new GUI.DetailBill(Convert.ToInt32(dgvHoaDonBanHang.SelectedRows[0].Cells["IDBill"].Value));
                frm.ShowDialog();
            }

        }
        //update
        private void setDgvBaocaoColHeaderText()
        {
            dgvHoaDonBanHang.Columns[0].HeaderText = "ID đơn hàng";
            dgvHoaDonBanHang.Columns[1].HeaderText = "Tên nhân viên";
            dgvHoaDonBanHang.Columns[2].HeaderText = "Thời gian";
            dgvHoaDonBanHang.Columns[3].HeaderText = "Tổng tiền";
            dgvHoaDonBanHang.Columns[4].HeaderText = "Tên khách hàng";
        }

        //============================================Khách Hàng===================================
        public void ShowAllDGVKhachHang(string msg)
        {
            dgvDSKH.DataSource = BLL_KhachHang.Instance.getAllKH(msg);
            setViewDgvKH();
            dgvDSKH.ClearSelection();
        }
        private void ResetGUIKH()
        {
            txtIDKH.Text = "";
            txtNameKH.Text = "";
            txtSDT.Text = "";
            btnAddKhachHang.Enabled = true;
            btnEdit_KhachHang.Enabled = false;
        }
        private void btnAddKEdit_KhachHang_Click(object sender, EventArgs e)
        {
            bool check = true;
            KHACH_HANG k = new KHACH_HANG();
            if(txtIDKH.Text != "")
            {
                k.ID = Convert.ToInt32(txtIDKH.Text);
            }
            if(txtNameKH.Text == "")
            {
                check = false;
            }else
            {
                k.TenKhachHang = txtNameKH.Text;
            }
            if (txtSDT.Text.Length != 10)
            {
                txtSDT.Text = "";
                check = false;
            }
            else
            {
                if(txtIDKH.Text == "")
                {
                    if (Tool.Instance.CheckSDTKH(txtSDT.Text) == false)
                    {
                        MessageBox.Show("Số điện thoại đã bị trùng !",
                                "Lỗi !!!", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        txtSDT.Text = "";
                        check = false;
                    }
                }else
                {
                    if (txtSDT.Text != BLL_KhachHang.Instance.getKHByID(Convert.ToInt32(txtIDKH.Text)).SDT)
                    {
                        if (Tool.Instance.CheckSDTKH(txtSDT.Text) == false)
                        {
                            MessageBox.Show("Số điện thoại đã bị trùng !",
                                    "Lỗi !!!", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            txtSDT.Text = "";
                            check = false;
                        }
                    }
                }
            }
            if (check)
            {
                k.SDT = txtSDT.Text;
                k.trangThai = true;
                BLL_KhachHang.Instance.AddEdit(k);
                ShowAllDGVKhachHang("");
                ResetGUIKH();
            }else
            {
                MessageBox.Show("Vui lòng kiểm tra lại các trường dữ liệu !",
                            "Thông báo lỗi !!!", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
        }
        private void dgvDSKH_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(dgvDSKH.SelectedRows.Count == 1)
            {
                txtIDKH.Text = BLL_KhachHang.Instance.getKHByID(Convert.ToInt32(dgvDSKH.SelectedRows[0].Cells["ID"].Value.ToString())).ID+"";
                txtNameKH.Text = BLL_KhachHang.Instance.getKHByID(Convert.ToInt32(dgvDSKH.SelectedRows[0].Cells["ID"].Value.ToString())).TenKhachHang;
                txtSDT.Text = BLL_KhachHang.Instance.getKHByID(Convert.ToInt32(dgvDSKH.SelectedRows[0].Cells["ID"].Value.ToString())).SDT;
                btnAddKhachHang.Enabled = false;
                btnEdit_KhachHang.Enabled = true;
            }
        }

        private void btnSearch_KH_Click(object sender, EventArgs e)
        {
            ShowAllDGVKhachHang(txtSearch_KH.Text);
        }
        private void setViewDgvKH()
        {
            dgvDSKH.Columns[0].HeaderText = "ID";
            dgvDSKH.Columns[1].HeaderText = "Tên khách hàng";
            dgvDSKH.Columns[2].HeaderText = "Số điện thoại";
            dgvDSKH.Columns[3].HeaderText = "Số hóa đơn";
            dgvDSKH.Columns[4].HeaderText = "Số tiền đã thanh toán";

            dgvDSKH.Columns[0].Width = (int)(dgvDSKH.Width * 0.1);
            dgvDSKH.Columns[1].Width = (int)(dgvDSKH.Width * 0.25);
            dgvDSKH.Columns[2].Width = (int)(dgvDSKH.Width * 0.2);
            dgvDSKH.Columns[3].Width = (int)(dgvDSKH.Width * 0.175);
            dgvDSKH.Columns[4].Width = (int)(dgvDSKH.Width * 0.25);
        }
        private void setDgvBill1ColHeaderText()
        {
            dgvBill.Columns[0].HeaderText = "ID";
            dgvBill.Columns[1].HeaderText = "Tên mặt hàng";
            dgvBill.Columns[2].HeaderText = "Giá";
            dgvBill.Columns[3].HeaderText = "Số lượng";
            dgvBill.Columns[4].HeaderText = "Thành tiền";
        }
        private void setDgvListHangColHeaderText()
        {
            dgvListHangHoa_TaoHoaDon.Columns[0].HeaderText = "ID";
            dgvListHangHoa_TaoHoaDon.Columns[1].HeaderText = "Tên mặt hàng";
            dgvListHangHoa_TaoHoaDon.Columns[2].HeaderText = "Loại mặt hàng";
            dgvListHangHoa_TaoHoaDon.Columns[3].HeaderText = "Nhà sản xuất";
            dgvListHangHoa_TaoHoaDon.Columns[4].HeaderText = "Giá";
            dgvListHangHoa_TaoHoaDon.Columns[5].HeaderText = "Hạn sử dụng";
            dgvListHangHoa_TaoHoaDon.Columns[6].HeaderText = "Số lượng";
        }

        
    }
}
