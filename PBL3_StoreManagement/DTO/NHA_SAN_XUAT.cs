using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace PBL3_StoreManagement.DTO
{
    public class NHA_SAN_XUAT
    {
        public NHA_SAN_XUAT()
        {
            HANGs = new HashSet<HANG>();
        }
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string TenNhaSX { get; set; }
        public virtual ICollection<HANG> HANGs { get; set; }
    }
}
