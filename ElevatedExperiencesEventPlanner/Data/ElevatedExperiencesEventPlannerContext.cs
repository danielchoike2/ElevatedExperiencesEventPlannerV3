using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ElevatedExperiencesEventPlanner.Models;

namespace ElevatedExperiencesEventPlanner.Data
{
    public class ElevatedExperiencesEventPlannerContext : DbContext
    {
        public ElevatedExperiencesEventPlannerContext (DbContextOptions<ElevatedExperiencesEventPlannerContext> options)
            : base(options)
        {
        }

        public DbSet<ElevatedExperiencesEventPlanner.Models.OfferedService> OfferedService { get; set; } = default!;

        public DbSet<ElevatedExperiencesEventPlanner.Models.Schedule> Schedule { get; set; } = default!;
    }
}
