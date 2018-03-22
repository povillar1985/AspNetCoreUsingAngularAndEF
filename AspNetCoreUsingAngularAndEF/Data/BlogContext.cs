using AspNetCoreUsingAngularAndEF.Data.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreUsingAngularAndEF.Data
{
    public class BlogContext : DbContext
    {
        protected BlogContext(DbContextOptions<BlogContext> options):base(options)
        {
        }

        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<Blog>().ToTable(typeof(Blog).Name);
        //    modelBuilder.Entity<Comment>().ToTable(typeof(Comment).Name);

        //    //modelBuilder.Entity<Blog>()
        //    //    .HasMany(x => x.Comments)
        //    //    .WithOne(x=>x.Blog)
        //    //    .HasForeignKey(x=>x.BlogId)
        //    //    .OnDelete(DeleteBehavior.Cascade);                
        //}
    }
}
