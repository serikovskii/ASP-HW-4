namespace WebApplication5.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using WebApplication5.Models;

    public class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }
        
        public DbSet<Article> News { get; set; }
    }

}