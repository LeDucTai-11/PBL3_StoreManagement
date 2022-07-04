using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3_StoreManagement.BLL;

namespace PBL3_StoreManagement.GUI
{
    public partial class DetailBill : Form
    {
        public int IDBILL { get; set; }
        public DetailBill(int idbill)
        {
            InitializeComponent();
            IDBILL = idbill;
            SetList();
        }
        public void SetList()
        {
            dgvBDTlistbill.DataSource = BLL_HoaDon.Instance.DisplayBill(IDBILL);
            setWidthAndHeaderText();
            lbTongTienBaoCao.Text = Tool.Instance.Tranf_Money(BLL_HoaDon.Instance.GetBillbyID(IDBILL).TongTien);
        }

        private void setWidthAndHeaderText()
        {
            dgvBDTlistbill.Columns[0].Width = (int)(dgvBDTlistbill.Width * 0.05);
            dgvBDTlistbill.Columns[1].Width = (int)(dgvBDTlistbill.Width * 0.4);
            dgvBDTlistbill.Columns[2].Width = (int)(dgvBDTlistbill.Width * 0.15);
            dgvBDTlistbill.Columns[3].Width = (int)(dgvBDTlistbill.Width * 0.125);
            dgvBDTlistbill.Columns[4].Width = (int)(dgvBDTlistbill.Width * 0.2);

            dgvBDTlistbill.Columns[0].HeaderText = "ID";
            dgvBDTlistbill.Columns[1].HeaderText = "Tên sản phẩm";
            dgvBDTlistbill.Columns[2].HeaderText = "Giá";
            dgvBDTlistbill.Columns[3].HeaderText = "Số lượng";
            dgvBDTlistbill.Columns[4].HeaderText = "Thành tiền";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
