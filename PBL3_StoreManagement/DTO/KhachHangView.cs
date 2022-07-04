using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_StoreManagement.DTO
{
    public class KhachHangView
    {
        public int ID { get; set; }
        public string TenKhachHang { get; set; }
        public string SDT { get; set; }
        public int SoHoaDon { get; set; }
        public double SoTien { get; set; }
    }
}
