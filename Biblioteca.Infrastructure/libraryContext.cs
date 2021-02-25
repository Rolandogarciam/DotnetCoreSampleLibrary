using System;
using System.Configuration;
using System.Collections.Generic;
using Biblioteca.Domain.Models;
using Microsoft.EntityFrameworkCore;


namespace Biblioteca.Infrastructure
{
    /// <summary>
    /// Class for context EF.
    /// </summary>
    public class libraryContext : DbContext
    {

        public libraryContext(DbContextOptions options) : base (options)
        {
        }
        /// <summary>
        /// DbSet: autores.
        /// </summary>
        public DbSet<autor> autores { get; set; }

        /// <summary>
        /// DbSet: libros.
        /// </summary>
        public DbSet<libro> libros { get; set; }

        /// <summary>
        /// DbSet: editoriales.
        /// </summary>
        public DbSet<editorial> editoriales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Relationship many to many between autores and libros.
            modelBuilder.Entity<autor>()
            .HasMany(p => p.libros)
            .WithMany(p => p.autores)
            .UsingEntity<Dictionary<string, object>>(
            "autores_has_libros",
            j => j
                .HasOne<libro>()
                .WithMany()
                .HasForeignKey("libros_ISBN")
                .HasConstraintName("libros_fk")
                .OnDelete(DeleteBehavior.Cascade),
            j => j
                .HasOne<autor>()
                .WithMany()
                .HasForeignKey("autores_id")
                .HasConstraintName("autores_fk")
                .OnDelete(DeleteBehavior.ClientCascade));

            // Relationship one to many between libros and editoriales.
            modelBuilder.Entity<libro>()
                .HasOne(p => p.editorial)
                .WithMany(p => p.libros)
                .HasForeignKey(p => p.editorialId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
