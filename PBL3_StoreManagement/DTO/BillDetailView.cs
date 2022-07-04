using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_StoreManagement.DTO
{
    public class BillDetailView
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gia { get; set; }
        public int SoLuong { get; set; }
        public string ThanhTien { get; set; }
    }
}
