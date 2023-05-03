using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.ServiceManDTOs
{
    public class ServiceManHistoryDTO
    {
        public int Id { get; set; }
        [Required]
        public string Product { get; set; }
        [Required]
        public string SupplierName { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}
