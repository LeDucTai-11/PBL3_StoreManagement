using PBL3_StoreManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_StoreManagement.BLL
{
    public class BLL_QLNhanVien
    {
        private static BLL_QLNhanVien _Instance;
        QLCuaHang_DB db = new QLCuaHang_DB();

        public static BLL_QLNhanVien Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_QLNhanVien();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_QLNhanVien() { }
        public List<CBBItemCaLamViec> GetCBBItemCaLamViecs()
        {
            return db.CA_LAM_VIECs.Select(p => new CBBItemCaLamViec
            {
                Value = p.ID,
                Text = p.TenCaLamViec,
            }).ToList();
        }
        public List<NhanVienView> getAllNhanVien(int id_CLV, string txt)
        {
            if (id_CLV == 0)
            {
                return db.CASHIERs.Where(p => p.HoVaTen.Contains(txt) && p.TrangThai == true).
                    Select(p => new NhanVienView
                    {
                        ID = p.ID,
                        HoVaTen = p.HoVaTen,
                        GioiTinh = (bool)p.GioiTinh,
                        SDT = p.SDT,
                        DiaChi = p.DiaChi,
                        UserName = p.ACCOUNT.UserName,
                        PW = p.ACCOUNT.PW,
                        CaLamViec = p.CA_LAM_VIEC.TenCaLamViec,
                    }).ToList();
            }
            else
            {
                return db.CASHIERs.Where(p => p.IDShift == id_CLV && p.HoVaTen.Contains(txt) && p.TrangThai == true).
                    Select(p => new NhanVienView
                    {
                        ID = p.ID,
                        HoVaTen = p.HoVaTen,
                        GioiTinh = (bool)p.GioiTinh,
                        SDT = p.SDT,
                        DiaChi = p.DiaChi,
                        UserName = p.ACCOUNT.UserName,
                        PW = p.ACCOUNT.PW,
                        CaLamViec = p.CA_LAM_VIEC.TenCaLamViec,
                    }).ToList();
            }
        }
        public CASHIER getNhanVienByID(int id)
        {
            return db.CASHIERs.Find(id);
        }
        public void AddEdit(CASHIER c)
        {
            bool add = true;
            foreach (CASHIER i in db.CASHIERs.Where(p => p.TrangThai == true).ToList())
            {
                if (i.ID == c.ID)
                {
                    add = false;
                    break;
                }
            }
            if (add)
            {
                Add(c);
            }
            else
            {
                Edit(c);
            }
        }
        private void Add(CASHIER c)
        {
            db.CASHIERs.Add(c);
            db.SaveChanges();
        }
        private void Edit(CASHIER c)
        {
            var d = db.CASHIERs.Find(c.ID);
            d.HoVaTen = c.HoVaTen;
            d.GioiTinh = c.GioiTinh;
            d.SDT = c.SDT;
            d.DiaChi = c.DiaChi;
            //d.IDAccount = c.IDAccount;
            d.IDShift = c.IDShift;
            d.TrangThai = c.TrangThai;
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var c = db.CASHIERs.Find(id);
            c.TrangThai = false;
            db.SaveChanges();
        }
        public List<NhanVienView> Sort(string msg)
        {
            List<NhanVienView> data = new List<NhanVienView>();
            switch(msg)
            {
                case "ID":
                    data = getAllNhanVien(0, "").OrderBy(p => p.ID).ToList();
                    break;
                case "HoVaTen":
                    data = getAllNhanVien(0, "").OrderBy(p => p.HoVaTen).ToList();
                    break;
                case "GioiTinh":
                    data = getAllNhanVien(0, "").OrderBy(p => p.GioiTinh).ToList();
                    break;
                case "DiaChi":
                    data = getAllNhanVien(0, "").OrderBy(p => p.DiaChi).ToList();
                    break;
                case "SDT":
                    data = getAllNhanVien(0, "").OrderBy(p => p.SDT).ToList();
                    break;
                case "UserName":
                    data = getAllNhanVien(0, "").OrderBy(p => p.UserName).ToList();
                    break;
                case "PW":
                    data = getAllNhanVien(0, "").OrderBy(p => p.PW).ToList();
                    break;
                case "CaLamViec":
                    data = getAllNhanVien(0, "").OrderBy(p => p.CaLamViec).ToList();
                    break;
            }
            return data;
        }
        public List<BillView> GetListBillToday(int IDCS)
        {
            List<BillView> list = new List<BillView>();
            foreach (HOA_DON_BAN_HANG i in db.HOA_DON_BAN_HANGs.ToList())
            {
                if(i.IDCashier == IDCS && i.ThoiGian.Date == DateTime.Today)
                {
                    list.Add(new BillView
                    {
                        IDBill = i.ID,
                        TenNhanVien = BLL_QLNhanVien.Instance.getNhanVienByID(i.IDCashier).HoVaTen,
                        ThoiGian = DateTime.Today,
                        KhachHang = (i.IDKhachHang != null) ? i.KHACH_HANG.TenKhachHang : "Không có",
                        TongTien = i.TongTien
                    });
                }
            }
            return list;
        }
        public List<CBBItemNhanVien> GetCBBItemNhanVien()
        {
            List<CBBItemNhanVien> list = new List<CBBItemNhanVien>();
            foreach (CASHIER i in db.CASHIERs.Select(p => p).ToList())
            {
                list.Add(new CBBItemNhanVien { Value = i.ID, Text = i.HoVaTen });
            }
            return list;
        }

    }
}
