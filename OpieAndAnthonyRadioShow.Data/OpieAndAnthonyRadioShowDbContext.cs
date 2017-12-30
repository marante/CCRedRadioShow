using System;
using Microsoft.EntityFrameworkCore;
using OpieAndAnthonyRadioShow.Data.Models;

namespace OpieAndAnthonyRadioShow.Data
{
    public class OpieAndAnthonyRadioShowDbContext : DbContext
    {
        public OpieAndAnthonyRadioShowDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<RadioShow> RadioShows { get; set; }
        public DbSet<RadioShowTag> RadioShowTags { get; set; }
    }
}
