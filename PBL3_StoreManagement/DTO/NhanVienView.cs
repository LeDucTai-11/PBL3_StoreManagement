using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_StoreManagement.DTO
{
    public class NhanVienView
    {
        public int ID { get; set; }
        public string HoVaTen { get; set; }
        public bool GioiTinh { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string UserName { get; set; }
        public string PW { get; set; }
        public string CaLamViec { get; set; }
    }
}
