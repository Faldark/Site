using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MyOwnSite.Interfaces;
using MyOwnSite.Models;

namespace MyOwnSite
{
    public class UserContext : DbContext, IUserContext
    {
        //public UserContext()
        //{
        //    Database.SetInitializer<UserContext>(new DropCreateDatabaseAlways<UserContext>());

        //}




        public DbSet<User> Users { get; set; }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Comment>()
                .HasRequired<Post>(s => s.Post)
                .WithMany(s => s.Comments)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Comment>()
                .HasRequired<User>(s => s.User)
                .WithMany(s => s.Comments)
                .WillCascadeOnDelete(false);


            //modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();


        }
    }
}