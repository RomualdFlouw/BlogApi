using BlogModels.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogModels.Models
{
    public class DBContext : IdentityDbContext<User>
    {
        private static ModelBuilder _modelBuilder { get; set; }

        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {

        }

        public DbSet<Topic> Topic { get; set; }
        public DbSet<Category> Category { get; set; }
        //public DbSet<Post> Post { get; set; }
        //public DbSet<Comment> Comment { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;
            base.OnModelCreating(_modelBuilder);

            //composiet key definiëren voor tussentabel via de fluent API
            modelBuilder.Entity<TopicsSubbed>().HasKey(rr => new { rr.TopicID, rr.UserID });
            modelBuilder.Entity<TopicCategory>().HasKey(rr => new { rr.TopicID, rr.CategoryID });

            ModelBuilderExtensions.modelBuilder = _modelBuilder;

            ModelBuilderExtensions.Seed();

        }

    }
}
