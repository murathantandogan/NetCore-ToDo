using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.DAL.Concrete.Context.EntityTypeConfiguration;
using ToDo.Model.Entities;

namespace ToDo.DAL.Concrete.Context
{
    class ToDoDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-7FHMHK2;Database=ToDoV2Db;Trusted_Connection=True;");
        }

        public DbSet<Person> People { get; set; }
        public DbSet<ToDoItem> ToDoItems { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new PersonConfiguration());

            modelBuilder.ApplyConfiguration(new ToDoItemConfiguration());


        }




    }
}
