using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginAPI.Models
{
    public class LoginDetailsContext : DbContext
    {
        public DbSet<LoginDetails> LoginDetails { get; set; }
        public LoginDetailsContext(DbContextOptions options) : base(options)
        {

        }

    }   
}
