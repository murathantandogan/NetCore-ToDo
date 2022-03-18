using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using ToDo.Model.Entities;

namespace ToDo.DAL.Concrete.Context.EntityTypeConfiguration
{
    class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasKey(a => a.ID);

            builder.Property(a => a.ID)
                .UseIdentityColumn();

            builder.Property(a => a.Name)
                .HasMaxLength(100)
                .IsRequired();

           

        }
    }
}
