using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCAssigment1.Models;

namespace MVCAssigment1.Data
{
    public class MVCAssigment1Context : DbContext
    {
        public MVCAssigment1Context (DbContextOptions<MVCAssigment1Context> options)
            : base(options)
        {
        }

        public DbSet<MVCAssigment1.Models.Student> Student { get; set; } = default!;
    }
}
