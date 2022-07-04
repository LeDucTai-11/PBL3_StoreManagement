using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3_StoreManagement.DTO
{
    public class HOA_DON_BAN_HANG
    {
        public HOA_DON_BAN_HANG()
        {
            HOA_DON_CHI_TIETs = new HashSet<HOA_DON_CHI_TIET>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int ID { get; set; }
        [Required]
        public int IDCashier { get; set; }

        [Required]
        public DateTime ThoiGian { get; set; }
        [Required]
        public int TongTien { get; set; }
        public int? IDKhachHang { get; set; }

        [ForeignKey("IDCashier")]
        public virtual CASHIER CASHIER { get; set; }
        [ForeignKey("IDKhachHang")]
        public virtual KHACH_HANG KHACH_HANG { get; set; }
        public virtual ICollection<HOA_DON_CHI_TIET> HOA_DON_CHI_TIETs { get; set; }
    }
}
