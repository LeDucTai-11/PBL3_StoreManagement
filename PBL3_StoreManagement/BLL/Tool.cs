using PBL3_StoreManagement.DTO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_StoreManagement.BLL
{
    public class Tool
    {
        private static Tool _Instance;

        public static Tool Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new Tool();
                }
                return _Instance;
            }

            set { }
        }
        public string Tranf_Money(int money)
        {
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"
            return double.Parse((money).ToString()).ToString("#,###", cul.NumberFormat);
        }
        public bool CheckUserName(string user)
        {
            bool check = true;
            foreach (ACCOUNT i in BLL_Account.Instance.getAllACCOUNTs())
            {
                if (i.UserName == user)
                {
                    check = false;
                    break;
                }
            }
            return check;
        }
        public bool CheckSDTNV(string msg)
        {
            bool check = true;
            foreach (NhanVienView i in BLL_QLNhanVien.Instance.getAllNhanVien(0, ""))
            {
                if (i.SDT == msg)
                {
                    check = false;
                    break;
                }
            }
            return check;
        }
        public bool CheckSDTKH(string msg)
        {
            bool check = true;
            foreach (KhachHangView i in BLL_KhachHang.Instance.getAllKH())
            {
                if (i.SDT == msg)
                {
                    check = false;
                    break;
                }
            }
            return check;
        }
    }
}
