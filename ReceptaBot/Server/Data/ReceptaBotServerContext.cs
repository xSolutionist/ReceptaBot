using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReceptaBot.Shared.Models;

namespace ReceptaBot.Server.Data
{
    public class ReceptaBotServerContext : DbContext
    {
        public ReceptaBotServerContext (DbContextOptions<ReceptaBotServerContext> options)
            : base(options)
        {
        }

        public DbSet<ReceptaBot.Shared.Models.Recipe> Recipe { get; set; }
    }
}
