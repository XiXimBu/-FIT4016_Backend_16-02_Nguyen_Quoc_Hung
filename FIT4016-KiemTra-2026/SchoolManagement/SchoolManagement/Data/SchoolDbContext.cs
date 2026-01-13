using Microsoft.EntityFrameworkCore;
using SchoolManagement.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace SchoolManagement.Data
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options)
               : base(options)
        {
        }
        public DbSet<School> Schools { get; set; }
        public DbSet<Student> Students { get; set; }


    }
}
