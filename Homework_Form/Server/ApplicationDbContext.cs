using Homework_Form.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework_Form.Server
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base (options)       
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Class1>().HasKey(x => new { x.ID });

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Class1> Class1Set { get; set; }

    }
}
