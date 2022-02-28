using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoginAPI.Models
{
    public class LoginDetails
    {
        [Key]
        public int LoginId { get; set; }
        
        public string Username { get; set; }
        
        public string Password { get; set; }
        public int AccessLevel { get; set; }
        //FK EmployeeID
        //FK ArrangörID
        //FK SponsorID 

    }
}
