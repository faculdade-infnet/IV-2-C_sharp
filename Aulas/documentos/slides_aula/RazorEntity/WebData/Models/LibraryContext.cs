using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace WebData.Models;

public partial class LibraryContext : DbContext
{
    public LibraryContext()
    {
    }

    public LibraryContext(DbContextOptions<LibraryContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Author> Authors { get; set; }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<Section> Sections { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasIndex(e => e.AuthorId, "IX_Books_AuthorId");

            entity.HasOne(d => d.Author).WithMany(p => p.Books).HasForeignKey(d => d.AuthorId);
        });

        modelBuilder.Entity<Section>(entity =>
        {
            entity.HasIndex(e => e.BookId, "IX_Sections_BookId");

            entity.HasOne(d => d.Book).WithMany(p => p.Sections).HasForeignKey(d => d.BookId);
        });

        OnModelCreatingPartial(modelBuilder);
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //optionsBuilder.UseLazyLoadingProxies();
    }
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
