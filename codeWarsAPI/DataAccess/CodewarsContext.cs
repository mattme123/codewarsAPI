using codeWarsAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace codeWarsAPI.DataAccess
{
    public class CodewarsContext : DbContext
    {
        public CodewarsContext(DbContextOptions<CodewarsContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Kata> Katas { get; set; }
        public DbSet<Cohort> Cohorts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
