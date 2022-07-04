using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_StoreManagement.DTO
{
    public class CBBItemNhaSanxuat
    {
        private int _Value;
        private string _Text;

        public int Value { get => _Value; set => _Value = value; }
        public string Text { get => _Text; set => _Text = value; }
        public override string ToString()
        {
            return this._Text;
        }
    }
}
