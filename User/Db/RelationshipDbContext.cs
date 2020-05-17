using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using User.Models;

namespace User.Db
{
    public class RelationshipDbContext : DbContext
    {
            public RelationshipDbContext(DbContextOptions<RelationshipDbContext> options)
                : base(options)
            {
        }

            public DbSet<Parent> Parents { get; set; }
            public DbSet<Child> Children { get; set; }


    }
}
