using PBL3_StoreManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_StoreManagement.BLL
{
    public class BLL_KhachHang
    {
        private static BLL_KhachHang _Instance;
        QLCuaHang_DB db = new QLCuaHang_DB();

        public static BLL_KhachHang Instance { 
            get
            {
                if( _Instance == null )
                {
                    _Instance = new BLL_KhachHang();
                }
                return _Instance;
            }
            private set { } }
        private BLL_KhachHang() { }
        public List<CBBItemKhachHang> getAllCBBKhachHang()
        {
            return db.KHACH_HANGs.Where(p=>p.trangThai == true).Select(p=>new CBBItemKhachHang
            {
                Value = p.ID,
                Text = p.TenKhachHang.ToString(),
            }).ToList();
        }
        public int SoDonHangOfKhachHang(int idKH)
        {
            return db.HOA_DON_BAN_HANGs.Count(p => p.IDKhachHang == idKH);
        }
        public double SoTienOfAllHoaDon(int idKH)
        {
            double sum = 0;
            foreach(HOA_DON_BAN_HANG i in db.HOA_DON_BAN_HANGs.Where(p=>p.IDKhachHang == idKH).ToList()){
                sum += Convert.ToDouble(i.TongTien);
            }
            return sum;
        }
        public List<KhachHangView> getAllKH()
        {
            List<KhachHangView> data = new List<KhachHangView>();
            foreach(KHACH_HANG i in db.KHACH_HANGs.ToList())
            {
                if(i.trangThai == true)
                {
                    data.Add(new KhachHangView
                    {
                        ID = i.ID,
                        TenKhachHang = i.TenKhachHang,
                        SDT = i.SDT,
                        SoHoaDon = SoDonHangOfKhachHang(i.ID),
                        SoTien = SoTienOfAllHoaDon(i.ID),
                    });
                }
            }
            return data;
        }
        public List<KhachHangView> getAllKH(string msg)
        {
            return getAllKH().Where(p => p.TenKhachHang.Contains(msg)).ToList();
        }
        public KhachHangView getKHByID(int id)
        {
            return getAllKH().Where(p=>p.ID == id).FirstOrDefault();
        }
        public void AddEdit(KHACH_HANG h)
        {
            if(getKHByID(h.ID) == null)
            {
                Add(h);
            }else
            {
                Edit(h);
            }
        }
        private void Add(KHACH_HANG h)
        {
            db.KHACH_HANGs.Add(h);
            db.SaveChanges();
        }
        private void Edit(KHACH_HANG h)
        {
            var kh = db.KHACH_HANGs.Find(h.ID);
            kh.TenKhachHang = h.TenKhachHang;
            kh.SDT = h.SDT;
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var kh = db.KHACH_HANGs.Find(id);
            kh.trangThai = false;
            db.SaveChanges();
        }
        public List<KhachHangView> Sort(string msg)
        {
            List<KhachHangView> data = new List<KhachHangView>();
            switch (msg)
            {
                case "ID":
                    data = getAllKH("").OrderBy(p => p.ID).ToList();
                    break;
                case "TenKhachHang":
                    data = getAllKH("").OrderBy(p => p.TenKhachHang).ToList();
                    break;
                case "SDT":
                    data = getAllKH("").OrderBy(p => p.SDT).ToList();
                    break;
                case "SoHoaDon":
                    data = getAllKH("").OrderBy(p => p.SoHoaDon).ToList();
                    break;
                case "SoTien":
                    data = getAllKH("").OrderBy(p => p.SoTien).ToList();
                    break;
            }
            return data;
        }
    }
}
