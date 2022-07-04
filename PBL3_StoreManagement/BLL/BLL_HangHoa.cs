using PBL3_StoreManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_StoreManagement.BLL
{
    public class BLL_HangHoa
    {
            private static BLL_HangHoa _Instance;
            QLCuaHang_DB db = new QLCuaHang_DB();

            public static BLL_HangHoa Instance
            {
                get
                {
                    if (_Instance == null)
                    {
                        _Instance = new BLL_HangHoa();
                    }
                    return _Instance;
                }
                private set { }
            }
            private BLL_HangHoa() { }
            public List<CBBItemLoaiHang> getCBBItemLoaiHangs()
            {
                return db.LOAI_HANGs.Select(p => new CBBItemLoaiHang
                {
                    Value = p.ID,
                    Text = p.TenLoaiHang
                }).ToList();
            }
            public List<CBBItemNhaSanxuat> getAllNSXs()
            {
                return db.NHA_SAN_XUATs.Select(p => new CBBItemNhaSanxuat
                {
                    Value = p.ID,
                    Text = p.TenNhaSX
                }).ToList();
            }
            private List<int> getIDNSXByLoaiHang(int id)
            {
                return db.HANGs.Where(p => p.IDLoaiHang == id).Select(p => p.IDNhaSX).Distinct().ToList();
            }
            public List<CBBItemNhaSanxuat> getAllNSXByLoaiHang(int id)
            {
                List<CBBItemNhaSanxuat> data = new List<CBBItemNhaSanxuat>();
                foreach (int nsx in getIDNSXByLoaiHang(id))
                {
                    foreach (CBBItemNhaSanxuat i in getAllNSXs())
                    {
                        if (nsx == i.Value)
                        {
                            data.Add(i);
                            break;
                        }
                    }
                }
                return data;
            }
            public void AddLoaiHang(LOAI_HANG h)
            {
                db.LOAI_HANGs.Add(h);
                db.SaveChanges();
            }
            public LOAI_HANG getIDLoaiHangMax()
            {
                return db.LOAI_HANGs.OrderByDescending(p=>p.ID).FirstOrDefault();
            }
            public void AddNhaSX(NHA_SAN_XUAT h)
            {
                db.NHA_SAN_XUATs.Add(h);
                db.SaveChanges();
            }
            public NHA_SAN_XUAT getIDNSXMax()
            {
            return db.NHA_SAN_XUATs.OrderByDescending(p => p.ID).FirstOrDefault();
            }
            
            
            public List<HangView> getAllHangView()
            {
                return db.HANGs.Where(p => p.trangThai == true).Select(p => new HangView
                {

                    ID = p.ID,
                    TenMatHang = p.TenMatHang,
                    TenLoaiHang = p.LOAI_HANG.TenLoaiHang,
                    TenNhaSX = p.NHA_SAN_XUAT.TenNhaSX,
                    Gia = (int)p.Gia,
                    HSD = p.HSD,
                    SoLuong = p.SoLuong,
                }).ToList();
            }
            public List<HangView> getAllHangView(int id_LoaiHang)
            {
                List<HangView> data = new List<HangView>();
                if (id_LoaiHang == 0)
                {
                    data = getAllHangView();
                }
                else
                {
                    foreach (HangView i in getAllHangView())
                    {
                        if (db.HANGs.Find(i.ID).IDLoaiHang == id_LoaiHang)
                        {
                            data.Add(i);
                        }
                    }
                }
                return data;
            }
            public List<HangView> getAllHangView(int id_LoaiHang, int id_NSX)
            {
                List<HangView> data = new List<HangView>();
                if (id_NSX == 0)
                {
                    data = getAllHangView(id_LoaiHang);
                }
                else
                {
                    foreach (HangView i in getAllHangView(id_LoaiHang))
                    {
                        if (db.HANGs.Find(i.ID).IDNhaSX == id_NSX)
                        {
                            data.Add(i);
                        }
                    }
                }
                return data;
            }
            public List<HangView> getAllHangView(int id_LoaiHang, int id_NSX, string txt)
            {
                List<HangView> data = new List<HangView>();
                foreach (HangView i in getAllHangView(id_LoaiHang, id_NSX))
                {
                    if (i.TenMatHang.Contains(txt))
                    {
                        data.Add(i);
                    }
                }
                return data;
            }
            public HANG getHangByIDHang(int id)
            {
                return db.HANGs.Find(id);
            }
            public void AddEditHang(HANG h)
            {
                if (getHangByIDHang(h.ID) == null)
                {
                    Add(h);
                }
                else
                {
                    Edit(h);
                }
            }
            private void Add(HANG h)
            {
                db.HANGs.Add(h);
                db.SaveChanges();
            }
            public void Edit(HANG h)
            {
                var hang = db.HANGs.Find(h.ID);
                //hang.ID = h.ID;
                hang.TenMatHang = h.TenMatHang;
                hang.IDLoaiHang = h.IDLoaiHang;
                hang.IDNhaSX = h.IDNhaSX;
                hang.Gia = h.Gia;
                hang.HSD = h.HSD;
                hang.SoLuong = h.SoLuong;
                hang.trangThai = h.trangThai;
                db.SaveChanges();
            }
            public void Delete(int id)
            {
                var h = db.HANGs.Find(id);
                h.trangThai = false;
                db.SaveChanges();
            }
            public List<HangView> SortHang(string msg)
            {
                List<HangView> data = new List<HangView>();
                switch(msg)
                {
                    case "ID":
                        data = getAllHangView().OrderBy(p => p.ID).ToList();
                        break;
                    case "TenMatHang":
                        data = getAllHangView().OrderBy(p => p.TenMatHang).ToList();
                        break;
                    case "TenLoaiHang":
                        data = getAllHangView().OrderBy(p => p.TenLoaiHang).ToList();
                        break;
                    case "TenNhaSX":
                        data = getAllHangView().OrderBy(p => p.TenNhaSX).ToList();
                        break;
                    case "Gia":
                        data = getAllHangView().OrderBy(p => p.Gia).ToList();
                        break;
                    case "SoLuong":
                        data = getAllHangView().OrderBy(p => p.SoLuong).ToList();
                        break;
                    case "HSD":
                        data = getAllHangView().OrderBy(p => p.HSD).ToList();
                        break;
                }
                return data;
            }
            
    }
}
