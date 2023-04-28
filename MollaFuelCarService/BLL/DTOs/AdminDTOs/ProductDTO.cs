using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.AdminDTOs
{
    public class ProductDTO
    {
        
        public int ProductId { get; set; }
        [Required]
        
        public string ProductName { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        
        public string Category { get; set; }

    }
}
