using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Model.Entities;

namespace ToDo.DAL.Concrete.Context.EntityTypeConfiguration
{
    class ToDoItemConfiguration : IEntityTypeConfiguration<ToDoItem>
    {
        public void Configure(EntityTypeBuilder<ToDoItem> builder)
        {

            builder.HasKey(a => a.ID);
            builder.Property(a => a.ID)
                .UseIdentityColumn();


            builder.Property(a => a.Subject)
                .HasMaxLength(250);


            builder.Property(a => a.Notes)
               .HasMaxLength(250);


            builder.Property(a => a.StartDate);


            builder.Property(a => a.EndDate);


            builder.Property(a => a.Status);


            builder.Property(a => a.PersonID);

            builder.HasOne(a => a.Person)
                 .WithMany(a => a.ToDoItems)
                 .HasForeignKey(a => a.PersonID);


        }
    }
}
