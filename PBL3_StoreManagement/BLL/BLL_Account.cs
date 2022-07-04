using PBL3_StoreManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_StoreManagement.BLL
{
    public class BLL_Account //dùng chung cho Login & Account
    {
        private static BLL_Account _Instance;
        QLCuaHang_DB db = new QLCuaHang_DB();

        public static BLL_Account Instance { 
            get
            {
                if(_Instance == null)
                {
                    _Instance = new BLL_Account();
                }
                return _Instance;
            }
            private set { } }
        public ACCOUNT getAccountLogin(string user,string pw)
        {
            ACCOUNT acc = null;
            foreach(ACCOUNT i in getAllACCOUNTs())
            {
                if(i.UserName == user && i.PW == pw)
                {
                    acc = i;
                    break;
                }
            }
            return acc;
        }
        public List<ACCOUNT> getAllACCOUNTs()
        {
            return db.ACCOUNTs.Where(p=>p.trangThai == true).ToList();
        }
        public List<AccountView> getAllAccNhanVien()
        {
            List<AccountView> data = new List<AccountView>();
            foreach(ACCOUNT i in getAllACCOUNTs())
            {
                if(i.Loai == 2)
                {
                    data.Add(new AccountView
                    {
                        ID = i.ID,
                        TenNhanVien = BLL_QLNhanVien.Instance.getNhanVienByID(i.ID).HoVaTen,
                        UserName = i.UserName,
                        PW = i.PW,
                    });
                }
            }
            return data;
        }
        public void AddAccount(ACCOUNT acc)
        {
            db.ACCOUNTs.Add(acc);
            db.SaveChanges();
        }
        public void EditAccount(ACCOUNT acc)
        {
            var c = db.ACCOUNTs.Find(acc.ID);
            c.UserName = acc.UserName;
            c.PW = acc.PW;
            db.SaveChanges();
        }
        public void DeleteAccount(int id)
        {
            var c = db.ACCOUNTs.Find(id);
            c.trangThai = false;
            db.SaveChanges();
        }
        public ACCOUNT getAccountByIDMax()
        {
            return db.ACCOUNTs.Where(p=>p.Loai == 2).OrderByDescending(p=>p.ID).First();
        }
        public ACCOUNT getAccountByID(int id)
        {
            return db.ACCOUNTs.Find(id);
        }
        
    }
}
