using PBL3_StoreManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_StoreManagement.BLL
{
    public class BLL_NhapHang
    {
        private static BLL_NhapHang _Instance;
        QLCuaHang_DB db = new QLCuaHang_DB();

        public static BLL_NhapHang Instance {
            get
            {
                if( _Instance == null )
                {
                    _Instance = new BLL_NhapHang();
                }
                return _Instance;
            }
            private set { } }
        private BLL_NhapHang() { }
        public HOA_DON_NHAP_HANG getHoaDonByID(int id)
        {
            return db.HOA_DON_NHAP_HANGs.Find(id);
        }
        public HoaDonNhapHangView getHDNHView(HOA_DON_NHAP_HANG i)
        {
            return new HoaDonNhapHangView
            {
                ID = i.ID,
                TenMatHang = BLL_HangHoa.Instance.getHangByIDHang(i.IDHang).TenMatHang,
                TenNhaSX = BLL_HangHoa.Instance.getHangByIDHang(i.IDHang).NHA_SAN_XUAT.TenNhaSX,
                SoLuongNhap = i.SoLuong,
                GiaHoaDonNhap = i.GiaHoaDon,
                NgayNhapHang = (DateTime)i.NgayNhapHang,
            };
        }
        public List<HoaDonNhapHangView> getAllHoaDonNhapHang(int id_NSX)
        {
            List<HoaDonNhapHangView> data = new List<HoaDonNhapHangView>();
            if(id_NSX == 0)
            {
                foreach(HOA_DON_NHAP_HANG i in db.HOA_DON_NHAP_HANGs.ToList())
                {
                    data.Add(getHDNHView(i));
                }
            }else
            {
                foreach(HOA_DON_NHAP_HANG i in db.HOA_DON_NHAP_HANGs.ToList())
                {
                    if(BLL_HangHoa.Instance.getHangByIDHang(i.IDHang).IDNhaSX == id_NSX)
                    {
                        data.Add(getHDNHView(i));
                    }
                }
            }
            return data;
        }
        public List<HoaDonNhapHangView> getAllHoaDonNhapHang(int id_NSX,string msg)
        {
            List<HoaDonNhapHangView> data = new List<HoaDonNhapHangView>();
            foreach(HoaDonNhapHangView i in getAllHoaDonNhapHang(id_NSX))
            {
                if (i.TenMatHang.Contains(msg))
                {
                    data.Add(i);
                }
            }
            return data;
        }
        public void Add(HOA_DON_NHAP_HANG h)
        {
            if (db.HOA_DON_BAN_HANGs.Find(h.ID) == null)
            {
                db.HOA_DON_NHAP_HANGs.Add(h);
                db.SaveChanges();
            }
        }
    }
}
