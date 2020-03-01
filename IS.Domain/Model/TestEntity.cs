using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace IS.Domain.Model
{
    public class TestEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class Context : DbContext
    {
        public Context()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string ConnectionSting = "Data Source=Test.db";
            optionsBuilder.UseSqlite(ConnectionSting);
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<TestEntity> Products { get; set; }

    }
}
