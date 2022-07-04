using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3_StoreManagement.DTO
{
    public class KHACH_HANG
    {
        public KHACH_HANG()
        {
            HOA_DON_BAN_HANGs = new HashSet<HOA_DON_BAN_HANG>();
        }
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string TenKhachHang { get; set; }
        [Required]
        public string SDT { get; set; }
        public bool trangThai { get; set; }
        public virtual ICollection<HOA_DON_BAN_HANG> HOA_DON_BAN_HANGs { get; set; }
    }
}
