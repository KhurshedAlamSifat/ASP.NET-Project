using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.CustomerDTOs
{
    public class FuelOrderDTO
    {
        public int Id { get; set; }
        [Required]
        public string FuelType { get; set; }
        [Required]
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
        public string DeliveredBy { get; set; }
    }
}
