using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Message
    {
           [Key]
           public int MsgID { get; set; }   
           public string Message_from
                {
                   get; 
                   set;
                 }
           public string Messages { get; set; }
    }
}
