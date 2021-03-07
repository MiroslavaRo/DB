using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;


namespace task_03.Models
{
    public class BookStoreDB: DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<BookGenreMap> BookGenreMaps { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = LAPTOP-R6T9OC7R\SQLEXPRESS; Database = BookStoreDB; Trusted_Connection = True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
              .HasData(new Author { AuthorID = 1, AuthorName = "A. Sapkowski"});
            modelBuilder.Entity<Author>()
              .HasData(new Author { AuthorID = 2, AuthorName = "H.P. Lovecraft" });
            modelBuilder.Entity<Author>()
             .HasData(new Author { AuthorID = 3, AuthorName = "J.K. Rowling" });
            modelBuilder.Entity<Author>()
             .HasData(new Author { AuthorID = 4, AuthorName = "O. Wilde" });
            modelBuilder.Entity<Author>()
             .HasData(new Author { AuthorID = 5, AuthorName = "S. King" });

            modelBuilder.Entity<Book>()
            .HasData(new Book { BookID=1, AuthorID = 1, BookName= "Blood of Elves", BookYear= 1994});//fantasy
            modelBuilder.Entity<Book>()
            .HasData(new Book { BookID = 2, AuthorID = 1, BookName = "The Tower of Fools", BookYear = 2002 }); //Historical fantasy
            modelBuilder.Entity<Book>()
            .HasData(new Book { BookID = 3, AuthorID = 1, BookName = "Sword of Destiny", BookYear = 1992 }); //fantasy
            modelBuilder.Entity<Book>()
            .HasData(new Book { BookID = 4, AuthorID = 2, BookName = "The Call of Cthulhu", BookYear = 1928 });
            modelBuilder.Entity<Book>()
            .HasData(new Book { BookID = 5, AuthorID = 2, BookName = "At the Mountains of Madness", BookYear = 1931 });
            modelBuilder.Entity<Book>()
            .HasData(new Book { BookID = 6, AuthorID = 3, BookName = "Harry Potter and Philosopher's Stone", BookYear = 1997 });
            modelBuilder.Entity<Book>()
            .HasData(new Book { BookID = 7, AuthorID = 3, BookName = "Harry Potter and Chamber of Secrets", BookYear = 1998});
            modelBuilder.Entity<Book>()
            .HasData(new Book { BookID = 8, AuthorID = 3, BookName = "Harry Potter and Prisoner of Azkaban", BookYear = 1999 });
            modelBuilder.Entity<Book>()
            .HasData(new Book { BookID = 9, AuthorID = 3, BookName = "Harry Potter and Goblet of Fire", BookYear = 2000 });
            modelBuilder.Entity<Book>()
            .HasData(new Book { BookID = 10, AuthorID = 3, BookName = "Harry Potter and Order of the Phoenix", BookYear = 2003 });
            modelBuilder.Entity<Book>()
            .HasData(new Book { BookID = 11, AuthorID = 3, BookName = "Harry Potter and Half-Blood Prince", BookYear = 2005 });
            modelBuilder.Entity<Book>()
            .HasData(new Book { BookID = 12, AuthorID = 3, BookName = "Harry Potter and Deathly Hallows", BookYear = 2007 });
            modelBuilder.Entity<Book>()
          .HasData(new Book { BookID = 13, AuthorID = 5, BookName = "The Eyes of the Dragon", BookYear = 1984 }); //fantasy
            modelBuilder.Entity<Book>()
            .HasData(new Book { BookID = 14, AuthorID = 5, BookName = "Insomnia", BookYear = 1994 }); //horror, fantasy
            modelBuilder.Entity<Book>()
            .HasData(new Book { BookID = 15, AuthorID = 5, BookName = "The Green Mile", BookYear = 1996 }); //Dark Fantasy, Southern Gothic, Magic Realism
            modelBuilder.Entity<Book>()
            .HasData(new Book { BookID = 16, AuthorID = 4, BookName = "The Picture of Dorian Gray", BookYear = 1890 });


            modelBuilder.Entity<Genre>()
           .HasData(new Genre { GenreID=1, GenreName= "Philosophical fiction"});
            modelBuilder.Entity<Genre>()
          .HasData(new Genre { GenreID = 2, GenreName = "Fantasy" });
            modelBuilder.Entity<Genre>()
          .HasData(new Genre { GenreID = 3, GenreName = "Horror" });
            modelBuilder.Entity<Genre>()
          .HasData(new Genre { GenreID = 4, GenreName = "Historical fantasy" });
            modelBuilder.Entity<Genre>()
         .HasData(new Genre { GenreID = 5, GenreName = "Dark Fantasy" });
            modelBuilder.Entity<Genre>()
          .HasData(new Genre { GenreID = 6, GenreName = "Southern Gothic" });
            modelBuilder.Entity<Genre>()
          .HasData(new Genre { GenreID = 7, GenreName = "Magic Realism" });


            modelBuilder.Entity<BookGenreMap>()
          .HasData(new BookGenreMap { BookGenreMapID=1, GenreID=1, BookID=16});
            modelBuilder.Entity<BookGenreMap>()
         .HasData(new BookGenreMap { BookGenreMapID = 2, GenreID = 2, BookID = 1});
            modelBuilder.Entity<BookGenreMap>()
         .HasData(new BookGenreMap { BookGenreMapID = 3, GenreID = 2, BookID = 3 });
            modelBuilder.Entity<BookGenreMap>()
         .HasData(new BookGenreMap { BookGenreMapID = 4, GenreID = 2, BookID = 6 });
            modelBuilder.Entity<BookGenreMap>()
         .HasData(new BookGenreMap { BookGenreMapID = 5, GenreID = 2, BookID = 7 });
            modelBuilder.Entity<BookGenreMap>()
         .HasData(new BookGenreMap { BookGenreMapID = 6, GenreID = 2, BookID = 8 });
            modelBuilder.Entity<BookGenreMap>()
         .HasData(new BookGenreMap { BookGenreMapID = 7, GenreID = 2, BookID = 9 });
            modelBuilder.Entity<BookGenreMap>()
         .HasData(new BookGenreMap { BookGenreMapID = 8, GenreID = 2, BookID = 10 });
            modelBuilder.Entity<BookGenreMap>()
         .HasData(new BookGenreMap { BookGenreMapID = 9, GenreID = 2, BookID = 11});
            modelBuilder.Entity<BookGenreMap>()
         .HasData(new BookGenreMap { BookGenreMapID = 10, GenreID = 2, BookID = 12 });
            modelBuilder.Entity<BookGenreMap>()
         .HasData(new BookGenreMap { BookGenreMapID = 11, GenreID = 2, BookID = 13 });
            modelBuilder.Entity<BookGenreMap>()
         .HasData(new BookGenreMap { BookGenreMapID = 12, GenreID = 2, BookID = 14 });
            modelBuilder.Entity<BookGenreMap>()
         .HasData(new BookGenreMap { BookGenreMapID = 13, GenreID = 3, BookID = 4 });
            modelBuilder.Entity<BookGenreMap>()
         .HasData(new BookGenreMap { BookGenreMapID = 14, GenreID = 3, BookID = 5 });
            modelBuilder.Entity<BookGenreMap>()
         .HasData(new BookGenreMap { BookGenreMapID = 15, GenreID = 3, BookID = 14 });
            modelBuilder.Entity<BookGenreMap>()
         .HasData(new BookGenreMap { BookGenreMapID = 16, GenreID = 4, BookID = 2 });
            modelBuilder.Entity<BookGenreMap>()
         .HasData(new BookGenreMap { BookGenreMapID = 17, GenreID = 5, BookID =  15});
            modelBuilder.Entity<BookGenreMap>()
         .HasData(new BookGenreMap { BookGenreMapID = 18, GenreID = 6, BookID = 15 });
            modelBuilder.Entity<BookGenreMap>()
         .HasData(new BookGenreMap { BookGenreMapID = 19, GenreID = 7, BookID = 15 });
        }
    }
}
