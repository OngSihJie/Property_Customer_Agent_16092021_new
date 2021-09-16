using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Property_Customer_Agent_16092021.Models;

namespace Property_Customer_Agent_16092021.Data
{
    public class Property_Customer_Agent_16092021Context : DbContext
    {
        public Property_Customer_Agent_16092021Context (DbContextOptions<Property_Customer_Agent_16092021Context> options)
            : base(options)
        {
        }

        public DbSet<Property_Customer_Agent_16092021.Models.Agent> Agent { get; set; }

        public DbSet<Property_Customer_Agent_16092021.Models.Customer> Customer { get; set; }

        public DbSet<Property_Customer_Agent_16092021.Models.Property> Property { get; set; }
    }
}
