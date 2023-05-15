using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.AdminDTOs
{
    public  class WorkerLocationDTO
    {
        public string username { get; set; }
        [Required]
        public string password { get; set; }
        //
        [Required]
        public double latitude { get; set; }
        [Required]
        public double longitude { get; set; }
    }
}
