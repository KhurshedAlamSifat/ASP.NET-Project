using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [Required]
        [ForeignKey("Customer")]
        public string OrderedBy { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public string DeliverAddress { get; set; }
        [Required]
        public double TotalPrice { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        [ForeignKey("ServiceMan")]
        public string ServicedBy { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ServiceMan ServiceMan { get; set; }

        public virtual ICollection<ProductOrder> ProductOrders { get; set; }
        public Order()
        {
            ProductOrders = new List<ProductOrder>();
        }
    }
}
