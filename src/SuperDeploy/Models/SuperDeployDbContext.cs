using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;

namespace SuperDeploy.Models
{
    public class SuperDeployDbContext : DbContext
    {
        public DbSet<Application> Applications { get; set; } 

        public SuperDeployDbContext()
        {
            
        }
    }
}
