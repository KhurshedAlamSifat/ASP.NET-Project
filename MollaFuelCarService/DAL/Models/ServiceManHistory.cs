using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class ServiceManHistory
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(20)]
        public string Product { get; set; }
        [Required, StringLength(20)]
        public string SupplierName { get; set; }
        [Required]
        public int Quantity { get; set; }

    }
}
