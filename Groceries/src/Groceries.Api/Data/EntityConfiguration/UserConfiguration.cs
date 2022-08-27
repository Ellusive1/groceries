using Groceries.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Groceries.Api.Data.EntityConfiguration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> b)
        {
            b.HasKey(l => l.Id);

            b.Property(l => l.Id)
                .ValueGeneratedOnAdd();

            b.ToTable("Users");

            b.Property(l => l.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            b.Property(l => l.LastName)
               .IsRequired()
               .HasMaxLength(50);

            b.Property(l => l.Email)
               .IsRequired()
               .HasMaxLength(50);

            b.HasMany(u => u.Groceries)
                .WithOne(g => g.User)
                .HasForeignKey(g => g.UserId);

        }
    }
}
