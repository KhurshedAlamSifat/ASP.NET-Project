using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.CustomerDTOs
{
    public class CustomerFuelOrderDTO : CustomerDTO
    {
        public List<FuelOrderDTO> FuelOrders { get; set; }

        public CustomerFuelOrderDTO()
        {
            FuelOrders = new List<FuelOrderDTO>();
        }
    }
}
