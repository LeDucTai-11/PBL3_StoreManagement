using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3_StoreManagement.DTO
{
    public class HOA_DON_NHAP_HANG
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public int IDHang { get; set; }
        [Required]
        public int SoLuong { get; set; }
        public DateTime NgayNhapHang { get; set; }
        public int GiaHoaDon { get; set; }
        [ForeignKey("IDHang")]
        public virtual HANG HANG { get; set; }
    }
}
