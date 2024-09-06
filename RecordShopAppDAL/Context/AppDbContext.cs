using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using RechordShopApp.Concerete;
using RechordShopApp.Enum;
using Microsoft.EntityFrameworkCore;

namespace RecordShopAppDAL.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Admin> Admins { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-M89NHFE\\SQLEXPRESS;Database=RecordShopDb;Integrated Security=True;TrustServerCertificate=True;Encrypt=False");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            // Seed data for Admin
            var adminPasswordHash = "C4EDBC7C025A4BB0B47EEF39359710769C6684602731625F0B402066E722544E";
            modelBuilder.Entity<Admin>().HasData(new Admin
            {
                Id = 1,
                UserName = "AdminUser123", 
               
                Password = adminPasswordHash,
                CreateDate = DateTime.Now

            });

            // Seed data for Albums
            modelBuilder.Entity<Album>().HasData(
                new Album
                {
                    Id = 1,
                    AlbumName = "Thriller",
                    Artist = "Michael Jackson",
                    ReleaseDate = new DateTime(1982, 11, 30),
                    Price = 29.99m,
                    DisctountRate = 10,
                    Status = Status.OnSale,
                    Genre = Genre.Pop,
                    CreateDate = DateTime.Now

                },
                new Album
                {
                    Id = 2,
                    AlbumName = "Back in Black",
                    Artist = "AC/DC",
                    ReleaseDate = new DateTime(1980, 7, 25),
                    Price = 24.99m,
                    DisctountRate = 15,
                    Status = Status.OnSale,
                    Genre = Genre.Rock,
                    CreateDate = DateTime.Now

                },
                new Album
                {
                    Id = 3,
                    AlbumName = "The Dark Side of the Moon",
                    Artist = "Pink Floyd",
                    ReleaseDate = new DateTime(1973, 3, 1),
                    Price = 19.99m,
                    DisctountRate = 20,
                    Status = Status.Discontunied,
                    Genre = Genre.Rock,
                    CreateDate = DateTime.Now

                },
                new Album
                {
                    Id = 4,
                    AlbumName = "The Wall",
                    Artist = "Pink Floyd",
                    ReleaseDate = new DateTime(1979, 11, 30),
                    Price = 22.99m,
                    DisctountRate = 5,
                    Status = Status.OnSale,
                    Genre = Genre.Rock,
                    CreateDate = DateTime.Now

                },
                new Album
                {
                    Id = 5,
                    AlbumName = "Abbey Road",
                    Artist = "The Beatles",
                    ReleaseDate = new DateTime(1969, 9, 26),
                    Price = 27.99m,
                    DisctountRate = 12,
                    Status = Status.OnSale,
                    Genre = Genre.Rock,
                    CreateDate = DateTime.Now

                },
                new Album
                {
                    Id = 6,
                    AlbumName = "Hotel California",
                    Artist = "Eagles",
                    ReleaseDate = new DateTime(1976, 12, 8),
                    Price = 25.99m,
                    DisctountRate = 15,
                    Status = Status.OnSale,
                    Genre = Genre.Rock,
                    CreateDate = DateTime.Now

                },
                new Album
                {
                    Id = 7,
                    AlbumName = "Led Zeppelin IV",
                    Artist = "Led Zeppelin",
                    ReleaseDate = new DateTime(1971, 11, 8),
                    Price = 21.99m,
                    DisctountRate = 10,
                    Status = Status.OnSale,
                    Genre = Genre.Rock,
                    CreateDate = DateTime.Now

                },
                new Album
                {
                    Id = 8,
                    AlbumName = "Born to Run",
                    Artist = "Bruce Springsteen",
                    ReleaseDate = new DateTime(1975, 8, 25),
                    Price = 23.99m,
                    DisctountRate = 8,
                    Status = Status.OnSale,
                    Genre = Genre.Rock,
                    CreateDate = DateTime.Now

                },
                new Album
                {
                    Id = 9,
                    AlbumName = "Rumours",
                    Artist = "Fleetwood Mac",
                    ReleaseDate = new DateTime(1977, 2, 4),
                    Price = 24.99m,
                    DisctountRate = 10,
                    Status = Status.Discontunied,
                    Genre = Genre.Rock,
                    CreateDate = DateTime.Now

                },
                new Album
                {
                    Id = 10,
                    AlbumName = "Nevermind",
                    Artist = "Nirvana",
                    ReleaseDate = new DateTime(1991, 9, 24),
                    Price = 19.99m,
                    DisctountRate = 5,
                    Status = Status.OnSale,
                    Genre = Genre.Rock,
                    CreateDate = DateTime.Now

                },
                new Album
                {
                    Id = 11,
                    AlbumName = "Sgt. Pepper's Lonely Hearts Club Band",
                    Artist = "The Beatles",
                    ReleaseDate = new DateTime(1967, 5, 26),
                    Price = 26.99m,
                    DisctountRate = 10,
                    Status = Status.OnSale,
                    Genre = Genre.Rock,
                    CreateDate = DateTime.Now

                },
                new Album
                {
                    Id = 12,
                    AlbumName = "A Night at the Opera",
                    Artist = "Queen",
                    ReleaseDate = new DateTime(1975, 11, 21),
                    Price = 22.99m,
                    DisctountRate = 7,
                    Status = Status.OnSale,
                    Genre = Genre.Rock,
                    CreateDate = DateTime.Now

                },
                new Album
                {
                    Id = 13,
                    AlbumName = "The Joshua Tree",
                    Artist = "U2",
                    ReleaseDate = new DateTime(1987, 3, 9),
                    Price = 24.99m,
                    DisctountRate = 12,
                    Status = Status.OnSale,
                    Genre = Genre.Rock,
                    CreateDate = DateTime.Now

                },
                new Album
                {
                    Id = 14,
                    AlbumName = "Who's Next",
                    Artist = "The Who",
                    ReleaseDate = new DateTime(1971, 8, 14),
                    Price = 21.99m,
                    DisctountRate = 10,
                    Status = Status.Discontunied,
                    Genre = Genre.Rock,
                    CreateDate = DateTime.Now

                },
                new Album
                {
                    Id = 15,
                    AlbumName = "Purple Rain",
                    Artist = "Prince",
                    ReleaseDate = new DateTime(1984, 6, 25),
                    Price = 22.99m,
                    DisctountRate = 8,
                    Status = Status.OnSale,
                    Genre = Genre.Pop,
                    CreateDate = DateTime.Now

                },
                new Album
                {
                    Id = 16,
                    AlbumName = "The Rise and Fall of Ziggy Stardust and the Spiders from Mars",
                    Artist = "David Bowie",
                    ReleaseDate = new DateTime(1972, 6, 16),
                    Price = 20.99m,
                    DisctountRate = 15,
                    Status = Status.OnSale,
                    Genre = Genre.Rock,
                    CreateDate = DateTime.Now

                },
                new Album
                {
                    Id = 17,
                    AlbumName = "Sticky Fingers",
                    Artist = "The Rolling Stones",
                    ReleaseDate = new DateTime(1971, 4, 23),
                    Price = 23.99m,
                    DisctountRate = 10,
                    Status = Status.OnSale,
                    Genre = Genre.Rock,
                    CreateDate = DateTime.Now

                },
                new Album
                {
                    Id = 18,
                    AlbumName = "The Velvet Underground & Nico",
                    Artist = "The Velvet Underground",
                    ReleaseDate = new DateTime(1967, 3, 12),
                    Price = 21.99m,
                    DisctountRate = 12,
                    Status = Status.Discontunied,
                    Genre = Genre.Rock,
                    CreateDate = DateTime.Now

                },
                new Album
                {
                    Id = 19,
                    AlbumName = "OK Computer",
                    Artist = "Radiohead",
                    ReleaseDate = new DateTime(1997, 5, 21),
                    Price = 22.99m,
                    DisctountRate = 8,
                    Status = Status.OnSale,
                    Genre = Genre.Rock,
                    CreateDate = DateTime.Now

                },
                new Album
                {
                    Id = 20,
                    AlbumName = "The Miseducation of Lauryn Hill",
                    Artist = "Lauryn Hill",
                    ReleaseDate = new DateTime(1998, 8, 25),
                    Price = 24.99m,
                    DisctountRate = 10,
                    Status = Status.OnSale,
                    Genre = Genre.Pop,
                    CreateDate = DateTime.Now
                }
            );
        }

    }
}
