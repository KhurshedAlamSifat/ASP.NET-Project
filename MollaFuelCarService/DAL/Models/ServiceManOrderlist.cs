using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class ServiceManOrderlist
    {
        [Key]
        public int OrderId { get; set; }
        [Required, StringLength(20)]
        public string OrderFor { get; set; }
        [Required]
        public DateTime OrderTime { get; set; }
        [Required]
        public int Quantity { get; set; }

    }
}
