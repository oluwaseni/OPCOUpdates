using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OPCOUpdates.Models;

namespace OPCOUpdates.Data
{
    public class OPCOUpdatesContext : DbContext
    {
        public OPCOUpdatesContext (DbContextOptions<OPCOUpdatesContext> options)
            : base(options)
        {
        }

        public DbSet<OPCOUpdates.Models.Department> Department { get; set; }

        public DbSet<OPCOUpdates.Models.Project> Project { get; set; }

        public DbSet<OPCOUpdates.Models.Theme> Theme { get; set; }
    }
}
