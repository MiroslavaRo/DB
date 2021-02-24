using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace task02.Models
{
    public class BookShopDB: DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Generes { get; set; }
        public DbSet<BookGenreMap> BookGenreMaps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = LAPTOP-R6T9OC7R\SQLEXPRESS; Database=BookStore;Trusted_Connection=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
               .HasData(new Author {AuthorID=1,AuthorName="Sapkowski"});
            modelBuilder.Entity<Book>()
                .HasData(new Book { BookID = 1, BookName = "The Last Wish", AuthorID=1,BookYear=1993});
            modelBuilder.Entity<Genre>()
                .HasData(new Genre {GenreID=1,GenreName="fantasy"});
            modelBuilder.Entity<BookGenreMap>()
                .HasData(new BookGenreMap { BookGenreMapID = 1, BookID = 1, GenreID = 1 });
            modelBuilder.Entity<Book>().Property(a => a.BookYear).HasColumnType("int").HasMaxLength(4);
            modelBuilder.Entity<Book>()
               .HasData(new Book { BookID = 2, BookName = "The Snake", AuthorID = 1, BookYear = 2009 });
            modelBuilder.Entity<Genre>()
               .HasData(new Genre { GenreID = 2, GenreName = "war film" });
            modelBuilder.Entity<BookGenreMap>()
                .HasData(new BookGenreMap { BookGenreMapID = 2, BookID = 2, GenreID = 1, Book = "The Snake", Genre = "fantasy" });
            modelBuilder.Entity<BookGenreMap>()
            .HasData(new BookGenreMap { BookGenreMapID = 3, BookID = 2, GenreID = 2, Book = "The Snake", Genre = "war film" });


            modelBuilder.Entity<Book>()
              .HasData(new Book { BookID = 3, BookName = "Harry Potter", AuthorID = 2, BookYear = 1997 });
            modelBuilder.Entity<Genre>()
               .HasData(new Genre { GenreID = 3, GenreName = "drama" });
            modelBuilder.Entity<BookGenreMap>()
                .HasData(new BookGenreMap { BookGenreMapID = 4, BookID = 3, GenreID = 1, Book = "Harry Potter", Genre = "fantasy" });
            modelBuilder.Entity<BookGenreMap>()
            .HasData(new BookGenreMap { BookGenreMapID = 5, BookID = 2, GenreID = 2, Book = "Harry Potter", Genre = "drama" });

        }
    }
}
