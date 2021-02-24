using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace task_02.Models
{
    class BookShopDB: DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Geners { get; set; }
        public DbSet<AuthorBookGenreMap> AuthorBookGenreMaps { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = LAPTOP-R6T9OC7R\SQLEXPRESS; Database=BookStore;Trusted_Connection=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
              .HasData(new Author {AuthorID=1,AuthorName= "Sapkowski" });
            modelBuilder.Entity<Genre>()
             .HasData(new Genre {GenreID=1, GenreName="fantasy"}, new Genre {GenreID=2, GenreName="war film"}, new Genre { GenreID = 3, GenreName = "drama" });
            modelBuilder.Entity<Book>()
                .HasData(new Book {BookID=1,AuthorID=1,BookName= "Witcher:The Last Wish", BookYear=1993}, new Book { BookID = 2, AuthorID = 1, BookName = "The Snake", BookYear = 2009 });
            modelBuilder.Entity<AuthorBookGenreMap>()
                .HasData(new AuthorBookGenreMap { AuthorBookGenreMapID = 1, AuthorID = 1, BookID = 2, GenreID = 1 }, new AuthorBookGenreMap { AuthorBookGenreMapID = 2, AuthorID = 1, BookID = 2, GenreID = 2 });
            modelBuilder.Entity<AuthorBookGenreMap>()
                .HasData(new AuthorBookGenreMap { AuthorBookGenreMapID=3,AuthorID=1, BookID=2, GenreID=3 });
        }
    }
}
