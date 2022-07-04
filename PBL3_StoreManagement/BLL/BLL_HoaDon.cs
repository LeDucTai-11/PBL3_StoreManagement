using PBL3_StoreManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;

namespace PBL3_StoreManagement.BLL
{
    public class BLL_HoaDon
    {
        private static BLL_HoaDon _Instance;
        QLCuaHang_DB db = new QLCuaHang_DB();
        public static int IDBILLNOW = -1;
        public List<HOA_DON_CHI_TIET> HOA_DON_CHI_TIET = new List<HOA_DON_CHI_TIET>();
        public static BLL_HoaDon Instance {
            get
            {
                if(_Instance == null)
                {
                    _Instance = new BLL_HoaDon();
                }
                return _Instance;
            }
            private set { } }
        public int CreateNewBill(int idcashier)
        {
            HOA_DON_BAN_HANG temp = new HOA_DON_BAN_HANG();
            temp.IDCashier = idcashier;
            temp.TongTien = 0;
            temp.ThoiGian = DateTime.Now;
            db.HOA_DON_BAN_HANGs.Add(temp);
            db.SaveChanges();
            IDBILLNOW = (int)db.HOA_DON_BAN_HANGs.Max(p => p.ID);
            return IDBILLNOW;
        }
        public void OderHang(int idHang)
        {
            if (!Giamsoluong(idHang, 1)) return;
            int soluong = 0;
            if (FindBillByIDHang(idHang) != null) soluong = FindBillByIDHang(idHang).SoLuong;
            if (soluong == 0)
            {
                HOA_DON_CHI_TIET temp = new HOA_DON_CHI_TIET();
                temp.IDHang = idHang;
                temp.SoLuong = soluong + 1;
                temp.IDHoaDonBanHang = IDBILLNOW;
                db.HOA_DON_CHI_TIETs.Add(temp);
                db.SaveChanges();
            }
            else
            {
                //var temp = db.HOA_DON_CHI_TIET.Where(p => p.IDHang == idHang && p.IDHoaDonBanHang == IDBILLNOW).FirstOrDefault();
                var temp = FindBillByIDHang(idHang);
                temp.SoLuong = soluong + 1;
                db.SaveChanges();
            }
        }
        public List<BillDetailView> DisplayBill(int idBill)
        {
            return db.HOA_DON_CHI_TIETs.Where(p => p.IDHoaDonBanHang == idBill).Select(i=>new BillDetailView
            {
                ID = i.IDHang,
                Name = i.HANG.TenMatHang,
                Gia = (i.HANG.Gia).ToString(),
                SoLuong = i.SoLuong,
                ThanhTien = (i.HANG.Gia * i.SoLuong).ToString()
            }).ToList();
        }
        public HOA_DON_BAN_HANG Update_Bill(int idkhachhang = -1)
        {
            var temp = GetBillbyID(IDBILLNOW);
            int sum = 0;
            foreach (BillDetailView i in DisplayBill(IDBILLNOW))
            {
                sum += Convert.ToInt32(i.ThanhTien);
            }
            temp.TongTien = sum;
            if (idkhachhang != -1)
            {
                temp.IDKhachHang = idkhachhang;
            }
            db.SaveChanges();
            return temp;
        }
        public bool Giamsoluong(int hang, int soluongmuahang)
        {
            var temp = db.HANGs.Where(p => p.ID == hang).FirstOrDefault();
            if (temp.SoLuong - soluongmuahang >= 0)
            {
                temp.SoLuong -= soluongmuahang;
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Update_DetailBill(int idhang, int soluong)
        {
            var temp = FindBillByIDHang(idhang);
            if (Giamsoluong(idhang, soluong - temp.SoLuong))
            {
                temp.SoLuong = soluong;
                db.SaveChanges();
            }
        }
        public HOA_DON_CHI_TIET FindBillByIDHang(int idhang)
        {
            if (IDBILLNOW != -1)
            {
                return db.HOA_DON_CHI_TIETs.Where(p => p.IDHang == idhang && p.IDHoaDonBanHang == IDBILLNOW).FirstOrDefault();
            }
            else return null;
        }
        public void DeleteDetailBill(int idhang)
        {
            Giamsoluong(idhang, -FindBillByIDHang(idhang).SoLuong);
            db.HOA_DON_CHI_TIETs.Remove(FindBillByIDHang(idhang));
            db.SaveChanges();
        }
        public List<HOA_DON_CHI_TIET> GetAllDetailBILLbyIDBill()
        {
            return db.HOA_DON_CHI_TIETs.Where(x => x.IDHoaDonBanHang == IDBILLNOW).ToList();
        }
        public void Print_Bill()
        {

            HOA_DON_BAN_HANG temp = db.HOA_DON_BAN_HANGs.Find(IDBILLNOW);
            List<string> noidung = new List<string>(new string[]
            {                "\t\t\t    MINI MART HKT  ",
                "   \t54 Nguyễn Lương Bằng - Thanh Khê - Đà Nẵng",
                "         \tTel: 6969696969 - 0909076543",
                "              \tHÓA ĐƠN BÁN HÀNG",
                "       \tNgày In đơn: "+ DateTime.Now.ToString(),
                "      ---------------------------------------------",
                "      SL          Đ.Giá           Thành Tiền",
            });
            foreach (HOA_DON_CHI_TIET i in GetAllDetailBILLbyIDBill())
            {
                string s = "  " + i.HANG.TenMatHang;
                noidung.Add(s);
                s = "      " + i.SoLuong.ToString() + "           " + Tool.Instance.Tranf_Money(i.HANG.Gia) + "         " + Tool.Instance.Tranf_Money((i.SoLuong * i.HANG.Gia));
                noidung.Add(s);
            }
            noidung.AddRange(new string[]
            {
                "    -----------------------------------------------",
                "    Thành tiền:                 "+Tool.Instance.Tranf_Money(temp.TongTien),
                "    -----------------------------------------------",
                "\n\n",
                "               Xin cảm ơn  - Hẹn gặp lại"
            });
            File.WriteAllLines(@"G:\Hoc C#\PBL3_StoreManagement\PBL3_StoreManagement\BILL\" + IDBILLNOW + ".txt", noidung);
        }
        public void DeleteALLBill()
        {
            if (IDBILLNOW != -1)
            {
                foreach (HOA_DON_CHI_TIET i in db.HOA_DON_CHI_TIETs.Where(p => p.IDHoaDonBanHang == IDBILLNOW).Select(p => p).ToList())
                {
                    db.HOA_DON_CHI_TIETs.Remove(i);
                    Giamsoluong(i.IDHang, -FindBillByIDHang(i.IDHang).SoLuong);
                    db.SaveChanges();

                }
                db.HOA_DON_BAN_HANGs.Remove(GetBillbyID(IDBILLNOW));
                db.SaveChanges();
                IDBILLNOW = -1;
            }
        }
        public HOA_DON_BAN_HANG GetBillbyID(int id)
        {
            return db.HOA_DON_BAN_HANGs.Find(id);
        }



        // ------------------- Hóa đơn ------------------------
        public List<HOA_DON_BAN_HANG> getAllHoaDonBanHang()
        {
            return db.HOA_DON_BAN_HANGs.ToList();
        }
        public List<BillView> Tranf_from_HOADON_to_BillView(List<HOA_DON_BAN_HANG> list)
        {
            List<BillView> data = new List<BillView>();
            foreach(HOA_DON_BAN_HANG i in list)
            {
                data.Add(new BillView
                {
                    IDBill = i.ID,
                    TenNhanVien = BLL_QLNhanVien.Instance.getNhanVienByID(i.IDCashier).HoVaTen,
                    ThoiGian = i.ThoiGian,
                    TongTien = (int)i.TongTien,
                    KhachHang = (i.IDKhachHang != null) ? i.KHACH_HANG.TenKhachHang : "",
                });
            }
            return data;
        }
        public List<BillView> getAllBill(int IDCS)
        {
            if(IDCS == 0)
            {
                return Tranf_from_HOADON_to_BillView(getAllHoaDonBanHang());
            }else
            {
                return Tranf_from_HOADON_to_BillView(getAllHoaDonBanHang().Where(p=>p.IDCashier == IDCS).ToList());
            }
        }
        public List<BillView> getAllBill(int IDCS,string date)
        {
            List<BillView> data = new List<BillView>();
            if(date == "All")
            {
                data = getAllBill(IDCS);
            }else
            {
                foreach(BillView i in getAllBill(IDCS))
                {
                    if(i.ThoiGian.Date == Convert.ToDateTime(date).Date)
                    {
                        data.Add(i);
                    }
                }
            }
            return data;
        }
        public List<DateTime> getAllDateInHoaDon()
        {
            List<DateTime> data = new List<DateTime>();
            foreach(HOA_DON_BAN_HANG i in db.HOA_DON_BAN_HANGs.ToList())
            {
                data.Add(i.ThoiGian.Date);
            }
            return data;
        }
        public List<DateTime> GetNgayTaobyidCS(int IDCashier)
        {
            List<DateTime> data = new List<DateTime>();
            foreach(var i in db.HOA_DON_BAN_HANGs.Where(p=>p.IDCashier == IDCashier).ToList())
            {
                data.Add(i.ThoiGian.Date);
            }
            return data;
        }
        public int SoDonHangToday()
        {
            int count = 0;
            foreach (HOA_DON_BAN_HANG i in db.HOA_DON_BAN_HANGs.ToList())
            {
                if (i.ThoiGian.Date == DateTime.Today)
                {
                    count++;
                }
            }
            return count;
        }
        public int SoDonHangMonth()
        {
            int count = 0;
            foreach (HOA_DON_BAN_HANG i in db.HOA_DON_BAN_HANGs.ToList())
            {
                if (i.ThoiGian.Month == DateTime.Now.Month)
                {
                    count++;
                }
            }
            return count;
        }
        public int DoanhThuToday()
        {
            int count = 0;
            foreach (HOA_DON_BAN_HANG i in db.HOA_DON_BAN_HANGs.ToList())
            {
                if (i.ThoiGian.Date == DateTime.Today)
                {
                    count += i.TongTien;
                }
            }
            return count;
        }
        public int DoanhThuMonth()
        {
            int count = 0;
            foreach (HOA_DON_BAN_HANG i in db.HOA_DON_BAN_HANGs.ToList())
            {
                if (i.ThoiGian.Month == DateTime.Now.Month)
                {
                    count += i.TongTien;
                }
            }
            return count;
        }
        public int HoaDonNhapHangToday()
        {
            int count = 0;
            foreach(HOA_DON_NHAP_HANG i in db.HOA_DON_NHAP_HANGs.ToList())
            {
                if(i.NgayNhapHang.Date == DateTime.Today)
                {
                    count++;
                }
            }
            return count;
        }
        public int HoaDonNhapHangMonth()
        {
            int count = 0;
            foreach (HOA_DON_NHAP_HANG i in db.HOA_DON_NHAP_HANGs.ToList())
            {
                if (i.NgayNhapHang.Month == DateTime.Now.Month)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
