using PBL3_StoreManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_StoreManagement.BLL
{
    public class BLL_TongQuan
    {
        private static BLL_TongQuan _Instance;
        QLCuaHang_DB db = new QLCuaHang_DB();

        public static BLL_TongQuan Instance { 
            get
            {
                if(_Instance == null)
                {
                    _Instance = new BLL_TongQuan();
                }
                return _Instance;
            }
            private set { } }
        private BLL_TongQuan() { }
        public List<string> setListBanchay()
        {
            var list = db.HOA_DON_CHI_TIETs.OrderBy(p=>p.IDHang).Distinct().Select(p=>new
            {
                Name = p.HANG.TenMatHang,
                SoLuong = db.HOA_DON_CHI_TIETs.Where(x=>x.IDHang == p.IDHang).Sum(x=>x.SoLuong),
            }).ToList();
            return list.OrderByDescending(x=>x.SoLuong).Select(p=>p.Name).ToList();
        }
        public List<string> getListRecentBill()
        {
            List<string> data = new List<string>();
            foreach(HOA_DON_BAN_HANG i in db.HOA_DON_BAN_HANGs.OrderByDescending(p=>p.ThoiGian).Take(5))
            {
                if(i.IDKhachHang != null)
                {
                    data.Add(i.ThoiGian + "    " + i.KHACH_HANG.TenKhachHang);
                }else
                {
                    data.Add(i.ThoiGian + "    " + "Khách hàng mua trực tiếp");
                }
            }
            return data;
        } 
        public List<int> weekOfChart()
        {
            List<int> weekOfChart = new List<int>();
            DateTime date = DateTime.Now;
            for (int i = 6; i >= 0; i--)
            {
                int tt = 0;
                DateTime datebefore = date.AddDays(-i);
                var x = db.HOA_DON_BAN_HANGs.Where(p => p.ThoiGian.Day == datebefore.Day
                                                                        && p.ThoiGian.Month == datebefore.Month
                                                                        && p.ThoiGian.Year == datebefore.Year);
                foreach (HOA_DON_BAN_HANG j in x)
                {
                    tt += Convert.ToInt32(j.TongTien);
                }
                weekOfChart.Add(tt);
            }
            return weekOfChart;
        }

    }
}
