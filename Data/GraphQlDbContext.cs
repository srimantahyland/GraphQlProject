using GraphQlProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQlProject.Data
{
    public class GraphQlDbContext : DbContext
    {
        public GraphQlDbContext(DbContextOptions<GraphQlDbContext> options): base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
