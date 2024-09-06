using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using RechordShopApp.Concerete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RecordShopAppDAL.Configuration
{
    public class AlbumConfiguration : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.ToTable("Albums");

            builder.Property(x => x.AlbumName)
                .IsRequired()
                .HasColumnType("nvarchar(100)");

            builder.Property(x => x.Artist)
                .IsRequired()
                .HasColumnType("Nvarchar(100)");

            builder.Property(x => x.ReleaseDate)
                .IsRequired();

            builder.Property(x => x.Price)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            builder.Property(x => x.DisctountRate )
                .HasColumnType("decimal(5,2)");

            builder.Property(x => x.Status)
                .IsRequired()
                .HasConversion<string>();

            builder.Property(x => x.CreateDate)
                .IsRequired();

            builder.Property(x => x.DropDate)
                .IsRequired(false);
        }
    }
}
