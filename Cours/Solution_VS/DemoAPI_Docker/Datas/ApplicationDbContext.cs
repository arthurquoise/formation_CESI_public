﻿using DemoAPI_Docker.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoAPI_Docker.Datas
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Dog> Dogs { get; set; }
        public DbSet<Master> Masters { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Account> Accounts { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}
