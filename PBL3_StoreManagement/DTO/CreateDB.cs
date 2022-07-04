using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PBL3_StoreManagement.DTO
{
    public class CreateDB : CreateDatabaseIfNotExists<QLCuaHang_DB>
    {
        protected override void Seed(QLCuaHang_DB context)
        {
            context.LOAI_HANGs.AddRange(new LOAI_HANG[]
            {
                new LOAI_HANG{TenLoaiHang = "Thực phẩm khô"},
                new LOAI_HANG{TenLoaiHang = "Thực phẩm lạnh"},
                new LOAI_HANG{TenLoaiHang = "Gia vị"},
                new LOAI_HANG{TenLoaiHang = "Dụng cụ bếp"},
                new LOAI_HANG{TenLoaiHang = "Mỹ phẩm"},
                new LOAI_HANG{TenLoaiHang = "Hóa phẩm"},
                new LOAI_HANG{TenLoaiHang = "Giấy và bông"},
                new LOAI_HANG{TenLoaiHang = "Đồ uống"},
                new LOAI_HANG{TenLoaiHang = "Thuốc lá"},
                new LOAI_HANG{TenLoaiHang = "May mặc"},
                new LOAI_HANG{TenLoaiHang = "Văn phòng phẩm"},
                new LOAI_HANG{TenLoaiHang = "Vệ sinh và chăm sóc cá nhân"},
            });
            context.NHA_SAN_XUATs.AddRange(new NHA_SAN_XUAT[]
            {
                new NHA_SAN_XUAT{TenNhaSX = "Massan"},
                new NHA_SAN_XUAT{TenNhaSX = "Vissan"},
                new NHA_SAN_XUAT{TenNhaSX = "PepsiCo"},
                new NHA_SAN_XUAT{TenNhaSX = "Cocacola"},
                new NHA_SAN_XUAT{TenNhaSX = "Unilever"},
                new NHA_SAN_XUAT{TenNhaSX = "Nestle"},
                new NHA_SAN_XUAT{TenNhaSX = "Sunhouse"},
                new NHA_SAN_XUAT{TenNhaSX = "Kangaroo"},
                new NHA_SAN_XUAT{TenNhaSX = "Vinamilk"},
                new NHA_SAN_XUAT{TenNhaSX = "AceCook VN"},
                new NHA_SAN_XUAT{TenNhaSX = "URC"},
                new NHA_SAN_XUAT{TenNhaSX = "Perfetti"},
                new NHA_SAN_XUAT{TenNhaSX = "Vinataba"},
                new NHA_SAN_XUAT{TenNhaSX = "Khataco"},
                new NHA_SAN_XUAT{TenNhaSX = "ThienLong"},
                new NHA_SAN_XUAT{TenNhaSX = "Procter Gamble"},
                new NHA_SAN_XUAT{TenNhaSX = "Unicharm"},
                new NHA_SAN_XUAT{TenNhaSX = "Vocarimex"},
                new NHA_SAN_XUAT{TenNhaSX = "Công ty bia Heiniken"},
                new NHA_SAN_XUAT{TenNhaSX = "Công ty bia SaiGon"},
                new NHA_SAN_XUAT{TenNhaSX = "SSL International"},
                new NHA_SAN_XUAT{TenNhaSX = "Safoco"},
                new NHA_SAN_XUAT{TenNhaSX = "Thực phẩm Cầu tre"},
                new NHA_SAN_XUAT{TenNhaSX = "P&G"},
            });
            context.ACCOUNTs.Add(new ACCOUNT
            {
                UserName = "ductai",
                PW = "123456",
                Loai = 1,
                trangThai = true
            });
        }
    }
}
