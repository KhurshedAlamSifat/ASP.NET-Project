using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.DeliveryManDTOs
{
    public class DeliveryManDTO
    {
       
        public string Username { get; set; }
        [Required]
        
        public string Name { get; set; }
        [Required]
        //[StringLength(100)]
        public string Gender { get; set; }
        [Required]
        public DateTime Dob { get; set; }
        [Required]
       
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
