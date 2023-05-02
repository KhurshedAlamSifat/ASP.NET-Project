using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.CustomerDTOs
{
    public class CustomerOrderDTO : CustomerDTO
    {
        public List<OrderDTO> Orders { get; set; }

        public CustomerOrderDTO() 
        {
            Orders = new List<OrderDTO>();
        }

    }
}
