using PBL3_StoreManagement.DTO;
using System;
using System.Data.Entity;
using System.Linq;


namespace PBL3_StoreManagement
{
    public class QLCuaHang_DB : DbContext
    {
        public QLCuaHang_DB()
            : base("name=QLCuaHang_DB")
        {
            Database.SetInitializer<QLCuaHang_DB>(new CreateDB());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<HOA_DON_BAN_HANG>().Property(p => p.IDKhachHang)
                .IsOptional();
        }
        public DbSet<ACCOUNT> ACCOUNTs { get; set; }
        public DbSet<CA_LAM_VIEC> CA_LAM_VIECs { get; set; }
        public DbSet<CASHIER> CASHIERs { get; set; }
        public DbSet<HANG> HANGs { get; set; }
        public DbSet<HOA_DON_BAN_HANG> HOA_DON_BAN_HANGs { get; set; }
        public DbSet<HOA_DON_CHI_TIET> HOA_DON_CHI_TIETs { get; set; }
        public DbSet<HOA_DON_NHAP_HANG> HOA_DON_NHAP_HANGs { get; set; }
        public DbSet<KHACH_HANG> KHACH_HANGs { get; set; }
        public DbSet<LOAI_HANG> LOAI_HANGs { get; set; }
        public DbSet<NHA_SAN_XUAT> NHA_SAN_XUATs { get; set; }


    }


}