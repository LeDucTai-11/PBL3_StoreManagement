using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3_StoreManagement.DTO
{
    [Table("CASHIER")]
    public class CASHIER
    {
        public CASHIER()
        {
            HOA_DON_BAN_HANGs = new HashSet<HOA_DON_BAN_HANG>();
        }
        [ForeignKey("ACCOUNT")]
        [Key]
        [Required]
        public int ID { get; set; }
        [Required]
        public string HoVaTen { get; set; }
        [Required]
        public bool GioiTinh { get; set; }
        [Required]
        [StringLength(10)]

        public string SDT { get; set; }
        public bool TrangThai { get; set; } = true;

        [Required]
        public string DiaChi { get; set; }

        [Required]
        public int IDShift { get; set; }

        public virtual ACCOUNT ACCOUNT { get; set; }
        [ForeignKey("IDShift")]
        public virtual CA_LAM_VIEC CA_LAM_VIEC { get; set; }
        public virtual ICollection<HOA_DON_BAN_HANG> HOA_DON_BAN_HANGs { get; set; }
    }
}
