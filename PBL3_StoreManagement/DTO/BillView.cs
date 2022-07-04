using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_StoreManagement.DTO
{
    public class BillView
    {
        public int IDBill { get; set; }
        public string TenNhanVien { get; set; }
        public DateTime ThoiGian { get; set; }
        public int TongTien { get; set; }
        public String KhachHang { get; set; }
    }
}
