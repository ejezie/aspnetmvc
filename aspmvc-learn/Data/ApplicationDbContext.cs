using System;
using Microsoft.EntityFrameworkCore;

namespace aspmvc_learn.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)

        {

        }

        public DbSet<Models.Item> Items { get; set; }

    }
}
