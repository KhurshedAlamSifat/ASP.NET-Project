using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.ServiceManDTOs
{
    public class ServiceManOrderlistDTO
    {
        public int OrderId { get; set; }
        [Required]
        public string OrderFor { get; set; }
        [Required]
        public DateTime OrderTime { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}
