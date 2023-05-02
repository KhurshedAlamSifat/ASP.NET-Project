using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.CustomerDTOs
{
    public class OrderDTO
    {
        public int OrderId { get; set; }
        [Required]
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
        public string ServicedBy { get; set; }
    }
}
