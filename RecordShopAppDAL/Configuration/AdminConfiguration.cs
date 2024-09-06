using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RechordShopApp.Concerete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RecordShopAppDAL.Configuration
{
    public class AdminConfiguration : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.ToTable("Admins");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.UserName)
            .IsRequired()
            .HasColumnType("Nvarchar(50)");

            builder.Property(a => a.Password)
                .IsRequired();

            builder.HasIndex(a => a.Password)
                .IsUnique();

            builder.Property(a => a.CreateDate)
                .IsRequired();

            builder.Property(a=> a.DropDate)
                .IsRequired();
        }

    }
}
