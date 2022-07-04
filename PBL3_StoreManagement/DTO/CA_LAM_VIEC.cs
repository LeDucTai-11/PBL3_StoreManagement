using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3_StoreManagement.DTO
{
    public class CA_LAM_VIEC
    {
        public CA_LAM_VIEC()
        {
            CASHIERs = new HashSet<CASHIER>();
        }
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public DateTime batDau { get; set; }
        public DateTime ketThuc { get; set; }
        [StringLength(100)]
        public string TenCaLamViec { get; set; }
        public virtual ICollection<CASHIER> CASHIERs { get; set; }

    }
}
