using Groceries.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Groceries.Api.Data.EntityConfiguration
{
    public class GroceryConfiguration : IEntityTypeConfiguration<Grocery>
    {
        public void Configure(EntityTypeBuilder<Grocery> b)
        {
            b.HasKey(l => l.Id);

            b.Property(l => l.Id)
                .ValueGeneratedOnAdd();

            b.ToTable("Groceries");

            b.Property(l => l.Name)
                .IsRequired()
                .HasMaxLength(200);

        }
    }
}
