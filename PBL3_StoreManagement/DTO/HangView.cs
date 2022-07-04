using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_StoreManagement.DTO
{
    public class HangView
    {
        public int ID { get; set; }
        public string TenMatHang { get; set; }
        public string TenLoaiHang { get; set; }
        public string TenNhaSX { get; set; }
        public int Gia { get; set; }
        public DateTime HSD { get; set; }
        public int SoLuong { get; set; }
    }
}
