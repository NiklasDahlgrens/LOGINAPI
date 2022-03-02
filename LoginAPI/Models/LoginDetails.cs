using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoginAPI.Models
{
    [Index(nameof(AccessLevel), nameof(UserId), IsUnique = true)]
    public class LoginDetails
    {
    
        public int Id { get; set; }
        
        public string Username { get; set; }
        
        public string Password { get; set; }
        public int AccessLevel { get; set; }
        public int UserId { get; set; }

        //[Index("IX_FirstAndSecond", 1, IsUnique = true)]
        //public int AccessLevel  { get; set; }

        //[Index("IX_FirstAndSecond", 2, IsUnique = true)]
        //public int UserId { get; set; }

    }
}
