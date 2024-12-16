using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Blazor213FinalWebAPP.Models;

namespace _213FinalWebAPP.Data
{
    public class _213FinalWebAPPContext : DbContext
    {
        public _213FinalWebAPPContext (DbContextOptions<_213FinalWebAPPContext> options)
            : base(options)
        {
        }

        public DbSet<Blazor213FinalWebAPP.Models.Dog> Dog { get; set; } = default!;
        public DbSet<Blazor213FinalWebAPP.Models.CreateAccount> CreateAccount { get; set; } = default!;
    }
}
