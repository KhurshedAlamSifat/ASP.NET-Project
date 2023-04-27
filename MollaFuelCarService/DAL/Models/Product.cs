using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [StringLength(50)]
        public string ProductName { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        [StringLength(50)]
        public string Category { get; set; }

        public virtual ICollection<ProductOrder> ProductOrders { get; set; }
        public Product()
        {
            ProductOrders= new List<ProductOrder>();
        }

    }
}
