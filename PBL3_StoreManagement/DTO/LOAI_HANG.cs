using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3_StoreManagement.DTO
{
    public class LOAI_HANG
    {
        public LOAI_HANG()
        {
            HANGs = new HashSet<HANG>();
        }
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string TenLoaiHang { get; set; }

        public virtual ICollection<HANG> HANGs { get; set; }
    }
}
