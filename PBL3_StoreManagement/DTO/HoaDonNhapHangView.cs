using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_StoreManagement.DTO
{
    public class HoaDonNhapHangView
    {
        public int ID { get; set; }
        public string TenMatHang { get; set; }
        public string TenNhaSX { get; set; }
        public int SoLuongNhap { get; set; }
        public int GiaHoaDonNhap { get; set; }
        public DateTime NgayNhapHang { get; set; }
    }
}
