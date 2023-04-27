using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class FuelOrder
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string FuelType { get; set; }
        [Required]
        [ForeignKey("Customer")]
        public string OrderedBy { get; set; }
        [Required]
        public DateTime FOrderDate { get; set; }
        [Required]
        public string DeliverAddress { get; set; }
        [Required]
        public double TotalPrice { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        [ForeignKey("DeliveryMan")]
        public string DeliveredBy { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual DeliveryMan DeliveryMan { get; set; }

    }
}
