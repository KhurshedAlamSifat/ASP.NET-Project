using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class DeliveryMan
    {
        [Key]
        public string Username { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(100)]
        public string Gender { get; set; }
        [Required]
        public DateTime Dob { get; set; }
        [Required]
        [StringLength(100)]
        public string Email { get; set; }
        [Required]
        [StringLength(100)]
        public string Phone { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string Password { get; set; }

        public virtual ICollection<FuelOrder> FuelOrders { get; set; }
        public DeliveryMan()
        {
            FuelOrders = new List<FuelOrder>();
        }
    }
}
