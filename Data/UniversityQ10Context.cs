using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UniversityQ10.Models;

namespace UniversityQ10.Data
{
    public class UniversityQ10Context : DbContext
    {
        public UniversityQ10Context(DbContextOptions<UniversityQ10Context> options)
            : base(options)
        {
        }

        public DbSet<Student> Student { get; set; } = default!;
        public DbSet<Course> Course { get; set; } = default!;
    }
}