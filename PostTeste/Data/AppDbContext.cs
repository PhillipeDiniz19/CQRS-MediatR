﻿using Microsoft.EntityFrameworkCore;
using PostTeste.Entities;

namespace PostTeste.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Parabens> Parabens { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Post>()
                .HasMany(p => p.Comments)
                .WithOne(c => c.Post)
                .HasForeignKey(c => c.PostId);

            modelBuilder.Entity<Post>()
                .HasMany(p => p.ParabensList)
                .WithOne(pb => pb.Post)
                .HasForeignKey(pb => pb.PostId);
        }
    }
}
