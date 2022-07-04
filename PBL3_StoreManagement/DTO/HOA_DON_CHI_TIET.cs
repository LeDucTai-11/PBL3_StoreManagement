using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3_StoreManagement.DTO
{
    public class HOA_DON_CHI_TIET
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public int IDHang { get; set; }
        [Required]
        public int SoLuong { get; set; }
        [Required]
        public int IDHoaDonBanHang { get; set; }
        [ForeignKey("IDHoaDonBanHang")]
        public virtual HOA_DON_BAN_HANG HOA_DON_BAN_HANG { get; set; }
        [ForeignKey("IDHang")]
        public virtual HANG HANG { get; set; }
    }
}
