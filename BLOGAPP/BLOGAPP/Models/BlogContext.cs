using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BLOGAPP.Models
{
    // veritabanının kendisi olarak düşün
    public class BlogContext:DbContext
    {
       public BlogContext():base("blogDb")
        {
            Database.SetInitializer(new BlogInitializer());

        }

        // burada veritabanımza iki tane tablo eklemiş olduk 
        // tipleri dbset

        public DbSet<Blog> Bloglar { get; set; }
        public DbSet<Category> Kategoriler { get; set; }

    }
}