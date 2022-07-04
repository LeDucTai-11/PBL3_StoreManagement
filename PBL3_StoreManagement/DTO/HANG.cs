using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3_StoreManagement.DTO
{
    [Table("HANG")]
    public class HANG
    {
        public HANG()
        {
            HOA_DON_CHI_TIETs = new HashSet<HOA_DON_CHI_TIET>();
            HOA_DON_NHAP_HANGs = new HashSet<HOA_DON_NHAP_HANG>();
        }
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [StringLength(100)]
        public string TenMatHang { get; set; }
        [Required]
        public int IDLoaiHang { get; set; }
        [Required]

        public int IDNhaSX { get; set; }

        [Required]
        public int Gia { get; set; }
        public DateTime HSD { get; set; }
        public int SoLuong { get; set; }
        public bool trangThai { get; set; } = true;
        public virtual ICollection<HOA_DON_CHI_TIET> HOA_DON_CHI_TIETs { get; set; }
        [ForeignKey("IDLoaiHang")]
        public virtual LOAI_HANG LOAI_HANG { get; set; }
        [ForeignKey("IDNhaSX")]
        public virtual NHA_SAN_XUAT NHA_SAN_XUAT { get; set; }
        public virtual ICollection<HOA_DON_NHAP_HANG> HOA_DON_NHAP_HANGs { get; set; }
    }
}
