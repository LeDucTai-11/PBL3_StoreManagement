using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3_StoreManagement.DTO
{
    [Table("ACCOUNT")]
    public class ACCOUNT
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [Required]
        [StringLength(100)]
        public string UserName { get; set; }
        [Required]
        public string PW { get; set; }
        [Required]
        public int Loai { get; set; }
        [Required]
        public bool trangThai { get; set; } = true;

        public virtual CASHIER CASHIER { get; set; }
    }
}
