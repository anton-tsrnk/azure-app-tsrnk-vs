﻿using Microsoft.EntityFrameworkCore;

namespace azure_app_tsrnk.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
                
        }
    }
}
