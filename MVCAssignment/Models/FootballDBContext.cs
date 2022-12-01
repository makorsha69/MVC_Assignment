using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAssignment.Models
{
    public class FootballDBContext : DbContext 
    {
        public FootballDBContext(DbContextOptions<FootballDBContext> options) : base(options)
        {

        }
        public DbSet<FootballLeague> FootballLeagues { get; set; }
    }
}
